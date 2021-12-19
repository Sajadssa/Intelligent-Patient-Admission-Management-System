using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPAMS_BE;

namespace IPAMS_DAL
{
   public class IPAMS_Admission_Crud_DAL
   {
        #region Instance From Database

        IPAMS_db IPAMS_db = new IPAMS_db();
        #endregion

        //Creat-Read-Update-Delete
        #region Create
        /// <summary>
        /// ایجاد شی در بانک اطلاعاتی
        /// </summary>
        /// <param name="a"></param>
        public string Create(IPAMS_Admission_Crud_BE a)

        {
            if (!Read(a))
            {
                IPAMS_db.Admission.Add(a);
                IPAMS_db.SaveChanges();
                return "ثبت نوبت با موفقیت انجام شد";
            }
            else
            {
                return "نوبت ثبت شده تکراری است";
            }

        }

      

        #endregion
        #region Read
        /// <summary>
        /// خواندن در بانک اطلاعاتی
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public bool Read(IPAMS_Admission_Crud_BE a)
        {
            return IPAMS_db.Admission.Any(i => i.Admission_No == a.Admission_No && i.Type_Admission == a.Type_Admission );
        }


        #endregion

        #region Read By id
        public IPAMS_Admission_Crud_BE Read(int id)
        {
            return IPAMS_db.Admission.Where(i => i.id == id).SingleOrDefault();
        }
        #endregion

        #region Read By All in datagridview
        public List<IPAMS_Admission_Crud_BE> Read()
        {
            return IPAMS_db.Admission.ToList();
        }
        #endregion

        #region Update
        public string Update(int id, IPAMS_Admission_Crud_BE Pnew)
        {
            IPAMS_Admission_Crud_BE ia = new IPAMS_Admission_Crud_BE();
            ia = Read(id);
            ia.Type_Admission= Pnew.Type_Admission;
            ia.Remark = Pnew.Remark;
            ia.Type_Insurance = Pnew.Type_Insurance;
            ia.Amount_Discount = Pnew.Amount_Discount;
            ia.Date = Pnew.Date;
           
           
            IPAMS_db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";

        }
        #endregion

        #region Delete By id
        public string Delete(int id)
        {

            IPAMS_Admission_Crud_BE a = Read(id);
            IPAMS_db.Admission.Remove(a);
            IPAMS_db.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }

        #endregion

        public DataTable GetAdmissions()
        {


            SqlConnection con = new SqlConnection(@"Data Source=SAJAD1367;Initial Catalog=IPAMS_db;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt2 = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "SELECT * FROM dbo.IPAMS_Admission_Vi";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            adp.Fill(dt2);
            return dt2;
        }

        //
        public string MaxAdmission()
        {
            IPAMS_db db1 = new IPAMS_db();
            var q=db1.Admission.Max((i) => ( i.Admission_No).ToString());
            return q;
        }
        public string counts()
        {
            return (new IPAMS_db()).Admission.Count().ToString();
        }
        public int SetNumber(int id)
        {
            return 1000 + id;
        }

        public int getcountpaziresh(string tarikh)
        {
            return   IPAMS_db.Admission.Where(i => i.Date_Time == tarikh).Count();
        }

        public List<string> GetAdmissionNames()
        {
            return IPAMS_db.Admission.Select(i => i.Type_Insurance).ToList();
        }
        public int GetTodayPazireshCount()
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();
         
            string date = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
            string CurrentTime = DateTime.Now.Hour.ToString("0#")+ ":"+ DateTime.Now.Minute.ToString("0#")+ ":"+ DateTime.Now.Second.ToString("0#");
         return   IPAMS_db.Admission.Where(p => p.Date == date).Where(p => p.Time.CompareTo(CurrentTime) <= 0).Count();
        }
        public int PazireshTotalCount()
        {
            return IPAMS_db.Admission.Count();
        }

        public DataTable GetPrice_Admission()
        {

            SqlConnection con = new SqlConnection(@"Data Source=SAJAD1367;Initial Catalog=IPAMS_db;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt3 = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "SELECT نام, [نام خانوادگی], [کد ملی], SUM([مبلغ پذیرش]) AS [هزینه کل پذیرش هربیمار] FROM dbo.IPAMS_Admission_Vi GROUP BY نام, [نام خانوادگی], [کد ملی]";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            adp.Fill(dt3);
            return dt3;
        }

        public double GetTodayPrice()
        {
            System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();

            string date = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
            string CurrentTime = DateTime.Now.Hour.ToString("0#") + ":" + DateTime.Now.Minute.ToString("0#") + ":" + DateTime.Now.Second.ToString("0#");
            return IPAMS_db.Admission.Where(p => p.Date == date).Where(p => p.Time.CompareTo(CurrentTime) <= 0).Count();
        }
        public double Getprice_Total()
        {
            return IPAMS_db.Admission.Include("IPAMS_HIC").Sum(i =>(double?) i.IPAMS_HIC.Amount_Discount)??0;
        }

        public DataTable GetPrices()
        {

            SqlConnection con = new SqlConnection(@"Data Source=SAJAD1367;Initial Catalog=IPAMS_db;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt4 = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "SELECT SUM([جمع هزینه پذیرشها]) AS [هزینه کل] FROM  dbo.IPAMS_Price_Admission";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            adp.Fill(dt4);
            return dt4;
        }
        public string sum_tabel()
        {
            IPAMS_db db1 = new IPAMS_db();

            try
            {
                return db1.Admission.Sum(i => i.Amount_Discount).ToString();

            }
            catch (Exception)
            {

                return "0";
            }

        }
        public string sum_daryaft_tarikh( )
        {
            try
            {
                System.Globalization.PersianCalendar pc = new System.Globalization.PersianCalendar();

                string date = pc.GetYear(DateTime.Now).ToString() + "/" + pc.GetMonth(DateTime.Now).ToString("00") + "/" + pc.GetDayOfMonth(DateTime.Now).ToString("00");
                string CurrentTime = DateTime.Now.Hour.ToString("0#") + ":" + DateTime.Now.Minute.ToString("0#") + ":" + DateTime.Now.Second.ToString("0#");
               return  IPAMS_db.Admission.Where(p => p.Date == date).Where(p => p.Time.CompareTo(CurrentTime) <= 0).Sum(i => ((double?)i.Amount_Discount) ?? 0).ToString();
            }
            catch (Exception)
            {
                return "0";
            }
            
        }
        public DataTable GetChartData(string date1, string date2)
        {
            

            SqlConnection con = new SqlConnection(@"Data Source=SAJAD1367;Initial Catalog=IPAMS_db;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt2 = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = @"SELECT [تاریخ] AS [تاریخ], COUNT(ردیف) AS [تعداد پذیرش] FROM dbo.IPAMS_Admissions_Vi GROUP BY [تاریخ]  having (تاریخ between '" + date1 + "' and '" + date2 + "')";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            adp.Fill(dt2);
            return dt2;

        }
   }
}
