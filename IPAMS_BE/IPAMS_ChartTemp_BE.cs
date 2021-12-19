using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPAMS_BE
{
  public  class IPAMS_ChartTemp_BE
    {
        public int PazireshCount { get; set; }
        public string Date { get; set; }
    }
   public class IPAMS_ChartTempPatients_BE
    {
        public int PatientPazireshCount { get; set; }
        public string Name { get; set; }
    }
}
