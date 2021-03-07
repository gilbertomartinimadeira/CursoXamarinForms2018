using App06_Cells.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App06_Cells.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewButtonPage : ContentPage
    {
        public ListViewButtonPage()
        {
            InitializeComponent();

            var funcionarios = new List<Funcionario>
            {
                new Funcionario { Nome = "Gilberto",  Cargo= "Analista de Sistemas" },
                new Funcionario { Nome = "Josélia",  Cargo= "Analista Contábil" },
                new Funcionario { Nome = "João",  Cargo= "Programador" },
                new Funcionario { Nome = "Mary",  Cargo= "Analista Jurídico" }

            };

            listViewFuncionarios.ItemsSource = funcionarios;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            var funcionario = (Funcionario)button.CommandParameter;

            DisplayAlert(funcionario.Nome, funcionario.Nome + " - " + funcionario.Cargo, "FODA-SE");
        }
    }
}