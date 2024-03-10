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
    public partial class Frm_SA_SEAI : Form
    {

        public string twellnum;
        //传感器名称
        private string[] projects = new string[]
        {
            "大钩载荷传感器",
            "泵冲传感器",
            "绞车传感器",
            "流量传感器",
            "密度传感器",
            "温度传感器",
            "电导率传感器",
            "钻井液液位传感器",
            "转盘转速传感器",
            "扭矩传感器",
            "压力传感器",
            "井筒液位监测仪",
        };
        public Frm_SA_SEAI()
        {
            InitializeComponent();
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 250;
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
            //DgvRowHelper dhelper = new DgvRowHelper(this.dataGridView1);
            //dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 12, "脱气器"));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.SensorEquip blws = new SupervDB.BLL.SensorEquip();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.SensorEquip wst = new SupervDB.Model.SensorEquip();

                wst.Wellnum = twellnum;
                wst.SensorName = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);

                if (wst.SensorName == null || wst.SensorName == "")
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

                string sqlw = " Wellnum = '" + twellnum + "' AND SensorName = '" + wst.SensorName + "'";
                List<SupervDB.Model.SensorEquip> lgws = blws.GetModelList(sqlw);
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
                SupervDB.BLL.SensorEquip blws = new SupervDB.BLL.SensorEquip();
                List<SupervDB.Model.SensorEquip> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.SensorEquip item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView1.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common
                    tdr.Cells[0].Value = item.SensorName;
                    //tdr.Cells[1].Value = DBUtility.DbHelperSQL.GetVtime(item.Affiliation);
                    //tdr.Cells[2].Value = DBUtility.DbHelperSQL.GetVDoule(item.QualCNum);
                    //tdr.Cells[3].Value = DBUtility.DbHelperSQL.GetVDoule(item.TypeTeam);
                    //tdr.Cells[4].Value = DBUtility.DbHelperSQL.GetVDoule(item.TeamLevel);
                    //tdr.Cells[5].Value = DBUtility.DbHelperSQL.GetVDoule(item.CheckResults);
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

        private void Frm_SA_SEAI_Load(object sender, EventArgs e)
        {
            lodaData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lodaData();
        }
    }
}
