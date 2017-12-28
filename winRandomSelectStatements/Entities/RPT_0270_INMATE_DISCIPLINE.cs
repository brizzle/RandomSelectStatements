using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_0270_INMATE_DISCIPLINE :basePrisonerLocation
    {
        public DateTime VIOLATION_DATE { get; set; }
        public string CASE_NUMBER { get; set; }
        public string REPORTED_BY { get; set; }
        public DateTime VERD_DATE { get; set; }
        public int CDE { get; set; }
        public string DISP { get; set; }
        public int CYCLE { get; set; }
        public string HAS_CMT { get; set; }

    }
}