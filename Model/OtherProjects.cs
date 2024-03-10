
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// OtherProjects:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OtherProjects
	{
		public OtherProjects()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
		private string _supervision;
		private string _super_item;
		private string _checkcontent;
		private string _checkresult;
		private string _problemdes;
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
		public string Supervision
		{
			set{ _supervision=value;}
			get{return _supervision;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Super_Item
		{
			set{ _super_item=value;}
			get{return _super_item;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CheckContent
		{
			set{ _checkcontent=value;}
			get{return _checkcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CheckResult
		{
			set{ _checkresult=value;}
			get{return _checkresult;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProblemDes
		{
			set{ _problemdes=value;}
			get{return _problemdes;}
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

