using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App03_LayoutXF.Layouts.Stack
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LabelTestPage : ContentPage
    {
        public LabelTestPage()
        {
            InitializeComponent();
            Thickness thickness = default;
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    thickness = new Thickness(0, 20, 0, 0);
                    break;
                case Device.UWP:
                    thickness = new Thickness(0, 40, 0, 0);
                    break;
            }
            
            var label = new Label
            {
                Text = "Um Texto Bem grande e copiado varias vezes Um Texto Bem grande e copiado varias vezes Um Texto Bem grande e copiado varias vezes ",
                HorizontalTextAlignment = TextAlignment.Start
            };
            Content = label;

            this.Padding = thickness;
        }

    }
}