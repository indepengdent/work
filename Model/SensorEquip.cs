
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// SensorEquip:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SensorEquip
	{
		public SensorEquip()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
		private string _sensorname;
		private string _factorynum;
		private string _manufacturer;
		private DateTime? _datemanu;
		private string _checkresults;
		private string _isstandard;
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
		public string SensorName
		{
			set{ _sensorname=value;}
			get{return _sensorname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FactoryNum
		{
			set{ _factorynum=value;}
			get{return _factorynum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Manufacturer
		{
			set{ _manufacturer=value;}
			get{return _manufacturer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? DateManu
		{
			set{ _datemanu=value;}
			get{return _datemanu;}
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
		public string IsStandard
		{
			set{ _isstandard=value;}
			get{return _isstandard;}
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

