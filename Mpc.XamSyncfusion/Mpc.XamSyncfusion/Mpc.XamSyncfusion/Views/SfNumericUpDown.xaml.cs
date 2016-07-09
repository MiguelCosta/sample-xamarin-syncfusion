using Xamarin.Forms;

namespace Mpc.XamSyncfusion.Views
{
    public partial class SfNumericUpDown : ContentPage
    {
        public SfNumericUpDown()
        {
            InitializeComponent();

            var c = new Models.Client
            {
                Id = 1,
                Name = "Client1"
            };

            this.BindingContext = c;
        }
    }
}
