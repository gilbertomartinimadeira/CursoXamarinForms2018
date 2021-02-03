﻿

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Tabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Abas : TabbedPage
    {
        public Abas()
        {
            InitializeComponent();

            Children.Add(new NavigationPage(new TipoPagina.Navigation.Pagina1()){ Title = "item 3", BarBackgroundColor= Color.LightPink});
        }
    }
}