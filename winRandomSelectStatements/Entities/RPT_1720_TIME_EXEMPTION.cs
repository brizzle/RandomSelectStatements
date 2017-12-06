using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1720_TIME_EXEMPTION
    {
        public int ADC_NUMBER { get; set; }
        public string INMATE_NAME { get; set; }
        public int UNIT_ID { get; set; }
        public string LOCATION_CODE { get; set; }
        public string BUILDING_NAME { get; set; }
        public string BED_NUMBER_DESIGNATION { get; set; }

        public bool MEETS_STANDARD { get; set; }
        public bool GED { get; set; }

        public DateTime CURRENT_ADMIT_DATE { get; set; }
        public DateTime TD_CSBD { get; set; }
        public string ERD { get; set; }

    }
}