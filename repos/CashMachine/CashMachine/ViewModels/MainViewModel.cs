using CashMachine.aWPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Text;
using static CashMachine.aWPF.State.Navigators.INavigator;

namespace CashMachine.aWPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public INavigator Navigator { get; set; } = new Navigator(); 
        /*
        public MainViewModel(INavigator navigator)
        {
            Navigator = navigator;

            Navigator.UpdateCurrentViewModelCommand.Execute(ViewType.Home);
        }*/
    }
}
