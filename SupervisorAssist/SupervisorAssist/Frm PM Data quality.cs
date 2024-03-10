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
    public partial class Frm_PM_Data_quality : Form
    {
        public string twellnum;
        //检查项目
        private string[] projects = new string[]
        {
            "基本数据表",
            "录井班报",
            "钻具丈量记录",
            "迟到时间测量记录",
            "岩屑草描记录",
            "样品入库清单",
            "钻井液氯离子滴定记录",
            "套管丈量记录",
            "岩屑描述记录",
            "钻井取心描述记录",
            "井壁取心描述记录",
            "缝洞统计表",
            "后效气体检测记录",
            "工程异常报告单",
            "泥（页）岩密度分析记录",
            "碳酸盐含量分析记录",
            "定量荧光录井分析记录",
            "岩石热解地球化学录井分析记录",
            "岩石热蒸发烃气相色谱录井分析记录",
            "轻烃录井分析记录",
            "核磁共振录井分析记录",
            "X射线衍射矿物录井分析记录",
            "X射线荧光元素录井分析记录",
            "自然伽玛能谱录井分析记录",
            "套管记录",
            "随钻地质录井图",
            "随钻工程录井图",
            "岩心录井图",
        };
        public Frm_PM_Data_quality()
        {
            InitializeComponent();
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
            dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 8, "过程记录"));
            dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(8, 17, "原始资料"));
            dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(25, 3, "随钻录井图"));

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

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
                string sqlwhere = " Wellnum = '" + twellnum + "'" + " AND"+ " CheckProject = '" + projects[i] + "'"+"AND Savetime between '" + starttime + "' and '" + endtime + " '";
                //string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " CheckProject = '" + projects[i] + "'";
                sqlwhere += " ORDER BY Updatetime DESC ";
                try
                {
                    SupervDB.BLL.DriTSMana bllp = new SupervDB.BLL.DriTSMana();
                    List<SupervDB.Model.DriTSMana> llps = bllp.GetModelList(sqlwhere);

                    if (llps.Count > 0&&llps[0].TableName=="资料质量")
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

        private void Frm_PM_Data_quality_Load(object sender, EventArgs e)
        {
            lodaData(0);
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            
        }

       
        //退出
        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //保存信息
        private void button1_Click_1(object sender, EventArgs e)
        {
            SupervDB.BLL.DriTSMana bllp = new SupervDB.BLL.DriTSMana();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.DriTSMana lpro = new SupervDB.Model.DriTSMana();

                lpro.Wellnum = twellnum;
                //区分不同的表单
                lpro.TableName = DBUtility.DbHelperSQL.GetVStr("资料质量");

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

                string sqlwhere = " Wellnum = '" + twellnum + "'" + " AND" + " CheckProject = '" + projects[i] + "'" + "AND Savetime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                //string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " CheckProject = '" + lpro.CheckProject + "'";
                List<SupervDB.Model.DriTSMana> llps = bllp.GetModelList(sqlwhere);
                //if(llps[0].Savetime.ToString() == "")
                //{
                //    lpro.Savetime = dateTimePicker1.Value;
                //}
                //else
                //{
                //    lpro.Savetime = llps[0].Savetime;//用于还原保存的初始时间
                //}
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lodaData(0);
        }

        //根据日期显示信息
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
