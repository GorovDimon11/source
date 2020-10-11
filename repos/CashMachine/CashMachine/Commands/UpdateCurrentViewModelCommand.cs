using CashMachine.aWPF.State.Navigators;
using CashMachine.aWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using static CashMachine.aWPF.State.Navigators.INavigator;

namespace CashMachine.aWPF.Commands
{
    class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly INavigator _navigator;
        //private readonly IRootCashMachineViewModelFactory _viewModelFactory;

        public UpdateCurrentViewModelCommand(INavigator navigator/*, IRootCashMachineViewModelFactory viewModelFactory*/)
        {
            _navigator = navigator;
           // _viewModelFactory = viewModelFactory;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                switch (viewType)
                {
                    case ViewType.SeniorHome:
                        _navigator.CurrentViewModel = new SeniorHomeModel();
                        break;
                    case ViewType.SeniorViewAllUsers:
                        _navigator.CurrentViewModel = new SeniorUsersModel();
                        break;
                   
                    case ViewType.SeniorXrecord:
                        break;
                    case ViewType.SeniorZrecord:
                        break;
                    default:
                        break;
                }

                //_navigator.CurrentViewModel = _viewModelFactory.CreateViewModel(viewType);


            }
        }
    }
}
