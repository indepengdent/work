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
    public partial class Frm_Userlogon : Form
    {
       //定义密钥 
        private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
        //作为检验登录账号密码正确性的标志
        public int sign;

        public Frm_Userlogon()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="decryptString">待解密的字符串</param>
        /// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
        /// <returns>解密成功返回解密后的字符串，失败返源串</returns>
        public static string DecryptDES(string decryptString, string decryptKey)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch (Exception)
            {
                //return decryptString;
                return "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            // 验证用户输入是否为空，若为空，提示用户信息
            if (textBox1.Text.Equals("")||textBox2.Text.Equals(""))
            {
                MessageBox.Show("用户名或密码不能为空！");
            }
            else
            {
                try
                {
                    //通过状态是否有效来获取有效的账号核密码信息
                    string sqlwhere = " Username = '" + textBox1.Text +"'";
                    
                    SupervDB.BLL.Users blws = new SupervDB.BLL.Users();
                    List<SupervDB.Model.Users> lgws = blws.GetModelList(sqlwhere);
                    sign = 0;
                    foreach (SupervDB.Model.Users item in lgws)
                    {
                        string decode = DecryptDES(item.Password, "abcdefgh");
                        if (textBox2.Text == decode)
                        {
                            if (item.Isstate == true)
                            {
                                sign = 1;
                                break;
                            }
                        }

                    }
                    if (sign == 1)
                    {
                        this.Dispose();
                        Program.flag = true;
                    }
                    else{
                        MessageBox.Show("账号或密码错误!");
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                    //MessageBox.Show(ex.Message);
                }
            }
           
        }

    }
}
