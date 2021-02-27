using App05_ControleXF.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_ControleXF.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {       
        public ListViewPage()
        {
            InitializeComponent();

            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa() { Nome = "Gilberto Martini" , Idade = "37"},
                new Pessoa() { Nome = "Alan Martini" , Idade = "40"},
                new Pessoa() { Nome = "Jéssica Martini" , Idade = "33"},
                new Pessoa() { Nome = "João Martini" , Idade = "0"}
            };

            ListaPessoas.ItemsSource = pessoas;

            
            
        }
    }
}