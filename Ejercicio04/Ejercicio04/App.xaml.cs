using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio04
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navigationPage = new NavigationPage(new BatteryDemo());

            navigationPage.Navigation.PushAsync(new TextToSpeechDemo());

            MainPage = navigationPage;

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
