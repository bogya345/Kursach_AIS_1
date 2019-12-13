using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfAppAbit2.Models
{
    public class LocalStorage
    {
        //saedgsdfhtsd
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
        public void FillEntranceTestItems()
        {
            EntranceTestItems = new ObservableCollection<EntranceTestItem>()
            {
                new EntranceTestItem()
                {
                    Guid = Guid.NewGuid(),
                    EntranceTestType = 0,
                    MinScore = 45,
                    EntranceTestPriority = 0,
                    Subject = Subjects[0],
                    IsForSPOandVO = false,
                    EntranceTestBenefits = new ObservableCollection<EntranceTestBenefitItem>(),
                    ReplacedEntranceTestItem = null

                },
                new EntranceTestItem()
                {
                    Guid = Guid.NewGuid(),
                    EntranceTestType = 0,
                    MinScore = 40,
                    EntranceTestPriority = 0,
                    Subject = Subjects[1],
                    IsForSPOandVO = false,
                    EntranceTestBenefits = new ObservableCollection<EntranceTestBenefitItem>(),
                    ReplacedEntranceTestItem = null

                },
                new EntranceTestItem()
                {
                    Guid = Guid.NewGuid(),
                    EntranceTestType = 0,
                    MinScore = 45,
                    EntranceTestPriority = 0,
                    Subject = Subjects[2],
                    IsForSPOandVO = false,
                    EntranceTestBenefits = new ObservableCollection<EntranceTestBenefitItem>(),
                    ReplacedEntranceTestItem = null

                },
                new EntranceTestItem()
                {
                    Guid = Guid.NewGuid(),
                    EntranceTestType = 0,
                    MinScore = 38,
                    EntranceTestPriority = 0,
                    Subject = Subjects[3],
                    IsForSPOandVO = false,
                    EntranceTestBenefits = new ObservableCollection<EntranceTestBenefitItem>(),
                    ReplacedEntranceTestItem = null

                }

            };
        }
        public void FillLevelBudjets()
        {
            LevelBudgets = new ObservableCollection<LevelBudget>()
            {
                new LevelBudget() { ID = 1, Name = "Обучение за счёт Федерального бюджета"},
                new LevelBudget() { ID = 2, Name = "Обучение на договорной основе"}

            };
        }
        public void FillCompGroups()
        {
            CompetitiveGroups = new ObservableCollection<CompetitiveGroup>()
            {
                new CompetitiveGroup(){UID = Guid.NewGuid(), Name = Directions[1].ToString()+"  "+ LevelBudgets[0].ToString(), Campaign =  Campaigns[0], Direction = Directions[1],
                    IsForKrym = false, IsAdditional = false,
                    CompetitiveGroupItem = new CompetitiveGroupItem(1, "Бюджетные места  "+ Directions[1].Name, 40),
                    LevelBudget = LevelBudgets[0],
                    EntranceTestItems = new ObservableCollection<EntranceTestItem>()
                    { new EntranceTestItem(){ } } },
                new CompetitiveGroup(){UID = Guid.NewGuid(), Name = Directions[1].ToString()+"  "+ LevelBudgets[1].ToString(), Campaign =  Campaigns[0], Direction = Directions[1],
                    IsForKrym = false, IsAdditional = false,
                    CompetitiveGroupItem = new CompetitiveGroupItem(2, "Контрактные места  "+ Directions[1].Name, 20),
                    LevelBudget = LevelBudgets[0],
                    EntranceTestItems = new ObservableCollection<EntranceTestItem>()
                    { new EntranceTestItem(){ } } },
                new CompetitiveGroup(){UID = Guid.NewGuid(), Name = Directions[3].ToString()+"  "+ LevelBudgets[1].ToString(), Campaign =  Campaigns[0], Direction = Directions[3],
                    IsForKrym = false, IsAdditional = false,
                    CompetitiveGroupItem = new CompetitiveGroupItem(3, "Бюджетные места  "+ Directions[3].Name, 35),
                    LevelBudget = LevelBudgets[0],
                    EntranceTestItems = new ObservableCollection<EntranceTestItem>()
                    { } }
            };
        }
        public void FillLevels()
        {
            EducationLevels = new ObservableCollection<EducationLevel>()
            {
                new EducationLevel(){ID = 1, Name = "Бакалавриат"},
                new EducationLevel(){ID = 2, Name = "Специалитет"},
                new EducationLevel(){ID = 3, Name = "Магистратура"}
            };
        }
        public void FillSubjects()
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
        public void FillentranceTestItems()
        {
            EntranceTestItems = new ObservableCollection<EntranceTestItem>()
            {
                new EntranceTestItem(){Guid = Guid.NewGuid(), EntranceTestType = 0,
                     Subject = Subjects[0], IsForSPOandVO = false, MinScore = 36 },
                new EntranceTestItem(){Guid = Guid.NewGuid(), EntranceTestType = 0,
                     Subject = Subjects[1], IsForSPOandVO = false, MinScore = 45 },
                new EntranceTestItem(){Guid = Guid.NewGuid(), EntranceTestType = 0,
                     Subject = Subjects[2], IsForSPOandVO = false, MinScore = 40 }
            };
        }
        public void FillDirections()
        {
            Directions = new ObservableCollection<Direction>()
            {
                new Direction(Guid.NewGuid(), "Реклама и Связи с общественностью","РиСО", Departments[3]),
                new Direction(Guid.NewGuid(), "Информационные системы и технологии","ИСТ", Departments[2]),
                new Direction(Guid.NewGuid(), "Информатика и вычислительная техника","ИВТ", Departments[2]),
                new Direction(Guid.NewGuid(), "Промышленное и гражданское строительство","ПГС", Departments[6])

            };
        }
        public void FillDepartments()
        {
            Departments.Clear();
            this.Departments = new ObservableCollection<Department>()
            {
                new Department(){ DepartmentGuid = Guid.NewGuid(),  HeadDepartment = null,
                    Name = "ФГБОУ Ухтинский Государственный Технический Университет",
                    ShortName = "ФГБОУ УГТУ", DepartmentLevel = 0}

            };
            Departments.Add(
                new Department()
                {
                    DepartmentGuid = Guid.NewGuid(),
                    HeadDepartment = Departments[0],
                    Name = "Институт Экономики Управления и Информационных Технологий",
                    ShortName = "ИНЭУиИТ",
                    DepartmentLevel = 1
                });
            Departments.Add(
                new Department()
                {
                    DepartmentGuid = Guid.NewGuid(),
                    HeadDepartment = Departments[1],
                    Name = "Кафедра Вычислительной техники, информационных систем и технологий",
                    ShortName = "ВТИСиТ",
                    DepartmentLevel = 2
                });
            Departments.Add(
                new Department()
                {
                    DepartmentGuid = Guid.NewGuid(),
                    HeadDepartment = Departments[1],
                    Name = "Кафедра Социально-коммуникативных технологий",
                    ShortName = "СКТ",
                    DepartmentLevel = 2
                }
                );
            Departments.Add(
                 new Department()
                 {
                     DepartmentGuid = Guid.NewGuid(),
                     HeadDepartment = Departments[1],
                     Name = "Кафедра Менеджмента и маркетинга",
                     ShortName = "МиМ",
                     DepartmentLevel = 2
                 }
                );
            Departments.Add(
                 new Department()
                 {
                     DepartmentGuid = Guid.NewGuid(),
                     HeadDepartment = Departments[0],
                     Name = "Строительно-технологический Институт",
                     ShortName = "СТИ",
                     DepartmentLevel = 1
                 }
                );
            Departments.Add(
                 new Department()
                 {
                     DepartmentGuid = Guid.NewGuid(),
                     HeadDepartment = Departments[5],
                     Name = "Кафедра Промышленного и гражданского строительства",
                     ShortName = "ПГС",
                     DepartmentLevel = 2
                 }
                );

        }
        public void FillEntranceTestResults()
        {
            EntranceTestResults = new ObservableCollection<EntranceTestResult>()
            {
                new EntranceTestResult(){ UID = Guid.NewGuid(), EntranceTestItem = EntranceTestItems[0],
                    Entrant = Entrants[0], ResultValue = 60},
                new EntranceTestResult(){ UID = Guid.NewGuid(), EntranceTestItem = EntranceTestItems[1],
                    Entrant = Entrants[0], ResultValue = 68},
                new EntranceTestResult(){ UID = Guid.NewGuid(), EntranceTestItem = EntranceTestItems[2],
                    Entrant = Entrants[0], ResultValue = 73}
            };
        }
        public void FillApplications()
        {
            Applications = new ObservableCollection<EntrantApplication>
            {
                new EntrantApplication()
                {
                    Entrant = Entrants[0],
                    ApplicationNumber = 0,
                    RegistrationDate = DateTime.Today,
                    NeedHostel = false,
                    StatusApp = "Неполное",
                    CompetitiveGroup = CompetitiveGroups[0],
                    ReturnDocumentsType = 0,
                    balls = 0,
                    ReturnDocumentsDate = DateTime.MinValue,
                    FinSourceAndEduForms = new FinSourceAndEduForms(){ CompetitiveGroup = CompetitiveGroups[0],
                        TargetOrganization = null, IsAgreedDate = DateTime.Today, IsDisagreedDate = DateTime.MinValue,
                        IsForSPOandVO = false}


                }

            };

        }
        private void FillEntrants()
        {
            Entrants = new ObservableCollection<Entrant>()
            {
                new Entrant()
                { Person = new Person( new Passport() { FirstName="B1", LastName= "Volkov1", MiddleName="M1",
                    Series ="1243", Number = "214545" }, null,
                new EmailOrMailAddress("owlkek@gpepa.com", new Address(){ Town = "Сыктыкар", Street = "улица Пушкина", House = "Дом Колатушкина" } ) )
               , IsFromKrym=true
                },
                new Entrant(){ Person = new Person()
                {
                    PersonPassports = new ObservableCollection<Passport>()
                    { new Passport()
                    { FirstName="B2", LastName= "Volkov2", MiddleName="M2" , Series ="1243", Number = "346679"}
                    }
                }, IsFromKrym=false },
                new Entrant(){ Person = new Person()
                {
                        PersonPassports = new ObservableCollection<Passport>()
                        {
                            new Passport() { FirstName="B3", LastName= "Volkov3", MiddleName="M3", Series ="1243", Number = "214241" }
                        }
                }, IsFromKrym=true },
                new Entrant(){ Person = new Person()
                {
                    PersonPassports = new ObservableCollection<Passport>()
                    {
                        new Passport() { FirstName="B4", LastName= "Volkov4", MiddleName="M4",Series ="1243", Number = "535423" }
                    }
                }, IsFromKrym=false },
                new Entrant(){ Person = new Person()
                {
                    PersonPassports = new ObservableCollection<Passport>()
                    { new Passport() { FirstName="B5", LastName= "Volkov5", MiddleName="M5",Series ="1243", Number = "754632" }
                    }
                }, IsFromKrym=true }
            };
          //  MessageBox.Show(Entrants[0].Person.FirstName);
        }
        public LocalStorage()
        {
            FillDepartments();
            FillSubjects();
            FillEntranceTestItems();
            FillLevels();
            FillDirections();
            FillLevelBudjets();
            FillentranceTestItems();

            FillCompGroups();
            FillEntrants();
            FillEntranceTestResults();

            FillApplications();


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