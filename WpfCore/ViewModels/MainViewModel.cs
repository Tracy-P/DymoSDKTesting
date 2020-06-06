using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCore.Utilities;

namespace WpfCore.ViewModels
{
    public class MainViewModel
    {
        public IEnumerable<DymoSDK.Interfaces.IPrinter> Printers { get; set; }

        public CommandUtility GetPrintersCommand { get; set; }

        public MainViewModel()
        {
            GetPrintersCommand = new CommandUtility(GetPrintersButtonClick);
        }

        private void GetPrintersButtonClick(object sender)
        {
            Printers = DymoSDK.Implementations.DymoPrinter.Instance.GetPrinters();
        }
    }
}
