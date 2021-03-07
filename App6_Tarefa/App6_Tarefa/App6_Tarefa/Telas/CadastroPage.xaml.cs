using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6_Tarefa.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroPage : ContentPage
    {
        public CadastroPage()
        {
            InitializeComponent();

            MudaCorLabels();
        }

        private void MudaCorLabels()
        {
            var childrenStacks = slPrioridades.Children;

            foreach (var linha in childrenStacks)
            {
                var lblPrioridade = (Label)((StackLayout)linha).Children[1];
                lblPrioridade.TextColor = Color.Red;


            }
        }

        public void PrioridadeSelectAction(object sender, EventArgs e)
        {
            

            var tappedStack = (StackLayout)sender;
            var tappedLabel = (Label)tappedStack.Children[1];

            tappedLabel.TextColor = Color.Black;

        }

        public void SalvarAction(object sender, EventArgs e)
        {
            if( txtNome.Text.Trim().Length == 0)
            {
                //erro
            }
        }
    }
}