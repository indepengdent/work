
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// DataAcqSoft:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DataAcqSoft
	{
		public DataAcqSoft()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
		private string _tablename;
		private string _acpsoftver;
		private string _softmanu;
		private DateTime? _softuptime;
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
		public string TableName
		{
			set{ _tablename=value;}
			get{return _tablename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AcpSoftVer
		{
			set{ _acpsoftver=value;}
			get{return _acpsoftver;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SoftManu
		{
			set{ _softmanu=value;}
			get{return _softmanu;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SoftUpTime
		{
			set{ _softuptime=value;}
			get{return _softuptime;}
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

