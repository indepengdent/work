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
    public partial class Frm_SA_DEAI : Form
    {
        public string twellnum;
        public Frm_SA_DEAI()
        {
            InitializeComponent();
            dataGridView1.Columns[6].Width = 250;
            //DgvRowHelper dhelper = new DgvRowHelper(this.dataGridView1);
            //dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 2, "脱气器"));
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

            string sqlwhere = " Wellnum = '" + twellnum + "'";

            try
            {
                SupervDB.BLL.DeaeratorEquip blws = new SupervDB.BLL.DeaeratorEquip();
                List<SupervDB.Model.DeaeratorEquip> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.DeaeratorEquip item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView1.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common
                    tdr.Cells[0].Value = item.Model;
                    tdr.Cells[1].Value = item.FactoryNum;
                    tdr.Cells[2].Value = item.Manufacturer;
                    tdr.Cells[3].Value = DBUtility.DbHelperSQL.GetVtime(item.DateManu);
                    tdr.Cells[4].Value = item.CheckResults;
                    tdr.Cells[5].Value = item.IsStandard;
                    tdr.Cells[6].Value = item.ProblemDesc;

                    dataGridView1.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Frm_SA_DEAI_Load(object sender, EventArgs e)
        {
            lodaData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.DeaeratorEquip blws = new SupervDB.BLL.DeaeratorEquip();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.DeaeratorEquip wst = new SupervDB.Model.DeaeratorEquip();

                wst.Wellnum = twellnum;
                wst.Model = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);

                if (wst.Model == null || wst.Model == "")
                {
                    continue;
                }
                wst.Updatetime = DBUtility.DbHelperSQL.getCurtime();
                wst.FactoryNum = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[1].Value);
                wst.Manufacturer = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[2].Value);
                wst.DateManu = DBUtility.DbHelperSQL.SaveVtime(dataGridView1.Rows[i].Cells[3].Value);
                wst.CheckResults = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[4].Value);
                wst.IsStandard = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[5].Value);
                wst.ProblemDesc = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[6].Value);

                string sqlw = " Wellnum = '" + twellnum + "' AND Model = '" + wst.Model + "'";
                List<SupervDB.Model.DeaeratorEquip> lgws = blws.GetModelList(sqlw);
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

        private void button3_Click(object sender, EventArgs e)
        {
            lodaData();
        }
    }
}
