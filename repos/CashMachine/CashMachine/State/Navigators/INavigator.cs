using CashMachine.aWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CashMachine.aWPF.State.Navigators
{
    public interface INavigator
    {
 

        ViewModelBase CurrentViewModel { get; set; }
        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
