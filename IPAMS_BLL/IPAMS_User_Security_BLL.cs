using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPAMS_BE;
using IPAMS_DAL;

namespace IPAMS_BLL
{
   public class IPAMS_User_Security_BLL
    {
        IPAMS_User_Security_DAL sdal = new IPAMS_User_Security_DAL();
        public void UpdatePermission(List<IPAMS_User_Security> lists)
        {
             sdal.UpdatePermission(lists);
        }
        public List<bool> Checks()
        {
            return sdal.Checks();
        }
    }
}
