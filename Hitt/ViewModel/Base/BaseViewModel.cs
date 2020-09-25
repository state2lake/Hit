using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Hitt.Services;

namespace Hitt.ViewModel.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        protected readonly INavigationService NavigationService;
        protected bool SetProperty<T>(ref T field, T value,[CallerMemberName]string name = null)
        {
            bool propertyChanged = false;

            if(!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                OnPropertyChanged(name);
                propertyChanged = true;
            }
            return propertyChanged;
        }
        //protected readonly IDialogService DialogService;
        //protected readonly IState State;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
