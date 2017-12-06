namespace winRandomSelectStatements.Entities
{
    public class RPT_1750_MNTLY_EDU_TEST :baseLocation
    {


        public int POPULATION { get; set; }

        public int MANDATORY_LIT_4690 { get; set; }
        public int MANDATORY_TESTS_90 { get; set; }
        public int MANDATORY_OVERDUE_TOT { get; set; }

        public decimal OV_PERCENT { get; set; }

        public int TESTS_CURRENT { get; set; }
        public int TEST_PRIOR { get; set; }

        public decimal READING { get; set; }
        public decimal MATH { get; set; }
        public decimal LANG { get; set; }
        public decimal TOTAL { get; set; }

        public decimal MDIF { get; set; }
        public decimal RDIF { get; set; }
        public decimal LDIF { get; set; }
        public decimal TDIF { get; set; }
        public int MEET_NUMBER { get; set; }
        public decimal MEET_PERCENT { get; set; }
    }
}