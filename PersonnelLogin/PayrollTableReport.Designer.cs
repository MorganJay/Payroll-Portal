namespace PersonnelLogin
{
    partial class PayrollTableReport
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
            this.View_PayrollTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PayrollTableView = new PersonnelLogin.PayrollTableView();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.View_PayrollTableTableAdapter = new PersonnelLogin.PayrollTableViewTableAdapters.View_PayrollTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.View_PayrollTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // View_PayrollTableBindingSource
            // 
            this.View_PayrollTableBindingSource.DataMember = "View_PayrollTable";
            this.View_PayrollTableBindingSource.DataSource = this.PayrollTableView;
            // 
            // PayrollTableView
            // 
            this.PayrollTableView.DataSetName = "PayrollTableView";
            this.PayrollTableView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_PayrollTableBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PersonnelLogin.Report1.rdlc";
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
            this.reportViewer1.Size = new System.Drawing.Size(655, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // View_PayrollTableTableAdapter
            // 
            this.View_PayrollTableTableAdapter.ClearBeforeFill = true;
            // 
            // PayrollTableReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(655, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PayrollTableReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Table Report";
            this.Load += new System.EventHandler(this.PayrollTableReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.View_PayrollTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollTableView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_PayrollTableBindingSource;
        private PayrollTableView PayrollTableView;
        private PayrollTableViewTableAdapters.View_PayrollTableTableAdapter View_PayrollTableTableAdapter;
    }
}