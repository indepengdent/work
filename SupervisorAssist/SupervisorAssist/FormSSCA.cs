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
    public partial class FormSSCA : Form
    {
        public　string twellnum;
        public FormSSCA()
        {
            InitializeComponent();
        }

        private void FormSSCA_Load(object sender, EventArgs e)
        {
            if (twellnum == null || twellnum == "")
            {
                return;
            }
            int sign = 0;//用于记录是第几个不合格
            string Wellnum = twellnum;
            string Well_BB = "";
            string Well_type = "";
            string LogTNum = "";
            string TypeTeam = "";
            string TeamLevel = "";
            string QualCNum = "";
            string Logunit = "";
            string Geosupervision = "";
            string workplace = "";
            string Peopleaccept = "";
            string CheckResult1 = "合格";
            string CheckResult2 = "合格";
            string CheckResult3 = "合格";
            string CheckResult4 = "合格";
            string CheckResult5 = "合格";
            string CheckResult6 = "合格";
            string CheckResult7 = "合格";
            string CheckResult8 = "合格";
            string CheckResult9 = "合格";
            string Othercircum = "";
            string Conclusion = "";
            string Height = "";
            string Logteam = "";
            string Wellsitter = "";
            string Accepttime = "";
            DataTable dt = new DataTable();
            dt.Columns.Add("Wellnum", typeof(string));
            dt.Columns.Add("Well_BB", typeof(string));
            dt.Columns.Add("Well_type", typeof(string));
            dt.Columns.Add("LogTNum", typeof(string));
            dt.Columns.Add("TypeTeam", typeof(string));
            dt.Columns.Add("TeamLevel", typeof(string));
            dt.Columns.Add("QualCNum", typeof(string));
            dt.Columns.Add("Logunit", typeof(string));
            dt.Columns.Add("Geosupervision", typeof(string));
            dt.Columns.Add("workplace", typeof(string));
            dt.Columns.Add("Peopleaccept", typeof(string));
            dt.Columns.Add("CheckResult1", typeof(string));
            dt.Columns.Add("CheckResult2", typeof(string));
            dt.Columns.Add("CheckResult3", typeof(string));
            dt.Columns.Add("CheckResult4", typeof(string));
            dt.Columns.Add("CheckResult5", typeof(string));
            dt.Columns.Add("CheckResult6", typeof(string));
            dt.Columns.Add("CheckResult7", typeof(string));
            dt.Columns.Add("CheckResult8", typeof(string));
            dt.Columns.Add("CheckResult9", typeof(string));
            dt.Columns.Add("Height",typeof(string));
            dt.Columns.Add("Othercircum", typeof(string));
            dt.Columns.Add("Conclusion", typeof(string));
            dt.Columns.Add("Logteam", typeof(string));
            dt.Columns.Add("Wellsitter", typeof(string));
            dt.Columns.Add("Accepttime", typeof(string));
            string sqlwhere = " Wellnum = '" + twellnum + "'";
            try
            {
                
                SupervDB.BLL.GeoSuperv blgs1 = new SupervDB.BLL.GeoSuperv();
                List<SupervDB.Model.GeoSuperv> lgsv1 = blgs1.GetModelList(sqlwhere);
                if (lgsv1.Count > 0)
                {
                    SupervDB.Model.GeoSuperv gsv = lgsv1[0];
                    //Well_num = gsv.Wellnum;
                    Well_BB = gsv.Well_BB;
                    Well_type = gsv.Well_type;
                    //地质监督
                    Geosupervision = gsv.JdName;
                }

                SupervDB.BLL.TeamQual blgs2 = new SupervDB.BLL.TeamQual();
                List<SupervDB.Model.TeamQual> lgsv2 = blgs2.GetModelList(sqlwhere);
                if (lgsv2.Count > 0)
                {
                    SupervDB.Model.TeamQual gsv = lgsv2[0];
                    LogTNum = gsv.LogTNum;
                    TypeTeam = gsv.TypeTeam;
                    TeamLevel = gsv.TeamLevel;
                    QualCNum = gsv.QualCNum;
                    Logunit = gsv.Affiliation;

                }
                SupervDB.BLL.StaffDocu blgs3 = new SupervDB.BLL.StaffDocu();
                List<SupervDB.Model.StaffDocu> lgsv3 = blgs3.GetModelList(sqlwhere);
                if (lgsv3.Count > 0)
                {
                    SupervDB.Model.StaffDocu gsv = lgsv3[0];
                    workplace = gsv.JobTitle;
                }

                //参加验收人（暂时搁置）
                Peopleaccept = "暂时不管";

                //录井队伍资质
                SupervDB.BLL.TeamQual blws4 = new SupervDB.BLL.TeamQual();
                List<SupervDB.Model.TeamQual> lgws4 = blws4.GetModelList(sqlwhere);
                foreach (SupervDB.Model.TeamQual item in lgws4)
                {
                    //当其余各项均不为空时，有一小项检查结果不合格即说明该大项不合格
                    if (item.CheckResults == "不合格"&&item.LogTNum!=""&&item.Affiliation!=""&&item.QualCNum!=""&&item.TypeTeam!=""&&item.TeamLevel!="")
                    {
                        CheckResult1 = "不合格";
                        sign++;
                        Othercircum += sign + "、 录井队伍资质:" + item.LogTNum + "不合格\n";
                        
                    }   
                }

                //人员配备及证件
                SupervDB.BLL.StaffDocu blws5 = new SupervDB.BLL.StaffDocu();
                List<SupervDB.Model.StaffDocu> lgws5 = blws5.GetModelList(sqlwhere);
                foreach (SupervDB.Model.StaffDocu item in lgws5)
                {
                    //当其余各项均不为空时，有一小项检查结果不合格即说明该大项不合格
                    if (item.CheckResults=="不合格"&&item.Num!=""&&item.Name!=""&&item.JobNum!=""&&item.JobTitle!=""&&item.JobLevel!=""&&item.WellConcert!=""&&item.HS2Cert!=""&&item.HSECert!=""&&item.FiveSCert!="")
                    {
                        CheckResult2 = "不合格";
                        sign++;
                        Othercircum += sign + "、 人员配备及证件:" + item.Name + "不合格\n";
                    }
                }

                //设备配备及安装
                if (CheckResult3 == "合格") {
                    SupervDB.BLL.DataAcqSoft blws7 = new SupervDB.BLL.DataAcqSoft();
                    List<SupervDB.Model.DataAcqSoft> lgws7 = blws7.GetModelList(sqlwhere);
                    foreach (SupervDB.Model.DataAcqSoft item in lgws7)
                    {
                        if ((item.CheckResult == "" || item.CheckResult == "不合格") && item.AcpSoftVer == "" && item.SoftManu == "")
                        {
                            CheckResult3 = "不合格";
                            sign++;
                            Othercircum += sign+ "、 设备配备及安装:" + item.AcpSoftVer + "不合格\n";
                        }
                    }
                }
                if (CheckResult3 == "合格")
                {
                    SupervDB.BLL.OnDataTran blws8 = new SupervDB.BLL.OnDataTran();
                    List<SupervDB.Model.OnDataTran> lgws8 = blws8.GetModelList(sqlwhere);
                    foreach (SupervDB.Model.OnDataTran item in lgws8) {
                        if ((item.CheckResult == "" || item.CheckResult == "不合格") && item.TranFormat == "" && item.TranStab == "")
                        {
                            CheckResult3 = "不合格";
                            sign++;
                            Othercircum += sign+ "、 设备配备及安装:" + item.TranFormat + "不合格\n";
                        }
                    }
                }
                if (CheckResult3 == "合格")
                {
                    SupervDB.BLL.DeaeratorEquip blws9 = new SupervDB.BLL.DeaeratorEquip();
                    List<SupervDB.Model.DeaeratorEquip> lgws9 = blws9.GetModelList(sqlwhere);
                    foreach (SupervDB.Model.DeaeratorEquip item in lgws9) {
                        if ((item.CheckResults == "" || item.CheckResults == "不合格"||item.IsStandard==""||item.IsStandard=="不规范") && item.Model == "" && item.FactoryNum == ""&&item.Manufacturer=="")
                        {
                            CheckResult3 = "不合格";
                            sign++;
                            Othercircum += sign+ "、 设备配备及安装:" + item.Model + "不合格\n";
                        }
                    }
                }
                if (CheckResult3 == "合格")
                {
                    SupervDB.BLL.EvalLogEquip bllp10 = new SupervDB.BLL.EvalLogEquip();
                    List<SupervDB.Model.EvalLogEquip> llps10 = bllp10.GetModelList(sqlwhere);
                    foreach (SupervDB.Model.EvalLogEquip item in llps10)
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格" )
                        {
                            CheckResult3 = "不合格";
                            sign++;
                            Othercircum += sign+ "、 设备配备及安装:" + item.CheckProject + "不合格\n";
                        }
                    }
                }
                if (CheckResult3 == "合格")
                {
                    SupervDB.BLL.GeoREquip bllp11 = new SupervDB.BLL.GeoREquip();
                    List<SupervDB.Model.GeoREquip> llps11 = bllp11.GetModelList(sqlwhere);
                    foreach (SupervDB.Model.GeoREquip item in llps11)
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            CheckResult3 = "不合格";
                            sign++;
                            Othercircum += sign+ "、 设备配备及安装:" + item.GeoEquip  + "不合格\n";
                        }
                    }
                }
                if (CheckResult3 == "合格")
                {
                    SupervDB.BLL.EquipCAI blws12 = new SupervDB.BLL.EquipCAI();
                    List<SupervDB.Model.EquipCAI> lgws12 = blws12.GetModelList(sqlwhere);
                    foreach (SupervDB.Model.EquipCAI item in lgws12)
                    {
                        if ((item.CheckResults == "" || item.CheckResults == "不合格")&&item.Model ==""&&item.EquipName==""&&item.FactoryNum==""&&item.Manufacturer=="")
                        {
                            CheckResult3 = "不合格";
                            sign++;
                            Othercircum +=sign+ "、 设备配备及安装:" + item.EquipName + "不合格\n";
                        }
                    }
                }
                if (CheckResult3 == "合格")
                {
                    SupervDB.BLL.SensorEquip blws13 = new SupervDB.BLL.SensorEquip();
                    List<SupervDB.Model.SensorEquip> lgws13 = blws13.GetModelList(sqlwhere);
                    foreach (SupervDB.Model.SensorEquip item in lgws13)
                    {
                        if ((item.CheckResults == "" || item.CheckResults == "不合格"||item.IsStandard=="")&&item.FactoryNum==""&&item.Manufacturer=="" )
                        {
                            CheckResult3 = "不合格";
                            sign++;
                            Othercircum +=sign+ "、 设备配备及安装:" + item.SensorName   + "不合格\n";
                        }
                    }
                }


                //资料准备
                SupervDB.BLL.PrepareMaterials bllp6 = new SupervDB.BLL.PrepareMaterials();
                List<SupervDB.Model.PrepareMaterials> llps6 = bllp6.GetModelList(sqlwhere);
                foreach (SupervDB.Model.PrepareMaterials item in llps6)
                {
                    //当其余各项均不为空时，有一小项检查结果不合格即说明该大项不合格
                    if (item.Checked != "" && item.IsAdopt == false)
                    {
                        CheckResult4 = "不合格";
                        sign++;
                        Othercircum += sign+ "、 资料准备:" + item.Checked + "不合格\n";
                    }
                }

                
               
                SupervDB.BLL.LogWells_SitDuty bllp14 = new SupervDB.BLL.LogWells_SitDuty();
                List<SupervDB.Model.LogWells_SitDuty> llps14 = bllp14.GetModelList(sqlwhere);
                foreach (SupervDB.Model.LogWells_SitDuty item in llps14)
                {
                    //硫化氢传感器安装与检测
                    if (item.TableName== "硫化氢传感器安装及检测")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            CheckResult5 = "不合格";
                            sign++;
                            Othercircum += sign+ "、 硫化氢传感器安装与检测:" + item.CheckProject + "不合格\n";
                        }
                    }
                    //安全防护设施配备及管理
                    else if(item.TableName == "硫化氢传感器检测")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格") {
                            //安全防护设施配备及管理
                            if (item.CheckProject   == "正压式呼吸器"||item.CheckProject== "灭火器"||item.CheckProject== "有毒有害气体检测仪"||item.CheckProject== "防毒面具"||item.CheckProject== "报警器"||item.CheckProject== "劳保穿戴") {
                                CheckResult6 = "不合格";
                                sign++;
                                Othercircum += sign +"、 安全防护设施配备及管理:" + item.CheckProject + "不合格\n";
                            }
                            //化学药品配备及管理
                            if (item.CheckProject == "化学药品使用"||item.CheckProject== "化学药品存放"||item.CheckProject== "化学药品管理")
                            {
                                CheckResult7 = "不合格";
                                sign++;
                                Othercircum += sign +"、 化学药品配备及管理:" + item.CheckProject + "不合格\n";
                            }
                            //应急预案及演练
                            if (item.CheckProject == "应急预案"||item.CheckProject== "应急演练")
                            {
                                CheckResult8 = "不合格";
                                sign++;
                                Othercircum += sign+ "、 应急预案及演练:" + item.CheckProject + "不合格\n";
                            }
                        }
                    }
                    //录井环境
                    else if(item.TableName== "录井环境")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            CheckResult9 = "不合格";
                            sign++;
                            Othercircum += sign+ "、 录井环境:" + item.CheckProject + "不合格\n";
                        }
                    }
                    else
                    {
                        Wellnum = twellnum;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            for (int i = 0; i < sign; i++) {
                if (i < (sign / 2)) Height = "\n" + Height;
                else if (i == (sign / 2)) Height += "其他情况说明";
                else  Height += "\n";
            }
                
            if (CheckResult1 =="合格" &&CheckResult2 =="合格"&& CheckResult3 == "合格" && CheckResult4 == "合格" && CheckResult5 == "合格" && CheckResult6 == "合格" && CheckResult7 == "合格" && CheckResult8 == "合格" && CheckResult9 == "合格")
            {
                Conclusion = "同意开工";
            }
            else
            {
                Conclusion = "不同意开工/择期重新验收";
            }
            
            // 动态添加前台传来的数据
            dt.Rows.Add(new object[] { Wellnum ,Well_BB ,Well_type ,LogTNum ,TypeTeam ,TeamLevel ,QualCNum ,Logunit ,Geosupervision ,workplace ,Peopleaccept , CheckResult1 ,CheckResult2 , CheckResult3 ,CheckResult4,CheckResult5,CheckResult6 ,CheckResult7 ,CheckResult8,CheckResult9 ,Height,Othercircum ,Conclusion ,Logteam ,Wellsitter ,Accepttime });
            // 另外需要将ReportMain.rdlc文件复制到当前可执行程序目录下
            //this.reportViewer1.LocalReport.ReportPath = "ReportSSCA.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            // 名称需要用我们之前设定的 "DataSetReport"
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
