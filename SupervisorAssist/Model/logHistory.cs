
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// LogHistory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LogHistory
	{
		public LogHistory()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
		private int? _lognum;
		private DateTime? _logtime;
		private decimal? _log_height;
		private string _condition;
		private string _conditiondesc;
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
		public int? Lognum
		{
			set{ _lognum=value;}
			get{return _lognum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Logtime
		{
			set{ _logtime=value;}
			get{return _logtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Log_height
		{
			set{ _log_height=value;}
			get{return _log_height;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Condition
		{
			set{ _condition=value;}
			get{return _condition;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Conditiondesc
		{
			set{ _conditiondesc=value;}
			get{return _conditiondesc;}
		}
		#endregion Model

	}
}

