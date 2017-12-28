using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2150_WORK_ASSIGN_ELIG : basePrisonerLocation
    {
        public string ASSIGNMENT_AM { get; set; }
        public string ASSIGNMENT_PM { get; set; }
        public string ASSIGNMENT_EVENING { get; set; }
        public string EMP_HC { get; set; }
        public int SKILL_LEVEL { get; set; }
        public DateTime LAST_DISC_VIOLATION { get; set; }
        public string PH { get; set; }
        public string WK_RANK { get; set; }
        public int WORK_LEVEL { get; set; }

        public bool HAS_GED { get; set; }
        public string SECTION_ID { get; set; }


        public bool HAS_DI83 { get; set; }

    }
}