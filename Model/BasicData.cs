
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// BasicData:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BasicData
	{
		public BasicData()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
		private decimal? _well_depth;
		private string _layerbits;
		private decimal? _density;
		private decimal? _viscosity;
		private string _jdname;
		private string _jdnum;
		private string _loggeologist;
		private string _inengineer;
		private decimal? _manholesection;
		private decimal? _packetnum;
		private decimal? _cum_depth;
		private decimal? _cum_layernum;
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
		public DateTime? Savetime
        {
            set { _savetime = value; }
            get { return _savetime; }
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
		public string LayerBits
		{
			set{ _layerbits=value;}
			get{return _layerbits;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Density
		{
			set{ _density=value;}
			get{return _density;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Viscosity
		{
			set{ _viscosity=value;}
			get{return _viscosity;}
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
		public string LogGeologist
		{
			set{ _loggeologist=value;}
			get{return _loggeologist;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string InEngineer
		{
			set{ _inengineer=value;}
			get{return _inengineer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? ManholeSection
		{
			set{ _manholesection=value;}
			get{return _manholesection;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? PacketNum
		{
			set{ _packetnum=value;}
			get{return _packetnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Cum_Depth
		{
			set{ _cum_depth=value;}
			get{return _cum_depth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Cum_layerNum
		{
			set{ _cum_layernum=value;}
			get{return _cum_layernum;}
		}
		#endregion Model

	}
}

