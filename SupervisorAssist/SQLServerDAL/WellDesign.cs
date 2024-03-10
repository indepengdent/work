
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SupervDB.IDAL;
using DBUtility;//Please add references
namespace SupervDB.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:WellDesign
	/// </summary>
	public partial class WellDesign:IWellDesign
	{
		public WellDesign()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Wellnum)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from WellDesign");
			strSql.Append(" where Wellnum=@Wellnum ");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Wellnum;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SupervDB.Model.WellDesign model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into WellDesign(");
			strSql.Append("Well_X,Well_Y,Well_JWx,Well_JWy,Well_KB,Well_HB,Well_Cd,Well_depth,Well_Sd,Well_CX,Well_BB,Well_type,Well_DS,Wellnum,Wellname,BuildF,Location,GZLoc,LogLoc,DrillAim,ComRul,AimLayer,ComSty,Welllins,Updatetime,Bdis,Well_Bx,Well_By,Well_JwBx,Well_JwBy,Well_Bx1,Well_By1,Well_JwBx1,Well_JwBy1,Bx_Xs,Bx_Cs,Bx_Bxj,Bx_Xs1,Bx_Cs1,Bx_Bxj1,BZ,Wellnum_t)");
			strSql.Append(" values (");
			strSql.Append("@Well_X,@Well_Y,@Well_JWx,@Well_JWy,@Well_KB,@Well_HB,@Well_Cd,@Well_depth,@Well_Sd,@Well_CX,@Well_BB,@Well_type,@Well_DS,@Wellnum,@Wellname,@BuildF,@Location,@GZLoc,@LogLoc,@DrillAim,@ComRul,@AimLayer,@ComSty,@Welllins,@Updatetime,@Bdis,@Well_Bx,@Well_By,@Well_JwBx,@Well_JwBy,@Well_Bx1,@Well_By1,@Well_JwBx1,@Well_JwBy1,@Bx_Xs,@Bx_Cs,@Bx_Bxj,@Bx_Xs1,@Bx_Cs1,@Bx_Bxj1,@BZ,@Wellnum_t)");
			SqlParameter[] parameters = {
					new SqlParameter("@Well_X", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_Y", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JWx", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JWy", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_KB", SqlDbType.Float,8),
					new SqlParameter("@Well_HB", SqlDbType.Float,8),
					new SqlParameter("@Well_Cd", SqlDbType.Float,8),
					new SqlParameter("@Well_depth", SqlDbType.Float,8),
					new SqlParameter("@Well_Sd", SqlDbType.Float,8),
					new SqlParameter("@Well_CX", SqlDbType.Float,8),
					new SqlParameter("@Well_BB", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_type", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_DS", SqlDbType.NVarChar,50),
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Wellname", SqlDbType.NVarChar,50),
					new SqlParameter("@BuildF", SqlDbType.NVarChar,50),
					new SqlParameter("@Location", SqlDbType.NVarChar,50),
					new SqlParameter("@GZLoc", SqlDbType.NVarChar,50),
					new SqlParameter("@LogLoc", SqlDbType.NVarChar,50),
					new SqlParameter("@DrillAim", SqlDbType.NVarChar,50),
					new SqlParameter("@ComRul", SqlDbType.NVarChar,50),
					new SqlParameter("@AimLayer", SqlDbType.NVarChar,50),
					new SqlParameter("@ComSty", SqlDbType.NVarChar,50),
					new SqlParameter("@Welllins", SqlDbType.NVarChar,50),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@Bdis", SqlDbType.Float,8),
					new SqlParameter("@Well_Bx", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_By", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JwBx", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JwBy", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_Bx1", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_By1", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JwBx1", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JwBy1", SqlDbType.NVarChar,50),
					new SqlParameter("@Bx_Xs", SqlDbType.Float,8),
					new SqlParameter("@Bx_Cs", SqlDbType.Float,8),
					new SqlParameter("@Bx_Bxj", SqlDbType.Float,8),
					new SqlParameter("@Bx_Xs1", SqlDbType.Float,8),
					new SqlParameter("@Bx_Cs1", SqlDbType.Float,8),
					new SqlParameter("@Bx_Bxj1", SqlDbType.Float,8),
					new SqlParameter("@BZ", SqlDbType.NVarChar,-1),
					new SqlParameter("@Wellnum_t", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Well_X;
			parameters[1].Value = model.Well_Y;
			parameters[2].Value = model.Well_JWx;
			parameters[3].Value = model.Well_JWy;
			parameters[4].Value = model.Well_KB;
			parameters[5].Value = model.Well_HB;
			parameters[6].Value = model.Well_Cd;
			parameters[7].Value = model.Well_depth;
			parameters[8].Value = model.Well_Sd;
			parameters[9].Value = model.Well_CX;
			parameters[10].Value = model.Well_BB;
			parameters[11].Value = model.Well_type;
			parameters[12].Value = model.Well_DS;
			parameters[13].Value = model.Wellnum;
			parameters[14].Value = model.Wellname;
			parameters[15].Value = model.BuildF;
			parameters[16].Value = model.Location;
			parameters[17].Value = model.GZLoc;
			parameters[18].Value = model.LogLoc;
			parameters[19].Value = model.DrillAim;
			parameters[20].Value = model.ComRul;
			parameters[21].Value = model.AimLayer;
			parameters[22].Value = model.ComSty;
			parameters[23].Value = model.Welllins;
			parameters[24].Value = model.Updatetime;
			parameters[25].Value = model.Bdis;
			parameters[26].Value = model.Well_Bx;
			parameters[27].Value = model.Well_By;
			parameters[28].Value = model.Well_JwBx;
			parameters[29].Value = model.Well_JwBy;
			parameters[30].Value = model.Well_Bx1;
			parameters[31].Value = model.Well_By1;
			parameters[32].Value = model.Well_JwBx1;
			parameters[33].Value = model.Well_JwBy1;
			parameters[34].Value = model.Bx_Xs;
			parameters[35].Value = model.Bx_Cs;
			parameters[36].Value = model.Bx_Bxj;
			parameters[37].Value = model.Bx_Xs1;
			parameters[38].Value = model.Bx_Cs1;
			parameters[39].Value = model.Bx_Bxj1;
			parameters[40].Value = model.BZ;
			parameters[41].Value = model.Wellnum_t;

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
		public bool Update(SupervDB.Model.WellDesign model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update WellDesign set ");
			strSql.Append("Well_X=@Well_X,");
			strSql.Append("Well_Y=@Well_Y,");
			strSql.Append("Well_JWx=@Well_JWx,");
			strSql.Append("Well_JWy=@Well_JWy,");
			strSql.Append("Well_KB=@Well_KB,");
			strSql.Append("Well_HB=@Well_HB,");
			strSql.Append("Well_Cd=@Well_Cd,");
			strSql.Append("Well_depth=@Well_depth,");
			strSql.Append("Well_Sd=@Well_Sd,");
			strSql.Append("Well_CX=@Well_CX,");
			strSql.Append("Well_BB=@Well_BB,");
			strSql.Append("Well_type=@Well_type,");
			strSql.Append("Well_DS=@Well_DS,");
			strSql.Append("Wellname=@Wellname,");
			strSql.Append("BuildF=@BuildF,");
			strSql.Append("Location=@Location,");
			strSql.Append("GZLoc=@GZLoc,");
			strSql.Append("LogLoc=@LogLoc,");
			strSql.Append("DrillAim=@DrillAim,");
			strSql.Append("ComRul=@ComRul,");
			strSql.Append("AimLayer=@AimLayer,");
			strSql.Append("ComSty=@ComSty,");
			strSql.Append("Welllins=@Welllins,");
			strSql.Append("Updatetime=@Updatetime,");
			strSql.Append("Bdis=@Bdis,");
			strSql.Append("Well_Bx=@Well_Bx,");
			strSql.Append("Well_By=@Well_By,");
			strSql.Append("Well_JwBx=@Well_JwBx,");
			strSql.Append("Well_JwBy=@Well_JwBy,");
			strSql.Append("Well_Bx1=@Well_Bx1,");
			strSql.Append("Well_By1=@Well_By1,");
			strSql.Append("Well_JwBx1=@Well_JwBx1,");
			strSql.Append("Well_JwBy1=@Well_JwBy1,");
			strSql.Append("Bx_Xs=@Bx_Xs,");
			strSql.Append("Bx_Cs=@Bx_Cs,");
			strSql.Append("Bx_Bxj=@Bx_Bxj,");
			strSql.Append("Bx_Xs1=@Bx_Xs1,");
			strSql.Append("Bx_Cs1=@Bx_Cs1,");
			strSql.Append("Bx_Bxj1=@Bx_Bxj1,");
			strSql.Append("BZ=@BZ,");
			strSql.Append("Wellnum_t=@Wellnum_t");
			strSql.Append(" where Wellnum=@Wellnum ");
			SqlParameter[] parameters = {
					new SqlParameter("@Well_X", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_Y", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JWx", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JWy", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_KB", SqlDbType.Float,8),
					new SqlParameter("@Well_HB", SqlDbType.Float,8),
					new SqlParameter("@Well_Cd", SqlDbType.Float,8),
					new SqlParameter("@Well_depth", SqlDbType.Float,8),
					new SqlParameter("@Well_Sd", SqlDbType.Float,8),
					new SqlParameter("@Well_CX", SqlDbType.Float,8),
					new SqlParameter("@Well_BB", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_type", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_DS", SqlDbType.NVarChar,50),
					new SqlParameter("@Wellname", SqlDbType.NVarChar,50),
					new SqlParameter("@BuildF", SqlDbType.NVarChar,50),
					new SqlParameter("@Location", SqlDbType.NVarChar,50),
					new SqlParameter("@GZLoc", SqlDbType.NVarChar,50),
					new SqlParameter("@LogLoc", SqlDbType.NVarChar,50),
					new SqlParameter("@DrillAim", SqlDbType.NVarChar,50),
					new SqlParameter("@ComRul", SqlDbType.NVarChar,50),
					new SqlParameter("@AimLayer", SqlDbType.NVarChar,50),
					new SqlParameter("@ComSty", SqlDbType.NVarChar,50),
					new SqlParameter("@Welllins", SqlDbType.NVarChar,50),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@Bdis", SqlDbType.Float,8),
					new SqlParameter("@Well_Bx", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_By", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JwBx", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JwBy", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_Bx1", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_By1", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JwBx1", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JwBy1", SqlDbType.NVarChar,50),
					new SqlParameter("@Bx_Xs", SqlDbType.Float,8),
					new SqlParameter("@Bx_Cs", SqlDbType.Float,8),
					new SqlParameter("@Bx_Bxj", SqlDbType.Float,8),
					new SqlParameter("@Bx_Xs1", SqlDbType.Float,8),
					new SqlParameter("@Bx_Cs1", SqlDbType.Float,8),
					new SqlParameter("@Bx_Bxj1", SqlDbType.Float,8),
					new SqlParameter("@BZ", SqlDbType.NVarChar,-1),
					new SqlParameter("@Wellnum_t", SqlDbType.NVarChar,50),
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Well_X;
			parameters[1].Value = model.Well_Y;
			parameters[2].Value = model.Well_JWx;
			parameters[3].Value = model.Well_JWy;
			parameters[4].Value = model.Well_KB;
			parameters[5].Value = model.Well_HB;
			parameters[6].Value = model.Well_Cd;
			parameters[7].Value = model.Well_depth;
			parameters[8].Value = model.Well_Sd;
			parameters[9].Value = model.Well_CX;
			parameters[10].Value = model.Well_BB;
			parameters[11].Value = model.Well_type;
			parameters[12].Value = model.Well_DS;
			parameters[13].Value = model.Wellname;
			parameters[14].Value = model.BuildF;
			parameters[15].Value = model.Location;
			parameters[16].Value = model.GZLoc;
			parameters[17].Value = model.LogLoc;
			parameters[18].Value = model.DrillAim;
			parameters[19].Value = model.ComRul;
			parameters[20].Value = model.AimLayer;
			parameters[21].Value = model.ComSty;
			parameters[22].Value = model.Welllins;
			parameters[23].Value = model.Updatetime;
			parameters[24].Value = model.Bdis;
			parameters[25].Value = model.Well_Bx;
			parameters[26].Value = model.Well_By;
			parameters[27].Value = model.Well_JwBx;
			parameters[28].Value = model.Well_JwBy;
			parameters[29].Value = model.Well_Bx1;
			parameters[30].Value = model.Well_By1;
			parameters[31].Value = model.Well_JwBx1;
			parameters[32].Value = model.Well_JwBy1;
			parameters[33].Value = model.Bx_Xs;
			parameters[34].Value = model.Bx_Cs;
			parameters[35].Value = model.Bx_Bxj;
			parameters[36].Value = model.Bx_Xs1;
			parameters[37].Value = model.Bx_Cs1;
			parameters[38].Value = model.Bx_Bxj1;
			parameters[39].Value = model.BZ;
			parameters[40].Value = model.Wellnum_t;
			parameters[41].Value = model.Wellnum;

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
			strSql.Append("delete from WellDesign ");
			strSql.Append(" where Wellnum=@Wellnum ");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,50)			};
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
			strSql.Append("delete from WellDesign ");
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
		public SupervDB.Model.WellDesign GetModel(string Wellnum)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Well_X,Well_Y,Well_JWx,Well_JWy,Well_KB,Well_HB,Well_Cd,Well_depth,Well_Sd,Well_CX,Well_BB,Well_type,Well_DS,Wellnum,Wellname,BuildF,Location,GZLoc,LogLoc,DrillAim,ComRul,AimLayer,ComSty,Welllins,Updatetime,Bdis,Well_Bx,Well_By,Well_JwBx,Well_JwBy,Well_Bx1,Well_By1,Well_JwBx1,Well_JwBy1,Bx_Xs,Bx_Cs,Bx_Bxj,Bx_Xs1,Bx_Cs1,Bx_Bxj1,BZ,Wellnum_t from WellDesign ");
			strSql.Append(" where Wellnum=@Wellnum ");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Wellnum;

			SupervDB.Model.WellDesign model=new SupervDB.Model.WellDesign();
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
		public SupervDB.Model.WellDesign DataRowToModel(DataRow row)
		{
			SupervDB.Model.WellDesign model=new SupervDB.Model.WellDesign();
			if (row != null)
			{
				if(row["Well_X"]!=null)
				{
					model.Well_X=row["Well_X"].ToString();
				}
				if(row["Well_Y"]!=null)
				{
					model.Well_Y=row["Well_Y"].ToString();
				}
				if(row["Well_JWx"]!=null)
				{
					model.Well_JWx=row["Well_JWx"].ToString();
				}
				if(row["Well_JWy"]!=null)
				{
					model.Well_JWy=row["Well_JWy"].ToString();
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
				if(row["Well_BB"]!=null)
				{
					model.Well_BB=row["Well_BB"].ToString();
				}
				if(row["Well_type"]!=null)
				{
					model.Well_type=row["Well_type"].ToString();
				}
				if(row["Well_DS"]!=null)
				{
					model.Well_DS=row["Well_DS"].ToString();
				}
				if(row["Wellnum"]!=null)
				{
					model.Wellnum=row["Wellnum"].ToString();
				}
				if(row["Wellname"]!=null)
				{
					model.Wellname=row["Wellname"].ToString();
				}
				if(row["BuildF"]!=null)
				{
					model.BuildF=row["BuildF"].ToString();
				}
				if(row["Location"]!=null)
				{
					model.Location=row["Location"].ToString();
				}
				if(row["GZLoc"]!=null)
				{
					model.GZLoc=row["GZLoc"].ToString();
				}
				if(row["LogLoc"]!=null)
				{
					model.LogLoc=row["LogLoc"].ToString();
				}
				if(row["DrillAim"]!=null)
				{
					model.DrillAim=row["DrillAim"].ToString();
				}
				if(row["ComRul"]!=null)
				{
					model.ComRul=row["ComRul"].ToString();
				}
				if(row["AimLayer"]!=null)
				{
					model.AimLayer=row["AimLayer"].ToString();
				}
				if(row["ComSty"]!=null)
				{
					model.ComSty=row["ComSty"].ToString();
				}
				if(row["Welllins"]!=null)
				{
					model.Welllins=row["Welllins"].ToString();
				}
				if(row["Updatetime"]!=null && row["Updatetime"].ToString()!="")
				{
					model.Updatetime=DateTime.Parse(row["Updatetime"].ToString());
				}
				if(row["Bdis"]!=null && row["Bdis"].ToString()!="")
				{
					model.Bdis=decimal.Parse(row["Bdis"].ToString());
				}
				if(row["Well_Bx"]!=null)
				{
					model.Well_Bx=row["Well_Bx"].ToString();
				}
				if(row["Well_By"]!=null)
				{
					model.Well_By=row["Well_By"].ToString();
				}
				if(row["Well_JwBx"]!=null)
				{
					model.Well_JwBx=row["Well_JwBx"].ToString();
				}
				if(row["Well_JwBy"]!=null)
				{
					model.Well_JwBy=row["Well_JwBy"].ToString();
				}
				if(row["Well_Bx1"]!=null)
				{
					model.Well_Bx1=row["Well_Bx1"].ToString();
				}
				if(row["Well_By1"]!=null)
				{
					model.Well_By1=row["Well_By1"].ToString();
				}
				if(row["Well_JwBx1"]!=null)
				{
					model.Well_JwBx1=row["Well_JwBx1"].ToString();
				}
				if(row["Well_JwBy1"]!=null)
				{
					model.Well_JwBy1=row["Well_JwBy1"].ToString();
				}
				if(row["Bx_Xs"]!=null && row["Bx_Xs"].ToString()!="")
				{
					model.Bx_Xs=decimal.Parse(row["Bx_Xs"].ToString());
				}
				if(row["Bx_Cs"]!=null && row["Bx_Cs"].ToString()!="")
				{
					model.Bx_Cs=decimal.Parse(row["Bx_Cs"].ToString());
				}
				if(row["Bx_Bxj"]!=null && row["Bx_Bxj"].ToString()!="")
				{
					model.Bx_Bxj=decimal.Parse(row["Bx_Bxj"].ToString());
				}
				if(row["Bx_Xs1"]!=null && row["Bx_Xs1"].ToString()!="")
				{
					model.Bx_Xs1=decimal.Parse(row["Bx_Xs1"].ToString());
				}
				if(row["Bx_Cs1"]!=null && row["Bx_Cs1"].ToString()!="")
				{
					model.Bx_Cs1=decimal.Parse(row["Bx_Cs1"].ToString());
				}
				if(row["Bx_Bxj1"]!=null && row["Bx_Bxj1"].ToString()!="")
				{
					model.Bx_Bxj1=decimal.Parse(row["Bx_Bxj1"].ToString());
				}
				if(row["BZ"]!=null)
				{
					model.BZ=row["BZ"].ToString();
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
			strSql.Append("select Well_X,Well_Y,Well_JWx,Well_JWy,Well_KB,Well_HB,Well_Cd,Well_depth,Well_Sd,Well_CX,Well_BB,Well_type,Well_DS,Wellnum,Wellname,BuildF,Location,GZLoc,LogLoc,DrillAim,ComRul,AimLayer,ComSty,Welllins,Updatetime,Bdis,Well_Bx,Well_By,Well_JwBx,Well_JwBy,Well_Bx1,Well_By1,Well_JwBx1,Well_JwBy1,Bx_Xs,Bx_Cs,Bx_Bxj,Bx_Xs1,Bx_Cs1,Bx_Bxj1,BZ,Wellnum_t ");
			strSql.Append(" FROM WellDesign ");
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
			strSql.Append(" Well_X,Well_Y,Well_JWx,Well_JWy,Well_KB,Well_HB,Well_Cd,Well_depth,Well_Sd,Well_CX,Well_BB,Well_type,Well_DS,Wellnum,Wellname,BuildF,Location,GZLoc,LogLoc,DrillAim,ComRul,AimLayer,ComSty,Welllins,Updatetime,Bdis,Well_Bx,Well_By,Well_JwBx,Well_JwBy,Well_Bx1,Well_By1,Well_JwBx1,Well_JwBy1,Bx_Xs,Bx_Cs,Bx_Bxj,Bx_Xs1,Bx_Cs1,Bx_Bxj1,BZ,Wellnum_t ");
			strSql.Append(" FROM WellDesign ");
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
			strSql.Append("select count(1) FROM WellDesign ");
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
			strSql.Append(")AS Row, T.*  from WellDesign T ");
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
			parameters[0].Value = "WellDesign";
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

