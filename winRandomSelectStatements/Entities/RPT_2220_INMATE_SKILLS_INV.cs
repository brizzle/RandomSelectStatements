using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2220_INMATE_SKILLS_INV :basePrisonerLocation
    {

        public string ASSIGNMENT_AM { get; set; }
        public string ASSIGNMENT_PM { get; set; }
        public string ASSIGNMENT_EV { get; set; }
        public DateTime BEG_DATE { get; set; }
        public DateTime RELEASE_DATE { get; set; }

        public string PH { get; set; }
        public string WL { get; set; }
        public string GROUP_ID { get; set; }
        public string RACE { get; set; }

        public string ASSIGNMENT_ID { get; set; }
        public string ASSIGNMENT { get; set; }
        public string CU_LEVEL { get; set; }
        public int IR_LEVEL { get; set; }

        public int AGE { get; set; }
        public string CUSTODY_LEVEL { get; set; }
        public string SEX_STATUS { get; set; }
        public int SKILL_LEVEL { get; set; }

    }
}