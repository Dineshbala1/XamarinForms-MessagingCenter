using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinForms_DependencyService
{
    public class App : Application
    {

        public static INavigation Navigation { get; private set; }

        public App()
        {
            // The root page of your application

            var mainPage =  new NavigationPage(new HomePage());
            Navigation = mainPage.Navigation;
            MainPage = mainPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
