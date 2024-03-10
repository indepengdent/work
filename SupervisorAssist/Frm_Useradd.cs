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
    public partial class Frm_Useradd : Form
    {
        private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF }; //定义密钥

        public Frm_Useradd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            catch (Exception e)
            {
                return encryptString;
            }
        }

        ///// <summary>
        ///// DES解密字符串
        ///// </summary>
        ///// <param name="decryptString">待解密的字符串</param>
        ///// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
        ///// <returns>解密成功返回解密后的字符串，失败返源串</returns>
        //public static string DecryptDES(string decryptString, string decryptKey)
        //{
        //    try
        //    {
        //        byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey);
        //        byte[] rgbIV = Keys;
        //        byte[] inputByteArray = Convert.FromBase64String(decryptString);
        //        DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
        //        MemoryStream mStream = new MemoryStream();
        //        CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
        //        cStream.Write(inputByteArray, 0, inputByteArray.Length);
        //        cStream.FlushFinalBlock();
        //        return Encoding.UTF8.GetString(mStream.ToArray());
        //    }
        //    catch (Exception e)
        //    {
        //        return decryptString;
        //    }
        //} 

        private void button3_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.Users blgs = new SupervDB.BLL.Users();
            SupervDB.Model.Users gsv = new SupervDB.Model.Users();

            gsv.Username = textBox1.Text;
            if (textBox2.Text == textBox9.Text)
            {
                //string encode = EncryptHelper.EncryptDES(str, "abcdefgh");
                //gsv.Password = textBox2.Text;
                gsv.Password = EncryptDES(textBox2.Text,"abcdefgh");
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
            string userper = comboBox1.Text;
            gsv.Userpermission = int.Parse(userper);
            gsv.Remark = textBox4.Text;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox5.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("必要信息不可为空");
            }
            else
            {
                string sqlw = " Username = '" + textBox1.Text + "'";
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
                this.Dispose();
            }
        }
    }
}
