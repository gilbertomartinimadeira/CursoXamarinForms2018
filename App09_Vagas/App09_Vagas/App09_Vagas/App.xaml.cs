﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App09_Vagas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Paginas.ConsultaVagasPage());
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
