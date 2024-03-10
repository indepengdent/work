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
    public partial class Frm_PM_other_oversight_projects : Form
    {
        public string twellnum;
        public Frm_PM_other_oversight_projects()
        {
            InitializeComponent();
            dataGridView1.Columns[4].Width = 250;
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
            //string sqlwhere = " Wellnum = '" + twellnum + "'";
            string sqlwhere = " Wellnum = '" + twellnum + "'" + "AND Savetime between '" + starttime+ "' and '" + endtime+ " '";
            try
            {
                SupervDB.BLL.OtherProjects blws = new SupervDB.BLL.OtherProjects();
                List<SupervDB.Model.OtherProjects> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.OtherProjects item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView1.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common
                    tdr.Cells[0].Value = item.Supervision;
                    tdr.Cells[1].Value = item.Super_Item;
                    tdr.Cells[2].Value = item.CheckContent;
                    tdr.Cells[3].Value = item.CheckResult;
                    tdr.Cells[4].Value = item.ProblemDes;

                    dataGridView1.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Frm_PM_other_oversight_projects_Load(object sender, EventArgs e)
        {
            lodaData(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.OtherProjects blws = new SupervDB.BLL.OtherProjects();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.OtherProjects wst = new SupervDB.Model.OtherProjects();

                wst.Wellnum = twellnum;
                wst.Supervision = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);

                if (wst.Supervision == null || wst.Supervision == "")
                {
                    continue;
                }


                wst.Updatetime = DBUtility.DbHelperSQL.getCurtime();

                wst.Super_Item = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[1].Value);
                wst.CheckContent = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[2].Value);
                wst.CheckResult = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[3].Value);
                wst.ProblemDes = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[4].Value);

                string sqlw = " Wellnum = '" + twellnum + "'" + " AND" + " Supervision = '" + wst.Supervision + "'" + "AND Savetime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                //string sqlw = " Wellnum = '" + twellnum + "' AND Supervision = '" + wst.Supervision + "'";
                List<SupervDB.Model.OtherProjects> lgws = blws.GetModelList(sqlw);
                if (lgws.Count > 0)
                {
                    wst.ID = lgws[0].ID;
                    wst.Savetime = lgws[0].Savetime;//用于还原保存的初始时间
                    blws.Update(wst);
                }
                else
                {
                    wst.Savetime = dateTimePicker1.Value;
                    blws.Add(wst);
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
