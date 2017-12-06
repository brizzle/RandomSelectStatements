using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1740_EDU_TEST_STATUS :basePrisonerLocation
    {

        public string GR { get; set; }
        public string SUPERVISOR_NAME { get; set; }

        public DateTime BEGIN_DATE { get; set; }
        public DateTime REL_DATE { get; set; }
        public string LANGUAGE { get; set; }
        public DateTime LANG_TEST_DATE { get; set; }

        public string MATH { get; set; }
        public DateTime MATH_TEST_DATE { get; set; }
        public string READING { get; set; }
        public DateTime READING_TEST_DATE { get; set; }


    }
}