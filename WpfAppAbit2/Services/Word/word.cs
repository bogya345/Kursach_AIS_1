using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Office.Interop.Word;

namespace WpfAppAbit2.Services.Word
{
    public class word
    {
        protected Application app = new Application();
        protected Document doc;

        protected string patternPath;
    }
}
