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
    public partial class TextCellPage : ContentPage
    {
        public TextCellPage()
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
    }
}