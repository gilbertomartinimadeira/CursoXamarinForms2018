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
    public partial class EntryEditorPage : ContentPage
    {
        public EntryEditorPage()
        {
            InitializeComponent();

            
            txtIdade.TextChanged += (object sender, TextChangedEventArgs e) =>
            {
                lblDuplicado.Text = e.NewTextValue;
            };

            txtComentario.Completed += (object sender, EventArgs e) =>
            {
                var tamanho = txtComentario.Text?.Length.ToString();

                lblQuantidadeCaracteres.Text = tamanho;
            };
        }

        
    }
}