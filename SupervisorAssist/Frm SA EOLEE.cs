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
    public partial class Frm_SA_EOLEE : Form
    {
        public string twellnum;
        //检查项目
        private string[] projects = new string[]
        {
            "定量荧光分析仪",
            "岩石热解分析仪",
            "岩石热蒸发气相色谱仪",
            "轻烃分析仪",
            "元素分析仪（XRF）",
            "矿物分析仪（XRD）",
            "自然伽马能谱仪",
            "核磁共振分析仪",
            "碳酸盐岩分析仪",
            "泥（页）岩密度计",
            "其它",
        };
        public Frm_SA_EOLEE()
        {
            InitializeComponent();
            this.dataGridView1.RowHeadersWidth = 150;
            dataGridView1.Columns[2].Width = 250;
            //for (int i = 0; i < projects.Length; i++)
            //{
            //    DataGridViewRow tdr = new DataGridViewRow();
            //    foreach (DataGridViewColumn c in dataGridView1.Columns)
            //    {
            //        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
            //    }
            //    tdr.Cells[0].Value = projects[i];
            //    dataGridView1.Rows.Add(tdr);
            //}
            //DgvRowHelper dhelper = new DgvRowHelper(this.dataGridView1);
            //dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 11, "评价录井仪配备"));
        }

        private void button2_Click(object sender, EventArgs e)
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

                string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " CheckProject = '" + projects[i] + "'";
                sqlwhere += " ORDER BY Updatetime DESC ";
                try
                {
                    SupervDB.BLL.EvalLogEquip bllp = new SupervDB.BLL.EvalLogEquip();
                    List<SupervDB.Model.EvalLogEquip> llps = bllp.GetModelList(sqlwhere);

                    if (llps.Count > 0)
                    {
                        tdr.Cells[1].Value = llps[0].CheckResults;
                        tdr.Cells[2].Value = llps[0].ProblemDesc;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dataGridView1.Rows.Add(tdr);
            }
        }

        private void Frm_SA_EOLEE_Load(object sender, EventArgs e)
        {
            lodaData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.EvalLogEquip bllp = new SupervDB.BLL.EvalLogEquip();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.EvalLogEquip lpro = new SupervDB.Model.EvalLogEquip();

                lpro.Wellnum = twellnum;

                lpro.CheckProject = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);
                //bool isCheck = (bool)this.dataGridView1.Rows[i].Cells[2].EditedFormattedValue;
                if (lpro.CheckProject == null || lpro.CheckProject == "")
                {
                    continue;
                }

                //lpro.IsAdopt = isCheck;
                lpro.CheckResults = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[1].Value);
                lpro.ProblemDesc = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[2].Value);
                lpro.Updatetime = DBUtility.DbHelperSQL.getCurtime();


                string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " CheckProject = '" + lpro.CheckProject + "'";
                List<SupervDB.Model.EvalLogEquip> llps = bllp.GetModelList(sqlwhere);
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

        private void button3_Click(object sender, EventArgs e)
        {
            lodaData();
        }
    }
}
