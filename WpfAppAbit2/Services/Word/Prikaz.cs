using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

using WpfAppAbit2.Services.Patterns;
using WpfAppAbit2.Models;

namespace WpfAppAbit2.Services.Word
{
    public class Prikaz : word
    {
        public Prikaz()
        {
            patternPath = Pattern.Doc.Prikaz;

            doc = app.Documents.Open(patternPath);
            Paragraph freeSpace = doc.Paragraphs.Add();
        }

        public void SetContent(RepositoryApplication apps)
        {
            //doc.Activate();

            app.Selection.Find.Execute(FindText: "#Дата#", ReplaceWith: DateTime.Today);
            app.Selection.Find.Execute(FindText: "#Год#", ReplaceWith: DateTime.Today.Year);

            //var list = apps.GetAll().GroupBy(x => x.CompetitiveGroup.Direction)
            //    .Select()
            //    .ToList();

            var list = from app in apps.GetAll()
                       group app by app.CompetitiveGroup.Direction;

            List<EntrantApplication> temp = new List<EntrantApplication>();

            foreach (IGrouping<Direction, EntrantApplication> g in list)
            {
                //Range range = doc.Sections.Add().Range;
                Range range = doc.Paragraphs.Add().Range;

                Table table = doc.Tables.Add(range, (g.Count() + 1), 3);
                table = doc.Tables[doc.Tables.Count];

                table.Range.ParagraphFormat.SpaceBefore = 5;
                table.Range.ParagraphFormat.SpaceAfter = 7;

                table.Borders[WdBorderType.wdBorderBottom].Visible = true;
                table.Borders[WdBorderType.wdBorderHorizontal].Visible = true;
                table.Borders[WdBorderType.wdBorderLeft].Visible = true;
                table.Borders[WdBorderType.wdBorderRight].Visible = true;
                table.Borders[WdBorderType.wdBorderTop].Visible = true;
                table.Borders[WdBorderType.wdBorderVertical].Visible = true;
                //table.Borders[WdBorderType].Visible = true;

                int i = 1;
                foreach (var r in g)
                {
                    table.Cell(i, 1).Range.Text = i.ToString();
                    table.Cell(i, 2).Range.Text = r.ToString();
                    table.Cell(i, 3).Range.Text = r.balls.ToString();
                    i++;
                }
            }

            //foreach (var item in list)
            //{
            //    Range range = doc.Range();
            //    if (checker == null)
            //        checker = item.CompetitiveGroup.Direction;
            //    if (item.CompetitiveGroup.Direction.Name == checker.Name)
            //    {
            //        counter++;
            //        temp.Add(item);
            //    }
            //    else
            //    {
            //        Table table = doc.Tables.Add(range, (counter + 1), 3);
            //        for (int i = 0; i < temp.Count; i++)
            //        {
            //            table.Cell(i, 0).Range.Text = i.ToString();
            //            table.Cell(i, 1).Range.Text = temp[i].ToString();
            //            table.Cell(i, 2).Range.Text = temp[i].balls.ToString();
            //        }
            //        counter = 0;
            //        temp = new List<EntrantApplication>();
            //    }
            //}
            //if (counter != 0)
            //{
            //    Range range = doc.Range();
            //    Table table = doc.Tables.Add(range, (counter + 1), 3);
            //    for (int i = 0; i < temp.Count; i++)
            //    {
            //        table.Cell(i, 0).Range.Text = i.ToString();
            //        table.Cell(i, 1).Range.Text = temp[i].ToString();
            //        table.Cell(i, 2).Range.Text = temp[i].balls.ToString();
            //    }
            //}
            //foreach (EntrantApplication item1 in apps.GetAll())
            //{
            //    Table table = doc.Tables.Add(doc.Bookmarks.g);
            //}

            app.Visible = true;
        }
    }
}
