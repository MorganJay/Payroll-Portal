namespace PersonnelLogin
{
    partial class PayrollSlipReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_PayrollSlipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LogInDataSet3 = new PersonnelLogin.LogInDataSet3();
            this.View_PayrollSlipTableAdapter = new PersonnelLogin.LogInDataSet3TableAdapters.View_PayrollSlipTableAdapter();
            this.LogInDataSet4 = new PersonnelLogin.LogInDataSet4();
            this.View_3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_3TableAdapter = new PersonnelLogin.LogInDataSet4TableAdapters.View_3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_PayrollSlipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet2";
            reportDataSource3.Value = this.View_3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PersonnelLogin.Report9.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowContextMenu = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowExportButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowProgress = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowRefreshButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.ShowZoomControl = false;
            this.reportViewer1.Size = new System.Drawing.Size(659, 337);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_PayrollSlipBindingSource
            // 
            this.View_PayrollSlipBindingSource.DataMember = "View_PayrollSlip";
            this.View_PayrollSlipBindingSource.DataSource = this.LogInDataSet3;
            // 
            // LogInDataSet3
            // 
            this.LogInDataSet3.DataSetName = "LogInDataSet3";
            this.LogInDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_PayrollSlipTableAdapter
            // 
            this.View_PayrollSlipTableAdapter.ClearBeforeFill = true;
            // 
            // LogInDataSet4
            // 
            this.LogInDataSet4.DataSetName = "LogInDataSet4";
            this.LogInDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_3BindingSource
            // 
            this.View_3BindingSource.DataMember = "View_3";
            this.View_3BindingSource.DataSource = this.LogInDataSet4;
            // 
            // View_3TableAdapter
            // 
            this.View_3TableAdapter.ClearBeforeFill = true;
            // 
            // PayrollSlipReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 337);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PayrollSlipReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Slip Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PayrollSlipReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_PayrollSlipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_PayrollSlipBindingSource;
        private LogInDataSet3 LogInDataSet3;
        private LogInDataSet3TableAdapters.View_PayrollSlipTableAdapter View_PayrollSlipTableAdapter;
        private System.Windows.Forms.BindingSource View_3BindingSource;
        private LogInDataSet4 LogInDataSet4;
        private LogInDataSet4TableAdapters.View_3TableAdapter View_3TableAdapter;
    }
}