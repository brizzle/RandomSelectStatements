namespace winRandomSelectStatements.Entities
{
    public class RPT_0330_DISCIPLINE_YTD :baseLocation
    {
        public int POPULATION { get; set; }
        public int TOTAL_VIOLS { get; set; }
        public int TOTAL_FINLZD { get; set; }
        public int TOTAL_NOT_FINLZD { get; set; }
        public int NOT_FINLZD { get; set; }
        public int TOTAL_MAJOR_GUILTY { get; set; }
        public int TOTAL_MINOR_GUILTY { get; set; }
        public int TOTAL_INF_GUILTY { get; set; }
        public int TOTAL_PENDING { get; set; }
        public int TOTAL_OTHER { get; set; }
        public int TOTAL_NG_DS { get; set; }
        public decimal PERC_FND_GUILTY { get; set; }
        public decimal AVG_CYCLE_TIME { get; set; }
        public decimal DISC_PER_IM { get; set; }


    }
}