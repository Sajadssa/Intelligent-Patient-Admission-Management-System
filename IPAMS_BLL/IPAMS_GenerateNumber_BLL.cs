using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPAMS_DAL;
namespace IPAMS_BLL
{
   public class IPAMS_GenerateNumber_BLL
    {
        public int GetNumber()
        {
           return  new IPAMS_GenerateNumber_DAL().GetNumber();
        }
        public void GenerateNumber()
        {
            new IPAMS_GenerateNumber_DAL().GenerateNumber();
        }
    }
}
