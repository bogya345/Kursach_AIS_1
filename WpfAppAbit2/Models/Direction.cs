using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace WpfAppAbit2.Models
{
    [Serializable]
    public class Direction : SimpleClass
    {
        [XmlElement("UID")]
        public Guid Guid { get; set; }

        [XmlElement("ShortName")]
        public string ShortName { get; set; }

        [XmlIgnore]
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
