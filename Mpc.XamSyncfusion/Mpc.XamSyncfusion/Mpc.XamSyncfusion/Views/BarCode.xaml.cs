using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Syncfusion.SfBarcode.XForms;

namespace Mpc.XamSyncfusion.Views
{
    public partial class BarCode : ContentPage
    {
        public BarCode()
        {
            InitializeComponent();
            QRBarcodeSettings settings = new QRBarcodeSettings();
            settings.XDimension = 6;
            barQRCode.SymbologySettings = settings;
        }
    }
}
