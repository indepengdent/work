
using DBUtility;
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

namespace SupervisorAssist
{
    public partial class Form1 : Form
    {
        public GeoSuperv CurSuperv;
        public string CurWellnum;

        public Form1()
        {
            CurSuperv = new GeoSuperv();

            InitializeComponent();
        }

        private void 基本数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_MP_Bascidata f = new Frm_MP_Bascidata();
            //f.Show();
        }

        private void 地质监督计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_MP_MonitPlan f = new Frm_MP_MonitPlan();
            f.twellnum = CurWellnum;
            f.Show();

            //Frm_MP_MonitPlan f = new Frm_MP_MonitPlan();
            //f.Show();
        }

        private void 录井队伍资质ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_SA_Teamqualification f = new Frm_SA_Teamqualification();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 人员配备及证件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_SA_Staffingdocu fsa = new Frm_SA_Staffingdocu();
            //fsa.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_SA_Staffingdocu f = new Frm_SA_Staffingdocu();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 设备配备及质量评价ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_SA_Instrumenttation fas = new Frm_SA_Instrumenttation();
            //fas.Show();
        }

        private void 资料检查ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_SA_Predata fsa = new Frm_SA_Predata();
            //fsa.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_SA_Predata f = new Frm_SA_Predata();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 钻具及套管管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_PM_Drillingtool fpm = new Frm_PM_Drillingtool();
            //fpm.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_PM_Drillingtool f = new Frm_PM_Drillingtool();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 设备安装及运行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_PM_Deviceinstall fpm = new Frm_PM_Deviceinstall();
            //fpm.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_PM_Deviceinstall f = new Frm_PM_Deviceinstall();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 岩性落实ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_PM_Lithological_implementation fpm = new Frm_PM_Lithological_implementation();
            //fpm.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_PM_Lithological_implementation f = new Frm_PM_Lithological_implementation();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 地质卡层ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_PM_geological_card_layer fpm = new Frm_PM_geological_card_layer();
            //fpm.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_PM_geological_card_layer f = new Frm_PM_geological_card_layer();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 油气显示统计表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_PM_Reservoir_discovery fpm = new Frm_PM_Reservoir_discovery();
            //fpm.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_PM_Reservoir_discovery f = new Frm_PM_Reservoir_discovery();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 工程异常统计表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_PM_Engineering_warning fpm = new Frm_PM_Engineering_warning();
            //fpm.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_PM_Engineering_warning f = new Frm_PM_Engineering_warning();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 资料质量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_PM_Data_quality fpm = new Frm_PM_Data_quality();
            //fpm.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_PM_Data_quality f = new Frm_PM_Data_quality();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 录井坐岗ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 其它监督项目ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_PM_other_oversight_projects fpm = new Frm_PM_other_oversight_projects();
            //fpm.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_PM_other_oversight_projects f = new Frm_PM_other_oversight_projects();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 重点情况反映ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_PM_Key_situation_reflections f = new Frm_PM_Key_situation_reflections();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 典型案例分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_PM_Typical_case_studies fpm = new Frm_PM_Typical_case_studies();
            //fpm.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }
            
            Frm_PM_Typical_case_studies f = new Frm_PM_Typical_case_studies();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 基本数据ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_PM_Basicdata fpm = new Frm_PM_Basicdata();
            fpm.Show();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            //测试数据库连接
            //string contest = DBUtility.DbHelperSQL.connect(DbHelperSQL.connectionString);
            //if (contest != "连接成功")
            //{
            //    MessageBox.Show(contest);

            //    //退出程序
            //    this.Close();
            //    System.Environment.Exit(0);
            //}

            //初始化树形菜单
            AddTreeNodes11();

        }

        public void AddTN(TreeNode d, List<string> s)
        {
            for (int i = 0; i < s.Count; i++)
            {
                TreeNode t = new TreeNode();
                t.Text = s[i];
                t.Tag = s[i];
                d.Nodes.Add(t);
            }
        }

        private void AddTreeNodes11()
        {
            SupervDB.BLL.GeoSuperv bllwell = new SupervDB.BLL.GeoSuperv();
            string sqlwhere = " 1=1 ";//全部
            List<SupervDB.Model.GeoSuperv> twells = bllwell.GetModelList(sqlwhere);
            for (int j = 0; j < this.treeView1.Nodes.Count; j++)
            {
                TreeNode tt = this.treeView1.Nodes[j];
                tt.Nodes.Clear();
                if (tt.Tag.ToString() == "全部井")
                {
                    int tc = 0;
                    List<string> wellnums = new List<string>();
                    foreach (SupervDB.Model.GeoSuperv well in twells)
                    {
                        tc++;
                        wellnums.Add(well.Wellnum);
                    }
                    tt.Text = tt.Tag.ToString() + "(" + tc.ToString() + ")";
                    AddTN(tt, wellnums);
                }

                if (tt.Tag.ToString() == "待钻井")
                {
                    int tc = 0;
                    List<string> wellnums = new List<string>();
                    foreach (SupervDB.Model.GeoSuperv well in twells)
                    {
                        if (well.Well_state == "待钻井")
                        {
                            tc++;
                            wellnums.Add(well.Wellnum);
                        }
                    }
                    tt.Text = tt.Tag.ToString() + "(" + tc.ToString() + ")";
                    AddTN(tt, wellnums);
                }
                if (tt.Tag.ToString() == "正钻井")
                {
                    int tc = 0;
                    List<string> wellnums = new List<string>();
                    foreach (SupervDB.Model.GeoSuperv well in twells)
                    {
                        if (well.Well_state == "正钻井")
                        {
                            tc++;
                            wellnums.Add(well.Wellnum);
                        }
                    }
                    tt.Text = tt.Tag.ToString() + "(" + tc.ToString() + ")";
                    AddTN(tt, wellnums);
                }
                if (tt.Tag.ToString() == "完钻井")
                {
                    int tc = 0;
                    List<string> wellnums = new List<string>();
                    foreach (SupervDB.Model.GeoSuperv well in twells)
                    {
                        if (well.Well_state == "完钻井")
                        {
                            tc++;
                            wellnums.Add(well.Wellnum);
                        }
                    }
                    tt.Text = tt.Tag.ToString() + "(" + tc.ToString() + ")";
                    AddTN(tt, wellnums);
                }
                //if (tt.Tag.ToString() == "试油井")
                //{
                //    int tc = 0;
                //    List<string> wellnums = new List<string>();
                //    foreach (SupervDB.Model.GeoSuperv well in twells)
                //    {
                //        if (well.Well_state == "试油井")
                //        {
                //            tc++;
                //            wellnums.Add(well.Wellnum);
                //        }
                //    }
                //    tt.Text = tt.Tag.ToString() + "(" + tc.ToString() + ")";
                //    AddTN(tt, wellnums);
                //}
                //if (tt.Tag.ToString() == "报废井")
                //{
                //    int tc = 0;
                //    List<string> wellnums = new List<string>();
                //    foreach (SupervDB.Model.GeoSuperv well in twells)
                //    {
                //        if (well.Well_state == "报废井")
                //        {
                //            tc++;
                //            wellnums.Add(well.Wellnum);
                //        }
                //    }
                //    tt.Text = tt.Tag.ToString() + "(" + tc.ToString() + ")";
                //    AddTN(tt, wellnums);
                //}

            }
        }

        private void 录井坐岗ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Frm_HSE_Logging_sitting fhse = new Frm_HSE_Logging_sitting();
            //fhse.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_HSE_Logging_sitting f = new Frm_HSE_Logging_sitting();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 硫化氢传感器安装及检测ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_HSE_H2S fhse = new Frm_HSE_H2S();
            //fhse.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_HSE_H2S f = new Frm_HSE_H2S();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 安全防护设施配备及管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_HSE_Safety_protection fhse = new Frm_HSE_Safety_protection();
            //fhse.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_HSE_Safety_protection f = new Frm_HSE_Safety_protection();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 化学药品配备及管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_HSE_Chemical_preparation fhse = new Frm_HSE_Chemical_preparation();
            //fhse.Show();
        }

        private void 应急预案及演练ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_HSE_HSSD f = new Frm_HSE_HSSD();
            //f.ShowDialog();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_HSE_HSSD f = new Frm_HSE_HSSD();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 录井环境ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_HSE_Logging_environment fhse = new Frm_HSE_Logging_environment();
            //fhse.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_HSE_Logging_environment f = new Frm_HSE_Logging_environment();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 录井工作量统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void xX井基本信息数据表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_HSE_BasicdataR fhse = new Frm_HSE_BasicdataR();
            fhse.Show();
        }

        private void 监督计划书ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            FormSSSP f = new FormSSSP();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 监督日志ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
          
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            FormSSGL f = new FormSSGL();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 录井开工验收单ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }
            FormSSCA f = new FormSSCA();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 整改通知单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_RN_Rectification_notice frn = new Frm_RN_Rectification_notice();
            //frn.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }
            FormRN f = new FormRN();
            f.twellnum = CurWellnum;
            f.Show();
            
        }

        private void 整改回执单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RN_Rectification_receipt frn = new Frm_RN_Rectification_receipt();
            frn.Show();
        }

        private void 监督备忘录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_SS_Oversight_Memorandum fss = new Frm_SS_Oversight_Memorandum();
            fss.Show();
        }

        private void 录井井史ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_SS_History_of_logging_wells fss = new Frm_SS_History_of_logging_wells();
            //fss.Show();
        }

        private void 总结报告ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 发现问题统计表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }
           Forms.WellForm3 f = new Forms.WellForm3();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 综合录井仪配备ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_SA_Instrumenttation fas = new Frm_SA_Instrumenttation();
            //fas.Show();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_SA_Instrumenttation f = new Frm_SA_Instrumenttation();
            f.twellnum = CurWellnum;
            f.Show();
        }

        

        private void 脱气器配备及安装ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_SA_DEAI fsa = new Frm_SA_DEAI();
            //fsa.ShowDialog();

            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_SA_DEAI f = new Frm_SA_DEAI();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 传感器配备及安装ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_SA_SEAI fsa = new Frm_SA_SEAI();
            //fsa.ShowDialog();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_SA_SEAI f = new Frm_SA_SEAI();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 地质房设备配备ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 评价录井设备配备ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void 采集及处理软件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_SA_AAPS fsa = new Frm_SA_AAPS();
            //fsa.ShowDialog();

            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_SA_AAPS f = new Frm_SA_AAPS();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 基本数据ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            //Frm_MP_BDinfo f = new Frm_MP_BDinfo();
            //f.Show();
        }

        private void 人员变更ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_PM_logging_sitting f = new Frm_PM_logging_sitting();
            //f.ShowDialog();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

           Frm_PM_logging_sitting f = new Frm_PM_logging_sitting();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 设备变更ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_PM_Logging_sitting_02 f = new Frm_PM_Logging_sitting_02();
            //f.ShowDialog();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_PM_Logging_sitting_02 f = new Frm_PM_Logging_sitting_02();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 按进尺统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_HSE_Workload_summary f = new Frm_HSE_Workload_summary();
            //f.ShowDialog();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_HSE_Workload_summary f = new Frm_HSE_Workload_summary();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 按时间统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_HSE_Workload_summary_02 f = new Frm_HSE_Workload_summary_02();
            //f.ShowDialog();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_HSE_Workload_summary_02 f = new Frm_HSE_Workload_summary_02();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 评价录井设备配备ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Frm_SA_EOLEE f = new Frm_SA_EOLEE();
            //f.ShowDialog();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_SA_EOLEE f = new Frm_SA_EOLEE();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 地质房设备配备ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Frm_SA_GRE f = new Frm_SA_GRE();
            //f.ShowDialog();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_SA_GRE f = new Frm_SA_GRE();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 采集及处理软件ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //Frm_SA_AAPS f = new Frm_SA_AAPS();
            //f.ShowDialog();
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_SA_AAPS f = new Frm_SA_AAPS();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (treeView1.SelectedNode.Tag.ToString() == "全部井" ||
                treeView1.SelectedNode.Tag.ToString() == "待钻井" ||
                treeView1.SelectedNode.Tag.ToString() == "正钻井" ||
                treeView1.SelectedNode.Tag.ToString() == "完钻井")
            {

            }
            else
            {
                string wellnum = treeView1.SelectedNode.Text;//Tag.ToString();
                try
                {
                    if (this.Text.IndexOf(" (") > 0)
                        this.Text = this.Text.Substring(0, this.Text.IndexOf(" ("));
                    CurSuperv.Wellnum = wellnum;
                    CurWellnum = wellnum;
                    this.Text = this.Text + " (" + wellnum + ") ";

                    this.Text = this.Text + " --- 正在加载井数据，请稍等……";
                    
                    if (this.Text.IndexOf(" --- 正在") > 0)
                        this.Text = this.Text.Substring(0, this.Text.IndexOf(" --- 正在"));

                    //测试是否panel1是否会显示其它窗体
                    Forms.WellForm7 fhse = new Forms.WellForm7();
                    //Frm_HSE_BasicdataR fhse = new Frm_HSE_BasicdataR();
                    //清除panel里面的其他窗体
                    panel1.Controls.Clear();
                    //将该子窗体设置成非顶级控件
                    fhse.TopLevel = false;
                    //将该子窗体的边框去掉
                    fhse.FormBorderStyle = FormBorderStyle.None;
                    //设置子窗体随容器大小自动调整
                    fhse.Dock = DockStyle.Fill;
                    //设置mdi父容器为当前窗口
                    fhse.Parent = this.panel1;
                    fhse.StartPosition = FormStartPosition.CenterParent;
                    //子窗体显示
                    //fhse.Show();
                    if (CurWellnum == null || CurWellnum == "")
                    {
                        MessageBox.Show("请先选择井！");
                        return;
                    }
                    fhse.twellnum = CurWellnum;
                    fhse.Show();
                }
                catch
                {
                    if (this.Text.IndexOf(" --- 正在") > 0)
                        this.Text = this.Text.Substring(0, this.Text.IndexOf(" --- 正在"));
                }
            }
        }

        private void 管理用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Usermanage f = new Frm_Usermanage();
            f.ShowDialog();
        }

        private void 每日基本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }
            Frm_SA_BasicData f = new Frm_SA_BasicData();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 开工通知单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }
            FormSSCA f = new FormSSCA();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 录井井史ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }
            Frm_SS_History_of_logging_wells fss = new Frm_SS_History_of_logging_wells();
            fss.twellnum = CurWellnum;
            fss.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 监督报告附表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }
            Forms.WellForm5 f = new Forms.WellForm5();
            f.twellnum = CurWellnum;
            f.Show();
        }


        private void 基本信息数据表word导出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.WellForm7 f = new Forms.WellForm7();
            f.twellnum = CurWellnum;
            f.Save_Word();
        }

        private void 录井工作统计表进尺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.WellForm5 f = new Forms.WellForm5();
            f.twellnum = CurWellnum;
            f.Save_Word_1();
        }

        private void 录井工作统计表时间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.WellForm5 f = new Forms.WellForm5();
            f.twellnum = CurWellnum;
            f.Save_Word_2();
        }

        private void 现场问题及ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.WellForm5 f = new Forms.WellForm5();
            f.twellnum = CurWellnum;
            f.Save_Word_3();
        }

        private void 新建井号ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_MP_AddWell f = new Frm_MP_AddWell();
            f.Show();
        }

        private void 基本数据ToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_MP_BDinfo f = new Frm_MP_BDinfo();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 录井项目ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_MP_BDPro f = new Frm_MP_BDPro();
            f.twellnum = CurWellnum;
            f.Show();
        }


        private void 监督计划ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_MP_MonitPlan f = new Frm_MP_MonitPlan();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 井深结构数据ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (CurWellnum == null || CurWellnum == "")
            {
                MessageBox.Show("请先选择井！");
                return;
            }

            Frm_MP_BDStru f = new Frm_MP_BDStru();
            f.twellnum = CurWellnum;
            f.Show();
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //初始化树形菜单
            AddTreeNodes11();
        }

    }
}
