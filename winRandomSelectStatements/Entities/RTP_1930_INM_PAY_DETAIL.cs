using System;

namespace winRandomSelectStatements.Entities
{
    public class RTP_1930_INM_PAY_DETAIL :baseLocation
    {
        public DateTime ENTRY_DATE { get; set; }
        public decimal HOURS { get; set; }
        public decimal Rate { get; set; }
        public decimal PAY { get; set; }

        public decimal ADJ { get; set; }
        public DateTime ADJ_DATE { get; set; }

        public string STAFF { get; set; }
        public string ASSIGNMENT_ID { get; set; }
        public string ASSIGNMENT_CODE { get; set; }
    }
}