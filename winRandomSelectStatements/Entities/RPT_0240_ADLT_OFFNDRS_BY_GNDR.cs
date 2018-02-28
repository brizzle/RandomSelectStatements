using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winRandomSelectStatements.Entities
{
    public class RPT_0240_ADLT_OFFNDRS_BY_GNDR :baseLocation
    {
        public int OFFENSE_CODE { get; set; }
        public string OFFENSE_CODE_DESC { get; set; }
        public string INMATE_GENDER { get; set; }
        public int OFFENDER_COUNT { get; set; }

    }
}
