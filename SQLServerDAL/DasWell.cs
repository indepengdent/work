
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SupervDB.IDAL;
using DBUtility;//Please add references
namespace SupervDB.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:DasWell
	/// </summary>
	public partial class DasWell:IDasWell
	{
		public DasWell()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Wellnum)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from DasWell");
			strSql.Append(" where Wellnum=@Wellnum ");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Wellnum;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SupervDB.Model.DasWell model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into DasWell(");
			strSql.Append("YxFhl,YxFhl_2,YqFxl,CwKzl,Ycbgl,SjCcl,YxFhlall,YxFhlact,YxFhl_2all,YxFhl_2act,YqFxlall,YqFxlact,Ycbglall,Ycbglact,Qxcs,Qckzs,Yxcs,Yxkzs,Wzcs,Wzkzs,Sum_Layers,Sum_Yq,Sum_Kc,Sum_Yc,Sum_Ck,IsQQQZ,IsFHBZ,Score,YsName,PsDw,PsDate,Fs,Yxs,Cws,Ccs,Yqs,Ycs,Sjs,Bzs,Qqs,Jss,Wellnum,Wellnum_t,SpLen,SpClen,SpYlen,SPCper,SPYper,IsAudit,AcceptTimes)");
			strSql.Append(" values (");
			strSql.Append("@YxFhl,@YxFhl_2,@YqFxl,@CwKzl,@Ycbgl,@SjCcl,@YxFhlall,@YxFhlact,@YxFhl_2all,@YxFhl_2act,@YqFxlall,@YqFxlact,@Ycbglall,@Ycbglact,@Qxcs,@Qckzs,@Yxcs,@Yxkzs,@Wzcs,@Wzkzs,@Sum_Layers,@Sum_Yq,@Sum_Kc,@Sum_Yc,@Sum_Ck,@IsQQQZ,@IsFHBZ,@Score,@YsName,@PsDw,@PsDate,@Fs,@Yxs,@Cws,@Ccs,@Yqs,@Ycs,@Sjs,@Bzs,@Qqs,@Jss,@Wellnum,@Wellnum_t,@SpLen,@SpClen,@SpYlen,@SPCper,@SPYper,@IsAudit,@AcceptTimes)");
			SqlParameter[] parameters = {
					new SqlParameter("@YxFhl", SqlDbType.Float,8),
					new SqlParameter("@YxFhl_2", SqlDbType.Float,8),
					new SqlParameter("@YqFxl", SqlDbType.Float,8),
					new SqlParameter("@CwKzl", SqlDbType.Float,8),
					new SqlParameter("@Ycbgl", SqlDbType.Float,8),
					new SqlParameter("@SjCcl", SqlDbType.Float,8),
					new SqlParameter("@YxFhlall", SqlDbType.Float,8),
					new SqlParameter("@YxFhlact", SqlDbType.Float,8),
					new SqlParameter("@YxFhl_2all", SqlDbType.Float,8),
					new SqlParameter("@YxFhl_2act", SqlDbType.Float,8),
					new SqlParameter("@YqFxlall", SqlDbType.Float,8),
					new SqlParameter("@YqFxlact", SqlDbType.Float,8),
					new SqlParameter("@Ycbglall", SqlDbType.Float,8),
					new SqlParameter("@Ycbglact", SqlDbType.Float,8),
					new SqlParameter("@Qxcs", SqlDbType.Float,8),
					new SqlParameter("@Qckzs", SqlDbType.Float,8),
					new SqlParameter("@Yxcs", SqlDbType.Float,8),
					new SqlParameter("@Yxkzs", SqlDbType.Float,8),
					new SqlParameter("@Wzcs", SqlDbType.Float,8),
					new SqlParameter("@Wzkzs", SqlDbType.Float,8),
					new SqlParameter("@Sum_Layers", SqlDbType.Float,8),
					new SqlParameter("@Sum_Yq", SqlDbType.Float,8),
					new SqlParameter("@Sum_Kc", SqlDbType.Float,8),
					new SqlParameter("@Sum_Yc", SqlDbType.Float,8),
					new SqlParameter("@Sum_Ck", SqlDbType.Float,8),
					new SqlParameter("@IsQQQZ", SqlDbType.NVarChar,50),
					new SqlParameter("@IsFHBZ", SqlDbType.NVarChar,50),
					new SqlParameter("@Score", SqlDbType.NVarChar,50),
					new SqlParameter("@YsName", SqlDbType.NVarChar,50),
					new SqlParameter("@PsDw", SqlDbType.NVarChar,50),
					new SqlParameter("@PsDate", SqlDbType.DateTime),
					new SqlParameter("@Fs", SqlDbType.Float,8),
					new SqlParameter("@Yxs", SqlDbType.Int,4),
					new SqlParameter("@Cws", SqlDbType.Int,4),
					new SqlParameter("@Ccs", SqlDbType.Int,4),
					new SqlParameter("@Yqs", SqlDbType.Int,4),
					new SqlParameter("@Ycs", SqlDbType.Int,4),
					new SqlParameter("@Sjs", SqlDbType.Int,4),
					new SqlParameter("@Bzs", SqlDbType.Int,4),
					new SqlParameter("@Qqs", SqlDbType.Int,4),
					new SqlParameter("@Jss", SqlDbType.Int,4),
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,50),
					new SqlParameter("@Wellnum_t", SqlDbType.NVarChar,50),
					new SqlParameter("@SpLen", SqlDbType.Float,8),
					new SqlParameter("@SpClen", SqlDbType.Float,8),
					new SqlParameter("@SpYlen", SqlDbType.Float,8),
					new SqlParameter("@SPCper", SqlDbType.Float,8),
					new SqlParameter("@SPYper", SqlDbType.Float,8),
					new SqlParameter("@IsAudit", SqlDbType.Bit,1),
					new SqlParameter("@AcceptTimes", SqlDbType.Int,4)};
			parameters[0].Value = model.YxFhl;
			parameters[1].Value = model.YxFhl_2;
			parameters[2].Value = model.YqFxl;
			parameters[3].Value = model.CwKzl;
			parameters[4].Value = model.Ycbgl;
			parameters[5].Value = model.SjCcl;
			parameters[6].Value = model.YxFhlall;
			parameters[7].Value = model.YxFhlact;
			parameters[8].Value = model.YxFhl_2all;
			parameters[9].Value = model.YxFhl_2act;
			parameters[10].Value = model.YqFxlall;
			parameters[11].Value = model.YqFxlact;
			parameters[12].Value = model.Ycbglall;
			parameters[13].Value = model.Ycbglact;
			parameters[14].Value = model.Qxcs;
			parameters[15].Value = model.Qckzs;
			parameters[16].Value = model.Yxcs;
			parameters[17].Value = model.Yxkzs;
			parameters[18].Value = model.Wzcs;
			parameters[19].Value = model.Wzkzs;
			parameters[20].Value = model.Sum_Layers;
			parameters[21].Value = model.Sum_Yq;
			parameters[22].Value = model.Sum_Kc;
			parameters[23].Value = model.Sum_Yc;
			parameters[24].Value = model.Sum_Ck;
			parameters[25].Value = model.IsQQQZ;
			parameters[26].Value = model.IsFHBZ;
			parameters[27].Value = model.Score;
			parameters[28].Value = model.YsName;
			parameters[29].Value = model.PsDw;
			parameters[30].Value = model.PsDate;
			parameters[31].Value = model.Fs;
			parameters[32].Value = model.Yxs;
			parameters[33].Value = model.Cws;
			parameters[34].Value = model.Ccs;
			parameters[35].Value = model.Yqs;
			parameters[36].Value = model.Ycs;
			parameters[37].Value = model.Sjs;
			parameters[38].Value = model.Bzs;
			parameters[39].Value = model.Qqs;
			parameters[40].Value = model.Jss;
			parameters[41].Value = model.Wellnum;
			parameters[42].Value = model.Wellnum_t;
			parameters[43].Value = model.SpLen;
			parameters[44].Value = model.SpClen;
			parameters[45].Value = model.SpYlen;
			parameters[46].Value = model.SPCper;
			parameters[47].Value = model.SPYper;
			parameters[48].Value = model.IsAudit;
			parameters[49].Value = model.AcceptTimes;

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
		public bool Update(SupervDB.Model.DasWell model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update DasWell set ");
			strSql.Append("YxFhl=@YxFhl,");
			strSql.Append("YxFhl_2=@YxFhl_2,");
			strSql.Append("YqFxl=@YqFxl,");
			strSql.Append("CwKzl=@CwKzl,");
			strSql.Append("Ycbgl=@Ycbgl,");
			strSql.Append("SjCcl=@SjCcl,");
			strSql.Append("YxFhlall=@YxFhlall,");
			strSql.Append("YxFhlact=@YxFhlact,");
			strSql.Append("YxFhl_2all=@YxFhl_2all,");
			strSql.Append("YxFhl_2act=@YxFhl_2act,");
			strSql.Append("YqFxlall=@YqFxlall,");
			strSql.Append("YqFxlact=@YqFxlact,");
			strSql.Append("Ycbglall=@Ycbglall,");
			strSql.Append("Ycbglact=@Ycbglact,");
			strSql.Append("Qxcs=@Qxcs,");
			strSql.Append("Qckzs=@Qckzs,");
			strSql.Append("Yxcs=@Yxcs,");
			strSql.Append("Yxkzs=@Yxkzs,");
			strSql.Append("Wzcs=@Wzcs,");
			strSql.Append("Wzkzs=@Wzkzs,");
			strSql.Append("Sum_Layers=@Sum_Layers,");
			strSql.Append("Sum_Yq=@Sum_Yq,");
			strSql.Append("Sum_Kc=@Sum_Kc,");
			strSql.Append("Sum_Yc=@Sum_Yc,");
			strSql.Append("Sum_Ck=@Sum_Ck,");
			strSql.Append("IsQQQZ=@IsQQQZ,");
			strSql.Append("IsFHBZ=@IsFHBZ,");
			strSql.Append("Score=@Score,");
			strSql.Append("YsName=@YsName,");
			strSql.Append("PsDw=@PsDw,");
			strSql.Append("PsDate=@PsDate,");
			strSql.Append("Fs=@Fs,");
			strSql.Append("Yxs=@Yxs,");
			strSql.Append("Cws=@Cws,");
			strSql.Append("Ccs=@Ccs,");
			strSql.Append("Yqs=@Yqs,");
			strSql.Append("Ycs=@Ycs,");
			strSql.Append("Sjs=@Sjs,");
			strSql.Append("Bzs=@Bzs,");
			strSql.Append("Qqs=@Qqs,");
			strSql.Append("Jss=@Jss,");
			strSql.Append("Wellnum_t=@Wellnum_t,");
			strSql.Append("SpLen=@SpLen,");
			strSql.Append("SpClen=@SpClen,");
			strSql.Append("SpYlen=@SpYlen,");
			strSql.Append("SPCper=@SPCper,");
			strSql.Append("SPYper=@SPYper,");
			strSql.Append("IsAudit=@IsAudit,");
			strSql.Append("AcceptTimes=@AcceptTimes");
			strSql.Append(" where Wellnum=@Wellnum ");
			SqlParameter[] parameters = {
					new SqlParameter("@YxFhl", SqlDbType.Float,8),
					new SqlParameter("@YxFhl_2", SqlDbType.Float,8),
					new SqlParameter("@YqFxl", SqlDbType.Float,8),
					new SqlParameter("@CwKzl", SqlDbType.Float,8),
					new SqlParameter("@Ycbgl", SqlDbType.Float,8),
					new SqlParameter("@SjCcl", SqlDbType.Float,8),
					new SqlParameter("@YxFhlall", SqlDbType.Float,8),
					new SqlParameter("@YxFhlact", SqlDbType.Float,8),
					new SqlParameter("@YxFhl_2all", SqlDbType.Float,8),
					new SqlParameter("@YxFhl_2act", SqlDbType.Float,8),
					new SqlParameter("@YqFxlall", SqlDbType.Float,8),
					new SqlParameter("@YqFxlact", SqlDbType.Float,8),
					new SqlParameter("@Ycbglall", SqlDbType.Float,8),
					new SqlParameter("@Ycbglact", SqlDbType.Float,8),
					new SqlParameter("@Qxcs", SqlDbType.Float,8),
					new SqlParameter("@Qckzs", SqlDbType.Float,8),
					new SqlParameter("@Yxcs", SqlDbType.Float,8),
					new SqlParameter("@Yxkzs", SqlDbType.Float,8),
					new SqlParameter("@Wzcs", SqlDbType.Float,8),
					new SqlParameter("@Wzkzs", SqlDbType.Float,8),
					new SqlParameter("@Sum_Layers", SqlDbType.Float,8),
					new SqlParameter("@Sum_Yq", SqlDbType.Float,8),
					new SqlParameter("@Sum_Kc", SqlDbType.Float,8),
					new SqlParameter("@Sum_Yc", SqlDbType.Float,8),
					new SqlParameter("@Sum_Ck", SqlDbType.Float,8),
					new SqlParameter("@IsQQQZ", SqlDbType.NVarChar,50),
					new SqlParameter("@IsFHBZ", SqlDbType.NVarChar,50),
					new SqlParameter("@Score", SqlDbType.NVarChar,50),
					new SqlParameter("@YsName", SqlDbType.NVarChar,50),
					new SqlParameter("@PsDw", SqlDbType.NVarChar,50),
					new SqlParameter("@PsDate", SqlDbType.DateTime),
					new SqlParameter("@Fs", SqlDbType.Float,8),
					new SqlParameter("@Yxs", SqlDbType.Int,4),
					new SqlParameter("@Cws", SqlDbType.Int,4),
					new SqlParameter("@Ccs", SqlDbType.Int,4),
					new SqlParameter("@Yqs", SqlDbType.Int,4),
					new SqlParameter("@Ycs", SqlDbType.Int,4),
					new SqlParameter("@Sjs", SqlDbType.Int,4),
					new SqlParameter("@Bzs", SqlDbType.Int,4),
					new SqlParameter("@Qqs", SqlDbType.Int,4),
					new SqlParameter("@Jss", SqlDbType.Int,4),
					new SqlParameter("@Wellnum_t", SqlDbType.NVarChar,50),
					new SqlParameter("@SpLen", SqlDbType.Float,8),
					new SqlParameter("@SpClen", SqlDbType.Float,8),
					new SqlParameter("@SpYlen", SqlDbType.Float,8),
					new SqlParameter("@SPCper", SqlDbType.Float,8),
					new SqlParameter("@SPYper", SqlDbType.Float,8),
					new SqlParameter("@IsAudit", SqlDbType.Bit,1),
					new SqlParameter("@AcceptTimes", SqlDbType.Int,4),
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.YxFhl;
			parameters[1].Value = model.YxFhl_2;
			parameters[2].Value = model.YqFxl;
			parameters[3].Value = model.CwKzl;
			parameters[4].Value = model.Ycbgl;
			parameters[5].Value = model.SjCcl;
			parameters[6].Value = model.YxFhlall;
			parameters[7].Value = model.YxFhlact;
			parameters[8].Value = model.YxFhl_2all;
			parameters[9].Value = model.YxFhl_2act;
			parameters[10].Value = model.YqFxlall;
			parameters[11].Value = model.YqFxlact;
			parameters[12].Value = model.Ycbglall;
			parameters[13].Value = model.Ycbglact;
			parameters[14].Value = model.Qxcs;
			parameters[15].Value = model.Qckzs;
			parameters[16].Value = model.Yxcs;
			parameters[17].Value = model.Yxkzs;
			parameters[18].Value = model.Wzcs;
			parameters[19].Value = model.Wzkzs;
			parameters[20].Value = model.Sum_Layers;
			parameters[21].Value = model.Sum_Yq;
			parameters[22].Value = model.Sum_Kc;
			parameters[23].Value = model.Sum_Yc;
			parameters[24].Value = model.Sum_Ck;
			parameters[25].Value = model.IsQQQZ;
			parameters[26].Value = model.IsFHBZ;
			parameters[27].Value = model.Score;
			parameters[28].Value = model.YsName;
			parameters[29].Value = model.PsDw;
			parameters[30].Value = model.PsDate;
			parameters[31].Value = model.Fs;
			parameters[32].Value = model.Yxs;
			parameters[33].Value = model.Cws;
			parameters[34].Value = model.Ccs;
			parameters[35].Value = model.Yqs;
			parameters[36].Value = model.Ycs;
			parameters[37].Value = model.Sjs;
			parameters[38].Value = model.Bzs;
			parameters[39].Value = model.Qqs;
			parameters[40].Value = model.Jss;
			parameters[41].Value = model.Wellnum_t;
			parameters[42].Value = model.SpLen;
			parameters[43].Value = model.SpClen;
			parameters[44].Value = model.SpYlen;
			parameters[45].Value = model.SPCper;
			parameters[46].Value = model.SPYper;
			parameters[47].Value = model.IsAudit;
			parameters[48].Value = model.AcceptTimes;
			parameters[49].Value = model.Wellnum;

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
			strSql.Append("delete from DasWell ");
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
			strSql.Append("delete from DasWell ");
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
		public SupervDB.Model.DasWell GetModel(string Wellnum)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 YxFhl,YxFhl_2,YqFxl,CwKzl,Ycbgl,SjCcl,YxFhlall,YxFhlact,YxFhl_2all,YxFhl_2act,YqFxlall,YqFxlact,Ycbglall,Ycbglact,Qxcs,Qckzs,Yxcs,Yxkzs,Wzcs,Wzkzs,Sum_Layers,Sum_Yq,Sum_Kc,Sum_Yc,Sum_Ck,IsQQQZ,IsFHBZ,Score,YsName,PsDw,PsDate,Fs,Yxs,Cws,Ccs,Yqs,Ycs,Sjs,Bzs,Qqs,Jss,Wellnum,Wellnum_t,SpLen,SpClen,SpYlen,SPCper,SPYper,IsAudit,AcceptTimes from DasWell ");
			strSql.Append(" where Wellnum=@Wellnum ");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,50)			};
			parameters[0].Value = Wellnum;

			SupervDB.Model.DasWell model=new SupervDB.Model.DasWell();
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
		public SupervDB.Model.DasWell DataRowToModel(DataRow row)
		{
			SupervDB.Model.DasWell model=new SupervDB.Model.DasWell();
			if (row != null)
			{
				if(row["YxFhl"]!=null && row["YxFhl"].ToString()!="")
				{
					model.YxFhl=decimal.Parse(row["YxFhl"].ToString());
				}
				if(row["YxFhl_2"]!=null && row["YxFhl_2"].ToString()!="")
				{
					model.YxFhl_2=decimal.Parse(row["YxFhl_2"].ToString());
				}
				if(row["YqFxl"]!=null && row["YqFxl"].ToString()!="")
				{
					model.YqFxl=decimal.Parse(row["YqFxl"].ToString());
				}
				if(row["CwKzl"]!=null && row["CwKzl"].ToString()!="")
				{
					model.CwKzl=decimal.Parse(row["CwKzl"].ToString());
				}
				if(row["Ycbgl"]!=null && row["Ycbgl"].ToString()!="")
				{
					model.Ycbgl=decimal.Parse(row["Ycbgl"].ToString());
				}
				if(row["SjCcl"]!=null && row["SjCcl"].ToString()!="")
				{
					model.SjCcl=decimal.Parse(row["SjCcl"].ToString());
				}
				if(row["YxFhlall"]!=null && row["YxFhlall"].ToString()!="")
				{
					model.YxFhlall=decimal.Parse(row["YxFhlall"].ToString());
				}
				if(row["YxFhlact"]!=null && row["YxFhlact"].ToString()!="")
				{
					model.YxFhlact=decimal.Parse(row["YxFhlact"].ToString());
				}
				if(row["YxFhl_2all"]!=null && row["YxFhl_2all"].ToString()!="")
				{
					model.YxFhl_2all=decimal.Parse(row["YxFhl_2all"].ToString());
				}
				if(row["YxFhl_2act"]!=null && row["YxFhl_2act"].ToString()!="")
				{
					model.YxFhl_2act=decimal.Parse(row["YxFhl_2act"].ToString());
				}
				if(row["YqFxlall"]!=null && row["YqFxlall"].ToString()!="")
				{
					model.YqFxlall=decimal.Parse(row["YqFxlall"].ToString());
				}
				if(row["YqFxlact"]!=null && row["YqFxlact"].ToString()!="")
				{
					model.YqFxlact=decimal.Parse(row["YqFxlact"].ToString());
				}
				if(row["Ycbglall"]!=null && row["Ycbglall"].ToString()!="")
				{
					model.Ycbglall=decimal.Parse(row["Ycbglall"].ToString());
				}
				if(row["Ycbglact"]!=null && row["Ycbglact"].ToString()!="")
				{
					model.Ycbglact=decimal.Parse(row["Ycbglact"].ToString());
				}
				if(row["Qxcs"]!=null && row["Qxcs"].ToString()!="")
				{
					model.Qxcs=decimal.Parse(row["Qxcs"].ToString());
				}
				if(row["Qckzs"]!=null && row["Qckzs"].ToString()!="")
				{
					model.Qckzs=decimal.Parse(row["Qckzs"].ToString());
				}
				if(row["Yxcs"]!=null && row["Yxcs"].ToString()!="")
				{
					model.Yxcs=decimal.Parse(row["Yxcs"].ToString());
				}
				if(row["Yxkzs"]!=null && row["Yxkzs"].ToString()!="")
				{
					model.Yxkzs=decimal.Parse(row["Yxkzs"].ToString());
				}
				if(row["Wzcs"]!=null && row["Wzcs"].ToString()!="")
				{
					model.Wzcs=decimal.Parse(row["Wzcs"].ToString());
				}
				if(row["Wzkzs"]!=null && row["Wzkzs"].ToString()!="")
				{
					model.Wzkzs=decimal.Parse(row["Wzkzs"].ToString());
				}
				if(row["Sum_Layers"]!=null && row["Sum_Layers"].ToString()!="")
				{
					model.Sum_Layers=decimal.Parse(row["Sum_Layers"].ToString());
				}
				if(row["Sum_Yq"]!=null && row["Sum_Yq"].ToString()!="")
				{
					model.Sum_Yq=decimal.Parse(row["Sum_Yq"].ToString());
				}
				if(row["Sum_Kc"]!=null && row["Sum_Kc"].ToString()!="")
				{
					model.Sum_Kc=decimal.Parse(row["Sum_Kc"].ToString());
				}
				if(row["Sum_Yc"]!=null && row["Sum_Yc"].ToString()!="")
				{
					model.Sum_Yc=decimal.Parse(row["Sum_Yc"].ToString());
				}
				if(row["Sum_Ck"]!=null && row["Sum_Ck"].ToString()!="")
				{
					model.Sum_Ck=decimal.Parse(row["Sum_Ck"].ToString());
				}
				if(row["IsQQQZ"]!=null)
				{
					model.IsQQQZ=row["IsQQQZ"].ToString();
				}
				if(row["IsFHBZ"]!=null)
				{
					model.IsFHBZ=row["IsFHBZ"].ToString();
				}
				if(row["Score"]!=null)
				{
					model.Score=row["Score"].ToString();
				}
				if(row["YsName"]!=null)
				{
					model.YsName=row["YsName"].ToString();
				}
				if(row["PsDw"]!=null)
				{
					model.PsDw=row["PsDw"].ToString();
				}
				if(row["PsDate"]!=null && row["PsDate"].ToString()!="")
				{
					model.PsDate=DateTime.Parse(row["PsDate"].ToString());
				}
				if(row["Fs"]!=null && row["Fs"].ToString()!="")
				{
					model.Fs=decimal.Parse(row["Fs"].ToString());
				}
				if(row["Yxs"]!=null && row["Yxs"].ToString()!="")
				{
					model.Yxs=int.Parse(row["Yxs"].ToString());
				}
				if(row["Cws"]!=null && row["Cws"].ToString()!="")
				{
					model.Cws=int.Parse(row["Cws"].ToString());
				}
				if(row["Ccs"]!=null && row["Ccs"].ToString()!="")
				{
					model.Ccs=int.Parse(row["Ccs"].ToString());
				}
				if(row["Yqs"]!=null && row["Yqs"].ToString()!="")
				{
					model.Yqs=int.Parse(row["Yqs"].ToString());
				}
				if(row["Ycs"]!=null && row["Ycs"].ToString()!="")
				{
					model.Ycs=int.Parse(row["Ycs"].ToString());
				}
				if(row["Sjs"]!=null && row["Sjs"].ToString()!="")
				{
					model.Sjs=int.Parse(row["Sjs"].ToString());
				}
				if(row["Bzs"]!=null && row["Bzs"].ToString()!="")
				{
					model.Bzs=int.Parse(row["Bzs"].ToString());
				}
				if(row["Qqs"]!=null && row["Qqs"].ToString()!="")
				{
					model.Qqs=int.Parse(row["Qqs"].ToString());
				}
				if(row["Jss"]!=null && row["Jss"].ToString()!="")
				{
					model.Jss=int.Parse(row["Jss"].ToString());
				}
				if(row["Wellnum"]!=null)
				{
					model.Wellnum=row["Wellnum"].ToString();
				}
				if(row["Wellnum_t"]!=null)
				{
					model.Wellnum_t=row["Wellnum_t"].ToString();
				}
				if(row["SpLen"]!=null && row["SpLen"].ToString()!="")
				{
					model.SpLen=decimal.Parse(row["SpLen"].ToString());
				}
				if(row["SpClen"]!=null && row["SpClen"].ToString()!="")
				{
					model.SpClen=decimal.Parse(row["SpClen"].ToString());
				}
				if(row["SpYlen"]!=null && row["SpYlen"].ToString()!="")
				{
					model.SpYlen=decimal.Parse(row["SpYlen"].ToString());
				}
				if(row["SPCper"]!=null && row["SPCper"].ToString()!="")
				{
					model.SPCper=decimal.Parse(row["SPCper"].ToString());
				}
				if(row["SPYper"]!=null && row["SPYper"].ToString()!="")
				{
					model.SPYper=decimal.Parse(row["SPYper"].ToString());
				}
				if(row["IsAudit"]!=null && row["IsAudit"].ToString()!="")
				{
					if((row["IsAudit"].ToString()=="1")||(row["IsAudit"].ToString().ToLower()=="true"))
					{
						model.IsAudit=true;
					}
					else
					{
						model.IsAudit=false;
					}
				}
				if(row["AcceptTimes"]!=null && row["AcceptTimes"].ToString()!="")
				{
					model.AcceptTimes=int.Parse(row["AcceptTimes"].ToString());
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
			strSql.Append("select YxFhl,YxFhl_2,YqFxl,CwKzl,Ycbgl,SjCcl,YxFhlall,YxFhlact,YxFhl_2all,YxFhl_2act,YqFxlall,YqFxlact,Ycbglall,Ycbglact,Qxcs,Qckzs,Yxcs,Yxkzs,Wzcs,Wzkzs,Sum_Layers,Sum_Yq,Sum_Kc,Sum_Yc,Sum_Ck,IsQQQZ,IsFHBZ,Score,YsName,PsDw,PsDate,Fs,Yxs,Cws,Ccs,Yqs,Ycs,Sjs,Bzs,Qqs,Jss,Wellnum,Wellnum_t,SpLen,SpClen,SpYlen,SPCper,SPYper,IsAudit,AcceptTimes ");
			strSql.Append(" FROM DasWell ");
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
			strSql.Append(" YxFhl,YxFhl_2,YqFxl,CwKzl,Ycbgl,SjCcl,YxFhlall,YxFhlact,YxFhl_2all,YxFhl_2act,YqFxlall,YqFxlact,Ycbglall,Ycbglact,Qxcs,Qckzs,Yxcs,Yxkzs,Wzcs,Wzkzs,Sum_Layers,Sum_Yq,Sum_Kc,Sum_Yc,Sum_Ck,IsQQQZ,IsFHBZ,Score,YsName,PsDw,PsDate,Fs,Yxs,Cws,Ccs,Yqs,Ycs,Sjs,Bzs,Qqs,Jss,Wellnum,Wellnum_t,SpLen,SpClen,SpYlen,SPCper,SPYper,IsAudit,AcceptTimes ");
			strSql.Append(" FROM DasWell ");
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
			strSql.Append("select count(1) FROM DasWell ");
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
			strSql.Append(")AS Row, T.*  from DasWell T ");
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
			parameters[0].Value = "DasWell";
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

