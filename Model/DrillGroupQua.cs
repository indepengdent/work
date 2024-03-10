
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// DrillGroupQua:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class DrillGroupQua
	{
		public DrillGroupQua()
		{}
		#region Model
		private int _id;
		private string _logfactory;
		private string _lfsample;
		private string _glognum;
		private string _gzznum;
		private string _gzzlevel;
		private DateTime? _gzzvali;
		private string _ylognum;
		private string _yzznum;
		private DateTime? _yzzvali;
		private string _grouptype;
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
		public string LogFactory
		{
			set{ _logfactory=value;}
			get{return _logfactory;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LFSample
		{
			set{ _lfsample=value;}
			get{return _lfsample;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GLogNum
		{
			set{ _glognum=value;}
			get{return _glognum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GZZnum
		{
			set{ _gzznum=value;}
			get{return _gzznum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GZZlevel
		{
			set{ _gzzlevel=value;}
			get{return _gzzlevel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? GZZvali
		{
			set{ _gzzvali=value;}
			get{return _gzzvali;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YLogNum
		{
			set{ _ylognum=value;}
			get{return _ylognum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YZZnum
		{
			set{ _yzznum=value;}
			get{return _yzznum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? YZZvali
		{
			set{ _yzzvali=value;}
			get{return _yzzvali;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GroupType
		{
			set{ _grouptype=value;}
			get{return _grouptype;}
		}
		#endregion Model

	}
}

