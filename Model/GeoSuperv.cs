
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// GeoSuperv:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GeoSuperv
	{
		public GeoSuperv()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
        private string _well_state;
        private string _yt;
        private string _well_type;
		private string _well_bb;
		private string _jdname;
		private string _jdnum;
		private string _jdway;
		private string _location;
		private string _gzloc;
		private string _drillaim;
		private string _comrul;
		private decimal? _well_kb;
		private decimal? _well_hb;
		private decimal? _well_cd;
		private decimal? _well_depth;
		private decimal? _well_sd;
		private decimal? _well_cx;
		private decimal? _wzdepth;
		private decimal? _wzcd;
		private decimal? _splen;
		private decimal? _ljdepth;
		private string _mainaimlayer;
		private string _secaimlayer;
		private DateTime? _sdate;
		private DateTime? _edate;
		private DateTime? _cdate;
		private DateTime? _ljstartdate;
		private string _comsty;
		private string _welllines;
		private string _ljenddate;
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
		public string Well_state
        {
            set { _well_state = value; }
            get { return _well_state; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string YT
        {
            set { _yt = value; }
            get { return _yt; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Well_type
		{
			set{ _well_type=value;}
			get{return _well_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Well_BB
		{
			set{ _well_bb=value;}
			get{return _well_bb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JdName
		{
			set{ _jdname=value;}
			get{return _jdname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JdNum
		{
			set{ _jdnum=value;}
			get{return _jdnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JdWay
		{
			set{ _jdway=value;}
			get{return _jdway;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Location
		{
			set{ _location=value;}
			get{return _location;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GZLoc
		{
			set{ _gzloc=value;}
			get{return _gzloc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DrillAim
		{
			set{ _drillaim=value;}
			get{return _drillaim;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ComRul
		{
			set{ _comrul=value;}
			get{return _comrul;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Well_KB
		{
			set{ _well_kb=value;}
			get{return _well_kb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Well_HB
		{
			set{ _well_hb=value;}
			get{return _well_hb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Well_Cd
		{
			set{ _well_cd=value;}
			get{return _well_cd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Well_depth
		{
			set{ _well_depth=value;}
			get{return _well_depth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Well_Sd
		{
			set{ _well_sd=value;}
			get{return _well_sd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Well_CX
		{
			set{ _well_cx=value;}
			get{return _well_cx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Wzdepth
		{
			set{ _wzdepth=value;}
			get{return _wzdepth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? WzCd
		{
			set{ _wzcd=value;}
			get{return _wzcd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SpLen
		{
			set{ _splen=value;}
			get{return _splen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LjDepth
		{
			set{ _ljdepth=value;}
			get{return _ljdepth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MainAimLayer
		{
			set{ _mainaimlayer=value;}
			get{return _mainaimlayer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SecAimLayer
		{
			set{ _secaimlayer=value;}
			get{return _secaimlayer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SDate
		{
			set{ _sdate=value;}
			get{return _sdate;}
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
		public DateTime? CDate
		{
			set{ _cdate=value;}
			get{return _cdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LJStartDate
		{
			set{ _ljstartdate=value;}
			get{return _ljstartdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ComSty
		{
			set{ _comsty=value;}
			get{return _comsty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WellLines
		{
			set{ _welllines=value;}
			get{return _welllines;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LJEndDate
		{
			set{ _ljenddate=value;}
			get{return _ljenddate;}
		}
		#endregion Model

	}
}

