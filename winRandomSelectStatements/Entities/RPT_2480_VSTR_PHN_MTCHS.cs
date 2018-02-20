namespace winRandomSelectStatements.Entities
{
    public class RPT_2480_VSTR_PHN_MTCHS :basePrisoner
    {
        public int COUNTRY_CODE { get; set; }
        public int AREA_CODE { get; set; }
        public int PHONE_NUMBER { get; set; }
        public string VISITOR_NAME { get; set; }
        public string VISITOR_TYPE { get; set; }
        public string VISITOR_ID { get; set; }
        public string VISITOR_STATUS { get; set; }

        public string LOCATION_CODE { get; set; }
        public string LOCATION_DESC { get; set; }
        public string PRISON_NAME { get; set; }

    }
}