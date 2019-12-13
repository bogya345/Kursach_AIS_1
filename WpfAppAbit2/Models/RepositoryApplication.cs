using System.Collections.ObjectModel;

namespace WpfAppAbit2.Models
{
    public interface IRepositoryApplication : IRepository<EntrantApplication>
    {
#pragma warning disable CS0108 // "IRepositoryApplication.GetAll()" скрывает наследуемый член "IRepository<Application>.GetAll()". Если скрытие было намеренным, используйте ключевое слово new.
        ObservableCollection<EntrantApplication> GetAll();
#pragma warning restore CS0108 // "IRepositoryApplication.GetAll()" скрывает наследуемый член "IRepository<Application>.GetAll()". Если скрытие было намеренным, используйте ключевое слово new.
        EntrantApplication Get(Entrant entrant);
    }
    public class RepositoryApplication : IRepositoryApplication
    {
        public LocalStorage db;
        public RepositoryApplication(LocalStorage context)
        {
            this.db = context;
        }
        //public ObservableCollection<Application> Applications => db.Applications;

        public ObservableCollection<EntrantApplication> GetAll()
        {
            return db.Applications;
        }

        public EntrantApplication Get(Entrant entrant)
        {
            bool IsExisted = false;
            EntrantApplication Application = new EntrantApplication();
            foreach (EntrantApplication application in db.Applications)
            {
                if (application.Entrant == entrant) { IsExisted = true; Application = application; };
            }
            if (IsExisted) { return Application; }
            else { return null; }
        }
        /// <summary>
        /// Получить все заявления по конкурсу
        /// </summary>
        /// <param name="competitiveGroup"></param>
        /// <returns></returns>
        /// 
        public void Delete(EntrantApplication Application)
        {
            foreach (EntrantApplication application in db.Applications)
            {
                if (application == Application) { db.Applications.Remove(application); }
            }
        }
        public void Delete(int ApplicationNumber)
        {
            foreach (EntrantApplication application in db.Applications)
            {
                if (application.ApplicationNumber == ApplicationNumber) { db.Applications.Remove(application); }
            }
        }
        public void Update(EntrantApplication Application, EntrantApplication Application_prev)
        {
            int i = 0;
            foreach (EntrantApplication application in db.Applications)
            {
                if (application == Application_prev) { db.Applications[i] = Application; }
                i++;
            }
        }
        public void Create(EntrantApplication Application)
        {
            foreach (EntrantApplication application in db.Applications)
            {
                if (application == Application) { return; }
            }
            db.Applications.Add(Application);
        }
        public ObservableCollection<EntrantApplication> GetApplicationsCompGroup(CompetitiveGroup competitiveGroup)
        {
            ObservableCollection<EntrantApplication> ApplicationCompGroup = new ObservableCollection<EntrantApplication>();
            ObservableCollection<EntrantApplication> AllApps = GetAll();
            foreach (EntrantApplication application in AllApps)
            {
                if (application.CompetitiveGroup == competitiveGroup) ApplicationCompGroup.Add(application);
            }
            return ApplicationCompGroup;
        }

        /// <summary>
        /// Получить все заявления в подразделении
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        public ObservableCollection<EntrantApplication> GetApplicationsDepartment(Department department)
        {
            ObservableCollection<EntrantApplication> ApplicationsDepartment = new ObservableCollection<EntrantApplication>();
            ObservableCollection<EntrantApplication> AllApps = GetAll();
            foreach (EntrantApplication application in AllApps)
            {
                if (application.CompetitiveGroup.Direction.Department == department) ApplicationsDepartment.Add(application);
            }
            return ApplicationsDepartment;
        }

        public EntrantApplication Get(EntrantApplication item)
        {
            throw new System.NotImplementedException();
        }
    }
}
