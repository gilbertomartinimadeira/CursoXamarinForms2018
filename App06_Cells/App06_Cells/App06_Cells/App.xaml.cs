using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App06_Cells
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Menu.Master();
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
