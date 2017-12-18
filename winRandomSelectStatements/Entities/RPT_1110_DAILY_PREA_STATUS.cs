using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1110_DAILY_PREA_STATUS :basePrisonerLocation
    {
        public string AM { get; set; }
        public string PM { get; set; }
        public string EV { get; set; }
        public DateTime DATE_APPROVED { get; set; }

    }
}