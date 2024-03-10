
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SupervDB.IDAL;
using DBUtility;//Please add references
namespace SupervDB.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:Users
	/// </summary>
	public partial class Users:IUsers
	{
		public Users()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("id", "Users"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Users");
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
		public int Add(SupervDB.Model.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Users(");
			strSql.Append("Username,Password,Isstate,Name,Createddata,Creator,Userpermission,Remark)");
			strSql.Append(" values (");
			strSql.Append("@Username,@Password,@Isstate,@Name,@Createddata,@Creator,@Userpermission,@Remark)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Username", SqlDbType.NVarChar,255),
					new SqlParameter("@Password", SqlDbType.NVarChar,255),
					new SqlParameter("@Isstate", SqlDbType.Bit,1),
					new SqlParameter("@Name", SqlDbType.NVarChar,255),
					new SqlParameter("@Createddata", SqlDbType.DateTime),
					new SqlParameter("@Creator", SqlDbType.NVarChar,255),
					new SqlParameter("@Userpermission", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.Username;
			parameters[1].Value = model.Password;
			parameters[2].Value = model.Isstate;
			parameters[3].Value = model.Name;
			parameters[4].Value = model.Createddata;
			parameters[5].Value = model.Creator;
			parameters[6].Value = model.Userpermission;
			parameters[7].Value = model.Remark;

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
		public bool Update(SupervDB.Model.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Users set ");
			strSql.Append("Username=@Username,");
			strSql.Append("Password=@Password,");
			strSql.Append("Isstate=@Isstate,");
			strSql.Append("Name=@Name,");
			strSql.Append("Createddata=@Createddata,");
			strSql.Append("Creator=@Creator,");
			strSql.Append("Userpermission=@Userpermission,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@Username", SqlDbType.NVarChar,255),
					new SqlParameter("@Password", SqlDbType.NVarChar,255),
					new SqlParameter("@Isstate", SqlDbType.Bit,1),
					new SqlParameter("@Name", SqlDbType.NVarChar,255),
					new SqlParameter("@Createddata", SqlDbType.DateTime),
					new SqlParameter("@Creator", SqlDbType.NVarChar,255),
					new SqlParameter("@Userpermission", SqlDbType.Int,4),
					new SqlParameter("@Remark", SqlDbType.NVarChar,255),
					new SqlParameter("@id", SqlDbType.Int,4)};
			parameters[0].Value = model.Username;
			parameters[1].Value = model.Password;
			parameters[2].Value = model.Isstate;
			parameters[3].Value = model.Name;
			parameters[4].Value = model.Createddata;
			parameters[5].Value = model.Creator;
			parameters[6].Value = model.Userpermission;
			parameters[7].Value = model.Remark;
			parameters[8].Value = model.id;

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
			strSql.Append("delete from Users ");
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
			strSql.Append("delete from Users ");
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
		public SupervDB.Model.Users GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Username,Password,Isstate,Name,Createddata,Creator,Userpermission,Remark,id from Users ");
			strSql.Append(" where id=@id");
			SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
			};
			parameters[0].Value = id;

			SupervDB.Model.Users model=new SupervDB.Model.Users();
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
		public SupervDB.Model.Users DataRowToModel(DataRow row)
		{
			SupervDB.Model.Users model=new SupervDB.Model.Users();
			if (row != null)
			{
				if(row["Username"]!=null)
				{
					model.Username=row["Username"].ToString();
				}
				if(row["Password"]!=null)
				{
					model.Password=row["Password"].ToString();
				}
				if(row["Isstate"]!=null && row["Isstate"].ToString()!="")
				{
					if((row["Isstate"].ToString()=="1")||(row["Isstate"].ToString().ToLower()=="true"))
					{
						model.Isstate=true;
					}
					else
					{
						model.Isstate=false;
					}
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Createddata"]!=null && row["Createddata"].ToString()!="")
				{
					model.Createddata=DateTime.Parse(row["Createddata"].ToString());
				}
				if(row["Creator"]!=null)
				{
					model.Creator=row["Creator"].ToString();
				}
				if(row["Userpermission"]!=null && row["Userpermission"].ToString()!="")
				{
					model.Userpermission=int.Parse(row["Userpermission"].ToString());
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
				}
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
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
			strSql.Append("select Username,Password,Isstate,Name,Createddata,Creator,Userpermission,Remark,id ");
			strSql.Append(" FROM Users ");
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
			strSql.Append(" Username,Password,Isstate,Name,Createddata,Creator,Userpermission,Remark,id ");
			strSql.Append(" FROM Users ");
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
			strSql.Append("select count(1) FROM Users ");
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
			strSql.Append(")AS Row, T.*  from Users T ");
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
			parameters[0].Value = "Users";
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

