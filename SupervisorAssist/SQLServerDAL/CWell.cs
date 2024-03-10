
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SupervDB.IDAL;
using DBUtility;//Please add references
namespace SupervDB.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:CWell
	/// </summary>
	public partial class CWell:ICWell
	{
		public CWell()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Wellnum)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from CWell");
			strSql.Append(" where Wellnum=@Wellnum ");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Wellnum;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SupervDB.Model.CWell model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into CWell(");
			strSql.Append("YT,Well_State,SQ_date,SC_Date,SCFS,Well_X,Well_Y,Well_Jwx,Well_Jwy,Well_Bx,Well_By,Well_JwBx,Well_JwBy,Pldeg,Pldis,Zbcdepth,Totspdis,Bdis,MaxJX,Fwei,AtDep,Welllins,TolinsDis,TolinsDeg,DesLayerName,ComLayerName,AimLayer,LB,Well_KB,Well_HB,Well_Cd,Well_depth,Well_Sd,Well_CX,Well_BB,Well_type,Well_DS,Wellnum,Wellname,BuildF,Location,GZLoc,LogLoc,DrillAim,ComRul,SDate,EDate,CDate,ComSty,UpdateTime,Well_Bx1,Well_By1,Well_JwBx1,Well_JwBy1,Bx_Xs,Bx_Cs,Bx_Bxj,Bx_Xs1,Bx_Cs1,Bx_Bxj1,Sum_SP,Well_BHDeg,Length_SP,Max_JX,BZ,JJXD,SJZQ,Wellnum_t,WellnumAndt,ZQmxV,Projectteam,Loggingcompany,ComDepth,HCDepth,HCTime,LogTechnology,LJStartDate,LJEndDate)");
			strSql.Append(" values (");
			strSql.Append("@YT,@Well_State,@SQ_date,@SC_Date,@SCFS,@Well_X,@Well_Y,@Well_Jwx,@Well_Jwy,@Well_Bx,@Well_By,@Well_JwBx,@Well_JwBy,@Pldeg,@Pldis,@Zbcdepth,@Totspdis,@Bdis,@MaxJX,@Fwei,@AtDep,@Welllins,@TolinsDis,@TolinsDeg,@DesLayerName,@ComLayerName,@AimLayer,@LB,@Well_KB,@Well_HB,@Well_Cd,@Well_depth,@Well_Sd,@Well_CX,@Well_BB,@Well_type,@Well_DS,@Wellnum,@Wellname,@BuildF,@Location,@GZLoc,@LogLoc,@DrillAim,@ComRul,@SDate,@EDate,@CDate,@ComSty,@UpdateTime,@Well_Bx1,@Well_By1,@Well_JwBx1,@Well_JwBy1,@Bx_Xs,@Bx_Cs,@Bx_Bxj,@Bx_Xs1,@Bx_Cs1,@Bx_Bxj1,@Sum_SP,@Well_BHDeg,@Length_SP,@Max_JX,@BZ,@JJXD,@SJZQ,@Wellnum_t,@WellnumAndt,@ZQmxV,@Projectteam,@Loggingcompany,@ComDepth,@HCDepth,@HCTime,@LogTechnology,@LJStartDate,@LJEndDate)");
			SqlParameter[] parameters = {
					new SqlParameter("@YT", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_State", SqlDbType.NVarChar,50),
					new SqlParameter("@SQ_date", SqlDbType.DateTime),
					new SqlParameter("@SC_Date", SqlDbType.DateTime),
					new SqlParameter("@SCFS", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_X", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_Y", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_Jwx", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_Jwy", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_Bx", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_By", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JwBx", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JwBy", SqlDbType.NVarChar,50),
					new SqlParameter("@Pldeg", SqlDbType.Float,8),
					new SqlParameter("@Pldis", SqlDbType.Float,8),
					new SqlParameter("@Zbcdepth", SqlDbType.Float,8),
					new SqlParameter("@Totspdis", SqlDbType.Float,8),
					new SqlParameter("@Bdis", SqlDbType.Float,8),
					new SqlParameter("@MaxJX", SqlDbType.Float,8),
					new SqlParameter("@Fwei", SqlDbType.Float,8),
					new SqlParameter("@AtDep", SqlDbType.Float,8),
					new SqlParameter("@Welllins", SqlDbType.NVarChar,50),
					new SqlParameter("@TolinsDis", SqlDbType.Float,8),
					new SqlParameter("@TolinsDeg", SqlDbType.Float,8),
					new SqlParameter("@DesLayerName", SqlDbType.NVarChar,50),
					new SqlParameter("@ComLayerName", SqlDbType.NVarChar,50),
					new SqlParameter("@AimLayer", SqlDbType.NVarChar,50),
					new SqlParameter("@LB", SqlDbType.Int,4),
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
					new SqlParameter("@SDate", SqlDbType.DateTime),
					new SqlParameter("@EDate", SqlDbType.DateTime),
					new SqlParameter("@CDate", SqlDbType.DateTime),
					new SqlParameter("@ComSty", SqlDbType.NVarChar,50),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
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
					new SqlParameter("@Sum_SP", SqlDbType.Float,8),
					new SqlParameter("@Well_BHDeg", SqlDbType.Float,8),
					new SqlParameter("@Length_SP", SqlDbType.Float,8),
					new SqlParameter("@Max_JX", SqlDbType.Float,8),
					new SqlParameter("@BZ", SqlDbType.NVarChar,-1),
					new SqlParameter("@JJXD", SqlDbType.NVarChar,50),
					new SqlParameter("@SJZQ", SqlDbType.NVarChar,50),
					new SqlParameter("@Wellnum_t", SqlDbType.NVarChar,50),
					new SqlParameter("@WellnumAndt", SqlDbType.NVarChar,50),
					new SqlParameter("@ZQmxV", SqlDbType.Float,8),
					new SqlParameter("@Projectteam", SqlDbType.NVarChar,255),
					new SqlParameter("@Loggingcompany", SqlDbType.NVarChar,255),
					new SqlParameter("@ComDepth", SqlDbType.Float,8),
					new SqlParameter("@HCDepth", SqlDbType.Float,8),
					new SqlParameter("@HCTime", SqlDbType.DateTime),
					new SqlParameter("@LogTechnology", SqlDbType.VarChar,255),
					new SqlParameter("@LJStartDate", SqlDbType.DateTime),
					new SqlParameter("@LJEndDate", SqlDbType.DateTime)};
			parameters[0].Value = model.YT;
			parameters[1].Value = model.Well_State;
			parameters[2].Value = model.SQ_date;
			parameters[3].Value = model.SC_Date;
			parameters[4].Value = model.SCFS;
			parameters[5].Value = model.Well_X;
			parameters[6].Value = model.Well_Y;
			parameters[7].Value = model.Well_Jwx;
			parameters[8].Value = model.Well_Jwy;
			parameters[9].Value = model.Well_Bx;
			parameters[10].Value = model.Well_By;
			parameters[11].Value = model.Well_JwBx;
			parameters[12].Value = model.Well_JwBy;
			parameters[13].Value = model.Pldeg;
			parameters[14].Value = model.Pldis;
			parameters[15].Value = model.Zbcdepth;
			parameters[16].Value = model.Totspdis;
			parameters[17].Value = model.Bdis;
			parameters[18].Value = model.MaxJX;
			parameters[19].Value = model.Fwei;
			parameters[20].Value = model.AtDep;
			parameters[21].Value = model.Welllins;
			parameters[22].Value = model.TolinsDis;
			parameters[23].Value = model.TolinsDeg;
			parameters[24].Value = model.DesLayerName;
			parameters[25].Value = model.ComLayerName;
			parameters[26].Value = model.AimLayer;
			parameters[27].Value = model.LB;
			parameters[28].Value = model.Well_KB;
			parameters[29].Value = model.Well_HB;
			parameters[30].Value = model.Well_Cd;
			parameters[31].Value = model.Well_depth;
			parameters[32].Value = model.Well_Sd;
			parameters[33].Value = model.Well_CX;
			parameters[34].Value = model.Well_BB;
			parameters[35].Value = model.Well_type;
			parameters[36].Value = model.Well_DS;
			parameters[37].Value = model.Wellnum;
			parameters[38].Value = model.Wellname;
			parameters[39].Value = model.BuildF;
			parameters[40].Value = model.Location;
			parameters[41].Value = model.GZLoc;
			parameters[42].Value = model.LogLoc;
			parameters[43].Value = model.DrillAim;
			parameters[44].Value = model.ComRul;
			parameters[45].Value = model.SDate;
			parameters[46].Value = model.EDate;
			parameters[47].Value = model.CDate;
			parameters[48].Value = model.ComSty;
			parameters[49].Value = model.UpdateTime;
			parameters[50].Value = model.Well_Bx1;
			parameters[51].Value = model.Well_By1;
			parameters[52].Value = model.Well_JwBx1;
			parameters[53].Value = model.Well_JwBy1;
			parameters[54].Value = model.Bx_Xs;
			parameters[55].Value = model.Bx_Cs;
			parameters[56].Value = model.Bx_Bxj;
			parameters[57].Value = model.Bx_Xs1;
			parameters[58].Value = model.Bx_Cs1;
			parameters[59].Value = model.Bx_Bxj1;
			parameters[60].Value = model.Sum_SP;
			parameters[61].Value = model.Well_BHDeg;
			parameters[62].Value = model.Length_SP;
			parameters[63].Value = model.Max_JX;
			parameters[64].Value = model.BZ;
			parameters[65].Value = model.JJXD;
			parameters[66].Value = model.SJZQ;
			parameters[67].Value = model.Wellnum_t;
			parameters[68].Value = model.WellnumAndt;
			parameters[69].Value = model.ZQmxV;
			parameters[70].Value = model.Projectteam;
			parameters[71].Value = model.Loggingcompany;
			parameters[72].Value = model.ComDepth;
			parameters[73].Value = model.HCDepth;
			parameters[74].Value = model.HCTime;
			parameters[75].Value = model.LogTechnology;
			parameters[76].Value = model.LJStartDate;
			parameters[77].Value = model.LJEndDate;

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
		public bool Update(SupervDB.Model.CWell model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update CWell set ");
			strSql.Append("YT=@YT,");
			strSql.Append("Well_State=@Well_State,");
			strSql.Append("SQ_date=@SQ_date,");
			strSql.Append("SC_Date=@SC_Date,");
			strSql.Append("SCFS=@SCFS,");
			strSql.Append("Well_X=@Well_X,");
			strSql.Append("Well_Y=@Well_Y,");
			strSql.Append("Well_Jwx=@Well_Jwx,");
			strSql.Append("Well_Jwy=@Well_Jwy,");
			strSql.Append("Well_Bx=@Well_Bx,");
			strSql.Append("Well_By=@Well_By,");
			strSql.Append("Well_JwBx=@Well_JwBx,");
			strSql.Append("Well_JwBy=@Well_JwBy,");
			strSql.Append("Pldeg=@Pldeg,");
			strSql.Append("Pldis=@Pldis,");
			strSql.Append("Zbcdepth=@Zbcdepth,");
			strSql.Append("Totspdis=@Totspdis,");
			strSql.Append("Bdis=@Bdis,");
			strSql.Append("MaxJX=@MaxJX,");
			strSql.Append("Fwei=@Fwei,");
			strSql.Append("AtDep=@AtDep,");
			strSql.Append("Welllins=@Welllins,");
			strSql.Append("TolinsDis=@TolinsDis,");
			strSql.Append("TolinsDeg=@TolinsDeg,");
			strSql.Append("DesLayerName=@DesLayerName,");
			strSql.Append("ComLayerName=@ComLayerName,");
			strSql.Append("AimLayer=@AimLayer,");
			strSql.Append("LB=@LB,");
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
			strSql.Append("SDate=@SDate,");
			strSql.Append("EDate=@EDate,");
			strSql.Append("CDate=@CDate,");
			strSql.Append("ComSty=@ComSty,");
			strSql.Append("UpdateTime=@UpdateTime,");
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
			strSql.Append("Sum_SP=@Sum_SP,");
			strSql.Append("Well_BHDeg=@Well_BHDeg,");
			strSql.Append("Length_SP=@Length_SP,");
			strSql.Append("Max_JX=@Max_JX,");
			strSql.Append("BZ=@BZ,");
			strSql.Append("JJXD=@JJXD,");
			strSql.Append("SJZQ=@SJZQ,");
			strSql.Append("Wellnum_t=@Wellnum_t,");
			strSql.Append("WellnumAndt=@WellnumAndt,");
			strSql.Append("ZQmxV=@ZQmxV,");
			strSql.Append("Projectteam=@Projectteam,");
			strSql.Append("Loggingcompany=@Loggingcompany,");
			strSql.Append("ComDepth=@ComDepth,");
			strSql.Append("HCDepth=@HCDepth,");
			strSql.Append("HCTime=@HCTime,");
			strSql.Append("LogTechnology=@LogTechnology,");
			strSql.Append("LJStartDate=@LJStartDate,");
			strSql.Append("LJEndDate=@LJEndDate");
			strSql.Append(" where Wellnum=@Wellnum ");
			SqlParameter[] parameters = {
					new SqlParameter("@YT", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_State", SqlDbType.NVarChar,50),
					new SqlParameter("@SQ_date", SqlDbType.DateTime),
					new SqlParameter("@SC_Date", SqlDbType.DateTime),
					new SqlParameter("@SCFS", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_X", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_Y", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_Jwx", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_Jwy", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_Bx", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_By", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JwBx", SqlDbType.NVarChar,50),
					new SqlParameter("@Well_JwBy", SqlDbType.NVarChar,50),
					new SqlParameter("@Pldeg", SqlDbType.Float,8),
					new SqlParameter("@Pldis", SqlDbType.Float,8),
					new SqlParameter("@Zbcdepth", SqlDbType.Float,8),
					new SqlParameter("@Totspdis", SqlDbType.Float,8),
					new SqlParameter("@Bdis", SqlDbType.Float,8),
					new SqlParameter("@MaxJX", SqlDbType.Float,8),
					new SqlParameter("@Fwei", SqlDbType.Float,8),
					new SqlParameter("@AtDep", SqlDbType.Float,8),
					new SqlParameter("@Welllins", SqlDbType.NVarChar,50),
					new SqlParameter("@TolinsDis", SqlDbType.Float,8),
					new SqlParameter("@TolinsDeg", SqlDbType.Float,8),
					new SqlParameter("@DesLayerName", SqlDbType.NVarChar,50),
					new SqlParameter("@ComLayerName", SqlDbType.NVarChar,50),
					new SqlParameter("@AimLayer", SqlDbType.NVarChar,50),
					new SqlParameter("@LB", SqlDbType.Int,4),
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
					new SqlParameter("@SDate", SqlDbType.DateTime),
					new SqlParameter("@EDate", SqlDbType.DateTime),
					new SqlParameter("@CDate", SqlDbType.DateTime),
					new SqlParameter("@ComSty", SqlDbType.NVarChar,50),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
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
					new SqlParameter("@Sum_SP", SqlDbType.Float,8),
					new SqlParameter("@Well_BHDeg", SqlDbType.Float,8),
					new SqlParameter("@Length_SP", SqlDbType.Float,8),
					new SqlParameter("@Max_JX", SqlDbType.Float,8),
					new SqlParameter("@BZ", SqlDbType.NVarChar,-1),
					new SqlParameter("@JJXD", SqlDbType.NVarChar,50),
					new SqlParameter("@SJZQ", SqlDbType.NVarChar,50),
					new SqlParameter("@Wellnum_t", SqlDbType.NVarChar,50),
					new SqlParameter("@WellnumAndt", SqlDbType.NVarChar,50),
					new SqlParameter("@ZQmxV", SqlDbType.Float,8),
					new SqlParameter("@Projectteam", SqlDbType.NVarChar,255),
					new SqlParameter("@Loggingcompany", SqlDbType.NVarChar,255),
					new SqlParameter("@ComDepth", SqlDbType.Float,8),
					new SqlParameter("@HCDepth", SqlDbType.Float,8),
					new SqlParameter("@HCTime", SqlDbType.DateTime),
					new SqlParameter("@LogTechnology", SqlDbType.VarChar,255),
					new SqlParameter("@LJStartDate", SqlDbType.DateTime),
					new SqlParameter("@LJEndDate", SqlDbType.DateTime),
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.YT;
			parameters[1].Value = model.Well_State;
			parameters[2].Value = model.SQ_date;
			parameters[3].Value = model.SC_Date;
			parameters[4].Value = model.SCFS;
			parameters[5].Value = model.Well_X;
			parameters[6].Value = model.Well_Y;
			parameters[7].Value = model.Well_Jwx;
			parameters[8].Value = model.Well_Jwy;
			parameters[9].Value = model.Well_Bx;
			parameters[10].Value = model.Well_By;
			parameters[11].Value = model.Well_JwBx;
			parameters[12].Value = model.Well_JwBy;
			parameters[13].Value = model.Pldeg;
			parameters[14].Value = model.Pldis;
			parameters[15].Value = model.Zbcdepth;
			parameters[16].Value = model.Totspdis;
			parameters[17].Value = model.Bdis;
			parameters[18].Value = model.MaxJX;
			parameters[19].Value = model.Fwei;
			parameters[20].Value = model.AtDep;
			parameters[21].Value = model.Welllins;
			parameters[22].Value = model.TolinsDis;
			parameters[23].Value = model.TolinsDeg;
			parameters[24].Value = model.DesLayerName;
			parameters[25].Value = model.ComLayerName;
			parameters[26].Value = model.AimLayer;
			parameters[27].Value = model.LB;
			parameters[28].Value = model.Well_KB;
			parameters[29].Value = model.Well_HB;
			parameters[30].Value = model.Well_Cd;
			parameters[31].Value = model.Well_depth;
			parameters[32].Value = model.Well_Sd;
			parameters[33].Value = model.Well_CX;
			parameters[34].Value = model.Well_BB;
			parameters[35].Value = model.Well_type;
			parameters[36].Value = model.Well_DS;
			parameters[37].Value = model.Wellname;
			parameters[38].Value = model.BuildF;
			parameters[39].Value = model.Location;
			parameters[40].Value = model.GZLoc;
			parameters[41].Value = model.LogLoc;
			parameters[42].Value = model.DrillAim;
			parameters[43].Value = model.ComRul;
			parameters[44].Value = model.SDate;
			parameters[45].Value = model.EDate;
			parameters[46].Value = model.CDate;
			parameters[47].Value = model.ComSty;
			parameters[48].Value = model.UpdateTime;
			parameters[49].Value = model.Well_Bx1;
			parameters[50].Value = model.Well_By1;
			parameters[51].Value = model.Well_JwBx1;
			parameters[52].Value = model.Well_JwBy1;
			parameters[53].Value = model.Bx_Xs;
			parameters[54].Value = model.Bx_Cs;
			parameters[55].Value = model.Bx_Bxj;
			parameters[56].Value = model.Bx_Xs1;
			parameters[57].Value = model.Bx_Cs1;
			parameters[58].Value = model.Bx_Bxj1;
			parameters[59].Value = model.Sum_SP;
			parameters[60].Value = model.Well_BHDeg;
			parameters[61].Value = model.Length_SP;
			parameters[62].Value = model.Max_JX;
			parameters[63].Value = model.BZ;
			parameters[64].Value = model.JJXD;
			parameters[65].Value = model.SJZQ;
			parameters[66].Value = model.Wellnum_t;
			parameters[67].Value = model.WellnumAndt;
			parameters[68].Value = model.ZQmxV;
			parameters[69].Value = model.Projectteam;
			parameters[70].Value = model.Loggingcompany;
			parameters[71].Value = model.ComDepth;
			parameters[72].Value = model.HCDepth;
			parameters[73].Value = model.HCTime;
			parameters[74].Value = model.LogTechnology;
			parameters[75].Value = model.LJStartDate;
			parameters[76].Value = model.LJEndDate;
			parameters[77].Value = model.Wellnum;

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
			strSql.Append("delete from CWell ");
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
			strSql.Append("delete from CWell ");
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
		public SupervDB.Model.CWell GetModel(string Wellnum)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 YT,Well_State,SQ_date,SC_Date,SCFS,Well_X,Well_Y,Well_Jwx,Well_Jwy,Well_Bx,Well_By,Well_JwBx,Well_JwBy,Pldeg,Pldis,Zbcdepth,Totspdis,Bdis,MaxJX,Fwei,AtDep,Welllins,TolinsDis,TolinsDeg,DesLayerName,ComLayerName,AimLayer,LB,Well_KB,Well_HB,Well_Cd,Well_depth,Well_Sd,Well_CX,Well_BB,Well_type,Well_DS,Wellnum,Wellname,BuildF,Location,GZLoc,LogLoc,DrillAim,ComRul,SDate,EDate,CDate,ComSty,UpdateTime,Well_Bx1,Well_By1,Well_JwBx1,Well_JwBy1,Bx_Xs,Bx_Cs,Bx_Bxj,Bx_Xs1,Bx_Cs1,Bx_Bxj1,Sum_SP,Well_BHDeg,Length_SP,Max_JX,BZ,JJXD,SJZQ,Wellnum_t,WellnumAndt,ZQmxV,Projectteam,Loggingcompany,ComDepth,HCDepth,HCTime,LogTechnology,LJStartDate,LJEndDate from CWell ");
			strSql.Append(" where Wellnum=@Wellnum ");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Wellnum;

			SupervDB.Model.CWell model=new SupervDB.Model.CWell();
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
		public SupervDB.Model.CWell DataRowToModel(DataRow row)
		{
			SupervDB.Model.CWell model=new SupervDB.Model.CWell();
			if (row != null)
			{
				if(row["YT"]!=null)
				{
					model.YT=row["YT"].ToString();
				}
				if(row["Well_State"]!=null)
				{
					model.Well_State=row["Well_State"].ToString();
				}
				if(row["SQ_date"]!=null && row["SQ_date"].ToString()!="")
				{
					model.SQ_date=DateTime.Parse(row["SQ_date"].ToString());
				}
				if(row["SC_Date"]!=null && row["SC_Date"].ToString()!="")
				{
					model.SC_Date=DateTime.Parse(row["SC_Date"].ToString());
				}
				if(row["SCFS"]!=null)
				{
					model.SCFS=row["SCFS"].ToString();
				}
				if(row["Well_X"]!=null)
				{
					model.Well_X=row["Well_X"].ToString();
				}
				if(row["Well_Y"]!=null)
				{
					model.Well_Y=row["Well_Y"].ToString();
				}
				if(row["Well_Jwx"]!=null)
				{
					model.Well_Jwx=row["Well_Jwx"].ToString();
				}
				if(row["Well_Jwy"]!=null)
				{
					model.Well_Jwy=row["Well_Jwy"].ToString();
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
				if(row["Pldeg"]!=null && row["Pldeg"].ToString()!="")
				{
					model.Pldeg=decimal.Parse(row["Pldeg"].ToString());
				}
				if(row["Pldis"]!=null && row["Pldis"].ToString()!="")
				{
					model.Pldis=decimal.Parse(row["Pldis"].ToString());
				}
				if(row["Zbcdepth"]!=null && row["Zbcdepth"].ToString()!="")
				{
					model.Zbcdepth=decimal.Parse(row["Zbcdepth"].ToString());
				}
				if(row["Totspdis"]!=null && row["Totspdis"].ToString()!="")
				{
					model.Totspdis=decimal.Parse(row["Totspdis"].ToString());
				}
				if(row["Bdis"]!=null && row["Bdis"].ToString()!="")
				{
					model.Bdis=decimal.Parse(row["Bdis"].ToString());
				}
				if(row["MaxJX"]!=null && row["MaxJX"].ToString()!="")
				{
					model.MaxJX=decimal.Parse(row["MaxJX"].ToString());
				}
				if(row["Fwei"]!=null && row["Fwei"].ToString()!="")
				{
					model.Fwei=decimal.Parse(row["Fwei"].ToString());
				}
				if(row["AtDep"]!=null && row["AtDep"].ToString()!="")
				{
					model.AtDep=decimal.Parse(row["AtDep"].ToString());
				}
				if(row["Welllins"]!=null)
				{
					model.Welllins=row["Welllins"].ToString();
				}
				if(row["TolinsDis"]!=null && row["TolinsDis"].ToString()!="")
				{
					model.TolinsDis=decimal.Parse(row["TolinsDis"].ToString());
				}
				if(row["TolinsDeg"]!=null && row["TolinsDeg"].ToString()!="")
				{
					model.TolinsDeg=decimal.Parse(row["TolinsDeg"].ToString());
				}
				if(row["DesLayerName"]!=null)
				{
					model.DesLayerName=row["DesLayerName"].ToString();
				}
				if(row["ComLayerName"]!=null)
				{
					model.ComLayerName=row["ComLayerName"].ToString();
				}
				if(row["AimLayer"]!=null)
				{
					model.AimLayer=row["AimLayer"].ToString();
				}
				if(row["LB"]!=null && row["LB"].ToString()!="")
				{
					model.LB=int.Parse(row["LB"].ToString());
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
				if(row["ComSty"]!=null)
				{
					model.ComSty=row["ComSty"].ToString();
				}
				if(row["UpdateTime"]!=null && row["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(row["UpdateTime"].ToString());
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
				if(row["Sum_SP"]!=null && row["Sum_SP"].ToString()!="")
				{
					model.Sum_SP=decimal.Parse(row["Sum_SP"].ToString());
				}
				if(row["Well_BHDeg"]!=null && row["Well_BHDeg"].ToString()!="")
				{
					model.Well_BHDeg=decimal.Parse(row["Well_BHDeg"].ToString());
				}
				if(row["Length_SP"]!=null && row["Length_SP"].ToString()!="")
				{
					model.Length_SP=decimal.Parse(row["Length_SP"].ToString());
				}
				if(row["Max_JX"]!=null && row["Max_JX"].ToString()!="")
				{
					model.Max_JX=decimal.Parse(row["Max_JX"].ToString());
				}
				if(row["BZ"]!=null)
				{
					model.BZ=row["BZ"].ToString();
				}
				if(row["JJXD"]!=null)
				{
					model.JJXD=row["JJXD"].ToString();
				}
				if(row["SJZQ"]!=null)
				{
					model.SJZQ=row["SJZQ"].ToString();
				}
				if(row["Wellnum_t"]!=null)
				{
					model.Wellnum_t=row["Wellnum_t"].ToString();
				}
				if(row["WellnumAndt"]!=null)
				{
					model.WellnumAndt=row["WellnumAndt"].ToString();
				}
				if(row["ZQmxV"]!=null && row["ZQmxV"].ToString()!="")
				{
					model.ZQmxV=decimal.Parse(row["ZQmxV"].ToString());
				}
				if(row["Projectteam"]!=null)
				{
					model.Projectteam=row["Projectteam"].ToString();
				}
				if(row["Loggingcompany"]!=null)
				{
					model.Loggingcompany=row["Loggingcompany"].ToString();
				}
				if(row["ComDepth"]!=null && row["ComDepth"].ToString()!="")
				{
					model.ComDepth=decimal.Parse(row["ComDepth"].ToString());
				}
				if(row["HCDepth"]!=null && row["HCDepth"].ToString()!="")
				{
					model.HCDepth=decimal.Parse(row["HCDepth"].ToString());
				}
				if(row["HCTime"]!=null && row["HCTime"].ToString()!="")
				{
					model.HCTime=DateTime.Parse(row["HCTime"].ToString());
				}
				if(row["LogTechnology"]!=null)
				{
					model.LogTechnology=row["LogTechnology"].ToString();
				}
				if(row["LJStartDate"]!=null && row["LJStartDate"].ToString()!="")
				{
					model.LJStartDate=DateTime.Parse(row["LJStartDate"].ToString());
				}
				if(row["LJEndDate"]!=null && row["LJEndDate"].ToString()!="")
				{
					model.LJEndDate=DateTime.Parse(row["LJEndDate"].ToString());
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
			strSql.Append("select YT,Well_State,SQ_date,SC_Date,SCFS,Well_X,Well_Y,Well_Jwx,Well_Jwy,Well_Bx,Well_By,Well_JwBx,Well_JwBy,Pldeg,Pldis,Zbcdepth,Totspdis,Bdis,MaxJX,Fwei,AtDep,Welllins,TolinsDis,TolinsDeg,DesLayerName,ComLayerName,AimLayer,LB,Well_KB,Well_HB,Well_Cd,Well_depth,Well_Sd,Well_CX,Well_BB,Well_type,Well_DS,Wellnum,Wellname,BuildF,Location,GZLoc,LogLoc,DrillAim,ComRul,SDate,EDate,CDate,ComSty,UpdateTime,Well_Bx1,Well_By1,Well_JwBx1,Well_JwBy1,Bx_Xs,Bx_Cs,Bx_Bxj,Bx_Xs1,Bx_Cs1,Bx_Bxj1,Sum_SP,Well_BHDeg,Length_SP,Max_JX,BZ,JJXD,SJZQ,Wellnum_t,WellnumAndt,ZQmxV,Projectteam,Loggingcompany,ComDepth,HCDepth,HCTime,LogTechnology,LJStartDate,LJEndDate ");
			strSql.Append(" FROM CWell ");
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
			strSql.Append(" YT,Well_State,SQ_date,SC_Date,SCFS,Well_X,Well_Y,Well_Jwx,Well_Jwy,Well_Bx,Well_By,Well_JwBx,Well_JwBy,Pldeg,Pldis,Zbcdepth,Totspdis,Bdis,MaxJX,Fwei,AtDep,Welllins,TolinsDis,TolinsDeg,DesLayerName,ComLayerName,AimLayer,LB,Well_KB,Well_HB,Well_Cd,Well_depth,Well_Sd,Well_CX,Well_BB,Well_type,Well_DS,Wellnum,Wellname,BuildF,Location,GZLoc,LogLoc,DrillAim,ComRul,SDate,EDate,CDate,ComSty,UpdateTime,Well_Bx1,Well_By1,Well_JwBx1,Well_JwBy1,Bx_Xs,Bx_Cs,Bx_Bxj,Bx_Xs1,Bx_Cs1,Bx_Bxj1,Sum_SP,Well_BHDeg,Length_SP,Max_JX,BZ,JJXD,SJZQ,Wellnum_t,WellnumAndt,ZQmxV,Projectteam,Loggingcompany,ComDepth,HCDepth,HCTime,LogTechnology,LJStartDate,LJEndDate ");
			strSql.Append(" FROM CWell ");
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
			strSql.Append("select count(1) FROM CWell ");
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
			strSql.Append(")AS Row, T.*  from CWell T ");
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
			parameters[0].Value = "CWell";
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

