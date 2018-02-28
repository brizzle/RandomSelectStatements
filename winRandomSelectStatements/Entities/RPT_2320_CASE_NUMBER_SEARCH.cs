using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2320_CASE_NUMBER_SEARCH :basePrisonerLocation
    {

        public int INMATE_SENT_CODE { get; set; }
        public string SENTENCE { get; set; }
        public string COUNTY { get; set; }
        public string INMATE_STATUS { get; set; }
        public string CASE_NUMBER { get; set; }
        public DateTime BIRTH_DATE { get; set; }

    }
}