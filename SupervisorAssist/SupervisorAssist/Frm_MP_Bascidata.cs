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
    public partial class Frm_MP_Bascidata : Form
    {
        //录井项目
        private string[] projects = new string[] 
        {
            "钻时录井",
            "岩屑录井",
            "钻井取心",
            "井壁取心",
            "气测录井",
            "钻井液录井",
            "工程录井",
            "泥（页）岩密度分析",
            "碳酸盐含量分析",
            "定量荧光录井",
            "岩石热解地球化学录井",
            "岩石热蒸发烃气相色谱录井",
            "轻烃录井",
            "核磁共振录井",
            "X射线衍射矿物录井",
            "X射线荧光元素录井",
            "自然伽马能谱录井",
            "岩心扫描",
            "岩屑成像录井",
        };
        public Frm_MP_Bascidata()
        {
            InitializeComponent();
            tabControl1.Width = this.Width - 20;
            tabControl1.Height = this.Height - 40 - 70;


            DgvColumnHelper helper = new DgvColumnHelper(this.dataGridView3);
            helper.Headers.Add(new DgvColumnHelper.TopHeader(0, 4, "实际钻头程序"));
            helper.Headers.Add(new DgvColumnHelper.TopHeader(4, 2, "实际套管程序"));

            this.dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView3.ColumnHeadersHeight = 50; //设置Dgv属性ColumnHeadersHeightSizeMode才会生效

            for (int i = 0; i < projects.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView2.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                tdr.Cells[0].Value = i + 1;
                tdr.Cells[1].Value = projects[i];
                tdr.Cells[2].Value = false;

                dataGridView2.Rows.Add(tdr);
            }

            //DgvRowHelper dhelper = new DgvRowHelper(this.dataGridView2);
            //dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 4, "test"));
            //dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(4, 10, "test2"));
           
        }

        private void Frm_MP_Bascidata_Resize(object sender, EventArgs e)
        {
            //tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.Width = this.Width - 20;
            tabControl1.Height = this.Height - 40 - 70;
            //this.TopLevel = false;
            //this.Dock = DockStyle.Fill;
            //from.tabPage1.Text = "开始";
            //this.Parent = from.panel1;
            //this.FormBorderStyle = FormBorderStyle.None;//这里是设置没边框
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_MP_Bascidata_Load(object sender, EventArgs e)
        {

        }
    }
}
