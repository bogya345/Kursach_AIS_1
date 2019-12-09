using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace WpfAppAbit2.Repository
{
    public interface IRepositor<T> where T : class
    {
        ObservableCollection<T> GetAll();

        T Get(T item);
        T Get(Func<T, bool> func);

        void Delete(T item);
        void Delete(Func<T, bool> func);
    }
}
