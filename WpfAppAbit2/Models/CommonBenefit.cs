using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAbit2.Models
{
    //Сведения об общих льготах
    public class CommonBenefit : EntranceTestBenefitItem
    {
        //public Guid UID { get; set; }
        //public ObservableCollection<OlympicDiplomType> OlympicDiplomTypes = new ObservableCollection<OlympicDiplomType>();
        //public BenefitKind BenefitKind { get; set; }
        //public bool IsForAllOlympics { get; set; }
        public bool IsCreative { get; set; }
        public bool IsAthletic { get; set; }
        //public LevelForAllOlympic LevelForAllOlympic { get; set; }
        //public ObservableCollection<ProfileOlympic> ProfileForAllOlympics = new ObservableCollection<ProfileOlympic>();
        public ObservableCollection<MinSubjMark> MinEgeMarks = new ObservableCollection<MinSubjMark>();

        

    }
}
