using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1760_DAILY_EDU_TEST_STAT :basePrisoner
    {
        public string PRISON_NAME { get; set; }
        public string BUILDING_NAME { get; set; }
        public string LOCATION_CODE { get; set; }
        public string GR { get; set; }
        public string SUPERVISOR_NAME { get; set; }

        public DateTime BEGIN_DATE { get; set; }

        public string PRIOR_F1 { get; set; }
        public DateTime PRIOR_DATE { get; set; }
        public decimal PRIOR_RDG { get; set; }
        public decimal PRIOR_MTH { get; set; }
        public decimal PRIOR_LNG { get; set; }
        public decimal PRIOR_TOT { get; set; }


        public string CURRENT_F1 { get; set; }
        public DateTime CURRENT_DATE { get; set; }
        public decimal CURRENT_RDG { get; set; }
        public decimal CURRENT_MTH { get; set; }
        public decimal CURRENT_LNG { get; set; }
        public decimal CURRENT_TOT { get; set; }

        public bool MEET_STANDARD { get; set; }
    }
}