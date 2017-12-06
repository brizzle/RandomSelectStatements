using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_780_RECENT_PAY :basePrisonerLocation
    {

        public DateTime ENTRY_DATE { get; set; }
        public decimal HOURS { get; set; }
        public decimal Rate { get; set; }
        public decimal PAY { get; set; }
        public string RATING { get; set; }

        public string STAFF { get; set; }
        public string ASSIGNMENT_ID { get; set; }
        public string ASSIGNMENT_CODE { get; set; }

    }
}