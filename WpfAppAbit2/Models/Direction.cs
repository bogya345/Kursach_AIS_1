using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAbit2.Models
{
    /// <summary>
    /// направление подготовки
    /// </summary>
    public class Direction : SimpleClass
    {
        public Guid UID { get; set; }
        public string ShortName { get; set; }
        public Department Department { get; set; }
        public Direction(Guid UID, string Name, string ShortName, Department department)
        {
            this.UID = UID;
            this.Department = department;
            this.Name = Name;
            this.ShortName = ShortName;            
        }
    }
}
