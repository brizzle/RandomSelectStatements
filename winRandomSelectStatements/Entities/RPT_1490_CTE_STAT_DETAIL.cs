using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1490_CTE_STAT_DETAIL :basePrisonerLocation
    {

        public int PROGRAM_ID { get; set; }
        public string PROGRAM_TYPE { get; set; }

        public DateTime DTE { get; set; }
        public DateTime CDE { get; set; }
    }
}