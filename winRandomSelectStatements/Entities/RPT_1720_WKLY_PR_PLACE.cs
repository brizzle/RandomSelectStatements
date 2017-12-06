using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1720_WKLY_PR_PLACE : basePrisonerLocation
    {
        public DateTime ADMISSION_DATE { get; set; }
        public DateTime RECD_AT_UNIT { get; set; }
        public DateTime REL_DATE { get; set; }
        public string DI83_PGM { get; set; }
        public string SUPERVISOR_NAME { get; set; }
        public DateTime BEGIN_DATE { get; set; }
        public DateTime END_DATE { get; set; }
        public int PRR_SEC { get; set; }
        public int PRR_RANK { get; set; }

    }
}