using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using ComputerSalonMVVM.ViewModels;
using Models;

namespace ComputerSalonMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SystemBlockViewModel vm;

        public MainWindow()
        {
            InitializeComponent();

            vm = (SystemBlockViewModel)DataContext;
        }

        private void ComponentsChanged(object sender, EventArgs args)
        {
            vm.SystemBlock.Components.Clear();

            for (Int32 i = 0; i < icComponents.Items.Count; i++)
            {
                var container = icComponents.ItemContainerGenerator.ContainerFromIndex(i);

                var lb = VisualTreeHelper.GetChild(container, 0) as ListBox;

                foreach (SystemComponentBase selected in lb.SelectedItems)
                {
                    vm.SystemBlock.Components.Add(selected);
                }
            }
        }
    }
}
