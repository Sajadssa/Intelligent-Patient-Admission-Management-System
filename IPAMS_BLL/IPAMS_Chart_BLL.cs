using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPAMS_BE;
using IPAMS_DAL;
namespace IPAMS_BLL
{
 public   class IPAMS_Chart_BLL
 {
       
        public DataTable GetPriceSum()
        {
            return new IPAMS_Chart_DAL().GetPriceSum();
        }
        public DataTable GetPatients()
        {
            return new IPAMS_Chart_DAL().GetPatients();
        } 

 }

}
