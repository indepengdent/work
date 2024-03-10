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
    public partial class Frm_PM_Typical_case_studies : Form
    {
        public string twellnum;
        //项目
        private string[] projects = new string[]
        {
            "问题描述",
            "原因分析",
            "监督策略",
            "监督成效",
        };
        public Frm_PM_Typical_case_studies()
        {
            InitializeComponent();
            dataGridView1.Columns[1].Width = 250;
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
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lodaData(int n)
        {
            dataGridView1.Rows.Clear();

            if (twellnum == null || twellnum == "")
            {
                return;
            }

            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("请先选择日期!");
                return;
            }
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(n);
            string starttime = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string endtime = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59";
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
                string sqlwhere = " Wellnum = '" + twellnum + "'" + " AND" + " project = '" + projects[i] + "'" + "AND Savetime between '" + starttime + "' and '" + endtime + " '";
                //string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " project = '" + projects[i] + "'";
                sqlwhere += " ORDER BY Updatetime DESC ";
                try
                {
                    SupervDB.BLL.KeySituation bllp = new SupervDB.BLL.KeySituation();
                    List<SupervDB.Model.KeySituation> llps = bllp.GetModelList(sqlwhere);

                    if (llps.Count > 0 && llps[0].TableName == "典型案例分析")
                    {
                        tdr.Cells[1].Value = llps[0].ProblemDes;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dataGridView1.Rows.Add(tdr);
            }
        }

        private void Frm_PM_Typical_case_studies_Load(object sender, EventArgs e)
        {
           lodaData(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.KeySituation bllp = new SupervDB.BLL.KeySituation();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.KeySituation lpro = new SupervDB.Model.KeySituation();

                lpro.Wellnum = twellnum;
                //区分不同的表单
                lpro.TableName = DBUtility.DbHelperSQL.GetVStr("典型案例分析");

                lpro.project = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);
                //bool isCheck = (bool)this.dataGridView1.Rows[i].Cells[1].EditedFormattedValue;
                string text = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[1].Value);
                // string str = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[2].Value);
                if (text == null || text == "" || lpro.project == null || lpro.project == "")
                {
                    continue;
                }

                lpro.ProblemDes = text;

                lpro.Updatetime = DBUtility.DbHelperSQL.getCurtime();

                string sqlwhere = " Wellnum = '" + twellnum + "'" + " AND" + " project = '" + projects[i] + "'" + "AND Savetime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                //string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " project = '" + lpro.project + "'";
                List<SupervDB.Model.KeySituation> llps = bllp.GetModelList(sqlwhere);
                if (llps.Count > 0)
                {
                    lpro.ID = llps[0].ID;
                    lpro.Savetime = llps[0].Savetime;//用于还原保存的初始时间
                    bllp.Update(lpro);
                }
                else
                {
                    lpro.Savetime = dateTimePicker1.Value;
                    bllp.Add(lpro);
                }
            }

            MessageBox.Show("保存成功");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lodaData(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lodaData(0);
        }
        //昨天
        private void button5_Click(object sender, EventArgs e)
        {
            lodaData(-1);
        }
        //明天
        private void button6_Click(object sender, EventArgs e)
        {
            lodaData(1);
        }
    }
}
