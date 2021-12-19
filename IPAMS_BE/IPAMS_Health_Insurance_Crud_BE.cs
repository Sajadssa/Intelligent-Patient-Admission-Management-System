using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPAMS_BE
{
     public class IPAMS_Health_Insurance_Crud_BE
    {
        public int id { get; set; }
        public string Type_Hic { get; set; }
        public double Amount_Discount { get; set; }
        //navigation prp
        public List<IPAMS_Admission_Crud_BE> IPAMS_Admission_Crud_BEs = new List<IPAMS_Admission_Crud_BE>();
    }
}
