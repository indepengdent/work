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
    public partial class Frm_SA_Instrumenttation : Form
    {
        public string twellnum;

        public Frm_SA_Instrumenttation()
        {
            InitializeComponent();
            dataGridView1.Columns[0].Width =150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 250;
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
                SupervDB.BLL.EquipCAI blws = new SupervDB.BLL.EquipCAI();
                List<SupervDB.Model.EquipCAI> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.EquipCAI item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView1.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common
                    tdr.Cells[0].Value = item.EquipName;
                    tdr.Cells[1].Value = item.Model;
                    tdr.Cells[2].Value = item.FactoryNum;
                    tdr.Cells[3].Value = item.Manufacturer;
                    tdr.Cells[4].Value = DBUtility.DbHelperSQL.GetVtime(item.DateManu);
                    tdr.Cells[5].Value = item.CheckResults;
                    //tdr.Cells[1].Value = DBUtility.DbHelperSQL.GetVtime(item.EDate);
                    //tdr.Cells[2].Value = DBUtility.DbHelperSQL.GetVDoule(item.Bitdia);
                    //tdr.Cells[3].Value = DBUtility.DbHelperSQL.GetVDoule(item.Welldepth);
                    //tdr.Cells[4].Value = DBUtility.DbHelperSQL.GetVDoule(item.TgWj);
                    //tdr.Cells[5].Value = DBUtility.DbHelperSQL.GetVDoule(item.XDepth);

                    dataGridView1.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Frm_SA_Instrumenttation_Load(object sender, EventArgs e)
        {
            lodaData();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.EquipCAI blws = new SupervDB.BLL.EquipCAI();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.EquipCAI wst = new SupervDB.Model.EquipCAI();

                wst.Wellnum = twellnum;
                wst.EquipName = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);

                if (wst.EquipName == null || wst.EquipName == "")
                {
                    continue;
                }


                wst.Updatetime = DBUtility.DbHelperSQL.getCurtime();

                wst.Model = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[1].Value);
                wst.FactoryNum = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[2].Value);
                wst.Manufacturer = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[3].Value);
                wst.DateManu = DBUtility.DbHelperSQL.SaveVtime(dataGridView1.Rows[i].Cells[4].Value);
                wst.CheckResults = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[5].Value);

                string sqlw = " Wellnum = '" + twellnum + "' AND EquipName = '" + wst.EquipName + "'";
                List<SupervDB.Model.EquipCAI> lgws = blws.GetModelList(sqlw);
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
