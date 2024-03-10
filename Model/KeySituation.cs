
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// KeySituation:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class KeySituation
	{
		public KeySituation()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
		private string _tablename;
		private string _project;
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
		public string TableName
		{
			set{ _tablename=value;}
			get{return _tablename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string project
		{
			set{ _project=value;}
			get{return _project;}
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

