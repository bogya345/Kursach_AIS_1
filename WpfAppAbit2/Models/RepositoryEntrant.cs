using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace WpfAppAbit2.Models
{
    public interface IRepositoryEntrant : IRepository<Entrant>
    {
#pragma warning disable CS0108 // "IRepositoryEntrant.GetAll()" скрывает наследуемый член "IRepository<Entrant>.GetAll()". Если скрытие было намеренным, используйте ключевое слово new.
        ObservableCollection<Entrant> GetAll();
#pragma warning restore CS0108 // "IRepositoryEntrant.GetAll()" скрывает наследуемый член "IRepository<Entrant>.GetAll()". Если скрытие было намеренным, используйте ключевое слово new.
        Entrant Get(Entrant entrant);


    }
    public class RepositoryEntrant : IRepositoryEntrant
    {
#pragma warning disable CS0649 // Полю "RepositoryEntrant.db" нигде не присваивается значение, поэтому оно всегда будет иметь значение по умолчанию null.
        private readonly LocalStorage db;
#pragma warning restore CS0649 // Полю "RepositoryEntrant.db" нигде не присваивается значение, поэтому оно всегда будет иметь значение по умолчанию null.
        public IRepositoryApplication repositoryApplication;
        public IRepositoryPerson repositoryPerson;

        public RepositoryEntrant(LocalStorage db)
        {
            this.db = db;
        }

        public ObservableCollection<Entrant> GetAll()
        {
            return db.Entrants;
        }
        //TODO Entrant заменить на другие функции и перегрузить под разные поисковые запросы
        //TODO В интерфейсах репозиториев можно дописывать новые функции 
        //TODO Что передавать в Get для репозиториев
        public Entrant Get(Entrant entrant)
        {
#pragma warning disable CS0219 // Переменной "IsExisted" присвоено значение, но оно ни разу не использовано.
            bool IsExisted = false;
#pragma warning restore CS0219 // Переменной "IsExisted" присвоено значение, но оно ни разу не использовано.
            Entrant Entrant = new Entrant();
            int ind = db.Entrants.IndexOf(entrant);
            if (ind >= 0) { return db.Entrants[ind]; }
            else { return null; }
        }
        public void Create(Entrant Entrant)
        {

            if ((!db.Entrants.Any(x => (x.Person == Entrant.Person)))
                && (repositoryPerson.Existed(Entrant.Person)))
            { db.Entrants.Add(Entrant); };
        }
        public void Delete(Entrant Entrant)
        {
            db.Entrants.Remove(Entrant);
        }
        public void Update(Entrant Entrant)
        {
            db.Entrants[db.Entrants.IndexOf(Entrant)] = Entrant;
        }
        public ObservableCollection<EntrantApplication> GetApplicationsEntrant(Entrant entrant)
        {
            ObservableCollection<EntrantApplication> ApplicationsEntrant = new ObservableCollection<EntrantApplication>();
            ObservableCollection<EntrantApplication> AllApps = repositoryApplication.GetAll();
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
            ObservableCollection<EntranceTestResult> EntranceTestResults,
            ObservableCollection<InstitutionAchievement> InstitutionAchievments,
            bool Original,
            ObservableCollection<EntrantApplication> applications)
        {
            bool isAcheived = false;
            foreach (EntrantApplication application in applications)
            {
                if ((application.Entrant.Person.PersonPassports[0].Series == entrant.Person.PersonPassports[0].Series)
                   && (application.Entrant.Person.PersonPassports[0].Number == entrant.Person.PersonPassports[0].Number)) { isAcheived = true; }
            }
            if (isAcheived == true)
            {
                int ApplicationNumber = applications.Count;
                EntrantApplication app = new EntrantApplication(
                    entrant, ApplicationNumber, RegistrationDate,
                    NeedHostel, StatusApp, CompetitiveGroup,
                    1, FinSourceAndEduForms,
                    ApplicationDocuments, EntranceTestResults,
                    InstitutionAchievments, Original);

                applications.Add(app);
            }
            else
            {

            }
        }
    }
}


