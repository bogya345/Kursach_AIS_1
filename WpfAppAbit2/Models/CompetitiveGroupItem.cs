using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAbit2.Models
{
    public class CompetitiveGroupItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Places { get; set; }
        public CompetitiveGroupItem(int ID, string Name, int Places)
        {
            this.Name = Name;
            this.Places = Places;
        }
    }
}
