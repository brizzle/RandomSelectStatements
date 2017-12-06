namespace winRandomSelectStatements.Entities
{
    public class RPT_1140_WEEK_CAP_SUM :baseLocation
    {
        public int ASSIGNED_NUM { get; set; }
        public decimal ASSIGNED_PERC { get; set; }
        public int POPULATION { get; set; }
        public decimal ED { get; set; }
        public decimal CTE { get; set; }
        public decimal SA_SX_TX { get; set; }
        public decimal SELF_IMPR { get; set; }
        public decimal ACI { get; set; }

        public decimal IGA { get; set; }
        public decimal OTHER_WORK { get; set; }
        public decimal TOTAL_CAPACITY { get; set; }
        public int CURRENT_UTIL { get; set; }
        public decimal PERC_UTIL { get; set; }
    }
}