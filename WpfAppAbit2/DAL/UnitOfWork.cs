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
