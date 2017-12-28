using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_0350_DISCIP_FORT_LOG:baseLocation
    {
        public DateTime DATE_ENTERED { get; set; }
        public int DOC_ID { get; set; }
        public string CASE_NUMBER { get; set; }
        public string VIOL { get; set; }
        public DateTime HEAR_DATE { get; set; }
        public int FORF { get; set; }
        public DateTime RELEASE_DATE { get; set; }
        public string SID { get; set; }

    }
}