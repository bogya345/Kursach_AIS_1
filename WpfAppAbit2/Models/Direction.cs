using System;

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
