using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupervisorAssist
{
    public class GeoSuperv
    {
        /// <summary>
        /// 井的基本数据
        /// </summary>
        public string Wellnum;//井号，不可随便更改
        public string Well_type, Well_BB;//井的类型，井别
        public string Well_state;//井的状态
        public string YT;//所属油田
        public string JdName, JdNum, JdWay;//地质监督姓名、监督证号、监督方式
        public string Location;//地理位置
        public string GZLoc;//构造位置
        public string DrillAim;//钻探目的
        public string ComRul;//完钻原则

        public double Well_KB, Well_HB, Well_Cd, Well_depth, Well_Sd, Well_CX;//井补心高，海拔，垂深，井深（斜深）,水深,潮汐；
        public double Wzdepth, WzCd;//完钻井深，完钻斜深
        public double SpLen, LjDepth;//实钻水平段长，开始录井井深
        public string MainAimLayer, SecAimLayer;//主要目的层，次要目的层
        //public string Drilllayer;//完钻层位
        public string LJEndDate;//完钻层位
        public DateTime SDate, EDate, CDate, LJStartDate/*, LJEndDate*/;//开钻日期，完钻日期，完井日期，录井开始日期，录井结束日期

        public string ComSty;//完井方法
        public string WellLines;//邻井井号

        //监督计划
        public List<LogProjects> LogTechnology;//录井项目
        public List<WellStructure> Well_Strus;//井身结构数据
        public List<MonitPlan> Well_MonPlan;//监督计划

        //开工验收
        public List<TeamQual> teamQuals;//录井队伍资质
        public List<StaffDocu> staffDocus;//人员配备及证件
        public List<EquipCAI> equipCAIs;//设备配备及安装
        public List<DeaeratorEquip> deaeratorEquips;//脱气器配备及安装
        public List<SensorEquip> sensorEquips;//传感器配备及安装
        public List<AcqProcessSoft> acqProcessSofts;//采集及处理软件
        public List<GeoREquip> geoREquips;//地质房设备配备
        public List<EvalLogEquip> evalLogEquips;//评价录井设备配备
        public List<PrepareMaterials> prepareMaterials;//资料准备

        //过程管控
        public BasicData basicData;//基础数据
        public List<DriTSMana> driTSManas;//钻具及套管管理
        //public List<EquipOperCal> equipOperCals;//设备运行及校验
        //public List<LitImple> litImples;//岩性落实
        //public List<GeoLayer> geoLayers;//地质卡层
        //public List<OilGasShow> oilGasShows;//油气显示落实
        //public List<EngineerWarn> engineerWarns;//工程预警
        //public List<DataQualityn> dataQualityns;//资料质量
        public List<PersonChange> personChanges;//人员变更
        public List<DeviceChange> deviceChanges;//设备变更
        public List<OtherProjects> otherProjects;//其它监督项目
        public List<KeySituation> keySituations;//重点情况反映
        //public List<TypicalCase> typicalCases;//典型案例分析

        //录井HSE
        public List<LogWells_SitDuty> logWells_SitDuties;//录井坐岗
        //public List<HS2Sensor> hS2Sensors;//硫化氢传感器安装及检测
        //public List<HS2SensorDetect> hS2SensorDetects;//硫化氢传感器检测
        //public List<LogEnvironment> logEnvironments;//录井环境
        public List<LogWorkloadSta_Footage> logWorkloadSta_Footages;//录井工作量统计--按进尺统计
        public List<LogWorkloadSta_Time> logWorkloadSta_Times;//录井工作量统计--按时间统计
        public LogBasicData logBasicData;//XX井基本信息数据表

        //总结报告
        public NoticeRect noticeRect;//整改通知单
        public RectReceipt rectReceipt;//整改回执单
        public Memorandum memorandum;//监督备忘录

        public GeoSuperv()
        {
            //监督计划
            LogTechnology = new List<LogProjects>();
            Well_Strus = new List<WellStructure>();
            Well_MonPlan = new List<MonitPlan>();

            //开工验收
            teamQuals = new List<TeamQual>();
            staffDocus = new List<StaffDocu>();
            equipCAIs = new List<EquipCAI>();
            deaeratorEquips = new List<DeaeratorEquip>();
            sensorEquips = new List<SensorEquip>();
            acqProcessSofts = new List<AcqProcessSoft>();
            geoREquips = new List<GeoREquip>();
            evalLogEquips = new List<EvalLogEquip>();
            prepareMaterials = new List<PrepareMaterials>();

            //过程管控
            basicData = new BasicData();
            driTSManas = new List<DriTSMana>();
            //equipOperCals = new List<EquipOperCal>();
            //litImples = new List<LitImple>();
            //geoLayers = new List<GeoLayer>();
            //oilGasShows = new List<OilGasShow>();
            //engineerWarns = new List<EngineerWarn>();
            //dataQualityns = new List<DataQualityn>();
            personChanges = new List<PersonChange>();
            deviceChanges = new List<DeviceChange>();
            otherProjects = new List<OtherProjects>();
            keySituations = new List<KeySituation>();
            //typicalCases = new List<TypicalCase>();

            //录井HSE
            logWells_SitDuties = new List<LogWells_SitDuty>();
            //hS2Sensors = new List<HS2Sensor>();
            //hS2SensorDetects = new List<HS2SensorDetect>();
            //logEnvironments = new List<LogEnvironment>();
            logWorkloadSta_Footages = new List<LogWorkloadSta_Footage>();
            logWorkloadSta_Times = new List<LogWorkloadSta_Time>();
            logBasicData = new LogBasicData();

            //总结报告
            noticeRect = new NoticeRect();//整改通知单
            rectReceipt = new RectReceipt();//整改回执单
            memorandum = new Memorandum();//监督备忘录
            
         }
    }

    /// <summary>
    /// 监督计划
    /// 1-2 录井项目
    /// </summary>
    public class LogProjects
    {
        public string proname;//项目名称
        public bool IsAdopt;//是否采用
    }

    /// <summary>
    /// 监督计划
    /// 1-3 井身结构数据
    /// </summary>
    public class WellStructure
    {
        //实际钻头程序
        public string OpenTime;//开次
        public DateTime EDate;//完钻时间
        public double Bitdia, Welldepth;//钻头直径,井深

        //实际套管程序
        public double TgWj, XDepth;//套管外径,下入深度
    }

    /// <summary>
    /// 监督计划
    /// 1.2 监督计划（开工验收、过程监督、录井QHSE）
    /// </summary>
    public class MonitPlan
    {
        public string Skey;//监督重点（开工验收、过程监督、录井QHSE）
        public string SCon;//监督内容
        public string DifCou;//监督难点及对策
    }




    /// <summary>
    /// 开工验收
    /// 2.1 录井队伍资质
    /// </summary>
    public class TeamQual
    {
        public string LogTNum;//录井队号
        public string Affiliation;//所属单位
        public string QualCNum;//资质证编号
        public string TypeTeam;//队伍种类
        public string TeamLevel;//队伍级别
        public string CheckResults;//检查结果
    }

    /// <summary>
    /// 开工验收
    /// 2.2 人员配备及证件
    /// </summary>
    public class StaffDocu
    {
        public string Num;//序号
        public string Name;//姓名
        //public string WorkPlace;//工作单位
        public string JobTitle;//岗位名称
        public string JobNum;//岗位编号
        public string JobLevel;//岗位级别
        public string WellConcert;//井控证
        public string HS2Cert;//硫化氢证
        public string HSECert;//HSE证
        public string FiveSCert;//五小证
        public string CheckResults;//检查结果

    }

    /// <summary>
    /// 开工验收
    /// 2.3 设备配备及质量评价--设备配备及安装
    /// </summary>
    public class EquipCAI
    {
        public string EquipName;//设备名称
        public string Model;//型号
        public string FactoryNum;//出厂编号
        public string Manufacturer;//生产厂家
        public DateTime DateManu;//生产日期
        public string CheckResults;//检查结果
    }

    /// <summary>
    /// 开工验收
    /// 2.3 设备配备及质量评价--脱气器配备及安装
    /// </summary>
    public class DeaeratorEquip
    {
        //public string EquipName;//设备名称
        public string Model;//型号
        public string FactoryNum;//出厂编号
        public string Manufacturer;//生产厂家
        public DateTime DateManu;//生产日期
        public string CheckResults;//检查结果
        public string IsStandard;//安装是否规范
        public string ProblemDesc;//问题描述
    }

    /// <summary>
    /// 开工验收
    /// 2.3 设备配备及质量评价--传感器配备及安装
    /// </summary>
    public class SensorEquip
    {
        public string SensorName;//传感器名称
        public string FactoryNum;//出厂编号
        public string Manufacturer;//生产厂家
        public DateTime DateManu;//生产日期
        public string CheckResults;//检查结果
        public string IsStandard;//安装是否规范
        public string ProblemDesc;//问题描述
    }

    /// <summary>
    /// 开工验收
    /// 2.3 设备配备及质量评价--采集及处理软件
    /// </summary>
    public class AcqProcessSoft
    {
        public List<DataAcqSoft> dataAcqSofts;//数据采集软件
        //public List<DataProSoft> dataProSofts;//资料处理软件
        public List<OnDataTran> onDataTrans;//现场数据传输
    }

    /// <summary>
    /// 开工验收
    /// 2.3 采集及处理软件-- 数据采集软件 和 资料处理软件
    /// </summary>
    public class DataAcqSoft
    {
        public string TableName;//用于区分“数据采集软件”和“资料处理软件”
        public string AcpSoftVer;//采集软件版本
        public string SoftManu;//软件生产商
        public DateTime SoftUpTime;//软件更新时间
        public string CheckResult;//检查结果
    }

    ///// <summary>
    ///// 开工验收
    ///// 2.3 采集及处理软件--资料处理软件
    ///// </summary>
    //public class DataProSoft
    //{
    //    public string AcpSoftVer;//采集软件版本
    //    public string SoftManu;//软件生产商
    //    public DateTime SoftUpTime;//软件更新时间
    //    public string CheckResult;//检查结果
    //}

    /// <summary>
    /// 开工验收
    /// 2.3 采集及处理软件--现场数据传输
    /// </summary>
    public class OnDataTran
    {
        public string TranFormat;//数据传输格式
        public string TranStab;//传输稳定性
        public DateTime CheckTime;//检查时间
        public string CheckResult;//检查结果
    }

    /// <summary>
    /// 开工验收
    /// 2.3 设备配备及质量评价--地质房设备配备
    /// </summary>
    public class GeoREquip
    {
        public int Num;//序号
        public string GeoEquip;//地质房设备配备
        public string CheckResults;//检查结果
    }

    /// <summary>
    /// 开工验收
    /// 2.3 设备配备及质量评价--评价录井设备配备
    /// </summary>
    public class EvalLogEquip
    {
        public string CheckProject;//检查项目
        public string CheckResults;//检查结果
        public string ProblemDesc;//问题描述
    }

    /// <summary>
    /// 开工验收
    /// 2.4 资料准备
    /// </summary>
    public class PrepareMaterials
    {
        public string CheckProject;//检查项目
        public bool IsAdopt;//是否采用
    }




    /// <summary>
    /// 过程监督
    /// 3.1 基础数据
    /// </summary>
    public class BasicData
    {
        public string Wellnum;//井号，不可随便更改
        public double Well_depth;//钻达井深，m
        public string LayerBits;//层位
        public double Density;//密度，g/cm³
        public double Viscosity;//粘度，s
        public string JdName, JdNum;//地质监督姓名,监督证号
        public string LogGeologist;//录井地质师
        public string InEngineer;//仪器工程师
        public double ManholeSection, PacketNum, Cum_Depth, Cum_layerNum;//检查井段,m ; 捞取包数 ; 累计显示厚度 ; 累计显示层数
        //public List<DailyOpeCon> DailyData;//每日工况
    }

    ///// <summary>
    ///// 过程监督
    ///// 3.1 基础数据--每日工况
    ///// </summary>
    //public class DailyOpeCon
    //{
    //    public int num;//序号
    //    public DateTime Time;//时间
    //    public double Well_depth;//井深,m
    //    public string WorkCondition;//工况
    //    public string WorkCondition_Des;//工况描述
    //}

    /// <summary>
    /// 过程监督
    /// 3.2 钻具及套管管理
    /// 3.3 设备运行及校验
    /// 3.4 岩性落实
    /// 3.5 地质卡层
    /// 3.6 油气显示落实
    /// 3.7 工程预警
    /// 3.8 资料质量
    /// </summary>
    public class DriTSMana
    {
        public string TableName;//用于区分不同的表
        public string CheckProject;//检查项目
        public string CheckResults;//检查结果
        public string ProblemDesc;//问题描述
    }

    ///// <summary>
    ///// 过程监督
    ///// 3.3 设备运行及校验
    ///// </summary>
    //public class EquipOperCal
    //{
    //    public string CheckProject;//检查项目
    //    public string CheckResults;//检查结果
    //    public string ProblemDesc;//问题描述
    //}

    ///// <summary>
    ///// 过程监督
    ///// 3.4 岩性落实
    ///// </summary>
    //public class LitImple
    //{
    //    public string CheckProject;//检查项目
    //    public string CheckResults;//检查结果
    //    public string ProblemDesc;//问题描述
    //}

    ///// <summary>
    ///// 过程监督
    ///// 3.5 地质卡层
    ///// </summary>
    //public class GeoLayer
    //{
    //    public string CheckProject;//检查项目
    //    public string CheckResults;//检查结果
    //    public string ProblemDesc;//问题描述
    //}

    ///// <summary>
    ///// 过程监督
    ///// 3.6 油气显示落实
    ///// </summary>
    //public class OilGasShow 
    //{
    //    public string CheckProject;//检查项目
    //    public string CheckResults;//检查结果
    //    public string ProblemDesc;//问题描述
    //}

    ///// <summary>
    ///// 过程监督
    ///// 3.7 工程预警
    ///// </summary>
    //public class EngineerWarn
    //{
    //    public string CheckProject;//检查项目
    //    public string CheckResults;//检查结果
    //    public string ProblemDesc;//问题描述
    //}

    ///// <summary>
    ///// 过程监督
    ///// 3.8 资料质量
    ///// </summary>
    //public class DataQualityn
    //{
    //    public string CheckProject;//检查项目
    //    public string CheckResults;//检查结果
    //    public string ProblemDesc;//问题描述
    //}

    /// <summary>
    /// 过程监督
    /// 3.9 录井坐岗--人员变更
    /// </summary>
    public class PersonChange
    {
        public string Num;//序号
        public string Name;//姓名
        public string WorkPlace;//工作单位
        public string JobTitle;//岗位名称
        public string JobNum;//岗位编号
        public string JobLevel;//岗位级别
        public string WellConcert;//井控证
        public string HS2Cert;//硫化氢证
        public string HSECert;//HSE证
        public string FiveSCert;//五小证
        public string CheckResults;//检查结果
    }

    /// <summary>
    /// 过程监督
    /// 3.9 录井坐岗--设备变更
    /// </summary>
    public class DeviceChange
    {
        public string EquipName;//设备名称
        public string Model;//型号
        public string FactoryNum;//出厂编号
        public string Manufacturer;//生产厂家
        public DateTime DateManu;//生产日期
        public string CheckResults;//检查结果
    }

    /// <summary>
    /// 过程监督
    /// 3.10 其它监督项目
    /// </summary>
    public class OtherProjects
    {
        public string Supervision;//监督环节
        public string Super_Item;//监督项
        public string CheckContent;//检查内容
        public string CheckResult;//检查结果
        public string ProblemDes;//问题描述
    }

    /// <summary>
    /// 过程监督
    /// 3.11 重点情况反映
    /// 3.12 典型案例分析
    /// </summary>
    public class KeySituation
    {
        public string TableName;//用于区分不同的表格
        public string project;//项目
        public string ProblemDes;//问题描述
    }

    ///// <summary>
    ///// 过程监督
    ///// 3.12 典型案例分析
    ///// </summary>
    //public class TypicalCase
    //{
    //    public string project;//项目
    //    public string ProblemDes;//问题描述
    //}






    /// <summary>
    /// 录井HSE
    /// 4.1 录井坐岗
    /// 4.2 硫化氢传感器安装及检测
    /// 4.3 硫化氢传感器检测
    /// 4.4 录井环境
    /// </summary>
    public class LogWells_SitDuty
    {
        public string TableName;//用于区分不同的项目表格
        public string CheckProject;//检查项目
        public string CheckResults;//检查结果
        public string ProblemDesc;//问题描述
    }

    ///// <summary>
    ///// 录井HSE
    ///// 4.2 硫化氢传感器安装及检测
    ///// </summary>
    //public class HS2Sensor
    //{
    //    public string CheckProject;//检查项目
    //    public string CheckResults;//检查结果
    //    public string ProblemDesc;//问题描述
    //}

    ///// <summary>
    ///// 录井HSE
    ///// 4.3 硫化氢传感器检测
    ///// </summary>
    //public class HS2SensorDetect
    //{
    //    public string CheckProject;//检查项目
    //    public string CheckResults;//检查结果
    //    public string ProblemDesc;//问题描述
    //}

    ///// <summary>
    ///// 录井HSE
    ///// 4.4 录井环境
    ///// </summary>
    //public class LogEnvironment
    //{
    //    public string CheckProject;//检查项目
    //    public string CheckResults;//检查结果
    //    public string ProblemDesc;//问题描述
    //}

    /// <summary>
    /// 录井HSE
    /// 4.5 录井工作量统计--按进尺统计
    /// </summary>
    public class LogWorkloadSta_Footage
    {
        public string LogProject;//录井项目
        public double Start_Well_Depth;//开始井深，m
        public double End_Well_Depth;//结束井深，m
        public double SampleInterval;//取样间隔
        public double Number;//数量
    }

    /// <summary>
    /// 录井HSE
    /// 4.5 录井工作量统计--按时间统计
    /// </summary>
    public class LogWorkloadSta_Time
    {
        public List<LogService>  logServices;//录井服务
        public List<EvaluationLog> evaluationLogs;//评价录井
        public List<ProjectComplex> projectComplices;//工程复杂
        public List<OrganiZownTime> organiZownTimes;//组织停工
    }

    /// <summary>
    /// 录井HSE
    /// 4.5 录井工作量统计--按时间统计
    /// 录井服务
    /// </summary>
    public class LogService
    {
        public string LogProject;//录井项目
        public DateTime Star_LogTime;//录井开始时间
        public DateTime End_LogTime;//录井结束时间
        public double LogDay;//录井天数，天
        public double LogPerNum;//录井人数

    }

    /// <summary>
    /// 录井HSE
    /// 4.5 录井工作量统计--按时间统计
    /// 评价录井
    /// </summary>
    public class EvaluationLog
    {
        public string ProjectName;//项目名称
        public DateTime Star_Time;//开始时间
        public DateTime End_Time;//结束时间
        public double LogDay;//服务天数，天
        public double LogPerNum;//录井人数
    }

    /// <summary>
    /// 录井HSE
    /// 4.5 录井工作量统计--按时间统计
    /// 工程复杂
    /// </summary>
    public class ProjectComplex
    {
        public string EComplexType;//工程复杂类型
        public DateTime Star_Time;//开始时间
        public DateTime End_Time;//结束时间
        public double LogDay;//工程复杂天数，天
        public double LogPerNum;//录井人数
    }

    /// <summary>
    /// 录井HSE
    /// 4.5 录井工作量统计--按时间统计
    /// 组织停工
    /// </summary>
    public class OrganiZownTime
    {
        public DateTime Star_Time;//开始时间
        public DateTime End_Time;//结束时间
        public int CumNumDay;//累计天数
    }
    
    /// <summary>
    /// 录井HSE
    /// 4.6 XX井基本信息数据表
    /// </summary>
    public class LogBasicData
    {
        public string Wellnum;//井号，不可随便更改
        public string Well_type, Well_BB;//井的类型，井别
        //public string JdName, JdNum, JdWay;//地质监督姓名、监督证号、监督方式
        public string Location;//地理位置
        public string GZLoc;//构造位置
        public string DrillAim;//钻探目的
        public string ComRul;//完钻原则

        public double Well_KB, Well_HB, Well_Cd, Well_depth, Well_Sd;//井补心高，海拔，垂深，井深（斜深）,水深；
        public double Wzdepth, WzCd, WzLayer;//完钻井深，完钻垂深,完钻层位
        public double HorLen,SpLen, LjDepth;//设计水平段长，m , 实钻水平段长，开始录井井深
        public string MainAimLayer, SecAimLayer;//主要目的层，次要目的层
        public DateTime SDate, EDate, CDate, LJStartDate;//开钻日期，完钻日期，完井日期，录井开始日期

        public string ComSty;//完井方法
        public string Welllins;//邻井井号

        public string LogTechnology;//录井项目
        public List<WellStructure> Well_Strus;//井身结构数据
       
    }

    public class User
    {
        public string Username;
        public string Password;
        public bool Isstate;
        public string Name;
        public DateTime Createddata;
        public string Creator;
        public int Userpermission;
        public string Remark;
        public int id;
    }

    //整改通知单
    public class NoticeRect
    {
        public string Wellnum;//井号
        public string ConstructUnit;//施工单位
        public DateTime ReleaseTime;//下达时间
        public string Problems;//存在的问题
        public string Requirements;//整改要求
        public string GeoSupervisor;//地址监督签字
        public string ConstructSign;//施工单位签字
        
    }

    //整改回执单
    public class RectReceipt
    {
        public string Wellnum;//井号
        public string GeoSupervision;//地质监督
        public string Rectification;//整改情况
        public string ReviewConclusions;//复查结论
        public string GeoSupervisor;//地址监督签字
    }

    //监督备忘录
    public class Memorandum
    {
        public string Wellnum;//井号
        public string ConstructUnit;//施工单位
        public string DescProblem;//问题描述
        public string Penalties;//处罚及处理意见
        public string LogTeamSign;//录井队签字
        public string GeoSupervisor;//地址监督签字
        public DateTime IssueTime;//签发时间
    }
}

