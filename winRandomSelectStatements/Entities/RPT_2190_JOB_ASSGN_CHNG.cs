using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2190_JOB_ASSGN_CHNG :basePrisonerLocation

    {
        public string ALT_NAME { get; set; }
        public string SUPERVISOR_NAME { get; set; }
        public string CATEGORY { get; set; }
        public string CATEGORY_CODE { get; set; }
        public string ASSIGNMENT { get; set; }
        public string ASSIGNMENT_CODE { get; set; }

        public int PROGRAM_ID { get; set; }
        public DateTime SESSION_DATE { get; set; }
        public string TIME_SLOT { get; set; }

        public int SESSION_START_TIME { get; set; }
        public int SESSION_END_TIME { get; set; }

        public string JOB_LOCATION { get; set; }

        public bool SUNDAY { get; set; }
        public bool MONDAY { get; set; }
        public bool TUESDAY { get; set; }
        public bool WEDNESDAY { get; set; }
        public bool THURSDAY { get; set; }
        public bool FRIDAY { get; set; }
        public bool SATURDAY { get; set; }


    }
}