
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SupervDB.IDAL;
using DBUtility;//Please add references
namespace SupervDB.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Staff
	/// </summary>
	public partial class Staff:IStaff
	{
		public Staff()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "Staff"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Staff");
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
		public int Add(SupervDB.Model.Staff model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Staff(");
			strSql.Append("StaName,StaNum,Yxq,Name,Updatetime,Wellnum,Wellnum_t)");
			strSql.Append(" values (");
			strSql.Append("@StaName,@StaNum,@Yxq,@Name,@Updatetime,@Wellnum,@Wellnum_t)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@StaName", SqlDbType.NVarChar,50),
					new SqlParameter("@StaNum", SqlDbType.NVarChar,50),
					new SqlParameter("@Yxq", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Wellnum_t", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.StaName;
			parameters[1].Value = model.StaNum;
			parameters[2].Value = model.Yxq;
			parameters[3].Value = model.Name;
			parameters[4].Value = model.Updatetime;
			parameters[5].Value = model.Wellnum;
			parameters[6].Value = model.Wellnum_t;

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
		public bool Update(SupervDB.Model.Staff model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Staff set ");
			strSql.Append("StaName=@StaName,");
			strSql.Append("StaNum=@StaNum,");
			strSql.Append("Yxq=@Yxq,");
			strSql.Append("Name=@Name,");
			strSql.Append("Updatetime=@Updatetime,");
			strSql.Append("Wellnum=@Wellnum,");
			strSql.Append("Wellnum_t=@Wellnum_t");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@StaName", SqlDbType.NVarChar,50),
					new SqlParameter("@StaNum", SqlDbType.NVarChar,50),
					new SqlParameter("@Yxq", SqlDbType.NVarChar,50),
					new SqlParameter("@Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Wellnum_t", SqlDbType.NVarChar,50),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.StaName;
			parameters[1].Value = model.StaNum;
			parameters[2].Value = model.Yxq;
			parameters[3].Value = model.Name;
			parameters[4].Value = model.Updatetime;
			parameters[5].Value = model.Wellnum;
			parameters[6].Value = model.Wellnum_t;
			parameters[7].Value = model.id;

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
			strSql.Append("delete from Staff ");
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
			strSql.Append("delete from Staff ");
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
		public SupervDB.Model.Staff GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 id,StaName,StaNum,Yxq,Name,Updatetime,Wellnum,Wellnum_t from Staff ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			SupervDB.Model.Staff model=new SupervDB.Model.Staff();
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
		public SupervDB.Model.Staff DataRowToModel(DataRow row)
		{
			SupervDB.Model.Staff model=new SupervDB.Model.Staff();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["StaName"]!=null)
				{
					model.StaName=row["StaName"].ToString();
				}
				if(row["StaNum"]!=null)
				{
					model.StaNum=row["StaNum"].ToString();
				}
				if(row["Yxq"]!=null)
				{
					model.Yxq=row["Yxq"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Updatetime"]!=null && row["Updatetime"].ToString()!="")
				{
					model.Updatetime=DateTime.Parse(row["Updatetime"].ToString());
				}
				if(row["Wellnum"]!=null)
				{
					model.Wellnum=row["Wellnum"].ToString();
				}
				if(row["Wellnum_t"]!=null)
				{
					model.Wellnum_t=row["Wellnum_t"].ToString();
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
			strSql.Append("select id,StaName,StaNum,Yxq,Name,Updatetime,Wellnum,Wellnum_t ");
			strSql.Append(" FROM Staff ");
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
			strSql.Append(" id,StaName,StaNum,Yxq,Name,Updatetime,Wellnum,Wellnum_t ");
			strSql.Append(" FROM Staff ");
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
			strSql.Append("select count(1) FROM Staff ");
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
			strSql.Append(")AS Row, T.*  from Staff T ");
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
			parameters[0].Value = "Staff";
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

