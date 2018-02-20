using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1690_PR_STATS :basePrisonerLocation
    {
        public DateTime SESSION_MONTH { get; set; }

        public string STATUS { get; set; }
        public string CODE { get; set; }
        public string TYP { get; set; }
        public DateTime START_DATE { get; set; }
        public DateTime END_DATE { get; set; }
        public string GROUP_ID { get; set; }
        public string PROGRAM_CATEGORY { get; set; }
        public string PROGRAM_ASSIGNMENT { get; set; }
        public string CATEGORY_CODE { get; set; }
        public string ASSIGNMENT_CODE { get; set; }
     
        public string SUPERVISOR_NAME { get; set; }


    }
}