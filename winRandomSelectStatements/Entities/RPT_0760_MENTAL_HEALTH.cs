using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_0760_MENTAL_HEALTH :basePrisonerLocation
    {
        public string ADMIN_REGION { get; set; }
        public string RACE { get; set; }

        public int MH { get; set; }
        public string SMI { get; set; }
        public string MEDS { get; set; }
        public string DIAGNOSIS { get; set; }
        public string SC { get; set; }
        public string SMIC { get; set; }
        public string SORT_ORDER { get; set; }
        public DateTime RELEASE_DATE { get; set; }
        public string SA { get; set; }
        public DateTime EARLIEST_RELEASE_DATE { get; set; }
        public DateTime LAST_DIST_DATE { get; set; }

        public string CU_IR { get; set; }
        public int M_CODE { get; set; }


    }
}