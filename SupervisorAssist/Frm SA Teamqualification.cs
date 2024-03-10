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
    public partial class Frm_SA_Teamqualification : Form
    {
        public string twellnum;

        public Frm_SA_Teamqualification()
        {
            InitializeComponent();
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[5].Width = 100;
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
                SupervDB.BLL.TeamQual blws = new SupervDB.BLL.TeamQual();
                List<SupervDB.Model.TeamQual> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.TeamQual item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView1.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common
                    tdr.Cells[0].Value = item.LogTNum;
                    tdr.Cells[1].Value = item.Affiliation;
                    tdr.Cells[2].Value = item.QualCNum;
                    tdr.Cells[3].Value = item.TypeTeam;
                    tdr.Cells[4].Value = item.TeamLevel;
                    tdr.Cells[5].Value = item.CheckResults;

                    dataGridView1.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void Frm_SA_Teamqualification_Load(object sender, EventArgs e)
        {
            lodaData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.TeamQual blws = new SupervDB.BLL.TeamQual();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.TeamQual wst = new SupervDB.Model.TeamQual();

                wst.Wellnum = twellnum;
                wst.LogTNum = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);

                if (wst.LogTNum == null || wst.LogTNum == "")
                {
                    continue;
                }


                wst.Updatetime = DBUtility.DbHelperSQL.getCurtime();

                wst.Affiliation = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[1].Value);
                wst.QualCNum = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[2].Value);
                wst.TypeTeam = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[3].Value);
                wst.TeamLevel = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[4].Value);
                wst.CheckResults = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[5].Value);

                string sqlw = " Wellnum = '" + twellnum + "' AND LogTNum = '" + wst.LogTNum + "'";
                List<SupervDB.Model.TeamQual> lgws = blws.GetModelList(sqlw);
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

        private void Check(int rowindex)
        {
            string lognum = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[rowindex].Cells[0].Value);
            string company = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[rowindex].Cells[1].Value);
            string zznum = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[rowindex].Cells[2].Value);
            string logtype = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[rowindex].Cells[3].Value);
            string loglevel = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[rowindex].Cells[4].Value);

            if (lognum == "")
            {
                dataGridView1.Rows[rowindex].Cells[5].Value = "不合格";
            }
            else
            {
                try
                {
                    string sqlnum = " GLogNum = '" + lognum + "' OR " + " YLogNum = '" + lognum + "'";
                    DBUtility.DbHelperSQL.ChangeDB(1);
                    SupervDB.BLL.DrillGroupQua bldg = new SupervDB.BLL.DrillGroupQua();
                    SupervDB.Model.DrillGroupQua mdgq = new SupervDB.Model.DrillGroupQua();
                    List<SupervDB.Model.DrillGroupQua> lsdg = bldg.GetModelList(sqlnum);

                    DBUtility.DbHelperSQL.ChangeDB(0);

                    if (lsdg.Count > 0)
                    {
                        mdgq = lsdg[lsdg.Count - 1];

                        if ((mdgq.LFSample == company || mdgq.LogFactory == company) &&
                            (mdgq.GZZnum == zznum || mdgq.YZZnum == zznum) &&
                            mdgq.GroupType == logtype && mdgq.GZZlevel == loglevel)
                        {
                            dataGridView1.Rows[rowindex].Cells[5].Value = "合格";
                        }

                    }
                    else
                    {
                        dataGridView1.Rows[rowindex].Cells[5].Value = "不合格";
                    }
                }
                catch (Exception)
                {
                    DBUtility.DbHelperSQL.ChangeDB(0);
                }

            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex != 5 && dataGridView1.CurrentCell.ColumnIndex != -1 && dataGridView1.CurrentCell.RowIndex != -1)
            {
                
                int rowindex = dataGridView1.CurrentCell.RowIndex;

                Check(rowindex);
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == 5 && dataGridView1.CurrentCell.RowIndex != -1)
            {
                int rowindex = dataGridView1.CurrentCell.RowIndex;
                Check(rowindex);
            }
        }
    }
}
