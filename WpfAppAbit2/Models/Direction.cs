using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAbit2.Models
{
    public class Direction : SimpleClass
    {
        public Guid Guid { get; set; }
        public string ShortName { get; set; }
        public Department Department { get; set; }
        public Direction(Guid Guid, string Name, string ShortName, Department department)
        {
            this.Guid = Guid;
            this.Department = department;
            this.Name = Name;
            this.ShortName = ShortName;            
        }
    }
}
