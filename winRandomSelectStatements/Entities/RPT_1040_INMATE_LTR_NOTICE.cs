using System;

namespace winRandomSelectStatements.Entities
{
    public class RPT_1040_INMATE_LTR_NOTICE :basePrisoner
    {
        public DateTime PROCESS_DATE { get; set; }
        public string CASE_NUM { get; set; }
        public string CASE_DESCR { get; set; }
        public string LETTER_TYPE { get; set; }
        public int CREDIT_NUM { get; set; }
    }
}