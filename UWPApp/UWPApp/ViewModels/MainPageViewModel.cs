using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPApp.Helper;
using UWPApp.Models.Application;

namespace UWPApp.ViewModels
{
    class MainPageViewModel : BindableBase
    {
        private string logMsg_;
        private MainUseCase mainUseCase_;

        public MainPageViewModel()
        {
            this.MainUseCase_ = new MainUseCase();
            EnumCommand = new DelegateCommand(() => MainUseCase_.EnumAndGetName());
            this.LogMsg = "Start!";
        }
        public DelegateCommand EnumCommand { get; set; }
        public string LogMsg
        {
            get { return this.logMsg_; }
            set { this.SetProperty(ref this.logMsg_, value); }
        }
        public MainUseCase MainUseCase_ { get; set; }

        //{
        //    //get { return this.mainUseCase_.DeviceNames_; }
        //    //set
        //    //{
        //    //    this.mainUseCase_.DeviceNames_ = value;
        //    //    //this.mainUseCase_ = value;
        //    //    this.LogMsg = this.mainUseCase_.DeviceNames_;
        //    //}
        //}
    }
}
