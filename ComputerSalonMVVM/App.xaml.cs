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
using Microsoft.EntityFrameworkCore;

namespace ComputerSalonMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
    }
}
