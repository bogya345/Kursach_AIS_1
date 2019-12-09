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
}
