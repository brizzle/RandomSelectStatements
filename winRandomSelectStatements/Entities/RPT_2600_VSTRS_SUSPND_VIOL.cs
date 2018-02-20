using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2600_VSTRS_SUSPND_VIOL
    {
        public string VISIT_LOCATION_CODE { get; set; }
        public string VISIT_LOCATION_DESC { get; set; }
        public int ADC_NUMBER { get; set; }
        public string INMATE_NAME { get; set; }
        public string INMATE_STATUS { get; set; }
        public string INMATE_LOCATION_CODE { get; set; }
        public string INMATE_LOCATION_DESC { get; set; }
        public DateTime ADD_DATE { get; set; }
        public DateTime REMOVE_DATE { get; set; }
        public string HOUSING_UNIT { get; set; }
        public string VISITOR_NAME { get; set; }
        public string VISITOR_GENDER { get; set; }
        public string VISITOR_RACE { get; set; }
        public string VISITOR_RELATIONSHIP { get; set; }
        public string VISITOR_TYPE { get; set; }
        public DateTime VISITOR_DOB { get; set; }
        public int VISITOR_SSN { get; set; }
        public string VISITOR_SEC_ID { get; set; }
        public DateTime DATE_ADDED { get; set; }
        public DateTime DATE_APPROVED { get; set; }
        public string MINOR_FLAG { get; set; }
        public string VISITOR_STATUS { get; set; }
        public string VISITOR_ID { get; set; }
        public string VISITOR_SUSPENSION_TYPE { get; set; }
        public DateTime VISITOR_SUSPENSION_BEGIN_DATE { get; set; }
        public DateTime VISITOR_SUSPENSION_END_DATE { get; set; }
        public string SUSPENSION_COMMENT_TYPE { get; set; }
        public DateTime SUSPENSION_COMMENT_DATE { get; set; }
        public string SUSPENSION_COMMENT { get; set; }
        public string PRISON_NAME { get; set; }

    }
}