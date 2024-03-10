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
    public partial class Frm_HSE_Workload_summary_02 : Form
    {
        public string twellnum;
        //录井服务
        private string[] SupKey1 = new string[]
        {
            "综合录井",
            "气测录井",
            "地质录井", 
        };
        //评价录井
        private string[] SupKey2 = new string[]
        {
            "压力监测",
            "井筒液面监测",
            "定量荧光",
            "岩石热解地球化学录井",
            "岩石热蒸发烃气相色谱录井",
            "轻烃录井",
            "核磁共振录井",
            "X射线衍射矿物录井",
            "X射线荧光元素录井",
            "自然伽马能谱录井",
            "岩心扫描",
            "岩屑成像录井",
            "随钻解释",
           
        };
        //工程复杂类型
        private string[] SupKey3 = new string[]
        {
            "井漏",
            "溢流",
            "井涌",
            "井喷",
            "设备维修",
            "卡钻",
            "处理井眼",
             
        };
        public Frm_HSE_Workload_summary_02()
        {
            InitializeComponent();
            //dataGridView4
            for (int i = 0; i < SupKey1.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView4.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                tdr.Cells[0].Value = SupKey1[i];
                dataGridView4.Rows.Add(tdr);
            }

            //dataGridView1
            for (int i = 0; i < SupKey2.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                tdr.Cells[0].Value = SupKey2[i];
                dataGridView1.Rows.Add(tdr);
            }

            //dataGridView2
            for (int i = 0; i < SupKey3.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView2.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                tdr.Cells[0].Value = SupKey3[i];
                dataGridView2.Rows.Add(tdr);
            }



            //DgvRowHelper dhelper4 = new DgvRowHelper(this.dataGridView4);
            //dhelper4.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 3, "录井服务"));
            //DgvRowHelper dhelper1 = new DgvRowHelper(this.dataGridView1);
            //dhelper1.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 13, "评价录井"));
            //DgvRowHelper dhelper2 = new DgvRowHelper(this.dataGridView2);
            //dhelper2.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 7, "工程复杂"));
            //DgvRowHelper dhelper3 = new DgvRowHelper(this.dataGridView3);
            //dhelper3.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 2, "组织停工"));

        }



       

        private void lodaData_4(int n)
        {
            dataGridView4.Rows.Clear();
           
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
            //string sqlwhere = " Wellnum = '" + twellnum + "'";
            string sqlwhere = " Wellnum = '" + twellnum + "'" +  "AND Savetime between '" + starttime + "' and '" +endtime + " '";
            try
            {
                SupervDB.BLL.LogService blws = new SupervDB.BLL.LogService();
                List<SupervDB.Model.LogService> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.LogService item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView4.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common
                    tdr.Cells[0].Value = item.LogProject;
                    tdr.Cells[1].Value = DBUtility.DbHelperSQL.GetVtime(item.Star_LogTime);
                    tdr.Cells[2].Value = DBUtility.DbHelperSQL.GetVtime(item.End_LogTime);
                    tdr.Cells[3].Value = DBUtility.DbHelperSQL.GetVDoule(item.LogDay); ;
                    tdr.Cells[4].Value = DBUtility.DbHelperSQL.GetVDoule(item.LogPerNum);


                    dataGridView4.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

   

        private void lodaData_1(int n)
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
            // string sqlwhere = " Wellnum = '" + twellnum + "'";
            string sqlwhere = " Wellnum = '" + twellnum + "'" + "AND Savetime between '" + starttime + "' and '" + endtime + " '";
            try
            {
                SupervDB.BLL.EvaluationLog blws = new SupervDB.BLL.EvaluationLog();
                List<SupervDB.Model.EvaluationLog> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.EvaluationLog item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView1.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common
                    tdr.Cells[0].Value = item.ProjectName;
                    tdr.Cells[1].Value = DBUtility.DbHelperSQL.GetVtime(item.Star_Time);
                    tdr.Cells[2].Value = DBUtility.DbHelperSQL.GetVtime(item.End_Time);
                    tdr.Cells[3].Value = DBUtility.DbHelperSQL.GetVDoule(item.LogDay); ;
                    tdr.Cells[4].Value = DBUtility.DbHelperSQL.GetVDoule(item.LogPerNum);


                    dataGridView1.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void lodaData_2(int n) {
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
            // string sqlwhere = " Wellnum = '" + twellnum + "'";
            string sqlwhere = " Wellnum = '" + twellnum + "'" + "AND Savetime between '" + starttime+ "' and '" + endtime + " '";
            try
            {
                SupervDB.BLL.ProjectComplex blws = new SupervDB.BLL.ProjectComplex();
                List<SupervDB.Model.ProjectComplex> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.ProjectComplex item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView2.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common
                    tdr.Cells[0].Value = item.EComplexType;
                    tdr.Cells[1].Value = DBUtility.DbHelperSQL.GetVtime(item.Star_Time);
                    tdr.Cells[2].Value = DBUtility.DbHelperSQL.GetVtime(item.End_Time);
                    tdr.Cells[3].Value = DBUtility.DbHelperSQL.GetVDoule(item.LogDay); ;
                    tdr.Cells[4].Value = DBUtility.DbHelperSQL.GetVDoule(item.LogPerNum);
                    

                    dataGridView2.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lodaData_3(int n)
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
            //string sqlwhere = " Wellnum = '" + twellnum + "'";
            string sqlwhere = " Wellnum = '" + twellnum + "'" + "AND Savetime between '" + starttime+ "' and '" + endtime + " '";
            try
            {
                SupervDB.BLL.OrganiZownTime blws = new SupervDB.BLL.OrganiZownTime();
                List<SupervDB.Model.OrganiZownTime> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.OrganiZownTime item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView3.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common

                    tdr.Cells[0].Value = DBUtility.DbHelperSQL.GetVtime(item.Star_Time);
                    tdr.Cells[1].Value = DBUtility.DbHelperSQL.GetVtime(item.End_Time);
                    tdr.Cells[2].Value = DBUtility.DbHelperSQL.GetVDoule(item.CumNumDay);

                    dataGridView3.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Frm_HSE_Workload_summary_02_Load(object sender, EventArgs e)
        {
            lodaData_1(0);
            lodaData_2(0);
            lodaData_3(0);
            lodaData_4(0);
        }

        

       



        private void button4_Click(object sender, EventArgs e)
        {
            lodaData_1(0);
            lodaData_2(0);
            lodaData_3(0);
            lodaData_4(0);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lodaData_1(0);
            lodaData_2(0);
            lodaData_3(0);
            lodaData_4(0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SupervDB.BLL.LogService blws = new SupervDB.BLL.LogService();
            SupervDB.BLL.EvaluationLog blws1 = new SupervDB.BLL.EvaluationLog();
            SupervDB.BLL.ProjectComplex blws2 = new SupervDB.BLL.ProjectComplex();
            SupervDB.BLL.OrganiZownTime blws3 = new SupervDB.BLL.OrganiZownTime();

            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                SupervDB.Model.LogService wst = new SupervDB.Model.LogService();

                wst.Wellnum = twellnum;
                wst.LogProject = DBUtility.DbHelperSQL.GetVStr(dataGridView4.Rows[i].Cells[0].Value);

                if (wst.LogProject == null || wst.LogProject == "")
                {
                    continue;
                }
                wst.Star_LogTime = DBUtility.DbHelperSQL.SaveVtime(dataGridView4.Rows[i].Cells[1].Value);
                wst.End_LogTime = DBUtility.DbHelperSQL.SaveVtime(dataGridView4.Rows[i].Cells[2].Value);
                wst.LogDay = (decimal)DBUtility.DbHelperSQL.GetVDoule(dataGridView4.Rows[i].Cells[3].Value);
                wst.LogPerNum = (decimal)DBUtility.DbHelperSQL.GetVDoule(dataGridView4.Rows[i].Cells[4].Value);

                wst.Updatetime = DBUtility.DbHelperSQL.getCurtime();
                string sqlw = " Wellnum = '" + twellnum + "'" + " AND" + " LogProject = '" + wst.LogProject + "'" + "AND Savetime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                //string sqlw = " Wellnum = '" + twellnum + "' AND LogProject = '" + wst.LogProject + "'";
                List<SupervDB.Model.LogService> lgws = blws.GetModelList(sqlw);
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

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.EvaluationLog wst1 = new SupervDB.Model.EvaluationLog();

                wst1.Wellnum = twellnum;
                wst1.ProjectName = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);

                if (wst1.ProjectName == null || wst1.ProjectName == "")
                {
                    continue;
                }


                wst1.Updatetime = DBUtility.DbHelperSQL.getCurtime();

                wst1.Star_Time = DBUtility.DbHelperSQL.SaveVtime(dataGridView1.Rows[i].Cells[1].Value);
                wst1.End_Time = DBUtility.DbHelperSQL.SaveVtime(dataGridView1.Rows[i].Cells[2].Value);
                wst1.LogDay = (int)DBUtility.DbHelperSQL.GetVDoule(dataGridView1.Rows[i].Cells[3].Value);
                wst1.LogPerNum = (decimal)DBUtility.DbHelperSQL.GetVDoule(dataGridView1.Rows[i].Cells[4].Value);
                string sqlw1 = " Wellnum = '" + twellnum + "'" + " AND" + " ProjectName = '" + wst1.ProjectName + "'" + "AND Savetime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                //string sqlw1 = " Wellnum = '" + twellnum + "' AND ProjectName = '" + wst1.ProjectName + "'";
                List<SupervDB.Model.EvaluationLog> lgws1 = blws1.GetModelList(sqlw1);
                if (lgws1.Count > 0)
                {
                    wst1.ID = lgws1[0].ID;
                    wst1.Savetime = lgws1[0].Savetime;//用于还原保存的初始时间
                    blws1.Update(wst1);
                }
                else
                {
                    wst1.Savetime = dateTimePicker1.Value;
                    blws1.Add(wst1);
                }
            }

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                SupervDB.Model.ProjectComplex wst2 = new SupervDB.Model.ProjectComplex();

                wst2.Wellnum = twellnum;
                wst2.EComplexType = DBUtility.DbHelperSQL.GetVStr(dataGridView2.Rows[i].Cells[0].Value);

                if (wst2.EComplexType == null || wst2.EComplexType == "")
                {
                    continue;
                }
                wst2.Star_Time = DBUtility.DbHelperSQL.SaveVtime(dataGridView2.Rows[i].Cells[1].Value);
                wst2.End_Time = DBUtility.DbHelperSQL.SaveVtime(dataGridView2.Rows[i].Cells[2].Value);
                wst2.LogDay = (decimal)DBUtility.DbHelperSQL.GetVDoule(dataGridView2.Rows[i].Cells[3].Value);
                wst2.LogPerNum = (decimal)DBUtility.DbHelperSQL.GetVDoule(dataGridView2.Rows[i].Cells[4].Value);

                wst2.Updatetime = DBUtility.DbHelperSQL.getCurtime();

                //if (i > SupKey3.Length)
                //{
                //    //string[] a = new string[] { "1", "2", "3" }; List<string> b = a.ToList(); b.Add("4"); a = b.ToArray();
                //    List<string> b = SupKey3.ToList();
                //    b.Add(DBUtility.DbHelperSQL.GetVStr(dataGridView2.Rows[i].Cells[0].Value));
                //    SupKey3 = b.ToArray();
                //}
                string sqlw2 = " Wellnum = '" + twellnum + "'" + " AND" + " EComplexType = '" + wst2.EComplexType + "'" + "AND Savetime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                //string sqlw2 = " Wellnum = '" + twellnum + "' AND EComplexType = '" + wst2.EComplexType + "'";
                List<SupervDB.Model.ProjectComplex> lgws2 = blws2.GetModelList(sqlw2);
                if (lgws2.Count > 0)
                {
                    wst2.ID = lgws2[0].ID;
                    wst2.Savetime = lgws2[0].Savetime;//用于还原保存的初始时间
                    blws2.Update(wst2);
                }
                else
                {
                    wst2.Savetime = dateTimePicker1.Value;
                    blws2.Add(wst2);
                }
            }

            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                SupervDB.Model.OrganiZownTime wst3 = new SupervDB.Model.OrganiZownTime();

                wst3.Wellnum = twellnum;
                // wst.OpenTime = DBUtility.DbHelperSQL.GetVStr(dataGridView3.Rows[i].Cells[0].Value);
                wst3.Star_Time = DBUtility.DbHelperSQL.SaveVtime(dataGridView3.Rows[i].Cells[0].Value);
                if (wst3.Star_Time == null || wst3.Star_Time.ToString() == "")
                {
                    continue;
                }


                wst3.Updatetime = DBUtility.DbHelperSQL.getCurtime();


                wst3.End_Time = DBUtility.DbHelperSQL.SaveVtime(dataGridView3.Rows[i].Cells[1].Value);
                wst3.CumNumDay = (int)DBUtility.DbHelperSQL.GetVDoule(dataGridView3.Rows[i].Cells[2].Value);
                string sqlw3 = " Wellnum = '" + twellnum + "'" + " AND" + " Star_Time = '" + wst3.Star_Time + "'" + "AND Savetime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                //string sqlw3 = " Wellnum = '" + twellnum + "' AND Star_Time = '" + wst3.Star_Time + "'";
                List<SupervDB.Model.OrganiZownTime> lgws3 = blws3.GetModelList(sqlw3);
                if (lgws3.Count > 0)
                {
                    wst3.ID = lgws3[0].ID;
                    wst3.Savetime = lgws3[0].Savetime;//用于还原保存的初始时间
                    blws3.Update(wst3);
                }
                else
                {
                    wst3.Savetime = dateTimePicker1.Value;
                    blws3.Add(wst3);
                }
            }

            MessageBox.Show("保存成功");
        }
        //昨天
        private void button5_Click(object sender, EventArgs e)
        {
            lodaData_1(-1);
            lodaData_2(0);
            lodaData_3(0);
            lodaData_4(0);
        }
        //明天
        private void button6_Click(object sender, EventArgs e)
        {
            lodaData_1(1);
            lodaData_2(0);
            lodaData_3(0);
            lodaData_4(0);
        }
    }
}
