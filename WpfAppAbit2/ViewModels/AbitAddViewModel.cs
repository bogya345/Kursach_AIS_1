using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using WpfAppAbit2.DAL;
using WpfAppAbit2.Models;
using WpfAppAbit2.Patterns;
using WpfAppAbit2.Views;

namespace WpfAppAbit2.ViewModels
{
    public class AbitAddViewModel : ViewModelBase, INotifyPropertyChanged
    {

        public Entrant Entrant { get; set; }
        public DateTime RegistrationDate { get => _registrationDate; set { _registrationDate = value; } }
        private bool _needhostel = false;
        public bool NeedHostel
        {
            get { return _needhostel; }
            set
            {
                Set(ref _needhostel, value);

                _needhostel = value;
            }
        }
        public Address Address { get; set; }
        public CompetitiveGroup competitiveGroup { get; set; }
        public EmailOrMailAddress EmailOrMailAddress { get; set; }

        private Person _person;
        public Person Person
        {
            get => _person;
            set
            {
                _person = value;
                OnPropertyChanged("Person");
                Set(ref _person, value);
            }
        }

        private Passport _selectedpassport = new Passport();
        public Passport SelectedPassport
        {
            get => _selectedpassport;
            set
            {
                _selectedpassport = value;
                OnPropertyChanged("SelectedPassport");
                Set(ref _selectedpassport, value);
                //WpfAppAbit2.Views.AbitAddView.tbL.GetBindingExpression().UpdateSource();
                //_selectedpassport.LastName = value.LastName;
            }
            //set
            //{
            //    if (Set(ref _selectedpassport, value))
            //    {
            //        SelectedPassport = _selectedpassport;
            //    }
            //}
        }

        public new event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }


        public bool IsEditApp { get => _isEditApp; }
        private bool _isEditApp = false;
        //public Passport   sport { get => _selectedpassport; }
        //public ObservableCollection<Department> Departments2ndLevel
        //{
        //    get ; set _departments2ndLevel = value;

        //} = new ObservableCollection<Department>();

        // public Application Application; икупрукрку
        private DateTime _registrationDate;

        private ObservableCollection<EntrantApplication> _entrantApplications = new ObservableCollection<EntrantApplication>();
        public ObservableCollection<EntrantApplication> EntrantApplications { get { return _entrantApplications; } set { _entrantApplications = value; } }
        private ObservableCollection<Passport> _entrantPassports = new ObservableCollection<Passport>();
        private ObservableCollection<CompetitiveGroup> _competitiveGroups = new ObservableCollection<CompetitiveGroup>();
        private ObservableCollection<Department> _departments = new ObservableCollection<Department>();
        public ObservableCollection<Department> Departments0stLevel { get; set; } = new ObservableCollection<Department>();
        private ObservableCollection<Department> _departments1stLevel = new ObservableCollection<Department>();
        private ObservableCollection<Department> _departments2ndLevel = new ObservableCollection<Department>();
        private ObservableCollection<Direction> _directions = new ObservableCollection<Direction>();
        //private ObservableCollection<CompetitiveGroup> _competitiveGroups = new ObservableCollection<CompetitiveGroup>();

