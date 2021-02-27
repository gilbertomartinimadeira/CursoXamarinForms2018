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
    public partial class ProgressBarPage : ContentPage
    {
        public ProgressBarPage()
        {
            InitializeComponent();
        }

        public void ModificarBarras(object sender, EventArgs e)
        {
            Bar1.ProgressTo(1, 3000, Easing.CubicIn);
            Bar2.ProgressTo(1, 5000, Easing.BounceIn);
            Bar3.ProgressTo(1, 5000, Easing.SpringOut);

        }
    }
}