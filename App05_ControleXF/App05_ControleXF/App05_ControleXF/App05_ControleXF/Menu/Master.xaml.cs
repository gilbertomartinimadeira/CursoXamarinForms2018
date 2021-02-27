using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App05_ControleXF.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }
        
        public void GoActivityIndicatorPage(object sender, EventArgs e)
        {
            Detail = new Controles.ActivityIndicatorPage();
        }
        public void GoProgressBarPage(object sender, EventArgs e)
        {
            Detail = new Controles.ProgressBarPage();
        }
        public void GoBoxViewPage(object sender, EventArgs e)
        {
            Detail = new Controles.BoxViewPage();
        }
        public void GoLabelPage(object sender, EventArgs e)
        {
            Detail = new Controles.LabelPage();
        }
        public void GoButtonPage(object sender, EventArgs e)
        {
            Detail = new Controles.ButtonPage();
        }

        public void GoEntryEditorPage(object sender, EventArgs e)
        {
            Detail = new Controles.EntryEditorPage();
        }

        public void GoDatePickerPage(object sender, EventArgs e)
        {
            Detail = new Controles.DatePickerPage();
        }

        public void GoPickerPage(object sender, EventArgs e)
        {
            Detail = new Controles.PickerPage();
        }
       
        public void GoSearchBarPage(object sender, EventArgs e)
        {
            Detail = new Controles.SearchBarPage();
        }

        private void GoSliderStepperPage(object sender, EventArgs e)
        {
            Detail = new Controles.SliderStepperPage();
        }

        private void GoSwitchPage(object sender, EventArgs e)
        {
            Detail = new Controles.SwitchPage();
        }

        private void GoImagePage(object sender, EventArgs e)
        {
            Detail = new Controles.ImagePage();
        }

        private void GoListViewPage(object sender, EventArgs e)
        {
            Detail = new Controles.ListViewPage();
        }

    }
}