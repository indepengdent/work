
using System;
using System.Data;
using System.Collections.Generic;
using Common;
using SupervDB.Model;
using SupervDB.DALFactory;
using SupervDB.IDAL;
namespace SupervDB.BLL
{
	/// <summary>
	/// NoticeRect
	/// </summary>
	public partial class NoticeRect
	{
		private readonly INoticeRect dal=DataAccess.CreateNoticeRect();
		public NoticeRect()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Wellnum)
		{
			return dal.Exists(Wellnum);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SupervDB.Model.NoticeRect model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SupervDB.Model.NoticeRect model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string Wellnum)
		{
			
			return dal.Delete(Wellnum);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Wellnumlist )
		{
			return dal.DeleteList(Wellnumlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SupervDB.Model.NoticeRect GetModel(string Wellnum)
		{
			
			return dal.GetModel(Wellnum);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public SupervDB.Model.NoticeRect GetModelByCache(string Wellnum)
		{
			
			string CacheKey = "NoticeRectModel-" + Wellnum;
			object objModel = Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(Wellnum);
					if (objModel != null)
					{
						int ModelCache = Common.ConfigHelper.GetConfigInt("ModelCache");
						Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (SupervDB.Model.NoticeRect)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SupervDB.Model.NoticeRect> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SupervDB.Model.NoticeRect> DataTableToList(DataTable dt)
		{
			List<SupervDB.Model.NoticeRect> modelList = new List<SupervDB.Model.NoticeRect>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				SupervDB.Model.NoticeRect model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

