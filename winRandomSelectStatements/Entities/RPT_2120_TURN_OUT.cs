using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2120_TURN_OUT :basePrisonerLocation
    {
        public int TITLE_CODE { get; set; }
        public string TITLE_DESCRIPTION { get; set; }
        public string WORK_ASSIGNMENT { get; set; }
        public string SUPERVISOR_NAME { get; set; }
        public DateTime SESSION_DATE { get; set; }
        public int SESSION_TIME { get; set; }

    }
}