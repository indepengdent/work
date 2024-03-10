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
    public partial class Frm_SummaryReport : Form
    {
        public string twellnum;
        public Frm_SummaryReport()
        {
            InitializeComponent();
        }

        private void Frm_SummaryReport_Load(object sender, EventArgs e)
        {
            try
            {
                //测试是否会显示其它窗体
                Forms.WellForm3 f1 = new Forms.WellForm3();
                //清除panel里面的其他窗体
                this.panel1.Controls.Clear();
                //将该子窗体设置成非顶级控件
                f1.TopLevel = false;
                //将该子窗体的边框去掉
                f1.FormBorderStyle = FormBorderStyle.None;
                //设置子窗体随容器大小自动调整
                f1.Dock = DockStyle.Fill;
                //设置mdi父容器为当前窗口
                f1.Parent = this.panel1;
                f1.StartPosition = FormStartPosition.CenterParent;
                //子窗体显示
                f1.twellnum = twellnum;
                f1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                Frm_SS_Oversight_Memorandum f2 = new Frm_SS_Oversight_Memorandum();
                this.panel2.Controls.Clear();
                f2.TopLevel = false;
                //将该子窗体的边框去掉
                f2.FormBorderStyle = FormBorderStyle.None;
                //设置子窗体随容器大小自动调整
                f2.Dock = DockStyle.Fill;
                //设置mdi父容器为当前窗口
                f2.Parent = this.panel2;
                f2.StartPosition = FormStartPosition.CenterParent;
                f2.twellnum = twellnum;
                f2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //测试是否panel1是否会显示其它窗体
                Forms.WellForm7 f3 = new Forms.WellForm7();
                //清除pane3里面的其他窗体
                panel3.Controls.Clear();
                //将该子窗体设置成非顶级控件
                f3.TopLevel = false;
                //将该子窗体的边框去掉
                f3.FormBorderStyle = FormBorderStyle.None;
                //设置子窗体随容器大小自动调整
                f3.Dock = DockStyle.Fill;
                //设置mdi父容器为当前窗口
                f3.Parent = this.panel3;
                f3.StartPosition = FormStartPosition.CenterParent;
                //子窗体显示
                f3.twellnum = twellnum;
                f3.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //测试是否panel1是否会显示其它窗体
                FormSSSP f4 = new FormSSSP();
                //清除pane3里面的其他窗体
                panel4.Controls.Clear();
                //将该子窗体设置成非顶级控件
                f4.TopLevel = false;
                //将该子窗体的边框去掉
                f4.FormBorderStyle = FormBorderStyle.None;
                //设置子窗体随容器大小自动调整
                f4.Dock = DockStyle.Fill;
                //设置mdi父容器为当前窗口
                f4.Parent = this.panel4;
                f4.StartPosition = FormStartPosition.CenterParent;
                //子窗体显示
                f4.twellnum = twellnum;
                f4.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //测试是否panel1是否会显示其它窗体
                Frm_HSE_Workload_summary f5 = new Frm_HSE_Workload_summary();
                //清除pane3里面的其他窗体
                panel5.Controls.Clear();
                //将该子窗体设置成非顶级控件
                f5.TopLevel = false;
                //将该子窗体的边框去掉
                f5.FormBorderStyle = FormBorderStyle.None;
                //设置子窗体随容器大小自动调整
                f5.Dock = DockStyle.Fill;
                //设置mdi父容器为当前窗口
                f5.Parent = this.panel5;
                f5.StartPosition = FormStartPosition.CenterParent;
                //子窗体显示
                f5.twellnum = twellnum;
                f5.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                //测试是否panel6是否会显示其它窗体
                Frm_HSE_Workload_summary_02 f6 = new Frm_HSE_Workload_summary_02();
                //清除pane6里面的其他窗体
                panel6.Controls.Clear();
                //将该子窗体设置成非顶级控件
                f6.TopLevel = false;
                //将该子窗体的边框去掉
                f6.FormBorderStyle = FormBorderStyle.None;
                //设置子窗体随容器大小自动调整
                f6.Dock = DockStyle.Fill;
                //设置mdi父容器为当前窗口
                f6.Parent = this.panel6;
                f6.StartPosition = FormStartPosition.CenterParent;
                //子窗体显示
                f6.twellnum = twellnum;
                f6.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
               
        }
    }
}
