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
    public partial class Frm_SA_Predata : Form
    {
        public string twellnum;
        //录井项目
        private string[] projects = new string[]
        {
            "钻井地质设计",
            "钻井地质设计变更",
            "钻井工程设计",
            "钻井工程设计变更",
            "录井施工方案",
            "Q/SY 01128 录井资料采集处理解释规范",
            "Q/SY 01024 录井资料质量评价规范",
            "Q/SY 01226 综合录井仪质量评定指标",
            "SY/T 5190 石油综合录井仪技术条件",
            "录井工程管理规定",
            "录井资质审核标准",
            "油田公司录井管理制度",
            "邻井资料准备",
        };
        public Frm_SA_Predata()
        {
            InitializeComponent();
            //dataGridView1.Columns[0].Width = 350;
            for (int i = 0; i < projects.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }
                tdr.Cells[0].Value = projects[i];
                dataGridView1.Rows.Add(tdr);
            }
            //DgvRowHelper dhelper = new DgvRowHelper(this.dataGridView1);
            //dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 13, "设计"));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lodaData()
        {
            dataGridView1.Rows.Clear();
            if (twellnum == null || twellnum == "")
            {
                return;
            }
            for (int i = 0; i < projects.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                //tdr.Cells[0].Value = i + 1;
                tdr.Cells[0].Value = projects[i];
                //tdr.Cells[2].Value = false;

                string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " Checked = '" + projects[i] + "'";
                sqlwhere += " ORDER BY Updatetime DESC ";
                try
                {
                    SupervDB.BLL.PrepareMaterials bllp = new SupervDB.BLL.PrepareMaterials();
                    List<SupervDB.Model.PrepareMaterials> llps = bllp.GetModelList(sqlwhere);
                    if (llps.Count > 0)
                    {
                        ((DataGridViewCheckBoxCell)tdr.Cells[1]).Value = llps[0].IsAdopt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dataGridView1.Rows.Add(tdr);
            }

            //自定义项目
            string sqlwhere2 = " Wellnum = '" + twellnum + "' ";

            SupervDB.BLL.PrepareMaterials bllp2 = new SupervDB.BLL.PrepareMaterials();
            List<SupervDB.Model.PrepareMaterials> llps2 = bllp2.GetModelList(sqlwhere2);

            //int curcount = projects.Length + 1;

            foreach (var item in llps2)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                //if (item.proname != null || item.proname != "" || projects.Contains(item.proname)) 
                if (item.Checked == null || item.Checked == "" || projects.Contains(item.Checked))
                {
                    continue;
                }

                //tdr.Cells[0].Value = curcount++;
                tdr.Cells[0].Value = item.Checked;
                ((DataGridViewCheckBoxCell)tdr.Cells[1]).Value = item.IsAdopt;

                dataGridView1.Rows.Add(tdr);
            }



        }

        private void Frm_SA_Predata_Load(object sender, EventArgs e)
        {
            lodaData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SupervDB.BLL.PrepareMaterials bllp = new SupervDB.BLL.PrepareMaterials();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.PrepareMaterials lpro = new SupervDB.Model.PrepareMaterials();

                lpro.Wellnum = twellnum;

                lpro.Checked = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);
                bool isCheck = (bool)this.dataGridView1.Rows[i].Cells[1].EditedFormattedValue;
                //if (!isCheck || lpro.proname == null || lpro.proname == "")
                if (lpro.Checked == null || lpro.Checked == "")
                {
                    continue;
                }

                lpro.IsAdopt = isCheck;
                lpro.Updatetime = DBUtility.DbHelperSQL.getCurtime();
                string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " Checked = '" + lpro.Checked + "'";
                List<SupervDB.Model.PrepareMaterials> llps = bllp.GetModelList(sqlwhere);
                if (llps.Count > 0)
                {
                    lpro.ID = llps[0].ID;
                    bllp.Update(lpro);
                }
                else
                {
                    bllp.Add(lpro);
                }
            }

            MessageBox.Show("保存成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lodaData();
        }
    }
}
