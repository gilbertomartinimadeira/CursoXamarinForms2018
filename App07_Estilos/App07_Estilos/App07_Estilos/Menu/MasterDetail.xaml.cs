using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App07_Estilos.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            InitializeComponent();


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.ImplicitStylePage());
            IsPresented = false;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.ExplicitStylePage());
            IsPresented = false;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.GlobalStylePage());
            IsPresented = false;
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.InheritStylePage());
            IsPresented = false;
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Paginas.DynamicStylePage());
            IsPresented = false;
        }
    }
}