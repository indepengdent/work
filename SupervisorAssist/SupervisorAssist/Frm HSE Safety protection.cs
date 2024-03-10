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
    public partial class Frm_HSE_Safety_protection : Form
    {
        public string twellnum;
        //检查项目
        private string[] SupKey = new string[]
        {
            "正压式呼吸器",
            "灭火器",
            "有毒有害气体检测仪",
            "防毒面具",
            "报警器",
            "劳保穿戴",
        };
        public Frm_HSE_Safety_protection()
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

            //DgvRowHelper dhelper = new DgvRowHelper(this.dataGridView1);
            //dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 6, "安全防护设施配备及管理"));
        }

        private void Frm_HSE_Safety_protection_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
