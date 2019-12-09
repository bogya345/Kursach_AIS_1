using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAbit2.Models
{
    //Общие льготы
    public class ApplicationCommonBenefit
    {
        public Guid UID { get; set; }
        public CompetitiveGroup CompetitiveGroup { get; set; }
        public Document Document { get; set; }
        public BenefitKind BenefitKind { get; set; }
    }
}
