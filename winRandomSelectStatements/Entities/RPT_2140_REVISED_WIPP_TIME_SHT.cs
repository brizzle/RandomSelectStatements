using System;
using System.Windows.Forms.VisualStyles;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2140_REVISED_WIPP_TIME_SHT :basePrisonerLocation
    {

        public string SUPERVISOR_NAME { get; set; }

        public string WIPP { get; set; }

        public int FISCAL_YEAR { get; set; }
        public int PAY_PERIOD_NUMBER { get; set; }


        public DateTime FROM_DATE { get; set; }
        public DateTime TO_DATE { get; set; }

        public string GROUP_CODE { get; set; }
        public string ALT_NAME { get; set; }
        public string WORK_LEVEL_CODE { get; set; }
        public string WORK_LEVEL_DESCRIPTION { get; set; }



    }
}