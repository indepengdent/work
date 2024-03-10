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
    public partial class FormSSSP : Form
    {
        public string twellnum;
        public FormSSSP()
        {
            InitializeComponent();
        }

        private void FormSSSP_Load(object sender, EventArgs e)
        {
            if (twellnum == null || twellnum == "")
            {
                return;
            }
            string Geosupervision = "";
            string Supervcernum = "";
            string Supervmode = "";
            string Well_num = "";
            string Well_type = "";
            string Well_BB = "";
            string DrillAim = "";
            string Staraccept = "";
            string Processsuperv = "";
            string QHSE = "";
            string Title = "";
            DataTable dt = new DataTable();
            dt.Columns.Add("Title", typeof(string));
            dt.Columns.Add("Geosupervision", typeof(string));
            dt.Columns.Add("Supervcernum", typeof(string));
            dt.Columns.Add("Supervmode", typeof(string));
            dt.Columns.Add("Well_num", typeof(string));
            dt.Columns.Add("Well_type", typeof(string));
            dt.Columns.Add("Well_BB", typeof(string));
            dt.Columns.Add("DrillAim", typeof(string));
            
            dt.Columns.Add("Staraccept", typeof(string));
            dt.Columns.Add("Processsuperv", typeof(string));
            dt.Columns.Add("QHSE", typeof(string));
            
            string sqlwhere = " Wellnum = '" + twellnum + "'";
            try {
                SupervDB.BLL.GeoSuperv blgs = new SupervDB.BLL.GeoSuperv();
                List<SupervDB.Model.GeoSuperv> lgsv = blgs.GetModelList(sqlwhere);
                if (lgsv.Count > 0)
                {
                    SupervDB.Model.GeoSuperv gsv = lgsv[0];
                    Geosupervision = gsv.JdName;
                    Supervcernum = gsv.JdNum;
                    Supervmode = gsv.JdWay;
                    Well_num = gsv.Wellnum;
                    Well_type = gsv.Well_type;
                    Well_BB = gsv.Well_BB;
                    DrillAim = gsv.DrillAim;

                    Title = gsv.Wellnum + "井地址监督计划书";
                }

                SupervDB.BLL.MonitPlan bllp1 = new SupervDB.BLL.MonitPlan();
                List<SupervDB.Model.MonitPlan> llps1 = bllp1.GetModelList(sqlwhere);
                foreach (SupervDB.Model.MonitPlan item in llps1)
                {
                    if (item.DifCou!="")
                    {
                        if(item.Skey== "开工验收")
                        {
                            Staraccept += item.SCon + item.DifCou + "\n";
                        }
                        else if(item.Skey== "过程监督")
                        {
                            Processsuperv += item.SCon + item.DifCou + "\n";
                        }
                        else
                        {
                            QHSE += item.SCon + item.DifCou + "\n";
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // 动态添加前台传来的数据
            dt.Rows.Add(new object[] { Title,Geosupervision, Supervcernum, Supervmode, Well_num, Well_type, Well_BB , DrillAim, Staraccept, Processsuperv, QHSE });
            // 另外需要将ReportMain.rdlc文件复制到当前可执行程序目录下
            //this.reportViewer1.LocalReport.ReportPath = "ReportSSSP.rdlc";
            this.reportViewer1.LocalReport.DataSources.Clear();
            // 名称需要用我们之前设定的 "DataSetReport"
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            this.reportViewer1.RefreshReport();
        }
    }
}
