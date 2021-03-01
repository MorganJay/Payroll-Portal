namespace PersonnelLogin
{
    partial class StatutoryReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StatutoryView = new PersonnelLogin.StatutoryView();
            this.View_StatutoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_StatutoryTableAdapter = new PersonnelLogin.StatutoryViewTableAdapters.View_StatutoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StatutoryView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_StatutoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_StatutoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PersonnelLogin.Report7.rdlc";
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
            this.reportViewer1.Size = new System.Drawing.Size(783, 367);
            this.reportViewer1.TabIndex = 0;
            // 
            // StatutoryView
            // 
            this.StatutoryView.DataSetName = "StatutoryView";
            this.StatutoryView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_StatutoryBindingSource
            // 
            this.View_StatutoryBindingSource.DataMember = "View_Statutory";
            this.View_StatutoryBindingSource.DataSource = this.StatutoryView;
            // 
            // View_StatutoryTableAdapter
            // 
            this.View_StatutoryTableAdapter.ClearBeforeFill = true;
            // 
            // StatutoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 367);
            this.Controls.Add(this.reportViewer1);
            this.Name = "StatutoryReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statutory Deduction Report";
            this.Load += new System.EventHandler(this.StatutoryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StatutoryView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_StatutoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_StatutoryBindingSource;
        private StatutoryView StatutoryView;
        private StatutoryViewTableAdapters.View_StatutoryTableAdapter View_StatutoryTableAdapter;
    }
}