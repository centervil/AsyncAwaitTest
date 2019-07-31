using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPApp.Models.Domain;

namespace UWPApp.Models.InfraUwp
{
    class DeviceRepository : IDeviceRepository
    {
        private string printerName_ = "Initial";

        public string GetDeviceName()
        {
            return printerName_;
        }

        public void Store(string name)
        {
            this.printerName_ = name;
            Debug.Write(name + " is Stored");
        }
    }
}
