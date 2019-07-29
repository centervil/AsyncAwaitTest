using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPApp.Models.Domain
{
    public class EnumService
    {
        IEnumPrinter enumPrinter_;
        IDeviceRepository deviceRepository_;
        public EnumService(IEnumPrinter enumPrinter, IDeviceRepository deviceRepository)
        {
            this.enumPrinter_ = enumPrinter;
            this.deviceRepository_ = deviceRepository;
        }
        public void EnumPrinters()
        {
            this.enumPrinter_.EnumPrinters(deviceRepository_);
        }
    }
}
