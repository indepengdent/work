using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisorAssist
{
    public partial class Frm_HSE_Emergency_plans_and_drills : Form
    {
        //检查项目
        private string[] SupKey = new string[]
        {
            "应急预案",
            "应急演练",
            
        };
        public Frm_HSE_Emergency_plans_and_drills()
        {
            InitializeComponent();
            this.dataGridView1.RowHeadersWidth = 100;
            dataGridView1.Columns[2].Width = 300;
            for (int i = 0; i < SupKey.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                tdr.Cells[0].Value = SupKey[i];
                tdr.Cells[1].Value = "";

                dataGridView1.Rows.Add(tdr);
            }

            DgvRowHelper dhelper = new DgvRowHelper(this.dataGridView1);
            dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 2, "应急预案与演练"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
