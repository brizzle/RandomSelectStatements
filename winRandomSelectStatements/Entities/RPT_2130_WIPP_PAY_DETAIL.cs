using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2130_WIPP_PAY_DETAIL :basePrisonerLocation
    {
        public DateTime ENTRY_DATE { get; set; }
        public decimal WORK_HOURS { get; set; }
        public decimal WORK_RATE { get; set; }
        public decimal PAY { get; set; }
        public decimal ADJUSTED { get; set; }
        public DateTime ADJUSTED_DATE { get; set; }
        public string STAFF { get; set; }
        public string ASSIGNMENT_CODE { get; set; }
        public string ASSIGNMENT { get; set; }


    }
}