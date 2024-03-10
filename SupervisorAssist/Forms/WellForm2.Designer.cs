namespace Forms
{
    partial class WellForm2
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
            this.dataTable2BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.DS2 = new Forms.DS2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dS2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable2BindingSource2
            // 
            this.dataTable2BindingSource2.DataMember = "DataTable2";
            this.dataTable2BindingSource2.DataSource = this.DS2;
            // 
            // DS2
            // 
            this.DS2.DataSetName = "DS2";
            this.DS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable2BindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Forms.地质监督发现问题统计表—开工验收.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(818, 405);
            this.reportViewer1.TabIndex = 0;
            // 
            // dS2BindingSource
            // 
            this.dS2BindingSource.DataSource = this.DS2;
            this.dS2BindingSource.Position = 0;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.dS2BindingSource;
            // 
            // dS2BindingSource1
            // 
            this.dS2BindingSource1.DataSource = this.DS2;
            this.dS2BindingSource1.Position = 0;
            // 
            // dataTable2BindingSource1
            // 
            this.dataTable2BindingSource1.DataMember = "DataTable2";
            this.dataTable2BindingSource1.DataSource = this.DS2;
            // 
            // WellForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 405);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WellForm2";
            this.Text = "WellForm2";
            this.Load += new System.EventHandler(this.WellForm2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS2 DS2;
        private System.Windows.Forms.BindingSource dataTable2BindingSource1;
        private System.Windows.Forms.BindingSource dS2BindingSource;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private System.Windows.Forms.BindingSource dS2BindingSource1;
        private System.Windows.Forms.BindingSource dataTable2BindingSource2;
    }
}