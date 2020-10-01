using System;
using System.Collections.Generic;
using Hitt.ViewModel;
using Xamarin.Forms;

namespace Hitt.View
{
    public partial class HomePageView : ContentPage
    {
        public HomePageView()
        {
            InitializeComponent();
            this.BindingContext = (new HomePageViewModel());
        }
        
    }
}
