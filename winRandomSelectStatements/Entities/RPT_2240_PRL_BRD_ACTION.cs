using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2240_PRL_BRD_ACTION
    {
        public string PAROLE_BOARD_ACTION_INMATE_GROUP { get; set; }
        public string GENDER_INDICATOR { get; set; }
        public DateTime PAROLE_BOARD_ACTION_DATE { get; set; }
        public int TOTAL_GRANT { get; set; }
        public int TOTAL_DENY { get; set; }
        public int TOTAL_CONTINUE { get; set; }
        public int TOTAL_REFUSE { get; set; }
        public int TOTAL_GRANT_OTHER_RELEASE { get; set; }
        public int TOTAL_RESCIND { get; set; }
        public int TOTAL_REVOKE { get; set; }
        public int TOTAL_NOT_RESCIND { get; set; }
        public int TOTAL_NOT_REVOKE { get; set; }
        public int TOTAL_REVOKE_REINSTATE { get; set; }

    }
}
