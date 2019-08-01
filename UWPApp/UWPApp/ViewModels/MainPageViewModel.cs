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

        public string LogMsg
        {
            get { return logMsg_; }
            set
            {
                SetProperty(ref this.logMsg_, value);
            }
        }
        public DelegateCommand EnumCommand { get; set; }

        public MainPageViewModel()
        {
            this.mainUseCase_ = new MainUseCase();
            EnumCommand = new DelegateCommand(() => mainUseCase_.EnumAndGetName());
            this.LogMsg = "Start!";
            this.mainUseCase_.PropertyChanged += MsgChanged;
        }

        private void MsgChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "DeviceNames_") return;

            var u = (MainUseCase)sender;
            LogMsg = u.DeviceNames_;
        }


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
