namespace PersonnelLogin
{
    partial class JobDescriptionReport
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
            this.View_JobDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.JobDescriptionView = new PersonnelLogin.JobDescriptionView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_JobDescriptionTableAdapter = new PersonnelLogin.JobDescriptionViewTableAdapters.View_JobDescriptionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_JobDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobDescriptionView)).BeginInit();
            this.SuspendLayout();
            // 
            // View_JobDescriptionBindingSource
            // 
            this.View_JobDescriptionBindingSource.DataMember = "View_JobDescription";
            this.View_JobDescriptionBindingSource.DataSource = this.JobDescriptionView;
            // 
            // JobDescriptionView
            // 
            this.JobDescriptionView.DataSetName = "JobDescriptionView";
            this.JobDescriptionView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_JobDescriptionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PersonnelLogin.Report5.rdlc";
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
            this.reportViewer1.Size = new System.Drawing.Size(784, 453);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_JobDescriptionTableAdapter
            // 
            this.View_JobDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // JobDescriptionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 453);
            this.Controls.Add(this.reportViewer1);
            this.Name = "JobDescriptionReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job Description Report";
            this.Load += new System.EventHandler(this.JobDescriptionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_JobDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JobDescriptionView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_JobDescriptionBindingSource;
        private JobDescriptionView JobDescriptionView;
        private JobDescriptionViewTableAdapters.View_JobDescriptionTableAdapter View_JobDescriptionTableAdapter;
    }
}