﻿using System;
using System.Collections.Generic;
using System.Text;

using Models;

using ApplicationLogic.Interfaces;

namespace ComputerSalon.Abstraction
{
    interface ISystemBlockView
    {
        event Action ViewLoaded;
        event Action QuitButtonClicked;
        event Action CheckButtonClicked;

        void ShowSuccessMessage(String title, String message);

        void ShowErrorMessage(String title, String message);

        void Shutdown();

        void ShowComponents<T>(IList<T> components) where T: SystemComponentBase;

        IList<SystemComponentBase> GetSelectedComponents();
    }
}
