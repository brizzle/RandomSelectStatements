using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1400_DISCR_OR_DISC_VIOL :basePrisonerLocation
    {
        public string PLAN_MANAGER { get; set; }
        public string CURR_DI99 { get; set; }
        public DateTime CU_LEV_DATE { get; set; }
        public string DISCIPLINE { get; set; }
        public string VIOLATION_CODE { get; set; }
        public string VIOLATION_DESC { get; set; }
        public DateTime VIOLATION_DATE { get; set; }
        public string DISPOSITION { get; set; }

    }
}