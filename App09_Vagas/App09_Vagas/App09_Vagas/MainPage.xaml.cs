using App09_Vagas.Banco;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App09_Vagas
{
    public partial class MainPage : ContentPage
    {
        private VagaRepository _db;

        public MainPage()
        {
            InitializeComponent();

            _db = new VagaRepository();

           
            
        }

        
    }
}
