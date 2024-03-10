using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisorAssist
{
    public partial class Frm_MP_MonitPlan : Form
    {
        public string twellnum;
        
        //监督重点
        private string[] SupKey = new string[]
        {
            "录井队伍资质",
            "人员配备及证件",
            "设备配备",
            "资料准备及设计",

            "钻具及套管管理",
            "设备安装及运行",
            "岩性落实",
            "显示落实",
            "地质卡层",
            "工程预警",
            "资料质量",
            "录井坐岗",

            "硫化氢传感器安装与检测",
            "安全设备设施配备及管理",
            "化学要求配备及管理",
            "应急预案及演练",
            "录井环境",
        };

        public Frm_MP_MonitPlan()
        {
            InitializeComponent();
            //设置前两列的宽度
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            //设定第三列自动换行
            dataGridView1.Columns[2].CellTemplate.Style.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            //设置行高 
            //dataGridView1.RowTemplate.Height = 50;
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                item.Height = 100;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private List<string> GetCoboxItem(string cbvalue)
        {
            List<string> wListData = new List<string> { };
            #region
            List<string> wListData1 = new List<string> { "录井队伍资质",
                                                        "人员配备及证件",
                                                        "设备配备",
                                                        "资料准备及设计" };

            List<string> wListData2 = new List<string> { "钻具及套管管理",
                                                            "设备安装及运行",
                                                            "岩性落实",
                                                            "显示落实",
                                                            "地质卡层",
                                                            "工程预警",
                                                            "资料质量",
                                                            "录井坐岗" };
            List<string> wListData3 = new List<string> { "硫化氢传感器安装与检测",
                                                        "安全设备设施配备及管理",
                                                        "化学要求配备及管理",
                                                        "应急预案及演练",
                                                        "录井环境" };

            if (cbvalue == "开工验收")
            {
                wListData = wListData1;
            }
            else if (cbvalue == "过程管控")
            {
                wListData = wListData2;
            }
            else if (cbvalue == "录井QHSE")
            {
                wListData = wListData3;
            }

            #endregion

            return wListData;
        }

        private void lodaData()
        {
            dataGridView1.Rows.Clear();

            if (twellnum == null || twellnum == "")
            {
                return;
            }

            try
            {
                string sqlwhere = " Wellnum = '" + twellnum + "'";
                sqlwhere += " ORDER BY Updatetime DESC ";

                SupervDB.BLL.MonitPlan bllp = new SupervDB.BLL.MonitPlan();
                List<SupervDB.Model.MonitPlan> llps = bllp.GetModelList(sqlwhere);

                for (int i = 0; i < llps.Count; i++)
                {
                    SupervDB.Model.MonitPlan item = llps[i];
                    DataGridViewRow tdr = new DataGridViewRow();
                    foreach (DataGridViewColumn c in dataGridView1.Columns)
                    {
                        tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                    }

                    List<string> wListData = GetCoboxItem(item.Skey);

                    if (((DataGridViewComboBoxCell)tdr.Cells[0]).Items.Contains(item.Skey))
                    {
                        tdr.Cells[0].Value = item.Skey;
                    }
                    else
                    {
                        continue;
                    }

                    foreach (var wdata in wListData)
                    {
                        ((DataGridViewComboBoxCell)tdr.Cells[1]).Items.Add(wdata);
                    }

                    if (((DataGridViewComboBoxCell)tdr.Cells[1]).Items.Contains(item.SCon))
                    {
                        tdr.Cells[1].Value = item.SCon;
                    }

                    //tdr.Cells[0].Value = item.Skey;
                    //tdr.Cells[1].Value = item.SCon;
                    tdr.Cells[2].Value = item.DifCou;

                    if (item.DifCou == null || item.DifCou.Trim() == "")
                    {
                        continue;
                    }

                    dataGridView1.Rows.Add(tdr);
                }

                foreach (var item in llps)
                {
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }



        private void Frm_MP_MonitPlan_Load(object sender, EventArgs e)
        {
            lodaData();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SupervDB.BLL.MonitPlan bllp = new SupervDB.BLL.MonitPlan();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.MonitPlan lpro = new SupervDB.Model.MonitPlan();

                lpro.Wellnum = twellnum;

                lpro.Skey = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);
                //if (i <= 3) { lpro.Skey = "开工验收"; }
                //else if (i > 3 && i <= 11) { lpro.Skey = "过程监督"; }
                //else { lpro.Skey = "录井QHSE"; }
                lpro.SCon = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[1].Value);
                if (lpro.Skey == null || lpro.Skey == "" || lpro.SCon == null || lpro.SCon == "")
                {
                    continue;
                }

                string sqldel = " Wellnum = '" + twellnum + "'";
                if (i == 0)
                {
                    DBUtility.DbHelperSQL.DeleteDatas("MonitPlan", sqldel);
                }

                lpro.DifCou = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[2].Value);
                lpro.Updatetime = DBUtility.DbHelperSQL.getCurtime();


                string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " SCon = '" + lpro.SCon + "'";
                List<SupervDB.Model.MonitPlan> llps = bllp.GetModelList(sqlwhere);
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

        private void button3_Click_1(object sender, EventArgs e)
        {
            lodaData();
        }

        ComboBox cbo = new ComboBox();
        /// <summary>
        /// 首先给这个DataGridView加上EditingControlShowing事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == 0 && dataGridView1.CurrentCell.RowIndex != -1)
            {
                cbo = e.Control as ComboBox; //保存当前的事件源。为了触发事件后。在取消
                cbo.SelectedIndexChanged += new EventHandler(cbo_SelectedIndexChanged);
            }
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combox = sender as ComboBox;
            //这里就可以写。触发后是逻辑代码

            string cbvalue = combox.Text;
            List<string> wListData = GetCoboxItem(cbvalue);

            int rowindex = dataGridView1.CurrentCell.RowIndex;
            ((DataGridViewComboBoxCell)dataGridView1.Rows[rowindex].Cells[1]).Value = "";
            ((DataGridViewComboBoxCell)dataGridView1.Rows[rowindex].Cells[1]).Items.Clear();

            foreach (var item in wListData)
            {
                ((DataGridViewComboBoxCell)dataGridView1.Rows[rowindex].Cells[1]).Items.Add(item);
            }

            //撤销动态事件
            cbo.SelectedIndexChanged -= new EventHandler(cbo_SelectedIndexChanged);
            //或者
            combox.SelectedIndexChanged -= new EventHandler(cbo_SelectedIndexChanged);
        }

        ///// <summary>
        ///// 组合框事件处理
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //public void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //    ComboBox combox = sender as ComboBox;

        //    //这里比较重要
        //    combox.Leave += new EventHandler(combox_Leave);
        //    try
        //    {
        //        //在这里就可以做值是否改变判断
        //        if (combox.SelectedItem != null)
        //        {

        //        }
        //        Thread.Sleep(100);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        ///// <summary>
        ///// 离开combox时，把事件删除
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //public void combox_Leave(object sender, EventArgs e)
        //{
        //    ComboBox combox = sender as ComboBox;
        //    //做完处理，须撤销动态事件
        //    combox.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
        //}



    }
}
