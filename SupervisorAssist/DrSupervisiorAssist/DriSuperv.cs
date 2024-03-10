using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrSupervisiorAssist
{
    /// <summary>
    /// 钻井的基本数据
    /// </summary>
    public class DriSuperv
    {
        public string Wellnum;//井号，不可随便更改
        public string Well_type, Well_BB;//井的类型，井别
        public string DriSupervisor;//钻井监督
        public string Supervisor_license;//监督证号
        public string Supervision_Methods;//监督方式

        public SuperPlan superPlan;//监督计划
        public List<SuperDiffCounter> superDiffCounter;//监督难点及对策

        //开工验收
        public List<DriTQualification> driTQualification;//钻井队伍资质
        public List<StaffDocu> staffDocu;//人员配备及证件
        public List<WellCEquip> wellCEquip;//设备配备及安装-井控设备及安装
        public List<MainEquipInst> mainEquipInst;//设备配备及安装-主体设备及安装
        public List<WellEMmanage> wellEMmanage;//入井材料管理
        public List<PrepareMaterials> prepareMaterials;//资料准备

        //过程监督
        public BasicDataDay basicDataDay;//每日基本信息
        public List<DesignCMImple> designCMImple;
        public List<ChangekeyPositions> changekeyPositions;//关键岗位人员变更
        public List<OtherProjects> otherProjects;//其它监督项目
        public List<KeySituation> keySituation;

        //钻井井控安全及管理
        public List<WellCSManage> wellCSManage;//井控安全及管理

        public DriSuperv()
        {
            //监督计划
            superPlan = new SuperPlan();
            superDiffCounter = new List<SuperDiffCounter>();

            //开工验收
            driTQualification = new List<DriTQualification>();
            staffDocu = new List<StaffDocu>();
            wellCEquip = new List<WellCEquip>();
            mainEquipInst = new List<MainEquipInst>();
            wellEMmanage = new List<WellEMmanage>();
            prepareMaterials = new List<PrepareMaterials>();

            //过程监督
            basicDataDay = new BasicDataDay();
            designCMImple = new List<DesignCMImple>();
            changekeyPositions = new List<ChangekeyPositions>();
            otherProjects = new List<OtherProjects>();
            keySituation = new List<KeySituation>();

            //钻井井控安全及管理
            wellCSManage = new List<WellCSManage>();
        }

    }

    /// <summary>
    /// 监督计划基础
    /// 1.2 监督计划基础数据
    /// </summary>
    public class SuperPlan
    {
        public string Wellnum;//井号，不可随便更改
        public string Well_type, Well_BB;//井的类型，井别
        public string DriFlQuaRequire;//钻井液质量要求
        public string WellQuaRequire;//井身质量要求
        public string CementQuaRequire;//固井质量要求
        public string CorQuaRequire;//取心质量要求
    }

    /// <summary>
    /// 监督计划基础
    /// 1.3 监督难点及对策
    /// </summary>
    public class SuperDiffCounter
    {
        public string Skey;//监督重点（开工验收、过程监督、井控安全及管理）
        public string SCon;//监督内容
        public string DifCou;//监督难点及对策
    }

    /// <summary>
    /// 开工验收
    /// 2.1 钻井队伍资质
    /// </summary>
    public class DriTQualification
    {
        public string DriTNum;//录井队号
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
    /// 开工验收
    /// 2.3.1 井控设备及安装
    /// </summary>
    public class WellCEquip
    {
        public string Projects;//项目
        public string Model;//型号
        public string FactoryNum;//出厂编号
        public string FactoryTime;//出厂时间
        public string CheckResults;//检查结果
        public string InstPreTest;//安装及试压
        public string DescProblem;//问题描述
    }

    /// <summary>
    /// 开工验收
    /// 2.3.2 主体设备及安装
    /// </summary>
    public class MainEquipInst
    {
        public string EquipName;//设备名称
        public string Model;//型号
        public string FactoryNum;//出厂编号
        public string FactoryTime;//出厂时间
        public string InstallStatus;//安装情况
        public string CheckResults;//检查结果
        public string DescProblem;//问题描述

    }

    /// <summary>
    /// 开工验收
    /// 2.4 入井材料管理
    /// </summary>
    public class WellEMmanage
    {
        public string CheckProject;//检查项目
        public string CheckResults;//检查结果
        public string ProblemDesc;//问题描述
    }

    /// <summary>
    /// 开工验收
    /// 2.5 资料准备
    /// </summary>
    public class PrepareMaterials
    {
        public string CheckProject;//检查项目
        public bool IsAdopt;//是否采用
    }


    /// <summary>
    /// 过程监督
    /// 3.1 每日基本信息
    /// </summary>
    public class BasicDataDay
    {
        public string Wellnum;//井号
        public decimal DriDepthWell;//钻达井深
        public string Layer;//层位
        public decimal Density;//密度，g/cm³
        public decimal Viscosity;//粘度，s
        public string DriSuperv;//钻井监督
        public string WorkCondi;//工况
    }

    /// <summary>
    /// 过程监督
    /// 3.2.1 设计与施工措施执行
    /// 3.2.2 井身质量
    /// 3.2.3 入井材料及流体质量
    /// 3.2.3 钻具质量
    /// 3.2.4 钻井取心质量
    /// 3.2.5 下套管质量
    /// 3.2.6 固井质量
    /// 3.2.7 钻井资料质量
    /// </summary>
    public class DesignCMImple
    {
        public string TableName;//用于区分不同的表格(SQL Server),区分以上共用相同数据结构的不同表单
        public string CheckProject;//检查项目
        public string CheckResults;//检查结果
        public string ProblemDesc;//问题描述
    }

    /// <summary>
    /// 过程监督
    /// 3.3 关键岗位人员变更
    /// </summary>
    public class ChangekeyPositions
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
    /// 3.4 其它监督项目
    /// </summary>
    public class OtherProjects
    {
        public string Supervision;//监督环节
        public string SuperItem;//监督项
        public string CheckContent;//检查内容
        public string CheckResult;//检查结果
        public string ProblemDes;//问题描述
    }

    /// <summary>
    /// 过程监督
    /// 3.5 重点情况反映
    /// 3.6 典型案例分析
    /// </summary>
    public class KeySituation
    {
        public string TableName;//用于区分不同的表格
        public string Projects;//项目
        public string ProblemDes;//问题描述
    }

    /// <summary>
    /// 钻井井控安全及管理
    /// 4.1 井控安全及管理
    /// </summary>
    public class WellCSManage
    {
        public string CheckProject;//检查项目
        public string CheckResults;//检查结果
        public string ProblemDesc;//问题描述
    }

}




