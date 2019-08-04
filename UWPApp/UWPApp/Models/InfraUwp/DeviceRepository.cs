// <copyright file="DeviceRepository.cs" company="PlaceholderCompany">
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

    internal class DeviceRepository : IDeviceRepository
    {
        private string printerName = "Initial";

        /// <inheritdoc/>
        public string GetDeviceName()
        {
            return this.printerName;
        }

        /// <inheritdoc/>
        public void Store(string name)
        {
            this.printerName = name;
            Debug.Write(name + " is Stored\n");
        }
    }
}
