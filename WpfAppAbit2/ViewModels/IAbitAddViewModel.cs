﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppAbit2.Views;

namespace WpfAppAbit2.ViewModels
{
    public interface IAbitAddViewModel : IView
    {
        IView View { get; set; }
      //  IView IViewModel.View { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
