﻿using System;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

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
    public class EntrantApplication
    {
        [XmlElement("UID")]
        public string UID { get; set; }

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
        public int ReturnDocumentsType { get; set; }

        [XmlIgnore]
        public DateTime ReturnDocumentsDate { get; set; }
        
        [XmlElement("FinSourceAndEduForms")]
        public FinSourceAndEduForms FinSourceAndEduForms { get; set; }

        [XmlArray]
        public ObservableCollection<Document> ApplicationDocuments = new ObservableCollection<Document>();

        [XmlArray]
        public ObservableCollection<EntranceTestResults> EntranceTestResults = new ObservableCollection<EntranceTestResults>();

        [XmlIgnore]
        public ObservableCollection<InstitutionAchievement> InstitutionAchievments = new ObservableCollection<InstitutionAchievement>();
        

        public void balls()
        {
            // CompetitiveGroup.Direction.
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
