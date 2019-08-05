// <copyright file="MainUseCase.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace UWPApp.Models.Application
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using UWPApp.Helper;
    using UWPApp.Models.Domain;

    public class MainUseCase : BindableBase
    {
        private string deviceNames;
        private EnumService enumService;

        public MainUseCase()
        {
            this.enumService = new EnumService(new InfraUwp.EnumPrinters(), new InfraUwp.DeviceRepository());
        }

        public string DeviceNames_
        {
            get { return this.deviceNames; }
            set { this.SetProperty(ref this.deviceNames, value); }
        }

        public async Task EnumAndGetNameAsync()
        {
            this.DeviceNames_ = await this.enumService.EnumPrintersAsync();
        }
    }
}
