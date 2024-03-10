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
    public partial class Frm_PM_Basicdata : Form
    {
        public string twellnum;
        public Frm_PM_Basicdata()
        {
            InitializeComponent();
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 250;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void lodaData()
        //{
        //    if (twellnum == null || twellnum == "")
        //    {
        //        return;
        //    }

        //    string sqlwhere = " Wellnum = '" + twellnum + "'";

        //    try
        //    {
        //        SupervDB.BLL.GeoSuperv blgs = new SupervDB.BLL.GeoSuperv();
        //        List<SupervDB.Model.GeoSuperv> lgsv = blgs.GetModelList(sqlwhere);

        //        if (lgsv.Count > 0)
        //        {
        //            SupervDB.Model.GeoSuperv gsv = lgsv[0];

        //            textBox1.Text = gsv.Wellnum;
        //            textBox2.Text = gsv.Well_type;
        //            textBox3.Text = gsv.Well_BB;
        //            textBox4.Text = gsv.DrillAim;
        //            textBox5.Text = gsv.JdNum;
        //            textBox6.Text = gsv.JdName;
        //            textBox7.Text = gsv.ComRul;
        //            textBox8.Text = gsv.Well_KB.ToString();
        //            textBox9.Text = gsv.Well_HB.ToString();
        //            textBox10.Text = gsv.Well_Sd.ToString();
        //            textBox11.Text = gsv.MainAimLayer;
        //            textBox12.Text = gsv.Well_Cd.ToString();
        //            textBox13.Text = gsv.Well_depth.ToString();
                    



        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //}
        private void Frm_PM_Basicdata_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
