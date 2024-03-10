
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SupervDB.IDAL;
using DBUtility;//Please add references
namespace SupervDB.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:GeoSuperv
	/// </summary>
	public partial class GeoSuperv:IGeoSuperv
	{
		public GeoSuperv()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "GeoSuperv"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from GeoSuperv");
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
		public int Add(SupervDB.Model.GeoSuperv model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into GeoSuperv(");
			strSql.Append("Wellnum,Updatetime,Well_type,Well_BB,JdName,JdNum,JdWay,Location,GZLoc,DrillAim,ComRul,Well_KB,Well_HB,Well_Cd,Well_depth,Well_Sd,Well_CX,Wzdepth,WzCd,SpLen,LjDepth,MainAimLayer,SecAimLayer,SDate,EDate,CDate,LJStartDate,ComSty,WellLines,LJEndDate,Well_state,YT)");
			strSql.Append(" values (");
			strSql.Append("@Wellnum,@Updatetime,@Well_type,@Well_BB,@JdName,@JdNum,@JdWay,@Location,@GZLoc,@DrillAim,@ComRul,@Well_KB,@Well_HB,@Well_Cd,@Well_depth,@Well_Sd,@Well_CX,@Wzdepth,@WzCd,@SpLen,@LjDepth,@MainAimLayer,@SecAimLayer,@SDate,@EDate,@CDate,@LJStartDate,@ComSty,@WellLines,@LJEndDate,@Well_state,@YT)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,255),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@Well_type", SqlDbType.NVarChar,255),
					new SqlParameter("@Well_BB", SqlDbType.NVarChar,255),
					new SqlParameter("@JdName", SqlDbType.NVarChar,255),
					new SqlParameter("@JdNum", SqlDbType.NVarChar,255),
					new SqlParameter("@JdWay", SqlDbType.NVarChar,255),
					new SqlParameter("@Location", SqlDbType.NVarChar,255),
					new SqlParameter("@GZLoc", SqlDbType.NVarChar,255),
					new SqlParameter("@DrillAim", SqlDbType.NVarChar,255),
					new SqlParameter("@ComRul", SqlDbType.NVarChar,255),
					new SqlParameter("@Well_KB", SqlDbType.Float,8),
					new SqlParameter("@Well_HB", SqlDbType.Float,8),
					new SqlParameter("@Well_Cd", SqlDbType.Float,8),
					new SqlParameter("@Well_depth", SqlDbType.Float,8),
					new SqlParameter("@Well_Sd", SqlDbType.Float,8),
					new SqlParameter("@Well_CX", SqlDbType.Float,8),
					new SqlParameter("@Wzdepth", SqlDbType.Float,8),
					new SqlParameter("@WzCd", SqlDbType.Float,8),
					new SqlParameter("@SpLen", SqlDbType.Float,8),
					new SqlParameter("@LjDepth", SqlDbType.Float,8),
					new SqlParameter("@MainAimLayer", SqlDbType.NVarChar,255),
					new SqlParameter("@SecAimLayer", SqlDbType.NVarChar,255),
					new SqlParameter("@SDate", SqlDbType.DateTime),
					new SqlParameter("@EDate", SqlDbType.DateTime),
					new SqlParameter("@CDate", SqlDbType.DateTime),
					new SqlParameter("@LJStartDate", SqlDbType.DateTime),
					new SqlParameter("@ComSty", SqlDbType.NVarChar,255),
					new SqlParameter("@WellLines", SqlDbType.NVarChar,255),
					new SqlParameter("@LJEndDate", SqlDbType.NVarChar,255),
                    new SqlParameter("@Well_state", SqlDbType.NVarChar,255),
                    new SqlParameter("@YT", SqlDbType.NVarChar,255)};
			parameters[0].Value = model.Wellnum;
			parameters[1].Value = model.Updatetime;
			parameters[2].Value = model.Well_type;
			parameters[3].Value = model.Well_BB;
			parameters[4].Value = model.JdName;
			parameters[5].Value = model.JdNum;
			parameters[6].Value = model.JdWay;
			parameters[7].Value = model.Location;
			parameters[8].Value = model.GZLoc;
			parameters[9].Value = model.DrillAim;
			parameters[10].Value = model.ComRul;
			parameters[11].Value = model.Well_KB;
			parameters[12].Value = model.Well_HB;
			parameters[13].Value = model.Well_Cd;
			parameters[14].Value = model.Well_depth;
			parameters[15].Value = model.Well_Sd;
			parameters[16].Value = model.Well_CX;
			parameters[17].Value = model.Wzdepth;
			parameters[18].Value = model.WzCd;
			parameters[19].Value = model.SpLen;
			parameters[20].Value = model.LjDepth;
			parameters[21].Value = model.MainAimLayer;
			parameters[22].Value = model.SecAimLayer;
			parameters[23].Value = model.SDate;
			parameters[24].Value = model.EDate;
			parameters[25].Value = model.CDate;
			parameters[26].Value = model.LJStartDate;
			parameters[27].Value = model.ComSty;
			parameters[28].Value = model.WellLines;
			parameters[29].Value = model.LJEndDate;
            parameters[30].Value = model.Well_state;
            parameters[31].Value = model.YT;

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
		public bool Update(SupervDB.Model.GeoSuperv model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update GeoSuperv set ");
			strSql.Append("Wellnum=@Wellnum,");
			strSql.Append("Updatetime=@Updatetime,");
			strSql.Append("Well_type=@Well_type,");
			strSql.Append("Well_BB=@Well_BB,");
			strSql.Append("JdName=@JdName,");
			strSql.Append("JdNum=@JdNum,");
			strSql.Append("JdWay=@JdWay,");
			strSql.Append("Location=@Location,");
			strSql.Append("GZLoc=@GZLoc,");
			strSql.Append("DrillAim=@DrillAim,");
			strSql.Append("ComRul=@ComRul,");
			strSql.Append("Well_KB=@Well_KB,");
			strSql.Append("Well_HB=@Well_HB,");
			strSql.Append("Well_Cd=@Well_Cd,");
			strSql.Append("Well_depth=@Well_depth,");
			strSql.Append("Well_Sd=@Well_Sd,");
			strSql.Append("Well_CX=@Well_CX,");
			strSql.Append("Wzdepth=@Wzdepth,");
			strSql.Append("WzCd=@WzCd,");
			strSql.Append("SpLen=@SpLen,");
			strSql.Append("LjDepth=@LjDepth,");
			strSql.Append("MainAimLayer=@MainAimLayer,");
			strSql.Append("SecAimLayer=@SecAimLayer,");
			strSql.Append("SDate=@SDate,");
			strSql.Append("EDate=@EDate,");
			strSql.Append("CDate=@CDate,");
			strSql.Append("LJStartDate=@LJStartDate,");
			strSql.Append("ComSty=@ComSty,");
			strSql.Append("WellLines=@WellLines,");
			strSql.Append("LJEndDate=@LJEndDate,");
            strSql.Append("Well_state=@Well_state,");
            strSql.Append("YT=@YT");
            strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,255),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@Well_type", SqlDbType.NVarChar,255),
					new SqlParameter("@Well_BB", SqlDbType.NVarChar,255),
					new SqlParameter("@JdName", SqlDbType.NVarChar,255),
					new SqlParameter("@JdNum", SqlDbType.NVarChar,255),
					new SqlParameter("@JdWay", SqlDbType.NVarChar,255),
					new SqlParameter("@Location", SqlDbType.NVarChar,255),
					new SqlParameter("@GZLoc", SqlDbType.NVarChar,255),
					new SqlParameter("@DrillAim", SqlDbType.NVarChar,255),
					new SqlParameter("@ComRul", SqlDbType.NVarChar,255),
					new SqlParameter("@Well_KB", SqlDbType.Float,8),
					new SqlParameter("@Well_HB", SqlDbType.Float,8),
					new SqlParameter("@Well_Cd", SqlDbType.Float,8),
					new SqlParameter("@Well_depth", SqlDbType.Float,8),
					new SqlParameter("@Well_Sd", SqlDbType.Float,8),
					new SqlParameter("@Well_CX", SqlDbType.Float,8),
					new SqlParameter("@Wzdepth", SqlDbType.Float,8),
					new SqlParameter("@WzCd", SqlDbType.Float,8),
					new SqlParameter("@SpLen", SqlDbType.Float,8),
					new SqlParameter("@LjDepth", SqlDbType.Float,8),
					new SqlParameter("@MainAimLayer", SqlDbType.NVarChar,255),
					new SqlParameter("@SecAimLayer", SqlDbType.NVarChar,255),
					new SqlParameter("@SDate", SqlDbType.DateTime),
					new SqlParameter("@EDate", SqlDbType.DateTime),
					new SqlParameter("@CDate", SqlDbType.DateTime),
					new SqlParameter("@LJStartDate", SqlDbType.DateTime),
					new SqlParameter("@ComSty", SqlDbType.NVarChar,255),
					new SqlParameter("@WellLines", SqlDbType.NVarChar,255),
					new SqlParameter("@LJEndDate", SqlDbType.NVarChar,255),
                    new SqlParameter("@Well_state", SqlDbType.NVarChar,255),
                    new SqlParameter("@YT", SqlDbType.NVarChar,255),
                    new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Wellnum;
			parameters[1].Value = model.Updatetime;
			parameters[2].Value = model.Well_type;
			parameters[3].Value = model.Well_BB;
			parameters[4].Value = model.JdName;
			parameters[5].Value = model.JdNum;
			parameters[6].Value = model.JdWay;
			parameters[7].Value = model.Location;
			parameters[8].Value = model.GZLoc;
			parameters[9].Value = model.DrillAim;
			parameters[10].Value = model.ComRul;
			parameters[11].Value = model.Well_KB;
			parameters[12].Value = model.Well_HB;
			parameters[13].Value = model.Well_Cd;
			parameters[14].Value = model.Well_depth;
			parameters[15].Value = model.Well_Sd;
			parameters[16].Value = model.Well_CX;
			parameters[17].Value = model.Wzdepth;
			parameters[18].Value = model.WzCd;
			parameters[19].Value = model.SpLen;
			parameters[20].Value = model.LjDepth;
			parameters[21].Value = model.MainAimLayer;
			parameters[22].Value = model.SecAimLayer;
			parameters[23].Value = model.SDate;
			parameters[24].Value = model.EDate;
			parameters[25].Value = model.CDate;
			parameters[26].Value = model.LJStartDate;
			parameters[27].Value = model.ComSty;
			parameters[28].Value = model.WellLines;
			parameters[29].Value = model.LJEndDate;
            parameters[30].Value = model.Well_state;
            parameters[31].Value = model.YT;
            parameters[32].Value = model.ID;

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
			strSql.Append("delete from GeoSuperv ");
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
			strSql.Append("delete from GeoSuperv ");
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
		public SupervDB.Model.GeoSuperv GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Wellnum,Updatetime,Well_type,Well_BB,JdName,JdNum,JdWay,Location,GZLoc,DrillAim,ComRul,Well_KB,Well_HB,Well_Cd,Well_depth,Well_Sd,Well_CX,Wzdepth,WzCd,SpLen,LjDepth,MainAimLayer,SecAimLayer,SDate,EDate,CDate,LJStartDate,ComSty,WellLines,LJEndDate,Well_state,YT from GeoSuperv ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			SupervDB.Model.GeoSuperv model=new SupervDB.Model.GeoSuperv();
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
		public SupervDB.Model.GeoSuperv DataRowToModel(DataRow row)
		{
			SupervDB.Model.GeoSuperv model=new SupervDB.Model.GeoSuperv();
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
                if (row["Well_state"] != null)
                {
                    model.Well_state = row["Well_state"].ToString();
                }
                if (row["YT"] != null)
                {
                    model.YT = row["YT"].ToString();
                }
                if (row["Well_type"]!=null)
				{
					model.Well_type=row["Well_type"].ToString();
				}
				if(row["Well_BB"]!=null)
				{
					model.Well_BB=row["Well_BB"].ToString();
				}
				if(row["JdName"]!=null)
				{
					model.JdName=row["JdName"].ToString();
				}
				if(row["JdNum"]!=null)
				{
					model.JdNum=row["JdNum"].ToString();
				}
				if(row["JdWay"]!=null)
				{
					model.JdWay=row["JdWay"].ToString();
				}
				if(row["Location"]!=null)
				{
					model.Location=row["Location"].ToString();
				}
				if(row["GZLoc"]!=null)
				{
					model.GZLoc=row["GZLoc"].ToString();
				}
				if(row["DrillAim"]!=null)
				{
					model.DrillAim=row["DrillAim"].ToString();
				}
				if(row["ComRul"]!=null)
				{
					model.ComRul=row["ComRul"].ToString();
				}
				if(row["Well_KB"]!=null && row["Well_KB"].ToString()!="")
				{
					model.Well_KB=decimal.Parse(row["Well_KB"].ToString());
				}
				if(row["Well_HB"]!=null && row["Well_HB"].ToString()!="")
				{
					model.Well_HB=decimal.Parse(row["Well_HB"].ToString());
				}
				if(row["Well_Cd"]!=null && row["Well_Cd"].ToString()!="")
				{
					model.Well_Cd=decimal.Parse(row["Well_Cd"].ToString());
				}
				if(row["Well_depth"]!=null && row["Well_depth"].ToString()!="")
				{
					model.Well_depth=decimal.Parse(row["Well_depth"].ToString());
				}
				if(row["Well_Sd"]!=null && row["Well_Sd"].ToString()!="")
				{
					model.Well_Sd=decimal.Parse(row["Well_Sd"].ToString());
				}
				if(row["Well_CX"]!=null && row["Well_CX"].ToString()!="")
				{
					model.Well_CX=decimal.Parse(row["Well_CX"].ToString());
				}
				if(row["Wzdepth"]!=null && row["Wzdepth"].ToString()!="")
				{
					model.Wzdepth=decimal.Parse(row["Wzdepth"].ToString());
				}
				if(row["WzCd"]!=null && row["WzCd"].ToString()!="")
				{
					model.WzCd=decimal.Parse(row["WzCd"].ToString());
				}
				if(row["SpLen"]!=null && row["SpLen"].ToString()!="")
				{
					model.SpLen=decimal.Parse(row["SpLen"].ToString());
				}
				if(row["LjDepth"]!=null && row["LjDepth"].ToString()!="")
				{
					model.LjDepth=decimal.Parse(row["LjDepth"].ToString());
				}
				if(row["MainAimLayer"]!=null)
				{
					model.MainAimLayer=row["MainAimLayer"].ToString();
				}
				if(row["SecAimLayer"]!=null)
				{
					model.SecAimLayer=row["SecAimLayer"].ToString();
				}
				if(row["SDate"]!=null && row["SDate"].ToString()!="")
				{
					model.SDate=DateTime.Parse(row["SDate"].ToString());
				}
				if(row["EDate"]!=null && row["EDate"].ToString()!="")
				{
					model.EDate=DateTime.Parse(row["EDate"].ToString());
				}
				if(row["CDate"]!=null && row["CDate"].ToString()!="")
				{
					model.CDate=DateTime.Parse(row["CDate"].ToString());
				}
				if(row["LJStartDate"]!=null && row["LJStartDate"].ToString()!="")
				{
					model.LJStartDate=DateTime.Parse(row["LJStartDate"].ToString());
				}
				if(row["ComSty"]!=null)
				{
					model.ComSty=row["ComSty"].ToString();
				}
				if(row["WellLines"]!=null)
				{
					model.WellLines=row["WellLines"].ToString();
				}
				if(row["LJEndDate"]!=null)
				{
					model.LJEndDate=row["LJEndDate"].ToString();
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
			strSql.Append("select ID,Wellnum,Updatetime,Well_type,Well_BB,JdName,JdNum,JdWay,Location,GZLoc,DrillAim,ComRul,Well_KB,Well_HB,Well_Cd,Well_depth,Well_Sd,Well_CX,Wzdepth,WzCd,SpLen,LjDepth,MainAimLayer,SecAimLayer,SDate,EDate,CDate,LJStartDate,ComSty,WellLines,LJEndDate,Well_state,YT ");
			strSql.Append(" FROM GeoSuperv ");
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
			strSql.Append(" ID,Wellnum,Updatetime,Well_type,Well_BB,JdName,JdNum,JdWay,Location,GZLoc,DrillAim,ComRul,Well_KB,Well_HB,Well_Cd,Well_depth,Well_Sd,Well_CX,Wzdepth,WzCd,SpLen,LjDepth,MainAimLayer,SecAimLayer,SDate,EDate,CDate,LJStartDate,ComSty,WellLines,LJEndDate,Well_state,YT ");
			strSql.Append(" FROM GeoSuperv ");
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
			strSql.Append("select count(1) FROM GeoSuperv ");
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
			strSql.Append(")AS Row, T.*  from GeoSuperv T ");
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
			parameters[0].Value = "GeoSuperv";
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

