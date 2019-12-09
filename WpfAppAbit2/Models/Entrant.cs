using System.Collections.ObjectModel;

using System.Xml;
using System.Xml.Serialization;
using System;

namespace WpfAppAbit2.Models
{
    /// <summary>
    /// абитуриент в интерфейсе надо реализовать механизм атрибуты документа (паспорт) механизмы привязки данных, GetType (работает с названиями), 
    /// декораторы для каждого типа документа, через механизм PropertyGrid, нужны конвертеры из строковых типов в класс. 
    /// </summary>
    [Serializable]
    public class Entrant
    {
        //public string UID { get; set; }

        [XmlElement("Person")]
        public Person Person { get; set; }

        [XmlIgnore]
        public bool IsFromKrym { get; set; }

#pragma warning disable CS0649 // Полю "Entrant.repositoryApplication" нигде не присваивается значение, поэтому оно всегда будет иметь значение по умолчанию null.
        IRepositoryApplication repositoryApplication;
#pragma warning restore CS0649 // Полю "Entrant.repositoryApplication" нигде не присваивается значение, поэтому оно всегда будет иметь значение по умолчанию null.

        [XmlIgnore]
        public Document DocumentForKrym { get; set; }

        [NonSerialized]
        public ObservableCollection<EntrantApplication> EntrantApps = new ObservableCollection<EntrantApplication>();

        [NonSerialized]
        public ObservableCollection<Document> EntrantDocuments = new ObservableCollection<Document>();

        [NonSerialized]
        public ObservableCollection<EntranceTestResults> EntranceTestResults = new ObservableCollection<EntranceTestResults>();

        // public ObservableCollection<Document> EntrantDocuments = new ObservableCollection<Document>();
        public ObservableCollection<EntrantApplication> GetApplications(Entrant entrant)
        {
            EntrantApps.Clear();
            ObservableCollection<EntrantApplication> Applications = repositoryApplication.GetAll();
            foreach (EntrantApplication application in Applications)
            {
                if (application.Entrant == entrant) { EntrantApps.Add(application); }
            }

            return EntrantApps;
        }
        public void AddDocument(Document AddDocument)
        {
            EntrantApps.Clear();
            bool canAdd = true;
            foreach (Document document in EntrantDocuments)
            {
                if (document == AddDocument) { canAdd = false; }
            }
            if (canAdd == true) { EntrantDocuments.Add(AddDocument); }

        }
        public void EditDocument(Document EditDocument)
        {

        }

        public Entrant()
        {

        }
        //TODO получить список всех заявлений абитуриента
        public Entrant(Person person, bool IsFromKrym, Document DocumentForKrym, ObservableCollection<EntranceTestResults> EntranceTestResults)
        {
            this.Person = person;
            this.IsFromKrym = IsFromKrym;
            this.DocumentForKrym = DocumentForKrym;
            this.EntranceTestResults = EntranceTestResults;
        }
    }
}
