using System;
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
        public ICommand SelectedCommand => new Command(async () => await SelectedCommandAsync());
        ObservableCollection<MenuItems> menuItems = new ObservableCollection<MenuItems>();
        public ObservableCollection<MenuItems> MenuItem { get { return menuItems; } }

        public MainMasterDetailViewModel()
        {
            AddItemsToMenuItems();
        }

        public async Task SelectedCommandAsync()
        {
            await NavigationService.PushAsync(new ExpertTips());
        }
        public void AddItemsToMenuItems()
        {
            menuItems.Add(new MenuItems { Title="Settings" });
            menuItems.Add(new MenuItems { Title = "Expert Tips" });

        }
    }
}
