using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2200_INMATE_WORK_SKILLS :basePrisonerLocation
    {
        public int CU_LEVEL { get; set; }
        public int IR_LEVEL { get; set; }
        public int WL_LEVEL { get; set; }
        public int MEDICAL_LEVEL { get; set; }
        public int MENTALHEALTH_LEVEL { get; set; }
        public int PHASE_LEVEL { get; set; }
        public string SKILL_NAME { get; set; }
        public int SKILL_LEVEL { get; set; }
        public int DURACTION_YEAR { get; set; }
        public int DURACTION_MONTH { get; set; }
        public int END_YEAR { get; set; }
        public int END_MONTH { get; set; }
        public int MONTHLY_SALARY { get; set; }
        public string DISCIPLINE_ID { get; set; }
        public DateTime LAST_DISCIPLINE_DATE { get; set; }
        public int DISC_MIN { get; set; }
        public int DISC_MAJOR { get; set; }

        public string PREVIOUS_PROGRAM { get; set; }



    }
}