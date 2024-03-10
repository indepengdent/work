
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// StaffDocu:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class StaffDocu
	{
		public StaffDocu()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
		private string _num;
		private string _name;
		private string _workplace;
		private string _jobtitle;
		private string _jobnum;
		private string _joblevel;
		private string _wellconcert;
		private string _hs2cert;
		private string _hsecert;
		private string _fivescert;
		private string _checkresults;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Wellnum
		{
			set{ _wellnum=value;}
			get{return _wellnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Updatetime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Num
		{
			set{ _num=value;}
			get{return _num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WorkPlace
		{
			set{ _workplace=value;}
			get{return _workplace;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JobTitle
		{
			set{ _jobtitle=value;}
			get{return _jobtitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JobNum
		{
			set{ _jobnum=value;}
			get{return _jobnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JobLevel
		{
			set{ _joblevel=value;}
			get{return _joblevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WellConcert
		{
			set{ _wellconcert=value;}
			get{return _wellconcert;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HS2Cert
		{
			set{ _hs2cert=value;}
			get{return _hs2cert;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HSECert
		{
			set{ _hsecert=value;}
			get{return _hsecert;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FiveSCert
		{
			set{ _fivescert=value;}
			get{return _fivescert;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CheckResults
		{
			set{ _checkresults=value;}
			get{return _checkresults;}
		}
		#endregion Model

	}
}

