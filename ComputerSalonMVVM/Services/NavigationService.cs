using ComputerSalonMVVM.Abstraction;
using ComputerSalonMVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

using ComputerSalonMVVM.Pages;
using Models;
using System.Windows.Navigation;

namespace ComputerSalonMVVM.Services
{
    class NavigationService : ViewModelBase, INavigationService
    {
        private readonly IDictionary<PageType, Uri> pagesByKey;
        private readonly IList<PageType> history;
        private PageType currentPageKey;

        public PageType CurrentPageKey
        {
            get => currentPageKey;
            
            private set
            {
                if (currentPageKey == value) return;

                currentPageKey = value;
                OnPropertyChanged(nameof(CurrentPageKey));
            }
        }

        public NavigationService()
        {
            pagesByKey = new Dictionary<PageType, Uri>();
            history = new List<PageType>();
        }

        public void Configure(PageType key, Uri pageType)
        {
            lock (pagesByKey)
            {
                if (pagesByKey.ContainsKey(key))
                {
                    pagesByKey[key] = pageType;
                }
                else
                {
                    pagesByKey.Add(key, pageType);
                }
            }
        }

        public void GoBack()
        {
            if (history.Count > 1)
            {
                history.RemoveAt(history.Count - 1);
                PageType destination = history.Last();
                history.RemoveAt(history.Count - 1);
                NavigateTo(destination, null);
            }
        }

        public void NavigateTo(PageType key)
        {
            NavigateTo(key, null);
        }

        public void NavigateTo(PageType key, object parameter)
        {
            lock (pagesByKey)
            {
                if (!pagesByKey.ContainsKey(key))
                {
                    return;
                }
                Frame frame = GetDescendantFromName(Application.Current.MainWindow, "ContentFrame") as Frame;
                if (frame != null)
                {
                    frame.Source = pagesByKey[key];
                    FrameworkElement content = frame.Content as FrameworkElement;
                    if (content != null)
                    {
                        this.Parameter = parameter;
                        frame.LoadCompleted -= PassParameter;
                        frame.LoadCompleted += PassParameter;
                    }
                }
                history.Add(key);
                CurrentPageKey = key;
            }
        }

        private void PassParameter(object sender, NavigationEventArgs e)
        {
            Frame frame = sender as Frame;
            if (frame != null)
            {
                FrameworkElement content = frame.Content as FrameworkElement;
                if (content != null)
                {
                    ViewModelBase vm = content.DataContext as ViewModelBase;
                    vm.Parameter = this.Parameter;
                }
            }
        }

        private FrameworkElement GetDescendantFromName(DependencyObject parent, string name)
        {
            Int32 count = VisualTreeHelper.GetChildrenCount(parent);
            
            if (count < 1)
                return null;

            for (Int32 i = 0; i < count; i++)
            {
                if (VisualTreeHelper.GetChild(parent, i) is FrameworkElement frameworkElement)
                {
                    if (frameworkElement.Name == name)
                    {
                        return frameworkElement;
                    }

                    frameworkElement = GetDescendantFromName(frameworkElement, name);
                    if (frameworkElement != null)
                    {
                        return frameworkElement;
                    }
                }
            }
            return null;
        }
    }
}
