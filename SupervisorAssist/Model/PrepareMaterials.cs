
using System;
namespace SupervDB.Model
{
	/// <summary>
	/// PrepareMaterials:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PrepareMaterials
	{
		public PrepareMaterials()
		{}
		#region Model
		private int _id;
		private string _wellnum;
		private DateTime? _updatetime;
		private string _checked;
		private bool _isadopt;
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
		public string Checked
		{
			set{ _checked=value;}
			get{return _checked;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsAdopt
		{
			set{ _isadopt=value;}
			get{return _isadopt;}
		}
		#endregion Model

	}
}

