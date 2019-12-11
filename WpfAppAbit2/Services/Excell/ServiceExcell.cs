using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

namespace WpfAppAbit2.Services.Excell
{
    public class ServiceExcell
    {
        public ServiceExcell()
        {

        }

        private AbitDopSpec abitDocSpec;

        public AbitDopSpec AbitDopSpec { get; set; }
        public Abitltogi Abitltogi { get; set; }
    }
}
