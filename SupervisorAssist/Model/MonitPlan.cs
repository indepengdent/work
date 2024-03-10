
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// MonitPlan:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MonitPlan
	{
		public MonitPlan()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
		private string _skey;
		private string _scon;
		private string _difcou;
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
		public string Skey
		{
			set{ _skey=value;}
			get{return _skey;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SCon
		{
			set{ _scon=value;}
			get{return _scon;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DifCou
		{
			set{ _difcou=value;}
			get{return _difcou;}
		}
		#endregion Model

	}
}

