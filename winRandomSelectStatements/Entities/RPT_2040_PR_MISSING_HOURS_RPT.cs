using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2040_PR_MISSING_HOURS_RPT: basePrisonerLocation
    {
        public DateTime REG_EFF_DATE { get; set; }
        public string ASSIGNMENT { get; set; }
        public decimal HOURS { get; set; }
        public decimal COMPLETE { get; set; }
        public decimal TOTAL_HOURS { get; set; }
        public string EVALUATION { get; set; }
        public string SUPERVISOR_NAME { get; set; }

    }
}