
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// TeamQual:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TeamQual
	{
		public TeamQual()
		{}
		#region Model
		private int _id;
		private DateTime? _updatetime;
		private string _wellnum;
		private string _logtnum;
		private string _affiliation;
		private string _qualcnum;
		private string _typeteam;
		private string _teamlevel;
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
		public string LogTNum
		{
			set{ _logtnum=value;}
			get{return _logtnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Affiliation
		{
			set{ _affiliation=value;}
			get{return _affiliation;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string QualCNum
		{
			set{ _qualcnum=value;}
			get{return _qualcnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TypeTeam
		{
			set{ _typeteam=value;}
			get{return _typeteam;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TeamLevel
		{
			set{ _teamlevel=value;}
			get{return _teamlevel;}
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

