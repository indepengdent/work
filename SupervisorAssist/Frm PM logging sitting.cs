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
    public partial class Frm_PM_logging_sitting : Form
    {
        public string twellnum;       
        public Frm_PM_logging_sitting()
        {
            InitializeComponent();
            dataGridView1.Columns[10].Width = 250;
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
            string sqlwhere = " Wellnum = '" + twellnum + "'"  + "AND Savetime between '" + starttime + "' and '" + endtime + " '";

            try
            {
                SupervDB.BLL.PersonChange blws = new SupervDB.BLL.PersonChange();
                List<SupervDB.Model.PersonChange> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.PersonChange item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView1.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common
                    tdr.Cells[0].Value = item.Num;
                    tdr.Cells[1].Value = item.Name;
                    tdr.Cells[2].Value = item.WorkPlace;
                    tdr.Cells[3].Value = item.JobTitle;
                    tdr.Cells[4].Value = item.JobNum;
                    tdr.Cells[5].Value = item.JobLevel;
                    tdr.Cells[6].Value = item.WellConcert;
                    tdr.Cells[7].Value = item.HS2Cert;
                    tdr.Cells[8].Value = item.HSECert;
                    tdr.Cells[9].Value = item.FiveSCert;
                    tdr.Cells[10].Value = item.CheckResults;
                    dataGridView1.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Frm_PM_logging_sitting_Load(object sender, EventArgs e)
        {
            lodaData(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.PersonChange blws = new SupervDB.BLL.PersonChange();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.PersonChange wst = new SupervDB.Model.PersonChange();

                wst.Wellnum = twellnum;
                wst.Num = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);

                if (wst.Num == null || wst.Num == "")
                {
                    continue;
                }


                wst.Updatetime = DBUtility.DbHelperSQL.getCurtime();

               
                wst.Name = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[1].Value);
                wst.WorkPlace = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[2].Value);
                wst.JobTitle = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[3].Value);
                wst.JobNum = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[4].Value);
                wst.JobLevel = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[5].Value);
                wst.WellConcert = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[6].Value);
                wst.HS2Cert = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[7].Value);
                wst.HSECert = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[8].Value);
                wst.FiveSCert = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[9].Value);
                wst.CheckResults = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[10].Value);
                string sqlw = " Wellnum = '" + twellnum + "'" + " AND" + " Num = '" + wst.Num + "'" + "AND Savetime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                //string sqlw = " Wellnum = '" + twellnum + "' AND Num = '" + wst.Num + "'";
                List<SupervDB.Model.PersonChange> lgws = blws.GetModelList(sqlw);
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
