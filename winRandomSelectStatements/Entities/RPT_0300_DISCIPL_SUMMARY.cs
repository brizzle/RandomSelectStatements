using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_0300_DISCIPL_SUMMARY :baseLocation
    {
        public DateTime VERDICT_DATE { get; set; }

        public string VERDICT_TYPE { get; set; }

        public string RACE { get; set; }

        public int GUILTY_MAJOR { get; set; }
        public int NOT_GUILTY_MAJOR { get; set; }
        public int GUILTY_MINOR { get; set; }
        public int NOT_GUILTY_MINOR { get; set; }
        public int DISMISSED_PROC { get; set; }
        public int DISMISSED_TIME { get; set; }
        public int DISMISSED_COUNSEL { get; set; }
        public int PENDING { get; set; }

        public int FINDING_DISMISSED { get; set; }
        public int FINDING_UPHELD { get; set; }
        public int REHEARING { get; set; }
        public int MODIFIED { get; set; }
    }
}