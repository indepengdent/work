using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisorAssist
{
    static class Program
    {
        public static bool flag = false;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormSSSP());

            //测试是否从登录界面开始
            Application.Run(new Frm_Userlogon());
            if (flag == true)
            {
                Application.Run(new Form1());

            }
        }
    }
}
