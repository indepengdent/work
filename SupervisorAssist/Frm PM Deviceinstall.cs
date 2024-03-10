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
    
    public partial class Frm_PM_Deviceinstall : Form
    {
        public string twellnum;
        //检查项目
        private string[] projects = new string[]
        {
            "设备运行",
            "日常维护保养",
            "全烃",
            "组分",
            "二氧化碳分析仪",
            "定量荧光",
            "岩石热解分析仪",
            "岩石热蒸发烃气相色谱仪",
            "轻烃分析仪",
            "元素分析仪（XRF）",
            "矿物分析仪（XRD）",
            "自然伽马能谱仪",
            "核磁共振分析仪",
            "碳酸盐岩分析仪",
            "泥（页）岩密度计",
        };
        public Frm_PM_Deviceinstall()
        {
            InitializeComponent();
            this.dataGridView1.RowHeadersWidth = 100;
            dataGridView1.Columns[2].Width = 250;
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

            DgvRowHelper dhelper = new DgvRowHelper(this.dataGridView1);
            dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 2, "综合录井仪"));
            dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(2, 2, "色谱仪校验"));
            dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(4, 11, "评价录井"));
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            
        }
        //保存
        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.DriTSMana bllp = new SupervDB.BLL.DriTSMana();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.DriTSMana lpro = new SupervDB.Model.DriTSMana();

                lpro.Wellnum = twellnum;
                //区分不同的表单
                lpro.TableName = DBUtility.DbHelperSQL.GetVStr("设备安装及运行");

                lpro.CheckProject = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);
                //bool isCheck = (bool)this.dataGridView1.Rows[i].Cells[1].EditedFormattedValue;
                string text = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[1].Value);
                string str = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[2].Value);
                if (text == null || text == "" || lpro.CheckProject == null || lpro.CheckProject == "")
                {
                    continue;
                }

                lpro.CheckResults = text;
                lpro.ProblemDesc = str;
                lpro.Updatetime = DBUtility.DbHelperSQL.getCurtime();
                // string sqlwhere = " Wellnum = '" + twellnum + "'" + " AND" + " CheckProject = '" + projects[i] + "'" + 
                //"AND Savetime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                string starttime = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00";
                string endtime = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59";
                string sqlwhere = " Wellnum = '" + twellnum + "'" + " AND" + " CheckProject = '" + projects[i] + "'" + "AND Savetime between '" + starttime + "' and '" + endtime +"'";
                //string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " CheckProject = '" + lpro.CheckProject + "'";
                List<SupervDB.Model.DriTSMana> llps = bllp.GetModelList(sqlwhere);
                if (llps.Count > 0)
                {
                    lpro.ID = llps[0].ID;
                    lpro.Savetime = llps[0].Savetime;//用于还原保存的初始时间
                    bllp.Update(lpro);
                }
                else
                {
                    lpro.Savetime = dateTimePicker1.Value;
                    bllp.Add(lpro);
                }
            }

            MessageBox.Show("保存成功");
        }

        private void lodaData(int n)
        {
            dataGridView1.Rows.Clear();

            if (twellnum == null || twellnum == "")
            {
                return;
            }
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
                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                //tdr.Cells[0].Value = i + 1;
                tdr.Cells[0].Value = projects[i];
                //tdr.Cells[2].Value = false;

                string sqlwhere = " Wellnum = '" + twellnum + "'" + " AND" + " CheckProject = '" + projects[i] + "'" + "AND Savetime between '" + starttime + "' and '" + endtime + "'";
                //string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " CheckProject = '" + projects[i] + "'";
                sqlwhere += " ORDER BY Updatetime DESC ";
                try
                {
                    SupervDB.BLL.DriTSMana bllp = new SupervDB.BLL.DriTSMana();
                    List<SupervDB.Model.DriTSMana> llps = bllp.GetModelList(sqlwhere);

                    if (llps.Count > 0 && llps[0].TableName == "设备安装及运行")
                    {
                        tdr.Cells[1].Value = llps[0].CheckResults;
                        tdr.Cells[2].Value = llps[0].ProblemDesc;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dataGridView1.Rows.Add(tdr);
            }
        }

        private void Frm_PM_Deviceinstall_Load(object sender, EventArgs e)
        {
            lodaData(0);
        }
        //刷新
        private void button2_Click(object sender, EventArgs e)
        {
            lodaData(0);
        }
        //根据时间显示数据--当天
        private void button4_Click(object sender, EventArgs e)
        {
            lodaData(0);
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
