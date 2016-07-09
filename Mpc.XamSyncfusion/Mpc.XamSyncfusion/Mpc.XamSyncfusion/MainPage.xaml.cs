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
            try
            {
                var p = new Views.NumericUpDown();
                await Navigation.PushAsync(p);
            }
            catch(Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "ok");
            }
        }
    }
}
