using System;
using System.Collections.ObjectModel;

namespace WpfAppAbit2.Models
{
    public class LocalStorage
    {

        public ObservableCollection<Entrant> Entrants = new ObservableCollection<Entrant>();
        public ObservableCollection<Person> Persons = new ObservableCollection<Person>();

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
        private void FillCompGroups()
        {
            CompetitiveGroups = new ObservableCollection<CompetitiveGroup>()
            {
                new CompetitiveGroup(){UID = Guid.NewGuid(), Campaign =  Campaigns[0], Direction = Directions[1], }
            };
        }
        private void FillLevels()
        {
            EducationLevels = new ObservableCollection<EducationLevel>()
            {
                new EducationLevel(){ID = 1, Name = "Бакалавриат"},
                new EducationLevel(){ID = 2, Name = "Специалитет"},
                new EducationLevel(){ID = 3, Name = "Магистратура"}
            };
        }
        private void FillSubjects()
        {
            Subjects = new ObservableCollection<Subject>()
            {
                new Subject(){ ID = 1, Name = "Физика"},
                new Subject(){ ID = 2, Name = "Математика"},
                new Subject(){ ID = 3, Name = "Русский язык"},
                new Subject(){ ID = 4, Name = "Обществознание"},
                new Subject(){ ID = 5, Name = "Английский язык"}
            };
        }

        public void FillDirections()
        {
            Directions = new ObservableCollection<Direction>()
            {
                new Direction(Guid.NewGuid(), "Реклама и Связи с общественностью","РиСО", Departments[3]),
                new Direction(Guid.NewGuid(), "Информационные системы и технологии","ИСТ", Departments[2]),
                new Direction(Guid.NewGuid(), "Информатика и вычислительная техника","ИВТ", Departments[2])

            };
        }
        private void FillDepartments()
        {
            Departments = new ObservableCollection<Department>()
            {
                new Department(){ DepartmentGuid = Guid.NewGuid(),  HeadDepartment = null,
                    Name = "ФГБОУ Ухтинский Государственный Технический Университет",
                    ShortName = "ФГБОУ УГТУ", DepartmentLevel = 0},
                new Department(){ DepartmentGuid = Guid.NewGuid(),  HeadDepartment = Departments[0],
                    Name = "Институт Экономики Управления и Информационных Технологий",
                    ShortName = "ИНЭУиИТ", DepartmentLevel = 1},
                new Department(){ DepartmentGuid = Guid.NewGuid(),  HeadDepartment = Departments[1],
                    Name = "Кафедра Вычислительной техники, информационных систем и технологий",
                    ShortName = "ВТИСиТ", DepartmentLevel = 2},
                new Department(){ DepartmentGuid = Guid.NewGuid(),  HeadDepartment = Departments[1],
                    Name = "Кафедра Социально-коммуникативных технологий",
                    ShortName = "СКТ", DepartmentLevel = 2},
                 new Department(){ DepartmentGuid = Guid.NewGuid(),  HeadDepartment = Departments[1],
                    Name = "Кафедра Менеджмента и маркетинга",
                    ShortName = "МиМ", DepartmentLevel = 2}

            };
        }
        public LocalStorage()
        {
            FillEntrants();
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