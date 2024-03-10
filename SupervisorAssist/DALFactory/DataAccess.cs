using System;
using System.Reflection;
using System.Configuration;
using SupervDB.IDAL;
using Common;

namespace SupervDB.DALFactory
{
	/// <summary>
	/// 抽象工厂模式创建DAL。
	/// web.config 需要加入配置：(利用工厂模式+反射机制+缓存机制,实现动态创建不同的数据层对象接口) 
	/// DataCache类在导出代码的文件夹里
	/// <appSettings> 
	/// <add key="DAL" value="SupervDB.SQLServerDAL" /> (这里的命名空间根据实际情况更改为自己项目的命名空间)
	/// </appSettings> 
	/// </summary>
	public sealed class DataAccess//<t>
	{
		private static readonly string AssemblyPath = ConfigurationManager.AppSettings["DAL"];
		/// <summary>
		/// 创建对象或从缓存获取
		/// </summary>
		public static object CreateObject(string AssemblyPath,string ClassNamespace)
		{
			object objType = DataCache.GetCache(ClassNamespace);//从缓存读取
			if (objType == null)
			{
				try
				{
					objType = Assembly.Load(AssemblyPath).CreateInstance(ClassNamespace);//反射创建
					DataCache.SetCache(ClassNamespace, objType);// 写入缓存
				}
				catch
				{}
			}
			return objType;
		}
		/// <summary>
		/// 创建数据层接口
		/// </summary>
		//public static t Create(string ClassName)
		//{
		//string ClassNamespace = AssemblyPath +"."+ ClassName;
		//object objType = CreateObject(AssemblyPath, ClassNamespace);
		//return (t)objType;
		//}

		/// <summary>
		/// 创建DrillGroupQua数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IDrillGroupQua CreateDrillGroupQua()
		{

			string ClassNamespace = AssemblyPath + ".DrillGroupQua";
			object objType = CreateObject(AssemblyPath, ClassNamespace);
			return (SupervDB.IDAL.IDrillGroupQua)objType;
		}

		/// <summary>
		/// 创建CWell数据层接口。
		/// </summary>
		public static SupervDB.IDAL.ICWell CreateCWell()
		{

			string ClassNamespace = AssemblyPath + ".CWell";
			object objType = CreateObject(AssemblyPath, ClassNamespace);
			return (SupervDB.IDAL.ICWell)objType;
		}

		/// <summary>
		/// 创建Staff数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IStaff CreateStaff()
		{

			string ClassNamespace = AssemblyPath + ".Staff";
			object objType = CreateObject(AssemblyPath, ClassNamespace);
			return (SupervDB.IDAL.IStaff)objType;
		}

		/// <summary>
		/// 创建DasWell数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IDasWell CreateDasWell()
		{

			string ClassNamespace = AssemblyPath + ".DasWell";
			object objType = CreateObject(AssemblyPath, ClassNamespace);
			return (SupervDB.IDAL.IDasWell)objType;
		}


		/// <summary>
		/// 创建WellDesign数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IWellDesign CreateWellDesign()
		{

			string ClassNamespace = AssemblyPath + ".WellDesign";
			object objType = CreateObject(AssemblyPath, ClassNamespace);
			return (SupervDB.IDAL.IWellDesign)objType;
		}

		/// <summary>
		/// 创建BasicData数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IBasicData CreateBasicData()
		{

			string ClassNamespace = AssemblyPath + ".BasicData";
			object objType = CreateObject(AssemblyPath, ClassNamespace);
			return (SupervDB.IDAL.IBasicData)objType;
		}

		/// <summary>
		/// 创建User数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IUsers CreateUsers()
		{

			string ClassNamespace = AssemblyPath + ".Users";
			object objType = CreateObject(AssemblyPath, ClassNamespace);
			return (SupervDB.IDAL.IUsers)objType;
		}

		/// <summary>
		/// 创建DataAcqSoft数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IDataAcqSoft CreateDataAcqSoft()
		{

			string ClassNamespace = AssemblyPath +".DataAcqSoft";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IDataAcqSoft)objType;
		}


