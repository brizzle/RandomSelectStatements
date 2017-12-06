using System.Security.Permissions;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1220_POST_SEC_ACAD_ED: baseLocation
    {
        public int CTE_ENR_MO { get; set; }
        public int CTE_CUM_FY { get; set; }
        public int CTE_CMP_MO { get; set; }
        public int CTE_CMP_YR { get; set; }
        public int CTE_AVG_DAYS_CMP { get; set; }
        public decimal CTE_COMP_PERC { get; set; }


        public int ETV_ENR_MO { get; set; }
        public int ETV_CUM_FY { get; set; }
        public int ETV_CMP_MO { get; set; }
        public int ETV_CMP_YR { get; set; }
        public int ETV_CMP_PER_IM { get; set; }

        public int POST_ENR_MO { get; set; }
        public int POST_CUM_FY { get; set; }
        public int POST_CMP_MO { get; set; }
        public int POST_CMP_YR { get; set; }
        public int POST_CMP_PER_IM { get; set; }


    }
}