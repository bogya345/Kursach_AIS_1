using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAbit2.Models
{
    public interface IRepositoryCompetetiveGroup : IRepository<CompetitiveGroup>
    {
        ObservableCollection<CompetitiveGroup> GetAll();
        CompetitiveGroup Get(CompetitiveGroup item);
    }
    public class RepositoryCompetitiveGroup : IRepositoryCompetetiveGroup
    {
        public LocalStorage db;

        public RepositoryCompetitiveGroup(LocalStorage db)
        {
            this.db = db;
        }
        public ObservableCollection<CompetitiveGroup> GetAll()
        {
            //   db.FillDepartments();
            return db.CompetitiveGroups;
        }

        public CompetitiveGroup Get(CompetitiveGroup item)
        {
            throw new System.NotImplementedException();
        }
        public void Create(CompetitiveGroup item)
        {
            db.CompetitiveGroups.Add(item);
        }
        public void Update(CompetitiveGroup item, CompetitiveGroup item_prev)
        {
            db.CompetitiveGroups[db.CompetitiveGroups.IndexOf(item_prev)] = item;
        }
        public void Delete(CompetitiveGroup item)
        {
            db.CompetitiveGroups.Remove(item);
        }
    }

}
