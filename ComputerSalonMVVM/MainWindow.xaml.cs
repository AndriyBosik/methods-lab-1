using ComputerSalonMVVM.ViewModels;
using System.Windows;

namespace ComputerSalonMVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(SystemBlockViewModel vm)
        {
            InitializeComponent();

            DataContext = vm;
        }
    }
}
