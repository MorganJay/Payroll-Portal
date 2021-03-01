namespace PersonnelLogin
{
    partial class StateReport
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
            this.systemDefaultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logInDataSet6 = new PersonnelLogin.LogInDataSet6();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LogInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.systemDefaultsTableAdapter = new PersonnelLogin.LogInDataSet6TableAdapters.SystemDefaultsTableAdapter();
            this.StatesView = new PersonnelLogin.StatesView();
            this.View_StatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_StatesTableAdapter = new PersonnelLogin.StatesViewTableAdapters.View_StatesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatesView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_StatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // systemDefaultsBindingSource
            // 
            this.systemDefaultsBindingSource.DataMember = "SystemDefaults";
            this.systemDefaultsBindingSource.DataSource = this.logInDataSet6;
            // 
            // logInDataSet6
            // 
            this.logInDataSet6.DataSetName = "LogInDataSet6";
            this.logInDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.View_StatesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PersonnelLogin.ReportState.rdlc";
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
            this.reportViewer1.Size = new System.Drawing.Size(698, 318);
            this.reportViewer1.TabIndex = 0;
            // 
            // systemDefaultsTableAdapter
            // 
            this.systemDefaultsTableAdapter.ClearBeforeFill = true;
            // 
            // StatesView
            // 
            this.StatesView.DataSetName = "StatesView";
            this.StatesView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_StatesBindingSource
            // 
            this.View_StatesBindingSource.DataMember = "View_States";
            this.View_StatesBindingSource.DataSource = this.StatesView;
            // 
            // View_StatesTableAdapter
            // 
            this.View_StatesTableAdapter.ClearBeforeFill = true;
            // 
            // StateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 318);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StateReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "State Report";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatesView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_StatesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource LogInBindingSource;
 private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
     
        private LogInDataSet6 logInDataSet6;
        private System.Windows.Forms.BindingSource systemDefaultsBindingSource;
        private LogInDataSet6TableAdapters.SystemDefaultsTableAdapter systemDefaultsTableAdapter;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private System.Windows.Forms.BindingSource View_StatesBindingSource;
        private StatesView StatesView;
        private StatesViewTableAdapters.View_StatesTableAdapter View_StatesTableAdapter;
        //private DataSet2 DataSet2;
        //private DataSet2TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}