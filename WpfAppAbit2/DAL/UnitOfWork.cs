using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppAbit2.Models;

namespace WpfAppAbit2.DAL
{
    public class UnitOfWork// : IDisposable
    {
        private LocalStorage db = new LocalStorage();

        private RepositoryApplication reposApplication;
        private RepositoryEntrant reposEnrant;

        public RepositoryApplication Applications
        {
            get
            {
                if (reposApplication == null)
                    reposApplication = new RepositoryApplication(db);
                return reposApplication;
            }
        }

        public RepositoryEntrant Entrants
        {
            get
            {
                if (reposEnrant == null)
                    reposEnrant = new RepositoryEntrant(db);
                return reposEnrant;
            }
        }

        public void Save()
        {
            //
        }

        public void Dispose()
        {
            //
        }

        //public void Save()
        //{
        //    db.SaveChanges();
        //}

        //private bool disposed = false;

        //public virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        this.disposed = true;
        //    }
        //}
        //private RepositoryApplication repositoryApplication;
        //private RepositoryEntrant repositoryEntrant;

        //public RepositoryApplication Books
        //{
        //    get
        //    {
        //        if (repositoryApplication == null)
        //            repositoryApplication = new repositoryApplication(db);
        //        return repositoryApplication;
        //    }
        //}

        //public RepositoryEntrant Orders
        //{
        //    get
        //    {
        //        if (orderRepository == null)
        //            orderRepository = new OrderRepository(db);
        //        return orderRepository;
        //    }
        //}

        //public void Save()
        //{
        //    db.SaveChanges();
        //}

        //private bool disposed = false;

        //public virtual void Dispose(bool disposing)
        //{
        //    if (!this.disposed)
        //    {
        //        if (disposing)
        //        {
        //            db.Dispose();
        //        }
        //        this.disposed = true;
        //    }
        //}

        //public void Dispose()
        //{
        //    Dispose(true);
        //    GC.SuppressFinalize(this);
        //}
    }
}
