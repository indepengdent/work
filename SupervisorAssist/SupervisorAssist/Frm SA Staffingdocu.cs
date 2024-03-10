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
    public partial class Frm_SA_Staffingdocu : Form
    {
        public string twellnum;

        public Frm_SA_Staffingdocu()
        {
            InitializeComponent();
            //dataGridView1.Columns[9].Width = 300;
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

            string sqlwhere = " Wellnum = '" + twellnum + "'";

            try
            {
                SupervDB.BLL.StaffDocu blws = new SupervDB.BLL.StaffDocu();
                List<SupervDB.Model.StaffDocu> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.StaffDocu item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView1.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common
                    tdr.Cells[0].Value = item.Num;
                    //tdr.Cells[1].Value = DBUtility.DbHelperSQL.GetVtime(item.Affiliation);
                    //tdr.Cells[2].Value = DBUtility.DbHelperSQL.GetVDoule(item.QualCNum);
                    //tdr.Cells[3].Value = DBUtility.DbHelperSQL.GetVDoule(item.TypeTeam);
                    //tdr.Cells[4].Value = DBUtility.DbHelperSQL.GetVDoule(item.TeamLevel);
                    //tdr.Cells[5].Value = DBUtility.DbHelperSQL.GetVDoule(item.CheckResults);
                    tdr.Cells[1].Value = item.Name;
                    //tdr.Cells[2].Value = item.WorkPlace;
                    tdr.Cells[2].Value = item.JobTitle;
                    tdr.Cells[3].Value = item.JobNum;
                    tdr.Cells[4].Value = item.JobLevel;
                    tdr.Cells[5].Value = item.WellConcert;
                    tdr.Cells[6].Value = item.HS2Cert;
                    tdr.Cells[7].Value = item.HSECert;
                    tdr.Cells[8].Value = item.FiveSCert;
                    tdr.Cells[9].Value = item.CheckResults;
                    dataGridView1.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Frm_SA_Staffingdocu_Load(object sender, EventArgs e)
        {
            lodaData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.StaffDocu blws = new SupervDB.BLL.StaffDocu();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.StaffDocu wst = new SupervDB.Model.StaffDocu();

                wst.Wellnum = twellnum;
                wst.Num = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);

                if (wst.Num == null || wst.Num == "")
                {
                    continue;
                }


                wst.Updatetime = DBUtility.DbHelperSQL.getCurtime();

                wst.Name = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[1].Value);
                //wst.WorkPlace = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[2].Value);
                wst.JobTitle = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[2].Value);
                wst.JobNum = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[3].Value);
                wst.JobLevel = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[4].Value);
                wst.WellConcert = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[5].Value);
                wst.HS2Cert = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[6].Value);
                wst.HSECert = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[7].Value);
                wst.FiveSCert = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[8].Value);
                wst.CheckResults = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[9].Value);

                string sqlw = " Wellnum = '" + twellnum + "' AND Num = '" + wst.Num + "'";
                List<SupervDB.Model.StaffDocu> lgws = blws.GetModelList(sqlw);
                if (lgws.Count > 0)
                {
                    wst.ID = lgws[0].ID;
                    blws.Update(wst);
                }
                else
                {
                    blws.Add(wst);
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
