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
    public partial class Frm_SA_AAPS : Form
    {
        public string twellnum;
        public Frm_SA_AAPS()
        {
            InitializeComponent();
            dataGridView1.Columns[4].Width = 250;
            dataGridView2.Columns[4].Width = 250;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lodaData_Acq()
        {
            dataGridView1.Rows.Clear();

            if (twellnum == null || twellnum == "")
            {
                return;
            }

            string sqlwhere = " Wellnum = '" + twellnum + "'";

            try
            {
                SupervDB.BLL.DataAcqSoft blws = new SupervDB.BLL.DataAcqSoft();
                List<SupervDB.Model.DataAcqSoft> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.DataAcqSoft item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView1.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common
                    tdr.Cells[0].Value = item.TableName;
                    tdr.Cells[1].Value = item.AcpSoftVer;
                    tdr.Cells[2].Value = item.SoftManu;
                    tdr.Cells[3].Value = DBUtility.DbHelperSQL.GetVtime(item.SoftUpTime);
                    tdr.Cells[4].Value = item.CheckResult;
                    dataGridView1.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lodaData_On()
        {
            dataGridView2.Rows.Clear();

            if (twellnum == null || twellnum == "")
            {
                return;
            }

            string sqlwhere = " Wellnum = '" + twellnum + "'";

            try
            {
                SupervDB.BLL.OnDataTran blws = new SupervDB.BLL.OnDataTran();
                List<SupervDB.Model.OnDataTran> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.OnDataTran item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView2.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common
                    tdr.Cells[1].Value = item.TranFormat;
                    tdr.Cells[2].Value = item.TranStab;
                    tdr.Cells[3].Value = DBUtility.DbHelperSQL.GetVtime(item.CheckTime);
                    tdr.Cells[4].Value = item.CheckResult;
                    dataGridView2.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Frm_SA_AAPS_Load(object sender, EventArgs e)
        {
            lodaData_Acq();
            lodaData_On();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.DataAcqSoft blws = new SupervDB.BLL.DataAcqSoft();
            SupervDB.BLL.OnDataTran blws_2 = new SupervDB.BLL.OnDataTran();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.DataAcqSoft wst = new SupervDB.Model.DataAcqSoft();

                wst.Wellnum = twellnum;
                wst.TableName = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);

                if (wst.TableName == null || wst.TableName == "")
                {
                    continue;
                }


                wst.Updatetime = DBUtility.DbHelperSQL.getCurtime();

                wst.AcpSoftVer = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[1].Value);
                wst.SoftManu = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[2].Value);
                wst.SoftUpTime = DBUtility.DbHelperSQL.SaveVtime(dataGridView1.Rows[i].Cells[3].Value);
                wst.CheckResult = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[4].Value);
                

                string sqlw = " Wellnum = '" + twellnum + "' AND TableName = '" + wst.TableName + "'";
                List<SupervDB.Model.DataAcqSoft> lgws = blws.GetModelList(sqlw);
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

            

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                SupervDB.Model.OnDataTran wst2 = new SupervDB.Model.OnDataTran();

                wst2.Wellnum = twellnum;
                wst2.TranFormat = DBUtility.DbHelperSQL.GetVStr(dataGridView2.Rows[i].Cells[1].Value);

                if (wst2.TranFormat == null || wst2.TranFormat == "")
                {
                    continue;
                }


                wst2.Updatetime = DBUtility.DbHelperSQL.getCurtime();

                wst2.TranStab = DBUtility.DbHelperSQL.GetVStr(dataGridView2.Rows[i].Cells[2].Value);
                wst2.CheckTime = DBUtility.DbHelperSQL.SaveVtime(dataGridView2.Rows[i].Cells[3].Value); 
                wst2.CheckResult = DBUtility.DbHelperSQL.GetVStr(dataGridView2.Rows[i].Cells[4].Value);


                string sqlw2 = " Wellnum = '" + twellnum + "' AND TranFormat = '" + wst2.TranFormat + "'";
                List<SupervDB.Model.OnDataTran> lgws2 = blws_2.GetModelList(sqlw2);
                if (lgws2.Count > 0)
                {
                    wst2.ID = lgws2[0].ID;
                    blws_2.Update(wst2);
                }
                else
                {
                    blws_2.Add(wst2);
                }
            }

            MessageBox.Show("保存成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lodaData_Acq();
            lodaData_On();
        }
    }
}
