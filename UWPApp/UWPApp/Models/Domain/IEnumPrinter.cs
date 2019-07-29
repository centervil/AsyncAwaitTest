using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPApp.Models.Domain
{
    public interface IEnumPrinter
    {
        void EnumPrinters(IDeviceRepository deviceRepository_);
    }
}
