using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_0170_PAROLE_WKST
    {
        public int PAROLE_BOARD_HEARING_YEAR { get; set; }
        public int PAROLE_BOARD_HEARING_MONTH { get; set; }
        public string HEARING_CODE { get; set; }
        public string HEARING_TYPE { get; set; }
        public string OLD_CODE_INDICATOR { get; set; }
        public string NEW_CODE_INDICATOR { get; set; }
        public int ADC_NUMBER { get; set; }
        public string INMATE_NAME { get; set; }
        public string INMATE_LOCATION_CODE { get; set; }
        public string INMATE_LOCATION_DESC { get; set; }
        public string HOUSING_UNIT { get; set; }
        public DateTime INMATE_RECEIVED_DATE { get; set; }
        public string COUNTY_TO_RESIDE { get; set; }
        public string ELIGIBILITY_CODE_DESC { get; set; }
        public string TS_CORRECT_INDICATOR { get; set; }
        public string VERIFIED_BY { get; set; }
        public string DETAINERS_NOTIFICATION { get; set; }
        public string COMMENTS { get; set; }
        public string AUTHORITY { get; set; }
        public string OFFENSE { get; set; }
        public string CMP_CODE { get; set; }
        public int CAUSE_ID { get; set; }
        public string OFFENSE_COUNTY { get; set; }
        public string JUDGE { get; set; }
        public int SENTENCE_YEARS { get; set; }
        public int SENTENCE_MONTHS { get; set; }
        public int SENTENCE_DAYS { get; set; }
        public string CONCURRENT_CONSECUTIVE { get; set; }
        public DateTime SENTENCE_BEGAN_DATE { get; set; }
        public DateTime PAROLE_ELIGIBLE_DATE { get; set; }
        public DateTime MR_PR_DATE { get; set; }
        public DateTime ERCD_SED_DATE { get; set; }
        public DateTime SED_DATE { get; set; }

    }
}