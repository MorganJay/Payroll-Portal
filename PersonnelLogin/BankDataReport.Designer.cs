namespace PersonnelLogin
{
    partial class BankDataReport
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
            this.View_BankDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BankDataView = new PersonnelLogin.BankDataView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_BankDataTableAdapter = new PersonnelLogin.BankDataViewTableAdapters.View_BankDataTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_BankDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // View_BankDataBindingSource
            // 
            this.View_BankDataBindingSource.DataMember = "View_BankData";
            this.View_BankDataBindingSource.DataSource = this.BankDataView;
            // 
            // BankDataView
            // 
            this.BankDataView.DataSetName = "BankDataView";
            this.BankDataView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_BankDataBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PersonnelLogin.Report3.rdlc";
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
            this.reportViewer1.Size = new System.Drawing.Size(780, 446);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_BankDataTableAdapter
            // 
            this.View_BankDataTableAdapter.ClearBeforeFill = true;
            // 
            // BankDataReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(780, 446);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BankDataReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BankData Report";
            this.Load += new System.EventHandler(this.BankDataReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_BankDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BankDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_BankDataBindingSource;
        private BankDataView BankDataView;
        private BankDataViewTableAdapters.View_BankDataTableAdapter View_BankDataTableAdapter;
    }
}