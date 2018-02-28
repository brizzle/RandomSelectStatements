using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winRandomSelectStatements.Entities
{
    public class RPT_0810_DWI_COMMITMENTS :basePrisonerLocation
    {
        public DateTime RECEIVED_DATE { get; set; }
        public DateTime INMATE_DOB { get; set; }
        public int INMATE_SSN { get; set; }
        public string ARS_CODE { get; set; }
        public string ARS_DESC { get; set; }
        public string COUNTY { get; set; }
        public string CAUSE { get; set; }
      
    }
}
