
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// RectReceipt:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class RectReceipt
	{
		public RectReceipt()
		{}
		#region Model
		private string _wellnum;
		private string _geosupervision;
		private string _rectification;
		private string _reviewconclusions;
		private string _geosupervisor;
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
		public string GeoSupervision
		{
			set{ _geosupervision=value;}
			get{return _geosupervision;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Rectification
		{
			set{ _rectification=value;}
			get{return _rectification;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReviewConclusions
		{
			set{ _reviewconclusions=value;}
			get{return _reviewconclusions;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GeoSupervisor
		{
			set{ _geosupervisor=value;}
			get{return _geosupervisor;}
		}
		#endregion Model

	}
}

