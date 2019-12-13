using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace WpfAppAbit2.Models
{
    public class Person
    {

        public Guid UID { get; set; }
        //public Passport Passport { get; set; }
        /// <summary>
        /// список паспортов 
        /// </summary>
        /// 
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }

        public ObservableCollection<Passport> PersonPassports { get; set; }
        public string CustomInformation { get; set; }
        public EmailOrMailAddress EmailOrMailAddress { get; set; }
        public override string ToString()
        {
            string FIO = this.PersonPassports[0].LastName + " " + this.PersonPassports[0].FirstName + " " + this.PersonPassports[0].MiddleName;
            return FIO;
        }
        public bool CheckExisted(string Series, string Number, ObservableCollection<Person> persons)
        {
            return persons.Any(x => (x.PersonPassports[0].Series == Series) && (x.PersonPassports[0].Number == Number));
        }
        public bool CheckPasExisted(string Series, string Number)
        {
            return PersonPassports.Any(x => (x.Series == Series) && (x.Number == Number));
        }
        public void PersonPassAdd(string Series, string Number, string LastName, string FirstName,
                    string MiddleName, bool GenderID, Address Address, string UnitCode, DateTime BirthDay,
                    Address BirthPlace)
        {
            Passport Passport = new Passport(Series, Number, LastName, FirstName, MiddleName, GenderID, Address, UnitCode, BirthDay, BirthPlace, null, true);
#pragma warning disable CS0219 // Переменной "IsNotExist" присвоено значение, но оно ни разу не использовано.
            bool IsNotExist = false;
#pragma warning restore CS0219 // Переменной "IsNotExist" присвоено значение, но оно ни разу не использовано.
            if (CheckPasExisted(Series, Number)) { PersonPassports.Add(Passport); }
            else { return; }
        }
        public Person() { }
        public Person(Passport passport, string CustomInformation, EmailOrMailAddress emailOrMailAddress)
        {
            this.UID = Guid.NewGuid();
            this.PersonPassports = new ObservableCollection<Passport>();
            this.PersonPassports.Add(passport);
            this.LastName = PersonPassports[0].LastName;
            this.FirstName = PersonPassports[0].FirstName;
            this.MiddleName = PersonPassports[0].MiddleName;
            this.EmailOrMailAddress = emailOrMailAddress;
        }

        //TODO добавление абитуриента (подача заявления), редактирование, зачисление.
        public void PersonPassSort()
        {
            PersonPassports.OrderByDescending(x => x.DateGiven);
        }

        public string Fullname()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
    }
}
