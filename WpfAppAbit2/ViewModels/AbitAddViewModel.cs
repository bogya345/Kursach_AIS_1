using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WpfAppAbit2.DAL;
using WpfAppAbit2.Models;
using WpfAppAbit2.Patterns;
using WpfAppAbit2.Views;

namespace WpfAppAbit2.ViewModels
{
    public class AbitAddViewModel : ViewModelBase
    {

        public Entrant Entrant { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool NeedHostel { get; set; }
        public Address Address { get; set; }
        public CompetitiveGroup competitiveGroup { get; set; }
        public EmailOrMailAddress EmailOrMailAddress { get; set; }
        public Person Person { get; set; }
       
        //public ObservableCollection<Department> Departments2ndLevel
        //{
        //    get ; set _departments2ndLevel = value;

        //} = new ObservableCollection<Department>();

        // public Application Application; икупрукрку
        public ObservableCollection<EntrantApplication> EntrantApplications { get; set; } = new ObservableCollection<EntrantApplication>();
        public ObservableCollection<Passport> _entrantPassports = new ObservableCollection<Passport>();
        public ObservableCollection<EntrantApplication> _entrantApplications = new ObservableCollection<EntrantApplication>();
        public ObservableCollection<CompetitiveGroup> _competitiveGroups = new ObservableCollection<CompetitiveGroup>();
        private ObservableCollection<Department> _departments = new ObservableCollection<Department>();
        public ObservableCollection<Department> Departments0stLevel { get; set; } = new ObservableCollection<Department>();
        private ObservableCollection<Department> _departments1stLevel = new ObservableCollection<Department>();
        private ObservableCollection<Department> _departments2ndLevel = new ObservableCollection<Department>();
        private ObservableCollection<Direction> _directions = new ObservableCollection<Direction>();
        //private ObservableCollection<CompetitiveGroup> _competitiveGroups = new ObservableCollection<CompetitiveGroup>();

        public ObservableCollection<Direction> Directions { get => _directions; }
        private Passport _selectedpassport = new Passport();
        public string FormName = "Добавление абитуриента";
        private Department _selectedDepart1st = new Department();
        private Department _selectedDepart2nd = new Department();
        private Direction _selectedDirection = new Direction();
        private EntrantApplication _selectedApplication = new EntrantApplication();
        private CompetitiveGroup _selectedcompetitiveGroup = new CompetitiveGroup();
        public CompetitiveGroup SelectedcompetitiveGroup { get => _selectedcompetitiveGroup; set { _selectedcompetitiveGroup = value; } }
        public ObservableCollection<CompetitiveGroup> CompetitiveGroups = new ObservableCollection<CompetitiveGroup>();

        public Direction SelectedDirection { get => _selectedDirection; set { _selectedDirection = value; } }

        //private Department _selectedDepart1stMem = new Department();
        //private Department _selectedDepart2ndMem = new Department();

        //private LocalStorage db = new LocalStorage();
        //public RepositoryApplication repositoryApplication;
        //public RepositoryEntrant repositoryEntrant;
        //insted use
        public UnitOfWork unit = new UnitOfWork();

        public ObservableCollection<EntrantApplication> Applications;
        public bool NotExisted = false;
        public bool Refreshed = false;


        public void GetDepartments()
        {
            // RepositoryDepartment RepDep = new RepositoryDepartment(db);
            ObservableCollection<Department> departsLocal = new ObservableCollection<Department>();
            departsLocal = unit.Departments.GetAll();
            _departments = new ObservableCollection<Department>();
            foreach (Department department in departsLocal)
            {
                _departments.Add(department);
            }
        }
        public void GetDirections()
        {
            // RepositoryDepartment RepDep = new RepositoryDepartment(db);
            ObservableCollection<Direction> directionLocal = new ObservableCollection<Direction>();
            directionLocal = unit.Directions.GetAll();
            _directions = new ObservableCollection<Direction>();
            foreach (Direction direction in directionLocal)
            {
                _directions.Add(direction);
            }
        }
         public ObservableCollection<Department> Departments
        {
            get
            {
                return _departments;
            }
            set
            {
                _departments = value;
            }

        }
        public ObservableCollection<Department> Departments1stLevel
        {
            get
            {
                return _departments1stLevel;
            }
            set
            {


            }

        }
        public ObservableCollection<Department> Departments2ndLevel
        {
            get
            {
                return _departments2ndLevel;
            }
            set
            {
                _departments2ndLevel = value;
            }

        }
        public EntrantApplication SelectedApplication { get=> _selectedApplication; set { _selectedApplication = value; } }
        //public  _selectedInstitute { get; set; } = new ();
        public Department SelectedDepart1st
        {
            get
            {
                return _selectedDepart1st;
            }
            set
            {
                //if (value == null) { _selectedDepart1st = _selectedDepart1stMem; }
                //else
                //{
                _selectedDepart1st = value;
                //RepositoryDepartment RepDep = new RepositoryDepartment(db);
                GetDepartments();
                //Refreshed = false;
                _departments2ndLevel = unit.Departments.GetAll();
                var _newdepart2ndlevel = _departments2ndLevel.Where(u => (u.HeadDepartment == _selectedDepart1st));
                ObservableCollection<Department> newdepartments = new ObservableCollection<Department>();
                foreach (Department department in _newdepart2ndlevel)
                {
                    newdepartments.Add(department);
                }
                /// _departments2ndLevel.Clear();
                _departments2ndLevel = newdepartments;
                Departments2ndLevel = _departments2ndLevel;
                // }
                //  RefreshSubs();
            }
        }
        public Department SelectedDepart2nd
        {
            get
            {
                return _selectedDepart2nd;
            }
            set
            {
                _selectedDepart2nd = value;
                GetDepartments();
                // Refreshed = false;
                _directions = unit.Directions.GetAll();
                var _newdirection = _directions.Where(u => (u.Department == _selectedDepart2nd));
                ObservableCollection<Direction> newdirections = new ObservableCollection<Direction>();
                foreach (Direction direction in _newdirection)
                {
                    newdirections.Add(direction);
                }
                /// _departments2ndLevel.Clear();
                _directions = newdirections;
                //Directions = _directions;
                //MessageBox.Show(_selectedDepart2nd.ToString());
            }
        }
        public Passport SelectedPassport
        {
            get => _selectedpassport;
            set
            {
                if (Set(ref _selectedpassport, value))
                {
                    SelectedPassport = _selectedpassport;
                }
            }
        }


        // public Department _selectedInst { get; set; } = new Department();
        //public Direction _selectedDirection { get; set; } = new Direction();
        //public CompetitiveGroupItem _selectedCompetitiveGroup { get; set; } = new CompetitiveGroupItem();
        //TODO РЕШИТЬ ВОПРОС С ОБНОВЛЕНИЕМ ДОЧЕРНИХ КОЛЛЕКЦИЙ

        public string _status { get; set; }

        public ObservableCollection<Passport> Passports
        {
            get => _entrantPassports;
            // set => Set(ref _entrantPassports, value);
        }


        public AbitAddViewModel(IView view) : base(view)
        {
            _departments1stLevel.Clear();
            _departments2ndLevel.Clear();
            GetDepartments();
            //_selectedDepart1stMem = _selectedDepart1st;
            //_selectedDepart2ndMem = _selectedDepart2nd;
            // RepositoryDepartment repositoryDepartment = new RepositoryDepartment(db);
            Departments = unit.Departments.GetAll();
            _departments1stLevel.Clear();
            _departments2ndLevel.Clear();
            foreach (Department department in Departments)
            {
                switch (department.DepartmentLevel)
                {
                    case 1: _departments1stLevel.Add(department); break;
                    case 2: _departments2ndLevel.Add(department); break;
                }
            };
            Departments1stLevel = _departments1stLevel;
            Departments2ndLevel = _departments2ndLevel;
            SelectedDepart1st = Departments1stLevel[0];
            SelectedDepart2nd = Departments2ndLevel[1];
            View.Show();
          //  MessageBox.Show(Departments1stLevel[0].ToString());

        }
        public void RefreshSubs()
        {
            //RepositoryDepartment repositoryDepartment = new RepositoryDepartment(db);
            _departments = unit.Departments.GetAll();
            Departments = _departments;
            _departments1stLevel.Clear();
            _departments2ndLevel.Clear();
            foreach (Department department in Departments)
            {
                switch (department.DepartmentLevel)
                {
                    case 1: _departments1stLevel.Add(department); break;
                    case 2: _departments2ndLevel.Add(department); break;
                }
            };

        }
        //public ICommand RefreshSubsDeparts
        //{
        //    get => new UserCommand(() =>
        //    {
        //        RefreshSubs();
        //        MessageBox.Show(_selectedKafedra.ToString());
        //    }
        //    );
        //}
        public ICommand AddPassport
        {
            get => new UserCommand(() =>
            {
                CreatePassport(_selectedpassport.Series, _selectedpassport.Number);
                MessageBox.Show(_selectedpassport.Series);
                MessageBox.Show(_entrantPassports[0].ToString());
            }
            );
        }
        public void CreatePassport(string Series, string Number)
        {
            // _selectedpassport.Series = AbitAddView.tbPasSeria;
            //_selectedpassport.Number = "21412543215";
            ObservableCollection<Entrant> entrants = unit.Entrants.GetAll();
            //foreach (Entrant entrant in entrants)
            //{
            //    entrant.Person.PersonPassports.Any(x=> (x.exist));
            //}
            Entrant = null;
            Passport passportNew = new Passport() { Series = Series, Number = Number };
            if (passportNew.PassportChecked(unit.Persons.GetPassports(), Series, Number))
            {
                Person = unit.Persons.Get(Series, Number);
                _selectedpassport = Person.PersonPassports[0];
                foreach (Entrant entrant in entrants)
                {
                    if (entrant.Person == Person) { Entrant = entrant; }
                };
                if (Entrant == null) { Entrant = new Entrant(); }
            }
            else
            {
                _entrantPassports.Add(_selectedpassport);
                NotExisted = true;
            }
        }
        public EntrantApplication CreateApp()
        {
            Applications = unit.Applications.GetAll();
            RegistrationDate = DateTime.UtcNow;
            EntrantApplication application = new EntrantApplication();
            // Application application = new Application(Entrant, Applications.Count, RegistrationDate, NeedHostel, StatusApp, competitiveGroup, 0, null, );
            return application;
        }
        public void CreateEntrant()
        {
            //  MessageBox.Show(_entrantPassports[0].ToString());
        }
        public ICommand CommandCreateEntrant
        {

            get => new UserCommand(() =>
            {
                CreateEntrant();
            }
            );
        }
        public void BtAddApp()
        {
            unit.Applications.Create(CreateApp());
        }

        //protected override void PrepareViewModel()
        //{
        //    _entrantPassports = new List<Passport>
        //    {

        //    };
        //    _entrantApplications = new List<EntrantApplication>
        //    {

        //    };

        //}
    }
}
