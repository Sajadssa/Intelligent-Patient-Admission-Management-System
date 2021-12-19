using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPAMS_BE
{
    public class IPAMS_Patient_Crud_BE
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public double National_Code { get; set; }
        public string Gender { get; set; }
        public double Phone_No { get; set; }
        public List<IPAMS_Admission_Crud_BE> IPAMS_Admission_Crud_BEs = new List<IPAMS_Admission_Crud_BE>();
      

    }
}
