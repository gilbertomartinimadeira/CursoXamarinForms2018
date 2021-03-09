using App07_Estilos.Menu;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App07_Estilos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MasterDetail();
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
