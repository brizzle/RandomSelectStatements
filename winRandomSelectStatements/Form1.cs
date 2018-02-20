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

            MakeSql().GetAwaiter().GetResult();

        }

        private async Task MakeSql()
        {
            var dataGen = new DataGenerator<Entities.RPT_0720_PRINT_DI70_REPORTS>();          // CHANGE THE CLASS HERE to RUN NEW ONE
            var sql = new StringBuilder();

            const int numberRows = 50;
            sql.Append(dataGen.CreateViewCreation());
            for (var i = 0; i < numberRows; i++)
            {
                sql.AppendLine($"{dataGen.CreateSelectLine()} union all ");
            }

            sql.Length -= 13;
            sql.Append(";");


            textBox1.Text = sql.ToString();
        }

        
    }
}
