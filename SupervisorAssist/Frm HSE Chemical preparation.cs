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
    public partial class Frm_HSE_Chemical_preparation : Form
    {
        //检查项目
        private string[] SupKey = new string[]
        {
            "化学药品使用",
            "化学药品存放",
            "化学药品管理",
        };
        public Frm_HSE_Chemical_preparation()
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
            dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 3, "化学药品使用与管理"));
        }

        private void Fem_HSE_Chemical_preparation_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
