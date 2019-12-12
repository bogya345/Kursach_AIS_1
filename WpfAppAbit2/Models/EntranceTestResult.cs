using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAbit2.Models
{
    //Результаты вступительных испытаний
    public class EntranceTestResult
    {
        public Guid UID { get; set; }
        public int ResultValue { get; set; }
        public Entrant Entrant { get; set; }
        public int ResultSourceType { get; set; }
        public EntranceTestItem EntranceTestItem { get; set; }
        //public CompetitiveGroup CompetitiveGroup { get; set; }

    }
}
