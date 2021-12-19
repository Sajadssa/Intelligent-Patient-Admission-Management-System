using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using IPAMS_BE;
namespace IPAMS_DAL
{
     public class IPAMS_User_Security_DAL
    {
        IPAMS_db db = new IPAMS_db();
        public void UpdatePermission(List<IPAMS_User_Security> lists)
        {
            foreach (var item in lists)
            {
                IPAMS_User_Security perm = db.User_Security.Where(i => i.id == item.id).Single();
                perm.Enable = item.Enable;
                db.SaveChanges();
            }
        }
        public List<bool> Checks()
        {
            return db.User_Security.Select(i => i.Enable).ToList();
        }
    }
}
