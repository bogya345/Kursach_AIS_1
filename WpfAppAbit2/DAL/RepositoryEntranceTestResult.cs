using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppAbit2.Models;

namespace WpfAppAbit2.DAL
{
    public interface IRepositoryEntranceTestResult : IRepository<EntranceTestResult>
    {
        ObservableCollection<EntranceTestResult> GetAll();
        EntranceTestResult Get(EntranceTestResult item);
    }
    public class RepositoryEntranceTestResult : IRepositoryEntranceTestResult
    {
        public LocalStorage db;

        public RepositoryEntranceTestResult(LocalStorage db)
        {
            this.db = db;
        }
        public ObservableCollection<EntranceTestResult> GetAll()
        {
            //   db.FillDepartments();
            return db.EntranceTestResults;
        }

        public EntranceTestResult Get(EntranceTestResult item)
        {
            throw new System.NotImplementedException();
        }
        public void Create(EntranceTestResult item)
        {
            db.EntranceTestResults.Add(item);
        }
        public void Update(EntranceTestResult item, EntranceTestResult item_prev)
        {
            db.EntranceTestResults[db.EntranceTestResults.IndexOf(item_prev)] = item;
        }
        public void Delete(EntranceTestResult item)
        {
            db.EntranceTestResults.Remove(item);
        }
    }
 
}
