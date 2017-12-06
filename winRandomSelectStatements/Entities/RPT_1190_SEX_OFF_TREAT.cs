using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1190_SEX_OFF_TREAT :baseLocation
    {

        public DateTime FILTER_DATE { get; set; }
        public int POPULATION { get; set; }
        public int ENROLL_NEW_THIS_MONTH { get; set; }
        public int ENROLL_CURRENT { get; set; }
        public int COMPLETIONS_THIS_MONTH { get; set; }
        public int COMPLETIONS_YEAR_TO_DTE { get; set; }

        public string PROGRAM_ID { get; set; }
        public string PROGRAM_NAME { get; set; }
        public int ENROLL_NEW_ADC { get; set; }
        public int ENROLL_NEW_PRIVATES { get; set; }
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