using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPAMS_DAL;
using IPAMS_BE;
using System.Data;

namespace IPAMS_BLL
{
    public class IPAMS_Admission_Crud_BLL
    {
        /// <summary>
        /// /Call Methods From Sup_DAL
        /// </summary>
        IPAMS_Admission_Crud_DAL Admission_DAL = new IPAMS_Admission_Crud_DAL();
        public string Create(IPAMS_Admission_Crud_BE a)
        {
            return Admission_DAL.Create(a);
        }
        public DataTable GetAdmissions()
        {
            return Admission_DAL.GetAdmissions();
        }
        public List<IPAMS_Admission_Crud_BE> Read(string name)
        {
            return Admission_DAL.Read();
        }
        public List<string> GetAdmissionNames()
        {
            return Admission_DAL.GetAdmissionNames();
        }
        public int SetNumber(int id)
        {
            return Admission_DAL.SetNumber(id);
        }
        public string Update(int id, IPAMS_Admission_Crud_BE anew)
        {
            return Admission_DAL.Update(id, anew);
        }
        public string Delete(int id)
        {
            return Admission_DAL.Delete(id);
        }
        public IPAMS_Admission_Crud_BE Read(int id)
        {
            return Admission_DAL.Read(id);
        }
        public List<IPAMS_Admission_Crud_BE> Read()
        {
            return Admission_DAL.Read();
        }

        public string MaxAdmissionNo()
        {
            return Admission_DAL.MaxAdmission();
        }
        public string counts()
        {
            return Admission_DAL.counts();
        }
        public int GetTodayPazireshCount()
        {
            return Admission_DAL.GetTodayPazireshCount();
        }
        public int GetTotalPazireshCount()
        {
            return Admission_DAL.PazireshTotalCount();
        }
        public DataTable GetPrice_Admission()
        {
            return Admission_DAL.GetPrice_Admission();
        }

        public double Getprice_Total()
        {
            return Admission_DAL.Getprice_Total();
        }
        public DataTable GetPrices()
        {
            return Admission_DAL.GetPrices();
        }
        public string eum_ttt()
        {
            return Admission_DAL.sum_tabel();

        }

        public string sum_daryaft_tarikh( )
        {
             return Admission_DAL.sum_daryaft_tarikh();
        }

        public DataTable GetChartData(string date1, string date2)
        {
            return Admission_DAL.GetChartData(date1,date2);
        }
    }
}
