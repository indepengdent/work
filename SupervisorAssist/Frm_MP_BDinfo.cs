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
    public partial class Frm_MP_BDinfo : Form
    {
        public string twellnum;
        public Frm_MP_BDinfo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lodaData()
        {
            if (twellnum == null || twellnum == "") 
            {
                return;
            }

            string sqlwhere = " Wellnum = '" + twellnum + "'";

            try
            {
                SupervDB.BLL.GeoSuperv blgs = new SupervDB.BLL.GeoSuperv();
                List<SupervDB.Model.GeoSuperv> lgsv = blgs.GetModelList(sqlwhere);

                if (lgsv.Count > 0)
                {
                    SupervDB.Model.GeoSuperv gsv = lgsv[0];

                    textBox1.Text = gsv.Wellnum;
                    comboBox1.Text = gsv.Well_type;
                    comboBox2.Text = gsv.Well_BB;
                    //添加测试
                    comboBox4.Text = gsv.Well_state;
                    comboBox5.Text = gsv.YT;
                    textBox6.Text = gsv.JdName;
                    textBox5.Text = gsv.JdNum;
                    comboBox3.Text = gsv.JdWay;
                    textBox2.Text = gsv.Location;
                    textBox3.Text = gsv.GZLoc;
                    textBox4.Text = gsv.DrillAim;
                    textBox7.Text = gsv.ComRul;
                    //Well_CX;潮汐；
                    textBox8.Text = gsv.Well_KB.ToString();
                    textBox9.Text = gsv.Well_HB.ToString();
                    textBox10.Text = gsv.Well_Sd.ToString();
                    textBox11.Text = gsv.MainAimLayer;
                    textBox12.Text = gsv.Well_Cd.ToString();
                    textBox13.Text = gsv.Well_depth.ToString();
                    textBox14.Text = gsv.SecAimLayer;
                    textBox15.Text = gsv.SpLen.ToString();
                    //设计水平段长
                    textBox16.Text =gsv.Well_CX.ToString();
                    //SDate, LJEndDate;//开钻日期，完钻日期，完井日期，录井开始日期，录井结束日期
                    //textBox17.Text = gsv.CDate.ToString();
                    //textBox18.Text = gsv.EDate.ToString();
                    //完钻层位
                    textBox20.Text =gsv.LJEndDate;
                    textBox21.Text = gsv.WzCd.ToString();
                    textBox22.Text = gsv.Wzdepth.ToString();
                    textBox23.Text = gsv.ComSty;
                    textBox24.Text = gsv.LjDepth.ToString();
                    //textBox25.Text = gsv.LJStartDate.ToString();
                    textBox26.Text = gsv.WellLines;
                    //各项时间
                    dateTimePicker1.Text = gsv.SDate.ToString(); 
                    dateTimePicker2.Text = gsv.EDate.ToString(); 
                    dateTimePicker3.Text = gsv.CDate.ToString();
                    dateTimePicker4.Text = gsv.LJStartDate.ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Frm_MP_BDinfo_Load(object sender, EventArgs e)
        {
            string[] ts = { "大庆", "辽河", "长庆", "塔里木", "新疆", "西南", "吉林", "大港", "青海", "华北", "吐哈", "冀东", "玉门", "浙江", "煤层气", "南方", "储气库" };
            comboBox5.DataSource = ts;

            lodaData();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.GeoSuperv blgs = new SupervDB.BLL.GeoSuperv();
            SupervDB.Model.GeoSuperv gsv = new SupervDB.Model.GeoSuperv();

            //gsv.Wellnum = textBox1.Text;//井号，不可随便更改
            gsv.Wellnum = twellnum;
            DateTime nowtime = DateTime.Now;
            gsv.Updatetime = nowtime;
            gsv.Well_type = comboBox1.Text;
            gsv.Well_BB = comboBox2.Text;
            //添加测试
             gsv.JdName = textBox6.Text ;
             gsv.Well_state = comboBox4.Text;
             gsv.YT = comboBox5.Text;
             gsv.JdNum = textBox5.Text;
             gsv.JdWay = comboBox3.Text;
             gsv.Location = textBox2.Text ;
             gsv.GZLoc = textBox3.Text ;
             gsv.DrillAim = textBox4.Text;
             gsv.ComRul = textBox7.Text;
            //Well_CX;潮汐；
             gsv.Well_KB= (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox8.Text);
             gsv.Well_HB = (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox9.Text);
             gsv.Well_Sd = (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox10.Text );
             gsv.MainAimLayer = textBox11.Text;
             gsv.Well_Cd = (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox12.Text);
             gsv.Well_depth = (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox13.Text);
             gsv.SecAimLayer = textBox14.Text;
             gsv.SpLen = (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox15.Text);
            //设计水平段长
             gsv.Well_CX = (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox16.Text);
            //SDate, LJEndDate;//开钻日期，完钻日期，完井日期，录井开始日期，录井结束日期
             //gsv.CDate = DBUtility.DbHelperSQL.SaveVtime(textBox17.Text);
             //gsv.EDate = DBUtility.DbHelperSQL.SaveVtime(textBox18.Text);
            //完钻层位
            //gsv.Drilllayer = textBox20.Text ;
            gsv.LJEndDate = textBox20.Text;
            gsv.WzCd = (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox21.Text);
             gsv.Wzdepth = (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox22.Text);
             gsv.ComSty = textBox23.Text;
             gsv.LjDepth = (decimal)DBUtility.DbHelperSQL.GetVDoule(textBox24.Text);
             //gsv.LJStartDate = DBUtility.DbHelperSQL.SaveVtime(textBox25.Text);
             gsv.WellLines = textBox26.Text;

            if (dateTimePicker1.Text != "")
            {
                gsv.SDate = Convert.ToDateTime(dateTimePicker1.Text);
            }
            if (dateTimePicker2.Text != "")
            {
                gsv.EDate = Convert.ToDateTime(dateTimePicker2.Text);
            }
            if (dateTimePicker3.Text != "")
            {
                gsv.CDate = Convert.ToDateTime(dateTimePicker3.Text);
            }
            if (dateTimePicker4.Text != "")
            {
                gsv.LJStartDate = Convert.ToDateTime(dateTimePicker4.Text);
            }
            //测试用，修改
            //gsv.EDate = nowtime;
            //gsv.CDate = nowtime;
            //gsv.LJStartDate = nowtime;
            //gsv.LJEndDate = nowtime;


            string sqlwhere = " Wellnum = '" + twellnum + "'";
            List<SupervDB.Model.GeoSuperv> lgsv = blgs.GetModelList(sqlwhere);

            if (lgsv.Count > 0)
            {
                gsv.ID = lgsv[0].ID;
            }

            //主表，不可添加
            bool res = blgs.Update(gsv);
            if (res)
            {
                MessageBox.Show("保存成功");
            }
            else
            {
                MessageBox.Show("保存失败");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lodaData();
        }

    }
}
