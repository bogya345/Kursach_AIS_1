using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Excel;

namespace WpfAppAbit2.Services.Excell
{
    public class Excell
    {
        protected Application app = new Application();
        protected Workbook wb;
        protected Worksheet ws;

        protected string patternPath;

        public Excell()
        {

        }
    }
}
