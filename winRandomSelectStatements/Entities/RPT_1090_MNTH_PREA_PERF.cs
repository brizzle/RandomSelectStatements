using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1090_MNTH_PREA_PERF :basePrisonerLocation
    {
        public int THREEDAY_RECEIVED { get; set; }
        public int THREEDAY_ASSESSED { get; set; }


        public int REASSESSED_30 { get; set; }
        public int SRT_RISK_REVIEW { get; set; }
        public int RECEIVED_ALL { get; set; }
        public int RECEIVED_GREATER_2D { get; set; }
        public int RECEIVED_GREATER_29D { get; set; }
        public int PRIOR_82012 { get; set; }

        public int TRIGGER_NUMBER { get; set; }
        public int RETALIATION { get; set; }
        public int REVIEWS_CONDUCTED { get; set; }

        public DateTime TG_REVIEW { get; set; }
        public string STAFF_NAME_TG_REVIEW { get; set; }
        public string TG_REVIEW_CMTS { get; set; }
    }
}