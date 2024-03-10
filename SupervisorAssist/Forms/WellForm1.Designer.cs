namespace Forms
{
    partial class WellForm1
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
            this.dataTable1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dS1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DS1 = new Forms.DS1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS2 = new Forms.DS2();
            this.dS2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS3 = new Forms.DS3();
            this.dataTable1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTable1BindingSource2
            // 
            this.dataTable1BindingSource2.DataMember = "DataTable1";
            this.dataTable1BindingSource2.DataSource = this.dS1BindingSource1;
            // 
            // dS1BindingSource1
            // 
            this.dS1BindingSource1.DataSource = this.DS1;
            this.dS1BindingSource1.Position = 0;
            // 
            // DS1
            // 
            this.DS1.DataSetName = "DS1";
            this.DS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dataTable1BindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Forms.监督报告附表（三）现场问题及整改情况统计表.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(947, 474);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.DS1;
            // 
            // DS2
            // 
            this.DS2.DataSetName = "DS2";
            this.DS2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dS2BindingSource
            // 
            this.dS2BindingSource.DataSource = this.DS2;
            this.dS2BindingSource.Position = 0;
            // 
            // dS1BindingSource
            // 
            this.dS1BindingSource.DataSource = this.DS1;
            this.dS1BindingSource.Position = 0;
            // 
            // DS3
            // 
            this.DS3.DataSetName = "DS3";
            this.DS3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource1
            // 
            this.dataTable1BindingSource1.DataMember = "DataTable1";
            this.dataTable1BindingSource1.DataSource = this.DS1;
            // 
            // WellForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 474);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "WellForm1";
            this.Text = "WellForm1";
            this.Load += new System.EventHandler(this.WellForm1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private DS1 DS1;
        private DS2 DS2;
        private System.Windows.Forms.BindingSource dS2BindingSource;
        private System.Windows.Forms.BindingSource dS1BindingSource;
        private DS3 DS3;
        private System.Windows.Forms.BindingSource dataTable1BindingSource1;
        private System.Windows.Forms.BindingSource dataTable1BindingSource2;
        private System.Windows.Forms.BindingSource dS1BindingSource1;
    }
}