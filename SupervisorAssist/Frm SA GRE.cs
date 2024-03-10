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
    public partial class Frm_SA_GRE : Form
    {
        public string twellnum;
        //地质房设备配备
        private string[] projects = new string[]
        {
            "岩屑烘烤设备",
            "双目显微镜",
            "荧光灯",
        };
        public Frm_SA_GRE()
        {
            InitializeComponent();
            //for (int i = 0; i < projects.Length; i++)
            //{
            //    DataGridViewRow tdr = new DataGridViewRow();
            //    foreach (DataGridViewColumn c in dataGridView1.Columns)
            //    {
            //        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
            //    }
            //    tdr.Cells[0].Value = i + 1;
            //    tdr.Cells[1].Value = projects[i];
            //    dataGridView1.Rows.Add(tdr);
            //}
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

            for (int i = 0; i < projects.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                tdr.Cells[0].Value = i + 1;
                tdr.Cells[1].Value = projects[i];
                //tdr.Cells[2].Value = false;

                string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " GeoEquip = '" + projects[i] + "'";
                sqlwhere += " ORDER BY Updatetime DESC ";
                try
                {
                    SupervDB.BLL.GeoREquip bllp = new SupervDB.BLL.GeoREquip();
                    List<SupervDB.Model.GeoREquip> llps = bllp.GetModelList(sqlwhere);

                    if (llps.Count > 0)
                    {
                        tdr.Cells[2].Value = llps[0].CheckResults;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dataGridView1.Rows.Add(tdr);
            }
        }

        private void Frm_SA_GRE_Load(object sender, EventArgs e)
        {
            lodaData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.GeoREquip bllp = new SupervDB.BLL.GeoREquip();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.GeoREquip lpro = new SupervDB.Model.GeoREquip();

                lpro.Wellnum = twellnum;
                lpro.Num = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);
                lpro.GeoEquip = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[1].Value);
                //bool isCheck = (bool)this.dataGridView1.Rows[i].Cells[2].EditedFormattedValue;
                if (lpro.GeoEquip == null || lpro.GeoEquip == "")
                {
                    continue;
                }
                lpro.CheckResults = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[2].Value);
                //lpro.CheckResults = isCheck;
                lpro.Updatetime = DBUtility.DbHelperSQL.getCurtime();


                string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " GeoEquip = '" + lpro.GeoEquip + "'";
                List<SupervDB.Model.GeoREquip> llps = bllp.GetModelList(sqlwhere);
                if (llps.Count > 0)
                {
                    lpro.ID = llps[0].ID;
                    bllp.Update(lpro);
                }
                else
                {
                    bllp.Add(lpro);
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
