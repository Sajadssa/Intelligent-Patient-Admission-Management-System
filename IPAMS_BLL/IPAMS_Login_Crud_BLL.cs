using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPAMS_DAL;
using IPAMS_BE;
using System.Data.SqlClient;
using System.Data;

namespace IPAMS_BLL
{
    public class IPAMS_Login_Crud_BLL
    {
        IPAMS_Login_Crud_DAL dal = new IPAMS_Login_Crud_DAL();
        IPAMS_db db=new IPAMS_db();
        public byte Login(string username, string password)
        {
            return dal.Login(username, password);
        }

        public void Register(IPAMS_User_Login_BE u)
        {
            dal.Register(u);
        }
        public string Create(IPAMS_User_Login_BE L)
        {
            return dal.Create(L);
        }
        public List<IPAMS_User_Login_BE> Read(string Name)
        {
            return dal.Read(Name);
        }

        #region Read By All in datagridview
        public List<IPAMS_User_Login_BE> Readdata()
        {
            return dal.Readdata().ToList();
        }
        #endregion
        public IPAMS_User_Login_BE Readid(int id)
        {
            return dal.Readid(id);

        }

        public string Delete(int id)
        {
            return dal.Delete(id);
        }

        public string Update(int id, IPAMS_User_Login_BE lnew)
        {
            return dal.Update(id, lnew);
        }

        public DataTable FillGrd()
        {
            return dal.FillGrd();
        }
        public int username(string Name,string password)
        {
            return dal.username(Name,password);
        }

        public IPAMS_User_Login_BE loginuser(int id)
        {
            return dal.loginuser(id);
        }
    }

}

