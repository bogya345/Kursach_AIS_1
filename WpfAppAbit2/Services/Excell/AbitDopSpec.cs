using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;

using WpfAppAbit2.Services.Patterns;
using WpfAppAbit2.DAL;
using WpfAppAbit2.Models;

namespace WpfAppAbit2.Services.Excell
{
    public class AbitDopSpec : Excell
    {
        private int specNumber;

        public AbitDopSpec(int specNum)
        {
            this.specNumber = specNum;

            patternPath = Pattern.Excel.AbitDopSpec;

            //wb = app.Workbooks.Open(patternPath);
            //ws = wb.Worksheets[1];
        }

        public void SetContent(RepositoryApplication apps)
        {
            ws.Cells.Replace("#specNumber#", specNumber.ToString());

            foreach (EntrantApplication item in apps.GetAll())
            {
                //fullname
                ws.Cells[3, 3].Value2 = item.Entrant.Person.Fullname();
                //application number
                ws.Cells[3, 3].Value2 = item.ApplicationNumber;
                //summary of balls
                ws.Cells[3, 3].Value2 = item.balls;
            }

            app.Visible = true;
        }
    }
}
