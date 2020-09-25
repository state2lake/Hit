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

      

        public MainMasterDetailsPage()
        {
            InitializeComponent();

            Detail = new NavigationPage(new HomePageView());

            IsPresented = false;

            this.BindingContext = new MainMasterDetailViewModel();

        }
    }
}
