
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// Staff:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Staff
	{
		public Staff()
		{}
		#region Model
		private int _id;
		private string _staname;
		private string _stanum;
		private string _yxq;
		private string _name;
		private DateTime? _updatetime;
		private string _wellnum;
		private string _wellnum_t;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StaName
		{
			set{ _staname=value;}
			get{return _staname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StaNum
		{
			set{ _stanum=value;}
			get{return _stanum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Yxq
		{
			set{ _yxq=value;}
			get{return _yxq;}
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
		public DateTime? Updatetime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
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
		public string Wellnum_t
		{
			set{ _wellnum_t=value;}
			get{return _wellnum_t;}
		}
		#endregion Model

	}
}

