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
    public partial class MinhasVagasCadastradasPage : ContentPage
    {
        private VagaRepository _repo;
        private List<Vaga> listaDB;
        public MinhasVagasCadastradasPage()
        {
            InitializeComponent();
            _repo = new VagaRepository();

            ConsultarVagas();
        }

        private void ConsultarVagas()
        {
            listaDB = _repo.Consultar();
            listaVagas.ItemsSource = listaDB;
            lblCount.Text = listaDB.Count.ToString();
        }

        private void GoCadastro(object sender, EventArgs e)
        {

        }

        private void GoMinhasVagas(object sender, EventArgs e)
        {

        }

        private void EditarAction(object sender, EventArgs e)
        {
            // Vaga vaga = (Vaga)e.Parameter;
            var lblDetalhe = (Label)sender;
            var tapGestureRecognizer = (TapGestureRecognizer)lblDetalhe.GestureRecognizers[0];

            Vaga vaga = tapGestureRecognizer.CommandParameter as Vaga;
            Navigation.PushAsync(new CadastroVagaPage(vaga));
        }

        private void ExcluirAction(object sender, EventArgs e)
        {
            var lblExcluir = (Label)sender;
            var tapGestureRecognizer = (TapGestureRecognizer)lblExcluir.GestureRecognizers[0];

            Vaga vaga = tapGestureRecognizer.CommandParameter as Vaga;

            _repo.Exclusao(vaga);

            ConsultarVagas();


        }
    }
}