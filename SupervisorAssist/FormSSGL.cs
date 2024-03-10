using Microsoft.Reporting.WinForms;
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
    public partial class FormSSGL : Form
    {
        public string twellnum;
        public FormSSGL()
        {
            InitializeComponent();
            
        }

        private void FormSSGL_Load(object sender, EventArgs e)
        {
            seacher_inform(0);
        }

        //先选择时间再展示信息
        //查询当天信息
        private void button1_Click(object sender, EventArgs e)
        {
            seacher_inform(0);
        }

        //上一个：选定日期的前一天
        private void button2_Click(object sender, EventArgs e)
        {
            seacher_inform(-1);
        }
        //下一个：选定日期的后一天
        private void button3_Click(object sender, EventArgs e)
        {
            seacher_inform(1);
        }

        /// <summary>
        /// 查询某天的数据
        /// </summary>
        /// <param name="n">时间推进天数---n</param>
        public void seacher_inform(int n) {
            //先确定井号
            if (twellnum == null || twellnum == "")
            {
                MessageBox.Show("请选定井号!");
                return;
            }
            //接着选择时间 年-月-日
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("请先选择要显示数据的日期!");
                return;
            }
        
            string Well_num = twellnum;
            string Well_depth = "";
            //当前工况暂未统计
            string Curcondition = "";
            string Layerbit = "";
            string Density = "";
            string Viscosity = "";
            string Loggeologist = "";
            string Instrengineer = "";
            string Geosupervision = "";
            string Wellsegment = "";
            string Packetscoope = "";
            string Cumdisthick = "";
            string Cumdislevel = "";
            int Num_problem1 = 0;
            int Num_problem2 = 0;
            int Num_problem3 = 0;
            int Num_problem4 = 0;
            int Num_problem5 = 0;
            int Num_problem6 = 0;
            int Num_problem7 = 0;
            int Num_problem8 = 0;
            int Num_problem9 = 0;
            int Num_problem10 = 0;
            int Num_problem11 = 0;
            int Num_problem12 = 0;
            int Num_problem13 = 0;
            int Num_problem14 = 0;
            int Num_problem15 = 0;
            int Num_problem16 = 0;
            int Num_problem17 = 0;
            string Problem_des = "";
            string Keysitrefle = "";
            string Typicalcases = "";
            string Check_time = "";
            string Sign_Logteam = "";
            string Sign_Geo = "";
            DataTable dt = new DataTable();
            dt.Columns.Add("Well_num", typeof(string));
            dt.Columns.Add("Well_depth", typeof(string));
            dt.Columns.Add("Curcondition", typeof(string));
            dt.Columns.Add("Layerbit", typeof(string));
            dt.Columns.Add("Density", typeof(string));
            dt.Columns.Add("Viscosity", typeof(string));
            dt.Columns.Add("Loggeologist", typeof(string));
            dt.Columns.Add("Instrengineer", typeof(string));
            dt.Columns.Add("Geosupervision", typeof(string));
            dt.Columns.Add("Wellsegment", typeof(string));
            dt.Columns.Add("Packetscoope", typeof(string));
            dt.Columns.Add("Cumdisthick", typeof(string));
            dt.Columns.Add("Cumdislevel", typeof(string));
            dt.Columns.Add("Num_problem1", typeof(string));
            dt.Columns.Add("Num_problem2", typeof(string));
            dt.Columns.Add("Num_problem3", typeof(string));
            dt.Columns.Add("Num_problem4", typeof(string));
            dt.Columns.Add("Num_problem5", typeof(string));
            dt.Columns.Add("Num_problem6", typeof(string));
            dt.Columns.Add("Num_problem7", typeof(string));
            dt.Columns.Add("Num_problem8", typeof(string));
            dt.Columns.Add("Num_problem9", typeof(string));
            dt.Columns.Add("Num_problem10", typeof(string));
            dt.Columns.Add("Num_problem11", typeof(string));
            dt.Columns.Add("Num_problem12", typeof(string));
            dt.Columns.Add("Num_problem13", typeof(string));
            dt.Columns.Add("Num_problem14", typeof(string));
            dt.Columns.Add("Num_problem15", typeof(string));
            dt.Columns.Add("Num_problem16", typeof(string));
            dt.Columns.Add("Num_problem17", typeof(string));
            dt.Columns.Add("Problem_des", typeof(string));
            dt.Columns.Add("Keysitrefle", typeof(string));
            dt.Columns.Add("Typicalcases", typeof(string));
            dt.Columns.Add("Check_time", typeof(string));
            dt.Columns.Add("Sign_Logteam", typeof(string));
            dt.Columns.Add("Sign_Geo", typeof(string));
            //时间推进
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(n);
            string starttime = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string endtime = dateTimePicker1.Value.ToString("yyyy-MM-dd") + "  23:59:59";
            string sqlwhere = "Wellnum = '" + twellnum + "'";//用于查询井的基本信息
            string sqlwhere2 = " Wellnum = '" + twellnum + "'" + " AND Savetime between '" + starttime + "' and '" + endtime + "'";//用于查询井每天的其它信息

            try
            {
                //基本信息
                SupervDB.BLL.BasicData blgs1 = new SupervDB.BLL.BasicData();
                List<SupervDB.Model.BasicData> lgsv1 = blgs1.GetModelList(sqlwhere);

                if (lgsv1.Count > 0)
                {
                    SupervDB.Model.BasicData gsv = lgsv1[0];
                    Well_depth = gsv.Well_depth.ToString();
                    Layerbit = gsv.LayerBits;
                    Density = gsv.Density.ToString();
                    Viscosity = gsv.Viscosity.ToString();
                    Loggeologist = gsv.LogGeologist;
                    Instrengineer = gsv.InEngineer;
                    Geosupervision = gsv.JdName;
                    Wellsegment = gsv.ManholeSection.ToString();
                    Packetscoope = gsv.PacketNum.ToString();
                    Cumdisthick = gsv.Cum_Depth.ToString();
                    Cumdislevel = gsv.Cum_layerNum.ToString();
                }
                //录井队伍资质
                SupervDB.BLL.TeamQual blws1 = new SupervDB.BLL.TeamQual();
                List<SupervDB.Model.TeamQual> lgws1 = blws1.GetModelList(sqlwhere);
                foreach (SupervDB.Model.TeamQual item in lgws1)
                {
                    //当其余各项均不为空时，有一小项检查结果不合格即说明该大项不合格
                    if (item.CheckResults == "不合格" && item.LogTNum != "" && item.Affiliation != "" && item.QualCNum != "" && item.TypeTeam != "" && item.TeamLevel != "")
                    {
                        Num_problem1 += 1;
                        Problem_des += "1."+Num_problem1 + " "+item.LogTNum + item.CheckResults + "\n";
                    }
                }
                //人员配备及证件
                SupervDB.BLL.StaffDocu blws2 = new SupervDB.BLL.StaffDocu();
                List<SupervDB.Model.StaffDocu> lgws2 = blws2.GetModelList(sqlwhere);
                foreach (SupervDB.Model.StaffDocu item in lgws2)
                {
                    //当其余各项均不为空时，有一小项检查结果不合格即说明该大项不合格
                    if (item.CheckResults == "不合格" && item.Num != "" && item.Name != "" && item.JobNum != "" && item.JobTitle != "" && item.JobLevel != "" && item.WellConcert != "" && item.HS2Cert != "" && item.HSECert != "" && item.FiveSCert != "")
                    {
                        Num_problem2 += 1;
                        Problem_des += "2." + Num_problem2 + " " + item.Num + " " + item.Name + item.CheckResults + "\n";
                    }
                }
                //设备配备及安装
                SupervDB.BLL.EquipCAI blws3 = new SupervDB.BLL.EquipCAI();
                List<SupervDB.Model.EquipCAI> lgws3 = blws3.GetModelList(sqlwhere);
                foreach (SupervDB.Model.EquipCAI item in lgws3)
                {
                    if ((item.CheckResults == "" || item.CheckResults == "不合格") && item.EquipName == "" && item.EquipName == "")
                    {
                        Num_problem3 += 1;
                        Problem_des += "3." + Num_problem3 + " " + item.EquipName + item.Model + item.CheckResults + "\n";
                    }
                }
                //资料准备
                SupervDB.BLL.PrepareMaterials bllp4 = new SupervDB.BLL.PrepareMaterials();
                List<SupervDB.Model.PrepareMaterials> llps4 = bllp4.GetModelList(sqlwhere);
                foreach (SupervDB.Model.PrepareMaterials item in llps4)
                {
                    //当其余各项均不为空时，有一小项检查结果不合格即说明该大项不合格
                    if (item.Checked != "" && item.IsAdopt == false)
                    {
                        Num_problem4 += 1;
                        Problem_des += "4." + Num_problem4 + " " + item.Checked + item.IsAdopt + "\n";
                    }
                }


                //sqlwhere = " Wellnum = '" + twellnum + "'" + " AND Savetime between '" + starttime + "' and '" + endtime + "'";
                SupervDB.BLL.DriTSMana bllp5 = new SupervDB.BLL.DriTSMana();
                List<SupervDB.Model.DriTSMana> llps5 = bllp5.GetModelList(sqlwhere2);
                foreach (SupervDB.Model.DriTSMana item in llps5)
                {
                    //钻具及套管管理
                    if (item.TableName == "钻具及套管管理")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            Num_problem5 += 1;
                            Problem_des += "5." + Num_problem5 + " " + item.CheckProject + item.CheckResults +"( "+item.ProblemDesc+" )" + "\n";
                        }
                    }
                    //设备安装及运行
                    else if (item.TableName == "设备安装及运行")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            Num_problem6 += 1;
                            Problem_des += "6." + Num_problem6 + " " + item.CheckProject + item.CheckResults + "( " + item.ProblemDesc + " )" + "\n";
                        }
                    }
                    //岩性落实
                    else if (item.TableName == "岩性落实")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            Num_problem7 += 1;
                            Problem_des += "7." + Num_problem7 + " " + item.CheckProject + item.CheckResults + "( " + item.ProblemDesc + " )" + "\n";
                        }
                    }
                    //气油层显示落实
                    else if (item.TableName == "油气层发现")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            Num_problem8 += 1;
                            Problem_des += "8." + Num_problem8 + " " + item.CheckProject + item.CheckResults + "( " + item.ProblemDesc + " )" + "\n";
                        }
                    }
                    //地质卡层  
                    else if (item.TableName == "地质卡层")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            Num_problem9 += 1;
                            Problem_des += "9." + Num_problem9 + " " + item.CheckProject + item.CheckResults + "( " + item.ProblemDesc + " )" + "\n";
                        }
                    }
                    //工程预警
                    else if (item.TableName == "工程预警")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            Num_problem10 += 1;
                            Problem_des += "10." + Num_problem10 + " " + item.CheckProject + item.CheckResults + "( " + item.ProblemDesc + " )" + "\n";
                        }
                    }
                    //资料质量  
                    else if (item.TableName == "资料质量")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            Num_problem11 += 1;
                            Problem_des += "11." + Num_problem11 + " " + item.CheckProject + item.CheckResults+"( " + item.ProblemDesc + " )" + "\n";
                        }
                    }
                    else { Well_num = twellnum; }
                }

                SupervDB.BLL.LogWells_SitDuty bllp16 = new SupervDB.BLL.LogWells_SitDuty();
                List<SupervDB.Model.LogWells_SitDuty> llps16 = bllp16.GetModelList(sqlwhere2);
                foreach (SupervDB.Model.LogWells_SitDuty item in llps16)
                {
                    if (item.TableName == "录井坐岗")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            Num_problem12 += 1;
                            Problem_des += "12." + Num_problem12 + " " + item.CheckProject + item.CheckResults + "( " + item.ProblemDesc + " )" + "\n";
                        }
                    }
                    //硫化氢传感器安装与检测
                    else if (item.TableName == "硫化氢传感器安装及检测")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            Num_problem13 += 1;
                            Problem_des += "13." + Num_problem13 + " " + item.CheckProject + item.CheckResults + "( " + item.ProblemDesc + " )" + "\n";
                        }
                    }
                    //安全防护设施配备及管理
                    else if (item.TableName == "硫化氢传感器检测")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            //安全防护设施配备及管理
                            if (item.CheckProject == "正压式呼吸器" || item.CheckProject == "灭火器" || item.CheckProject == "有毒有害气体检测仪" || item.CheckProject == "防毒面具" || item.CheckProject == "报警器" || item.CheckProject == "劳保穿戴")
                            {
                                Num_problem14 += 1;
                                Problem_des += "14." + Num_problem14 + " " + item.CheckProject + item.CheckResults + "( " + item.ProblemDesc + " )" + "\n";
                            }
                            //化学药品配备及管理
                            if (item.CheckProject == "化学药品使用" || item.CheckProject == "化学药品存放" || item.CheckProject == "化学药品管理")
                            {
                                Num_problem15 += 1;
                                Problem_des += "15." + Num_problem15 + " " + item.CheckProject + item.CheckResults + "( " + item.ProblemDesc + " )" + "\n";
                            }
                            //应急预案及演练
                            if (item.CheckProject == "应急预案" || item.CheckProject == "应急演练")
                            {
                                Num_problem16 += 1;
                                Problem_des += "16." + Num_problem16 + " " + item.CheckProject + item.CheckResults + "( " + item.ProblemDesc + " )" + "\n";
                            }
                        }
                    }
                    //录井环境
                    else if (item.TableName == "录井环境")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            Num_problem17 += 1;
                            Problem_des += "17." + Num_problem17 + " " + item.CheckProject + item.CheckResults + "( " + item.ProblemDesc + " )" + "\n";
                        }
                    }
                    else
                    {
                        Well_num = twellnum;
                    }
                }


                SupervDB.BLL.KeySituation blgs7 = new SupervDB.BLL.KeySituation();
                List<SupervDB.Model.KeySituation> lgsv7 = blgs7.GetModelList(sqlwhere2);
                foreach (SupervDB.Model.KeySituation item in lgsv7)
                {
                    if (item.TableName == "典型案例分析")
                    {
                        Typicalcases += item.project + "; " + item.ProblemDes + "\n";
                    }
                    else if (item.TableName == "重点情况反映")
                    {
                        Keysitrefle += item.ProblemDes + "\n";

                    }
                    else
                    {
                        ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dt.Rows.Add(new object[] { Well_num, Well_depth, Curcondition, Layerbit, Density, Viscosity, Loggeologist, Instrengineer, Geosupervision, Wellsegment, Packetscoope, Cumdisthick, Cumdislevel, Num_problem1.ToString(), Num_problem2.ToString(), Num_problem3.ToString(), Num_problem4.ToString(), Num_problem5.ToString(), Num_problem6.ToString(), Num_problem7.ToString(), Num_problem8.ToString(), Num_problem9.ToString(), Num_problem10.ToString(), Num_problem11.ToString(), Num_problem12.ToString(), Num_problem13.ToString(), Num_problem14.ToString(), Num_problem15.ToString(), Num_problem16.ToString(), Num_problem17.ToString(), Problem_des, Keysitrefle, Typicalcases, Check_time, Sign_Logteam, Sign_Geo });
            // 另外需要将ReportMain.rdlc文件复制到当前可执行程序目录下
            //this.reportViewer1.LocalReport.ReportPath = "ReportSSGL.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            // 名称需要用我们之前设定的 "DataSetReport"
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            this.reportViewer1.RefreshReport();

        }


}
}
