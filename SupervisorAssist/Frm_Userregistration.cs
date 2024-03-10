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
    public partial class Frm_Userregistration : Form
    {
        public Frm_Userregistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.Users blgs = new SupervDB.BLL.Users();
            SupervDB.Model.Users gsv = new SupervDB.Model.Users();

            gsv.Username = textBox1.Text;
            if (textBox2.Text == textBox9.Text)
            {
                gsv.Password = textBox2.Text;
            }
            else
            {
                MessageBox.Show("两次输入密码不相同!!");
            }
            DateTime nowtime = DateTime.Now;
            gsv.Createddata = nowtime;
            gsv.Name = textBox3.Text;
            gsv.Creator = textBox5.Text;
            gsv.Isstate = true;

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("必要信息不可为空");
            }
            else
            {
                string sqlw = " Isstate = '" + "1'";
                List<SupervDB.Model.Users> lgws = blgs.GetModelList(sqlw);
                if (lgws.Count > 0)
                {
                    gsv.id = lgws[0].id;
                    blgs.Update(gsv);
                }
                else
                {
                    blgs.Add(gsv);
                }
                MessageBox.Show("保存成功");
            }
        }
    }
}
