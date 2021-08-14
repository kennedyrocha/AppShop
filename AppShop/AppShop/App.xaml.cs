using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppShop
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Device.SetFlags(new string[] { "Shapes_Experimental" });

            MainPage = new AppShop.Views.Login();
        }

        public static void NavegarParaPaginaInicial()
        {
            App.Current.MainPage = new Menu();
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
