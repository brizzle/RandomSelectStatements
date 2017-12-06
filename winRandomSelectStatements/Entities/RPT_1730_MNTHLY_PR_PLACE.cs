using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1730_MNTHLY_PR_PLACE : basePrisonerLocation
    {
        public DateTime ADMISSION_DATE { get; set; }
        public DateTime RECD_UNIT { get; set; }
        public DateTime REL_DATE { get; set; }
        public string DI83_PGM { get; set; }
        public string STATUS { get; set; }
        public DateTime BEG_DATE { get; set; }
        public DateTime END_DATE { get; set; }
        public int PRR_SEC { get; set; }
        public int PRR_RANK { get; set; }

    }
}