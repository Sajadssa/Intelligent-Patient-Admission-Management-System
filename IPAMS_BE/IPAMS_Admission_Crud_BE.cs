using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace IPAMS_BE
{
    public class IPAMS_Admission_Crud_BE
    {
        public int id { get; set; }

        public int Patient_id { get; set; }
        public int insurance_id { get; set; }
        public string Type_Admission { get; set; }
        public double Amount_Discount { get; set; }
        public string Date_Time { get; set; }
        public string Date { get; set; }
        public string Remark { get; set; }
        public int Admission_No { get; set; }
        public string Type_Insurance { get; set; }
        public string Time { get; set; }

        //Navigation Properties

        public IPAMS_Doctors_Crud_BE IPMAS_Doctor { get; set; }
        public IPAMS_Health_Insurance_Crud_BE IPAMS_HIC { get; set; }
        public IPAMS_Patient_Crud_BE IPAMS_Pateient { get; set; }
    }
}
