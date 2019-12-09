using System;
using System.Collections.ObjectModel;

namespace WpfAppAbit2.Models
{
    //Приёмная кампания
    public class Campaign
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
        public int YearStart { get; set; }
        public int YearEnd { get; set; }
        public string Status { get; set; }
        public ObservableCollection<string> EducationForms = new ObservableCollection<string>();
       // public SimpleClass status { get; set; }
        public ObservableCollection<EducationLevel> EducationLevels = new ObservableCollection<EducationLevel>();
        public CampaignType CampaignType { get; set; }
       // public EducationLevel EducationLevel { get; set; }


    }
}
