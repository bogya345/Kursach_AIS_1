using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppAbit2.Models
{
    /// <summary>
    /// условия приёма
    /// </summary>
    public class FinSourceAndEduForms
    {
        public CompetitiveGroup CompetitiveGroup { get; set; }
        public TargetOrganization TargetOrganization { get; set; }
        public DateTime IsAgreedDate { get; set; }
        public DateTime IsDisagreedDate { get; set; }
        public bool IsForSPOandVO { get; set; }
        public override string ToString()
        {
            if (TargetOrganization != null)
            {
                return CompetitiveGroup.ToString() + "  " + TargetOrganization.ToString();
            }
            else
            {
                return CompetitiveGroup.ToString() + "  не целевой приём";

            }
        }
    }
}
