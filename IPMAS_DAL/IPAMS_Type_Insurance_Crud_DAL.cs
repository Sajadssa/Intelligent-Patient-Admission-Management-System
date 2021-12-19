using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPAMS_BE;

namespace IPAMS_DAL
{
    public class IPAMS_Type_Insurance_Crud_DAL
    {
        #region Instance From Database

        IPAMS_db IPAMS_db = new IPAMS_db();
        #endregion

        public string Create(IPAMS_Health_Insurance_Crud_BE h)
        {
            if (!Read(h))
            {
                if (h.Type_Hic.Length > 0  )
                {
                    IPAMS_db.Health_Insurance.Add(h);
                    IPAMS_db.SaveChanges();
                    return "ثبت اطلاعات با موفقیت انجام شد";
                }
                else
                {
                    return "عنوان دفترچه را وارد کنید";
                }

            }
            else
            {
                return "اطلاعات وارد شده تکراری است.";
            }

          


        }
        public bool Read(IPAMS_Health_Insurance_Crud_BE h)
        {
            return IPAMS_db.Health_Insurance.Any(i => i.Type_Hic ==h.Type_Hic  && i.Amount_Discount == h.Amount_Discount);
        }

        #region Read By All in combobox
       public List<string> List_Combo_Bimeh() {
            //List<string> lst = new List<string>();
            //foreach (var item in new IPAMS_db().Health_Insurance)
            //{
            //    if (item != null)
            //    {
            //        lst.Add(item.Type_Hic);
            //    }

            //}
            //return lst;
            var q= IPAMS_db.Health_Insurance.Where(i => i.Type_Hic != "آزاد").Select(i=>i.Type_Hic).ToList();
            return q;
            
        }
        public List<string> GetFreeBime()
        {
           
            var q=IPAMS_db.Health_Insurance.Where(i => i.Type_Hic == "آزاد").Select(i => i.Type_Hic).ToList();
            return q;

        }
        #endregion
        public string getpric(string name) 
        {
            string q = IPAMS_db.Health_Insurance.Where(i => i.Type_Hic == name).Select(i => i.Amount_Discount).Single().ToString();
            return q;
        }

        public int admissionNo()
        {
            int a = IPAMS_db.Health_Insurance.Count();
            return a + 1000;
        }
        public IPAMS_Health_Insurance_Crud_BE getbime(string name )
        {
            return IPAMS_db.Health_Insurance.Where(i => i.Type_Hic == name).Single();
        }

        #region Read By id
        public IPAMS_Health_Insurance_Crud_BE Read(int id)
        {
            return IPAMS_db.Health_Insurance.Where(i => i.id == id).SingleOrDefault();
        }
        #endregion

    }
}
    
