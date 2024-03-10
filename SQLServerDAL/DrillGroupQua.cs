
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SupervDB.IDAL;
using DBUtility;//Please add references
namespace SupervDB.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:DrillGroupQua
	/// </summary>
	public partial class DrillGroupQua:IDrillGroupQua
	{
		public DrillGroupQua()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "DrillGroupQua"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DrillGroupQua");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SupervDB.Model.DrillGroupQua model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DrillGroupQua(");
			strSql.Append("LogFactory,LFSample,GLogNum,GZZnum,GZZlevel,GZZvali,YLogNum,YZZnum,YZZvali,GroupType)");
			strSql.Append(" values (");
			strSql.Append("@LogFactory,@LFSample,@GLogNum,@GZZnum,@GZZlevel,@GZZvali,@YLogNum,@YZZnum,@YZZvali,@GroupType)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@LogFactory", SqlDbType.VarChar,255),
					new SqlParameter("@LFSample", SqlDbType.VarChar,255),
					new SqlParameter("@GLogNum", SqlDbType.VarChar,255),
					new SqlParameter("@GZZnum", SqlDbType.VarChar,255),
					new SqlParameter("@GZZlevel", SqlDbType.VarChar,255),
					new SqlParameter("@GZZvali", SqlDbType.DateTime),
					new SqlParameter("@YLogNum", SqlDbType.VarChar,255),
					new SqlParameter("@YZZnum", SqlDbType.VarChar,255),
					new SqlParameter("@YZZvali", SqlDbType.DateTime),
					new SqlParameter("@GroupType", SqlDbType.VarChar,255)};
			parameters[0].Value = model.LogFactory;
			parameters[1].Value = model.LFSample;
			parameters[2].Value = model.GLogNum;
			parameters[3].Value = model.GZZnum;
			parameters[4].Value = model.GZZlevel;
			parameters[5].Value = model.GZZvali;
			parameters[6].Value = model.YLogNum;
			parameters[7].Value = model.YZZnum;
			parameters[8].Value = model.YZZvali;
			parameters[9].Value = model.GroupType;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SupervDB.Model.DrillGroupQua model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DrillGroupQua set ");
			strSql.Append("LogFactory=@LogFactory,");
			strSql.Append("LFSample=@LFSample,");
			strSql.Append("GLogNum=@GLogNum,");
			strSql.Append("GZZnum=@GZZnum,");
			strSql.Append("GZZlevel=@GZZlevel,");
			strSql.Append("GZZvali=@GZZvali,");
			strSql.Append("YLogNum=@YLogNum,");
			strSql.Append("YZZnum=@YZZnum,");
			strSql.Append("YZZvali=@YZZvali,");
			strSql.Append("GroupType=@GroupType");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@LogFactory", SqlDbType.VarChar,255),
					new SqlParameter("@LFSample", SqlDbType.VarChar,255),
					new SqlParameter("@GLogNum", SqlDbType.VarChar,255),
					new SqlParameter("@GZZnum", SqlDbType.VarChar,255),
					new SqlParameter("@GZZlevel", SqlDbType.VarChar,255),
					new SqlParameter("@GZZvali", SqlDbType.DateTime),
					new SqlParameter("@YLogNum", SqlDbType.VarChar,255),
					new SqlParameter("@YZZnum", SqlDbType.VarChar,255),
					new SqlParameter("@YZZvali", SqlDbType.DateTime),
					new SqlParameter("@GroupType", SqlDbType.VarChar,255),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.LogFactory;
			parameters[1].Value = model.LFSample;
			parameters[2].Value = model.GLogNum;
			parameters[3].Value = model.GZZnum;
			parameters[4].Value = model.GZZlevel;
			parameters[5].Value = model.GZZvali;
			parameters[6].Value = model.YLogNum;
			parameters[7].Value = model.YZZnum;
			parameters[8].Value = model.YZZvali;
			parameters[9].Value = model.GroupType;
			parameters[10].Value = model.id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DrillGroupQua ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from DrillGroupQua ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SupervDB.Model.DrillGroupQua GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,LogFactory,LFSample,GLogNum,GZZnum,GZZlevel,GZZvali,YLogNum,YZZnum,YZZvali,GroupType from DrillGroupQua ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			SupervDB.Model.DrillGroupQua model=new SupervDB.Model.DrillGroupQua();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SupervDB.Model.DrillGroupQua DataRowToModel(DataRow row)
		{
			SupervDB.Model.DrillGroupQua model=new SupervDB.Model.DrillGroupQua();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["LogFactory"]!=null)
				{
					model.LogFactory=row["LogFactory"].ToString();
				}
				if(row["LFSample"]!=null)
				{
					model.LFSample=row["LFSample"].ToString();
				}
				if(row["GLogNum"]!=null)
				{
					model.GLogNum=row["GLogNum"].ToString();
				}
				if(row["GZZnum"]!=null)
				{
					model.GZZnum=row["GZZnum"].ToString();
				}
				if(row["GZZlevel"]!=null)
				{
					model.GZZlevel=row["GZZlevel"].ToString();
				}
				if(row["GZZvali"]!=null && row["GZZvali"].ToString()!="")
				{
					model.GZZvali=DateTime.Parse(row["GZZvali"].ToString());
				}
				if(row["YLogNum"]!=null)
				{
					model.YLogNum=row["YLogNum"].ToString();
				}
				if(row["YZZnum"]!=null)
				{
					model.YZZnum=row["YZZnum"].ToString();
				}
				if(row["YZZvali"]!=null && row["YZZvali"].ToString()!="")
				{
					model.YZZvali=DateTime.Parse(row["YZZvali"].ToString());
				}
				if(row["GroupType"]!=null)
				{
					model.GroupType=row["GroupType"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,LogFactory,LFSample,GLogNum,GZZnum,GZZlevel,GZZvali,YLogNum,YZZnum,YZZvali,GroupType ");
			strSql.Append(" FROM DrillGroupQua ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" id,LogFactory,LFSample,GLogNum,GZZnum,GZZlevel,GZZvali,YLogNum,YZZnum,YZZvali,GroupType ");
			strSql.Append(" FROM DrillGroupQua ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM DrillGroupQua ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from DrillGroupQua T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "DrillGroupQua";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

