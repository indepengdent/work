
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SupervDB.IDAL;
using DBUtility;//Please add references
namespace SupervDB.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:LogWells_SitDuty
	/// </summary>
	public partial class LogWells_SitDuty:ILogWells_SitDuty
	{
		public LogWells_SitDuty()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "LogWells_SitDuty"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from LogWells_SitDuty");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(SupervDB.Model.LogWells_SitDuty model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into LogWells_SitDuty(");
			strSql.Append("Wellnum,Updatetime,TableName,CheckProject,CheckResults,ProblemDesc,Savetime)");
			strSql.Append(" values (");
			strSql.Append("@Wellnum,@Updatetime,@TableName,@CheckProject,@CheckResults,@ProblemDesc,@Savetime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,255),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@TableName", SqlDbType.NVarChar,255),
					new SqlParameter("@CheckProject", SqlDbType.NVarChar,255),
					new SqlParameter("@CheckResults", SqlDbType.NVarChar,255),
					new SqlParameter("@ProblemDesc", SqlDbType.NVarChar,255),
					new SqlParameter("@Savetime", SqlDbType.DateTime)};
			parameters[0].Value = model.Wellnum;
			parameters[1].Value = model.Updatetime;
			parameters[2].Value = model.TableName;
			parameters[3].Value = model.CheckProject;
			parameters[4].Value = model.CheckResults;
			parameters[5].Value = model.ProblemDesc;
			parameters[6].Value = model.Savetime;

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
		public bool Update(SupervDB.Model.LogWells_SitDuty model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update LogWells_SitDuty set ");
			strSql.Append("Wellnum=@Wellnum,");
			strSql.Append("Updatetime=@Updatetime,");
			strSql.Append("TableName=@TableName,");
			strSql.Append("CheckProject=@CheckProject,");
			strSql.Append("CheckResults=@CheckResults,");
			strSql.Append("ProblemDesc=@ProblemDesc,");
			strSql.Append("Savetime=@Savetime");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,255),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@TableName", SqlDbType.NVarChar,255),
					new SqlParameter("@CheckProject", SqlDbType.NVarChar,255),
					new SqlParameter("@CheckResults", SqlDbType.NVarChar,255),
					new SqlParameter("@ProblemDesc", SqlDbType.NVarChar,255),
					new SqlParameter("@Savetime", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Wellnum;
			parameters[1].Value = model.Updatetime;
			parameters[2].Value = model.TableName;
			parameters[3].Value = model.CheckProject;
			parameters[4].Value = model.CheckResults;
			parameters[5].Value = model.ProblemDesc;
			parameters[6].Value = model.Savetime;
			parameters[7].Value = model.ID;

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
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LogWells_SitDuty ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from LogWells_SitDuty ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
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
		public SupervDB.Model.LogWells_SitDuty GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Wellnum,Updatetime,TableName,CheckProject,CheckResults,ProblemDesc,Savetime from LogWells_SitDuty ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			SupervDB.Model.LogWells_SitDuty model=new SupervDB.Model.LogWells_SitDuty();
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
		public SupervDB.Model.LogWells_SitDuty DataRowToModel(DataRow row)
		{
			SupervDB.Model.LogWells_SitDuty model=new SupervDB.Model.LogWells_SitDuty();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Wellnum"]!=null)
				{
					model.Wellnum=row["Wellnum"].ToString();
				}
				if(row["Updatetime"]!=null && row["Updatetime"].ToString()!="")
				{
					model.Updatetime=DateTime.Parse(row["Updatetime"].ToString());
				}
				if(row["TableName"]!=null)
				{
					model.TableName=row["TableName"].ToString();
				}
				if(row["CheckProject"]!=null)
				{
					model.CheckProject=row["CheckProject"].ToString();
				}
				if(row["CheckResults"]!=null)
				{
					model.CheckResults=row["CheckResults"].ToString();
				}
				if(row["ProblemDesc"]!=null)
				{
					model.ProblemDesc=row["ProblemDesc"].ToString();
				}
				if(row["Savetime"]!=null && row["Savetime"].ToString()!="")
				{
					model.Savetime=DateTime.Parse(row["Savetime"].ToString());
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
			strSql.Append("select ID,Wellnum,Updatetime,TableName,CheckProject,CheckResults,ProblemDesc,Savetime ");
			strSql.Append(" FROM LogWells_SitDuty ");
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
			strSql.Append(" ID,Wellnum,Updatetime,TableName,CheckProject,CheckResults,ProblemDesc,Savetime ");
			strSql.Append(" FROM LogWells_SitDuty ");
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
			strSql.Append("select count(1) FROM LogWells_SitDuty ");
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
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from LogWells_SitDuty T ");
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
			parameters[0].Value = "LogWells_SitDuty";
			parameters[1].Value = "ID";
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

