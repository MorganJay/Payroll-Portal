namespace PersonnelLogin
{
    partial class PFAReport
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
            this.PFAView = new PersonnelLogin.PFAView();
            this.View_PFABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_PFATableAdapter = new PersonnelLogin.PFAViewTableAdapters.View_PFATableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PFAView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_PFABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_PFABindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PersonnelLogin.Report6.rdlc";
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
            this.reportViewer1.Size = new System.Drawing.Size(771, 330);
            this.reportViewer1.TabIndex = 0;
            // 
            // PFAView
            // 
            this.PFAView.DataSetName = "PFAView";
            this.PFAView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_PFABindingSource
            // 
            this.View_PFABindingSource.DataMember = "View_PFA";
            this.View_PFABindingSource.DataSource = this.PFAView;
            // 
            // View_PFATableAdapter
            // 
            this.View_PFATableAdapter.ClearBeforeFill = true;
            // 
            // PFAReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(771, 330);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PFAReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PFA Data Report";
            this.Load += new System.EventHandler(this.PFAReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PFAView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_PFABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_PFABindingSource;
        private PFAView PFAView;
        private PFAViewTableAdapters.View_PFATableAdapter View_PFATableAdapter;
    }
}