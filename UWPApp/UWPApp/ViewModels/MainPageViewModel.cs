// <copyright file="MainPageViewModel.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace UWPApp.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using UWPApp.Helper;
    using UWPApp.Models.Application;

    internal class MainPageViewModel : BindableBase
    {
        private string logMsg;
        private MainUseCase mainUseCase;
        private bool isProgress = false;

        public string LogMsg
        {
            get { return this.logMsg; }
            set { this.SetProperty(ref this.logMsg, value); }
        }

        public bool IsProgress
        {
            get { return this.isProgress; }
            set { this.SetProperty(ref this.isProgress, value); }
        }


        public DelegateCommand EnumCommand { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainPageViewModel"/> class.
        /// </summary>
        public MainPageViewModel()
        {
            this.mainUseCase = new MainUseCase();
            this.EnumCommand = new DelegateCommand(async () =>
            {
                this.IsProgress = true;
                await this.mainUseCase.EnumAndGetNameAsync();
                this.IsProgress = false;
            });
            this.LogMsg = "Start!";
            this.mainUseCase.PropertyChanged += this.MsgChanged;
        }

        private void MsgChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "DeviceNames")
            {
                return;
            }

            var u = (MainUseCase)sender;
            this.LogMsg = u.DeviceNames_;
        }

        // {
        //    //get { return this.mainUseCase_.DeviceNames_; }
        //    //set
        //    //{
        //    //    this.mainUseCase_.DeviceNames_ = value;
        //    //    //this.mainUseCase_ = value;
        //    //    this.LogMsg = this.mainUseCase_.DeviceNames_;
        //    //}
        // }
    }
}
