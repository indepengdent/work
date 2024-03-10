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
    public partial class Frm_HSE_HSSD : Form
    {
        public string twellnum;
        //检查项目
        private string[] projects = new string[]
        {
            "应急预案",
            "应急演练",

            "化学药品使用",
            "化学药品存放",
            "化学药品管理",

            "正压式呼吸器",
            "灭火器",
            "有毒有害气体检测仪",
            "防毒面具",
            "报警器",
            "劳保穿戴",
        };
        public Frm_HSE_HSSD()
        {
            InitializeComponent();
            dataGridView1.Columns[2].Width = 300;
            this.dataGridView1.RowHeadersWidth = 150;

            dataGridView2.Columns[2].Width = 300;
            this.dataGridView2.RowHeadersWidth = 150;

            dataGridView3.Columns[2].Width = 300;
            this.dataGridView3.RowHeadersWidth = 150;
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

            DgvRowHelper dhelper1 = new DgvRowHelper(this.dataGridView1);
            dhelper1.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 2, "应急预案与演练"));
            DgvRowHelper dhelper2 = new DgvRowHelper(this.dataGridView2);
            dhelper2.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 3, "化学药品使用与管理"));
            DgvRowHelper dhelper3 = new DgvRowHelper(this.dataGridView3);
            dhelper3.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 6, "安全防护设施配备及管理"));
        }


        private void lodaData1(int n)
        {
            dataGridView1.Rows.Clear();

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
                if (i >= 2)
                {
                    break;
                }
                else
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
                        SupervDB.BLL.LogWells_SitDuty bllp = new SupervDB.BLL.LogWells_SitDuty();
                        List<SupervDB.Model.LogWells_SitDuty> llps = bllp.GetModelList(sqlwhere);

                        if (llps.Count > 0 && llps[0].TableName == "硫化氢传感器检测")
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
        }

        private void lodaData2(int n)
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
            for (int i = 2; i < 5; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();

                foreach (DataGridViewColumn c in dataGridView2.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                //tdr.Cells[0].Value = i + 1;
                tdr.Cells[0].Value = projects[i];
                //tdr.Cells[2].Value = false;
                string sqlwhere = " Wellnum = '" + twellnum + "'" + " AND" + " CheckProject = '" + projects[i] + "'" + "AND Savetime between '" + starttime+ "' and '" + endtime + " '";

                //string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " CheckProject = '" + projects[i] + "'";
                sqlwhere += " ORDER BY Updatetime DESC ";
                try
                {
                    SupervDB.BLL.LogWells_SitDuty bllp = new SupervDB.BLL.LogWells_SitDuty();
                    List<SupervDB.Model.LogWells_SitDuty> llps = bllp.GetModelList(sqlwhere);

                    if (llps.Count > 0 && llps[0].TableName == "硫化氢传感器检测")
                    {
                        tdr.Cells[1].Value = llps[0].CheckResults;
                        tdr.Cells[2].Value = llps[0].ProblemDesc;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dataGridView2.Rows.Add(tdr);
            }
        }

        private void lodaData3(int n)
        {
            dataGridView3.Rows.Clear();

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
            for (int i = 5; i < projects.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();

                foreach (DataGridViewColumn c in dataGridView3.Columns)
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
                    SupervDB.BLL.LogWells_SitDuty bllp = new SupervDB.BLL.LogWells_SitDuty();
                    List<SupervDB.Model.LogWells_SitDuty> llps = bllp.GetModelList(sqlwhere);

                    if (llps.Count > 0 && llps[0].TableName == "硫化氢传感器检测")
                    {
                        tdr.Cells[1].Value = llps[0].CheckResults;
                        tdr.Cells[2].Value = llps[0].ProblemDesc;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dataGridView3.Rows.Add(tdr);
            }
        }

        private void Frm_HSE_HSSD_Load(object sender, EventArgs e)
        {
            lodaData1(0);
            lodaData2(0);
            lodaData3(0);
        }


        //private void button2_Click(object sender, EventArgs e)
        //{
        //    lodaData1();
        //}

        private void button4_Click(object sender, EventArgs e)
        {
            lodaData1(0);
            lodaData2(0);
            lodaData3(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SupervDB.BLL.LogWells_SitDuty bllp = new SupervDB.BLL.LogWells_SitDuty();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.LogWells_SitDuty lpro = new SupervDB.Model.LogWells_SitDuty();

                lpro.Wellnum = twellnum;
                //区分不同的表单
                lpro.TableName = DBUtility.DbHelperSQL.GetVStr("硫化氢传感器检测");

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
                List<SupervDB.Model.LogWells_SitDuty> llps = bllp.GetModelList(sqlwhere);
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

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                SupervDB.Model.LogWells_SitDuty lpro = new SupervDB.Model.LogWells_SitDuty();

                lpro.Wellnum = twellnum;
                //区分不同的表单
                lpro.TableName = DBUtility.DbHelperSQL.GetVStr("硫化氢传感器检测");

                lpro.CheckProject = DBUtility.DbHelperSQL.GetVStr(dataGridView2.Rows[i].Cells[0].Value);
                //bool isCheck = (bool)this.dataGridView1.Rows[i].Cells[1].EditedFormattedValue;
                string text = DBUtility.DbHelperSQL.GetVStr(dataGridView2.Rows[i].Cells[1].Value);
                string str = DBUtility.DbHelperSQL.GetVStr(dataGridView2.Rows[i].Cells[2].Value);
                if (text == null || text == "" || lpro.CheckProject == null || lpro.CheckProject == "")
                {
                    continue;
                }

                lpro.CheckResults = text;
                lpro.ProblemDesc = str;
                lpro.Updatetime = DBUtility.DbHelperSQL.getCurtime();

                string sqlwhere = " Wellnum = '" + twellnum + "'" + " AND" + " CheckProject = '" + projects[i] + "'" + "AND Savetime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                //string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " CheckProject = '" + lpro.CheckProject + "'";
                List<SupervDB.Model.LogWells_SitDuty> llps = bllp.GetModelList(sqlwhere);
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

            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                SupervDB.Model.LogWells_SitDuty lpro = new SupervDB.Model.LogWells_SitDuty();

                lpro.Wellnum = twellnum;
                //区分不同的表单
                lpro.TableName = DBUtility.DbHelperSQL.GetVStr("硫化氢传感器检测");

                lpro.CheckProject = DBUtility.DbHelperSQL.GetVStr(dataGridView3.Rows[i].Cells[0].Value);
                //bool isCheck = (bool)this.dataGridView1.Rows[i].Cells[1].EditedFormattedValue;
                string text = DBUtility.DbHelperSQL.GetVStr(dataGridView3.Rows[i].Cells[1].Value);
                string str = DBUtility.DbHelperSQL.GetVStr(dataGridView3.Rows[i].Cells[2].Value);
                if (text == null || text == "" || lpro.CheckProject == null || lpro.CheckProject == "")
                {
                    continue;
                }

                lpro.CheckResults = text;
                lpro.ProblemDesc = str;
                lpro.Updatetime = DBUtility.DbHelperSQL.getCurtime();

                string sqlwhere = " Wellnum = '" + twellnum + "'" + " AND" + " CheckProject = '" + projects[i] + "'" + "AND Savetime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                //string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " CheckProject = '" + lpro.CheckProject + "'";
                List<SupervDB.Model.LogWells_SitDuty> llps = bllp.GetModelList(sqlwhere);
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

        private void button2_Click_1(object sender, EventArgs e)
        {
            lodaData1(0);
            lodaData2(0);
            lodaData3(0);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //昨天
        private void button5_Click(object sender, EventArgs e)
        {
            lodaData1(-1);
            lodaData2(0);
            lodaData3(0);
        }
        //明天
        private void button6_Click(object sender, EventArgs e)
        {
            lodaData1(1);
            lodaData2(0);
            lodaData3(0);
        }
    }
}
