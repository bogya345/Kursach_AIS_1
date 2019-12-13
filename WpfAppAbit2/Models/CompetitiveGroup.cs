using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

using System.Xml.Serialization;

namespace WpfAppAbit2.Models
{
    /// <summary>
    /// конкурс на специальность
    /// </summary>
    public class CompetitiveGroup
    {
        [XmlElement("UID")]
        public Guid UID { get; set; }

        [XmlIgnore]
        public Campaign Campaign { get; set; }

        [XmlIgnore]
        public string Name { get; set; }

        [XmlIgnore]
        public EducationLevel EducationLevel { get; set; }

        [XmlIgnore]
        public EducationSource EducationSource { get; set; }

        [XmlIgnore]
        public EducationForm EducationForm { get; set; }

        [XmlIgnore]
        public Direction Direction { get; set; }
        //TODO public ObservableCollection<EducationLevel> EduPrograms = new ObservableCollection<EducationLevel>();

        [XmlIgnore]
        public bool IsForKrym { get; set; }

        [XmlIgnore]
        public bool IsAdditional { get; set; }

        [XmlIgnore]
        public LevelBudget LevelBudget { get; set; }

        [XmlIgnore]
        public CompetitiveGroupItem CompetitiveGroupItem { get; set; }

        [XmlIgnore]
        public TargetOrganization TargetOrganization { get; set; }

        [XmlIgnore]
        public ObservableCollection<EntranceTestItem> EntranceTestItems = new ObservableCollection<EntranceTestItem>();
        public override string ToString()
        {
            return Name;
        }

    }
}
