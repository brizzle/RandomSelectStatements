using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1940_INMATES_AGE21_NOGED :basePrisonerLocation
    {
        public DateTime FILTER_DATE { get; set; }

        public string CODE { get; set; }
        public string RS { get; set; }
        public DateTime BEG_DATE { get; set; }
        public DateTime END_DATE { get; set; }

        public DateTime DOB { get; set; }

        public string DI83_CODE { get; set; }

    }
}