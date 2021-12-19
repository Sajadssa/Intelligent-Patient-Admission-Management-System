using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPAMS_DAL;
using IPAMS_BE;


namespace IPAMS_BLL
{
   public class IPAMS_Type_Insurance_Crud_BLL
    {
        IPAMS_Type_Insurance_Crud_DAL ITI_DAL = new IPAMS_Type_Insurance_Crud_DAL();
        public string Create(IPAMS_Health_Insurance_Crud_BE P)
        {
            return ITI_DAL.Create(P);
        }

        public List<string> listbime()
        {
            return ITI_DAL.List_Combo_Bimeh();
        }
        public List<string> GetFreeBime()
        {
            return ITI_DAL.GetFreeBime();
        }
        public string getpric(string name)
        {
            return ITI_DAL.getpric(name);
        }
        public int admission()
        {
            return ITI_DAL.admissionNo();
        }
        public IPAMS_Health_Insurance_Crud_BE getbim(string name)
        {
            return ITI_DAL.getbime(name);
        }

        public IPAMS_Health_Insurance_Crud_BE Read(int id)
        {
            return ITI_DAL.Read(id);
        }

    }
}
