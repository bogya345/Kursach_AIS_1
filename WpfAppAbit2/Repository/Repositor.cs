using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

using WpfAppAbit2.Models;

namespace WpfAppAbit2.Repository
{
    class RepositorEntrant : IRepositor<Entrant>
    {
        private readonly LocalStorage db;

        public RepositorEntrant(LocalStorage storage)
        {
            db = storage;
        }

        ObservableCollection<Entrant> IRepositor<Entrant>.GetAll()
        {
            return db.Entrants;
        }

        public void Delete(Entrant item)
        {

        }

        public void Delete(Func<Entrant, bool> func)
        {
            //db.Entrants.Remove(func);
        }

        public Entrant Get(Entrant item)
        {
            throw new NotImplementedException();
        }

        public Entrant Get(Func<Entrant, bool> func)
        {
            return db.Entrants.First(func);
        }
    }
    //class RepositorDepartment : IRepository<Department>
    //{
    //    private readonly LocalStorage db;

    //    public RepositorDepartment(LocalStorage storage)
    //    {
    //        db = storage;
    //    }


    //    public void Delete(Entrant item)
    //    {

    //    }

    //    public void Delete(Func<Department, bool> func)
    //    {
    //        //db.Entrants.Remove(func);
    //    }

    //    public Entrant Get(Department item)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public Department Get(Func<Department, bool> func)
    //    {
    //        return db.Departments.First(func);
    //    }
    //}
//    class RepositorApplication : IRepositor<EntrantApplication>
//    {
//        private readonly LocalStorage db;

//        public RepositorApplication(LocalStorage storage)
//        {
//            db = storage;
//        }

//        ObservableCollection<EntrantApplication> IRepositor<EntrantApplication>.GetAll()
//        {
//            return db.Applications;
//        }

//        public void Delete(EntrantApplication item)
//        {

//        }

//        public void Delete(Func<EntrantApplication, bool> func)
//        {
//            //db.Entrants.Remove(func);
//        }

//        public Entrant Get(EntrantApplication item)
//        {
//            throw new NotImplementedException();
//        }

//        public Entrant Get(Func<EntrantApplication, bool> func)
//        {
//            return db.Applications.First(func);
//        }
//    }
}
