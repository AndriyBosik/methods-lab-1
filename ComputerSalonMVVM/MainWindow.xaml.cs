using ComputerSalonMVVM.ViewModels;
using System.Windows;

using ComputerSalonMVVM.Pages;

namespace ComputerSalonMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FrameLoaded(object sender, RoutedEventArgs e)
        {
            (DataContext as MainViewModel).Navigation.NavigateTo(PageType.HomePage);
        }
    }
}
