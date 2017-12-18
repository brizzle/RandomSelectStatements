using System.Drawing.Text;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1180_PLAN_MNG_PERF :basePrisonerLocation
    {
        public int CASES { get; set; }
        public string PLAN_MANAGER { get; set; }

        public int COMPLETED_ICP { get; set; }
        public int COMPLETED_DI99 { get; set; }
        public int COMPLETED_OS { get; set; }
        public int COMPLETED_OTH { get; set; }


        public int OVERDUE_ICP { get; set; }
        public int OVERDUE_DI99 { get; set; }
        public int OVERDUE_OS { get; set; }
        public int OVERDUE_OTH { get; set; }


        public int TOTAL_CMP { get; set; }
        public int TOTAL_OVD { get; set; }
        public int TOTAL_RAT { get; set; }

    }
}