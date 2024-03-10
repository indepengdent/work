
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// OnDataTran:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OnDataTran
	{
		public OnDataTran()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
		private string _tranformat;
		private string _transtab;
		private DateTime? _checktime;
		private string _checkresult;
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
		public string TranFormat
		{
			set{ _tranformat=value;}
			get{return _tranformat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TranStab
		{
			set{ _transtab=value;}
			get{return _transtab;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CheckTime
		{
			set{ _checktime=value;}
			get{return _checktime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CheckResult
		{
			set{ _checkresult=value;}
			get{return _checkresult;}
		}
		#endregion Model

	}
}

