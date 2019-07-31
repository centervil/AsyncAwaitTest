using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPApp.Models.Domain
{
    public interface IDeviceRepository
    {
        void Store(string name);
        string GetDeviceName();
    }
}
