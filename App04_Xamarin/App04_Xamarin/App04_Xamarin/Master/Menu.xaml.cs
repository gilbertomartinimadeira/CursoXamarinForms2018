using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App04_Xamarin.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        public void GoPaginaPerfil(object sender, EventArgs e)
        {
            Detail = new Pages.Perfil();
            IsPresented = false;
        }

        public void GoPaginaXamarin(object sender, EventArgs e)
        {
            Detail = new Pages.Xamarin();
            IsPresented = false;
        }

    }
}