        // public ObservableCollection<Direction> Directions { get => _directions; }
        //   private Passport _selectedpassport = new Passport();
        public string FormName { get => "Добавление абитуриента"; }
        private Department _selectedDepart1st = new Department();
        private Department _selectedDepart2nd = new Department();
        private Direction _selectedDirection = new Direction();
        private EntrantApplication _selectedApplication = new EntrantApplication();
        private CompetitiveGroup _selectedcompetitiveGroup = new CompetitiveGroup();
        public ObservableCollection<CompetitiveGroup> CompetitiveGroups
        {
            get
            { return _competitiveGroups; }
            set
            {
                Set(ref _competitiveGroups, value);
            }
        }


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
            { return _departments; }
            set
            { _departments = value; }

        }
        public ObservableCollection<Department> Departments1stLevel
        {
            get
            { return _departments1stLevel; }
            set
            {
                Set(ref _departments1stLevel, value);

            }

        }
        public ObservableCollection<Department> Departments2ndLevel
        {
            get
            { return _departments2ndLevel; }
            set
            {
                Set(ref _departments2ndLevel, value);
            }

        }
        public ObservableCollection<Direction> Directions
        {
            get
            { return _directions; }
            set
            {
                Set(ref _directions, value);
            }
        }

        public void ChooseEntrant()
        {

        }
        public EntrantApplication SelectedApplication
        {
            get { return _selectedApplication; }
            set
            {
                Set(ref _selectedApplication, value);
                _selectedcompetitiveGroup = _selectedApplication.CompetitiveGroup;
                _registrationDate = _selectedApplication.RegistrationDate;
                _selectedDirection = _selectedcompetitiveGroup.Direction;
                _selectedDepart2nd = _selectedDirection.Department;
                _selectedDepart1st = SelectedDepart2nd.HeadDepartment;
            }
        }
        //public  _selectedInstitute { get; set; } = new ();
        public Department SelectedDepart1st
        {
            get
            { return _selectedDepart1st; }
            set
            {
                //if (value == null) { _selectedDepart1st = _selectedDepart1stMem; }
                //else
                //{
                _selectedDepart1st = value;
                //RepositoryDepartment RepDep = new RepositoryDepartment(db);
                GetDepartments();
                //Refreshed = false;
                var _newdepart2ndlevel = unit.Departments.GetAll().Where(u => (u.HeadDepartment == _selectedDepart1st));
                // = _departments2ndLevel
                ObservableCollection<Department> newdepartments = new ObservableCollection<Department>();
                foreach (Department department in _newdepart2ndlevel)
                {
                    newdepartments.Add(department);
                }
                _departments2ndLevel = new ObservableCollection<Department>();
                foreach (Department department in newdepartments)
                {
                    _departments2ndLevel.Add(department);
                }
                //_departments2ndLevel = newdepartments;
                Departments2ndLevel = new ObservableCollection<Department>();
                foreach (Department department in newdepartments)
                {
                    Departments2ndLevel.Add(department);
                }
                // OnPropertyChanged("Departments2ndLevel");
                //Set(ref Departments2ndLevel, value);
            }
        }
        public Department SelectedDepart2nd
        {
            get
            { return _selectedDepart2nd; }
            set
            {
                _selectedDepart2nd = value;
                GetDepartments();
                _directions = unit.Directions.GetAll();
                if (!_selectedDepart2nd.AllGorups)
                {
                    var _newdirection = _directions.Where(u => (u.Department == _selectedDepart2nd));
                    ObservableCollection<Direction> newdirections = new ObservableCollection<Direction>();
                    foreach (Direction direction in _newdirection)
                    {
                        newdirections.Add(direction);
                    }
                    _directions = newdirections;
                    View.UpdateList();
                    Directions = new ObservableCollection<Direction>();
                    foreach (Direction direction in newdirections)
                    {
                        Directions.Add(direction);
                    }
                }
                else
                {
                    //var _newdirection = _directions ;
                    ObservableCollection<Direction> newdirections = new ObservableCollection<Direction>();
                    foreach (Direction direction in _directions)
                    {
                        newdirections.Add(direction);
                    }
                    _directions = newdirections;
                    View.UpdateList();
                    Directions = new ObservableCollection<Direction>();
                    foreach (Direction direction in newdirections)
                    {
                        Directions.Add(direction);
                    }
                }
            }
        }

        public Direction SelectedDirection
        {
            get { return _selectedDirection; }
            set
            {
                _selectedDirection = value;
                GetDirections();
                _competitiveGroups = unit.CompetitiveGroups.GetAll();
                var _newcompetitivegroups = _competitiveGroups.Where(x => (x.Direction == _selectedDirection));
                ObservableCollection<CompetitiveGroup> newcompetitiveGroups = new ObservableCollection<CompetitiveGroup>();
                foreach (CompetitiveGroup competitiveGroup in _newcompetitivegroups)
                {
                    newcompetitiveGroups.Add(competitiveGroup);
                }
                _competitiveGroups = newcompetitiveGroups;
                View.UpdateList();
                CompetitiveGroups = new ObservableCollection<CompetitiveGroup>();
                foreach (CompetitiveGroup сompetitiveGroup in _newcompetitivegroups)
                {
                    CompetitiveGroups.Add(сompetitiveGroup);
                }

            }
        }
        public CompetitiveGroup SelectedCompetitiveGroup
        {
            get => _selectedcompetitiveGroup;
            set { _selectedcompetitiveGroup = value; }
        }
        //public Passport SelectedPassport
        //{
        //    get => _selectedpassport;
        //    set
        //    {
        //        if (Set(ref _selectedpassport, value))
        //        {
        //            SelectedPassport = _selectedpassport;
        //        }
        //    }
        //}
        // public Department _selectedInst { get; set; } = new Department();
        //public Direction _selectedDirection { get; set; } = new Direction();
        //public CompetitiveGroupItem _selectedCompetitiveGroup { get; set; } = new CompetitiveGroupItem();
        //TODO РЕШИТЬ ВОПРОС С ОБНОВЛЕНИЕМ ДОЧЕРНИХ КОЛЛЕКЦИЙ
        private string _status;
        public string Status { get => _status; set { _status = value; } }
        public ObservableCollection<Passport> EntrantPassports
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
            SelectedDepart2nd = Departments2ndLevel[0];
            //Entrant = unit.Entrants.GetAll()[0];
            //Person = Entrant.Person;
            //_selectedpassport = Entrant.Person.PersonPassports[0];
            //ObservableCollection<EntrantApplication> Applications = unit.Applications.GetAll();
            //_selectedApplication = Entrant.GetApplications(Applications)[0]; Series ="1243", Number = "214545" },
            //  LoadEntrant("1243", "214545");

            //.Show(Person.EmailOrMailAddress.Email);
            View.Show();

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
        public void DeleteEntrApp()
        {
            if (_selectedApplication != null)
            {
                try
                {
                    unit.Applications.Delete(_selectedApplication.ApplicationNumber);
                }
                catch
                {
                    MessageBox.Show("Усп, что-то пошло не так. Возможно это заявление уже удалено");
                }
            }
        }
        public void SaveEntrApplication()
        {
            if (_selectedApplication != null)
            {
                try
                {
                    _selectedApplication.CompetitiveGroup = _selectedcompetitiveGroup;
                    _selectedApplication.Entrant = Entrant;
                    unit.Applications.Delete(_selectedApplication.ApplicationNumber);

                }
                catch
                {
                    MessageBox.Show("Усп, что-то пошло не так. Возможно это заявление уже удалено");
                }
            }
        }
        public ICommand SaveAppChanges
        {
            get => new UserCommand(() =>
            {

                SaveEntrApplication();
            }
            );
        }

        public ICommand CheckPassport
        {
            get => new UserCommand(() =>
            {
                CreatePassport(_selectedpassport.Series, _selectedpassport.Number);
                //MessageBox.Show(_selectedpassport.Series);
                //MessageBox.Show(_entrantPassports[0].ToString());
                MessageBox.Show(SelectedPassport.Series);
                MessageBox.Show(SelectedPassport.LastName);

            }
            );
        }
        public ICommand DeleteApp
        {
            get => new UserCommand(() =>
            {

                DeleteEntrApp();
            }
            );
        }
        private bool CheckPersonExist(string Series, string Number)
        {
            return unit.Entrants.GetAll().Any(x => (x.Person.PersonPassports[0].Series == Series) && (x.Person.PersonPassports[0].Number == Number));
        }

        public void CreatePassport(string Series, string Number)
        {

            ObservableCollection<Entrant> entrants = unit.Entrants.GetAll();
            Entrant = null;
            Passport passportNew = new Passport() { Series = Series, Number = Number };

            if (passportNew.PassportChecked(unit.Persons.GetPassports(), Series, Number) || (CheckPersonExist(Series, Number)))
            {
                Entrant = unit.Entrants.Get(Series, Number);
                if (Entrant != null)
                {
                    _selectedpassport = Entrant.Person.PersonPassports[0];
                    Person = Entrant.Person;
                    _entrantPassports = Person.PersonPassports;
                    LoadEntrant(Series, Number);
                }
                //foreach (Entrant entrant in entrants)
                //{
                //    if (entrant.Person == Person)
                //    {
                //        Entrant = entrant;
                //        LoadEntrant();
                //    }
                //};
                if (Entrant == null) { Entrant = new Entrant(); }
            }
            else
            {
                _entrantPassports.Add(_selectedpassport);

                NotExisted = true;
            }
        }

        /// <summary>
        /// загрузка абитуриента по поиску.
        /// </summary>
        /// <param name="Series"></param>
        /// <param name="Number"></param>
        /// 
        //TODO доделать поиск результатов экзаменов, загрузка результатов происходит, проблемы с фильтрацией.
        private void LoadEntrant(string Series, string Number)
        {
            Entrant = unit.Entrants.Get(Series, Number);
            Person = Entrant.Person;
            ObservableCollection<EntrantApplication> entrantApplications = unit.Applications.GetAll();
            ObservableCollection<EntranceTestResult> allTestResults = unit.EntranceTestResults.GetAll();
            Entrant.EntrantApps = unit.Entrants.GetApplicationsEntrant(entrantApplications, Entrant);

            foreach (EntrantApplication entrantApp in Entrant.EntrantApps)
            {
                var entrTesResult = unit.EntranceTestResults.GetAll().Where(x => ((x.Entrant.Person.PersonPassports[0].Series == Entrant.Person.PersonPassports[0].Series)
                && (x.Entrant.Person.PersonPassports[0].Number == Entrant.Person.PersonPassports[0].Number))
                && (entrantApp.CompetitiveGroup.EntranceTestItems.Any(y => y.Guid == x.EntranceTestItem.Guid)));

                foreach (EntranceTestResult entranceTestResult in entrTesResult)
                {
                    entrantApp.EntranceTestResults.Add(entranceTestResult);
                }
            }
            if (Entrant.EntrantApps.Count > 0)
            {
                _selectedApplication = Entrant.EntrantApps[0];
            }
            _selectedpassport = Person.PersonPassports[0];
            //MessageBox.Show(Entrant.ToString());
            //   SelectedDepart2nd = Departments2ndLevel[1];
        }
        public EntrantApplication CreateApp()
        {
            GetApps();
            _registrationDate = DateTime.UtcNow;
            EntrantApplication application = new EntrantApplication();
            Applications.Add(application);
            // Application application = new Application(Entrant, Applications.Count, RegistrationDate, NeedHostel, StatusApp, competitiveGroup, 0, null, );
            return application;
        }
        public void GetApps()
        {
            var applications = unit.Applications.GetAll().Where(x => (x.Entrant.Person.PersonPassports[0].Series == Person.PersonPassports[0].Series)
           && (x.Entrant.Person.PersonPassports[0].Number == Person.PersonPassports[0].Number));
            Applications = new ObservableCollection<EntrantApplication>();
            foreach (EntrantApplication app in applications)
            {
                Applications.Add(app);
            }
        }
        public void CreateEntrant()
        {
            unit.Entrants.AddEntrant
               (Entrant, DateTime.Now, false, Status, SelectedCompetitiveGroup, new SimpleClass() { ID = 1, Name = "не надо поступать сюда" }, null, null, null, true, _entrantApplications, unit);
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

        public ICommand CommandAddApplication
        {
            get => new UserCommand(() =>
            {
                CreateApp();
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
