using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisorAssist
{
    public partial class Frm_SS_Summary_report : Form
    {
        //录井项目
        private string[] SupKey = new string[]
        {
            "岩屑录井",
            "气体录井",
            "工程录井",
            "钻井液录井",
            "钻时录井",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
            " ",
        };
        //录井项目2
        private string[] SupKey2 = new string[]
        {
            "综合录井",
            "气测录井",
            "地质录井",
            "项目名称",
            "压力监测",
            "井筒液面监测",
            "定量荧光",
            "岩石热解地球化学录井",
            "岩石热蒸发烃气相色谱录井",
            "轻烃录井",
            "核磁共振录井",
            "X射线衍射矿物录井",
            "X射线荧光元素录井",
            "自然伽马能谱录井",
            "岩心扫描",
            "岩屑成像录井",
            "随钻解释",
            "....",
        };
        //工程复杂类型
        private string[] SupKey3 = new string[]
        {
            "工程复杂类型",
            "井漏",
            "溢流",
            "井涌",
            "井喷",
            "设备维修",
            "卡钻",
            "处理井眼",
            "...",
        };
        //现场问题类型
        private string[] SupKey4 = new string[]
        {
           "录井队伍资质",
            "人员配备及证件",
            "设备配备及安装",
            "资料准备",
            "钻具及套管管理",
            "设备运行与校验",
            "岩性落实",
            "油气显示落实",
            "地质卡层",
            "工程预警",
            "资料质量",
            "录井坐岗",
            "硫化氢传感器安装与检测",
            "安全防护设施配备及管理",
            "化学药品配备及管理",
            "应急预案及演练",
            "录井环境",
        };

        public Frm_SS_Summary_report()
        {
            InitializeComponent();
            dataGridView4.Columns[3].Width = 300;
            DgvColumnHelper helper = new DgvColumnHelper(this.dataGridView2);
            helper.Headers.Add(new DgvColumnHelper.TopHeader(1, 4, "工作量统计"));
            helper.Headers.Add(new DgvColumnHelper.TopHeader(0, 1, "录井项目"));
            this.dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridView2.ColumnHeadersHeight = 50; //设置Dgv属性ColumnHeadersHeightSizeMode才会生效
            for (int i = 0; i < SupKey.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView2.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                tdr.Cells[0].Value = SupKey[i];
                dataGridView2.Rows.Add(tdr);
            }

            for (int i = 0; i < SupKey2.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView3.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                tdr.Cells[0].Value = SupKey2[i];
                if (i == 3)
                {
                    tdr.Cells[1].Value = "开始时间";
                    tdr.Cells[2].Value = "结束时间";
                    tdr.Cells[3].Value = "服务天数";
                    tdr.Cells[4].Value = "录井人数";
                }
                dataGridView3.Rows.Add(tdr);
            }
            for (int i = 0; i < SupKey3.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView3.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                tdr.Cells[0].Value = SupKey3[i];
                if (i == 0)
                {
                    tdr.Cells[1].Value = "开始时间";
                    tdr.Cells[2].Value = "结束时间";
                    tdr.Cells[3].Value = "工程复杂天数";
                    tdr.Cells[4].Value = "录井人数";
                }
                dataGridView3.Rows.Add(tdr);
            }
            for (int i = 0; i < SupKey4.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView4.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                tdr.Cells[1].Value = SupKey4[i];
                dataGridView4.Rows.Add(tdr);
            }

            DgvRowHelper dhelper = new DgvRowHelper(this.dataGridView3);
            dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 3, "录井服务"));
            dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(3, 15, "特色技术服务"));
            dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(18, 9, "工程复杂"));
        }
    }
}
