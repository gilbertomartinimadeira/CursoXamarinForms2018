using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App03_LayoutXF
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void GoStackLayoutPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Stack.StackPage());
        }
        public void GoAbsoluteLayoutPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Absolute.AbsolutePage());
        }
        public void GoRelativeLayoutPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Relative.RelativePage());
        }
        public void GoGridLayoutPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Grid.GridPage());
        }
        public void GoScrollLayoutPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layouts.Scroll.ScrollPage());
        }
    }
}
