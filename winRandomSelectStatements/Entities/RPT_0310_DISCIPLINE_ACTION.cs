using System;
using System.Windows.Forms;

namespace winRandomSelectStatements.Entities
{
    public class RPT_0310_DISCIPLINE_ACTION :basePrisonerLocation
    {
        public string CASE_NUMBER { get; set; }
        public string RACE { get; set; }
        public string VIOLATION_CODE { get; set; }
        public string VIOLATION { get; set; }
        public DateTime VIOLATION_DATE { get; set; }
        public string VERDICT_CODE { get; set; }
        public string VERDICT { get; set; }
        public DateTime HEARING_DATE { get; set; }
        public string COMMITTEE_VERDICT_CODE { get; set; }
        public string COMMITTEE_VERDICt { get; set; }

        public string VERBAL { get; set; }
        public string WRITTEN { get; set; }
        public string PRIVELEGE_DAY_LOSS { get; set; }
        public string PAROLE_CLASS_DAYS { get; set; }
        public string STAFF_ID { get; set; }
        public string STAFF_NAME { get; set; }
        public string VIO_STATUS { get; set; }
        public string APPEAL_OUTCOME { get; set; }

    }
}