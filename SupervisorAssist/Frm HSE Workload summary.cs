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
    public partial class Frm_HSE_Workload_summary : Form
    {
        public string twellnum;
        //录井项目
        private string[] projects = new string[]
        {
            "钻时录井",
            "岩屑录井",
            "钻井取心",
            "井壁取心",
            "气测录井",
            "钻井液录井",
            "工程录井",
            "泥（页）岩密度分析",
            "碳酸盐含量分析",
            "定量荧光录井",
            "岩石热解地球化学录井",
            "岩石热蒸发烃气相色谱录井",
            "轻烃录井",
            "核磁共振录井",
            "X射线衍射矿物录井",
            "X射线荧光元素录井",
            "自然伽马能谱录井",
            "岩心扫描",
            "岩屑成像录井",
            "其它项目（自定义增加）",
        };

        

        
        public Frm_HSE_Workload_summary()
        {
            InitializeComponent();
           
            DgvColumnHelper helper = new DgvColumnHelper(this.dataGridView2);
            helper.Headers.Add(new DgvColumnHelper.TopHeader(1, 4, "工作量统计"));
            helper.Headers.Add(new DgvColumnHelper.TopHeader(0, 1, "录井项目"));
            this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView2.ColumnHeadersHeight = 50; //设置Dgv属性ColumnHeadersHeightSizeMode才会生效
            for (int i = 0; i < projects.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView2.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                tdr.Cells[0].Value = projects[i];
                dataGridView2.Rows.Add(tdr);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void lodaData(int n)
        {
            dataGridView2.Rows.Clear();

            if (twellnum == null || twellnum == "")
            {
                return;
            }
            //判断是否选择了时间
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("请先选择日期!");
                return;
            }
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(n);
            string starttime = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string endtime = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59";
            for (int i = 0; i < projects.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView2.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                //tdr.Cells[0].Value = i + 1;
                tdr.Cells[0].Value = projects[i];
                //tdr.Cells[2].Value = false;
                string sqlwhere = " Wellnum = '" + twellnum + "'" + " AND" + " LogProject = '" + projects[i] + "'" + "AND Savetime between '" + starttime+ "' and '" + endtime + " '";
                //string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " LogProject = '" + projects[i] + "'";
                sqlwhere += " ORDER BY Updatetime DESC ";
                try
                {
                    SupervDB.BLL.LogWorkloadSta_Footage bllp = new SupervDB.BLL.LogWorkloadSta_Footage();
                    List<SupervDB.Model.LogWorkloadSta_Footage> llps = bllp.GetModelList(sqlwhere);

                    if (llps.Count > 0 )
                    {
                        //tdr.Cells[1].Value = llps[0].CheckResults;
                        //tdr.Cells[2].Value = llps[0].ProblemDesc;
                        //Common
                        tdr.Cells[1].Value = DBUtility.DbHelperSQL.GetVDoule(llps[0].Start_Well_Depth);
                        tdr.Cells[2].Value = DBUtility.DbHelperSQL.GetVDoule(llps[0].End_Well_Depth);
                        tdr.Cells[3].Value = DBUtility.DbHelperSQL.GetVDoule(llps[0].SampleInterval);
                        tdr.Cells[4].Value = DBUtility.DbHelperSQL.GetVDoule(llps[0].Number);
                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dataGridView2.Rows.Add(tdr);
            }
        }

        private void Frm_HSE_Workload_summary_Load(object sender, EventArgs e)
        {
            lodaData(0);
       }

        private void Frm_HSE_Workload_summary_Resize(object sender, EventArgs e)
        {
            //tabControl1.SizeMode = TabSizeMode.Fixed;
           
            //this.TopLevel = false;
            //this.Dock = DockStyle.Fill;
            //from.tabPage1.Text = "开始";
            //this.Parent = from.panel1;
            //this.FormBorderStyle = FormBorderStyle.None;//这里是设置没边框
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lodaData(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SupervDB.BLL.LogWorkloadSta_Footage blws = new SupervDB.BLL.LogWorkloadSta_Footage();

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                SupervDB.Model.LogWorkloadSta_Footage wst = new SupervDB.Model.LogWorkloadSta_Footage();

                wst.Wellnum = twellnum;
                wst.LogProject = DBUtility.DbHelperSQL.GetVStr(dataGridView2.Rows[i].Cells[0].Value);

                if (wst.LogProject == null || wst.LogProject == "")
                {
                    continue;
                }


                wst.Updatetime = DBUtility.DbHelperSQL.getCurtime();


                wst.Start_Well_Depth = (decimal)DBUtility.DbHelperSQL.GetVDoule(dataGridView2.Rows[i].Cells[1].Value);
                wst.End_Well_Depth = (decimal)DBUtility.DbHelperSQL.GetVDoule(dataGridView2.Rows[i].Cells[2].Value);
                wst.SampleInterval = (decimal)DBUtility.DbHelperSQL.GetVDoule(dataGridView2.Rows[i].Cells[3].Value);
                wst.Number = (decimal)DBUtility.DbHelperSQL.GetVDoule(dataGridView2.Rows[i].Cells[4].Value);
                string sqlw = " Wellnum = '" + twellnum + "'" + " AND" + " LogProject = '" + projects[i] + "'" + "AND Savetime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                //string sqlw = " Wellnum = '" + twellnum + "' AND LogProject = '" + wst.LogProject + "'";
                List<SupervDB.Model.LogWorkloadSta_Footage> lgws = blws.GetModelList(sqlw);
                if (lgws.Count > 0)
                {
                    wst.ID = lgws[0].ID;
                    wst.Savetime = lgws[0].Savetime;//用于还原保存的初始时间
                    blws.Update(wst);
                }
                else
                {
                    wst.Savetime = dateTimePicker1.Value;
                    blws.Add(wst);
                }
            }

            MessageBox.Show("保存成功");
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            lodaData(0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //昨天
        private void button5_Click(object sender, EventArgs e)
        {
            lodaData(-1);
        }
        //明天
        private void button6_Click(object sender, EventArgs e)
        {
            lodaData(1);
        }
    }
}
