using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPApp.Models.Domain;
using Windows.UI.Popups;

namespace UWPApp.Models.InfraUwp
{
    class EnumPrinters : IEnumPrinter
    {
        void IEnumPrinter.EnumPrinters(IDeviceRepository deviceRepository_)
        {
            Debug.WriteLine("EnumPrinters() is Called\n");
            var printerName = "Printer1";
            deviceRepository_.Store(printerName);
        }
    }
}
