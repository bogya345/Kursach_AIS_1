using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAbit2.Models
{
    public interface IRepositoryDepartment : IRepository<Department>
    {
        ObservableCollection<Department> GetAll();
        Department Get(Department entrant);



    }
    public class RepositoryDepartment : IRepositoryDepartment
    {
        public LocalStorage db;

        public RepositoryDepartment(LocalStorage db)
        {
            this.db = db;
        }
        public ObservableCollection<Department> GetAll()
        {
            return db.Departments;
        }

        public Department Get(Department item)
        {
            throw new System.NotImplementedException();
        }
        public void Create(Department item)
        {
            db.Departments.Add(item);
        }
        public void Update(Department item, Department item_prev)
        {
            db.Departments[db.Departments.IndexOf(item_prev)] = item;
        }
        public void Delete( Department department)
        {
            db.Departments.Remove(department);
        }
    }
}
