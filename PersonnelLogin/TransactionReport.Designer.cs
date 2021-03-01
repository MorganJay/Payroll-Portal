namespace PersonnelLogin
{
    partial class TransactionReport
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
            this.TransactionTypeView = new PersonnelLogin.TransactionTypeView();
            this.View_TransactionTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_TransactionTypeTableAdapter = new PersonnelLogin.TransactionTypeViewTableAdapters.View_TransactionTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionTypeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_TransactionTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_TransactionTypeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PersonnelLogin.Report8.rdlc";
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
            this.reportViewer1.Size = new System.Drawing.Size(764, 292);
            this.reportViewer1.TabIndex = 0;
            // 
            // TransactionTypeView
            // 
            this.TransactionTypeView.DataSetName = "TransactionTypeView";
            this.TransactionTypeView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_TransactionTypeBindingSource
            // 
            this.View_TransactionTypeBindingSource.DataMember = "View_TransactionType";
            this.View_TransactionTypeBindingSource.DataSource = this.TransactionTypeView;
            // 
            // View_TransactionTypeTableAdapter
            // 
            this.View_TransactionTypeTableAdapter.ClearBeforeFill = true;
            // 
            // TransactionReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(764, 292);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TransactionReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Type Report";
            this.Load += new System.EventHandler(this.TransactionReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionTypeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_TransactionTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource View_TransactionTypeBindingSource;
        private TransactionTypeView TransactionTypeView;
        private TransactionTypeViewTableAdapters.View_TransactionTypeTableAdapter View_TransactionTypeTableAdapter;
    }
}