using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winRandomSelectStatements
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var dataGen = new DataGenerator<Entities.RPT_1810_CORR_PLAN_STAT_SUM>();
            var sql = new StringBuilder();

            sql.Append(dataGen.CreateViewCreation());
            for (int i = 0; i < 50; i++)
            {
                sql.AppendLine($"{dataGen.CreateSelectLine()} union all ");
            }

            sql.Length -= 13;
            sql.Append(";");


            textBox1.Text = sql.ToString();
        }


        
    }
}
