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
    public partial class Frm_MP_BDPro : Form
    {
        public string twellnum;
        //录井项目
        private string[] projects = new string[]
        {
            "钻时录井",
            "岩屑录井",
            "钻井取心",
            "井壁取心",
            "气测录井",
            "钻井液录井",
            "工程录井",
            "泥（页）岩密度分析",
            "碳酸盐含量分析",
            "定量荧光录井",
            "岩石热解地球化学录井",
            "岩石热蒸发烃气相色谱录井",
            "轻烃录井",
            "核磁共振录井",
            "X射线衍射矿物录井",
            "X射线荧光元素录井",
            "自然伽马能谱录井",
            "岩心扫描",
            "岩屑成像录井",
        };
        public Frm_MP_BDPro()
        {
            InitializeComponent();
        }

        private void lodaData()
        {
            dataGridView2.Rows.Clear();

            if (twellnum == null || twellnum == "")
            {
                return;
            }

            

            for (int i = 0; i < projects.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView2.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                tdr.Cells[0].Value = i + 1;
                tdr.Cells[1].Value = projects[i];
                //tdr.Cells[2].Value = false;

                string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " proname = '" + projects[i] + "'";
                sqlwhere += " ORDER BY Updatetime DESC ";
                try
                {
                    SupervDB.BLL.LogProjects bllp = new SupervDB.BLL.LogProjects();
                    List<SupervDB.Model.LogProjects> llps = bllp.GetModelList(sqlwhere);

                    if (llps.Count > 0)
                    {
                        ((DataGridViewCheckBoxCell)tdr.Cells[2]).Value = llps[0].IsAdopt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dataGridView2.Rows.Add(tdr);
            }

            //自定义项目
            string sqlwhere2 = " Wellnum = '" + twellnum + "' ";

            SupervDB.BLL.LogProjects bllp2 = new SupervDB.BLL.LogProjects();
            List<SupervDB.Model.LogProjects> llps2 = bllp2.GetModelList(sqlwhere2);

            int curcount = projects.Length + 1;

            foreach (var item in llps2)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView2.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                //if (item.proname != null || item.proname != "" || projects.Contains(item.proname)) 
                if (item.proname == null || item.proname == "" || projects.Contains(item.proname)) 
                {
                    continue;
                }

                tdr.Cells[0].Value = curcount++;
                tdr.Cells[1].Value = item.proname;
                ((DataGridViewCheckBoxCell)tdr.Cells[2]).Value = item.IsAdopt;

                dataGridView2.Rows.Add(tdr);
            }





        }

        private void Frm_MP_BDPro_Load(object sender, EventArgs e)
        {
            lodaData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.LogProjects bllp = new SupervDB.BLL.LogProjects();

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                SupervDB.Model.LogProjects lpro = new SupervDB.Model.LogProjects();

                lpro.Wellnum = twellnum;

                lpro.proname = DBUtility.DbHelperSQL.GetVStr(dataGridView2.Rows[i].Cells[1].Value);
                bool isCheck = (bool)this.dataGridView2.Rows[i].Cells[2].EditedFormattedValue;
                //if (!isCheck || lpro.proname == null || lpro.proname == "")
                if (lpro.proname == null || lpro.proname == "")
                {
                    continue;
                }

                lpro.IsAdopt = isCheck;
                lpro.Updatetime = DBUtility.DbHelperSQL.getCurtime();


                string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " proname = '" + lpro.proname + "'";
                List<SupervDB.Model.LogProjects> llps = bllp.GetModelList(sqlwhere);
                if (llps.Count > 0)
                {
                    lpro.ID = llps[0].ID;
                    bllp.Update(lpro);
                }
                else
                {
                    bllp.Add(lpro);
                }
            }

            MessageBox.Show("保存成功");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lodaData();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
