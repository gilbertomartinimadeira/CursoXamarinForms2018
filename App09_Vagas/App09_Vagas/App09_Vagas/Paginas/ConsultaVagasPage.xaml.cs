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
    public partial class ConsultaVagasPage : ContentPage
    {
        private VagaRepository _repo;
        private List<Vaga> listaDB;
        public ConsultaVagasPage()
        {
            InitializeComponent();

            _repo = new VagaRepository();
            listaDB =  _repo.Consultar();           
            listaVagas.ItemsSource = listaDB;
            lblCount.Text = listaDB.Count.ToString();
        }

        private void GoCadastro(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroVagaPage());
        }

        private void GoMinhasVagas(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MinhasVagasCadastradasPage());
        }

        private void DetalheAction(object sender, EventArgs e)
        {
            // Vaga vaga = (Vaga)e.Parameter;
            var lblDetalhe = (Label)sender;
            var tapGestureRecognizer = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];

            Vaga vaga = tapGestureRecognizer.CommandParameter as Vaga;
            Navigation.PushAsync(new DetalheVagaPage(vaga));
        }

        private void PesquisarAction(object sender, TextChangedEventArgs e)
        {
            var db = new VagaRepository();

            var listaVagas = db.Pesquisar(e.NewTextValue);
        }
    }
}