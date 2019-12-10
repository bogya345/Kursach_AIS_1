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
        public int balls = 0;
        public ObservableCollection<Document> ApplicationDocuments = new ObservableCollection<Document>();

        public ObservableCollection<EntranceTestResult> EntranceTestResults = new ObservableCollection<EntranceTestResult>();

        public ObservableCollection<InstitutionAchievement> InstitutionAchievments = new ObservableCollection<InstitutionAchievement>();

        public void RefreshBall()
        {
            int balls = 0;
            foreach (EntranceTestResult entranceTestResult in EntranceTestResults)
            {
                balls += entranceTestResult.ResultValue;
            }

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
            return this.ApplicationNumber.ToString() + Entrant.Person.ToString();//TODO: dfgg
        }
        public EntrantApplication()
        {
            balls = 0;
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
         ObservableCollection<EntranceTestResult> EntranceTestResults,
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
