using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisorAssist
{
    public partial class Frm_Usermanage : Form
    {
        private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF }; //定义密钥
        public int sign;
        public Frm_Usermanage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="encryptString">待加密的字符串</param>
        /// <param name="encryptKey">加密密钥,要求为8位</param>
        /// <returns>加密成功返回加密后的字符串，失败返回源串 </returns>
        public static string EncryptDES(string encryptString, string encryptKey)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));//转换为字节
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();//实例化数据加密标准
                MemoryStream mStream = new MemoryStream();//实例化内存流
                //将数据流链接到加密转换的流
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch (Exception)
            {
                return encryptString;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Useradd f = new Frm_Useradd();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("情选择要删除的用户");
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
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Userupdata f = new Frm_Userupdata();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("请选择要恢复默认密码的用户");
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
                        gsv.Password = EncryptDES("666666", "abcdefgh");
                        //gsv.Password = "666666";
                        gsv.Username = item.Username;
                        gsv.Isstate = true;
                        gsv.Name = item.Name;
                        gsv.Creator = item.Creator;
                        gsv.Createddata = item.Createddata;
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
                    }

                }
                else
                {
                    MessageBox.Show("该账号已经失效或不存在该账号");
                }
            }
        }

        private void lodaData()
        {
            dataGridView1.Rows.Clear();
            string sqlwhere = " Isstate = '" + "1'";
            try
            {
                SupervDB.BLL.Users blws = new SupervDB.BLL.Users();
                List<SupervDB.Model.Users> lgws = blws.GetModelList(sqlwhere);

                foreach (SupervDB.Model.Users item in lgws)
                {
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView1.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }
                    //Common
                    tdr.Cells[0].Value = item.Username;
                    tdr.Cells[1].Value = item.Name;
                    tdr.Cells[2].Value = (int)DBUtility.DbHelperSQL.GetVDoule(item.Userpermission); ;
                    tdr.Cells[3].Value = item.Remark;
                    dataGridView1.Rows.Add(tdr);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_Usermanage_Load(object sender, EventArgs e)
        {
            lodaData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //当点击表头部的列时，e.RowIndex==-1
            if (e.RowIndex > -1)
            {
                this.textBox1.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.textBox2.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lodaData();
        }
    }
}
