using System;
using System.Collections.ObjectModel;

namespace WpfAppAbit2.Models
{
    public class LocalStorage
    {

        public ObservableCollection<Entrant> Entrants = new ObservableCollection<Entrant>();
        public ObservableCollection<Person> Persons = new ObservableCollection<Person>();
        public ObservableCollection<Campaign> Campaigns = new ObservableCollection<Campaign>()
        {
            new Campaign()
            {
                Guid =  Guid.NewGuid(),
                Name = "Приёмная кампания 2019",
                YearStart = DateTime.Now.Year,
                Status = "Ведётся набор"
    }
    };
        public ObservableCollection<CampaignType> CampaignTypes = new ObservableCollection<CampaignType>();
        public ObservableCollection<EducationLevel> EducationLevels = new ObservableCollection<EducationLevel>();
        public ObservableCollection<EducationForm> EducationForms = new ObservableCollection<EducationForm>();
        public ObservableCollection<LevelBudget> LevelBudgets = new ObservableCollection<LevelBudget>();
        public ObservableCollection<EntrantApplication> Applications = new ObservableCollection<EntrantApplication>();
        public ObservableCollection<InstitutionAchievement> InstitutionAchievments = new ObservableCollection<InstitutionAchievement>();
        public ObservableCollection<EntranceTestItem> EntranceTestItems = new ObservableCollection<EntranceTestItem>();
        public ObservableCollection<EducationSource> EducationSources = new ObservableCollection<EducationSource>();
        public ObservableCollection<OlympicDiplomType> OlympicDiplomTypes = new ObservableCollection<OlympicDiplomType>();
        public ObservableCollection<CompetitiveGroup> CompetitiveGroups = new ObservableCollection<CompetitiveGroup>();
        public ObservableCollection<Department> Departments = new ObservableCollection<Department>();
        public ObservableCollection<TargetOrganization> TargetOrganizations = new ObservableCollection<TargetOrganization>();
        public ObservableCollection<Direction> Directions = new ObservableCollection<Direction>();
        public ObservableCollection<Subject> Subjects = new ObservableCollection<Subject>();

        public LocalStorage()
        {
            //FillEntrants();
            FillApplications();
        }

        private void FillEntrants()
        {
            Entrants = new ObservableCollection<Entrant>()
            {
                new Entrant(){ Person = new Person(){ PersonPassports = new ObservableCollection<Passport>(){ new Passport() { FirstName="B1", LastName= "Volkov1", MiddleName="M1" } } }, IsFromKrym=true },
                new Entrant(){ Person = new Person(){ PersonPassports = new ObservableCollection<Passport>(){ new Passport() { FirstName="B2", LastName= "Volkov2", MiddleName="M2" } } }, IsFromKrym=false },
                new Entrant(){ Person = new Person(){ PersonPassports = new ObservableCollection<Passport>(){ new Passport() { FirstName="B3", LastName= "Volkov3", MiddleName="M3" } } }, IsFromKrym=true },
                new Entrant(){ Person = new Person(){ PersonPassports = new ObservableCollection<Passport>(){ new Passport() { FirstName="B4", LastName= "Volkov4", MiddleName="M4" } } }, IsFromKrym=false },
                new Entrant(){ Person = new Person(){ PersonPassports = new ObservableCollection<Passport>(){ new Passport() { FirstName="B5", LastName= "Volkov5", MiddleName="M5" } } }, IsFromKrym=true }
            };
        }

        private void FillApplications()
        {
            Applications = new ObservableCollection<EntrantApplication>()
            {
                new EntrantApplication(){
                    UID = "0001",
                    Entrant = new Entrant(){
                        Person = new Person(){
                            UID = new Guid(),
                            PersonPassports = new ObservableCollection<Passport>(){ new Passport() { FirstName="B1", LastName= "Volkov1", MiddleName="M1" } } }, IsFromKrym=true },
                    ApplicationNumber = 1001,
                    RegistrationDate = DateTime.Today,
                    NeedHostel = true,
                    StatusApp = "1",

                    ReturnDocumentsType = 20001,
                    ReturnDocumentsDate = DateTime.Today
                },

            };
        }

        //public ObservableCollection<Passport> Passports = new ObservableCollection<Passport>();

        //private LocalStorage() => Entrants = new ObservableCollection<Entrant>()
        //{

        //    new 
        //    {
        //        PotwMags ="Африка",
        //        Humans = new List<Mag>()
        //        {
        //            new Mag
        //            {
        //                FIO = "Вишняков Максим",
        //                MarkaCar ="Honda",
        //                FIOR ="Шакиров Даниил",
        //                NameTeam ="Белокожий африканец",
        //                KSezon ="12",
        //                NomerCar ="34",
        //                Country ="Алжир"
        //            },
        //        },
        //    },

        //    new Potw
        //    {
        //        PotwMags ="Севреная Америка",
        //        Humans = new List<Mag>()
        //        {
        //            new Mag
        //            {
        //                FIO = "Петров Артем",
        //                MarkaCar="BMW",
        //                FIOR="Шакиров Даниил",
        //                NameTeam="Пиндостан",
        //                KSezon="12",
        //                NomerCar="6",
        //                Country="Канада"
        //            },

        //            new Mag
        //            {
        //                FIO = "Быков Сергей",
        //                MarkaCar ="BMW",
        //                FIOR ="Шакиров Даниил",
        //                NameTeam ="Пиндостан",
        //                KSezon ="12",
        //                NomerCar ="5",
        //                Country ="США"
        //            },

        //            new Mag
        //            {
        //                FIO = "Лучкевич Никита",
        //                MarkaCar ="BMW",
        //                FIOR ="Козлов Иван",
        //                NameTeam ="Весёлые колёса",
        //                KSezon ="12",
        //                NomerCar ="7",
        //                Country ="США"
        //            },
        //        },
        //    },

        //    new Potw
        //    {
        //        PotwMags ="Южная Америка",
        //        Humans = new List<Mag>()
        //        {

        //        },
        //    },

        //    new Potw
        //    {
        //        PotwMags ="Европа",
        //        Humans = new List<Mag>()
        //        {

        //        },
        //    },

        //    new Potw
        //    {
        //        PotwMags ="Азия",
        //        Humans = new List<Mag>()
        //        {

        //        },
        //    },

        //    new Potw
        //    {
        //        PotwMags ="Австралия",
        //        Humans = new List<Mag>()
        //        {

        //        },
        //    },
        //};

    }
}