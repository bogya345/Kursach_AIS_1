using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfAppAbit2.ViewModels;
using WpfAppAbit2.Views;

namespace WpfAppAbit2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    /// 
   

    public partial class App : Application
    {
        public DisplayRootRegistry displayRootRegistry = new DisplayRootRegistry();

        public App()
        {

            new MainViewModel(new MainView());
            displayRootRegistry.RegisterWindowType<AbitAddViewModel, AbitAddView>();

        }
    }
}
