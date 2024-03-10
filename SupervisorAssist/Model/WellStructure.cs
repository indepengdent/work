
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// WellStructure:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class WellStructure
	{
		public WellStructure()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
		private string _opentime;
		private DateTime? _edate;
		private decimal? _bitdia;
		private decimal? _welldepth;
		private decimal? _tgwj;
		private decimal? _xdepth;
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
		public string OpenTime
		{
			set{ _opentime=value;}
			get{return _opentime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EDate
		{
			set{ _edate=value;}
			get{return _edate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Bitdia
		{
			set{ _bitdia=value;}
			get{return _bitdia;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Welldepth
		{
			set{ _welldepth=value;}
			get{return _welldepth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TgWj
		{
			set{ _tgwj=value;}
			get{return _tgwj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? XDepth
		{
			set{ _xdepth=value;}
			get{return _xdepth;}
		}
		#endregion Model

	}
}

