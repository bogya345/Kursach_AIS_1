using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace WpfAppAbit2.Models
{
    //тип документа перечислением (удостоверяющий личность, об образовании и т.д.)
    [Serializable]
    public abstract class Document : SimpleClass
    {
        /// <summary>
        /// Абитуриент к которой относится документ
        /// </summary>
        [XmlIgnore]
        public Entrant Entrant { get; set; }

        [XmlElement("DocumentSeries")]
        public string Series { get; set; }

        [XmlElement("DocumentNumber")]
        public string Number { get; set; }

        /// <summary>
        /// Кем выдан
        /// </summary>
        [XmlElement("DocumentOrganization")]
        public string Given { get; set; }

        /// <summary>
        /// Когда выдан
        /// </summary>
        [XmlElement("DocumentDate")]
        public DateTime DateGiven { get; set; }

        [XmlIgnore]
        public List<string> DocType = new List<string>() { "Документ, удостоверяющий лчиность", "Документ об образовании", "Военный документ", "Документ-основание" };
    }
}