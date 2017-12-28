using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_2210_WORK_PG_ASSIGNMENT : basePrisonerLocation
    {

        public string RACE { get; set; }

        public int PH { get; set; }
        public string WL { get; set; }
        public string GRP { get; set; }
        public int CU_LEVEL { get; set; }
        public int IR_LEVEL { get; set; }

        public string ASSIGNMENT_AM { get; set; }
        public string ASSIGNMENT_PM { get; set; }
        public string ASSIGNMENT_EVENING { get; set; }
        public DateTime DI83_BEGIN_DATE { get; set; }
        public DateTime DI83_REL_DATE { get; set; }

        public int POPULATION_TOTAL { get; set; }
        public int POPULATION_MIN { get; set; }
        public int POPULATION_MAX { get; set; }
        public int POPULATION_WHITE { get; set; }
        public int POPULATION_BLACK { get; set; }
        public int POPULATION_MEX_AM { get; set; }
        public int POPULATION_MEX_NA { get; set; }
        public int POPULATION_NAT_AM { get; set; }
        public int POPULATION_OTHER { get; set; }

    }
}