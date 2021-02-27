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
    public partial class SearchBarPage : ContentPage
    {
        public List<string> EmpresasTI { get; private set; }

        public SearchBarPage()
        {
            InitializeComponent();

            EmpresasTI = new List<string>()
            {
                "Microsoft", "Apple", "Oracle", "IBM", "SAP","UBER"
            };

            Preencher(EmpresasTI);


        }

        private void Preencher(List<string> EmpresasTI)
        {
            ListResult.Children.Clear();
            foreach (var empresa in EmpresasTI)
            {
                ListResult.Children.Add(new Label { Text = empresa });
            }
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            
            Preencher(EmpresasTI.Where(a => a.Contains(sbPesquisaEmpresas.Text)).ToList<String>());
        }
    }
}