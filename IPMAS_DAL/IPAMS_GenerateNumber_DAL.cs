using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using IPAMS_BE;
namespace IPAMS_DAL
{
  public  class IPAMS_GenerateNumber_DAL
    {
        public  void GenerateNumber()
        {
            GenerateNumber ge = new GenerateNumber();
            ge.Status = "checked";
            IPAMS_db db = new IPAMS_db();
            db.GenerateNumbers.Add(ge);
            db.SaveChanges();
        }
        public int GetNumber()
        {
            IPAMS_db db = new IPAMS_db();
           return db.GenerateNumbers.Max(i => i.id)+1000;
        }
    }
}
