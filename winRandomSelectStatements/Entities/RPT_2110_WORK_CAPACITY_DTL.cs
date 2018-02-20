using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2110_WORK_CAPACITY_DTL : baseLocation
    {


        public string CODE { get; set; }

        public string DESCRIPTION { get; set; }

        public string P_CODE { get; set; }
        public string GR_CODE { get; set; }
        public string ALT_NAME { get; set; }
        public string WORK_DAYS { get; set; }
        public int TIME_FROM { get; set; }
        public int TIME_TO { get; set; }
        public string WORK_WHERE { get; set; }
        public string SUPV_CODE { get; set; }
        public int CAP_CODE { get; set; }
        public int ASN_CODE { get; set; }
        public string ST_CODE { get; set; }
        public DateTime WORK_CAPACITY_DATE { get; set; }
    }
}