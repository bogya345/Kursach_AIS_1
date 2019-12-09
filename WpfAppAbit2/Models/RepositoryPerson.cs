using System.Collections.ObjectModel;
using System.Linq;

namespace WpfAppAbit2.Models
{
    public interface IRepositoryPerson : IRepository<Person>
    {
#pragma warning disable CS0108 // "IRepositoryPerson.GetAll()" скрывает наследуемый член "IRepository<Person>.GetAll()". Если скрытие было намеренным, используйте ключевое слово new.
        ObservableCollection<Person> GetAll();
#pragma warning restore CS0108 // "IRepositoryPerson.GetAll()" скрывает наследуемый член "IRepository<Person>.GetAll()". Если скрытие было намеренным, используйте ключевое слово new.
         bool Existed(Person Person);
    }

    public class RepositoryPerson : IRepositoryPerson
    {
#pragma warning disable CS0649 // Полю "RepositoryPerson.db" нигде не присваивается значение, поэтому оно всегда будет иметь значение по умолчанию null.
        private LocalStorage db;
#pragma warning restore CS0649 // Полю "RepositoryPerson.db" нигде не присваивается значение, поэтому оно всегда будет иметь значение по умолчанию null.
        public ObservableCollection<Person> GetAll()
        {
            return db.Persons;
        }

        public Person Get(Person person)
        {
#pragma warning disable CS0219 // Переменной "IsExisted" присвоено значение, но оно ни разу не использовано.
            bool IsExisted = false;
#pragma warning restore CS0219 // Переменной "IsExisted" присвоено значение, но оно ни разу не использовано.
            Person Entrant = new Person();
            int ind = db.Persons.IndexOf(person);
            if (ind >= 0) { return db.Persons[ind]; }
            else { return null; }
        }
        public bool Existed(Person Person)
        {
            return (db.Persons.Any(x => (x.PersonPassports[0].Series == Person.PersonPassports[0].Series)
            && (x.PersonPassports[0].Number == Person.PersonPassports[0].Number)));
        }
        public void Create(Person Person)
        {
            if (!db.Persons.Any(x => (x.PersonPassports[0].Series == Person.PersonPassports[0].Series)
            && (x.PersonPassports[0].Number == Person.PersonPassports[0].Number))) { db.Persons.Add(Person); };
        }
        public void Delete(Person Person)
        {
            db.Persons.Remove(Person);
        }
        public void Update(Person Person, Person person_prev)
        {
            db.Persons[db.Persons.IndexOf(Person)] = Person;
        }
    }
}
