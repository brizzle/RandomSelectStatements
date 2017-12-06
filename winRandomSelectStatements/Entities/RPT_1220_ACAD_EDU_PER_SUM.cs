using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1220_ACAD_EDU_PER_SUM: baseLocation
    {
        public DateTime FILTERDATE { get; set; }

        public int CTE_ENROLL_MO { get; set; }
        public int CTE_CUM_ENROLL_FY { get; set; }

        public int CTE_CMP_MO { get; set; }
        public int CTE_CMP_YR { get; set; }
        public int CTE_AVG_DAYS_CMP { get; set; }
        public int CTE_CMP_PERC { get; set; }


        public int ETV_ENROLL_MO { get; set; }
        public int ETV_CUM_ENTROLL_FY { get; set; }
        public int ETC_CMP_MO { get; set; }
        public int ETC_CMP_YR { get; set; }
        public int ETC_CMP_PER_IM { get; set; }

        public int POST_ENROLL_MO { get; set; }
        public int POST_CUM_ENROLL_FY { get; set; }
        public int POST_CMP_MO { get; set; }
        public int POST_CMP_YR { get; set; }
        public int POST_CMP_PER_IM { get; set; }


    }
}