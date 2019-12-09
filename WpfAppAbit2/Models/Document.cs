using System;
using System.Collections.Generic;

namespace WpfAppAbit2.Models
{
    //тип документа перечислением (удостоверяющий личность, об образовании и т.д.)
    public abstract  class Document : SimpleClass
    {
        /// <summary>
        /// Абитуриент к которой относится документ
        /// </summary>
        public Entrant Entrant { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        /// <summary>
        /// Кем выдан
        /// </summary>
        public string Given { get; set; }
        /// <summary>
        /// Когда выдан
        /// </summary>
        public DateTime DateGiven { get; set; }
        public List<string> DocType = new List<string>() { "Документ, удостоверяющий лчиность", "Документ об образовании","Военный документ", "Документ-основание" };

    }
}