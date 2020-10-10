﻿using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Hitt.Model;
using Hitt.Navigation;
using Hitt.Services;
using Hitt.View;
using Hitt.ViewModel.Base;
using Xamarin.Forms;

namespace Hitt.ViewModel
{
    public class MainMasterDetailViewModel : BaseViewModel
    {
        #region ICommands

        public ICommand SelectedCommand => new Command(async () => await SelectedCommandAsync());
       
        #endregion ICommands

        #region props

        ObservableCollection<MenuItems> menuItems = new ObservableCollection<MenuItems>();
        public ObservableCollection<MenuItems> MenuItem { get { return menuItems; } }

        private bool _isMenuItemEnabled = false;
        public bool IsMenuItemEnabled
        {
            get => _isMenuItemEnabled;
            set
            {
                _isMenuItemEnabled = value;
                OnPropertyChanged();
            }
        }
        #endregion


        public MainMasterDetailViewModel()
        {
            AddItemsToMenuItems();
        }

        #region public 
        public async Task SelectedCommandAsync()
        {
            IsMenuItemEnabled = true;
           // await NavigationService.PushAsync(new );
        }
        public void HandleMenuItemEnabled()
        {
            if(IsMenuItemEnabled)
            {

            }
        }
        public void AddItemsToMenuItems()
        {
            menuItems.Add(new MenuItems { Title="Settings" });
            menuItems.Add(new MenuItems { Title = "Expert Tips" });
        }
        #endregion
    }
}
