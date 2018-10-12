using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using TimeLife.Core.ViewModels;

namespace TimeLife.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            //Mvx.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<MainViewModel>();
        }
    }
}
