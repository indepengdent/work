
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// NoticeRect:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NoticeRect
	{
		public NoticeRect()
		{}
		#region Model
		private string _wellnum;
		private string _constructunit;
		private DateTime? _releasetime;
		private string _problems;
		private string _requirements;
		private string _geosupervisor;
		private string _constructsign;
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
		public DateTime? ReleaseTime
		{
			set{ _releasetime=value;}
			get{return _releasetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Problems
		{
			set{ _problems=value;}
			get{return _problems;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Requirements
		{
			set{ _requirements=value;}
			get{return _requirements;}
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
		public string ConstructSign
		{
			set{ _constructsign=value;}
			get{return _constructsign;}
		}
		#endregion Model

	}
}

