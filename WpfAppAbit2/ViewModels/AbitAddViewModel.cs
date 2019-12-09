using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfAppAbit2.Models;
using WpfAppAbit2.Views;
using WpfAppAbit2.Patterns;


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
        public List<Passport> _entrantPassports;
        public List<EntrantApplication> _entrantApplications;
        public List<CompetitiveGroup> _competitiveGroups;
        public ObservableCollection<Department> Departments;
        public Passport _selectedpassport;
        public string FormName = "Добавление абитуриента";
        public IRepositoryApplication repositoryApplication;
        public IRepositoryEntrant repositoryEntrant;
        public ObservableCollection<EntrantApplication> Applications;
        public List<Passport> Passports
        {
            get => _entrantPassports;
           // set => Set(ref _entrantPassports, value);
        }
        public AbitAddViewModel()  
        {

        }
        public EntrantApplication CreatApp()
        {
            Applications = repositoryApplication.GetAll();
            RegistrationDate = DateTime.UtcNow;
            EntrantApplication application = new EntrantApplication();
           // Application application = new Application(Entrant, Applications.Count, RegistrationDate, NeedHostel, StatusApp, competitiveGroup, 0, null, );
            return application;
        }
        public void CreateEntrant()
        {

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
            repositoryApplication.Create(CreatApp());
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
