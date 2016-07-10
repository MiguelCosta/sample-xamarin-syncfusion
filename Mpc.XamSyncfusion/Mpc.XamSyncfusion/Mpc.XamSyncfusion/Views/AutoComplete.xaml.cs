using Syncfusion.SfAutoComplete.XForms;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Mpc.XamSyncfusion.Views
{
    public partial class AutoComplete : ContentPage
    {
        public AutoComplete()
        {
            InitializeComponent();

            BindingContext = Models.Repository.Clients();

            aucClientsBindingByCode.DataSource = Models.Repository.Clients();
            autocomplete.DataSource = Models.Repository.Clients();

            SfAutoComplete countryAutoComplete = new SfAutoComplete();
            List<string> countryName = new List<String>();
            countryName.Add("Afghanistan");
            countryName.Add("Akrotiri");
            countryName.Add("Albania");
            countryAutoComplete.Watermark = "Contry StartWith A";
            countryAutoComplete.AutoCompleteSource = countryName;
            stcMain.Children.Add(countryAutoComplete);

            var aucClientsBinding = new SfAutoComplete();
            var clients = Models.Repository.Clients();
            aucClientsBinding.DataSource = clients;
            aucClientsBinding.DisplayMemberPath = "Name";
            aucClientsBinding.SelectedValuePath = "Id";

            stcMain.Children.Add(aucClientsBinding);
        }
    }
}
