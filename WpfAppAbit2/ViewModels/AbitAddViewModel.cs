using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfAppAbit2.Models;
using WpfAppAbit2.Views;
using WpfAppAbit2.Patterns;
using System.Windows;

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
        // public Application Application;
        public ObservableCollection<EntrantApplication> EntrantApplications;
        public ObservableCollection<Passport> _entrantPassports= new ObservableCollection<Passport>();
        public ObservableCollection<EntrantApplication> _entrantApplications = new ObservableCollection<EntrantApplication>();
        public ObservableCollection<CompetitiveGroup> _competitiveGroups = new ObservableCollection<CompetitiveGroup>();
        public ObservableCollection<Department> Departments = new ObservableCollection<Department>();
        public Passport _selectedpassport= new Passport();
        public string FormName = "Добавление абитуриента";
        public RepositoryApplication repositoryApplication;
        public RepositoryEntrant repositoryEntrant;
        public ObservableCollection<EntrantApplication> Applications;
        public bool IsExisted;
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
                CreatePassport();
                MessageBox.Show(_entrantPassports[0].ToString());
            }
            ); 
        }
        public void CreatePassport()
        {
            _selectedpassport.Series = AbitAddView.tbPasSeria;
            _selectedpassport.Number = "21412543215";
            _entrantPassports.Add(_selectedpassport);
        }
        public EntrantApplication CreateApp()
        {
            Applications = repositoryApplication.GetAll();
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
            repositoryApplication.Create(CreateApp());
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
