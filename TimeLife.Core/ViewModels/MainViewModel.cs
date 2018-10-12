using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TimeLife.Core.ViewModels
{
    public class MainViewModel: MvxViewModel
    {

        public override Task Initialize()
        {
            TestValue = "Test String From View Model";
            return base.Initialize();

        }
        private string _testValue;
        public string TestValue
        {
            get => _testValue;
            set
            {
                _testValue = value;
                RaisePropertyChanged(() => TestValue);
            }
        }

    }
}
