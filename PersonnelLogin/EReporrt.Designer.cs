namespace PersonnelLogin
{
    partial class EReporrt
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
            this.View_1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmployeeView = new PersonnelLogin.EmployeeView();
            this.SystemDefaultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LogInDataSet6 = new PersonnelLogin.LogInDataSet6();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_1TableAdapter = new PersonnelLogin.EmployeeViewTableAdapters.View_1TableAdapter();
            this.SystemDefaultsTableAdapter = new PersonnelLogin.LogInDataSet6TableAdapters.SystemDefaultsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemDefaultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // View_1BindingSource
            // 
            this.View_1BindingSource.DataMember = "View_1";
            this.View_1BindingSource.DataSource = this.EmployeeView;
            // 
            // EmployeeView
            // 
            this.EmployeeView.DataSetName = "EmployeeView";
            this.EmployeeView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SystemDefaultsBindingSource
            // 
            this.SystemDefaultsBindingSource.DataMember = "SystemDefaults";
            this.SystemDefaultsBindingSource.DataSource = this.LogInDataSet6;
            // 
            // LogInDataSet6
            // 
            this.LogInDataSet6.DataSetName = "LogInDataSet6";
            this.LogInDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_1BindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.SystemDefaultsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PersonnelLogin.Report2.rdlc";
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
            this.reportViewer1.Size = new System.Drawing.Size(567, 272);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_1TableAdapter
            // 
            this.View_1TableAdapter.ClearBeforeFill = true;
            // 
            // SystemDefaultsTableAdapter
            // 
            this.SystemDefaultsTableAdapter.ClearBeforeFill = true;
            // 
            // EReporrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 272);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EReporrt";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Biodata Report";
            this.Load += new System.EventHandler(this.EReporrt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SystemDefaultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_1BindingSource;
        private EmployeeView EmployeeView;
        private EmployeeViewTableAdapters.View_1TableAdapter View_1TableAdapter;
        private System.Windows.Forms.BindingSource SystemDefaultsBindingSource;
        private LogInDataSet6 LogInDataSet6;
        private LogInDataSet6TableAdapters.SystemDefaultsTableAdapter SystemDefaultsTableAdapter;
    }
}