using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPAMS_BE
{
     public class IPAMS_User_Login_BE
    {
        public int id { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string ConifirmPassword { get; set; }
        public string Email { get; set; }
        public string PictureAddress { get; set; }
        public bool AccessLevel { get; set; }
    }
   
}
