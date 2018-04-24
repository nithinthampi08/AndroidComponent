using IntComponent.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IntComponent.Views
{
    public partial class Home : ContentPage
    {
        //private int _textCounter;
        public Home()
        {
            InitializeComponent();

            //_textCounter = DependencyService.Get<ITextCounter>().NumVowels("");
        }

        private void BtnCheck_Clicked(object sender, EventArgs e)
        {
            //int numVowels = DependencyService.Get<ITextCounter>().NumVowels(txtEntry.Text);
            DependencyService.Get<ITextCounter>().ShowMessage("Test");
            //DisplayAlert("Alert", numVowels.ToString(), "OK");
        }
    }
}
