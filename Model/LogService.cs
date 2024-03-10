
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// LogService:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LogService
	{
		public LogService()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
		private string _logproject;
		private DateTime? _star_logtime;
		private DateTime? _end_logtime;
		private decimal? _logpernum;
		private decimal? _logday;
		private DateTime? _savetime;
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
		public string LogProject
		{
			set{ _logproject=value;}
			get{return _logproject;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Star_LogTime
		{
			set{ _star_logtime=value;}
			get{return _star_logtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? End_LogTime
		{
			set{ _end_logtime=value;}
			get{return _end_logtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LogPerNum
		{
			set{ _logpernum=value;}
			get{return _logpernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LogDay
		{
			set{ _logday=value;}
			get{return _logday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Savetime
		{
			set{ _savetime=value;}
			get{return _savetime;}
		}
		#endregion Model

	}
}

