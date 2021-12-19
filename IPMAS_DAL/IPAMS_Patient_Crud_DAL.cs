using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPAMS_BE;
using System.Data.Entity;
namespace IPAMS_DAL
{
   public class IPAMS_Patient_Crud_DAL
    {
        #region Instance From Database

         IPAMS_db IPAMS_db = new IPAMS_db();
        #endregion

        //Creat-Read-Update-Delete
        #region Create
        /// <summary>
        /// ایجاد شی در بانک اطلاعاتی
        /// </summary>
        /// <param name="P"></param>
        public string Create(IPAMS_Patient_Crud_BE P)

        {
            if (!Read(P))
            {
                IPAMS_db.Patient.Add(P);
                IPAMS_db.SaveChanges();
                return "ثبت نام بیمار با موفقیت انجام شد";
                
            }
            else
            {
                return "بیمار ثبت شده تکراری است";
            }

        }

        public List<IPAMS_Patient_Crud_BE> Read(string name)
        {
            return IPAMS_db.Patient.Where(i => i.Name.Contains(name)).ToList();
        }
        #endregion
        #region Read
        /// <summary>
        /// خواندن در بانک اطلاعاتی
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool Read(IPAMS_Patient_Crud_BE P)
        {
            return IPAMS_db.Patient.Any(i => i.Name == P.Name && i.Family == P.Family && i.National_Code == P.National_Code && i.Phone_No == P.Phone_No);
        }


        #endregion

        #region Read By id
        public IPAMS_Patient_Crud_BE Read(int id)
        {
            return IPAMS_db.Patient.Where(i => i.id == id).SingleOrDefault();
        }
        #endregion

        #region Read By All in datagridview
        public List<IPAMS_Patient_Crud_BE> Read()
        {
            return IPAMS_db.Patient.ToList();
        }
        #endregion

        #region Update
        public string Update(int id, IPAMS_Patient_Crud_BE Pnew)
        {
            IPAMS_Patient_Crud_BE P = new IPAMS_Patient_Crud_BE();
            P = Read(id);
            P.Name = Pnew.Name;
            P.Family = Pnew.Family;
            P.National_Code = Pnew.National_Code;
            P.Gender = Pnew.Gender;
            P.Phone_No = Pnew.Phone_No;
            IPAMS_db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";

        }
        #endregion

        #region Delete By id
        public string Delete(int id)
        {
            
            IPAMS_Patient_Crud_BE P = Read(id);
            IPAMS_db.Patient.Remove(P);
            IPAMS_db.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }

        #endregion

      public int CountPatient()
        {
            return IPAMS_db.Patient.Count();
        }

    }
}
