
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// LogProjects:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LogProjects
	{
		public LogProjects()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
		private string _proname;
		private bool _isadopt;
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
		public string proname
		{
			set{ _proname=value;}
			get{return _proname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsAdopt
		{
			set{ _isadopt=value;}
			get{return _isadopt;}
		}
		#endregion Model

	}
}

