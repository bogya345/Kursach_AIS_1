using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfAppAbit2.Models;
using WpfAppAbit2.Views;
using WpfAppAbit2.Patterns;
using System.Windows;

using WpfAppAbit2.DAL;
using System.Linq;

namespace WpfAppAbit2.ViewModels
{
    public class AbitAddViewModel
    {
        public Entrant Entrant;
        public DateTime RegistrationDate;
        public bool NeedHostel = false;
        public string StatusApp;
        public Address Address { get; set; }
        public CompetitiveGroup competitiveGroup;
        public EmailOrMailAddress EmailOrMailAddress { get; set; }
        public Person Person;
        // public Application Application; икупрукрку
        public ObservableCollection<EntrantApplication> EntrantApplications;
        public ObservableCollection<Passport> _entrantPassports = new ObservableCollection<Passport>();
        public ObservableCollection<EntrantApplication> _entrantApplications = new ObservableCollection<EntrantApplication>();
        public ObservableCollection<CompetitiveGroup> _competitiveGroups = new ObservableCollection<CompetitiveGroup>();
        public ObservableCollection<Department> Departments = new ObservableCollection<Department>();
        public Passport _selectedpassport { get; set; } = new Passport();
        public string FormName = "Добавление абитуриента";
        
        //public RepositoryApplication repositoryApplication;
        //public RepositoryEntrant repositoryEntrant;
        //insted use
        public UnitOfWork unit = new UnitOfWork();

        public ObservableCollection<EntrantApplication> Applications;
        public bool IsExisted;


        public EntrantApplication _selectedApplication { get; set; } = new EntrantApplication();
        //public  _selectedInstitute { get; set; } = new ();
        public Department _selectedKafedra { get; set; } = new Department();
        //public Direction _selectedDirection { get; set; } = new Direction();
        //public CompetitiveGroupItem _selectedCompetitiveGroup { get; set; } = new CompetitiveGroupItem();
        public string _status { get; set; }

        public ObservableCollection<Passport> Passports
        {
            get => _entrantPassports;
            // set => Set(ref _entrantPassports, value);
        }
        public AbitAddViewModel()
        {

        }
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
            Passport passportNew = new Passport() { Series = Series, Number = Number };
            if (passportNew.PassportChecked(unit.Persons.GetPassports(), Series, Number)) { };
            _entrantPassports.Add(_selectedpassport);
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
