using System;
using System.Text;
using System.Security.Cryptography;
namespace Common.DEncrypt
{
	/// <summary>
	/// 得到随机安全码（哈希加密）。
	/// </summary>
	public class HashEncode
	{
		public HashEncode()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		/// <summary>
		/// 得到随机哈希加密字符串
		/// </summary>
		/// <returns></returns>
		public static string GetSecurity()
		{			
			string Security = HashEncoding(GetRandomValue());		
			return Security;
		}
		/// <summary>
		/// 得到一个随机数值
		/// </summary>
		/// <returns></returns>
		public static string GetRandomValue()
		{			
			Random Seed = new Random();
			string RandomVaule = Seed.Next(1, int.MaxValue).ToString();
			return RandomVaule;
		}
		/// <summary>
		/// 哈希加密一个字符串
		/// </summary>
		/// <param name="Security"></param>
		/// <returns></returns>
		public static string HashEncoding(string Security)
		{						
			byte[] Value;
			UnicodeEncoding Code = new UnicodeEncoding();
			byte[] Message = Code.GetBytes(Security);
			SHA512Managed Arithmetic = new SHA512Managed();
			Value = Arithmetic.ComputeHash(Message);
			Security = "";
			foreach(byte o in Value)
			{
				Security += (int) o + "O";
			}
			return Security;
		}


        /// <summary>
        /// 包含小写字母
        /// </summary>
        private static readonly string REG_CONTAIN_LOWERCASE_ASSERTION =
            @"(?=.*[a-z])";

        /// <summary>
        /// 包含大写字母
        /// </summary>
        private static readonly string REG_CONTAIN_UPPERCASE_ASSERTION =
            @"(?=.*[A-Z])";

        /// <summary>
        /// 包含数字
        /// </summary>
        private static readonly string REG_CONTAIN_DIGIT_ASSERTION =
            @"(?=.*\d)";

        /// <summary>
        /// 包含特殊字符(https://www.owasp.org/index.php/Password_special_characters)
        /// </summary>
        private static readonly string REG_CONTAIN_SPECIAL_CHAR_ASSERTION =
            @"(?=.*[ !""#$%&'()*+,-./:;<=>?@\[\]\^_`{|}~])";

        //public static readonly string PASSWORD_STRENGTH_1 =
        //    $"{REG_CONTAIN_LOWERCASE_ASSERTION}" + 
        //    $"{REG_CONTAIN_UPPERCASE_ASSERTION}" + 
        //    $"{REG_CONTAIN_DIGIT_ASSERTION}" + 
        //    $"{REG_CONTAIN_SPECIAL_CHAR_ASSERTION}" +
        //    @"^.{8,32}$";

        /// <summary>
        /// PASSWORD_STRENGTH_1 的另一种写法
        /// </summary>
        private static readonly string PASSWORD_STRENGTH_2 = @"(?=(.*[a-z]))(?=(.*[A-Z]))(?=(.*\d))(?=(.*[ !""#$%&'()*+,-./:;<=>?@\[\]\^_`{|}~]))^.{12,32}$";

        public static bool TestPattern(string input)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(PASSWORD_STRENGTH_2);
            return regex.IsMatch(input);
        }
        //public static void TestPattern(string pattern, string input)
        //{
        //    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(pattern);
        //    //Console.WriteLine(regex.IsMatch(input));
        //}
	}
}
