using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1200_PSYCOED_PROGRAMS :baseLocation
    {
        public DateTime FILTER_DATE { get; set; }
        public int FACILITY_POPULATION { get; set; }
        public int ENROLL_NEW_MONTH { get; set; }
        public int ENROLL_CURRENT { get; set; }
        public int COMPLETEIONS_THIS_MONTH { get; set; }
        public int COMPLETIONS_YTD { get; set; }


        public int ENROLL_NEW_ADC { get; set; }
        public int ENROLL_NEW_PRIVTES { get; set; }
        public int ENROLL_NEW_TOTAL { get; set; }

        public int ENROLL_CURRENT_ADC { get; set; }
        public int ENROLL_CURRENT_PRIVATES { get; set; }
        public int ENROLL_CURRENT_TOTAL { get; set; }

        public int COMPLETIONS_MONTH_ADC { get; set; }
        public int COMPLETIONS_MONTH_PRIVATES { get; set; }
        public int COMPLETIONS_MONTH_TOTAL { get; set; }

        public int COMPLETIONS_YTD_ADC { get; set; }
        public int COMPLETIONS_YTD_PRIVATES { get; set; }
        public int COMPLETIONS_YTD_TOTAL { get; set; }

    }
}