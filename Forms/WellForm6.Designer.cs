namespace Forms
{
    partial class WellForm6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable6_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS6 = new Forms.DS6();
            this.DataTable6_2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable6_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable6_2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable6_1BindingSource
            // 
            this.DataTable6_1BindingSource.DataMember = "DataTable6_1";
            this.DataTable6_1BindingSource.DataSource = this.DS6;
            // 
            // DS6
            // 
            this.DS6.DataSetName = "DS6";
            this.DS6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable6_2BindingSource
            // 
            this.DataTable6_2BindingSource.DataMember = "DataTable6_2";
            this.DataTable6_2BindingSource.DataSource = this.DS6;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable6_1BindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.DataTable6_2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Forms.监督报告附表（二）录井工作量统计表（时间）.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1042, 898);
            this.reportViewer1.TabIndex = 0;
            // 
            // WellForm6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 898);
            this.Controls.Add(this.reportViewer1);
            this.Name = "WellForm6";
            this.ShowIcon = false;
            this.Text = "WellForm6";
            this.Load += new System.EventHandler(this.WellForm6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable6_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable6_2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable6_1BindingSource;
        private DS6 DS6;
        private System.Windows.Forms.BindingSource DataTable6_2BindingSource;
    }
}