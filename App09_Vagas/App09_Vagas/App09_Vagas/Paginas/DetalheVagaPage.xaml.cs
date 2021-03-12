﻿using App09_Vagas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App09_Vagas.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalheVagaPage : ContentPage
    {
        public DetalheVagaPage(Vaga vaga)
        {
            InitializeComponent();

            BindingContext = vaga;
        }
    }
}