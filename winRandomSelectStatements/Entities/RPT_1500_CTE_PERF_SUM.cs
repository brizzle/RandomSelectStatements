namespace winRandomSelectStatements.Entities
{
    public class RPT_1500_CTE_PERF_SUM
    {
        public string PRISON_NAME { get; set; }
        public int UNIT_ID { get; set; }
        public string UNIT_NAME { get; set; }
        public string LOCATION_CODE { get; set; }
        public string BUILDING_NAME { get; set; }

        public string PROGRAM_TYPE { get; set; }
        public int POPULATION { get; set; }
        public int ENROLLMENT_NEW { get; set; }
        public int ENROLLMENT_CURRENT { get; set; }
        public int ENROLLMENT_THIS_MONTH { get; set; }

        public int COMPLETIONS_THIS_MONTH { get; set; }
        public int COMPLETIONS_THIS_YEAR { get; set; }
        public int AVERAGE_DAYS_COMPLETE { get; set; }
    }
}