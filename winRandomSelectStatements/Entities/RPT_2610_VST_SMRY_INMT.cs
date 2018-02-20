using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2610_VST_SMRY_INMT
    {
        public string VISIT_LOCATION_CODE { get; set; }
        public string VISIT_LOCATION_DESC { get; set; }
        public int ADC_NUMBER { get; set; }
        public string INMATE_NAME { get; set; }
        public string INMATE_STATUS { get; set; }
        public string INMATE_RACE { get; set; }
        public string INMATE_LOCATION_CODE { get; set; }
        public string INMATE_LOCATION_DESC { get; set; }
        public string HOUSING_UNIT { get; set; }
        public string VISITOR_NAME { get; set; }
        public string VISITOR_GENDER { get; set; }
        public string VISITOR_RACE { get; set; }
        public string VISITOR_TYPE { get; set; }
        public DateTime VISIT_DATE { get; set; }
        public DateTime DATE_ADDED { get; set; }
        public DateTime DATE_APPROVED { get; set; }
        public string MINOR_FLAG { get; set; }
        public string VISITOR_STATUS { get; set; }
        public string VISIT_ACTION_TAKEN { get; set; }
        public string VISITOR_ID { get; set; }
        public string PRISON_NAME { get; set; }
    }
}