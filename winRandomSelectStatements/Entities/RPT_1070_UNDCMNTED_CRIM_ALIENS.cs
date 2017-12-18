using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1070_UNDCMNTED_CRIM_ALIENS :basePrisonerLocation
    {
        public DateTime DATE_OF_BIRTH { get; set; }
        public string PLACE_OF_BIRTH { get; set; }
        public string FC_COMMENTS { get; set; }
        public string DET { get; set; }
        public string ICE_ID { get; set; }
    }
}