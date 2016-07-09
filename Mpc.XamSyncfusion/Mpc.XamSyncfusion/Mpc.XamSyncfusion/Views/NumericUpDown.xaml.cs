using Syncfusion.SfNumericUpDown.XForms;
using Xamarin.Forms;

namespace Mpc.XamSyncfusion.Views
{
    public partial class NumericUpDown : ContentPage
    {
        public NumericUpDown()
        {
            InitializeComponent();
            var numeric = new SfNumericUpDown();
            numeric.FormatString = "c";
            numeric.Culture = new System.Globalization.CultureInfo("pt-PT");
            stcMain.Children.Add(numeric);
        }
    }
}
