
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// CWell:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CWell
	{
		public CWell()
		{}
		#region Model
		private string _yt;
		private string _well_state;
		private DateTime? _sq_date;
		private DateTime? _sc_date;
		private string _scfs;
		private string _well_x;
		private string _well_y;
		private string _well_jwx;
		private string _well_jwy;
		private string _well_bx;
		private string _well_by;
		private string _well_jwbx;
		private string _well_jwby;
		private decimal? _pldeg;
		private decimal? _pldis;
		private decimal? _zbcdepth;
		private decimal? _totspdis;
		private decimal? _bdis;
		private decimal? _maxjx;
		private decimal? _fwei;
		private decimal? _atdep;
		private string _welllins;
		private decimal? _tolinsdis;
		private decimal? _tolinsdeg;
		private string _deslayername;
		private string _comlayername;
		private string _aimlayer;
		private int? _lb;
		private decimal? _well_kb;
		private decimal? _well_hb;
		private decimal? _well_cd;
		private decimal? _well_depth;
		private decimal? _well_sd;
		private decimal? _well_cx;
		private string _well_bb;
		private string _well_type;
		private string _well_ds;
		private string _wellnum;
		private string _wellname;
		private string _buildf;
		private string _location;
		private string _gzloc;
		private string _logloc;
		private string _drillaim;
		private string _comrul;
		private DateTime? _sdate;
		private DateTime? _edate;
		private DateTime? _cdate;
		private string _comsty;
		private DateTime? _updatetime;
		private string _well_bx1;
		private string _well_by1;
		private string _well_jwbx1;
		private string _well_jwby1;
		private decimal? _bx_xs;
		private decimal? _bx_cs;
		private decimal? _bx_bxj;
		private decimal? _bx_xs1;
		private decimal? _bx_cs1;
		private decimal? _bx_bxj1;
		private decimal? _sum_sp;
		private decimal? _well_bhdeg;
		private decimal? _length_sp;
		private decimal? _max_jx;
		private string _bz;
		private string _jjxd;
		private string _sjzq;
		private string _wellnum_t;
		private string _wellnumandt;
		private decimal? _zqmxv;
		private string _projectteam;
		private string _loggingcompany;
		private decimal? _comdepth;
		private decimal? _hcdepth;
		private DateTime? _hctime;
		private string _logtechnology;
		private DateTime? _ljstartdate;
		private DateTime? _ljenddate;
		/// <summary>
		/// 
		/// </summary>
		public string YT
		{
			set{ _yt=value;}
			get{return _yt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Well_State
		{
			set{ _well_state=value;}
			get{return _well_state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SQ_date
		{
			set{ _sq_date=value;}
			get{return _sq_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SC_Date
		{
			set{ _sc_date=value;}
			get{return _sc_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SCFS
		{
			set{ _scfs=value;}
			get{return _scfs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Well_X
		{
			set{ _well_x=value;}
			get{return _well_x;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Well_Y
		{
			set{ _well_y=value;}
			get{return _well_y;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Well_Jwx
		{
			set{ _well_jwx=value;}
			get{return _well_jwx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Well_Jwy
		{
			set{ _well_jwy=value;}
			get{return _well_jwy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Well_Bx
		{
			set{ _well_bx=value;}
			get{return _well_bx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Well_By
		{
			set{ _well_by=value;}
			get{return _well_by;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Well_JwBx
		{
			set{ _well_jwbx=value;}
			get{return _well_jwbx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Well_JwBy
		{
			set{ _well_jwby=value;}
			get{return _well_jwby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Pldeg
		{
			set{ _pldeg=value;}
			get{return _pldeg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Pldis
		{
			set{ _pldis=value;}
			get{return _pldis;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Zbcdepth
		{
			set{ _zbcdepth=value;}
			get{return _zbcdepth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Totspdis
		{
			set{ _totspdis=value;}
			get{return _totspdis;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Bdis
		{
			set{ _bdis=value;}
			get{return _bdis;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? MaxJX
		{
			set{ _maxjx=value;}
			get{return _maxjx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Fwei
		{
			set{ _fwei=value;}
			get{return _fwei;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AtDep
		{
			set{ _atdep=value;}
			get{return _atdep;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Welllins
		{
			set{ _welllins=value;}
			get{return _welllins;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TolinsDis
		{
			set{ _tolinsdis=value;}
			get{return _tolinsdis;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? TolinsDeg
		{
			set{ _tolinsdeg=value;}
			get{return _tolinsdeg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string DesLayerName
		{
			set{ _deslayername=value;}
			get{return _deslayername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ComLayerName
		{
			set{ _comlayername=value;}
			get{return _comlayername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AimLayer
		{
			set{ _aimlayer=value;}
			get{return _aimlayer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? LB
		{
			set{ _lb=value;}
			get{return _lb;}
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
		public string Well_BB
		{
			set{ _well_bb=value;}
			get{return _well_bb;}
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
		public string Well_DS
		{
			set{ _well_ds=value;}
			get{return _well_ds;}
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
		public string Wellname
		{
			set{ _wellname=value;}
			get{return _wellname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BuildF
		{
			set{ _buildf=value;}
			get{return _buildf;}
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
		public string LogLoc
		{
			set{ _logloc=value;}
			get{return _logloc;}
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
		public string ComSty
		{
			set{ _comsty=value;}
			get{return _comsty;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Well_Bx1
		{
			set{ _well_bx1=value;}
			get{return _well_bx1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Well_By1
		{
			set{ _well_by1=value;}
			get{return _well_by1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Well_JwBx1
		{
			set{ _well_jwbx1=value;}
			get{return _well_jwbx1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Well_JwBy1
		{
			set{ _well_jwby1=value;}
			get{return _well_jwby1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Bx_Xs
		{
			set{ _bx_xs=value;}
			get{return _bx_xs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Bx_Cs
		{
			set{ _bx_cs=value;}
			get{return _bx_cs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Bx_Bxj
		{
			set{ _bx_bxj=value;}
			get{return _bx_bxj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Bx_Xs1
		{
			set{ _bx_xs1=value;}
			get{return _bx_xs1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Bx_Cs1
		{
			set{ _bx_cs1=value;}
			get{return _bx_cs1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Bx_Bxj1
		{
			set{ _bx_bxj1=value;}
			get{return _bx_bxj1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Sum_SP
		{
			set{ _sum_sp=value;}
			get{return _sum_sp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Well_BHDeg
		{
			set{ _well_bhdeg=value;}
			get{return _well_bhdeg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Length_SP
		{
			set{ _length_sp=value;}
			get{return _length_sp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Max_JX
		{
			set{ _max_jx=value;}
			get{return _max_jx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ
		{
			set{ _bz=value;}
			get{return _bz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JJXD
		{
			set{ _jjxd=value;}
			get{return _jjxd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SJZQ
		{
			set{ _sjzq=value;}
			get{return _sjzq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Wellnum_t
		{
			set{ _wellnum_t=value;}
			get{return _wellnum_t;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WellnumAndt
		{
			set{ _wellnumandt=value;}
			get{return _wellnumandt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ZQmxV
		{
			set{ _zqmxv=value;}
			get{return _zqmxv;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Projectteam
		{
			set{ _projectteam=value;}
			get{return _projectteam;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Loggingcompany
		{
			set{ _loggingcompany=value;}
			get{return _loggingcompany;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ComDepth
		{
			set{ _comdepth=value;}
			get{return _comdepth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? HCDepth
		{
			set{ _hcdepth=value;}
			get{return _hcdepth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? HCTime
		{
			set{ _hctime=value;}
			get{return _hctime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LogTechnology
		{
			set{ _logtechnology=value;}
			get{return _logtechnology;}
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
		public DateTime? LJEndDate
		{
			set{ _ljenddate=value;}
			get{return _ljenddate;}
		}
		#endregion Model

	}
}

