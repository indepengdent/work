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
    public partial class Frm_SA_BasicData : Form
    {
        public string twellnum;
        public Frm_SA_BasicData()
        {
            InitializeComponent();
        }

        //退出
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /// <summary>
        /// 清空Panel1中所有的TextBox的值
        /// </summary>
        private void RefreshData()
        {
            foreach (Control cl in panel1.Controls)
            {
                if (cl is TextBox)
                {
                    TextBox tb = cl as TextBox;
                    tb.Text = string.Empty;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">天数</param>
        private void lodaData(int n)
        {
            RefreshData();
            if (twellnum == null || twellnum == "")
            {
                return;
            }
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("请先选择日期!");
                return;
            }
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(n);
            string starttime = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string endtime = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59";
            string sqlwhere = " Wellnum = '" + twellnum + "'" + "AND Savetime between '" + starttime + "' and '" + endtime + " '";
            //string sqlwhere = " Wellnum = '" + twellnum + "'";
            textBox2.Text = twellnum;
            try
            {
                SupervDB.BLL.BasicData blgs = new SupervDB.BLL.BasicData();
                List<SupervDB.Model.BasicData> lgsv = blgs.GetModelList(sqlwhere);

                if (lgsv.Count > 0)
                {
                    SupervDB.Model.BasicData gsv = lgsv[0];
                    textBox8.Text = gsv.Well_depth.ToString();
                    textBox9.Text = gsv.LayerBits;
                    textBox6.Text = gsv.Density.ToString();
                    textBox5.Text = gsv.Viscosity.ToString();
                    textBox10.Text = gsv.JdName;
                    textBox3.Text = gsv.LogGeologist;
                    textBox1.Text = gsv.InEngineer;
                    textBox11.Text = gsv.JdNum;
                    textBox7.Text =gsv.ManholeSection.ToString();
                    textBox12.Text =gsv.Cum_Depth.ToString();
                    textBox4.Text =gsv.PacketNum.ToString();
                    textBox13.Text =gsv.Cum_layerNum.ToString();
                       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Frm_SA_BasicData_Load(object sender, EventArgs e)
        {
            lodaData(0);
        }

        //刷新
        private void button3_Click(object sender, EventArgs e)
        {
            lodaData(0);
        }

        //保存
        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.BasicData blgs = new SupervDB.BLL.BasicData();
            SupervDB.Model.BasicData gsv = new SupervDB.Model.BasicData();
            //gsv.Wellnum = textBox1.Text;//井号，不可随便更改
            gsv.Wellnum = twellnum;
            DateTime nowtime = DateTime.Now;
            gsv.Updatetime = nowtime;
            gsv.Well_depth = (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox8.Text);
            gsv.LayerBits = textBox9.Text;
            gsv.Density = (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox6.Text);
            gsv.Viscosity= (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox5.Text);
            gsv.JdName = textBox10.Text;
            gsv.LogGeologist = textBox3.Text;
            gsv.InEngineer = textBox1.Text;
            gsv.JdNum = textBox11.Text;
            gsv.ManholeSection= (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox7.Text);
            gsv.Cum_Depth = (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox12.Text);
            gsv.PacketNum= (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox4.Text);
            gsv.Cum_layerNum= (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox13.Text);
            string sqlwhere = " Wellnum = '" + twellnum + "'"  + "AND Savetime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
            //string sqlwhere = " Wellnum = '" + twellnum +"'";
            List<SupervDB.Model.BasicData> lgsv = blgs.GetModelList(sqlwhere);
            if (lgsv.Count > 0)
            {
                gsv.ID = lgsv[0].ID;
                gsv.Savetime = lgsv[0].Savetime;//用于还原保存的初始时间
                blgs.Update(gsv);

            }
            else
            {
                gsv.Savetime = dateTimePicker1.Value;
                blgs.Add(gsv);
            }
            MessageBox.Show("保存成功");
        }

        //显示
        private void button4_Click(object sender, EventArgs e)
        {
            lodaData(0);
        }
        //上一天
        private void button5_Click(object sender, EventArgs e)
        {
            lodaData(-1);
        }
        //下一天
        private void button6_Click(object sender, EventArgs e)
        {
            lodaData(1);
        }
    }
}
