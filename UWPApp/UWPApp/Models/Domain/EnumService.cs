// <copyright file="EnumService.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace UWPApp.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EnumService
    {
        private IEnumPrinter enumPrinter;
        private IDeviceRepository deviceRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="EnumService"/> class.
        /// </summary>
        /// <param name="enumPrinter">enumPrinterの実装を注入する.</param>
        /// <param name="deviceRepository">deviceRepositoryの実装を注入する.</param>
        public EnumService(IEnumPrinter enumPrinter, IDeviceRepository deviceRepository)
        {
            this.enumPrinter = enumPrinter;
            this.deviceRepository = deviceRepository;
        }

        public string EnumPrinters()
        {
            this.enumPrinter.EnumPrinters(this.deviceRepository);
            return this.deviceRepository.GetDeviceName();
        }
    }
}
