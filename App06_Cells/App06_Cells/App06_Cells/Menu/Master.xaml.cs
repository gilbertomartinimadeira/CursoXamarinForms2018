﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App06_Cells.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }
        public void GoPagina1(object sender, EventArgs e)
        {
            var detail = new NavigationPage(new Paginas.TextCellPage());

            Detail = detail;
            IsPresented = false;
        }
        public void GoPagina2(object sender, EventArgs e)
        {
            var detail = new NavigationPage(new Paginas.ImageCellPage());

            Detail = detail;
            IsPresented = false;
        }
        public void GoPagina3(object sender, EventArgs e)
        {
            var detail = new NavigationPage(new Paginas.EntryCellPage());

            Detail = detail;
            IsPresented = false;
        }

        public void GoPagina4(object sender, EventArgs e)
        {
            var detail = new NavigationPage(new Paginas.SwitchCellPage());

            Detail = detail;
            IsPresented = false;
        }

        public void GoPagina5(object sender, EventArgs e)
        {
            var detail = new NavigationPage(new Paginas.ViewCellPage());

            Detail = detail;
            IsPresented = false;
        }

        public void GoPagina6(object sender, EventArgs e)
        {
            var detail = new NavigationPage(new Paginas.ListViewPage());

            Detail = detail;
            IsPresented = false;
        }

        public void GoPagina7(object sender, EventArgs e)
        {
            var detail = new NavigationPage(new Paginas.ListViewButtonPage());

            Detail = detail;
            IsPresented = false;
        }
    }
}