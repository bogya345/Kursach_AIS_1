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
        private bool _specNum;

        public AbitDopSpec()
        {
            _specNum = false;

            patternPath = Pattern.Excel.AbitDopSpec;

            wb = app.Workbooks.Open(patternPath);
            ws = wb.Worksheets[1];
        }

        public AbitDopSpec(int specNum)
        {
            this.specNumber = specNum;
            this._specNum = true;

            patternPath = Pattern.Excel.AbitDopSpec;

            wb = app.Workbooks.Open(patternPath);
            ws = wb.Worksheets[1];
        }

        public void SetSpecNumber(int num)
        {
            specNumber = num;
            _specNum = true;
        }

        public bool SetContent(RepositoryApplication apps)
        {
            if (_specNum)
            {
                ws.Cells.Replace("#specNumber#", specNumber.ToString());
                ws.Range["A1:G2"].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightBlue);

                int i = 3;
                foreach (EntrantApplication item in apps.GetAll())
                {
                    //fullname
                    ws.Cells[i, 3].Value2 = item.Entrant.Person.Fullname();
                    //application number
                    ws.Cells[i, 4].Value2 = item.ApplicationNumber;
                    //summary of balls
                    ws.Cells[i, 5].Value2 = item.balls;

                    i++;
                }

                ws.Range[ws.Cells[i + 1, 1], ws.Cells[i + 1, 2]].Merge();
                ws.Cells[i + 1, 1].Value2 = DateTime.Today.ToString("dd/MM/yyyy");

                app.Visible = true;
            }

            return _specNum;
        }
    }
}