		/// <summary>
		/// 创建DeaeratorEquip数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IDeaeratorEquip CreateDeaeratorEquip()
		{

			string ClassNamespace = AssemblyPath +".DeaeratorEquip";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IDeaeratorEquip)objType;
		}

		/// <summary>
		/// 创建DeviceChange数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IDeviceChange CreateDeviceChange()
		{

			string ClassNamespace = AssemblyPath +".DeviceChange";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IDeviceChange)objType;
		}

		/// <summary>
		/// 创建DriTSMana数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IDriTSMana CreateDriTSMana()
		{

			string ClassNamespace = AssemblyPath +".DriTSMana";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IDriTSMana)objType;
		}

		/// <summary>
		/// 创建EquipCAI数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IEquipCAI CreateEquipCAI()
		{

			string ClassNamespace = AssemblyPath +".EquipCAI";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IEquipCAI)objType;
		}

		/// <summary>
		/// 创建EvalLogEquip数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IEvalLogEquip CreateEvalLogEquip()
		{

			string ClassNamespace = AssemblyPath +".EvalLogEquip";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IEvalLogEquip)objType;
		}

		/// <summary>
		/// 创建EvaluationLog数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IEvaluationLog CreateEvaluationLog()
		{

			string ClassNamespace = AssemblyPath +".EvaluationLog";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IEvaluationLog)objType;
		}

		/// <summary>
		/// 创建GeoREquip数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IGeoREquip CreateGeoREquip()
		{

			string ClassNamespace = AssemblyPath +".GeoREquip";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IGeoREquip)objType;
		}

		/// <summary>
		/// 创建GeoSuperv数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IGeoSuperv CreateGeoSuperv()
		{

			string ClassNamespace = AssemblyPath +".GeoSuperv";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IGeoSuperv)objType;
		}

		/// <summary>
		/// 创建KeySituation数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IKeySituation CreateKeySituation()
		{

			string ClassNamespace = AssemblyPath +".KeySituation";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IKeySituation)objType;
		}

		/// <summary>
		/// 创建LogProjects数据层接口。
		/// </summary>
		public static SupervDB.IDAL.ILogProjects CreateLogProjects()
		{

			string ClassNamespace = AssemblyPath +".LogProjects";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.ILogProjects)objType;
		}

		/// <summary>
		/// 创建LogService数据层接口。
		/// </summary>
		public static SupervDB.IDAL.ILogService CreateLogService()
		{

			string ClassNamespace = AssemblyPath +".LogService";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.ILogService)objType;
		}

		/// <summary>
		/// 创建LogWells_SitDuty数据层接口。
		/// </summary>
		public static SupervDB.IDAL.ILogWells_SitDuty CreateLogWells_SitDuty()
		{

			string ClassNamespace = AssemblyPath +".LogWells_SitDuty";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.ILogWells_SitDuty)objType;
		}

		/// <summary>
		/// 创建LogWorkloadSta_Footage数据层接口。
		/// </summary>
		public static SupervDB.IDAL.ILogWorkloadSta_Footage CreateLogWorkloadSta_Footage()
		{

			string ClassNamespace = AssemblyPath +".LogWorkloadSta_Footage";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.ILogWorkloadSta_Footage)objType;
		}

		/// <summary>
		/// 创建MonitPlan数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IMonitPlan CreateMonitPlan()
		{

			string ClassNamespace = AssemblyPath +".MonitPlan";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IMonitPlan)objType;
		}

		/// <summary>
		/// 创建OnDataTran数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IOnDataTran CreateOnDataTran()
		{

			string ClassNamespace = AssemblyPath +".OnDataTran";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IOnDataTran)objType;
		}

		/// <summary>
		/// 创建OrganiZownTime数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IOrganiZownTime CreateOrganiZownTime()
		{

			string ClassNamespace = AssemblyPath +".OrganiZownTime";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IOrganiZownTime)objType;
		}

		/// <summary>
		/// 创建OtherProjects数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IOtherProjects CreateOtherProjects()
		{

			string ClassNamespace = AssemblyPath +".OtherProjects";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IOtherProjects)objType;
		}

		/// <summary>
		/// 创建PersonChange数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IPersonChange CreatePersonChange()
		{

			string ClassNamespace = AssemblyPath +".PersonChange";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IPersonChange)objType;
		}

		/// <summary>
		/// 创建PrepareMaterials数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IPrepareMaterials CreatePrepareMaterials()
		{

			string ClassNamespace = AssemblyPath +".PrepareMaterials";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IPrepareMaterials)objType;
		}

		/// <summary>
		/// 创建ProjectComplex数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IProjectComplex CreateProjectComplex()
		{

			string ClassNamespace = AssemblyPath +".ProjectComplex";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IProjectComplex)objType;
		}

		/// <summary>
		/// 创建SensorEquip数据层接口。
		/// </summary>
		public static SupervDB.IDAL.ISensorEquip CreateSensorEquip()
		{

			string ClassNamespace = AssemblyPath +".SensorEquip";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.ISensorEquip)objType;
		}

		/// <summary>
		/// 创建StaffDocu数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IStaffDocu CreateStaffDocu()
		{

			string ClassNamespace = AssemblyPath +".StaffDocu";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IStaffDocu)objType;
		}

		/// <summary>
		/// 创建TeamQual数据层接口。
		/// </summary>
		public static SupervDB.IDAL.ITeamQual CreateTeamQual()
		{

			string ClassNamespace = AssemblyPath +".TeamQual";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.ITeamQual)objType;
		}

		/// <summary>
		/// 创建WellStructure数据层接口。
		/// </summary>
		public static SupervDB.IDAL.IWellStructure CreateWellStructure()
		{

			string ClassNamespace = AssemblyPath +".WellStructure";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (SupervDB.IDAL.IWellStructure)objType;
		}

        /// <summary>
		/// 创建LogHistory数据层接口。
		/// </summary>
		public static SupervDB.IDAL.ILogHistory CreateLogHistory()
        {
            string ClassNamespace = AssemblyPath + ".LogHistory";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (SupervDB.IDAL.ILogHistory)objType;
        }

    }
}