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
    public partial class WellForm3 : Form
    {
        public string twellnum;
        //过程监督
        public int ProblemNum = 0;
        public string ToolManagement = "";
        public string LithologyImplementation = "";
        public string GeologicalCardLayer = "";
        public string OilAndGasDisplayImplementation = "";
        public string InstrumentOperationAndCalibration = "";
        public string EngineeringWarning = "";
        public string DataQuality = "";
        public string LoggingByPost = "";
        //开工验收
        public int ProblemNum1 = 0;
        public string Qualification = "";
        public string StaffingIdentification = "";
        public string EquipmentInstallation = "";
        public string Preparation = "";
        //录井QHSE
        public int ProblemNum2 = 0;
        public string InstallationAndDetection = "";
        public string FacilitiesAndManagement = "";
        public string SupplyAndManagement = "";
        public string EmergencyPlanAndDrill = "";
        public string LoggingEnvironment = "";
        public WellForm3()
        {
            InitializeComponent();
        }

        private void WellForm3_Load(object sender, EventArgs e)
        {
            if (twellnum == null || twellnum == "")
            {
                return;
            }
            ////过程监督
            //int ProblemNum = 0;
            //string ToolManagement = "";
            //string LithologyImplementation = "";
            //string GeologicalCardLayer = "";
            //string OilAndGasDisplayImplementation = "";
            //string InstrumentOperationAndCalibration = "";
            //string EngineeringWarning = "";
            //string DataQuality = "";
            //string LoggingByPost = "";
            ////开工验收
            //int ProblemNum1 = 0;
            //string Qualification = "";
            //string StaffingIdentification = "";
            //string EquipmentInstallation = "";
            //string Preparation = "";
            ////录井QHSE
            //int  ProblemNum2 = 0;
            //string InstallationAndDetection = "";
            //string FacilitiesAndManagement = "";
            //string SupplyAndManagement = "";
            //string EmergencyPlanAndDrill = "";
            //string LoggingEnvironment = "";

            //过程监督
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("ProblemNum", typeof(string));
            dt1.Columns.Add("ToolManagement", typeof(string));
            dt1.Columns.Add("LithologyImplementation", typeof(string));
            dt1.Columns.Add("GeologicalCardLayer", typeof(string));
            dt1.Columns.Add("OilAndGasDisplayImplementation", typeof(string));
            dt1.Columns.Add("InstrumentOperationAndCalibration", typeof(string));
            dt1.Columns.Add("EngineeringWarning", typeof(string));
            dt1.Columns.Add("DataQuality", typeof(string));
            dt1.Columns.Add("LoggingByPost", typeof(string));
            //开工验收
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ProblemNum", typeof(string));
            dt2.Columns.Add("Qualification", typeof(string));
            dt2.Columns.Add("StaffingIdentification", typeof(string));
            dt2.Columns.Add("EquipmentInstallation", typeof(string));
            dt2.Columns.Add("Preparation", typeof(string));
            //录井QHSE
            DataTable dt3 = new DataTable();
            dt3.Columns.Add("ProblemNum", typeof(string));
            dt3.Columns.Add("InstallationAndDetection", typeof(string));
            dt3.Columns.Add("FacilitiesAndManagement", typeof(string));
            dt3.Columns.Add("SupplyAndManagement", typeof(string));
            dt3.Columns.Add("EmergencyPlanAndDrill", typeof(string));
            dt3.Columns.Add("LoggingEnvironment", typeof(string));

            ////过程监督
            //DataRow dr1 = dt1.NewRow();
            ////开工验收
            ////DataRow dr2 = dt2.NewRow();
            ////录井QHSE
            //DataRow dr3 = dt3.NewRow();
            string sqlwhere = " Wellnum = '" + twellnum + "'";
            int i = 0;
            try
            {
                //录井队伍资质
                SupervDB.BLL.TeamQual blws1 = new SupervDB.BLL.TeamQual();
                List<SupervDB.Model.TeamQual> lgws1 = blws1.GetModelList(sqlwhere);
                foreach (SupervDB.Model.TeamQual item in lgws1)
                {
                    //当其余各项均不为空时，有一小项检查结果不合格即说明该大项不合格
                    if (item.CheckResults == "不合格" && item.LogTNum != "" && item.Affiliation != "" && item.QualCNum != "" && item.TypeTeam != "" && item.TeamLevel != "")
                    {
                        i++;
                        //DataRow dr2 = dt2.NewRow();
                        ProblemNum1 += 1;
                        Qualification += i+". "+item.LogTNum+"\n";
                        //dr2["Qualification"] = item.LogTNum + "不合格";
                        //dt2.Rows.Add(dr2);
                    }
                }

                //人员配备及证件
                SupervDB.BLL.StaffDocu blws2 = new SupervDB.BLL.StaffDocu();
                List<SupervDB.Model.StaffDocu> lgws2 = blws2.GetModelList(sqlwhere);
                i = 0;
                foreach (SupervDB.Model.StaffDocu item in lgws2)
                {
                    //当其余各项均不为空时，有一小项检查结果不合格即说明该大项不合格
                    if (item.CheckResults == "不合格" && item.Num != "" && item.Name != "" && item.JobNum != "" && item.JobTitle != "" && item.JobLevel != "" && item.WellConcert != "" && item.HS2Cert != "" && item.HSECert != "" && item.FiveSCert != "")
                    {
                        i++;
                        ProblemNum1 += 1;
                        StaffingIdentification +=i+". "+ item.Name + "\n";
                        //DataRow dr2 = dt2.NewRow();

                        //dr2["StaffingIdentification"] = item.Name + "不合格";
                        //dt2.Rows.Add(dr2);
                    }
                }

                //设备配备及安装
                SupervDB.BLL.DataAcqSoft blws7 = new SupervDB.BLL.DataAcqSoft();
                List<SupervDB.Model.DataAcqSoft> lgws7 = blws7.GetModelList(sqlwhere);
                int j = 0;
                foreach (SupervDB.Model.DataAcqSoft item in lgws7)
                {
                    if ((item.CheckResult == "" || item.CheckResult == "不合格") && item.AcpSoftVer == "" && item.SoftManu == "")
                    {
                        j++;
                        ProblemNum1 += 1;
                        EquipmentInstallation +=j+". "+ item.AcpSoftVer + "\n";
                        //DataRow dr2 = dt2.NewRow();

                        //dr2["EquipmentInstallation"]= item.AcpSoftVer + "不合格\n";
                        //dt2.Rows.Add(dr2);
                    }
                }

                SupervDB.BLL.OnDataTran blws8 = new SupervDB.BLL.OnDataTran();
                List<SupervDB.Model.OnDataTran> lgws8 = blws8.GetModelList(sqlwhere);
                
                foreach (SupervDB.Model.OnDataTran item in lgws8)
                {
                    if ((item.CheckResult == "" || item.CheckResult == "不合格") && item.TranFormat == "" && item.TranStab == "")
                    {
                        j++;
                        ProblemNum1 += 1;
                        EquipmentInstallation +=j+". "+ item.TranFormat + "\n";
                        //DataRow dr2 = dt2.NewRow();

                        //dr2["EquipmentInstallation"] = item.TranFormat + "不合格\n";
                        //dt2.Rows.Add(dr2);
                    }
                }

                SupervDB.BLL.DeaeratorEquip blws9 = new SupervDB.BLL.DeaeratorEquip();
                List<SupervDB.Model.DeaeratorEquip> lgws9 = blws9.GetModelList(sqlwhere);
               
                foreach (SupervDB.Model.DeaeratorEquip item in lgws9)
                {
                    if ((item.CheckResults == "" || item.CheckResults == "不合格" || item.IsStandard == "" || item.IsStandard == "不规范") && item.Model == "" && item.FactoryNum == "" && item.Manufacturer == "")
                    {
                        j++;
                        ProblemNum1 += 1;
                        EquipmentInstallation +=j+". "+ item.Model + "\n";
                        //DataRow dr2 = dt2.NewRow();

                        //dr2["EquipmentInstallation"] = item.Model + "不合格\n";
                        //dt2.Rows.Add(dr2);
                    }
                }

                SupervDB.BLL.EvalLogEquip bllp10 = new SupervDB.BLL.EvalLogEquip();
                List<SupervDB.Model.EvalLogEquip> llps10 = bllp10.GetModelList(sqlwhere);
                
                foreach (SupervDB.Model.EvalLogEquip item in llps10)
                {
                    if (item.CheckResults == "" || item.CheckResults == "不合格")
                    {
                        j++;
                        ProblemNum1 += 1;
                        EquipmentInstallation +=j+". "+ item.CheckProject + "\n";
                        //DataRow dr2 = dt2.NewRow();

                        //dr2["EquipmentInstallation"] = item.CheckProject + "不合格\n";
                        //dt2.Rows.Add(dr2);
                    }
                }

                SupervDB.BLL.GeoREquip bllp11 = new SupervDB.BLL.GeoREquip();
                List<SupervDB.Model.GeoREquip> llps11 = bllp11.GetModelList(sqlwhere);
              
                foreach (SupervDB.Model.GeoREquip item in llps11)
                {
                    if (item.CheckResults == "" || item.CheckResults == "不合格")
                    {
                        j++;
                        ProblemNum1 += 1;
                        EquipmentInstallation +=j+". "+ item.GeoEquip + "\n";
                        //DataRow dr2 = dt2.NewRow();

                        //dr2["EquipmentInstallation"] = item.GeoEquip + "不合格\n";
                        //dt2.Rows.Add(dr2);
                    }
                }

                SupervDB.BLL.EquipCAI blws12 = new SupervDB.BLL.EquipCAI();
                List<SupervDB.Model.EquipCAI> lgws12 = blws12.GetModelList(sqlwhere);
                
                foreach (SupervDB.Model.EquipCAI item in lgws12)
                {
                    if ((item.CheckResults == "" || item.CheckResults == "不合格") && item.Model == "" && item.EquipName == "" && item.FactoryNum == "" && item.Manufacturer == "")
                    {
                        j++;
                        ProblemNum1 += 1;
                        EquipmentInstallation +=j+". "+ item.EquipName + "\n";
                        //DataRow dr2 = dt2.NewRow();

                        //dr2["EquipmentInstallation"] = item.EquipName + "不合格\n";
                        //dt2.Rows.Add(dr2);
                    }
                }

                SupervDB.BLL.SensorEquip blws13 = new SupervDB.BLL.SensorEquip();
                List<SupervDB.Model.SensorEquip> lgws13 = blws13.GetModelList(sqlwhere);
                
                foreach (SupervDB.Model.SensorEquip item in lgws13)
                {
                    if ((item.CheckResults == "" || item.CheckResults == "不合格" || item.IsStandard == "") && item.FactoryNum == "" && item.Manufacturer == "")
                    {
                        j++;
                        ProblemNum1 += 1;
                        EquipmentInstallation +=j+". "+ item.SensorName + "\n";
                        //DataRow dr2 = dt2.NewRow();

                        //dr2["EquipmentInstallation"] = item.SensorName + "不合格\n";
                        //dt2.Rows.Add(dr2);
                    }
                }

                //资料准备
                SupervDB.BLL.PrepareMaterials bllp6 = new SupervDB.BLL.PrepareMaterials();
                List<SupervDB.Model.PrepareMaterials> llps6 = bllp6.GetModelList(sqlwhere);
                i = 0;
                foreach (SupervDB.Model.PrepareMaterials item in llps6)
                {
                    //当其余各项均不为空时，有一小项检查结果不合格即说明该大项不合格
                    if (item.Checked != "" && item.IsAdopt == false)
                    {
                        i++;
                        ProblemNum1 += 1;
                        Preparation +=i+". " + item.Checked + "\n";
                        //DataRow dr2 = dt2.NewRow();
                        //ProblemNum1 += 1;
                        //dr2["Preparation"] = item.Checked + "不合格\n";
                        //dt2.Rows.Add(dr2);
                    }
                }


                SupervDB.BLL.LogWells_SitDuty bllp14 = new SupervDB.BLL.LogWells_SitDuty();
                List<SupervDB.Model.LogWells_SitDuty> llps14 = bllp14.GetModelList(sqlwhere);
                int a = 0, b = 0, c = 0, d = 0, h = 0, f = 0;
                foreach (SupervDB.Model.LogWells_SitDuty item in llps14)
                {
                    //硫化氢传感器安装与检测
                    if (item.TableName == "硫化氢传感器安装及检测")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            a++;
                            ProblemNum2 += 1;
                            InstallationAndDetection +=a+". "+ item.CheckProject + "\n";
                            //Othercircum += "硫化氢传感器安装与检测:" + item.CheckProject + "不合格\n";
                        }
                    }
                    else if (item.TableName == "录井坐岗")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            b++;
                            ProblemNum += 1;
                            LoggingByPost += b+". "+item.CheckProject + "\n";
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
                                c++;
                                ProblemNum2 += 1;
                                FacilitiesAndManagement +=c+". "+ item.CheckProject + "\n";
                                //Othercircum += "安全防护设施配备及管理:" + item.CheckProject + "不合格\n";
                            }
                            //化学药品配备及管理
                            if (item.CheckProject == "化学药品使用" || item.CheckProject == "化学药品存放" || item.CheckProject == "化学药品管理")
                            {
                                d++;
                                ProblemNum2 += 1;
                                SupplyAndManagement +=d+". "+ item.CheckProject + "\n";
                                //Othercircum += "化学药品配备及管理:" + item.CheckProject + "不合格\n";
                            }
                            //应急预案及演练
                            if (item.CheckProject == "应急预案" || item.CheckProject == "应急演练")
                            {
                                f++;
                                ProblemNum2 += 1;
                                EmergencyPlanAndDrill +=f+". "+ item.CheckProject + "\n";
                                //Othercircum += "应急预案及演练:" + item.CheckProject + "不合格\n";
                            }
                        }
                    }
                    //录井环境
                    else if (item.TableName == "录井环境")
                    {
                        if (item.CheckResults == "" || item.CheckResults == "不合格")
                        {
                            h++;
                            ProblemNum2 += 1;
                            LoggingEnvironment += h+". "+item.CheckProject + "\n";
                            //Othercircum += "录井环境:" + item.CheckProject + "不合格\n";
                        }
                    }
                    else
                    {

                    }
                }

                SupervDB.BLL.DriTSMana bllp5 = new SupervDB.BLL.DriTSMana();
                List<SupervDB.Model.DriTSMana> llps5 = bllp5.GetModelList(sqlwhere);
                int a1=0, b1=0, c1=0, d1=0, f1=0, h1=0,g1=0;
                foreach (SupervDB.Model.DriTSMana item in llps5)
                {
                    //钻具及套管管理
                    if (item.TableName == "钻具及套管管理")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            a1++;
                            ProblemNum += 1;
                            ToolManagement +=a1+". "+ item.CheckProject + "\n";
                            //Problem_des += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                    //设备安装及运行
                    else if (item.TableName == "设备安装及运行")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            b1++;
                            ProblemNum += 1;
                            InstrumentOperationAndCalibration +=b1+". "+ item.CheckProject + "\n";
                            //Problem_des += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                    //岩性落实
                    else if (item.TableName == "岩性落实")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            c1++;
                            ProblemNum += 1;
                            LithologyImplementation +=c1+". "+ item.CheckProject  + "\n";
                            //Problem_des += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                    //气油层显示落实
                    else if (item.TableName == "油气层发现")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            d1++;
                            ProblemNum += 1;
                            OilAndGasDisplayImplementation +=d1+". "+ item.CheckProject  + "\n";
                            //Problem_des += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                    //地质卡层  
                    else if (item.TableName == "地质卡层")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            f1++;
                            ProblemNum += 1;
                            GeologicalCardLayer +=f1+". "+ item.CheckProject + "\n";
                            //Problem_des += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                    //工程预警
                    else if (item.TableName == "工程预警")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            h1++;
                            ProblemNum += 1;
                            EngineeringWarning +=h1+". "+ item.CheckProject + "\n";
                            //Problem_des += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                    //资料质量  
                    else if (item.TableName == "资料质量")
                    {
                        if (item.CheckResults == "不合格")
                        {
                            g1++;
                            ProblemNum += 1;
                            DataQuality +=g1+". "+ item.CheckProject+ "\n";
                            //Problem_des += item.CheckProject + item.CheckResults + "\n";
                        }
                    }
                    else {  }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            // 动态添加前台传来的数据
            dt1.Rows.Add(new object[] { ProblemNum.ToString() + "个",ToolManagement, LithologyImplementation, GeologicalCardLayer, OilAndGasDisplayImplementation, InstrumentOperationAndCalibration, EngineeringWarning, DataQuality, LoggingByPost });
            dt2.Rows.Add(new object[] { ProblemNum1.ToString() + "个", Qualification, StaffingIdentification, EquipmentInstallation , Preparation });
            dt3.Rows.Add(new object[] { ProblemNum2.ToString() + "个", InstallationAndDetection , FacilitiesAndManagement , SupplyAndManagement , EmergencyPlanAndDrill , LoggingEnvironment });
            // 另外需要将ReportMain.rdlc文件复制到当前可执行程序目录下
            //this.reportViewer1.LocalReport.ReportPath = "地质监督发现问题统计表—过程监督.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();

            //this.reportViewer2.LocalReport.ReportPath = "地质监督发现问题统计表—开工验收.rdlc";
            this.reportViewer2.LocalReport.DataSources.Clear();

            //this.reportViewer3.LocalReport.ReportPath = "地质监督发现问题统计表—录井QHSE.rdlc";
            this.reportViewer3.LocalReport.DataSources.Clear();
            // 名称需要用我们之前设定的 "DataSetReport"
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt1));
            this.reportViewer2.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt2));
            this.reportViewer3.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt3));

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        public void Export_1(string wordTemplatePath, string newFileName) {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            string TemplateFile = wordTemplatePath;
            File.Copy(TemplateFile, newFileName);
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
            Microsoft.Office.Interop.Word.Table table1 = doc.Tables[1];
            // int i = 16;
            table1.Cell(2, 1).Range.Text = ProblemNum.ToString();
            table1.Cell(2, 2).Range.Text = ToolManagement;
            table1.Cell(2, 3).Range.Text = LithologyImplementation;
            table1.Cell(2, 4).Range.Text = GeologicalCardLayer;
            table1.Cell(2, 5).Range.Text = OilAndGasDisplayImplementation;
            table1.Cell(2, 6).Range.Text = InstrumentOperationAndCalibration;
            table1.Cell(2, 7).Range.Text = EngineeringWarning;
            table1.Cell(2, 8).Range.Text = DataQuality;
            table1.Cell(2, 9).Range.Text = LoggingByPost;
            //i++;
            //System.Object beforRow = System.Type.Missing;
            //table1.Rows.Add(ref beforRow);//在表格末尾处插入行
            object obj_IsSave = true;
            doc.Close(ref obj_IsSave, ref obj_missing, ref obj_missing);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mubanFile = @"Templates\地质监督发现问题统计表—过程监督.docx";
                string templatePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, mubanFile);
                string wordpath = Application.StartupPath + "\\Data\\" + twellnum + "\\";//导出word的文件路径
                if (!Directory.Exists(wordpath))
                {
                    Directory.CreateDirectory(wordpath);
                }
                //GenerateWord(templatePath, wordpath, pdfpath, bookmarks);
                string path = wordpath + twellnum + "地质监督发现问题统计表—过程监督.docx";//导出word的地址
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                Export_1(templatePath, path);
                MessageBox.Show(path, "导出成功");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString());
                return;
            }
        }

        public void Export_2(string wordTemplatePath, string newFileName)
        {
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            string TemplateFile = wordTemplatePath;
            File.Copy(TemplateFile, newFileName);
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
            Microsoft.Office.Interop.Word.Table table1 = doc.Tables[1];
           // int i = 16;
            table1.Cell(2, 1).Range.Text = ProblemNum1.ToString ();
            table1.Cell(2, 2).Range.Text = Qualification;
            table1.Cell(2, 3).Range.Text = StaffingIdentification;
            table1.Cell(2, 4).Range.Text = EquipmentInstallation;
            table1.Cell(2, 5).Range.Text = Preparation;
            //i++;
            //System.Object beforRow = System.Type.Missing;
            //table1.Rows.Add(ref beforRow);//在表格末尾处插入行
            object obj_IsSave = true;
            doc.Close(ref obj_IsSave, ref obj_missing, ref obj_missing);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string mubanFile = @"Templates\地质监督发现问题统计表—开工验收.docx";
                string templatePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, mubanFile);
                string wordpath = Application.StartupPath + "\\Data\\" + twellnum + "\\";//导出word的文件路径
                if (!Directory.Exists(wordpath))
                {
                    Directory.CreateDirectory(wordpath);
                }
                //GenerateWord(templatePath, wordpath, pdfpath, bookmarks);
                string path = wordpath + twellnum + "地质监督发现问题统计表—开工验收.docx";//导出word的地址
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                Export_2(templatePath, path);
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
            File.Copy(TemplateFile, newFileName);
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
            Microsoft.Office.Interop.Word.Table table1 = doc.Tables[1];
            // int i = 16;
            table1.Cell(2, 1).Range.Text = ProblemNum2.ToString();
            table1.Cell(2, 2).Range.Text = InstallationAndDetection;
            table1.Cell(2, 3).Range.Text = FacilitiesAndManagement;
            table1.Cell(2, 4).Range.Text = SupplyAndManagement;
            table1.Cell(2, 5).Range.Text = EmergencyPlanAndDrill;
            table1.Cell(2, 6).Range.Text = LoggingEnvironment;
            //i++;
            //System.Object beforRow = System.Type.Missing;
            //table1.Rows.Add(ref beforRow);//在表格末尾处插入行
            object obj_IsSave = true;
            doc.Close(ref obj_IsSave, ref obj_missing, ref obj_missing);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string mubanFile = @"Templates\地质监督发现问题统计表—录井QHSE.docx";
                string templatePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, mubanFile);
                string wordpath = Application.StartupPath + "\\Data\\" + twellnum + "\\";//导出word的文件路径
                if (!Directory.Exists(wordpath))
                {
                    Directory.CreateDirectory(wordpath);
                }
                //GenerateWord(templatePath, wordpath, pdfpath, bookmarks);
                string path = wordpath + twellnum + "地质监督发现问题统计表—录井QHSE.docx";//导出word的地址
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
