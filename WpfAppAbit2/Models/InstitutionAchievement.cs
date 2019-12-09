using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAbit2.Models
{
    //Индивидуальные достижения, учитываемые образовательной организацией
    public class InstitutionAchievement
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public int IdCategory { get; set; }
        public int MaxValue { get; set; }
        public Campaign Campaign { get; set; }

    }
}

