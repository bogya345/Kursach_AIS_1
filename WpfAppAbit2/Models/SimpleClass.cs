using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WpfAppAbit2.Models
{
    /// <summary>
    /// Основной класс
    /// </summary>
    public class SimpleClass : DependencyObject, INotifyPropertyChanged
    {
        //todo все что связано с ViewModel - аггрегация (классы, которые хранит ViewModel сам, unitOfWork тоже касается.
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
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName]string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            //вызываем событие, уведомляем все подписчиков об изменении свойства
            NotifyPropertyChanged(propertyName);
            return true;
        }
        protected virtual void NotifyPropertyChanged([CallerMemberName]string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
        