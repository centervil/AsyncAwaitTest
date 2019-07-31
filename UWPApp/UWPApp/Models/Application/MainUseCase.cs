using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPApp.Helper;
using UWPApp.Models.Domain;

namespace UWPApp.Models.Application
{
    public class MainUseCase : BindableBase
    {
        private string deviceNames_;
        private EnumService enumService_;

        public MainUseCase()
        {
            enumService_ = new EnumService(new InfraUwp.EnumPrinters(), new InfraUwp.DeviceRepository());
        }

        public string DeviceNames_
        {
            get { return deviceNames_; }
            set { SetProperty(ref this.deviceNames_, value); }
        }

        public void EnumAndGetName()
        {
            enumService_.EnumPrinters();
            DeviceNames_ = enumService_.GetPrinterName();
        }
    }
}
