
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SupervDB.IDAL;
using DBUtility;//Please add references
namespace SupervDB.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:NoticeRect
	/// </summary>
	public partial class NoticeRect:INoticeRect
	{
		public NoticeRect()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Wellnum)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from NoticeRect");
			strSql.Append(" where Wellnum=@Wellnum ");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,255)			};
			parameters[0].Value = Wellnum;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SupervDB.Model.NoticeRect model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NoticeRect(");
			strSql.Append("Wellnum,ConstructUnit,ReleaseTime,Problems,Requirements,GeoSupervisor,ConstructSign)");
			strSql.Append(" values (");
			strSql.Append("@Wellnum,@ConstructUnit,@ReleaseTime,@Problems,@Requirements,@GeoSupervisor,@ConstructSign)");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,255),
					new SqlParameter("@ConstructUnit", SqlDbType.NVarChar,255),
					new SqlParameter("@ReleaseTime", SqlDbType.DateTime),
					new SqlParameter("@Problems", SqlDbType.NVarChar,255),
					new SqlParameter("@Requirements", SqlDbType.NVarChar,255),
					new SqlParameter("@GeoSupervisor", SqlDbType.NVarChar,255),
					new SqlParameter("@ConstructSign", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.Wellnum;
			parameters[1].Value = model.ConstructUnit;
			parameters[2].Value = model.ReleaseTime;
			parameters[3].Value = model.Problems;
			parameters[4].Value = model.Requirements;
			parameters[5].Value = model.GeoSupervisor;
			parameters[6].Value = model.ConstructSign;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(SupervDB.Model.NoticeRect model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NoticeRect set ");
			strSql.Append("ConstructUnit=@ConstructUnit,");
			strSql.Append("ReleaseTime=@ReleaseTime,");
			strSql.Append("Problems=@Problems,");
			strSql.Append("Requirements=@Requirements,");
			strSql.Append("GeoSupervisor=@GeoSupervisor,");
			strSql.Append("ConstructSign=@ConstructSign");
			strSql.Append(" where Wellnum=@Wellnum ");
			SqlParameter[] parameters = {
					new SqlParameter("@ConstructUnit", SqlDbType.NVarChar,255),
					new SqlParameter("@ReleaseTime", SqlDbType.DateTime),
					new SqlParameter("@Problems", SqlDbType.NVarChar,255),
					new SqlParameter("@Requirements", SqlDbType.NVarChar,255),
					new SqlParameter("@GeoSupervisor", SqlDbType.NVarChar,255),
					new SqlParameter("@ConstructSign", SqlDbType.NVarChar,255),
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.ConstructUnit;
			parameters[1].Value = model.ReleaseTime;
			parameters[2].Value = model.Problems;
			parameters[3].Value = model.Requirements;
			parameters[4].Value = model.GeoSupervisor;
			parameters[5].Value = model.ConstructSign;
			parameters[6].Value = model.Wellnum;

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
		public bool Delete(string Wellnum)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NoticeRect ");
			strSql.Append(" where Wellnum=@Wellnum ");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,255)			};
			parameters[0].Value = Wellnum;

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
		public bool DeleteList(string Wellnumlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NoticeRect ");
			strSql.Append(" where Wellnum in ("+Wellnumlist + ")  ");
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
		public SupervDB.Model.NoticeRect GetModel(string Wellnum)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Wellnum,ConstructUnit,ReleaseTime,Problems,Requirements,GeoSupervisor,ConstructSign from NoticeRect ");
			strSql.Append(" where Wellnum=@Wellnum ");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,255)			};
			parameters[0].Value = Wellnum;

			SupervDB.Model.NoticeRect model=new SupervDB.Model.NoticeRect();
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
		public SupervDB.Model.NoticeRect DataRowToModel(DataRow row)
		{
			SupervDB.Model.NoticeRect model=new SupervDB.Model.NoticeRect();
			if (row != null)
			{
				if(row["Wellnum"]!=null)
				{
					model.Wellnum=row["Wellnum"].ToString();
				}
				if(row["ConstructUnit"]!=null)
				{
					model.ConstructUnit=row["ConstructUnit"].ToString();
				}
				if(row["ReleaseTime"]!=null && row["ReleaseTime"].ToString()!="")
				{
					model.ReleaseTime=DateTime.Parse(row["ReleaseTime"].ToString());
				}
				if(row["Problems"]!=null)
				{
					model.Problems=row["Problems"].ToString();
				}
				if(row["Requirements"]!=null)
				{
					model.Requirements=row["Requirements"].ToString();
				}
				if(row["GeoSupervisor"]!=null)
				{
					model.GeoSupervisor=row["GeoSupervisor"].ToString();
				}
				if(row["ConstructSign"]!=null)
				{
					model.ConstructSign=row["ConstructSign"].ToString();
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
			strSql.Append("select Wellnum,ConstructUnit,ReleaseTime,Problems,Requirements,GeoSupervisor,ConstructSign ");
			strSql.Append(" FROM NoticeRect ");
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
			strSql.Append(" Wellnum,ConstructUnit,ReleaseTime,Problems,Requirements,GeoSupervisor,ConstructSign ");
			strSql.Append(" FROM NoticeRect ");
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
			strSql.Append("select count(1) FROM NoticeRect ");
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
				strSql.Append("order by T.Wellnum desc");
			}
			strSql.Append(")AS Row, T.*  from NoticeRect T ");
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
			parameters[0].Value = "NoticeRect";
			parameters[1].Value = "Wellnum";
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

