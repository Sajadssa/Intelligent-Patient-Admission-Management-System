using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPAMS_BE;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;


namespace IPAMS_DAL
{
    public class IPAMS_Chart_DAL
    {
       
        public DataTable GetPriceSum()
        {
            SqlConnection con = new SqlConnection(@"Data Source=SAJAD1367;Initial Catalog=IPAMS_db;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt2 = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "SELECT  تاریخ, SUM([مبلغ پذیرش]) AS [میزان درآمد]FROM dbo.IPAMS_Admission_Vi GROUP BY تاریخ ORDER BY تاریخ";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            adp.Fill(dt2);
            return dt2;
        }
        public DataTable GetPatients()
        {
            SqlConnection con = new SqlConnection(@"Data Source=SAJAD1367;Initial Catalog=IPAMS_db;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            DataTable dt2 = new DataTable();
            SqlDataAdapter adp = new SqlDataAdapter();
            adp.SelectCommand = new SqlCommand();
            adp.SelectCommand.Connection = con;
            adp.SelectCommand.CommandText = "SELECT DISTINCT { fn CONCAT({ fn CONCAT(نام, ' ') }, [نام خانوادگی]) } AS بیمار, COUNT([شماره پذیرش]) AS [تعداد پذیرش] FROM dbo.IPAMS_Admission_Vi GROUP BY { fn CONCAT({ fn CONCAT(نام, ' ') }, [نام خانوادگی]) }";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            adp.Fill(dt2);
            return dt2;
        }

    }
}     
        

