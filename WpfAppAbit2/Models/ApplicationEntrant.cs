using System;
using System.Collections.ObjectModel;

namespace WpfAppAbit2.Models
{
    //заявление абитуриента
    public class EntrantApplication
    {
        public Entrant Entrant { get; set; }
        public int ApplicationNumber { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool NeedHostel { get; set; }
        public string StatusApp { get; set; }
        public CompetitiveGroup CompetitiveGroup { get; set; }
        public int ReturnDocumentsType { get; set; }
        public DateTime ReturnDocumentsDate { get; set; }
        public FinSourceAndEduForms FinSourceAndEduForms { get; set; }

        public ObservableCollection<Document> ApplicationDocuments = new ObservableCollection<Document>();

        public ObservableCollection<EntranceTestResults> EntranceTestResults = new ObservableCollection<EntranceTestResults>();

        public ObservableCollection<InstitutionAchievement> InstitutionAchievments = new ObservableCollection<InstitutionAchievement>();
        public void balls()
        {
           // CompetitiveGroup.Direction.
        }
        public bool Original { get; set; }
        public bool IsMain { get; set; }
        //public ObservableCollection<Document> MinEgeMarks = new ObservableCollection<Document>();
        //public void Test()
        //{
        //   Passport passport =   new Passport();
        //    MinEgeMarks.Add(passport) ;
        //}

        public override string ToString()
        {

            return this.ApplicationNumber.ToString() + this;//TODO: dfgg
        }
        public EntrantApplication()
        {

        }
        public EntrantApplication(
            Entrant Entrant,
         int ApplicationNumber,
         DateTime RegistrationDate,
         bool NeedHostel,
         string StatusApp,
         CompetitiveGroup CompetitiveGroup,
         int ReturnDocumentsType,

         FinSourceAndEduForms FinSourceAndEduForms,
         ObservableCollection<Document> ApplicationDocuments,
         ObservableCollection<EntranceTestResults> EntranceTestResults,
         ObservableCollection<InstitutionAchievement> InstitutionAchievments,
         bool Original)
        {
            this.Entrant = Entrant;
            this.ApplicationNumber = ApplicationNumber;
            this.RegistrationDate = RegistrationDate;
            this.NeedHostel = NeedHostel;
            this.StatusApp = StatusApp;
            this.CompetitiveGroup = CompetitiveGroup;
            this.ReturnDocumentsType = ReturnDocumentsType;
            this.FinSourceAndEduForms = FinSourceAndEduForms;
            this.ApplicationDocuments = ApplicationDocuments;
            this.EntranceTestResults = EntranceTestResults;
            this.InstitutionAchievments = InstitutionAchievments;
            this.Original = Original;
        }


    }
}
