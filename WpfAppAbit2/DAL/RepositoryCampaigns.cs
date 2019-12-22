using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfAppAbit2.Models;

namespace WpfAppAbit2.DAL
{
    public class RepositoryCampaigns : IRepository<Campaign>
    {
        LocalStorage db;
        RepositoryCampaigns(LocalStorage db)
        {
            this.db = db;
        }
        public void Create(Campaign item)
        {
            throw new NotImplementedException();
        }

        public void Delete(Campaign item)
        {
            throw new NotImplementedException();
        }

        public Campaign Get(Campaign item)
        {
            throw new NotImplementedException();
        }

        public ObservableCollection<Campaign> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Campaign item, Campaign item_prev)
        {
            throw new NotImplementedException();
        }

        ObservableCollection<Campaign> IRepository<Campaign>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
