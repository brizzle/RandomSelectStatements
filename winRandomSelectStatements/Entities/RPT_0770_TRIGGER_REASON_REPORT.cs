using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winRandomSelectStatements.Entities
{
    public class RPT_0770_TRIGGER_REASON_REPORT :baseLocation
    {
        public string ADMIN_REGION { get; set; }
        public DateTime TRIGGER_DATE { get; set; }
        public int TRIGGER_COUNT { get; set; }
        public string TRIGGER_REASON { get; set; }
        public string TRIGGER_TYPE { get; set; }

        public string INMATE_STATUS { get; set; }
        public string SUMMARY_RPT_ID { get; set; }


    }
}
