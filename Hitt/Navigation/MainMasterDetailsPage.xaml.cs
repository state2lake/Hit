using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Hitt.Model;
using Hitt.View;
using Hitt.ViewModel;
using Xamarin.Forms;

namespace Hitt.Navigation
{
    public partial class MainMasterDetailsPage : MasterDetailPage
    {

        MainMasterDetailViewModel _mainMasterDetailViewModel = new MainMasterDetailViewModel();
        public MainMasterDetailsPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new HomePageView());

            IsPresented = false;

            this.BindingContext = new MainMasterDetailViewModel();

        }

        async void MenuItemView_ItemTapped_1(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            // await _mainMasterDetailViewModel.SelectedCommandAsync();
           
        }

        //void CustomLabel_Focused(System.Object sender, Xamarin.Forms.FocusEventArgs e)
        //{
        //    e.VisualElement.BackgroundColor = Color.Red;
        //}
    }
}
