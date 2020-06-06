using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFramework.ViewModels
{
    public class ViewModelLocator
    {
        public MainViewModel MainView { get => new MainViewModel(); }
    }
}
