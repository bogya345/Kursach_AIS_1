using System;
using System.Xml.Serialization;

namespace WpfAppAbit2.Models
{
    //адресс
    [Serializable]
    public class Address
    {
        [XmlIgnore]
        public int ID { get; set; }

        [XmlElement("Town")]
        public string Town { get; set; }

        [XmlElement("Street")]
        public string Street { get; set; }

        [XmlElement("House")]
        public string House { get; set; }


        public void Edit(int ID, string Town, string Street, string House)
        {
            this.ID = ID;
            this.Town = Town;
            this.Street = Street;
            this.House = House;
        }
    }
}