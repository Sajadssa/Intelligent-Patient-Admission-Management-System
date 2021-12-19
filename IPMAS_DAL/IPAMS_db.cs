using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using IPAMS_BE;
    

namespace IPAMS_DAL
{
    public class IPAMS_db : DbContext

    {
        public IPAMS_db() : base("name=IPAMS_db") {
     }
        public DbSet<IPAMS_Patient_Crud_BE> Patient { get; set; }
        public DbSet<IPAMS_Doctors_Crud_BE> Doctor { get; set; }
        public DbSet<IPAMS_Admission_Crud_BE> Admission { get; set; }
        public DbSet<IPAMS_Health_Insurance_Crud_BE> Health_Insurance { get; set; }
        public DbSet<IPAMS_User_Login_BE> User_Login { get; set; }
        public DbSet<GenerateNumber> GenerateNumbers { get; set; }
        public DbSet<IPAMS_User_Security> User_Security { get; set; }
    }
}
