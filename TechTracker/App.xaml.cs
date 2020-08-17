using System;
using TechTracker.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TechTracker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new VisitPageMain());
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
