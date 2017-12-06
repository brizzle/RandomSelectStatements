namespace winRandomSelectStatements.Entities
{
    public class RPT_1700_WORK_PR_HOURS :baseLocation
    {
        public int POPULATION { get; set; }
        public string ED_CTE { get; set; }
        public string SA_SD_TX { get; set; }
        public decimal BUCKET1 { get; set; }
        public decimal BUCKET2 { get; set; }
        public decimal BUCKET3 { get; set; }
        public decimal BUCKET4 { get; set; }
        public decimal BUCKET5 { get; set; }
        public decimal ZERO_HOURS { get; set; }
        public decimal TOTAL_HOURS { get; set; }
        public decimal HOURS_PER_WEEK_1_29 { get; set; }
        public decimal HOURS_PER_WEEK_GR_29 { get; set; }
    }
}