using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

using WpfAppAbit2.Services.Patterns;

namespace WpfAppAbit2.Services.Excell
{
    public class AbitDopSpec : Excell
    {
        public AbitDopSpec()
        {
            patternPath = Pattern.Excel.AbitDopSpec;
        }
    }
}
