using System;

namespace WpfAppAbit2.Models
{
    public class OrderOfAdmission
    {
        public Guid UIDOrderOfAdm { get; set; }
        public Campaign Campaign { get; set; }
        public string OrderName { get; set; }
        public string OrderNumber { get; set; }

        public DateTime OrderDate { get; set; }
        public DateTime OrderDatePublished { get; set; }
        public EducationForm EducationForm { get; set; }
        public EducationSource EducationSource { get; set; }
        public EducationLevel EducationLevel { get; set; }
        
        public int Stage { get; set; }


    }
}
