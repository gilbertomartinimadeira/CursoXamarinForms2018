﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SwitchPage : ContentPage
    {
        public SwitchPage()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Atenção", $"TROCOU O VALOR PARA {e.Value}", "CANCELAR");
        }
    }
}