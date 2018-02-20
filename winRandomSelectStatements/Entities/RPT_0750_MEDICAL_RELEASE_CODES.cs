using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_0750_MEDICAL_RELEASE_CODES :basePrisonerLocation
    {
        public int MD { get; set; }
        public int MH { get; set; }
        public string CDE { get; set; }
        public DateTime RELEASE_DATE { get; set; }
        public int RELEASE_CODE { get; set; }

    }
}