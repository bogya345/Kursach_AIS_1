using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppAbit2.Views;

namespace WpfAppAbit2.ViewModels
{
    public interface IViewModel
    {
        IView View { get; set; }
    }
}
