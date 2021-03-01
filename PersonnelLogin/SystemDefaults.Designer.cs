namespace PersonnelLogin
{
    partial class SystemDefaults
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
            System.Windows.Forms.Label companyNameLabel;
            System.Windows.Forms.Label maxSalaryDaysLabel;
            System.Windows.Forms.Label salaryStartDateLabel;
            System.Windows.Forms.Label salaryEndDateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemDefaults));
            this.logInDataSet6 = new PersonnelLogin.LogInDataSet6();
            this.systemDefaultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemDefaultsTableAdapter = new PersonnelLogin.LogInDataSet6TableAdapters.SystemDefaultsTableAdapter();
            this.tableAdapterManager = new PersonnelLogin.LogInDataSet6TableAdapters.TableAdapterManager();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.maxSalaryDaysTextBox = new System.Windows.Forms.TextBox();
            this.salaryStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salaryEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.printbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deletebutton = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            companyNameLabel = new System.Windows.Forms.Label();
            maxSalaryDaysLabel = new System.Windows.Forms.Label();
            salaryStartDateLabel = new System.Windows.Forms.Label();
            salaryEndDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // companyNameLabel
            // 
            companyNameLabel.AutoSize = true;
            companyNameLabel.Location = new System.Drawing.Point(50, 57);
            companyNameLabel.Name = "companyNameLabel";
            companyNameLabel.Size = new System.Drawing.Size(132, 20);
            companyNameLabel.TabIndex = 1;
            companyNameLabel.Text = "COMPANY NAME :";
            // 
            // maxSalaryDaysLabel
            // 
            maxSalaryDaysLabel.AutoSize = true;
            maxSalaryDaysLabel.Location = new System.Drawing.Point(37, 143);
            maxSalaryDaysLabel.Name = "maxSalaryDaysLabel";
            maxSalaryDaysLabel.Size = new System.Drawing.Size(145, 20);
            maxSalaryDaysLabel.TabIndex = 3;
            maxSalaryDaysLabel.Text = "MAX SALARY DAYS :";
            // 
            // salaryStartDateLabel
            // 
            salaryStartDateLabel.AutoSize = true;
            salaryStartDateLabel.Location = new System.Drawing.Point(26, 99);
            salaryStartDateLabel.Name = "salaryStartDateLabel";
            salaryStartDateLabel.Size = new System.Drawing.Size(156, 20);
            salaryStartDateLabel.TabIndex = 5;
            salaryStartDateLabel.Text = "SALARY START DATE :";
            // 
            // salaryEndDateLabel
            // 
            salaryEndDateLabel.AutoSize = true;
            salaryEndDateLabel.Location = new System.Drawing.Point(358, 102);
            salaryEndDateLabel.Name = "salaryEndDateLabel";
            salaryEndDateLabel.Size = new System.Drawing.Size(143, 20);
            salaryEndDateLabel.TabIndex = 7;
            salaryEndDateLabel.Text = "SALARY END DATE :";
            // 
            // logInDataSet6
            // 
            this.logInDataSet6.DataSetName = "LogInDataSet6";
            this.logInDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // systemDefaultsBindingSource
            // 
            this.systemDefaultsBindingSource.DataMember = "SystemDefaults";
            this.systemDefaultsBindingSource.DataSource = this.logInDataSet6;
            // 
            // systemDefaultsTableAdapter
            // 
            this.systemDefaultsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SystemDefaultsTableAdapter = this.systemDefaultsTableAdapter;
            this.tableAdapterManager.UpdateOrder = PersonnelLogin.LogInDataSet6TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemDefaultsBindingSource, "CompanyName", true));
            this.companyNameTextBox.Location = new System.Drawing.Point(188, 54);
            this.companyNameTextBox.MaxLength = 50;
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.ReadOnly = true;
            this.companyNameTextBox.Size = new System.Drawing.Size(437, 27);
            this.companyNameTextBox.TabIndex = 2;
            // 
            // maxSalaryDaysTextBox
            // 
            this.maxSalaryDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemDefaultsBindingSource, "MaxSalaryDays", true));
            this.maxSalaryDaysTextBox.Location = new System.Drawing.Point(188, 140);
            this.maxSalaryDaysTextBox.MaxLength = 5;
            this.maxSalaryDaysTextBox.Name = "maxSalaryDaysTextBox";
            this.maxSalaryDaysTextBox.ReadOnly = true;
            this.maxSalaryDaysTextBox.Size = new System.Drawing.Size(43, 27);
            this.maxSalaryDaysTextBox.TabIndex = 4;
            // 
            // salaryStartDateDateTimePicker
            // 
            this.salaryStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.systemDefaultsBindingSource, "SalaryStartDate", true));
            this.salaryStartDateDateTimePicker.Enabled = false;
            this.salaryStartDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.salaryStartDateDateTimePicker.Location = new System.Drawing.Point(188, 96);
            this.salaryStartDateDateTimePicker.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.salaryStartDateDateTimePicker.Name = "salaryStartDateDateTimePicker";
            this.salaryStartDateDateTimePicker.Size = new System.Drawing.Size(118, 27);
            this.salaryStartDateDateTimePicker.TabIndex = 6;
            // 
            // salaryEndDateDateTimePicker
            // 
            this.salaryEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.systemDefaultsBindingSource, "SalaryEndDate", true));
            this.salaryEndDateDateTimePicker.Enabled = false;
            this.salaryEndDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.salaryEndDateDateTimePicker.Location = new System.Drawing.Point(507, 99);
            this.salaryEndDateDateTimePicker.Name = "salaryEndDateDateTimePicker";
            this.salaryEndDateDateTimePicker.Size = new System.Drawing.Size(118, 27);
            this.salaryEndDateDateTimePicker.TabIndex = 8;
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(363, 187);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(61, 32);
            this.printbutton.TabIndex = 91;
            this.printbutton.Text = "PRINT";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            this.printbutton.MouseEnter += new System.EventHandler(this.printbutton_MouseEnter);
            // 
            // cancelbutton
            // 
            this.cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbutton.Enabled = false;
            this.cancelbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(296, 187);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(61, 32);
            this.cancelbutton.TabIndex = 94;
            this.cancelbutton.Text = "UNDO";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(228, 187);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(63, 32);
            this.savebutton.TabIndex = 93;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.Red;
            this.exitbutton.Location = new System.Drawing.Point(507, 187);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(56, 32);
            this.exitbutton.TabIndex = 92;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.Location = new System.Drawing.Point(163, 187);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(60, 32);
            this.editbutton.TabIndex = 95;
            this.editbutton.Text = "EDIT";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 37);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(650, 1);
            this.textBox3.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 96;
            this.label1.Text = "SYSTEM DEFAULTS";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(22, 180);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(650, 1);
            this.textBox1.TabIndex = 98;
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(430, 187);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(71, 32);
            this.deletebutton.TabIndex = 99;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // SystemDefaults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(669, 228);
            this.ControlBox = false;
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(salaryEndDateLabel);
            this.Controls.Add(this.salaryEndDateDateTimePicker);
            this.Controls.Add(salaryStartDateLabel);
            this.Controls.Add(this.salaryStartDateDateTimePicker);
            this.Controls.Add(maxSalaryDaysLabel);
            this.Controls.Add(this.maxSalaryDaysTextBox);
            this.Controls.Add(companyNameLabel);
            this.Controls.Add(this.companyNameTextBox);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SystemDefaults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Utilities";
            this.Load += new System.EventHandler(this.SystemDefaults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LogInDataSet6 logInDataSet6;
        private System.Windows.Forms.BindingSource systemDefaultsBindingSource;
        private LogInDataSet6TableAdapters.SystemDefaultsTableAdapter systemDefaultsTableAdapter;
        private LogInDataSet6TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox maxSalaryDaysTextBox;
        private System.Windows.Forms.DateTimePicker salaryStartDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker salaryEndDateDateTimePicker;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button deletebutton;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}