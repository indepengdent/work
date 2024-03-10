using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Forms
{
    public partial class WellForm5 : Form
    {
        public string twellnum;
        public string WellNum = "";
        public string WellSort = "";
        public string WellType = "";
        public string Deep1 = "";
        public string Deep2 = "";
        public string Location = "";
        public string LoggingTeam = "";
        public string TeamType = "";
        public string TeamLevel = "";
        public string SupervisionUnit = "";//监督单位
        public string GeologicalSupervision = "";

        public string WellNum_2 = "";//用的列名相同，用的字段不可相同
        public string WellSort_2 = "";//用的列名相同，用的字段不可相同
        public string WellType_2 = "";//用的列名相同，用的字段不可相同
        public string Deep1_2 = "";//用的列名相同，用的字段不可相同
        public string Deep2_2 = "";//用的列名相同，用的字段不可相同
        public string Location_2 = "";//用的列名相同，用的字段不可相同
        public string LoggingTeam_2 = "";//用的列名相同，用的字段不可相同
        public string TeamType_2 = "";//用的列名相同，用的字段不可相同
        public string TeamLevel_2 = "";//用的列名相同，用的字段不可相同
        public string SupervisionUnit_2 = "";//用的列名相同，用的字段不可相同
        public string GeologicalSupervision_2 = "";//用的列名相同，用的字段不可相同
        public string StartTime1 = "";
        public string StartTime2 = "";
        public string StartTime3 = "";
        public string EndTime1 = "";
        public string EndTime2 = "";
        public string EndTime3 = "";
        public string Days1 = "";
        public string Days2 = "";
        public string Days3 = "";
        public string Logs1 = "";
        public string Logs2 = "";
        public string Logs3 = "";
        public string ComplexType = "";
        public string StartTime = "";
        public string EndTime = "";
        public string ComplexDays = "";
        public string ComplexLogs = "";
        public string OrganizeDowntimeDays = "";
        public string PresentationOfCondition = "";

        public int ProblemNum = 0;
        public string ProblemDescription = "";
        public string RectificationResults = "暂时未知";
        public string GeologicalSupervision_3 = "暂时未知";//用的列名相同，用的字段不可相同
        
        public WellForm5()
        {
            InitializeComponent();
        }

        private void WellForm5_Load(object sender, EventArgs e)
        {
            if (twellnum == null || twellnum == "")
            {
                return;
            }
            //dataset5---DataTable5_1
            
            //dataset5---DataTable5_2
            string LoggingProjects = "";
            string StartDeep = "";
            string EndDeep = "";
            string Interval = "";
            string Number = "";
            //dataset6--DataTable6_1
            
            //dataset6--DataTable6_1
            string Starttime1 = "";
            string Endtime1 = "";
            string ServiceDays = "";
            string Logs1_2 = "";//用的列名相同，用的字段不可相同
            string ProjectName = "";
            //dataset1--DataTable1_1

            string Number_3 = "";//用的列名相同，用的字段不可相同
            string ProblemTypes = "";
            int ProblemNum = 0;
            string ProblemDescription = "";
            string RectificationResults = "";
            string GeologicalSupervision_3 = "";//用的列名相同，用的字段不可相同

            //dataset5---DataTable5_1
            DataTable dt = new DataTable();
            dt.Columns.Add("WellNum", typeof(string));
            dt.Columns.Add("WellSort", typeof(string));
            dt.Columns.Add("WellType", typeof(string));
            dt.Columns.Add("Deep1", typeof(string));
            dt.Columns.Add("Deep2", typeof(string));
            dt.Columns.Add("Location", typeof(string));
            dt.Columns.Add("LoggingTeam", typeof(string));
            dt.Columns.Add("TeamType", typeof(string));
            dt.Columns.Add("TeamLevel", typeof(string));
            dt.Columns.Add("SupervisionUnit", typeof(string));
            dt.Columns.Add("GeologicalSupervision", typeof(string));
            //dataset5---DataTable5_2
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("LoggingProjects", typeof(string));
            dt2.Columns.Add("StartDeep", typeof(string));
            dt2.Columns.Add("EndDeep", typeof(string));
            dt2.Columns.Add("Interval", typeof(string));
            dt2.Columns.Add("Number", typeof(string));


            //dataset6--DataTable6_1
            DataTable dt21 = new DataTable();
            dt21.Columns.Add("WellNum", typeof(string));//用的列名相同，用的字段不可相同
            dt21.Columns.Add("WellSort", typeof(string));
            dt21.Columns.Add("WellType", typeof(string));
            dt21.Columns.Add("Deep1", typeof(string));
            dt21.Columns.Add("Deep2", typeof(string));
            dt21.Columns.Add("Location", typeof(string));
            dt21.Columns.Add("LoggingTeam", typeof(string));
            dt21.Columns.Add("TeamType", typeof(string));
            dt21.Columns.Add("TeamLevel", typeof(string));
            dt21.Columns.Add("SupervisionUnit", typeof(string));
            dt21.Columns.Add("GeologicalSupervision", typeof(string));
            dt21.Columns.Add("StartTime1", typeof(string));
            dt21.Columns.Add("StartTime2", typeof(string));
            dt21.Columns.Add("StartTime3", typeof(string));
            dt21.Columns.Add("EndTime1", typeof(string));
            dt21.Columns.Add("EndTime2", typeof(string));
            dt21.Columns.Add("EndTime3", typeof(string));
            dt21.Columns.Add("Days1", typeof(string));
            dt21.Columns.Add("Days2", typeof(string));
            dt21.Columns.Add("Days3", typeof(string));
            dt21.Columns.Add("Logs1", typeof(string));
            dt21.Columns.Add("Logs2", typeof(string));
            dt21.Columns.Add("Logs3", typeof(string));
            dt21.Columns.Add("ComplexType", typeof(string));
            dt21.Columns.Add("StartTime", typeof(string));
            dt21.Columns.Add("EndTime", typeof(string));
            dt21.Columns.Add("ComplexDays", typeof(string));
            dt21.Columns.Add("ComplexLogs", typeof(string));
            dt21.Columns.Add("OrganizeDowntimeDays", typeof(string));
            dt21.Columns.Add("PresentationOfCondition", typeof(string));
            //dataset6--DataTable6_1
            DataTable dt22 = new DataTable();
            dt22.Columns.Add("Starttime1", typeof(string));
            dt22.Columns.Add("Endtime1", typeof(string));
            dt22.Columns.Add("ServiceDays", typeof(string));
            dt22.Columns.Add("Logs1", typeof(string));
            dt22.Columns.Add("ProjectName", typeof(string));

            //dataset1--DataTable1_1
            DataTable dt31 = new DataTable();
            dt31.Columns.Add("Number", typeof(string));
            dt31.Columns.Add("ProblemTypes", typeof(string));
            dt31.Columns.Add("ProblemNum", typeof(string));
            dt31.Columns.Add("ProblemDescription", typeof(string));
            dt31.Columns.Add("RectificationResults", typeof(string));
            dt31.Columns.Add("GeologicalSupervision", typeof(string));


            string sqlwhere = " Wellnum = '" + twellnum + "'";
            try
            {
                //reportview1---录井工作量统计表（进尺）
                //前两行
                SupervDB.BLL.GeoSuperv blgs = new SupervDB.BLL.GeoSuperv();
                List<SupervDB.Model.GeoSuperv> lgsv = blgs.GetModelList(sqlwhere);
                if (lgsv.Count > 0)
                {
                    SupervDB.Model.GeoSuperv gsv = lgsv[0];
                    WellNum = gsv.Wellnum;
                    WellSort = gsv.Well_BB;
                    WellType = gsv.Well_type;
                    Deep1 = gsv.Well_depth.ToString();
                    Deep2 = gsv.Wzdepth.ToString();
                    Location = gsv.LJEndDate;
                    //地质监督
                    GeologicalSupervision = gsv.JdName;


                    WellNum_2 = gsv.Wellnum;;//用的列名相同，用的字段不可相同
                    WellSort_2 = gsv.Well_BB;//用的列名相同，用的字段不可相同
                    WellType_2 = gsv.Well_type;//用的列名相同，用的字段不可相同
                    Deep1_2 = gsv.Well_depth.ToString();//用的列名相同，用的字段不可相同
                    Deep2_2 = gsv.Wzdepth.ToString();//用的列名相同，用的字段不可相同
                    Location_2 = gsv.LJEndDate; ;//用的列名相同，用的字段不可相同
                    //地质监督
                    GeologicalSupervision_2 = gsv.JdName;//用的列名相同，用的字段不可相同
                }
                //第三行
                SupervDB.BLL.TeamQual blws = new SupervDB.BLL.TeamQual();
                List<SupervDB.Model.TeamQual> lgws = blws.GetModelList(sqlwhere);
                if (lgws.Count > 0)
                {
                    SupervDB.Model.TeamQual gsv = lgws[0];
                    LoggingTeam = gsv.LogTNum;
                    TeamType = gsv.TypeTeam;
                    TeamLevel = gsv.TeamLevel;

                    LoggingTeam_2 = gsv.LogTNum;//用的列名相同，用的字段不可相同
                    TeamType_2 = gsv.TypeTeam;//用的列名相同，用的字段不可相同
                    TeamLevel_2 = gsv.TeamLevel;//用的列名相同，用的字段不可相同
                }
                //第四行
                //监督单位暂时没有，暂时空置

                //下方数据表
                SupervDB.BLL.LogWorkloadSta_Footage bllp = new SupervDB.BLL.LogWorkloadSta_Footage();
                List<SupervDB.Model.LogWorkloadSta_Footage> llps = bllp.GetModelList(sqlwhere);
                foreach (SupervDB.Model.LogWorkloadSta_Footage item in llps)
                {
                    DataRow dr = dt2.NewRow();
                    //Common
                    dr["LoggingProjects"] = item.LogProject;
                    dr["StartDeep"] = item.Start_Well_Depth.ToString();
                    dr["EndDeep"] = item.End_Well_Depth.ToString();
                    dr["Interval"] =item.SampleInterval.ToString();
                    dr["Number"] = item.Number.ToString();
                    dt2.Rows.Add(dr);
                }
                //录井服务
                SupervDB.BLL.LogService blws2 = new SupervDB.BLL.LogService();
                List<SupervDB.Model.LogService> lgws2 = blws2.GetModelList(sqlwhere);
                foreach (SupervDB.Model.LogService item in lgws2)
                {
                    if (item.LogProject == "综合录井")
                    {
                        StartTime1 = DBUtility.DbHelperSQL.GetVtime(item.Star_LogTime);
                        EndTime1 = DBUtility.DbHelperSQL.GetVtime(item.End_LogTime);
                        Days1 = item.LogDay.ToString();
                        Logs1 = item.LogPerNum.ToString();
                    }
                    else if(item.LogProject == "气测录井")
                    {
                        StartTime2 = DBUtility.DbHelperSQL.GetVtime(item.Star_LogTime);
                        EndTime2 = DBUtility.DbHelperSQL.GetVtime(item.End_LogTime);
                        Days2 = item.LogDay.ToString();
                        Logs2 = item.LogPerNum.ToString();
                    }
                    else
                    {
                        StartTime3 = DBUtility.DbHelperSQL.GetVtime(item.Star_LogTime);
                        EndTime3 = DBUtility.DbHelperSQL.GetVtime(item.End_LogTime);
                        Days3 = item.LogDay.ToString();
                        Logs3 = item.LogPerNum.ToString();
                    }
                }
                //特色技术服务
                SupervDB.BLL.EvaluationLog blws5 = new SupervDB.BLL.EvaluationLog();
                List<SupervDB.Model.EvaluationLog> lgws5 = blws5.GetModelList(sqlwhere);
                foreach (SupervDB.Model.EvaluationLog item in lgws5)
                {
                    DataRow dr = dt22.NewRow();
                    //Common
                    dr["ProjectName"] = item.ProjectName;
                    dr["Starttime1"] = DBUtility.DbHelperSQL.GetVtime(item.Star_Time);
                    dr["Endtime1"] = DBUtility.DbHelperSQL.GetVtime(item.End_Time);
                    dr["ServiceDays"] = item.LogDay.ToString();
                    dr["Logs1"] = item.LogPerNum.ToString();
                    dt22.Rows.Add(dr);
                }

                //工程复杂
                SupervDB.BLL.ProjectComplex blws3 = new SupervDB.BLL.ProjectComplex();
                List<SupervDB.Model.ProjectComplex> lgws3 = blws3.GetModelList(sqlwhere);
                if (lgws3.Count > 0)
                {
                    SupervDB.Model.ProjectComplex gsv = lgws3[0];
                    ComplexType = gsv.EComplexType;
                    StartTime= DBUtility.DbHelperSQL.GetVtime(gsv.Star_Time);
                    EndTime = DBUtility.DbHelperSQL.GetVtime(gsv.End_Time);
                    ComplexDays = gsv.LogDay.ToString();
                    ComplexLogs = gsv.LogPerNum.ToString();
                }
                //组织停工天数
                SupervDB.BLL.OrganiZownTime blws4 = new SupervDB.BLL.OrganiZownTime();
                List<SupervDB.Model.OrganiZownTime> lgws4 = blws4.GetModelList(sqlwhere);
                if (lgws4.Count > 0)
                {
                    SupervDB.Model.OrganiZownTime gsv = lgws4[0];
                    OrganizeDowntimeDays = gsv.CumNumDay.ToString();
                }




                //现场问题及整改情况统计表
                //录井队伍资质
                SupervDB.BLL.TeamQual blws1 = new SupervDB.BLL.TeamQual();
                List<SupervDB.Model.TeamQual> lgws1 = blws1.GetModelList(sqlwhere);
                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.TeamQual item in lgws1)
                {
                    //当其余各项均不为空时，有一小项检查结果不合格即说明该大项不合格
                    if (item.CheckResults == "不合格" && item.LogTNum != "" && item.Affiliation != "" && item.QualCNum != "" && item.TypeTeam != "" && item.TeamLevel != "")
                    {
                        ProblemNum += 1;
                       ProblemDescription += item.LogTNum + item.CheckResults + "\n";
                    }
                }
                DataRow dr21 = dt31.NewRow();
                dr21["Number"] = "1";
                dr21["ProblemTypes"] = "录井队伍资质";
                dr21["ProblemNum"] = ProblemNum.ToString();
                dr21["ProblemDescription"] = ProblemDescription;
                dr21["RectificationResults"] = "暂时未知";
                dr21["GeologicalSupervision"] ="暂时未知";
                dt31.Rows.Add(dr21);

                //人员配备及证件
                SupervDB.BLL.StaffDocu blws22 = new SupervDB.BLL.StaffDocu();
                List<SupervDB.Model.StaffDocu> lgws22 = blws22.GetModelList(sqlwhere);
                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.StaffDocu item in lgws22)
                {
                    //当其余各项均不为空时，有一小项检查结果不合格即说明该大项不合格
                    if (item.CheckResults == "不合格" && item.Num != "" && item.Name != "" && item.JobNum != "" && item.JobTitle != "" && item.JobLevel != "" && item.WellConcert != "" && item.HS2Cert != "" && item.HSECert != "" && item.FiveSCert != "")
                    {
                        ProblemNum += 1;
                        ProblemDescription += item.Num + " " + item.Name + item.CheckResults + "\n";
                    }
                }
                DataRow dr22 = dt31.NewRow();
                dr22["Number"] = "2";
                dr22["ProblemTypes"] = "人员配备及证件";
                dr22["ProblemNum"] = ProblemNum.ToString();
                dr22["ProblemDescription"] = ProblemDescription;
                dr22["RectificationResults"] = "暂时未知";
                dr22["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr22);

                //设备配备及安装
                SupervDB.BLL.EquipCAI blws33 = new SupervDB.BLL.EquipCAI();
                List<SupervDB.Model.EquipCAI> lgws33 = blws33.GetModelList(sqlwhere);
                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.EquipCAI item in lgws33)
                {
                    if ((item.CheckResults == "" || item.CheckResults == "不合格") && item.EquipName == "" && item.EquipName == "")
                    {
                        ProblemNum += 1;
                        ProblemDescription += item.EquipName + item.Model + item.CheckResults + "\n";
                    }
                }
                DataRow dr23 = dt31.NewRow();
                dr23["Number"] = "3";
                dr23["ProblemTypes"] = "设备配备及安装";
                dr23["ProblemNum"] = ProblemNum.ToString();
                dr23["ProblemDescription"] = ProblemDescription;
                dr23["RectificationResults"] = "暂时未知";
                dr23["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr23);

                //资料准备
                SupervDB.BLL.PrepareMaterials bllp4 = new SupervDB.BLL.PrepareMaterials();
                List<SupervDB.Model.PrepareMaterials> llps4 = bllp4.GetModelList(sqlwhere);
                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.PrepareMaterials item in llps4)
                {
                    //当其余各项均不为空时，有一小项检查结果不合格即说明该大项不合格
                    if (item.Checked != "" && item.IsAdopt == false)
                    {
                        ProblemNum += 1;
                        ProblemDescription += item.Checked + item.IsAdopt + "\n";
                    }
                }
                DataRow dr24 = dt31.NewRow();
                dr24["Number"] = "4";
                dr24["ProblemTypes"] = "资料准备";
                dr24["ProblemNum"] = ProblemNum.ToString();
                dr24["ProblemDescription"] = ProblemDescription;
                dr24["RectificationResults"] = "暂时未知";
                dr24["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr24);

                SupervDB.BLL.DriTSMana bllp5 = new SupervDB.BLL.DriTSMana();
                List<SupervDB.Model.DriTSMana> llps5 = bllp5.GetModelList(sqlwhere);
                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.DriTSMana item in llps5)
                {
                    //钻具及套管管理
                    if (item.TableName == "钻具及套管管理")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            ProblemNum += 1;
                            ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                }
                DataRow dr25 = dt31.NewRow();
                dr25["Number"] = "5";
                dr25["ProblemTypes"] = "钻具及套管管理";
                dr25["ProblemNum"] = ProblemNum.ToString();
                dr25["ProblemDescription"] = ProblemDescription;
                dr25["RectificationResults"] = "暂时未知";
                dr25["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr25);

                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.DriTSMana item in llps5)
                {
                    //设备安装及运行
                    if (item.TableName == "设备安装及运行")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            ProblemNum += 1;
                            ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                }
                DataRow dr26 = dt31.NewRow();
                dr26["Number"] = "6";
                dr26["ProblemTypes"] = "设备安装及运行";
                dr26["ProblemNum"] = ProblemNum.ToString();
                dr26["ProblemDescription"] = ProblemDescription;
                dr26["RectificationResults"] = "暂时未知";
                dr26["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr26);

                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.DriTSMana item in llps5)
                {
                    //岩性落实
                    if (item.TableName == "岩性落实")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            ProblemNum += 1;
                            ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                }
                DataRow dr27 = dt31.NewRow();
                dr27["Number"] = "7";
                dr27["ProblemTypes"] = "岩性落实";
                dr27["ProblemNum"] = ProblemNum.ToString();
                dr27["ProblemDescription"] = ProblemDescription;
                dr27["RectificationResults"] = "暂时未知";
                dr27["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr27);

                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.DriTSMana item in llps5)
                {
                    //气油层显示落实
                    if (item.TableName == "油气层发现")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            ProblemNum += 1;
                            ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                }
                DataRow dr28 = dt31.NewRow();
                dr28["Number"] = "8";
                dr28["ProblemTypes"] = "气油层显示落实";
                dr28["ProblemNum"] = ProblemNum.ToString();
                dr28["ProblemDescription"] = ProblemDescription;
                dr28["RectificationResults"] = "暂时未知";
                dr28["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr28);

                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.DriTSMana item in llps5)
                {
                    //地质卡层  
                     if (item.TableName == "地质卡层")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            ProblemNum += 1;
                            ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                }
                DataRow dr29 = dt31.NewRow();
                dr29["Number"] = "9";
                dr29["ProblemTypes"] = "地质卡层";
                dr29["ProblemNum"] = ProblemNum.ToString();
                dr29["ProblemDescription"] = ProblemDescription;
                dr29["RectificationResults"] = "暂时未知";
                dr29["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr29);

                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.DriTSMana item in llps5)
                {
                    //工程预警
                     if (item.TableName == "工程预警")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            ProblemNum += 1;
                            ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                }
                DataRow dr210 = dt31.NewRow();
                dr210["Number"] = "10";
                dr210["ProblemTypes"] = "工程预警";
                dr210["ProblemNum"] = ProblemNum.ToString();
                dr210["ProblemDescription"] = ProblemDescription;
                dr210["RectificationResults"] = "暂时未知";
                dr210["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr210);

                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.DriTSMana item in llps5)
                {
                    //资料质量  
                    if (item.TableName == "资料质量")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            ProblemNum += 1;
                            ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                }
                DataRow dr211 = dt31.NewRow();
                dr211["Number"] = "11";
                dr211["ProblemTypes"] = "资料质量";
                dr211["ProblemNum"] = ProblemNum.ToString();
                dr211["ProblemDescription"] = ProblemDescription;
                dr211["RectificationResults"] = "暂时未知";
                dr211["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr211);

                SupervDB.BLL.LogWells_SitDuty bllp16 = new SupervDB.BLL.LogWells_SitDuty();
                List<SupervDB.Model.LogWells_SitDuty> llps16 = bllp16.GetModelList(sqlwhere);
                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.LogWells_SitDuty item in llps16)
                {
                    if (item.TableName == "录井坐岗")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            ProblemNum += 1;
                            ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                    
                }
                DataRow dr212 = dt31.NewRow();
                dr212["Number"] = "12";
                dr212["ProblemTypes"] = "录井坐岗";
                dr212["ProblemNum"] = ProblemNum.ToString();
                dr212["ProblemDescription"] = ProblemDescription;
                dr212["RectificationResults"] = "暂时未知";
                dr212["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr212);

                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.LogWells_SitDuty item in llps16)
                {
                    //硫化氢传感器安装与检测
                    if (item.TableName == "硫化氢传感器安装及检测")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            ProblemNum += 1;
                            ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                        }
                    }

                }
                DataRow dr213 = dt31.NewRow();
                dr213["Number"] = "13";
                dr213["ProblemTypes"] = "硫化氢传感器安装及检测";
                dr213["ProblemNum"] = ProblemNum.ToString();
                dr213["ProblemDescription"] = ProblemDescription;
                dr213["RectificationResults"] = "暂时未知";
                dr213["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr213);

                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.LogWells_SitDuty item in llps16)
                {
                    //安全防护设施配备及管理
                    if (item.TableName == "硫化氢传感器检测")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            //安全防护设施配备及管理
                            if (item.CheckProject == "正压式呼吸器" || item.CheckProject == "灭火器" || item.CheckProject == "有毒有害气体检测仪" || item.CheckProject == "防毒面具" || item.CheckProject == "报警器" || item.CheckProject == "劳保穿戴")
                            {
                                ProblemNum += 1;
                                ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                            }
                        }
                    }

                }
                DataRow dr214 = dt31.NewRow();
                dr214["Number"] = "14";
                dr214["ProblemTypes"] = "安全防护设施配备及管理";
                dr214["ProblemNum"] = ProblemNum.ToString();
                dr214["ProblemDescription"] = ProblemDescription;
                dr214["RectificationResults"] = "暂时未知";
                dr214["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr214);

                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.LogWells_SitDuty item in llps16)
                {
                    //安全防护设施配备及管理
                    if (item.TableName == "硫化氢传感器检测")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            //化学药品配备及管理
                            if (item.CheckProject == "化学药品使用" || item.CheckProject == "化学药品存放" || item.CheckProject == "化学药品管理")
                            {
                                ProblemNum += 1;
                                ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                            }
                        }
                    }

                }
                DataRow dr215 = dt31.NewRow();
                dr215["Number"] = "15";
                dr215["ProblemTypes"] = "安全防护设施配备及管理";
                dr215["ProblemNum"] = ProblemNum.ToString();
                dr215["ProblemDescription"] = ProblemDescription;
                dr215["RectificationResults"] = "暂时未知";
                dr215["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr215);

                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.LogWells_SitDuty item in llps16)
                {
                    //安全防护设施配备及管理
                    if (item.TableName == "硫化氢传感器检测")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            //应急预案及演练
                            if (item.CheckProject == "应急预案" || item.CheckProject == "应急演练")
                            {
                                ProblemNum += 1;
                                ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                            }
                        }
                    }

                }
                DataRow dr216 = dt31.NewRow();
                dr216["Number"] = "16";
                dr216["ProblemTypes"] = "应急预案及演练";
                dr216["ProblemNum"] = ProblemNum.ToString();
                dr216["ProblemDescription"] = ProblemDescription;
                dr216["RectificationResults"] = "暂时未知";
                dr216["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr216);

                ProblemNum = 0;
                ProblemDescription = "";
                foreach (SupervDB.Model.LogWells_SitDuty item in llps16)
                {
                     //录井环境
                    if (item.TableName == "录井环境")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            ProblemNum += 1;
                            ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                        }
                    }

                }
                DataRow dr217 = dt31.NewRow();
                dr217["Number"] = "17";
                dr217["ProblemTypes"] = "录井环境";
                dr217["ProblemNum"] = ProblemNum.ToString();
                dr217["ProblemDescription"] = ProblemDescription;
                dr217["RectificationResults"] = "暂时未知";
                dr217["GeologicalSupervision"] = "暂时未知";
                dt31.Rows.Add(dr217);



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // 动态添加前台传来的数据
            dt.Rows.Add(new object[] { WellNum, WellSort, WellType, Deep1, Deep2, Location, LoggingTeam, TeamType, TeamLevel, SupervisionUnit, GeologicalSupervision });
            //dt2.Rows.Add(new object[] { LoggingProjects, StartDeep, EndDeep, Interval, Number});

            dt21.Rows.Add(new object[] { WellNum_2, WellSort_2, WellType_2, Deep1_2, Deep2_2, Location_2, LoggingTeam_2, TeamType_2, TeamLevel_2, SupervisionUnit_2, GeologicalSupervision_2, StartTime1, StartTime2, StartTime3, EndTime1, EndTime2, EndTime3, Days1, Days2, Days3, Logs1, Logs2, Logs3, ComplexType, StartTime , EndTime, ComplexDays, ComplexLogs, OrganizeDowntimeDays, PresentationOfCondition });
            //dt22.Rows.Add(new object[] { Starttime1, Endtime1, ServiceDays, Logs1_2, ProjectName });

            //dt31.Rows.Add(new object[] { Number_3, ProblemTypes, ProblemNum.ToString(), ProblemDescription, RectificationResults, GeologicalSupervision_3 });
            // 另外需要将ReportMain.rdlc文件复制到当前可执行程序目录下
            //this.reportViewer1.LocalReport.ReportPath = "监督报告附表（二）录井工作量统计表（进尺）.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();

            //this.reportViewer2.LocalReport.ReportPath = "监督报告附表（二）录井工作量统计表（时间）.rdlc";
            this.reportViewer2.LocalReport.DataSources.Clear();

            //this.reportViewer3.LocalReport.ReportPath = "监督报告附表（三）现场问题及整改情况统计表.rdlc";
            this.reportViewer3.LocalReport.DataSources.Clear();
            // 名称需要用我们之前设定的 "DataSetReport"
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dt2));

            this.reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt21));
            this.reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dt22));

            this.reportViewer3.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt31));
            

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mubanFile = @"Templates\监督报告附表（二）录井工作量统计表（进尺）.docx";
                string templatePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, mubanFile);
                Dictionary<string, string> bookmarks = new Dictionary<string, string>();
                bookmarks.Add("WellNum", WellNum);
                bookmarks.Add("WellSort", WellSort);
                bookmarks.Add("WellType", WellType);
                bookmarks.Add("Deep1", Deep1);
                bookmarks.Add("Deep2", Deep2);
                bookmarks.Add("Location", Location);
                bookmarks.Add("LoggingTeam", LoggingTeam);
                bookmarks.Add("TeamType", TeamType);
                bookmarks.Add("TeamLevel", TeamLevel);
                bookmarks.Add("SupervisionUnit", SupervisionUnit);
                bookmarks.Add("GeologicalSupervision", GeologicalSupervision);
                //下方多行表格暂时未写

                string wordpath = Application.StartupPath + "\\Data\\" + twellnum + "\\";//导出word的文件路径
                if (!System.IO.Directory.Exists(wordpath))
                {
                    System.IO.Directory.CreateDirectory(wordpath);
                }
                //GenerateWord(templatePath, wordpath, pdfpath, bookmarks);
                string path = wordpath + "监督报告附表（二）录井工作量统计表（进尺）.docx";//导出word的地址
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                Export(templatePath, path, bookmarks);
                MessageBox.Show(path, "导出成功");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
                return;
            }
        }

        public void Export(string wordTemplatePath, string newFileName, Dictionary<string, string> wordLableList)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            string TemplateFile = wordTemplatePath;
            System.IO.File.Copy(TemplateFile, newFileName);
            Word.Document doc = new Word.Document();
            object obj_NewFileName = newFileName;
            object obj_Visible = false;
            object obj_ReadOnly = false;
            object obj_missing = System.Reflection.Missing.Value;

            doc = app.Documents.Open(ref obj_NewFileName, ref obj_missing, ref obj_ReadOnly, ref obj_missing,
                                    ref obj_missing, ref obj_missing, ref obj_missing, ref obj_missing,
                                    ref obj_missing, ref obj_missing, ref obj_missing, ref obj_Visible,
                                    ref obj_missing, ref obj_missing, ref obj_missing,
                                    ref obj_missing);


            doc.Activate();
            if (wordLableList.Count > 0)
            {
                object what = Word.WdGoToItem.wdGoToBookmark;
                foreach (var item in wordLableList)
                {
                    object lableName = item.Key;
                    if (doc.Bookmarks.Exists(item.Key))
                    {
                        doc.ActiveWindow.Selection.GoTo(ref what, ref obj_missing, ref obj_missing, ref lableName);//光标移动书签的位置
                        doc.ActiveWindow.Selection.TypeText(item.Value);//在书签处插入的内容 
                        doc.ActiveWindow.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;//设置插入内容的Alignment
                    }
                }
            }

            Microsoft.Office.Interop.Word.Table table1 = doc.Tables[1];
            string sqlwhere = " Wellnum = '" + twellnum + "'";
            SupervDB.BLL.LogWorkloadSta_Footage bllp = new SupervDB.BLL.LogWorkloadSta_Footage();
            List<SupervDB.Model.LogWorkloadSta_Footage> llps = bllp.GetModelList(sqlwhere);
            int i = 8;
            foreach (SupervDB.Model.LogWorkloadSta_Footage item in llps)
            {
                System.Object beforRow = System.Type.Missing;
                table1.Rows.Add(ref beforRow);//在表格末尾处插入行
                table1.Cell(i, 1).Range.Text = item.LogProject;
                table1.Cell(i, 2).Range.Text = item.Start_Well_Depth.ToString();
                table1.Cell(i, 3).Range.Text = item.End_Well_Depth.ToString();
                table1.Cell(i, 4).Range.Text = item.SampleInterval.ToString();
                table1.Cell(i, 5).Range.Text = item.Number.ToString();
                i++;
                //System.Object beforRow = System.Type.Missing;
                //table1.Rows.Add(ref beforRow);//在表格末尾处插入行
                //table1.Cell(2, 1).Select();//光标选定第二行的第一个单元格
                //app.Selection.InsertRowsBelow(1);  //在下方插入一行
            }

            object obj_IsSave = true;
            doc.Close(ref obj_IsSave, ref obj_missing, ref obj_missing);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string mubanFile = @"Templates\监督报告附表（二）录井工作量统计表（时间）.docx";
                string templatePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, mubanFile);
                Dictionary<string, string> bookmarks = new Dictionary<string, string>();
                bookmarks.Add("WellNum", WellNum_2);
                bookmarks.Add("WellSort", WellSort_2);
                bookmarks.Add("WellType", WellType_2);
                bookmarks.Add("Deep1", Deep1_2);
                bookmarks.Add("Deep2", Deep2_2);
                bookmarks.Add("Location", Location_2);
                bookmarks.Add("LoggingTeam", LoggingTeam_2);
                bookmarks.Add("TeamType", TeamType_2);
                bookmarks.Add("TeamLevel", TeamLevel_2);
                bookmarks.Add("SupervisionUnit", SupervisionUnit_2);
                bookmarks.Add("GeologicalSupervision", GeologicalSupervision_2);
                bookmarks.Add("StartTime1", StartTime1);
                bookmarks.Add("StartTime2", StartTime2);
                bookmarks.Add("StartTime3", StartTime3);
                bookmarks.Add("EndTime1", EndTime1);
                bookmarks.Add("EndTime2", EndTime2);
                bookmarks.Add("EndTime3", EndTime3);
                bookmarks.Add("Days1", Days1);
                bookmarks.Add("Days2", Days2);
                bookmarks.Add("Days3", Days3);
                bookmarks.Add("Logs1", Logs1);
                bookmarks.Add("Logs2", Logs2);
                bookmarks.Add("Logs3", Logs3);
                bookmarks.Add("ComplexType", ComplexType);
                bookmarks.Add("StartTime", StartTime);
                bookmarks.Add("EndTime", EndTime);
                bookmarks.Add("ComplexDays", ComplexDays);
                bookmarks.Add("ComplexLogs", ComplexLogs);
                bookmarks.Add("OrganizeDowntimeDays", OrganizeDowntimeDays);
                bookmarks.Add("PresentationOfCondition", PresentationOfCondition);
                //下方多行表格暂时未写

                string wordpath = Application.StartupPath + "\\Data\\" + twellnum + "\\";//导出word的文件路径
                if (!System.IO.Directory.Exists(wordpath))
                {
                    System.IO.Directory.CreateDirectory(wordpath);
                }
                //GenerateWord(templatePath, wordpath, pdfpath, bookmarks);
                string path = wordpath + "监督报告附表（二）录井工作量统计表（时间）.docx";//导出word的地址
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                Export_2(templatePath, path, bookmarks);
                MessageBox.Show(path, "导出成功");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
                return;
            }
        }

        public void Export_2(string wordTemplatePath, string newFileName, Dictionary<string, string> wordLableList)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            string TemplateFile = wordTemplatePath;
            System.IO.File.Copy(TemplateFile, newFileName);
            Word.Document doc = new Word.Document();
            object obj_NewFileName = newFileName;
            object obj_Visible = false;
            object obj_ReadOnly = false;
            object obj_missing = System.Reflection.Missing.Value;

            doc = app.Documents.Open(ref obj_NewFileName, ref obj_missing, ref obj_ReadOnly, ref obj_missing,
                                    ref obj_missing, ref obj_missing, ref obj_missing, ref obj_missing,
                                    ref obj_missing, ref obj_missing, ref obj_missing, ref obj_Visible,
                                    ref obj_missing, ref obj_missing, ref obj_missing,
                                    ref obj_missing);


            doc.Activate();
            if (wordLableList.Count > 0)
            {
                object what = Word.WdGoToItem.wdGoToBookmark;
                foreach (var item in wordLableList)
                {
                    object lableName = item.Key;
                    if (doc.Bookmarks.Exists(item.Key))
                    {
                        doc.ActiveWindow.Selection.GoTo(ref what, ref obj_missing, ref obj_missing, ref lableName);//光标移动书签的位置
                        doc.ActiveWindow.Selection.TypeText(item.Value);//在书签处插入的内容 
                        doc.ActiveWindow.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;//设置插入内容的Alignment
                    }
                }
            }

            //特色技术服务
            Microsoft.Office.Interop.Word.Table table1 = doc.Tables[1];
            string sqlwhere = " Wellnum = '" + twellnum + "'";
            SupervDB.BLL.EvaluationLog blws5 = new SupervDB.BLL.EvaluationLog();
            List<SupervDB.Model.EvaluationLog> lgws5 = blws5.GetModelList(sqlwhere);
            int i = 10;
            foreach (SupervDB.Model.EvaluationLog item in lgws5)
            {
                table1.Cell(i, 2).Select();//光标选定第二行的第一个单元格
                app.Selection.InsertRowsBelow(1);  //在下方插入一行
                i++;
                table1.Cell(i, 2).Range.Text = item.ProjectName;
                table1.Cell(i, 3).Range.Text = DBUtility.DbHelperSQL.GetVtime(item.Star_Time);
                table1.Cell(i, 4).Range.Text = DBUtility.DbHelperSQL.GetVtime(item.End_Time);
                table1.Cell(i, 5).Range.Text = item.LogDay.ToString();
                table1.Cell(i, 6).Range.Text = item.LogPerNum.ToString();

            }

            object obj_IsSave = true;
            doc.Close(ref obj_IsSave, ref obj_missing, ref obj_missing);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string mubanFile = @"Templates\监督报告附表（三）现场问题及整改情况统计表.docx";
                string templatePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, mubanFile);//模板地址
                string wordpath = Application.StartupPath + "\\Data\\" + twellnum + "\\";//导出word的文件路径
                if (!System.IO.Directory.Exists(wordpath))
                {
                    System.IO.Directory.CreateDirectory(wordpath);
                }
                //GenerateWord(templatePath, wordpath, pdfpath, bookmarks);
                string path = wordpath + "监督报告附表（三）现场问题及整改情况统计表.docx";//导出word的地址
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                Export_3(templatePath, path);
                MessageBox.Show(path, "导出成功");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
                return;
            }
        }
        public void Export_3(string wordTemplatePath, string newFileName)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            string TemplateFile = wordTemplatePath;
            System.IO.File.Copy(TemplateFile, newFileName);
            Word.Document doc = new Word.Document();
            object obj_NewFileName = newFileName;
            object obj_Visible = false;
            object obj_ReadOnly = false;
            object obj_missing = System.Reflection.Missing.Value;

            doc = app.Documents.Open(ref obj_NewFileName, ref obj_missing, ref obj_ReadOnly, ref obj_missing,
                                    ref obj_missing, ref obj_missing, ref obj_missing, ref obj_missing,
                                    ref obj_missing, ref obj_missing, ref obj_missing, ref obj_Visible,
                                    ref obj_missing, ref obj_missing, ref obj_missing,
                                    ref obj_missing);

            doc.Activate();
            //if (wordLableList.Count > 0)
            //{
            //    object what = Word.WdGoToItem.wdGoToBookmark;
            //    foreach (var item in wordLableList)
            //    {
            //        object lableName = item.Key;
            //        if (doc.Bookmarks.Exists(item.Key))
            //        {
            //            doc.ActiveWindow.Selection.GoTo(ref what, ref obj_missing, ref obj_missing, ref lableName);//光标移动书签的位置
            //            doc.ActiveWindow.Selection.TypeText(item.Value);//在书签处插入的内容 
            //            doc.ActiveWindow.Selection.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;//设置插入内容的Alignment
            //        }
            //    }
            //}


            Microsoft.Office.Interop.Word.Table table1 = doc.Tables[1];
            string sqlwhere = " Wellnum = '" + twellnum + "'";

            SupervDB.BLL.TeamQual blws1 = new SupervDB.BLL.TeamQual();
            List<SupervDB.Model.TeamQual> lgws1 = blws1.GetModelList(sqlwhere);
            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.TeamQual item in lgws1)
            {
                //当其余各项均不为空时，有一小项检查结果不合格即说明该大项不合格
                if (item.CheckResults == "不合格" && item.LogTNum != "" && item.Affiliation != "" && item.QualCNum != "" && item.TypeTeam != "" && item.TeamLevel != "")
                {
                    ProblemNum += 1;
                    ProblemDescription += item.LogTNum + item.CheckResults + "\n";
                }
            }
            table1.Cell(2, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(2, 4).Range.Text = ProblemDescription;
            table1.Cell(2, 5).Range.Text = RectificationResults;
            table1.Cell(2, 6).Range.Text = GeologicalSupervision_3;

            //人员配备及证件
            SupervDB.BLL.StaffDocu blws22 = new SupervDB.BLL.StaffDocu();
            List<SupervDB.Model.StaffDocu> lgws22 = blws22.GetModelList(sqlwhere);
            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.StaffDocu item in lgws22)
            {
                //当其余各项均不为空时，有一小项检查结果不合格即说明该大项不合格
                if (item.CheckResults == "不合格" && item.Num != "" && item.Name != "" && item.JobNum != "" && item.JobTitle != "" && item.JobLevel != "" && item.WellConcert != "" && item.HS2Cert != "" && item.HSECert != "" && item.FiveSCert != "")
                {
                    ProblemNum += 1;
                    ProblemDescription += item.Num + " " + item.Name + item.CheckResults + "\n";
                }
            }
            table1.Cell(3, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(3, 4).Range.Text = ProblemDescription;
            table1.Cell(3, 5).Range.Text = RectificationResults;
            table1.Cell(3, 6).Range.Text = GeologicalSupervision_3;

            //设备配备及安装
            SupervDB.BLL.EquipCAI blws33 = new SupervDB.BLL.EquipCAI();
            List<SupervDB.Model.EquipCAI> lgws33 = blws33.GetModelList(sqlwhere);
            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.EquipCAI item in lgws33)
            {
                if ((item.CheckResults == "" || item.CheckResults == "不合格") && item.EquipName == "" && item.EquipName == "")
                {
                    ProblemNum += 1;
                    ProblemDescription += item.EquipName + item.Model + item.CheckResults + "\n";
                }
            }
            table1.Cell(4, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(4, 4).Range.Text = ProblemDescription;
            table1.Cell(4, 5).Range.Text = RectificationResults;
            table1.Cell(4, 6).Range.Text = GeologicalSupervision_3;

            //资料准备
            SupervDB.BLL.PrepareMaterials bllp4 = new SupervDB.BLL.PrepareMaterials();
            List<SupervDB.Model.PrepareMaterials> llps4 = bllp4.GetModelList(sqlwhere);
            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.PrepareMaterials item in llps4)
            {
                //当其余各项均不为空时，有一小项检查结果不合格即说明该大项不合格
                if (item.Checked != "" && item.IsAdopt == false)
                {
                    ProblemNum += 1;
                    ProblemDescription += item.Checked + item.IsAdopt + "\n";
                }
            }
            table1.Cell(5, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(5, 4).Range.Text = ProblemDescription;
            table1.Cell(5, 5).Range.Text = RectificationResults;
            table1.Cell(5, 6).Range.Text = GeologicalSupervision_3;

            SupervDB.BLL.DriTSMana bllp5 = new SupervDB.BLL.DriTSMana();
            List<SupervDB.Model.DriTSMana> llps5 = bllp5.GetModelList(sqlwhere);
            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.DriTSMana item in llps5)
            {
                //钻具及套管管理
                if (item.TableName == "钻具及套管管理")
                {
                    if (item.CheckResults == "不合格")
                    {
                        ProblemNum += 1;
                        ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                    }
                }
            }
            table1.Cell(6, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(6, 4).Range.Text = ProblemDescription;
            table1.Cell(6, 5).Range.Text = RectificationResults;
            table1.Cell(6, 6).Range.Text = GeologicalSupervision_3;

            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.DriTSMana item in llps5)
            {
                //设备安装及运行
                if (item.TableName == "设备安装及运行")
                {
                    if (item.CheckResults == "不合格")
                    {
                        ProblemNum += 1;
                        ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                    }
                }
            }
            table1.Cell(7, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(7, 4).Range.Text = ProblemDescription;
            table1.Cell(7, 5).Range.Text = RectificationResults;
            table1.Cell(7, 6).Range.Text = GeologicalSupervision_3;

            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.DriTSMana item in llps5)
            {
                //岩性落实
                if (item.TableName == "岩性落实")
                {
                    if (item.CheckResults == "不合格")
                    {
                        ProblemNum += 1;
                        ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                    }
                }
            }
            table1.Cell(8, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(8, 4).Range.Text = ProblemDescription;
            table1.Cell(8, 5).Range.Text = RectificationResults;
            table1.Cell(8, 6).Range.Text = GeologicalSupervision_3;

            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.DriTSMana item in llps5)
            {
                //气油层显示落实
                if (item.TableName == "油气层发现")
                {
                    if (item.CheckResults == "不合格")
                    {
                        ProblemNum += 1;
                        ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                    }
                }
            }
            table1.Cell(9, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(9, 4).Range.Text = ProblemDescription;
            table1.Cell(9, 5).Range.Text = RectificationResults;
            table1.Cell(9, 6).Range.Text = GeologicalSupervision_3;

            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.DriTSMana item in llps5)
            {
                //地质卡层  
                if (item.TableName == "地质卡层")
                {
                    if (item.CheckResults == "不合格")
                    {
                        ProblemNum += 1;
                        ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                    }
                }
            }
            table1.Cell(10, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(10, 4).Range.Text = ProblemDescription;
            table1.Cell(10, 5).Range.Text = RectificationResults;
            table1.Cell(10, 6).Range.Text = GeologicalSupervision_3;

            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.DriTSMana item in llps5)
            {
                //工程预警
                if (item.TableName == "工程预警")
                {
                    if (item.CheckResults == "不合格")
                    {
                        ProblemNum += 1;
                        ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                    }
                }
            }
            table1.Cell(11, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(11, 4).Range.Text = ProblemDescription;
            table1.Cell(11, 5).Range.Text = RectificationResults;
            table1.Cell(11, 6).Range.Text = GeologicalSupervision_3;

            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.DriTSMana item in llps5)
            {
                //资料质量  
                if (item.TableName == "资料质量")
                {
                    if (item.CheckResults == "不合格")
                    {
                        ProblemNum += 1;
                        ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                    }
                }
            }
            table1.Cell(12, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(12, 4).Range.Text = ProblemDescription;
            table1.Cell(12, 5).Range.Text = RectificationResults;
            table1.Cell(12, 6).Range.Text = GeologicalSupervision_3;

            SupervDB.BLL.LogWells_SitDuty bllp16 = new SupervDB.BLL.LogWells_SitDuty();
            List<SupervDB.Model.LogWells_SitDuty> llps16 = bllp16.GetModelList(sqlwhere);
            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.LogWells_SitDuty item in llps16)
            {
                if (item.TableName == "录井坐岗")
                {
                    if (item.CheckResults == "" || item.CheckResults == "不合格")
                    {
                        ProblemNum += 1;
                        ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                    }
                }

            }
            table1.Cell(13, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(13, 4).Range.Text = ProblemDescription;
            table1.Cell(13, 5).Range.Text = RectificationResults;
            table1.Cell(13, 6).Range.Text = GeologicalSupervision_3;

            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.LogWells_SitDuty item in llps16)
            {
                //硫化氢传感器安装与检测
                if (item.TableName == "硫化氢传感器安装及检测")
                {
                    if (item.CheckResults == "" || item.CheckResults == "不合格")
                    {
                        ProblemNum += 1;
                        ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                    }
                }

            }
            table1.Cell(14, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(14, 4).Range.Text = ProblemDescription;
            table1.Cell(14, 5).Range.Text = RectificationResults;
            table1.Cell(14, 6).Range.Text = GeologicalSupervision_3;

            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.LogWells_SitDuty item in llps16)
            {
                //安全防护设施配备及管理
                if (item.TableName == "硫化氢传感器检测")
                {
                    if (item.CheckResults == "" || item.CheckResults == "不合格")
                    {
                        //安全防护设施配备及管理
                        if (item.CheckProject == "正压式呼吸器" || item.CheckProject == "灭火器" || item.CheckProject == "有毒有害气体检测仪" || item.CheckProject == "防毒面具" || item.CheckProject == "报警器" || item.CheckProject == "劳保穿戴")
                        {
                            ProblemNum += 1;
                            ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                }

            }
            table1.Cell(15, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(15, 4).Range.Text = ProblemDescription;
            table1.Cell(15, 5).Range.Text = RectificationResults;
            table1.Cell(15, 6).Range.Text = GeologicalSupervision_3;

            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.LogWells_SitDuty item in llps16)
            {
                //安全防护设施配备及管理
                if (item.TableName == "硫化氢传感器检测")
                {
                    if (item.CheckResults == "" || item.CheckResults == "不合格")
                    {
                        //化学药品配备及管理
                        if (item.CheckProject == "化学药品使用" || item.CheckProject == "化学药品存放" || item.CheckProject == "化学药品管理")
                        {
                            ProblemNum += 1;
                            ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                }

            }
            table1.Cell(16, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(16, 4).Range.Text = ProblemDescription;
            table1.Cell(16, 5).Range.Text = RectificationResults;
            table1.Cell(16, 6).Range.Text = GeologicalSupervision_3;

            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.LogWells_SitDuty item in llps16)
            {
                //安全防护设施配备及管理
                if (item.TableName == "硫化氢传感器检测")
                {
                    if (item.CheckResults == "" || item.CheckResults == "不合格")
                    {
                        //应急预案及演练
                        if (item.CheckProject == "应急预案" || item.CheckProject == "应急演练")
                        {
                            ProblemNum += 1;
                            ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                }

            }
            table1.Cell(17, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(17, 4).Range.Text = ProblemDescription;
            table1.Cell(17, 5).Range.Text = RectificationResults;
            table1.Cell(17, 6).Range.Text = GeologicalSupervision_3;

            ProblemNum = 0;
            ProblemDescription = "";
            foreach (SupervDB.Model.LogWells_SitDuty item in llps16)
            {
                //录井环境
                if (item.TableName == "录井环境")
                {
                    if (item.CheckResults == "" || item.CheckResults == "不合格")
                    {
                        ProblemNum += 1;
                        ProblemDescription += item.CheckProject + item.CheckResults + "\n";
                    }
                }

            }
            table1.Cell(18, 3).Range.Text = ProblemNum.ToString();
            table1.Cell(18, 4).Range.Text = ProblemDescription;
            table1.Cell(18, 5).Range.Text = RectificationResults;
            table1.Cell(18, 6).Range.Text = GeologicalSupervision_3;

            object obj_IsSave = true;
            doc.Close(ref obj_IsSave, ref obj_missing, ref obj_missing);
        }

        public void Save_Word_1()
        {
            if (twellnum == null || twellnum == "")
            {
                return;
            }

            string sqlwhere = " Wellnum = '" + twellnum + "'";
            try
            {
                //reportview1---录井工作量统计表（进尺）
                //前两行
                SupervDB.BLL.GeoSuperv blgs = new SupervDB.BLL.GeoSuperv();
                List<SupervDB.Model.GeoSuperv> lgsv = blgs.GetModelList(sqlwhere);
                if (lgsv.Count > 0)
                {
                    SupervDB.Model.GeoSuperv gsv = lgsv[0];
                    WellNum = gsv.Wellnum;
                    WellSort = gsv.Well_BB;
                    WellType = gsv.Well_type;
                    Deep1 = gsv.Well_depth.ToString();
                    Deep2 = gsv.Wzdepth.ToString();
                    Location = gsv.LJEndDate;
                    //地质监督
                    GeologicalSupervision = gsv.JdName;

                }
                //第三行
                SupervDB.BLL.TeamQual blws = new SupervDB.BLL.TeamQual();
                List<SupervDB.Model.TeamQual> lgws = blws.GetModelList(sqlwhere);
                if (lgws.Count > 0)
                {
                    SupervDB.Model.TeamQual gsv = lgws[0];
                    LoggingTeam = gsv.LogTNum;
                    TeamType = gsv.TypeTeam;
                    TeamLevel = gsv.TeamLevel;

                }
                //第四行
                //监督单位暂时没有，暂时空置

                //组织停工天数
                SupervDB.BLL.OrganiZownTime blws4 = new SupervDB.BLL.OrganiZownTime();
                List<SupervDB.Model.OrganiZownTime> lgws4 = blws4.GetModelList(sqlwhere);
                if (lgws4.Count > 0)
                {
                    SupervDB.Model.OrganiZownTime gsv = lgws4[0];
                    OrganizeDowntimeDays = gsv.CumNumDay.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string mubanFile = @"Templates\监督报告附表（二）录井工作量统计表（进尺）.docx";
                string templatePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, mubanFile);
                Dictionary<string, string> bookmarks = new Dictionary<string, string>();
                bookmarks.Add("WellNum", WellNum);
                bookmarks.Add("WellSort", WellSort);
                bookmarks.Add("WellType", WellType);
                bookmarks.Add("Deep1", Deep1);
                bookmarks.Add("Deep2", Deep2);
                bookmarks.Add("Location", Location);
                bookmarks.Add("LoggingTeam", LoggingTeam);
                bookmarks.Add("TeamType", TeamType);
                bookmarks.Add("TeamLevel", TeamLevel);
                bookmarks.Add("SupervisionUnit", SupervisionUnit);
                bookmarks.Add("GeologicalSupervision", GeologicalSupervision);
                //下方多行表格暂时未写

                string wordpath = Application.StartupPath + "\\Data\\" + twellnum + "\\";//导出word的文件路径
                if (!System.IO.Directory.Exists(wordpath))
                {
                    System.IO.Directory.CreateDirectory(wordpath);
                }
                //GenerateWord(templatePath, wordpath, pdfpath, bookmarks);
                string path = wordpath + "监督报告附表（二）录井工作量统计表（进尺）.docx";//导出word的地址
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                Export(templatePath, path, bookmarks);
                MessageBox.Show(path, "导出成功");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
                return;
            }
        }

        public void Save_Word_2()
        {
            if (twellnum == null || twellnum == "")
            {
                return;
            }
            string sqlwhere = " Wellnum = '" + twellnum + "'";
            try
            {
                //reportview1---录井工作量统计表（进尺）
                //前两行
                SupervDB.BLL.GeoSuperv blgs = new SupervDB.BLL.GeoSuperv();
                List<SupervDB.Model.GeoSuperv> lgsv = blgs.GetModelList(sqlwhere);
                if (lgsv.Count > 0)
                {
                    SupervDB.Model.GeoSuperv gsv = lgsv[0];
                    WellNum_2 = gsv.Wellnum; ;//用的列名相同，用的字段不可相同
                    WellSort_2 = gsv.Well_BB;//用的列名相同，用的字段不可相同
                    WellType_2 = gsv.Well_type;//用的列名相同，用的字段不可相同
                    Deep1_2 = gsv.Well_depth.ToString();//用的列名相同，用的字段不可相同
                    Deep2_2 = gsv.Wzdepth.ToString();//用的列名相同，用的字段不可相同
                    Location_2 = gsv.LJEndDate; ;//用的列名相同，用的字段不可相同
                    //地质监督
                    GeologicalSupervision_2 = gsv.JdName;//用的列名相同，用的字段不可相同
                }
                //第三行
                SupervDB.BLL.TeamQual blws = new SupervDB.BLL.TeamQual();
                List<SupervDB.Model.TeamQual> lgws = blws.GetModelList(sqlwhere);
                if (lgws.Count > 0)
                {
                    SupervDB.Model.TeamQual gsv = lgws[0];
                    LoggingTeam_2 = gsv.LogTNum;//用的列名相同，用的字段不可相同
                    TeamType_2 = gsv.TypeTeam;//用的列名相同，用的字段不可相同
                    TeamLevel_2 = gsv.TeamLevel;//用的列名相同，用的字段不可相同
                }
                //第四行
                //监督单位暂时没有，暂时空置


                //录井服务
                SupervDB.BLL.LogService blws2 = new SupervDB.BLL.LogService();
                List<SupervDB.Model.LogService> lgws2 = blws2.GetModelList(sqlwhere);
                foreach (SupervDB.Model.LogService item in lgws2)
                {
                    if (item.LogProject == "综合录井")
                    {
                        StartTime1 = DBUtility.DbHelperSQL.GetVtime(item.Star_LogTime);
                        EndTime1 = DBUtility.DbHelperSQL.GetVtime(item.End_LogTime);
                        Days1 = item.LogDay.ToString();
                        Logs1 = item.LogPerNum.ToString();
                    }
                    else if (item.LogProject == "气测录井")
                    {
                        StartTime2 = DBUtility.DbHelperSQL.GetVtime(item.Star_LogTime);
                        EndTime2 = DBUtility.DbHelperSQL.GetVtime(item.End_LogTime);
                        Days2 = item.LogDay.ToString();
                        Logs2 = item.LogPerNum.ToString();
                    }
                    else
                    {
                        StartTime3 = DBUtility.DbHelperSQL.GetVtime(item.Star_LogTime);
                        EndTime3 = DBUtility.DbHelperSQL.GetVtime(item.End_LogTime);
                        Days3 = item.LogDay.ToString();
                        Logs3 = item.LogPerNum.ToString();
                    }
                }


                //工程复杂
                SupervDB.BLL.ProjectComplex blws3 = new SupervDB.BLL.ProjectComplex();
                List<SupervDB.Model.ProjectComplex> lgws3 = blws3.GetModelList(sqlwhere);
                if (lgws3.Count > 0)
                {
                    SupervDB.Model.ProjectComplex gsv = lgws3[0];
                    ComplexType = gsv.EComplexType;
                    StartTime = DBUtility.DbHelperSQL.GetVtime(gsv.Star_Time);
                    EndTime = DBUtility.DbHelperSQL.GetVtime(gsv.End_Time);
                    ComplexDays = gsv.LogDay.ToString();
                    ComplexLogs = gsv.LogPerNum.ToString();
                }
                //组织停工天数
                SupervDB.BLL.OrganiZownTime blws4 = new SupervDB.BLL.OrganiZownTime();
                List<SupervDB.Model.OrganiZownTime> lgws4 = blws4.GetModelList(sqlwhere);
                if (lgws4.Count > 0)
                {
                    SupervDB.Model.OrganiZownTime gsv = lgws4[0];
                    OrganizeDowntimeDays = gsv.CumNumDay.ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string mubanFile = @"Templates\监督报告附表（二）录井工作量统计表（时间）.docx";
                string templatePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, mubanFile);
                Dictionary<string, string> bookmarks = new Dictionary<string, string>();
                bookmarks.Add("WellNum", WellNum_2);
                bookmarks.Add("WellSort", WellSort_2);
                bookmarks.Add("WellType", WellType_2);
                bookmarks.Add("Deep1", Deep1_2);
                bookmarks.Add("Deep2", Deep2_2);
                bookmarks.Add("Location", Location_2);
                bookmarks.Add("LoggingTeam", LoggingTeam_2);
                bookmarks.Add("TeamType", TeamType_2);
                bookmarks.Add("TeamLevel", TeamLevel_2);
                bookmarks.Add("SupervisionUnit", SupervisionUnit_2);
                bookmarks.Add("GeologicalSupervision", GeologicalSupervision_2);
                bookmarks.Add("StartTime1", StartTime1);
                bookmarks.Add("StartTime2", StartTime2);
                bookmarks.Add("StartTime3", StartTime3);
                bookmarks.Add("EndTime1", EndTime1);
                bookmarks.Add("EndTime2", EndTime2);
                bookmarks.Add("EndTime3", EndTime3);
                bookmarks.Add("Days1", Days1);
                bookmarks.Add("Days2", Days2);
                bookmarks.Add("Days3", Days3);
                bookmarks.Add("Logs1", Logs1);
                bookmarks.Add("Logs2", Logs2);
                bookmarks.Add("Logs3", Logs3);
                bookmarks.Add("ComplexType", ComplexType);
                bookmarks.Add("StartTime", StartTime);
                bookmarks.Add("EndTime", EndTime);
                bookmarks.Add("ComplexDays", ComplexDays);
                bookmarks.Add("ComplexLogs", ComplexLogs);
                bookmarks.Add("OrganizeDowntimeDays", OrganizeDowntimeDays);
                bookmarks.Add("PresentationOfCondition", PresentationOfCondition);
                //下方多行表格暂时未写

                string wordpath = Application.StartupPath + "\\Data\\" + twellnum + "\\";//导出word的文件路径
                if (!System.IO.Directory.Exists(wordpath))
                {
                    System.IO.Directory.CreateDirectory(wordpath);
                }
                //GenerateWord(templatePath, wordpath, pdfpath, bookmarks);
                string path = wordpath + "监督报告附表（二）录井工作量统计表（时间）.docx";//导出word的地址
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                Export_2(templatePath, path, bookmarks);
                MessageBox.Show(path, "导出成功");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
                return;
            }
        }

        public void Save_Word_3() {
            try
            {
                string mubanFile = @"Templates\监督报告附表（三）现场问题及整改情况统计表.docx";
                string templatePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, mubanFile);//模板地址
                string wordpath = Application.StartupPath + "\\Data\\" + twellnum + "\\";//导出word的文件路径
                if (!System.IO.Directory.Exists(wordpath))
                {
                    System.IO.Directory.CreateDirectory(wordpath);
                }
                //GenerateWord(templatePath, wordpath, pdfpath, bookmarks);
                string path = wordpath + "监督报告附表（三）现场问题及整改情况统计表.docx";//导出word的地址
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                Export_3(templatePath, path);
                MessageBox.Show(path, "导出成功");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
                return;
            }
        }

    }
}
