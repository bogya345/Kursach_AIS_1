using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAbit2.Models
{
    //TODO конкурсные списки/итоговые списки - Excel , все специальности на разных листах
    //TODO заявление абитуиента  + согласие на обработку данных - Word
    //TODO приказ на зачисление Word
    public  class Department
    {
        public Guid DepartmentGuid { get; set; }
        public Department HeadDepartment { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        /// <summary>
        /// 0 - институт 1 - 
        /// </summary>
        public int DepartmentLevel { get; set; }
        public override string ToString()
        {
            return ShortName;
        }
        //TODO добавить функцию получения списка всех дочерних департаментов.
    }
}
