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
        public string PrinterName { get; private set; }
        public void Store(string name)
        {
            this.PrinterName = name;
            Debug.WriteLine("[{0}] is Stored", name);
        }
    }
}
