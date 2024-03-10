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
    public partial class Frm_Repassword : Form
    {
        public int sign;
        public Frm_Repassword()
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
                MessageBox.Show("用户名不可为空");
            }
            else
            {
                string sqlwhere = " Username = '" + textBox1.Text + "'";
                SupervDB.BLL.Users blws = new SupervDB.BLL.Users();
                SupervDB.Model.Users gsv = new SupervDB.Model.Users();
                List<SupervDB.Model.Users> lgws = blws.GetModelList(sqlwhere);
                sign = 0;
                foreach (SupervDB.Model.Users item in lgws)
                {
                    if (item.Isstate == true)
                    {
                        //初始默认密码
                        gsv.Password = "666666";
                        gsv.Username = item.Username;
                        gsv.Isstate = true;
                        gsv.Name = item.Name;
                        gsv.Creator = item.Creator;
                        gsv.Userpermission = item.Userpermission;
                        gsv.Remark = item.Remark;
                        sign = 1;
                        break;
                    }
                }
               
                if (sign == 1)
                {
                    if (lgws.Count > 0)
                    {
                        gsv.id = lgws[0].id;
                        blws.Update(gsv);
                        MessageBox.Show("恢复成功");
                        this.Dispose();
                    }
                    
                }
                else
                {
                    MessageBox.Show("该账号已经失效或不存在该账号");
                }
            }
        }
    }
}
