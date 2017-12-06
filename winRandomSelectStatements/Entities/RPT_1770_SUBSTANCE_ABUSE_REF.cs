using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1770_SUBSTANCE_ABUSE_REF :basePrisonerLocation
    {

        public DateTime FILTER_DATE { get; set; }

        public int SA_REFERRAL { get; set; }
        public int MH_SCORE { get; set; }
        public DateTime RELEASE_DATE { get; set; }

    }
}