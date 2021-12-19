using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPAMS_BE;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Data;

namespace IPAMS_DAL
{
     public class IPAMS_Login_Crud_DAL
    {
        
        #region Instance From Database

        IPAMS_db IPAMS_db = new IPAMS_db();
        #endregion
        public string Create(IPAMS_User_Login_BE L) {
            if (!Read(L))
            {
                if (L.User_Name.Length>0 && L.Password.Length>0)
                {
                    IPAMS_db.User_Login.Add(L);
                    IPAMS_db.SaveChanges();
                    return "ثبت اطلاعات با موفقیت انجام شد";
                }
                else
                {
                    return "نام کاربری و رمز عبور را وارد کنید";
                }

            }
            else
            {
                return "اطلاعات وارد شده تکراری است.";
            }
          
            

        }
        public bool Read(IPAMS_User_Login_BE L)
        {
            return IPAMS_db.User_Login.Any(i => i.User_Name == L.User_Name && i.Password == L.Password );
        }
        public List<IPAMS_User_Login_BE> Read(string name)
        {
            return IPAMS_db.User_Login.Where(i => i.User_Name.Contains(name)).ToList();
        }



        public byte Login(string username, string password)
        {
            if (IPAMS_db.User_Login.Count() == 0)
            {
                return 0;
            }
            else
            {
                if (IPAMS_db.User_Login.Any(i => i.User_Name == username && i.Password == password ))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        public void Register(IPAMS_User_Login_BE u)
        {
            IPAMS_db.User_Login.Add(u);
            IPAMS_db.SaveChanges();
        }

        #region Read By All in datagridview
        public List<IPAMS_User_Login_BE> Readdata()
        {
            return IPAMS_db.User_Login.ToList();
        }
        #endregion

        #region Read By id
        public IPAMS_User_Login_BE Readid(int id)
        {
            return IPAMS_db.User_Login.Where(i => i.id == id).SingleOrDefault();
            
        }
        #endregion
        #region Delete By id
        public string Delete(int id)
        {

            IPAMS_User_Login_BE a = Readid(id);
            IPAMS_db.User_Login.Remove(a);
            IPAMS_db.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }

        #endregion
        #region Update
        
        public string Update(int id, IPAMS_User_Login_BE lnew)
        {
           
            IPAMS_User_Login_BE al = new IPAMS_User_Login_BE();
            al = Readid(id);
            al.User_Name = lnew.User_Name;
            al.Password = lnew.Password;
            al.ConifirmPassword = lnew.ConifirmPassword;
            al.Email = lnew.Email;
            al.AccessLevel = lnew.AccessLevel;
            al.PictureAddress = lnew.PictureAddress;


            IPAMS_db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";

        }
        #endregion
        public DataTable FillGrd()
        {
            SqlConnection con = new SqlConnection(@"Data Source = SAJAD1367; Initial Catalog = IPAMS_db; Integrated Security = true");
            SqlCommand cmd = new SqlCommand();
            DataTable dt2 = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "SELECT id AS ردیف, User_Name AS[نام کاربری], Password AS[رمز عبور], ConifirmPassword AS[تأیید رمز عبور], Email AS[آدرس پستی الکترونیکی], PictureAddress AS[محل ذخیره تصویر], AccessLevel AS  [ادمین] FROM dbo.IPAMS_User_Login_BE";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            adp.Fill(dt2);
            return dt2;
            

        }
        public int username(string Name,string password)
        {
            return IPAMS_db.User_Login.Where(i => i.User_Name == Name && i.Password==password).Select(i => i.id).SingleOrDefault();
        }

        public IPAMS_User_Login_BE loginuser(int id)
        {
            return IPAMS_db.User_Login.Where(i => i.id == id).Select(i => i).SingleOrDefault();
        }
    }


}

