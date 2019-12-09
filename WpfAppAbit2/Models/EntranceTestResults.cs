using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace WpfAppAbit2.Models
{
    //Результаты вступительных испытаний
    [Serializable]
    public class EntranceTestResults
    {
        [XmlElement("UID")]
        public Guid UID { get; set; }

        [XmlElement("ResultValue")]
        public int ResultValue { get; set; }

        [XmlElement("ResultSourceType")]
        public int ResultSourceType { get; set; }

        [XmlElement("EntranceTestItem")]
        public EntranceTestItem EntranceTestItem { get; set; }

        [XmlElement("CompetitiveGroup")]
        public CompetitiveGroup CompetitiveGroup { get; set; }
    }
}
