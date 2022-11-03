using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appHalcyon
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            //            MainPage = new MainPage();
            MainPage = new NavigationPage(new login_page());
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

