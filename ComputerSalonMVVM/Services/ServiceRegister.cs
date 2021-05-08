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

            Services.AddTransient<IComputerService, ComputerService>();
            Services.AddTransient<ISystemBlockHandler, SystemBlockHandler>();
            Services.AddTransient<ISystemBlockService, SystemBlockService>();
            Services.AddTransient<ITypeService, TypeService>();
            Services.AddSingleton<IUnitOfWork, UnitOfWork>();

            Services.AddDbContext<ComputerSalonContext>(options =>
                options.UseNpgsql("Host=localhost;Port=5432;Database=ComputerSalonEAV;Username=postgres;Password=postgres"));

            Services.AddTransient<INavigationService>(x => navigationService);
            Services.AddTransient<SystemBlockComponents>();
            
            Services.AddTransient<SystemBlockComponentsViewModel>();
            Services.AddTransient<HomePageViewModel>();
            Services.AddTransient<CollectedViewModel>();
            Services.AddTransient<SystemBlockViewModel>();
            Services.AddTransient<MainViewModel>();

            ServiceProvider = Services.BuildServiceProvider();
        }
    }
}
