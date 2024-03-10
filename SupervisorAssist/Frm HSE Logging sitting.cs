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
    public partial class Frm_HSE_Logging_sitting : Form
    {
        public string twellnum;
        //检查项目
        private string[] projects = new string[]
        {
            "制度落实",
            "资料填写",
        };
        public Frm_HSE_Logging_sitting()
        {
            InitializeComponent();
            this.dataGridView1.RowHeadersWidth = 100;
            dataGridView1.Columns[2].Width = 250;
            for (int i = 0; i < projects.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                tdr.Cells[0].Value = projects[i];
                tdr.Cells[2].Value = "";

                dataGridView1.Rows.Add(tdr);
            }

            DgvRowHelper dhelper = new DgvRowHelper(this.dataGridView1);
            dhelper.LeftHeaders.Add(new DgvRowHelper.LeftHeader(0, 2, "录井坐岗"));

            

        }

        private void lodaData(int n)
        {
            dataGridView1.Rows.Clear();

            if (twellnum == null || twellnum == "")
            {
                return;
            }
            //判断是否选择了时间
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("请先选择日期!");
                return;
            }
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(n);
            string starttime = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00";
            string endtime = dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59";
            for (int i = 0; i < projects.Length; i++)
            {
                DataGridViewRow tdr = new DataGridViewRow();
                foreach (DataGridViewColumn c in dataGridView1.Columns)
                {
                    tdr.Cells.Add(c.CellTemplate.Clone() as DataGridViewCell);
                }

                tdr.Cells[0].Value = projects[i];

                string sqlwhere = " Wellnum = '" + twellnum + "'" + " AND" + " CheckProject = '" + projects[i] + "'" + "AND Savetime between '" + starttime+ "' and '" + endtime + " '";
                // string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " CheckProject = '" + projects[i] + "'";
                sqlwhere += " ORDER BY Updatetime DESC ";
                try
                {
                    SupervDB.BLL.LogWells_SitDuty bllp = new SupervDB.BLL.LogWells_SitDuty();
                    List<SupervDB.Model.LogWells_SitDuty> llps = bllp.GetModelList(sqlwhere);
                    if (llps.Count > 0 && llps[0].TableName == "录井坐岗")
                    {
                        tdr.Cells[1].Value = llps[0].CheckResults;
                        tdr.Cells[2].Value = llps[0].ProblemDesc;
                    }
                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                dataGridView1.Rows.Add(tdr);
            }

            
            
        }

        private void Select_option()
        {
            try
            {
                string option = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[0].Cells[0].Value);
                //string option = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[0].Cells[1].Value);
                if (option == "制度落实")
                {
                    List<string> wListData1 = new List<string> { "落实",
                                                                 "不落实" };
                    ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells[1]).Items.Clear();
                    foreach (var item in wListData1)
                    {
                        ((DataGridViewComboBoxCell)dataGridView1.Rows[0].Cells[1]).Items.Add(item);
                    }
                }
                option = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[1].Cells[0].Value);
                //option = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[1].Cells[1].Value);
                if (option == "资料填写")
                {
                    List<string> wListData2 = new List<string> { "合格",
                                                                "不合格" };
                    ((DataGridViewComboBoxCell)dataGridView1.Rows[1].Cells[1]).Items.Clear();
                    foreach (var item in wListData2)
                    {
                        ((DataGridViewComboBoxCell)dataGridView1.Rows[1].Cells[1]).Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Frm_HSE_Logging_sitting_Load(object sender, EventArgs e)
        {
            lodaData(0);
            Select_option();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lodaData(0);
            Select_option();
        }
        //保存
        private void button1_Click_1(object sender, EventArgs e)
        {
            SupervDB.BLL.LogWells_SitDuty bllp = new SupervDB.BLL.LogWells_SitDuty();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                SupervDB.Model.LogWells_SitDuty lpro = new SupervDB.Model.LogWells_SitDuty();

                lpro.Wellnum = twellnum;
                //区分不同的表单
                lpro.TableName = DBUtility.DbHelperSQL.GetVStr("录井坐岗");

                lpro.CheckProject = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[0].Value);
                //bool isCheck = (bool)this.dataGridView1.Rows[i].Cells[1].EditedFormattedValue;
                string text = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[1].Value);
                string str = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[i].Cells[2].Value);
                if (text == null || text == "" || lpro.CheckProject == null || lpro.CheckProject == "")
                {
                    continue;
                }

                lpro.CheckResults = text;
                lpro.ProblemDesc = str;
                lpro.Updatetime = DBUtility.DbHelperSQL.getCurtime();

                string sqlwhere = " Wellnum = '" + twellnum + "'" + " AND" + " CheckProject = '" + projects[i] + "'" + "AND Savetime between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 00:00:00" + "' and '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                // string sqlwhere = " Wellnum = '" + twellnum + "' AND " + " CheckProject = '" + lpro.CheckProject + "'";
                List<SupervDB.Model.LogWells_SitDuty> llps = bllp.GetModelList(sqlwhere);
                if (llps.Count > 0)
                {
                    lpro.ID = llps[0].ID;
                    lpro.Savetime = llps[0].Savetime;//用于还原保存的初始时间
                    bllp.Update(lpro);
                }
                else
                {
                    lpro.Savetime = dateTimePicker1.Value;
                    bllp.Add(lpro);
                }
            }

            MessageBox.Show("保存成功");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            lodaData(0);
            Select_option();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //昨天
        private void button5_Click(object sender, EventArgs e)
        {
            lodaData(-1);
            Select_option();
        }
        //明天
        private void button6_Click(object sender, EventArgs e)
        {
            lodaData(1);
            Select_option();
        }

        //ComboBox cbo = new ComboBox();
        ///// <summary>
        ///// 首先给这个DataGridView加上EditingControlShowing事件
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        //{
        //    //if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.ColumnIndex == 0 && dataGridView1.CurrentCell.RowIndex != -1)
        //    //{
        //    //    cbo = e.Control as ComboBox; //保存当前的事件源。为了触发事件后。在取消
        //    //    cbo.SelectedIndexChanged += new EventHandler(cbo_SelectedIndexChanged);
        //    //}
        //}

        //private List<string> GetCoboxItem(string cbvalue)
        //{
        //    List<string> wListData = new List<string> { };
        //    #region
        //    List<string> wListData1 = new List<string> { "落实",
        //                                                "不落实" };

        //    List<string> wListData2 = new List<string> { "合格",
        //                                                    "不合格" };

        //    if (cbvalue == "制度落实")
        //    {
        //        wListData = wListData1;
        //    }
        //    else
        //    {
        //        wListData = wListData2;
        //    }


        //    #endregion

        //    return wListData;
        //}

        //private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ComboBox combox = sender as ComboBox;
        //    //这里就可以写。触发后是逻辑代码
        //    int rowindex = dataGridView1.CurrentCell.RowIndex;
        //    //string cbvalue = DBUtility.DbHelperSQL.GetVStr(dataGridView1.Rows[rowindex].Cells[0].Value);

        //    string cbvalue = combox.Text;
        //    List<string> wListData = GetCoboxItem(cbvalue);


        //    ((DataGridViewComboBoxCell)dataGridView1.Rows[rowindex].Cells[1]).Value = "";
        //    ((DataGridViewComboBoxCell)dataGridView1.Rows[rowindex].Cells[1]).Items.Clear();

        //    foreach (var item in wListData)
        //    {
        //        ((DataGridViewComboBoxCell)dataGridView1.Rows[rowindex].Cells[1]).Items.Add(item);
        //    }

        //    //撤销动态事件
        //    cbo.SelectedIndexChanged -= new EventHandler(cbo_SelectedIndexChanged);
        //    //或者
        //    combox.SelectedIndexChanged -= new EventHandler(cbo_SelectedIndexChanged);
        //}


    }
}
