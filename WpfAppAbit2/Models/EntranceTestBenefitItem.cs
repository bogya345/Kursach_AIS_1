using System;
using System.Collections.ObjectModel;

namespace WpfAppAbit2.Models
{
    /// <summary>
    /// Условия предоставления льгот
    /// </summary>
    public class EntranceTestBenefitItem
    {
        public Guid UID { get; set; }

        public ObservableCollection<OlympicDiplomType> OlympicDiplomTypes = new ObservableCollection<OlympicDiplomType>();
        public BenefitKind BenefitKind { get; set; }
        public bool IsForAllOlympics { get; set; }
        public LevelForAllOlympic LevelForAllOlympic { get; set; }
        public ObservableCollection<ProfileOlympic> ProfileForAllOlympics = new ObservableCollection<ProfileOlympic>();
        public int MinEgeMark { get; set; }
        public ObservableCollection<Olympic> Olympics = new ObservableCollection<Olympic>();

    }
}