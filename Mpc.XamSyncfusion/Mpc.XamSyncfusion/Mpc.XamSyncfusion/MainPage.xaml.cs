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

        private async void btnSfNumericUpDownClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.SfNumericUpDown());
        }
    }
}
