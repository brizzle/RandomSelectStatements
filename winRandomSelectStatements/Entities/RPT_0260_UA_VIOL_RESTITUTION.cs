using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_0260_UA_VIOL_RESTITUTION:basePrisonerLocation
    {
        public DateTime HEARING_DATE { get; set; }
        public string CASE_NUMBER { get; set; }
        public string REPORTED_BY { get; set; }
        public string CODE { get; set; }
        public DateTime BIOATION_DATE { get; set; }
        public string VERDICT { get; set; }
        public string RESTITUTION { get; set; }

    }
}