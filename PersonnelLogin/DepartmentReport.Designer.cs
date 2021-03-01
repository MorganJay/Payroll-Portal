namespace PersonnelLogin
{
    partial class DepartmentReport
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
            this.View_DepartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DepartmentView = new PersonnelLogin.DepartmentView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_DepartmentTableAdapter = new PersonnelLogin.DepartmentViewTableAdapters.View_DepartmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_DepartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentView)).BeginInit();
            this.SuspendLayout();
            // 
            // View_DepartmentBindingSource
            // 
            this.View_DepartmentBindingSource.DataMember = "View_Department";
            this.View_DepartmentBindingSource.DataSource = this.DepartmentView;
            // 
            // DepartmentView
            // 
            this.DepartmentView.DataSetName = "DepartmentView";
            this.DepartmentView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_DepartmentBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PersonnelLogin.Report4.rdlc";
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
            this.reportViewer1.Size = new System.Drawing.Size(708, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_DepartmentTableAdapter
            // 
            this.View_DepartmentTableAdapter.ClearBeforeFill = true;
            // 
            // DepartmentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(708, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "DepartmentReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Department Report";
            this.Load += new System.EventHandler(this.DepartmentReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_DepartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmentView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_DepartmentBindingSource;
        private DepartmentView DepartmentView;
        private DepartmentViewTableAdapters.View_DepartmentTableAdapter View_DepartmentTableAdapter;
    }
}