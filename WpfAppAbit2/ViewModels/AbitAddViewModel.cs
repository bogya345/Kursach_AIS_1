﻿using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using WpfAppAbit2.Models;
using WpfAppAbit2.Patterns;

namespace WpfAppAbit2.ViewModels
{
    public class AbitAddViewModel
    {
        public Entrant Entrant;
        public DateTime RegistrationDate { get; set; }
        public bool NeedHostel = false;
        public string StatusApp;
        public Address Address { get; set; }
        public CompetitiveGroup competitiveGroup { get; set; }
        public EmailOrMailAddress EmailOrMailAddress { get; set; }
        public Person Person;
        // public Application Application; икупрукрку
        public ObservableCollection<EntrantApplication> EntrantApplications = new ObservableCollection<EntrantApplication>();
        public ObservableCollection<Passport> _entrantPassports = new ObservableCollection<Passport>();
        public ObservableCollection<EntrantApplication> _entrantApplications = new ObservableCollection<EntrantApplication>();
        public ObservableCollection<CompetitiveGroup> _competitiveGroups = new ObservableCollection<CompetitiveGroup>();
        public ObservableCollection<Department> Departments = new ObservableCollection<Department>();
        public Passport _selectedpassport { get; set; } = new Passport();
        public string FormName = "Добавление абитуриента";
        public RepositoryApplication repositoryApplication;
        public RepositoryEntrant repositoryEntrant;
        public LocalStorage db = new LocalStorage();
        public ObservableCollection<EntrantApplication> Applications;
        public bool IsExisted = true;
        public ObservableCollection<Passport> Passports
        {
            get => _entrantPassports;
            //set => Set(ref _entrantPassports, value);
        }
        public AbitAddViewModel()
        {

        }

        public void FillEntrant(Entrant entrant)
        {
            _entrantApplications = entrant.GetApplications();
            _entrantPassports = entrant.Person.PersonPassports;
            MessageBox.Show("Абитуриент с такими паспортными данными существует");
        }
        public void CheckPassport(string Seria, string Number)
        {
            repositoryEntrant = new RepositoryEntrant(db);
            Entrant = repositoryEntrant.Get(Seria, Number);
            if (Entrant != null) { FillEntrant(Entrant); }
           
        }
        public ICommand AddPassport
        {
            get => new UserCommand(() =>
            {
                CreatePassport();
                MessageBox.Show(_selectedpassport.Series);
                MessageBox.Show(_entrantPassports[0].ToString());
            }
            );
        }
        public void CreatePassport()
        {
            //_selectedpassport.Series = AbitAddView.tbPasSeria;
            //_selectedpassport.Number = "21412543215";
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

    }
}
