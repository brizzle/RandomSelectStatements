using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2120_TURN_OUT :basePrisonerLocation
    {
        public string TITLE { get; set; }
        public string SUPERVISOR_NAME { get; set; }
        public DateTime SESSION_DATE { get; set; }
        public string SESSION_TIME { get; set; }

    }
}