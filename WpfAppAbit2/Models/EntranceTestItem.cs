using System;
using System.Collections.ObjectModel;

namespace WpfAppAbit2.Models
{
    public class EntranceTestItem
    {
        /// <summary>
        /// Вступительные испытания конкурсной группы
        /// </summary>
        public Guid Guid { get; set; }
        public int EntranceTestType { get; set; }
        public int MinScore { get; set; }
        public int EntranceTestPriority { get; set; }
        public Subject Subject { get; set; }
        public bool IsForSPOandVO { get; set; }
        public ObservableCollection<EntranceTestBenefitItem> EntranceTestBenefits = new ObservableCollection<EntranceTestBenefitItem>();
        public EntranceTestItem ReplacedEntranceTestItem { get; set; }

    }
}