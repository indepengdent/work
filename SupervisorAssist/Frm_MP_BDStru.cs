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
    public partial class Frm_MP_BDStru : Form
    {
        public string twellnum;

        public Frm_MP_BDStru()
        {
            InitializeComponent();

            DgvColumnHelper helper = new DgvColumnHelper(this.dataGridView3);
            helper.Headers.Add(new DgvColumnHelper.TopHeader(0, 4, "实际钻头程序"));
            helper.Headers.Add(new DgvColumnHelper.TopHeader(4, 2, "实际套管程序"));

            this.dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView3.ColumnHeadersHeight = 50; //设置Dgv属性ColumnHeadersHeightSizeMode才会生效

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lodaData()
        {
            dataGridView3.Rows.Clear();

            if (twellnum == null || twellnum == "")
            {
                return;
            }
            
            string sqlwhere = " Wellnum = '" + twellnum + "'";

            try
            {
                SupervDB.BLL.WellStructure blws = new SupervDB.BLL.WellStructure();
                List<SupervDB.Model.WellStructure> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.WellStructure item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView3.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common
                    tdr.Cells[0].Value = item.OpenTime;
                    tdr.Cells[1].Value = DBUtility.DbHelperSQL.GetVtime(item.EDate);
                    tdr.Cells[2].Value = DBUtility.DbHelperSQL.GetVDoule(item.Bitdia);
                    tdr.Cells[3].Value = DBUtility.DbHelperSQL.GetVDoule(item.Welldepth);
                    tdr.Cells[4].Value = DBUtility.DbHelperSQL.GetVDoule(item.TgWj);
                    tdr.Cells[5].Value = DBUtility.DbHelperSQL.GetVDoule(item.XDepth);

                    dataGridView3.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void Frm_MP_BDStru_Load(object sender, EventArgs e)
        {
            lodaData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.WellStructure blws = new SupervDB.BLL.WellStructure();
            DBUtility.DbHelperSQL.DeleteDatas("WellStructure","Wellnum = '"+twellnum+"'");

            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                SupervDB.Model.WellStructure wst = new SupervDB.Model.WellStructure();

                wst.Wellnum = twellnum;
                wst.OpenTime = DBUtility.DbHelperSQL.GetVStr(dataGridView3.Rows[i].Cells[0].Value);

                if (wst.OpenTime == null || wst.OpenTime == "") 
                {
                    continue;
                }


                wst.Updatetime = DBUtility.DbHelperSQL.getCurtime();

                wst.EDate = DBUtility.DbHelperSQL.SaveVtime(dataGridView3.Rows[i].Cells[1].Value);
                wst.Bitdia = (decimal)DBUtility.DbHelperSQL.GetVDoule(dataGridView3.Rows[i].Cells[2].Value);
                wst.Welldepth = (decimal)DBUtility.DbHelperSQL.GetVDoule(dataGridView3.Rows[i].Cells[3].Value);
                wst.TgWj = (decimal)DBUtility.DbHelperSQL.GetVDoule(dataGridView3.Rows[i].Cells[4].Value);
                wst.XDepth = (decimal)DBUtility.DbHelperSQL.GetVDoule(dataGridView3.Rows[i].Cells[5].Value);
                
                string sqlw = " Wellnum = '" + twellnum + "' AND OpenTime = '" + wst.OpenTime + "'";
                List<SupervDB.Model.WellStructure> lgws = blws.GetModelList(sqlw);
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

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
