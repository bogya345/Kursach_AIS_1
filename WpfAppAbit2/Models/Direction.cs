using System;

using System.Xml.Serialization;

namespace WpfAppAbit2.Models
{
    /// <summary>
    /// направление подготовки
    /// </summary>
    [Serializable]
    public class Direction : SimpleClass
    {
        [XmlElement("UID")]
        public Guid Guid { get; set; }

        [XmlElement("ShortName")]
        public string ShortName { get; set; }

        [XmlIgnore]
        public Department Department { get; set; }
        public Direction(Guid UID, string Name, string ShortName, Department department)
        {
            this.Guid = UID;
            this.Department = department;
            this.Name = Name;
            this.ShortName = ShortName;
        }
        public Direction()
        {

        }
        public override string ToString()
        {
            return ShortName;
        }

        public string ToString2()
        {
            return Name;
        }
    }
}
