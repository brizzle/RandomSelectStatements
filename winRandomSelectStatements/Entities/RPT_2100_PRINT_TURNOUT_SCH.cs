using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2100_PRINT_TURNOUT_SCH :basePrisonerLocation
    {
        public string CATEGORY { get; set; }
        public string CATEGORY_CODE { get; set; }
        public string ASSIGNMENT { get; set; }
        public string ASSIGNMENT_CODE { get; set; }

        public int FACILITATOR_ID { get; set; }
        public string FACILITATOR_NAME { get; set; }

        public int PROGRAM_ID { get; set; }
        public DateTime SESSION_DATE { get; set; }
        public int TIME_SLOT { get; set; }

        public int SESSION_START_TIME { get; set; }
        public int SESSION_END_TIME { get; set; }

        public string SHIFT_AREA { get; set; }
        public string SHIFT_POSITTION { get; set; }

        public string SHIFT_COMMANDER { get; set; }

    }
}