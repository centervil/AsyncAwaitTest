// <copyright file="IEnumPrinter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace UWPApp.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IEnumPrinter
    {
        void EnumPrinters(IDeviceRepository deviceRepository_);
    }
}
