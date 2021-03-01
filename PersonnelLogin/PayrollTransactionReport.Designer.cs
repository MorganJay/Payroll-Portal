namespace PersonnelLogin
{
    partial class PayrollTransactionReport
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
            this.PayrollTransactionView = new PersonnelLogin.PayrollTransactionView();
            this.View_PayrollTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_PayrollTransactionTableAdapter = new PersonnelLogin.PayrollTransactionViewTableAdapters.View_PayrollTransactionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PayrollTransactionView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_PayrollTransactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_PayrollTransactionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PersonnelLogin.PtReport.rdlc";
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
            this.reportViewer1.Size = new System.Drawing.Size(748, 476);
            this.reportViewer1.TabIndex = 0;
            // 
            // PayrollTransactionView
            // 
            this.PayrollTransactionView.DataSetName = "PayrollTransactionView";
            this.PayrollTransactionView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_PayrollTransactionBindingSource
            // 
            this.View_PayrollTransactionBindingSource.DataMember = "View_PayrollTransaction";
            this.View_PayrollTransactionBindingSource.DataSource = this.PayrollTransactionView;
            // 
            // View_PayrollTransactionTableAdapter
            // 
            this.View_PayrollTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // PayrollTransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(748, 476);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PayrollTransactionReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll Transaction Report";
            this.Load += new System.EventHandler(this.PayrollTransactionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PayrollTransactionView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_PayrollTransactionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_PayrollTransactionBindingSource;
        private PayrollTransactionView PayrollTransactionView;
        private PayrollTransactionViewTableAdapters.View_PayrollTransactionTableAdapter View_PayrollTransactionTableAdapter;
    }
}