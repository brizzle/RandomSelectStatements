using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winRandomSelectStatements.Entities
{
    public class RPT_0720_PRINT_DI70_REPORTS : basePrisonerLocation
    {
        public string RACE { get; set; }
        public int AGE { get; set; }
        public DateTime ADMITT_DATE { get; set; }
        public string CL_CODE { get; set; }
        public string TY_CODE { get; set; }
        public string NCIC_CODE { get; set; }
        public int SENTENCE_MONTH { get; set; }
        public string CUR_CODE { get; set; }
        public string CUS_CODE { get; set; }
        public string STG { get; set; }
        public string PS_DPS_DUI { get; set; }
        public DateTime LAST_MOVE { get; set; }
        public int RSN { get; set; }
        public int TO_CODE { get; set; }

    }
}
