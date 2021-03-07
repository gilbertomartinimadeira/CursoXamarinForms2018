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
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
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

        private void listViewFuncionarios_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var funcionario = (Funcionario)e.SelectedItem;

            Navigation.PushAsync(new Paginas.DetailPage(funcionario));
        }

        private void Ferias_Action(object sender, EventArgs e)
        {
            MenuItem botao = (MenuItem)sender;

            Funcionario funcionario = (Funcionario)botao.CommandParameter;

            DisplayAlert("Titulo: " + funcionario.Nome, funcionario.Nome + " - " + funcionario.Cargo, "FODA-SE");
        }

        private void Abono_Action(object sender, EventArgs e)
        {

        }
    }
}