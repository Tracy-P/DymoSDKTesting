using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCore.ViewModels
{
    public class ViewModelLocator
    {
        public MainViewModel MainView { get => new MainViewModel(); }
    }
}
