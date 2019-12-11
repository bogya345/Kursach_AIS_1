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
        protected Application excelApp;
        protected Workbook workBook;
        protected Worksheet workSheet;

        protected string patternPath;

        public Excell()
        {

        }
    }
}
