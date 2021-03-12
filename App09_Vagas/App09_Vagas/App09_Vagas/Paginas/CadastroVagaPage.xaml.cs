using App09_Vagas.Banco;
using App09_Vagas.Modelos;
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
    public partial class CadastroVagaPage : ContentPage
    {
        public CadastroVagaPage(Vaga vaga = null)
        {
            InitializeComponent();

            if(vaga == null)
            {
                //cadastro
            }
            else
            {
                //edição
            }
        }

        private void SalvarAction(object sender, EventArgs e)
        {            
            Vaga vaga = new Vaga()
            {
                Nome = Nome.Text,
                Quantidade = Convert.ToByte(Quantidade.Text),               
                Salario = Convert.ToDouble(Salario.Text),
                Empresa = Empresa.Text,
                Cidade = Cidade.Text,
                Descricao = Descricao.Text,
                TipoContratacao = TipoContratacao.IsToggled ? "PJ" : "CLT",
                Telefone = Telefone.Text,
                Email = Email.Text

            };
            
            var repository = new VagaRepository();

            repository.Cadastro(vaga);

            App.Current.MainPage = new NavigationPage(new ConsultaVagasPage());


        }
    }
}