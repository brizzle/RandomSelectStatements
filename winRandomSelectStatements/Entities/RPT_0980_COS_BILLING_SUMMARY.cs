using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winRandomSelectStatements.Entities
{
    public class RPT_0980_COS_BILLING_SUMMARY : basePrisonerLocation
    {
        public DateTime COS_FEE_START_DATE { get; set; }
        public string DP07_STATUS { get; set; }
        public string FEE_CODE { get; set; }
        public decimal ASSESSED_FEE { get; set; }
        public int SEQ_NUMBER { get; set; }
        public string GL_CODE { get; set; }
        public string OFF_CODE { get; set; }
        public string PPO { get; set; }
        public string SUPERVISOR_TYPE { get; set; }
        public DateTime CASELOAD_DATE { get; set; }
        public DateTime SUPERVISION_END_DATE { get; set; }
        public string DP07_BATCH { get; set; }

    }
}
