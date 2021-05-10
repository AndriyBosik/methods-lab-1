using ApplicationLogic.Handlers;
using ApplicationLogic.Interfaces;
using ApplicationLogic.Services;
using ComputerSalonMVVM.Abstraction;
using ComputerSalonMVVM.ViewModels;
using DataAccess;
using DataAccess.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVVMModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ComputerSalonMVVM.Services
{
    class ServiceRegister
    {
        public IServiceProvider ServiceProvider
        { get; set; }

        public ServiceCollection Services
        { get; set; }

        public void Register(INavigationService navigationService)
        {
            Services = new ServiceCollection();

            Services.AddDbContext<ComputerSalonContext>(options =>
                options.UseNpgsql(ConfigurationManager.ConnectionStrings["ComputerSalonDB"].ConnectionString));
            
            Services.AddSingleton<IUnitOfWork, UnitOfWork>();
            Services.AddSingleton<IServiceProvider>(x => ServiceProvider);
            Services.AddSingleton<INavigationService>(x => navigationService);
            Services.AddSingleton<SystemBlockComponents>();

            Services.AddTransient<IComputerService, ComputerService>();

            Services.AddSingleton<ISystemBlockHandler, SystemBlockHandler>();
            
            Services.AddTransient<ISystemBlockService, SystemBlockService>();
            Services.AddTransient<ITypeService, TypeService>();
            Services.AddTransient<SystemBlockComponentsViewModel>();
            Services.AddTransient<HomePageViewModel>();
            Services.AddTransient<CollectedViewModel>();
            Services.AddTransient<SystemBlockViewModel>();
            Services.AddTransient<MainViewModel>();

            ServiceProvider = Services.BuildServiceProvider();
        }
    }
}
