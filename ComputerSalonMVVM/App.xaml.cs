using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;

using DataAccess;
using DataAccess.Abstraction;

using ApplicationLogic.Interfaces;
using ApplicationLogic.Services;
using ApplicationLogic.Handlers;

using MVVMModels;

using ComputerSalonMVVM.ViewModels;

namespace ComputerSalonMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<IComputerService, ComputerService>();
            services.AddSingleton<ISystemBlockHandler, SystemBlockHandler>();
            services.AddSingleton<ISystemBlockService, SystemBlockService>();
            services.AddSingleton<ITypeService, TypeService>();
            services.AddSingleton<IUnitOfWork, UnitOfWork>();

            services.AddDbContext<ComputerSalonContext>();
            services.AddSingleton<SystemBlockComponents>();
            services.AddSingleton<SystemBlockViewModel>();
            services.AddSingleton<MainWindow>();
        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            MainWindow mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

    }
}
