namespace winRandomSelectStatements.Entities
{
    public class RPT_1960_GED_STAT_SUM: baseLocation
    {

        public int COMPLEX_POPULATION { get; set; }
        public int WITH_GED { get; set; }
        public decimal WITH_GED_PERC { get; set; }
        public int WITHOUT_GED { get; set; }
        public decimal WITHOUT_GED_PERC { get; set; }

        public int INMATES_EXEMPT { get; set; }
        public decimal INMATES_EXEMPT_PERC { get; set; }

        public int ABLE_WO_GED { get; set; }
        public decimal ABLE_WO_GED_PERC { get; set; }

        public int ENROLLED_GED { get; set; }
        public int GED_CURRENT_MO { get; set; }
        public int GED_THROUGH_FY { get; set; }

    }
}