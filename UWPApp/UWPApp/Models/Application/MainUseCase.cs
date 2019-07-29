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
        public MainUseCase()
        {
        }

        public string DeviceNames_
        {
            get
            {
                return deviceNames_;
            }
            set
            {
                SetProperty(ref this.deviceNames_, value);
            }
        }

        public void GetDeviceNames()
        {
            IEnumPrinter enumPrinter = new InfraUwp.EnumPrinters();
            IDeviceRepository deviceRepository = new InfraUwp.DeviceRepository();
            var enumService = new EnumService(enumPrinter, deviceRepository);
            enumService.EnumPrinters();

            //DeviceNames_ = deviceRepository.Get();
        }
    }
}
