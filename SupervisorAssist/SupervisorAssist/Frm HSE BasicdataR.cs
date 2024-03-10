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
    public partial class Frm_HSE_BasicdataR : Form
    {
        public string twellnum;
        //录井项目
        private string[] projects = new string[]
        {
            "导管",
            "一开",
            "...",
        };
        public Frm_HSE_BasicdataR()
        {
            InitializeComponent();
            DgvColumnHelper helper = new DgvColumnHelper(this.dataGridView1);
            helper.Headers.Add(new DgvColumnHelper.TopHeader(0, 4, "钻头程序"));
            helper.Headers.Add(new DgvColumnHelper.TopHeader(4, 2, "实际套管程序"));

            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView1.ColumnHeadersHeight = 50; //设置Dgv属性ColumnHeadersHeightSizeMode才会生效
            for (int i = 0; i < projects.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                tdr.Cells[0].Value = projects[i];
                tdr.Cells[1].Value = "";

                dataGridView1.Rows.Add(tdr);
            }
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
                SupervDB.BLL.GeoSuperv blgs = new SupervDB.BLL.GeoSuperv();
                List<SupervDB.Model.GeoSuperv> lgsv = blgs.GetModelList(sqlwhere);

                if (lgsv.Count > 0)
                {
                    SupervDB.Model.GeoSuperv gsv = lgsv[0];
                    textBox1.Text = gsv.Wellnum;
                    comboBox1.Text = gsv.Well_type;
                    comboBox2.Text = gsv.Well_BB;
                    textBox4.Text = gsv.Location;
                    textBox5.Text = gsv.GZLoc;
                    textBox6.Text = gsv.DrillAim;
                    textBox7.Text = gsv.ComRul;
                    textBox8.Text = gsv.Well_Sd.ToString();
                    textBox9.Text = gsv.Well_HB.ToString();
                    textBox10.Text = gsv.Well_KB.ToString();
                    textBox11.Text = gsv.MainAimLayer;
                    textBox12.Text = gsv.Well_Cd.ToString();
                    textBox13.Text = gsv.Well_depth.ToString();
                    textBox17.Text = gsv.SecAimLayer;
                    textBox18.Text = gsv.SpLen.ToString();
                    textBox19.Text = gsv.Well_CX.ToString();
                    textBox20.Text = gsv.ComSty;
                    textBox21.Text = gsv.LjDepth.ToString();
                    textBox23.Text = gsv.LJEndDate;
                    textBox24.Text = gsv.WzCd.ToString();
                    textBox25.Text = gsv.Wzdepth.ToString();
                    textBox26.Text = gsv.WellLines;
                    //录井项目
                    textBox27.Text = @"钻时录井,岩屑录井,钻井取心,井壁取心,气测录井,钻井液录井,工程录井,泥（页）岩密度分析,
碳酸盐含量分析,定量荧光录井,岩石热解地球化学录井,岩石热蒸发烃气相色谱录井,轻烃录井,
核磁共振录井,X射线衍射矿物录井,X射线荧光元素录井,自然伽马能谱录井,岩心扫描,岩屑成像录井";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //用于下方的表格
            try
            {
                SupervDB.BLL.WellStructure blws = new SupervDB.BLL.WellStructure();
                List<SupervDB.Model.WellStructure> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.WellStructure item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView1.Columns)
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

                    dataGridView1.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_HSE_BasicdataR_Load(object sender, EventArgs e)
        {
            lodaData();
            
        }
    }
}
