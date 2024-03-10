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
    public partial class WellForm7 : Form
    {
        public string twellnum;
        //public string outputPath = @"D:\code.C#\SupervisorAssist\SupervisorAssist\bin\Debug\Data\";
        public string Title = "";
        public string Number = "";
        public string Type1 = "";
        public string Sort = "";
        public string Location1 = "";
        public string Location2 = "";
        public string Purpose = "";
        public string Principle = "";
        public string High1 = "";
        public string High2 = "";
        public string WaterDeep = "";
        public string DesignDeep1 = "";
        public string DesignDeep2 = "";
        public string MainPurpose = "";
        public string MiniorPurpose = "";
        public string Length1 = "";
        public string Length2 = "";
        public string StartData = "";
        public string EndData1 = "";
        public string EndData2 = "";
        public string Enddeep1 = "";
        public string Enddeep2 = "";
        public string EndLocation = "";
        public string StartData2 = "";
        public string StartDeep = "";
        public string Method = "";
        public string Adjacentnum = "";
        public string LoggingProjects = "";
        public WellForm7()
        {
            InitializeComponent();
            
        }

        

        private void WellForm7_Load(object sender, EventArgs e)
        {
            if (twellnum == null || twellnum == "")
            {
                return;
            }
            Title = twellnum + "井基本信息";

            DataTable dt = new DataTable();
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Number", typeof(string));
            dt.Columns.Add("Type", typeof(string));
            dt.Columns.Add("Sort", typeof(string));
            dt.Columns.Add("Location1", typeof(string));
            dt.Columns.Add("Location2", typeof(string));
            dt.Columns.Add("Purpose", typeof(string));
            dt.Columns.Add("Principle", typeof(string));
            dt.Columns.Add("High1", typeof(string));
            dt.Columns.Add("High2", typeof(string));
            dt.Columns.Add("WaterDeep", typeof(string));
            dt.Columns.Add("DesignDeep1", typeof(string));
            dt.Columns.Add("DesignDeep2", typeof(string));
            dt.Columns.Add("MainPurpose", typeof(string));
            dt.Columns.Add("MiniorPurpose", typeof(string));
            dt.Columns.Add("Length1", typeof(string));
            dt.Columns.Add("Length2", typeof(string));
            dt.Columns.Add("StartData", typeof(string));
            dt.Columns.Add("EndData1", typeof(string));
            dt.Columns.Add("EndData2", typeof(string));
            dt.Columns.Add("Enddeep1", typeof(string));
            dt.Columns.Add("Enddeep2", typeof(string));
            dt.Columns.Add("EndLocation", typeof(string));
            dt.Columns.Add("StartData2", typeof(string));
            dt.Columns.Add("StartDeep", typeof(string));
            dt.Columns.Add("Method", typeof(string));
            dt.Columns.Add("Adjacentnum", typeof(string));
            dt.Columns.Add("LoggingProjects", typeof(string));
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Num1", typeof(string));
            dt2.Columns.Add("EndTime1", typeof(string));
            dt2.Columns.Add("Dia1", typeof(string));
            dt2.Columns.Add("Deep1", typeof(string));
            dt2.Columns.Add("ExDia1", typeof(string));
            dt2.Columns.Add("Ldepth1", typeof(string));

            string sqlwhere = " Wellnum = '" + twellnum + "'";
            try
            {
                SupervDB.BLL.GeoSuperv blgs = new SupervDB.BLL.GeoSuperv();
                List<SupervDB.Model.GeoSuperv> lgsv = blgs.GetModelList(sqlwhere);
                if (lgsv.Count > 0)
                {
                    SupervDB.Model.GeoSuperv gsv = lgsv[0];
                    Number = gsv.Wellnum;
                    Type1 = gsv.Well_type;
                    Sort = gsv.Well_BB;
                    Location1 = gsv.Location;
                    Location2 = gsv.GZLoc;
                    Purpose = gsv.DrillAim;
                    Principle = gsv.ComRul;
                    WaterDeep = gsv.Well_Sd.ToString();
                    High2 = gsv.Well_HB.ToString();
                    High1 = gsv.Well_KB.ToString();
                    MainPurpose = gsv.MainAimLayer;
                    DesignDeep2 = gsv.Well_Cd.ToString();
                    DesignDeep1 = gsv.Well_depth.ToString();
                    MiniorPurpose = gsv.SecAimLayer;
                    Length2 = gsv.SpLen.ToString();
                    Length1 = gsv.Well_CX.ToString();
                    Method = gsv.ComSty;
                    StartDeep = gsv.LjDepth.ToString();
                    EndLocation = gsv.LJEndDate;
                    Enddeep2 = gsv.WzCd.ToString();
                    Enddeep1 = gsv.Wzdepth.ToString();
                    Adjacentnum = gsv.WellLines;
                    StartData = DBUtility.DbHelperSQL.GetVtime(gsv.SDate);
                    EndData1 = DBUtility.DbHelperSQL.GetVtime(gsv.EDate);
                    EndData2 = DBUtility.DbHelperSQL.GetVtime(gsv.CDate);
                    StartData2 = DBUtility.DbHelperSQL.GetVtime(gsv.LJStartDate);

                    //                    LoggingProjects = @"钻时录井,岩屑录井,钻井取心,井壁取心,气测录井,钻井液录井,工程录井,泥（页）岩密度分析,
                    //碳酸盐含量分析,定量荧光录井,岩石热解地球化学录井,岩石热蒸发烃气相色谱录井,轻烃录井,
                    //核磁共振录井,X射线衍射矿物录井,X射线荧光元素录井,自然伽马能谱录井,岩心扫描,岩屑成像录井";
                }

                SupervDB.BLL.LogProjects bllp = new SupervDB.BLL.LogProjects();
                List<SupervDB.Model.LogProjects> llps = bllp.GetModelList(sqlwhere);
                if (llps.Count > 0)
                {
                    if (llps[0].IsAdopt == true)
                    {
                        LoggingProjects += llps[0].proname + ",";
                    }
                }


                SupervDB.BLL.WellStructure blws = new SupervDB.BLL.WellStructure();
                List<SupervDB.Model.WellStructure> lgws = blws.GetModelList(sqlwhere);
                foreach (SupervDB.Model.WellStructure item in lgws)
                {
                    DataRow dr = dt2.NewRow();
                    //Common
                    dr["Num1"] = item.OpenTime;
                    dr["EndTime1"] = DBUtility.DbHelperSQL.GetVtime(item.EDate);
                    dr["Dia1"] = DBUtility.DbHelperSQL.GetVDoule(item.Bitdia);
                    dr["Deep1"] = DBUtility.DbHelperSQL.GetVDoule(item.Welldepth);
                    dr["ExDia1"] = DBUtility.DbHelperSQL.GetVDoule(item.TgWj);
                    dr["Ldepth1"] = DBUtility.DbHelperSQL.GetVDoule(item.XDepth);
                    dt2.Rows.Add(dr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // 动态添加前台传来的数据
            dt.Rows.Add(new object[] { Title,Number, Type1, Sort, Location1, Location2, Purpose, Principle, High1, High2, WaterDeep, DesignDeep1, DesignDeep2, MainPurpose, MiniorPurpose, Length1, Length2, StartData, EndData1, EndData2, Enddeep1, Enddeep2, EndLocation, StartData2 , StartDeep, Method , Adjacentnum, LoggingProjects });
            //dt2.Rows.Add(new object[] { Num1, EndTime1, Dia1, Deep1, ExDia1, Ldepth1 });
            // 另外需要将ReportMain.rdlc文件复制到当前可执行程序目录下
            //this.reportViewer1.LocalReport.ReportPath = "xx 井基本信息数据表.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            // 名称需要用我们之前设定的 "DataSetReport"
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", dt2));
            //this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", table));

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string mubanFile = @"Templates\XX井基本数据表.docx";
        //        string templatePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, mubanFile);
        //        Dictionary<string, string> bookmarks = new Dictionary<string, string>();
        //        bookmarks.Add("Title", Number);
        //        bookmarks.Add("Number", Number);
        //        bookmarks.Add("Type", Type1);
        //        bookmarks.Add("Sort", Sort);
        //        bookmarks.Add("Location1", Location1);
        //        bookmarks.Add("Location2", Location2);
        //        bookmarks.Add("Purpose", Purpose);
        //        bookmarks.Add("Principle", Principle);
        //        bookmarks.Add("High1", High1);
        //        bookmarks.Add("High2", High2);
        //        bookmarks.Add("WaterDeep", WaterDeep);
        //        bookmarks.Add("DesignDeep1", DesignDeep1);
        //        bookmarks.Add("DesignDeep2", DesignDeep2);
        //        bookmarks.Add("MainPurpose", MainPurpose);
        //        bookmarks.Add("Length1", Length1);
        //        bookmarks.Add("Length2", Length2);
        //        bookmarks.Add("MiniorPurpose", MiniorPurpose);
        //        bookmarks.Add("StartData", StartData);
        //        bookmarks.Add("EndData1", EndData1);
        //        bookmarks.Add("EndData2", EndData2);
        //        bookmarks.Add("Enddeep1", Enddeep1);
        //        bookmarks.Add("Enddeep2", Enddeep2);
        //        bookmarks.Add("EndLocation", EndLocation);
        //        bookmarks.Add("StartData2", StartData2);
        //        bookmarks.Add("StartDeep", StartDeep);
        //        bookmarks.Add("Method", Method);
        //        bookmarks.Add("Adjacentnum", Adjacentnum);
        //        bookmarks.Add("LoggingProjects", LoggingProjects);
        //        //下方多行表格暂时未写

        //        string wordpath = Application.StartupPath + "\\Data\\" + twellnum + "\\";//导出word的文件路径
        //        if (!Directory.Exists(wordpath))
        //        {
        //            Directory.CreateDirectory(wordpath);
        //        }
        //        //GenerateWord(templatePath, wordpath, pdfpath, bookmarks);
        //        string path = wordpath + twellnum + "井基本信息数据表.docx";//导出word的地址
        //        Export(templatePath, path, bookmarks);
        //        MessageBox.Show(path, "导出成功");
        //    }
        //    catch (Exception Ex)
        //    {
        //        MessageBox.Show(Ex.ToString());
        //        return;
        //    }
        //}

        public void Export(string wordTemplatePath, string newFileName, Dictionary<string, string> wordLableList)
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
            SupervDB.BLL.WellStructure blws = new SupervDB.BLL.WellStructure();
            List<SupervDB.Model.WellStructure> lgws = blws.GetModelList(sqlwhere);
            int i = 16;
            foreach (SupervDB.Model.WellStructure item in lgws)
            {
                table1.Cell(i, 1).Range.Text = item.OpenTime;
                table1.Cell(i, 2).Range.Text = DBUtility.DbHelperSQL.GetVtime(item.EDate);
                table1.Cell(i, 3).Range.Text = DBUtility.DbHelperSQL.GetVStr(item.Bitdia);
                table1.Cell(i, 4).Range.Text = DBUtility.DbHelperSQL.GetVStr(item.Welldepth);
                table1.Cell(i, 5).Range.Text = DBUtility.DbHelperSQL.GetVStr(item.TgWj);
                table1.Cell(i, 6).Range.Text = DBUtility.DbHelperSQL.GetVStr(item.XDepth);
                i++;
                System.Object beforRow = System.Type.Missing;
                table1.Rows.Add(ref beforRow);//在表格末尾处插入行
            }


            object obj_IsSave = true;

            //doc.Close(ref obj_IsSave, ref obj_missing, ref obj_missing);​
            doc.Close(ref obj_IsSave, ref obj_missing, ref obj_missing);
        }

        public void Save_Word()
        {
            if (twellnum == null || twellnum == "")
            {
                return;
            }
            string Titles = twellnum + "井基本信息";
            string Numbers = "";
            string Type1s = "";
            string Sorts = "";
            string Location1s = "";
            string Location2s = "";
            string Purposes = "";
            string Principles = "";
            string High1s = "";
            string High2s = "";
            string WaterDeeps = "";
            string DesignDeep1s = "";
            string DesignDeep2s = "";
            string MainPurposes = "";
            string MiniorPurposes = "";
            string Length1s = "";
            string Length2s = "";
            string StartDatas = "";
            string EndData1s = "";
            string EndData2s = "";
            string Enddeep1s = "";
            string Enddeep2s = "";
            string EndLocations = "";
            string StartData2s = "";
            string StartDeeps = "";
            string Methods = "";
            string Adjacentnums = "";
            string LoggingProjectss = "";
            string sqlwhere = " Wellnum = '" + twellnum + "'";
            try
            {
                SupervDB.BLL.GeoSuperv blgs = new SupervDB.BLL.GeoSuperv();
                List<SupervDB.Model.GeoSuperv> lgsv = blgs.GetModelList(sqlwhere);
                if (lgsv.Count > 0)
                {
                    SupervDB.Model.GeoSuperv gsv = lgsv[0];
                    Numbers = gsv.Wellnum;
                    Type1s = gsv.Well_type;
                    Sorts = gsv.Well_BB;
                    Location1s = gsv.Location;
                    Location2s = gsv.GZLoc;
                    Purposes = gsv.DrillAim;
                    Principles = gsv.ComRul;
                    WaterDeeps = gsv.Well_Sd.ToString();
                    High2s = gsv.Well_HB.ToString();
                    High1s = gsv.Well_KB.ToString();
                    MainPurposes = gsv.MainAimLayer;
                    DesignDeep2s = gsv.Well_Cd.ToString();
                    DesignDeep1s = gsv.Well_depth.ToString();
                    MiniorPurposes = gsv.SecAimLayer;
                    Length2s = gsv.SpLen.ToString();
                    Length1s = gsv.Well_CX.ToString();
                    Methods = gsv.ComSty;
                    StartDeeps = gsv.LjDepth.ToString();
                    EndLocations = gsv.LJEndDate;
                    Enddeep2s = gsv.WzCd.ToString();
                    Enddeep1s = gsv.Wzdepth.ToString();
                    Adjacentnums = gsv.WellLines;
                    StartDatas = DBUtility.DbHelperSQL.GetVtime(gsv.SDate);
                    EndData1s = DBUtility.DbHelperSQL.GetVtime(gsv.EDate);
                    EndData2s = DBUtility.DbHelperSQL.GetVtime(gsv.CDate);
                    StartData2s = DBUtility.DbHelperSQL.GetVtime(gsv.LJStartDate);

                    //                    LoggingProjects = @"钻时录井,岩屑录井,钻井取心,井壁取心,气测录井,钻井液录井,工程录井,泥（页）岩密度分析,
                    //碳酸盐含量分析,定量荧光录井,岩石热解地球化学录井,岩石热蒸发烃气相色谱录井,轻烃录井,
                    //核磁共振录井,X射线衍射矿物录井,X射线荧光元素录井,自然伽马能谱录井,岩心扫描,岩屑成像录井";
                }

                SupervDB.BLL.LogProjects bllp = new SupervDB.BLL.LogProjects();
                List<SupervDB.Model.LogProjects> llps = bllp.GetModelList(sqlwhere);
                if (llps.Count > 0)
                {
                    if (llps[0].IsAdopt == true)
                    {
                        LoggingProjectss += llps[0].proname + ",";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string mubanFile = @"Templates\XX井基本数据表.docx";
                string templatePath = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, mubanFile);
                Dictionary<string, string> bookmarks = new Dictionary<string, string>();
                bookmarks.Add("Title", Numbers);
                bookmarks.Add("Number", Numbers);
                bookmarks.Add("Type", Type1s);
                bookmarks.Add("Sort", Sorts);
                bookmarks.Add("Location1", Location1s);
                bookmarks.Add("Location2", Location2s);
                bookmarks.Add("Purpose", Purposes);
                bookmarks.Add("Principle", Principles);
                bookmarks.Add("High1", High1s);
                bookmarks.Add("High2", High2s);
                bookmarks.Add("WaterDeep", WaterDeeps);
                bookmarks.Add("DesignDeep1", DesignDeep1s);
                bookmarks.Add("DesignDeep2", DesignDeep2s);
                bookmarks.Add("MainPurpose", MainPurposes);
                bookmarks.Add("Length1", Length1s);
                bookmarks.Add("Length2", Length2s);
                bookmarks.Add("MiniorPurpose", MiniorPurposes);
                bookmarks.Add("StartData", StartDatas);
                bookmarks.Add("EndData1", EndData1s);
                bookmarks.Add("EndData2", EndData2s);
                bookmarks.Add("Enddeep1", Enddeep1s);
                bookmarks.Add("Enddeep2", Enddeep2s);
                bookmarks.Add("EndLocation", EndLocations);
                bookmarks.Add("StartData2", StartData2s);
                bookmarks.Add("StartDeep", StartDeeps);
                bookmarks.Add("Method", Methods);
                bookmarks.Add("Adjacentnum", Adjacentnums);
                bookmarks.Add("LoggingProjects", LoggingProjectss);
                //下方多行表格暂时未写

                string wordpath = Application.StartupPath + "\\Data\\" + twellnum + "\\";//导出word的文件路径
                if (!Directory.Exists(wordpath))
                {
                    Directory.CreateDirectory(wordpath);
                }
                //GenerateWord(templatePath, wordpath, pdfpath, bookmarks);
                string path = wordpath + twellnum + "井基本信息数据表.docx";//导出word的地址
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


    }
}
