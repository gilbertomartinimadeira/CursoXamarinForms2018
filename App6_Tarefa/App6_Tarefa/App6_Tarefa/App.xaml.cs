using App6_Tarefa.Telas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6_Tarefa
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new InicioPage());
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
