
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// Memorandum:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Memorandum
	{
		public Memorandum()
		{}
		#region Model
		private string _wellnum;
		private string _constructunit;
		private string _descproblem;
		private string _penalties;
		private string _logteamsign;
		private string _geosupervisor;
		private DateTime? _issuetime;
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
		public string ConstructUnit
		{
			set{ _constructunit=value;}
			get{return _constructunit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DescProblem
		{
			set{ _descproblem=value;}
			get{return _descproblem;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Penalties
		{
			set{ _penalties=value;}
			get{return _penalties;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LogTeamSign
		{
			set{ _logteamsign=value;}
			get{return _logteamsign;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GeoSupervisor
		{
			set{ _geosupervisor=value;}
			get{return _geosupervisor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? IssueTime
		{
			set{ _issuetime=value;}
			get{return _issuetime;}
		}
		#endregion Model

	}
}

