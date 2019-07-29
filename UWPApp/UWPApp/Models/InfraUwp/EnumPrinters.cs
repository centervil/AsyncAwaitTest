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
            var printerName = "Printer1";
            deviceRepository_.Store(printerName);
            Debug.WriteLine("EnumPrinters() is Called");
        }
    }
}
