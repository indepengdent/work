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
    public partial class Frm_SS_History_of_logging_wells : Form
    {
        public string twellnum;
        public Frm_SS_History_of_logging_wells()
        {
            InitializeComponent();
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 250;
        }
        //退出
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //保存
        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.LogHistory blws = new SupervDB.BLL.LogHistory();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.LogHistory wst = new SupervDB.Model.LogHistory();

                wst.Wellnum = twellnum;
                wst.Lognum = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);

                if (wst.Lognum == null)
                {
                    continue;
                }


                wst.Updatetime = DBUtility.DbHelperSQL.getCurtime();
                wst.Logtime = Convert.ToDateTime(dataGridView1.Rows[i].Cells[1].Value);
                wst.Log_height = (decimal)DBUtility.DbHelperSQL.GetVDoule(dataGridView1.Rows[i].Cells[2].Value);
                wst.Condition = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[3].Value);
                wst.Conditiondesc = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[4].Value);

                string sqlw = " Wellnum = '" + twellnum + "' AND Lognum = '" + wst.Lognum + "'";
                List<SupervDB.Model.LogHistory> lgws = blws.GetModelList(sqlw);
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
                SupervDB.BLL.LogHistory blws = new SupervDB.BLL.LogHistory();
                List<SupervDB.Model.LogHistory> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.LogHistory item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView1.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common
                    tdr.Cells[0].Value = item.Lognum;
                    tdr.Cells[1].Value = DBUtility.DbHelperSQL.GetVtime(item.Logtime);
                    tdr.Cells[2].Value = item.Log_height;
                    tdr.Cells[3].Value = item.Condition;
                    tdr.Cells[4].Value = item.Conditiondesc;

                    dataGridView1.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Frm_SS_History_of_logging_wells_Load(object sender, EventArgs e)
        {
            lodaData();
        }

        //刷新
        private void button3_Click(object sender, EventArgs e)
        {
            lodaData();
        }
    }
}
