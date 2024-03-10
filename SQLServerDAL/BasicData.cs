
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using SupervDB.IDAL;
using DBUtility;//Please add references
namespace SupervDB.SQLServerDAL
{
	/// <summary>
	/// 数据访问类:BasicData
	/// </summary>
	public partial class BasicData:IBasicData
	{
		public BasicData()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "BasicData"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from BasicData");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SupervDB.Model.BasicData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into BasicData(");
            //strSql.Append("ID,Wellnum,Updatetime,Well_depth,LayerBits,Density,Viscosity,JdName,JdNum,LogGeologist,InEngineer,ManholeSection,PacketNum,Cum_Depth,Cum_layerNum,Savetime)");
            strSql.Append("Wellnum,Updatetime,Well_depth,LayerBits,Density,Viscosity,JdName,JdNum,LogGeologist,InEngineer,ManholeSection,PacketNum,Cum_Depth,Cum_layerNum,Savetime)");
            strSql.Append(" values (");
			//strSql.Append("@ID,@Wellnum,@Updatetime,@Well_depth,@LayerBits,@Density,@Viscosity,@JdName,@JdNum,@LogGeologist,@InEngineer,@ManholeSection,@PacketNum,@Cum_Depth,@Cum_layerNum,@Savetime)");
            strSql.Append("@Wellnum,@Updatetime,@Well_depth,@LayerBits,@Density,@Viscosity,@JdName,@JdNum,@LogGeologist,@InEngineer,@ManholeSection,@PacketNum,@Cum_Depth,@Cum_layerNum,@Savetime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					//new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,255),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@Well_depth", SqlDbType.Decimal,9),
					new SqlParameter("@LayerBits", SqlDbType.NVarChar,255),
					new SqlParameter("@Density", SqlDbType.Decimal,9),
					new SqlParameter("@Viscosity", SqlDbType.Decimal,9),
					new SqlParameter("@JdName", SqlDbType.NVarChar,255),
					new SqlParameter("@JdNum", SqlDbType.NVarChar,255),
					new SqlParameter("@LogGeologist", SqlDbType.NVarChar,255),
					new SqlParameter("@InEngineer", SqlDbType.NVarChar,255),
					new SqlParameter("@ManholeSection", SqlDbType.Decimal,9),
					new SqlParameter("@PacketNum", SqlDbType.Decimal,9),
					new SqlParameter("@Cum_Depth", SqlDbType.Decimal,9),
					new SqlParameter("@Cum_layerNum", SqlDbType.Decimal,9),
                    new SqlParameter("@Savetime", SqlDbType.DateTime)};
            //parameters[0].Value = model.ID;
            //parameters[1].Value = model.Wellnum;
            //parameters[2].Value = model.Updatetime;
            //parameters[3].Value = model.Well_depth;
            //parameters[4].Value = model.LayerBits;
            //parameters[5].Value = model.Density;
            //parameters[6].Value = model.Viscosity;
            //parameters[7].Value = model.JdName;
            //parameters[8].Value = model.JdNum;
            //parameters[9].Value = model.LogGeologist;
            //parameters[10].Value = model.InEngineer;
            //parameters[11].Value = model.ManholeSection;
            //parameters[12].Value = model.PacketNum;
            //parameters[13].Value = model.Cum_Depth;
            //parameters[14].Value = model.Cum_layerNum;
            //parameters[15].Value = model.Savetime;


            parameters[0].Value = model.Wellnum;
            parameters[1].Value = model.Updatetime;
            parameters[2].Value = model.Well_depth;
            parameters[3].Value = model.LayerBits;
            parameters[4].Value = model.Density;
            parameters[5].Value = model.Viscosity;
            parameters[6].Value = model.JdName;
            parameters[7].Value = model.JdNum;
            parameters[8].Value = model.LogGeologist;
            parameters[9].Value = model.InEngineer;
            parameters[10].Value = model.ManholeSection;
            parameters[12].Value = model.PacketNum;
            parameters[13].Value = model.Cum_Depth;
            parameters[13].Value = model.Cum_layerNum;
            parameters[14].Value = model.Savetime;

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
		public bool Update(SupervDB.Model.BasicData model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update BasicData set ");
			strSql.Append("Wellnum=@Wellnum,");
			strSql.Append("Updatetime=@Updatetime,");
			strSql.Append("Well_depth=@Well_depth,");
			strSql.Append("LayerBits=@LayerBits,");
			strSql.Append("Density=@Density,");
			strSql.Append("Viscosity=@Viscosity,");
			strSql.Append("JdName=@JdName,");
			strSql.Append("JdNum=@JdNum,");
			strSql.Append("LogGeologist=@LogGeologist,");
			strSql.Append("InEngineer=@InEngineer,");
			strSql.Append("ManholeSection=@ManholeSection,");
			strSql.Append("PacketNum=@PacketNum,");
			strSql.Append("Cum_Depth=@Cum_Depth,");
			strSql.Append("Cum_layerNum=@Cum_layerNum,");
            strSql.Append("Savetime=@Savetime");
            strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Wellnum", SqlDbType.NVarChar,255),
					new SqlParameter("@Updatetime", SqlDbType.DateTime),
					new SqlParameter("@Well_depth", SqlDbType.Decimal,9),
					new SqlParameter("@LayerBits", SqlDbType.NVarChar,255),
					new SqlParameter("@Density", SqlDbType.Decimal,9),
					new SqlParameter("@Viscosity", SqlDbType.Decimal,9),
					new SqlParameter("@JdName", SqlDbType.NVarChar,255),
					new SqlParameter("@JdNum", SqlDbType.NVarChar,255),
					new SqlParameter("@LogGeologist", SqlDbType.NVarChar,255),
					new SqlParameter("@InEngineer", SqlDbType.NVarChar,255),
					new SqlParameter("@ManholeSection", SqlDbType.Decimal,9),
					new SqlParameter("@PacketNum", SqlDbType.Decimal,9),
					new SqlParameter("@Cum_Depth", SqlDbType.Decimal,9),
					new SqlParameter("@Cum_layerNum", SqlDbType.Decimal,9),
                    new SqlParameter("@Savetime", SqlDbType.DateTime),
                    new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Wellnum;
			parameters[1].Value = model.Updatetime;
			parameters[2].Value = model.Well_depth;
			parameters[3].Value = model.LayerBits;
			parameters[4].Value = model.Density;
			parameters[5].Value = model.Viscosity;
			parameters[6].Value = model.JdName;
			parameters[7].Value = model.JdNum;
			parameters[8].Value = model.LogGeologist;
			parameters[9].Value = model.InEngineer;
			parameters[10].Value = model.ManholeSection;
			parameters[11].Value = model.PacketNum;
			parameters[12].Value = model.Cum_Depth;
			parameters[13].Value = model.Cum_layerNum;
            parameters[14].Value = model.Savetime;
			parameters[15].Value = model.ID;

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
			strSql.Append("delete from BasicData ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)			};
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
			strSql.Append("delete from BasicData ");
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
		public SupervDB.Model.BasicData GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,Wellnum,Updatetime,Well_depth,LayerBits,Density,Viscosity,JdName,JdNum,LogGeologist,InEngineer,ManholeSection,PacketNum,Cum_Depth,Cum_layerNum,Savetime from BasicData ");
			strSql.Append(" where ID=@ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)			};
			parameters[0].Value = ID;

			SupervDB.Model.BasicData model=new SupervDB.Model.BasicData();
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
		public SupervDB.Model.BasicData DataRowToModel(DataRow row)
		{
			SupervDB.Model.BasicData model=new SupervDB.Model.BasicData();
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
                if (row["Savetime"] != null && row["Savetime"].ToString() != "")
                {
                    model.Savetime = DateTime.Parse(row["Savetime"].ToString());
                }
                if (row["Well_depth"]!=null && row["Well_depth"].ToString()!="")
				{
					model.Well_depth=decimal.Parse(row["Well_depth"].ToString());
				}
				if(row["LayerBits"]!=null)
				{
					model.LayerBits=row["LayerBits"].ToString();
				}
				if(row["Density"]!=null && row["Density"].ToString()!="")
				{
					model.Density=decimal.Parse(row["Density"].ToString());
				}
				if(row["Viscosity"]!=null && row["Viscosity"].ToString()!="")
				{
					model.Viscosity=decimal.Parse(row["Viscosity"].ToString());
				}
				if(row["JdName"]!=null)
				{
					model.JdName=row["JdName"].ToString();
				}
				if(row["JdNum"]!=null)
				{
					model.JdNum=row["JdNum"].ToString();
				}
				if(row["LogGeologist"]!=null)
				{
					model.LogGeologist=row["LogGeologist"].ToString();
				}
				if(row["InEngineer"]!=null)
				{
					model.InEngineer=row["InEngineer"].ToString();
				}
				if(row["ManholeSection"]!=null && row["ManholeSection"].ToString()!="")
				{
					model.ManholeSection=decimal.Parse(row["ManholeSection"].ToString());
				}
				if(row["PacketNum"]!=null && row["PacketNum"].ToString()!="")
				{
					model.PacketNum=decimal.Parse(row["PacketNum"].ToString());
				}
				if(row["Cum_Depth"]!=null && row["Cum_Depth"].ToString()!="")
				{
					model.Cum_Depth=decimal.Parse(row["Cum_Depth"].ToString());
				}
				if(row["Cum_layerNum"]!=null && row["Cum_layerNum"].ToString()!="")
				{
					model.Cum_layerNum=decimal.Parse(row["Cum_layerNum"].ToString());
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
			strSql.Append("select ID,Wellnum,Updatetime,Well_depth,LayerBits,Density,Viscosity,JdName,JdNum,LogGeologist,InEngineer,ManholeSection,PacketNum,Cum_Depth,Cum_layerNum,Savetime ");
			strSql.Append(" FROM BasicData ");
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
			strSql.Append(" ID,Wellnum,Updatetime,Well_depth,LayerBits,Density,Viscosity,JdName,JdNum,LogGeologist,InEngineer,ManholeSection,PacketNum,Cum_Depth,Cum_layerNum,Savetime");
			strSql.Append(" FROM BasicData ");
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
			strSql.Append("select count(1) FROM BasicData ");
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
			strSql.Append(")AS Row, T.*  from BasicData T ");
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
			parameters[0].Value = "BasicData";
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

