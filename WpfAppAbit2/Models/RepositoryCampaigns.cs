using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAbit2.Models
{
    public class RepositoryCampaigns : IRepository<Campaign>
    {
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

        public void Update(Campaign item)
        {
            throw new NotImplementedException();
        }

        ObservableCollection<Campaign> IRepository<Campaign>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
