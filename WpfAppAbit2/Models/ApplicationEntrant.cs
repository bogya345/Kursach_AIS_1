using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using System.Linq;

using System.IO;

namespace WpfAppAbit2.Models
{
    [Serializable]
    public class ListOfEntrantApplication
    {
        public ObservableCollection<EntrantApplication> Applications { get; set; }
        public ListOfEntrantApplication()
        {

        }
        public ListOfEntrantApplication(ObservableCollection<EntrantApplication> apps)
        {
            Applications = apps;
        }
    }

    //заявление абитуриента
    [Serializable]
    public class EntrantApplication : SimpleClass
    {
        [XmlElement("UID")]
        public Guid UID { get; set; }

        [XmlElement("Entrant")]
        public Entrant Entrant { get; set; }

        [XmlElement("ApplicationNumber")]
        public int ApplicationNumber { get; set; }

        [XmlElement("RegistrationDate")]
        public DateTime RegistrationDate { get; set; }

        [XmlElement("NeedHostel")]
        public bool NeedHostel { get; set; }

        [XmlElement("StatusID")]
        public string StatusApp { get; set; }

        [XmlElement("Competitive")]
        public CompetitiveGroup CompetitiveGroup { get; set; }

        [XmlIgnore]
        public int balls=0;

        [XmlIgnore]
        public int ReturnDocumentsType { get; set; }

        [XmlIgnore]
        public DateTime ReturnDocumentsDate { get; set; }
        
        [XmlElement("FinSourceAndEduForms")]
        public FinSourceAndEduForms FinSourceAndEduForms { get; set; }

        [XmlArray]
        public ObservableCollection<Document> ApplicationDocuments = new ObservableCollection<Document>();

        [XmlArray]
        public ObservableCollection<EntranceTestResult> EntranceTestResults = new ObservableCollection<EntranceTestResult>();

        [XmlIgnore]
        public ObservableCollection<InstitutionAchievement> InstitutionAchievments = new ObservableCollection<InstitutionAchievement>();

        public void EntrTestResults(ObservableCollection<EntranceTestResult> entranceTestResults)
        {
            //LocalStorage db = new LocalStorage();
            // RepositoryEntranceTestResult repositoryEntranceTestResult = new RepositoryEntranceTestResult(db);
            var TestResults = entranceTestResults
                .Where(x => (x.Entrant.Person.PersonPassports[0].Series == this.Entrant.Person.PersonPassports[0].Series)
                && (x.Entrant.Person.PersonPassports[0].Number == this.Entrant.Person.PersonPassports[0].Number));
            TestResults.Where(x => x.EntranceTestItem == this.CompetitiveGroup.EntranceTestItems.First(y => y == x.EntranceTestItem));
        }
        public bool NotDeleted = true;
        /// <summary>
        /// обновление суммы баллов в заявлении
        /// </summary>
        public void RefreshBall()
        {
            int balls = 0;
            foreach (EntranceTestResult entranceTestResult in EntranceTestResults)
            {
                balls += entranceTestResult.ResultValue;
            }
        }

        [XmlIgnore]
        public bool Original { get; set; }

        [XmlIgnore]
        public bool IsMain { get; set; }
        //public ObservableCollection<Document> MinEgeMarks = new ObservableCollection<Document>();
        //public void Test()
        //{
        //   Passport passport =   new Passport();
        //    MinEgeMarks.Add(passport) ;
        //}

        public override string ToString()
        {
            return this.ApplicationNumber.ToString() + "    " + Entrant.Person.ToString();//TODO: dfgg
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
            //this.EntranceTestResults = EntranceTestResults;
            this.InstitutionAchievments = InstitutionAchievments;
            this.Original = Original;
        }

        /// <summary>
        /// For single application
        /// </summary>
        /// <param name="path">Path xml-file to save</param>
        public void SaveAsXml(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                XmlSerializer xml = new XmlSerializer(typeof(EntrantApplication));
                xml.Serialize(fs, this);
            }
        }
    }
}
