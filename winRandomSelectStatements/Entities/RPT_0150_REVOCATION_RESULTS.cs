using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_0150_REVOCATION_RESULTS
    {
        public int PAROLE_BOARD_HEARING_YEAR { get; set; }
        public int PAROLE_BOARD_HEARING_MONTH { get; set; }
        public string SECURITY_PASSWORD { get; set; }
        public string SELECTION_CRITERIA_CODE { get; set; }
        public string OFFENDER_ID_NUMBER { get; set; }
        public string CURRENT_LOCATION_CODE { get; set; }
        public int ADC_NUMBER { get; set; }
        public string INMATE_NAME { get; set; }
        public string INMATE_LOCATION_CODE { get; set; }
        public string INMATE_LOCATION_DESC { get; set; }
        public string HOUSING_UNIT { get; set; }
        public DateTime HEARING_DATE { get; set; }
        public string ACTION_TAKEN { get; set; }
        public string TIME_FORFEITURE { get; set; }
        public string FINDING { get; set; }
        public string FURTHER_CONDITION_OF_RELEASE { get; set; }

    }
}