using System;
using System.Collections.ObjectModel;
using System.Linq;
using WpfAppAbit2.DAL;

namespace WpfAppAbit2.Models
{
    public interface IRepositoryEntrant : IRepository<Entrant>
    {
#pragma warning disable CS0108 // "IRepositoryEntrant.GetAll()" скрывает наследуемый член "IRepository<Entrant>.GetAll()". Если скрытие было намеренным, используйте ключевое слово new.
        ObservableCollection<Entrant> GetAll();
#pragma warning restore CS0108 // "IRepositoryEntrant.GetAll()" скрывает наследуемый член "IRepository<Entrant>.GetAll()". Если скрытие было намеренным, используйте ключевое слово new.
        Entrant Get(Entrant entrant);
        Entrant Get(string Seria, string Number);
    }
    public class RepositoryEntrant : IRepositoryEntrant
    {
        private readonly LocalStorage db;
        public IRepositoryApplication repositoryApplication;
        public IRepositoryPerson repositoryPerson;

        public RepositoryEntrant(LocalStorage db)
        {
            this.db = db;
        }

        public ObservableCollection<Entrant> GetAll()
        {
            var entrantsAll = db.Entrants.Where(x => x.NotDeleted);
            ObservableCollection<Entrant> entrants = new ObservableCollection<Entrant>();
            foreach(Entrant entrant in entrantsAll)
            {
                entrants.Add(entrant);
            }
            return entrants;
        }
        //TODO Entrant заменить на другие функции и перегрузить под разные поисковые запросы
        //TODO В интерфейсах репозиториев можно дописывать новые функции 
        //TODO Что передавать в Get для репозиториев
        public Entrant Get(string Seria, string Number)
        {
            Entrant entrant = db.Entrants.First(x => (x.Person.PersonPassports[0].Series == Seria) && (x.Person.PersonPassports[0].Number == Number));
            
            if (entrant!=null)
            {
                
                return entrant;
            }
            else
                return null;
        }
        public Entrant Get(Entrant entrant)
        {
            bool IsExisted = false;
            Entrant Entrant = new Entrant();
            int ind = db.Entrants.IndexOf(entrant);
            if (ind >= 0) { return db.Entrants[ind]; }
            else { return null; }
        }
        public void Create(Entrant Entrant)
        {

            if (!(repositoryPerson.Existed(Entrant.Person.PersonPassports[0].Series, Entrant.Person.PersonPassports[0].Number)))
            { db.Entrants.Add(Entrant); };
        }
        public void Delete(Entrant Entrant)
        {

            db.Entrants[db.Entrants.IndexOf(Entrant)].NotDeleted = false;
        }
        public void Delete(string Series, string Number)
        {
          
        }
        public void Update(Entrant Entrant, Entrant entrant_prev)
        {
            db.Entrants[db.Entrants.IndexOf(entrant_prev)] = Entrant;
        }
        public ObservableCollection<EntrantApplication> GetApplicationsEntrant(ObservableCollection<EntrantApplication> AllApps,
            Entrant entrant)
        {
            ObservableCollection<EntrantApplication> ApplicationsEntrant = new ObservableCollection<EntrantApplication>();
       
            foreach (EntrantApplication application in AllApps)
            {
                if (application.Entrant == entrant) ApplicationsEntrant.Add(application);
            }
            return ApplicationsEntrant;
        }

        public void AddEntrant(Entrant entrant,
            DateTime RegistrationDate,
            bool NeedHostel,
            string StatusApp,
            CompetitiveGroup CompetitiveGroup,
            SimpleClass ReturnDocumentsType,
            FinSourceAndEduForms FinSourceAndEduForms,
            ObservableCollection<Document> ApplicationDocuments,
            //ObservableCollection<EntranceTestResult> EntranceTestResults,
            ObservableCollection<InstitutionAchievement> InstitutionAchievments,
            bool Original,
            ObservableCollection<EntrantApplication> applications, UnitOfWork unit)
        {
            bool isAcheived = false;
            foreach (EntrantApplication application in applications)
            {
                if ((application.Entrant.Person.PersonPassports[0].Series == entrant.Person.PersonPassports[0].Series)
                   && (application.Entrant.Person.PersonPassports[0].Number == entrant.Person.PersonPassports[0].Number)) { isAcheived = true; }
            }
            if (isAcheived == true)
            {
                //int ApplicationNumber = applications.Count;
                //EntrantApplication app = new EntrantApplication(
                //    entrant, ApplicationNumber, RegistrationDate,
                //    NeedHostel, StatusApp, CompetitiveGroup,
                //    1, FinSourceAndEduForms,
                //    ApplicationDocuments, EntranceTestResults,
                //    InstitutionAchievments, Original);

                //unit.Applications.Create(app);
            }
            else
            {

            }
        }
    }
}


