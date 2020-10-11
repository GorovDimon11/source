using CashMachine.aWPF.Commands;
using CashMachine.aWPF.Models;
using CashMachine.aWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CashMachine.aWPF.State.Navigators
{
    class Navigator : ObservableObject, INavigator 
    {
        private ViewModelBase _currentViewModel;
        public ViewModelBase CurrentViewModel {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
/*
        public Navigator(IRootCashMachineViewModelFactory viewModelFactory)
        {
            UpdateCurrentViewModelCommand = new UpdateCurrentViewModelCommand(this, viewModelFactory);
        }*/
    }
}
