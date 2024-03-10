
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// EvalLogEquip:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class EvalLogEquip
	{
		public EvalLogEquip()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
		private string _checkproject;
		private string _checkresults;
		private string _problemdesc;
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
		public string CheckProject
		{
			set{ _checkproject=value;}
			get{return _checkproject;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CheckResults
		{
			set{ _checkresults=value;}
			get{return _checkresults;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ProblemDesc
		{
			set{ _problemdesc=value;}
			get{return _problemdesc;}
		}
		#endregion Model

	}
}

