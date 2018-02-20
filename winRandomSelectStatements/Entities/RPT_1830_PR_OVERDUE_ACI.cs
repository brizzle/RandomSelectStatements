using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1830_PR_OVERDUE_ACI : basePrisonerLocation
    {
        public int SESSION_MONTH { get; set; }

        public string PROGRAM_CATEGORY { get; set; }
        public string PROGRAM_ASSIGNMENT { get; set; }
        public string CATEGORY_CODE { get; set; }
        public string CAPACITY_GROUP { get; set; }
        public string GR_CODE { get; set; }

        public string SUPERVISOR_ID { get; set; }
        public string SUPERVISOR { get; set; }

    }
}
