﻿using System;
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
            try
            {
                await Navigation.PushAsync(new Views.AutoComplete());
            }
            catch(Exception ex)
            {
                await DisplayAlert("Erro", ex.Message, "ok");
            }
        }

        private async void btnNumericUpDownClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.NumericUpDown());
        }
    }
}
