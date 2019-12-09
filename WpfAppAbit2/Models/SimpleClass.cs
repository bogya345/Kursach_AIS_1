using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfAppAbit2.Models
{
    /// <summary>
    /// Основной класс
    /// </summary>
    public class SimpleClass : INotifyPropertyChanged
    {
        public int ID { get; set; }
        public string Name  { get; set; }
        //public SimpleClass(int ID, string Name)
        //{
        //    this.ID = ID;
        //    this.Name = Name;
        //}
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
        