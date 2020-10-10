using System;
using Hitt.Navigation;
using Hitt.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hitt
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            this.MainPage = new  MainMasterDetailsPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
