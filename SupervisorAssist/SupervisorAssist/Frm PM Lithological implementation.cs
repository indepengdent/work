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
    public partial class Frm_PM_Lithological_implementation : Form
    {
        public string twellnum;
        //检查项目
        private string[] projects = new string[]
        {
            "岩屑采集按设计执行",
            "岩屑清洗",
            "岩屑晾晒及保管",
            "方入丈量",
            "取心过程按时采集岩屑",
            "岩心出筒",
            "岩心整理",
            "岩心试验",
            "岩心保管",
            "按设计执行",
            "井壁取心样品规格",
            "出心过程",
            "井壁取心整理及保管",
            "岩心试验",
        };
        public Frm_PM_Lithological_implementation()
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
            dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 3, "岩屑采集"));
            dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(3, 6, "钻井取心"));
            dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(9, 5, "井壁取心"));
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox12_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox13_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox14_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
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
                string sqlwhere = " Wellnum = '" + twellnum + "'" + " AND" + " CheckProject = '" + projects[i] + "'" + "AND Savetime between '" + starttime + "' and '" + endtime + " '";
                //string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " CheckProject = '" + projects[i] + "'";
                sqlwhere += " ORDER BY Updatetime DESC ";
                try
                {
                    SupervDB.BLL.DriTSMana bllp = new SupervDB.BLL.DriTSMana();
                    List<SupervDB.Model.DriTSMana> llps = bllp.GetModelList(sqlwhere);

                    if (llps.Count > 0 && llps[0].TableName == "岩性落实")
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

        private void Frm_PM_Lithological_implementation_Load(object sender, EventArgs e)
        {
            lodaData(0);
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
                lpro.TableName = DBUtility.DbHelperSQL.GetVStr("岩性落实");

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
        //刷新
        private void button2_Click(object sender, EventArgs e)
        {
            lodaData(0);
        }

        //选定时间当天
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
