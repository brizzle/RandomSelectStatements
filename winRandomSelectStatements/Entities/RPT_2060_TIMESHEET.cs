using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2060_TIMESHEET :basePrisonerLocation
    {
        public string CYCLE_NAME { get; set; }
        public DateTime SCHEDULE_DATE { get; set; }
        public string EVALUATION { get; set; }
        public decimal TOTAL_HOURS { get; set; }
        public string WORK_LEVEL { get; set; }
        public DateTime PAY_PERIOD { get; set; }
    }
}