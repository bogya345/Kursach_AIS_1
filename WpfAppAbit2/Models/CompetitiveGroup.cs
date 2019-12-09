using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace WpfAppAbit2.Models
{
    /// <summary>
    /// конкурс на специальность
    /// </summary>
    public class CompetitiveGroup
    {
        public Guid UID { get; set; }
        public Campaign Campaign { get; set; }
        public string Name { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public EducationSource EducationSource { get; set; }
        public EducationForm EducationForm { get; set; }
        public Direction Direction { get; set; }
       //TODO public ObservableCollection<EducationLevel> EduPrograms = new ObservableCollection<EducationLevel>();
        public bool IsForKrym { get; set; }
        public bool IsAdditional { get; set; }
        public LevelBudget LevelBudget { get; set; }
        public CompetitiveGroupItem CompetitiveGroupItem { get; set; }
        public TargetOrganization TargetOrganization { get; set; }

        public ObservableCollection<EntranceTestItem> EntranceTestItems = new ObservableCollection<EntranceTestItem>();
        public override string ToString()
        {
            return Name;
        }

    }
}
