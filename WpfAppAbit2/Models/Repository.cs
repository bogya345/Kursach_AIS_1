using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAbit2.Models
{
    public interface IRepository<T> where T : class
    {
        ObservableCollection<T> GetAll();

        void Create(T item);
        T Get(T item);
        void Update(T item, T item_prev);
        void Delete(T item);
    }

    #region HowTo
    //public class Reposit<T> : IRepository<T> where T : class
    //{
    //    private readonly LocalStorage db;

    //    public Reposit(LocalStorage storage)
    //    {
    //        db = storage;
    //    }

    //    public void Create(T item)
    //    {
    //        //db.
    //    }

    //    public void Delete(T item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public T Get(T item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public ObservableCollection<T> GetAll()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Update(T item)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    #endregion

    public class Repository
    {
#pragma warning disable CS0649 // Полю "Repository.context" нигде не присваивается значение, поэтому оно всегда будет иметь значение по умолчанию null.
        private LocalStorage context;
#pragma warning restore CS0649 // Полю "Repository.context" нигде не присваивается значение, поэтому оно всегда будет иметь значение по умолчанию null.
#pragma warning disable CS0169 // Поле "Repository.repositoryApplication" никогда не используется.
        IRepositoryApplication repositoryApplication;
#pragma warning restore CS0169 // Поле "Repository.repositoryApplication" никогда не используется.
        public ObservableCollection<Campaign> Campaigns;
        public ObservableCollection<CampaignType> CampaignTypes;
        public ObservableCollection<EducationLevel> EducationLevels;
        public ObservableCollection<EntrantApplication> Applications;
        public ObservableCollection<InstitutionAchievement> InstitutionAchievments;
        public ObservableCollection<EntranceTestItem> EntranceTestItems;
        public ObservableCollection<EducationSource> EducationSources;
        public ObservableCollection<OlympicDiplomType> OlympicDiplomTypes;
        public ObservableCollection<CompetitiveGroup> CompetitiveGroups;
        public ObservableCollection<Department> Departments;
        public ObservableCollection<Entrant> GetAllEntrants()
        {
            return context.Entrants;
        }
        public ObservableCollection<CompetitiveGroup> GetAllCompetitiveGroups()
        {
            return context.CompetitiveGroups;
        }
        //public ObservableCollection<Application> GetAllApplications()
        //{
        //    return context.Applications;
        //}
        public ObservableCollection<Department> GetAllDepartments()
        {
            return context.Departments;
        }

        /// <summary>
        /// Получить список дочерних департаментов
        /// </summary>
        /// <param name="Department"></param>
        /// <returns></returns>
        public ObservableCollection<Department> GetSubsidiaryDeparts(Department Department)
        {
            ObservableCollection<Department> SubsidiaryDeparts = new ObservableCollection<Department>();
            ObservableCollection<Department> AllDepartments = GetAllDepartments();
            foreach (Department department in AllDepartments)
            {
                if (department.HeadDepartment == Department) SubsidiaryDeparts.Add(department);
            }
            return SubsidiaryDeparts;
        }
    }
}
