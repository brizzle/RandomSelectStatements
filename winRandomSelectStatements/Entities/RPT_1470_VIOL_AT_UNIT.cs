using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1470_VIOL_AT_UNIT :basePrisonerLocation
    {

        public DateTime VIOL_RETURN_DATE { get; set; }
        public string DI43 { get; set; }
        public int DAYS_SINCE_ARRIVAL { get; set; }
    }
}