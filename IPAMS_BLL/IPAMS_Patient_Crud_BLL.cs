using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPAMS_BE;
using IPAMS_DAL;
namespace IPAMS_BLL
{
    public class IPAMS_Patient_Crud_BLL
    {
        /// <summary>
        /// /Call Methods From Sup_DAL
        /// </summary>
        IPAMS_Patient_Crud_DAL Patient_DAL = new IPAMS_Patient_Crud_DAL();
        public string Create(IPAMS_Patient_Crud_BE P)
        {
            return Patient_DAL.Create(P);
        }
        public List<IPAMS_Patient_Crud_BE> Read(string Name)
        {
            return Patient_DAL.Read(Name);
        }
        public string Update(int id, IPAMS_Patient_Crud_BE Pnew)
        {
            return Patient_DAL.Update(id, Pnew);
        }
        public string Delete(int id)
        {
            return Patient_DAL.Delete(id);
        }
        public IPAMS_Patient_Crud_BE Read(int id)
        {
            return Patient_DAL.Read(id);
        }
        public List<IPAMS_Patient_Crud_BE> Read()
        {
            return Patient_DAL.Read();
        }
        public int CountPatient()
        {
            return Patient_DAL.CountPatient();
        }

    }
}

