using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App07_Estilos.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DynamicStylePage : ContentPage
    {
        public DynamicStylePage()
        {
            InitializeComponent();
        }

        private void MudarCor(object sender, EventArgs e)
        {
            this.Resources["lblColor"] = Color.Green;
            this.Resources["lbl"] = this.Resources["newLbl"];
        }
    }
}