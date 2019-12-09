using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        IRepositoryDepartment _repositoryDepartment;
        public Guid DepartmentGuid { get; set; }
        public Department HeadDepartment { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        RepositoryDepartment repositoryDepartment;
        public ObservableCollection<Department> DougthersDepartments = new ObservableCollection<Department>();
        /// <summary>
        /// 0 - институт 1 - 
        /// </summary>
        /// 
        public ObservableCollection<Department> GetSubsidiaryDeparts(Department Department)
        {
            ObservableCollection<Department> SubsidiaryDeparts = new ObservableCollection<Department>();
            ObservableCollection<Department> AllDepartments = _repositoryDepartment.GetAll();
            foreach (Department department in AllDepartments)
            {
                if (department.HeadDepartment == Department) SubsidiaryDeparts.Add(department);
            }
            return SubsidiaryDeparts;
        }
        public void GetGetSubsidiaryDeparts()
        {
            DougthersDepartments = GetSubsidiaryDeparts(this);
        }
        public int DepartmentLevel { get; set; }
        public override string ToString()
        {
            return ShortName;
        }
        
        
        //TODO добавить функцию получения списка всех дочерних департаментов.
    }
}
