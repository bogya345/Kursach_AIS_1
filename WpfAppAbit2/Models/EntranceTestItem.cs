using System;
using System.Collections.ObjectModel;

using System.Xml.Serialization;

namespace WpfAppAbit2.Models
{
    [Serializable]
    public class EntranceTestItem
    {
        /// <summary>
        /// Вступительные испытания конкурсной группы
        /// </summary>
        [XmlElement("UID")]
        public Guid Guid { get; set; }

        [XmlIgnore]
        public int EntranceTestType { get; set; }

        [XmlIgnore]
        public int MinScore { get; set; }
        public int EntranceTestPriority { get; set; }

        [XmlIgnore]
        public int EntranceTestPrority { get; set; }

        [XmlIgnore]
        public Subject Subject { get; set; }

        [XmlIgnore]
        public bool IsForSPOandVO { get; set; }

        [XmlIgnore]
        public ObservableCollection<EntranceTestBenefitItem> EntranceTestBenefits = new ObservableCollection<EntranceTestBenefitItem>();

        [XmlIgnore]
        public EntranceTestItem ReplacedEntranceTestItem { get; set; }
    }
}