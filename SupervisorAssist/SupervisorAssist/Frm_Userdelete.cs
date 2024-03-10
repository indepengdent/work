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
    public partial class Frm_Userdelete : Form
    {
        public int sign;
        public Frm_Userdelete()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("要删除的用户名不可为空");
            }
            else
            {
                string sqlwhere = " Username = '" + textBox1.Text + "'";
                SupervDB.BLL.Users blws = new SupervDB.BLL.Users();
                List<SupervDB.Model.Users> lgws = blws.GetModelList(sqlwhere);
                sign = 0;
                foreach (SupervDB.Model.Users item in lgws)
                {
                        if (item.Isstate == true)
                        {
                            sign = 1;
                            break;
                        }
                }
                if (sign == 1)
                {
                    SupervDB.Model.Users gsv = new SupervDB.Model.Users();
                    gsv.id = lgws[0].id;
                    blws.Delete(gsv.id);
                }
                else
                {
                    MessageBox.Show("该账号已经失效!!!");
                }
                MessageBox.Show("删除成功");
                this.Dispose();
            }
        }
    }
}
