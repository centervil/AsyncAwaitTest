using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPApp.Helper;
using UWPApp.Models.Application;

namespace UWPApp.ViewModels
{
    class MainPageViewModel : BindableBase
    {
        private string logMsg;

        public MainPageViewModel()
        {
            EnumCommand = new DelegateCommand(() =>
                {
                    var useCase = new MainUseCase();
                    useCase.GetDeviceNames();
                }
            );
            this.LogMsg = "Start!";
        }
        public DelegateCommand EnumCommand { get; set; }
        public string LogMsg
        {
            get
            {
                return this.logMsg;
            }
            set
            {
                this.SetProperty(ref this.logMsg, value);
            }
        }

    }
}
