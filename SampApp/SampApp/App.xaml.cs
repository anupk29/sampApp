using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;

namespace SampApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SampApp.MainPage();
        }

        protected override void OnStart()
        {
            MobileCenter.Start("android=5750b40d-91dc-455e-8c0d-47ff4778ffe9;"
                    //+
                    //    "uwp={Your UWP App secret here};" +
                    //    "ios={Your iOS App secret here}",
                    , typeof(Analytics), typeof(Crashes));
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
