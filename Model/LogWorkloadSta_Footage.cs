
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// LogWorkloadSta_Footage:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class LogWorkloadSta_Footage
	{
		public LogWorkloadSta_Footage()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
		private string _logproject;
		private decimal? _start_well_depth;
		private decimal? _end_well_depth;
		private decimal? _sampleinterval;
		private decimal? _number;
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
		public string LogProject
		{
			set{ _logproject=value;}
			get{return _logproject;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Start_Well_Depth
		{
			set{ _start_well_depth=value;}
			get{return _start_well_depth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? End_Well_Depth
		{
			set{ _end_well_depth=value;}
			get{return _end_well_depth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SampleInterval
		{
			set{ _sampleinterval=value;}
			get{return _sampleinterval;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Savetime
		{
			set{ _savetime=value;}
			get{return _savetime;}
		}
		#endregion Model

	}
}

