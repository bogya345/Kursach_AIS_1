using System;
using System.Collections.ObjectModel;

namespace WpfAppAbit2.Models
{
    public class Passport : Document
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public Person Person { get; set; }
        public bool GenderID { get; set; }
        /// <summary>
        /// место прописки
        /// </summary>
        public Address Address { get; set; }
        /// <summary>
        /// Код подразделения, выдавшего паспорт
        /// </summary>
        public string UnitCode { get; set; }
        /// <summary>
        /// дата рождения
        /// </summary>
        public DateTime BirthDay { get; set; }
        /// <summary>
        /// место рождения
        /// </summary>
        public Address BirthPlace { get; set; }
        /// <summary>
        /// предыдущий пасспорт
        /// </summary>
        public Passport PreviusPassport { get; set; }
        public bool Actual { get; set; }
        public override string ToString()
        {
            return this.LastName + " "+this.FirstName + " " + this.MiddleName + " " +this.Series + " " +this.Number;
        }
        public Passport(string Series, string Number,  string LastName, string FirstName, string MiddleName, bool GenderID, Address Address, string UnitCode, DateTime BirthDay, Address BirthPlace, Passport PreviusPassport, bool Actual)
        {
            this.Series = Series;
            this.Number = Number;
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.GenderID = GenderID;
            this.Address = Address;
            this.UnitCode = UnitCode;
            this.BirthDay = BirthDay;
            this.PreviusPassport = PreviusPassport;
            this.Actual = true;


        }

        public Passport()
        {
        }
        
        public bool PassportChecked(ObservableCollection<Passport> PersonPassports, string Series, string Number)
        {
            bool PassEx = false;
            foreach (Passport passport in PersonPassports) {
                if ((passport.Series == Series)&&(passport.Number == Number)) { PassEx = true; }
            }
            return PassEx;
        }

    }
}
