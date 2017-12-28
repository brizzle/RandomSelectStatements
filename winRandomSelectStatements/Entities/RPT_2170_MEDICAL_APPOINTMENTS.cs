using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2170_MEDICAL_APPOINTMENTS : basePrisonerLocation
    {
        public int AAPOINTMENT_TIME { get; set; }
        public string APPOINTMENT_LOCATION { get; set; }
        public string APPOINTMENT_TYPE { get; set; }
        public DateTime APPOINTMENT_DATE { get; set; }
        public string HNR { get; set; }

        public string FOLLOW_UP { get; set; }
        public string REFER { get; set; }
    }
}
