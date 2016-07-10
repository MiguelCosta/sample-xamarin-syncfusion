using System;
using Xamarin.Forms;

namespace Mpc.XamSyncfusion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAutoCompleteClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.AutoComplete());
        }

        private async void btnBarCodeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.BarCode());
        }

        private async void btnNumericUpDownClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NumericUpDown());
        }
    }
}
