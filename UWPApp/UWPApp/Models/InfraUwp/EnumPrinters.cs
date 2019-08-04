// <copyright file="EnumPrinters.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace UWPApp.Models.InfraUwp
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using UWPApp.Models.Domain;
    using Windows.UI.Popups;

    internal class EnumPrinters : IEnumPrinter
    {
        /// <inheritdoc/>
        void IEnumPrinter.EnumPrinters(IDeviceRepository deviceRepository_)
        {
            Debug.WriteLine("EnumPrinters() is Called\n");
            var printerName = "Printer1";
            deviceRepository_.Store(printerName);
        }
    }
}
