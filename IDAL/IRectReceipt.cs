
using System;
using System.Data;
namespace SupervDB.IDAL
{
	/// <summary>
	/// 接口层RectReceipt
	/// </summary>
	public interface IRectReceipt
	{
		#region  成员方法
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		bool Exists(string Wellnum);
		/// <summary>
		/// 增加一条数据
		/// </summary>
		bool Add(SupervDB.Model.RectReceipt model);
		/// <summary>
		/// 更新一条数据
		/// </summary>
		bool Update(SupervDB.Model.RectReceipt model);
		/// <summary>
		/// 删除一条数据
		/// </summary>
		bool Delete(string Wellnum);
		bool DeleteList(string Wellnumlist );
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		SupervDB.Model.RectReceipt GetModel(string Wellnum);
		SupervDB.Model.RectReceipt DataRowToModel(DataRow row);
		/// <summary>
		/// 获得数据列表
		/// </summary>
		DataSet GetList(string strWhere);
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		DataSet GetList(int Top,string strWhere,string filedOrder);
		int GetRecordCount(string strWhere);
		DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
		/// <summary>
		/// 根据分页获得数据列表
		/// </summary>
		//DataSet GetList(int PageSize,int PageIndex,string strWhere);
		#endregion  成员方法
		#region  MethodEx

		#endregion  MethodEx
	} 
}
