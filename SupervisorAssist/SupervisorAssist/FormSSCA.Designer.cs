namespace SupervisorAssist
{
    partial class FormSSCA
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
            this.DataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetRN = new SupervisorAssist.DataSetRN();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable3BindingSource
            // 
            this.DataTable3BindingSource.DataMember = "DataTable3";
            this.DataTable3BindingSource.DataSource = this.DataSetRN;
            // 
            // DataSetRN
            // 
            this.DataSetRN.DataSetName = "DataSetRN";
            this.DataSetRN.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.DataSetRN;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SupervisorAssist.ReportSSCA.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1192, 687);
            this.reportViewer1.TabIndex = 0;
            // 
            // FormSSCA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 687);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormSSCA";
            this.ShowIcon = false;
            this.Text = "开工验收单";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormSSCA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetRN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource DataTable3BindingSource;
        private DataSetRN DataSetRN;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}