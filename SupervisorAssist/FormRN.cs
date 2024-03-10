using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisorAssist
{
    public partial class FormRN : Form
    {
        public string twellnum;
        public FormRN()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox1.ForeColor = Color.Red;
            textBox2.Visible = false;
            textBox3.Visible = false;
            dateTimePicker1.Visible = false;
           
        }

        private void LodaData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Wellnum", typeof(string));
            dt.Columns.Add("Constructunit", typeof(string));
            dt.Columns.Add("Issueddate", typeof(string));
            dt.Columns.Add("Problems", typeof(string));
            dt.Columns.Add("Rectequire", typeof(string));
            dt.Columns.Add("Geosupervision", typeof(string));
            dt.Columns.Add("Buildsection", typeof(string));

            string sqlwhere = " Wellnum = '" + twellnum + "'";
            string str = "";//用于收集存在的问题
            string now = "";//用于显示下达时间
            string Rectequire = "";//用于显示整改要求
            try
            {
                //脱气器配备及安装
                SupervDB.BLL.DeaeratorEquip blws1 = new SupervDB.BLL.DeaeratorEquip();
                List<SupervDB.Model.DeaeratorEquip> lgws1 = blws1.GetModelList(sqlwhere);
                foreach (SupervDB.Model.DeaeratorEquip item in lgws1)
                {
                    if (item.CheckResults != "" && item.ProblemDesc != "" && item.CheckResults == "不合格")
                    {
                        str += "脱气机" + item.ProblemDesc + "\n";
                    }
                }
                //传感器配备及安装
                SupervDB.BLL.SensorEquip blws2 = new SupervDB.BLL.SensorEquip();
                List<SupervDB.Model.SensorEquip> lgws2 = blws2.GetModelList(sqlwhere);
                foreach (SupervDB.Model.SensorEquip item in lgws2)
                {
                    if (item.CheckResults != "" && item.ProblemDesc != "" && item.CheckResults == "不合格")
                    {
                        str += item.SensorName + item.ProblemDesc + "\n";
                    }
                }
                //评价录井设备配备
                //string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " CheckProject = '" + projects[i] + "'";
                sqlwhere += " ORDER BY Updatetime DESC ";
                SupervDB.BLL.EvalLogEquip bllp3 = new SupervDB.BLL.EvalLogEquip();
                List<SupervDB.Model.EvalLogEquip> llps3 = bllp3.GetModelList(sqlwhere);
                foreach (SupervDB.Model.EvalLogEquip item in llps3)
                {
                    if (item.CheckResults != "" && item.ProblemDesc != "" && item.CheckResults == "不合格")
                    {
                        str += item.CheckProject + item.ProblemDesc + "\n";
                    }
                }

                //钻井及套管管理
                //设备运行检查表
                //岩性落实
                //地质卡层
                //油气显示落实
                //工程预警
                //资料质量
                SupervDB.BLL.DriTSMana bllp4 = new SupervDB.BLL.DriTSMana();
                List<SupervDB.Model.DriTSMana> llps4 = bllp4.GetModelList(sqlwhere);
                foreach (SupervDB.Model.DriTSMana item in llps4)
                {
                    if (item.CheckResults != "" && item.ProblemDesc != "" && (item.CheckResults == "不合格" || item.CheckResults == "不正常" || item.CheckResults == "不到位" || item.CheckResults == "否" || item.CheckResults == "不准确" || item.CheckResults == "不合理"))
                    {
                        str += item.CheckProject + item.ProblemDesc + "\n";
                    }
                }

                //其它监督项目
                SupervDB.BLL.OtherProjects bllp5 = new SupervDB.BLL.OtherProjects();
                List<SupervDB.Model.OtherProjects> llps5 = bllp5.GetModelList(sqlwhere);
                foreach (SupervDB.Model.OtherProjects item in llps5)
                {
                    if (item.CheckResult != "" && item.ProblemDes != "" && item.CheckResult == "不合格")
                    {
                        str += item.Super_Item + item.ProblemDes + "\n";
                    }
                }

                //录井坐岗
                //硫化氢传感器安装及检测
                //硫化氢传感器检测
                //录井环境
                SupervDB.BLL.LogWells_SitDuty bllp6 = new SupervDB.BLL.LogWells_SitDuty();
                List<SupervDB.Model.LogWells_SitDuty> llps6 = bllp6.GetModelList(sqlwhere);
                foreach (SupervDB.Model.LogWells_SitDuty item in llps6)
                {
                    if (item.CheckResults != "" && item.ProblemDesc != "" && (item.CheckResults == "不合格" || item.CheckResults == "不落实"))
                    {
                        str += item.CheckProject + item.ProblemDesc + "\n";
                    }
                }

                //整改要求
                if (comboBox1.Text == "立即整改" || comboBox1.Text == "停工")
                {
                    Rectequire = textBox1.Text;
                }
                else if (comboBox1.Text == "限期整改")
                {
                    Rectequire = textBox2.Text + dateTimePicker1.Text + textBox3.Text;
                }
                else
                {
                    Rectequire = " ";
                }

                //下达时间
                now = DateTime.Now.ToLongDateString().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // 动态添加前台传来的数据
            dt.Rows.Add(new object[] { twellnum, "中建八局", now, str, Rectequire, "暂无", "暂无" });
            // 另外需要将ReportMain.rdlc文件复制到当前可执行程序目录下
            //this.reportViewer1.LocalReport.ReportPath = "ReportRN.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            // 名称需要用我们之前设定的 "DataSetReport"
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            this.reportViewer1.RefreshReport();
        }

        private void Formtext_Load(object sender, EventArgs e)
        {
            LodaData();
            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text == "立即整改")
            {
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                dateTimePicker1.Visible = false;
                textBox1.Text = "责令你单位当日完成整改，并将整改情况书面上报。";
            }
            else if(comboBox1.Text == "停工")
            {
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                dateTimePicker1.Visible = false;
                textBox1.Text = "责令立即停工，按要求进行整改，以书面形式报告整改结果。";
            }
            else if(comboBox1.Text == "限期整改")
            {
                textBox1.Visible = false;
                textBox2.Visible = true;
                textBox3.Visible = true;
                dateTimePicker1.Visible = true;
                textBox2.Text = "责令你单位于";
                textBox3.Text = "前整改完毕，并将整改情况书面上报。";
            }
            else
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                dateTimePicker1.Visible = false;
            }
            //选择完以后刷新报表
            LodaData();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LodaData();
        }


        //public void loadReport()
        //{
        //    DataTable dt = new DataTable();
        //    //定义本地数据表的列，名称应跟之前所建的testDataTable表中列相同。
        //    dt.Columns.Add("Wellnum", typeof(string));
        //    dt.Columns.Add("Constructunit", typeof(string));
        //    dt.Columns.Add("Issueddate", typeof(string));
        //    dt.Columns.Add("Problems", typeof(string));
        //    dt.Columns.Add("Rectequire", typeof(string));
        //    dt.Columns.Add("Geosupervision", typeof(string));
        //    dt.Columns.Add("Buildsection", typeof(string));

        //    //动态生成一些测试用数据

        //    DataRow row = dt.NewRow();
        //    row[0] = "Test01-" + "text";
        //    row[1] = "Test02-" + "text";
        //    row[2] = "Test03-" + "text";
        //    row[3] = "Test04-" + "text";
        //    row[4] = "Test05-" + "text";
        //    row[5] = "Test06-" + "text";
        //    row[6] = "Test07-" + "text";
        //    dt.Rows.Add(row);

        //    //设置本地报表，使程序与之前所建的testReport.rdlc报表文件进行绑定。
        //    this.reportViewer1.LocalReport.ReportPath = "ReportRN.rdlc";
        //    this.reportViewer1.LocalReport.DataSources.Clear();
        //    this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
        //}

    }
}
