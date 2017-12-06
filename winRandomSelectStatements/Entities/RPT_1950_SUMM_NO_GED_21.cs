using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1950_SUMM_NO_GED_21 :baseLocation
    {
        public string PROGRAM_ID { get; set; }
        public string PROGRAM_NAME { get; set; }

        public DateTime COMPLETION_DATE { get; set; }
        public int COMPLEX_POPULATION { get; set; }
        public int ENROLLED_FUNCTIOANAL { get; set; }
        public int ENROLLED_GED { get; set; }
        public int TOTAL_ENROLLED { get; set; }
    }
}