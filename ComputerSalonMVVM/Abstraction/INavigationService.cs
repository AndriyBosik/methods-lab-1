using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

using ComputerSalonMVVM.Pages;

namespace ComputerSalonMVVM.Abstraction
{
    interface INavigationService
    {
        public PageType CurrentPageKey { get; }

        public void Configure(PageType key, Uri pageType);

        public void GoBack();

        public void NavigateTo(PageType key);

        public void NavigateTo(PageType key, object parameter);

    }
}
