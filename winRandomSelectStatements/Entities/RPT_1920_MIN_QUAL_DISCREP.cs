using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1920_MIN_QUAL_DISCREP :basePrisonerLocation
    {
        public string SUPERVISOR_NAME { get; set; }

        public string GROUP_ID { get; set; }
        public string CODE_ID { get; set; }
        public string DESCRIPTION { get; set; }

        public DateTime BEGIN_DATE { get; set; }
        public int TOTAL_COUNT { get; set; }

    }
}