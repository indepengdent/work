using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupervisorAssist
{
    /// <summary>
    /// 多维表头
    /// </summary>
    public class DgvRowHelper
    {
        public DgvRowHelper(DataGridView gridview)
        {
            gridview.RowPostPaint += new DataGridViewRowPostPaintEventHandler(gridview_RowPostPaint);
        }

        private void gridview_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            DataGridView dgv = (DataGridView)(sender);

            int width = dgv.Width - dgv.RowHeadersWidth;
            int height = 0;

            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                height += dgv.Rows[i].Height; //单元格总高度
            }

            StringFormat SF = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

            Rectangle rect = new Rectangle(e.RowBounds.Left, e.RowBounds.Left + dgv.ColumnHeadersHeight, dgv.Width - width, height);

            using (Brush backColorBrush = new SolidBrush(Color.White)) //设置单元格背景颜色
            {
                e.Graphics.FillRectangle(backColorBrush, rect);
            }
            using (Pen gridLinePen = new Pen(dgv.GridColor))
            {
                //竖线
                e.Graphics.DrawLine(gridLinePen, dgv.Width - width, dgv.ColumnHeadersHeight, dgv.Width - width, height + dgv.ColumnHeadersHeight);
                //根据行拉伸变化画分割线
                //e.Graphics.DrawLine(gridLinePen, e.RowBounds.Left, (height / dgv.Rows.Count) * 5 + dgv.ColumnHeadersHeight, dgv.Width - width - 2, (height / dgv.Rows.Count) * 5 + dgv.ColumnHeadersHeight);
            }
            foreach (LeftHeader item in LeftHeaders)
            {
                using (Pen gridLinePen = new Pen(dgv.GridColor))
                {
                    //分割线
                    e.Graphics.DrawLine(gridLinePen, e.RowBounds.Left, (height / dgv.Rows.Count) * (item.Span + item.Index) + dgv.ColumnHeadersHeight, dgv.Width - width - 2, (height / dgv.Rows.Count) * (item.Span + item.Index) + dgv.ColumnHeadersHeight);
                    //字符串
                    e.Graphics.DrawString(item.Text, e.InheritedRowStyle.Font, new SolidBrush(e.InheritedRowStyle.ForeColor), e.RowBounds.Left + dgv.Width - width - (dgv.Width - width) / 2, dgv.ColumnHeadersHeight + ((height / dgv.Rows.Count) * (item.Span + 2 * item.Index)) / 2, SF);
                }
            }
        }

        private List<LeftHeader> _leftHeaders = new List<LeftHeader>();
        public List<LeftHeader> LeftHeaders
        {
            get { return _leftHeaders; }
        }
        /// <summary>
        /// 合并行表头结构体
        /// </summary>
        public struct LeftHeader
        {
            public LeftHeader(int index, int span, string text)
            {
                this.Index = index;
                this.Span = span;
                this.Text = text;
            }
            public int Index;
            public int Span;
            public string Text;
        }
    }
}
