namespace PersonnelLogin
{
    partial class PayrollTable
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
            System.Windows.Forms.Label staffIDLabel;
            System.Windows.Forms.Label salaryPeriodLabel;
            System.Windows.Forms.Label daysWorkedLabel;
            System.Windows.Forms.Label absentDaysLabel;
            System.Windows.Forms.Label grossSalaryLabel;
            System.Windows.Forms.Label netSalaryLabel;
            System.Windows.Forms.Label bankCodeLabel;
            System.Windows.Forms.Label accountNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollTable));
            System.Windows.Forms.Label deductionLabel1;
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.printbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.bottombutton = new System.Windows.Forms.Button();
            this.previousbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.topbutton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.logInDataSet6 = new PersonnelLogin.LogInDataSet6();
            this.systemDefaultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemDefaultsTableAdapter = new PersonnelLogin.LogInDataSet6TableAdapters.SystemDefaultsTableAdapter();
            this.tableAdapterManager = new PersonnelLogin.LogInDataSet6TableAdapters.TableAdapterManager();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.staffIDTextBox = new System.Windows.Forms.TextBox();
            this.payrollTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logInDataSet2 = new PersonnelLogin.LogInDataSet2();
            this.salaryPeriodTextBox = new System.Windows.Forms.TextBox();
            this.daysWorkedTextBox = new System.Windows.Forms.TextBox();
            this.absentDaysTextBox = new System.Windows.Forms.TextBox();
            this.grossSalaryTextBox = new System.Windows.Forms.TextBox();
            this.netSalaryTextBox = new System.Windows.Forms.TextBox();
            this.accountNumberTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.bankCodeTextBox = new System.Windows.Forms.TextBox();
            this.maxDaysLabel = new System.Windows.Forms.Label();
            this.systemDefaultsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.systemDefaultsDataSet = new PersonnelLogin.SystemDefaultsDataSet();
            this.systemDefaultsTableAdapter1 = new PersonnelLogin.SystemDefaultsDataSetTableAdapters.SystemDefaultsTableAdapter();
            this.tableAdapterManager1 = new PersonnelLogin.SystemDefaultsDataSetTableAdapters.TableAdapterManager();
            this.payeLabel = new System.Windows.Forms.Label();
            this.dlabel = new System.Windows.Forms.Label();
            this.payrollTableTableAdapter1 = new PersonnelLogin.LogInDataSet2TableAdapters.PayrollTableTableAdapter();
            this.tableAdapterManager2 = new PersonnelLogin.LogInDataSet2TableAdapters.TableAdapterManager();
            this.deductionTextBox = new System.Windows.Forms.TextBox();
            staffIDLabel = new System.Windows.Forms.Label();
            salaryPeriodLabel = new System.Windows.Forms.Label();
            daysWorkedLabel = new System.Windows.Forms.Label();
            absentDaysLabel = new System.Windows.Forms.Label();
            grossSalaryLabel = new System.Windows.Forms.Label();
            netSalaryLabel = new System.Windows.Forms.Label();
            bankCodeLabel = new System.Windows.Forms.Label();
            accountNumberLabel = new System.Windows.Forms.Label();
            deductionLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // staffIDLabel
            // 
            staffIDLabel.AutoSize = true;
            staffIDLabel.Location = new System.Drawing.Point(34, 53);
            staffIDLabel.Name = "staffIDLabel";
            staffIDLabel.Size = new System.Drawing.Size(102, 20);
            staffIDLabel.TabIndex = 99;
            staffIDLabel.Text = "EMPLOYEE ID:";
            // 
            // salaryPeriodLabel
            // 
            salaryPeriodLabel.AutoSize = true;
            salaryPeriodLabel.Location = new System.Drawing.Point(17, 99);
            salaryPeriodLabel.Name = "salaryPeriodLabel";
            salaryPeriodLabel.Size = new System.Drawing.Size(119, 20);
            salaryPeriodLabel.TabIndex = 100;
            salaryPeriodLabel.Text = "SALARY PERIOD:";
            // 
            // daysWorkedLabel
            // 
            daysWorkedLabel.AutoSize = true;
            daysWorkedLabel.Location = new System.Drawing.Point(253, 99);
            daysWorkedLabel.Name = "daysWorkedLabel";
            daysWorkedLabel.Size = new System.Drawing.Size(115, 20);
            daysWorkedLabel.TabIndex = 101;
            daysWorkedLabel.Text = "DAYS WORKED:";
            // 
            // absentDaysLabel
            // 
            absentDaysLabel.AutoSize = true;
            absentDaysLabel.Location = new System.Drawing.Point(530, 99);
            absentDaysLabel.Name = "absentDaysLabel";
            absentDaysLabel.Size = new System.Drawing.Size(107, 20);
            absentDaysLabel.TabIndex = 102;
            absentDaysLabel.Text = "ABSENT DAYS:";
            // 
            // grossSalaryLabel
            // 
            grossSalaryLabel.AutoSize = true;
            grossSalaryLabel.Location = new System.Drawing.Point(255, 145);
            grossSalaryLabel.Name = "grossSalaryLabel";
            grossSalaryLabel.Size = new System.Drawing.Size(114, 20);
            grossSalaryLabel.TabIndex = 103;
            grossSalaryLabel.Text = "GROSS SALARY:";
            // 
            // netSalaryLabel
            // 
            netSalaryLabel.AutoSize = true;
            netSalaryLabel.Location = new System.Drawing.Point(541, 145);
            netSalaryLabel.Name = "netSalaryLabel";
            netSalaryLabel.Size = new System.Drawing.Size(95, 20);
            netSalaryLabel.TabIndex = 105;
            netSalaryLabel.Text = "NET SALARY:";
            // 
            // bankCodeLabel
            // 
            bankCodeLabel.AutoSize = true;
            bankCodeLabel.Location = new System.Drawing.Point(274, 53);
            bankCodeLabel.Name = "bankCodeLabel";
            bankCodeLabel.Size = new System.Drawing.Size(94, 20);
            bankCodeLabel.TabIndex = 106;
            bankCodeLabel.Text = "BANK CODE:";
            // 
            // accountNumberLabel
            // 
            accountNumberLabel.AutoSize = true;
            accountNumberLabel.Location = new System.Drawing.Point(493, 53);
            accountNumberLabel.Name = "accountNumberLabel";
            accountNumberLabel.Size = new System.Drawing.Size(144, 20);
            accountNumberLabel.TabIndex = 107;
            accountNumberLabel.Text = "ACCOUNT NUMBER:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(9, 36);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(762, 1);
            this.textBox3.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "PAYROLL TABLE DATA";
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(503, 191);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(61, 32);
            this.printbutton.TabIndex = 16;
            this.printbutton.Text = "PRINT";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            this.printbutton.MouseEnter += new System.EventHandler(this.printbutton_MouseEnter);
            // 
            // cancelbutton
            // 
            this.cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(435, 191);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(61, 32);
            this.cancelbutton.TabIndex = 15;
            this.cancelbutton.Text = "UNDO";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Visible = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Enabled = false;
            this.savebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(365, 191);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(63, 32);
            this.savebutton.TabIndex = 14;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            this.savebutton.MouseEnter += new System.EventHandler(this.savebutton_MouseEnter);
            // 
            // editbutton
            // 
            this.editbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.Location = new System.Drawing.Point(436, 191);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(60, 32);
            this.editbutton.TabIndex = 97;
            this.editbutton.Text = "EDIT";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.Red;
            this.exitbutton.Location = new System.Drawing.Point(649, 191);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(56, 32);
            this.exitbutton.TabIndex = 18;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(571, 191);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(71, 32);
            this.deletebutton.TabIndex = 17;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // bottombutton
            // 
            this.bottombutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottombutton.Location = new System.Drawing.Point(279, 191);
            this.bottombutton.Name = "bottombutton";
            this.bottombutton.Size = new System.Drawing.Size(80, 32);
            this.bottombutton.TabIndex = 13;
            this.bottombutton.Text = "BOTTOM";
            this.bottombutton.UseVisualStyleBackColor = true;
            this.bottombutton.Click += new System.EventHandler(this.bottombutton_Click);
            // 
            // previousbutton
            // 
            this.previousbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousbutton.Location = new System.Drawing.Point(121, 191);
            this.previousbutton.Name = "previousbutton";
            this.previousbutton.Size = new System.Drawing.Size(84, 32);
            this.previousbutton.TabIndex = 11;
            this.previousbutton.Text = "PREVIOUS";
            this.previousbutton.UseVisualStyleBackColor = true;
            this.previousbutton.Click += new System.EventHandler(this.previousbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.Location = new System.Drawing.Point(212, 191);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(60, 32);
            this.nextbutton.TabIndex = 12;
            this.nextbutton.Text = "NEXT";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // topbutton
            // 
            this.topbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbutton.Location = new System.Drawing.Point(63, 191);
            this.topbutton.Name = "topbutton";
            this.topbutton.Size = new System.Drawing.Size(51, 32);
            this.topbutton.TabIndex = 10;
            this.topbutton.Text = "TOP";
            this.topbutton.UseVisualStyleBackColor = true;
            this.topbutton.Click += new System.EventHandler(this.topbutton_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(9, 184);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(762, 1);
            this.textBox4.TabIndex = 96;
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
            this.companyNameTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.companyNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemDefaultsBindingSource, "CompanyName", true));
            this.companyNameTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.companyNameTextBox.Location = new System.Drawing.Point(215, 7);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(10, 20);
            this.companyNameTextBox.TabIndex = 99;
            this.companyNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // staffIDTextBox
            // 
            this.staffIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollTableBindingSource1, "StaffID", true));
            this.staffIDTextBox.Location = new System.Drawing.Point(142, 50);
            this.staffIDTextBox.MaxLength = 4;
            this.staffIDTextBox.Name = "staffIDTextBox";
            this.staffIDTextBox.ReadOnly = true;
            this.staffIDTextBox.Size = new System.Drawing.Size(45, 27);
            this.staffIDTextBox.TabIndex = 1;
            this.staffIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.staffIDTextBox.TextChanged += new System.EventHandler(this.staffIDTextBox_TextChanged);
            this.staffIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.staffIDTextBox_KeyPress);
            this.staffIDTextBox.Leave += new System.EventHandler(this.staffIDTextBox_Leave);
            // 
            // payrollTableBindingSource1
            // 
            this.payrollTableBindingSource1.DataMember = "PayrollTable";
            this.payrollTableBindingSource1.DataSource = this.logInDataSet2;
            // 
            // logInDataSet2
            // 
            this.logInDataSet2.DataSetName = "LogInDataSet2";
            this.logInDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salaryPeriodTextBox
            // 
            this.salaryPeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollTableBindingSource1, "SalaryPeriod", true));
            this.salaryPeriodTextBox.Location = new System.Drawing.Point(142, 96);
            this.salaryPeriodTextBox.MaxLength = 20;
            this.salaryPeriodTextBox.Name = "salaryPeriodTextBox";
            this.salaryPeriodTextBox.ReadOnly = true;
            this.salaryPeriodTextBox.Size = new System.Drawing.Size(70, 27);
            this.salaryPeriodTextBox.TabIndex = 4;
            this.salaryPeriodTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.salaryPeriodTextBox.TextChanged += new System.EventHandler(this.salaryPeriodTextBox_TextChanged);
            this.salaryPeriodTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salaryPeriodTextBox_KeyPress);
            // 
            // daysWorkedTextBox
            // 
            this.daysWorkedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollTableBindingSource1, "DaysWorked", true));
            this.daysWorkedTextBox.Location = new System.Drawing.Point(374, 96);
            this.daysWorkedTextBox.MaxLength = 2;
            this.daysWorkedTextBox.Name = "daysWorkedTextBox";
            this.daysWorkedTextBox.ReadOnly = true;
            this.daysWorkedTextBox.Size = new System.Drawing.Size(35, 27);
            this.daysWorkedTextBox.TabIndex = 5;
            this.daysWorkedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.daysWorkedTextBox.TextChanged += new System.EventHandler(this.daysWorkedTextBox_TextChanged);
            this.daysWorkedTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.daysWorkedTextBox_KeyPress);
            // 
            // absentDaysTextBox
            // 
            this.absentDaysTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollTableBindingSource1, "AbsentDays", true));
            this.absentDaysTextBox.Location = new System.Drawing.Point(642, 96);
            this.absentDaysTextBox.MaxLength = 3;
            this.absentDaysTextBox.Name = "absentDaysTextBox";
            this.absentDaysTextBox.ReadOnly = true;
            this.absentDaysTextBox.Size = new System.Drawing.Size(35, 27);
            this.absentDaysTextBox.TabIndex = 6;
            this.absentDaysTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.absentDaysTextBox.TextChanged += new System.EventHandler(this.absentDaysTextBox_TextChanged);
            this.absentDaysTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.absentDaysTextBox_KeyPress);
            // 
            // grossSalaryTextBox
            // 
            this.grossSalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollTableBindingSource1, "GrossSalary", true));
            this.grossSalaryTextBox.Location = new System.Drawing.Point(375, 138);
            this.grossSalaryTextBox.Name = "grossSalaryTextBox";
            this.grossSalaryTextBox.ReadOnly = true;
            this.grossSalaryTextBox.Size = new System.Drawing.Size(121, 27);
            this.grossSalaryTextBox.TabIndex = 9;
            this.grossSalaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.grossSalaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grossSalaryTextBox_KeyPress);
            // 
            // netSalaryTextBox
            // 
            this.netSalaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollTableBindingSource1, "NetSalary", true));
            this.netSalaryTextBox.Location = new System.Drawing.Point(642, 138);
            this.netSalaryTextBox.Name = "netSalaryTextBox";
            this.netSalaryTextBox.ReadOnly = true;
            this.netSalaryTextBox.Size = new System.Drawing.Size(126, 27);
            this.netSalaryTextBox.TabIndex = 8;
            this.netSalaryTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.netSalaryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.netSalaryTextBox_KeyPress);
            // 
            // accountNumberTextBox
            // 
            this.accountNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollTableBindingSource1, "AccountNumber", true));
            this.accountNumberTextBox.Location = new System.Drawing.Point(642, 50);
            this.accountNumberTextBox.MaxLength = 10;
            this.accountNumberTextBox.Name = "accountNumberTextBox";
            this.accountNumberTextBox.ReadOnly = true;
            this.accountNumberTextBox.Size = new System.Drawing.Size(95, 27);
            this.accountNumberTextBox.TabIndex = 3;
            this.accountNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.accountNumberTextBox.CursorChanged += new System.EventHandler(this.accountNumberTextBox_CursorChanged);
            this.accountNumberTextBox.TextChanged += new System.EventHandler(this.accountNumberTextBox_TextChanged);
            this.accountNumberTextBox.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.accountNumberTextBox_ControlRemoved);
            this.accountNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accountNumberTextBox_KeyPress);
            this.accountNumberTextBox.Leave += new System.EventHandler(this.accountNumberTextBox_Leave);
            this.accountNumberTextBox.MouseLeave += new System.EventHandler(this.accountNumberTextBox_MouseLeave);
            this.accountNumberTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.accountNumberTextBox_MouseMove);
            this.accountNumberTextBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.accountNumberTextBox_MouseUp);
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
            // bankCodeTextBox
            // 
            this.bankCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollTableBindingSource1, "BankCode", true));
            this.bankCodeTextBox.Location = new System.Drawing.Point(374, 50);
            this.bankCodeTextBox.Name = "bankCodeTextBox";
            this.bankCodeTextBox.ReadOnly = true;
            this.bankCodeTextBox.Size = new System.Drawing.Size(93, 27);
            this.bankCodeTextBox.TabIndex = 108;
            this.bankCodeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maxDaysLabel
            // 
            this.maxDaysLabel.AutoSize = true;
            this.maxDaysLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemDefaultsBindingSource1, "MaxSalaryDays", true));
            this.maxDaysLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.maxDaysLabel.Location = new System.Drawing.Point(415, 99);
            this.maxDaysLabel.Name = "maxDaysLabel";
            this.maxDaysLabel.Size = new System.Drawing.Size(100, 20);
            this.maxDaysLabel.TabIndex = 109;
            this.maxDaysLabel.Text = "maxdayslabel";
            // 
            // systemDefaultsBindingSource1
            // 
            this.systemDefaultsBindingSource1.DataMember = "SystemDefaults";
            this.systemDefaultsBindingSource1.DataSource = this.systemDefaultsDataSet;
            // 
            // systemDefaultsDataSet
            // 
            this.systemDefaultsDataSet.DataSetName = "SystemDefaultsDataSet";
            this.systemDefaultsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // systemDefaultsTableAdapter1
            // 
            this.systemDefaultsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.SystemDefaultsTableAdapter = this.systemDefaultsTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = PersonnelLogin.SystemDefaultsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // payeLabel
            // 
            this.payeLabel.AutoSize = true;
            this.payeLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.payeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemDefaultsBindingSource1, "MaxSalaryDays", true));
            this.payeLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.payeLabel.Location = new System.Drawing.Point(694, 99);
            this.payeLabel.Name = "payeLabel";
            this.payeLabel.Size = new System.Drawing.Size(74, 20);
            this.payeLabel.TabIndex = 110;
            this.payeLabel.Text = "payelabel";
            // 
            // dlabel
            // 
            this.dlabel.AutoSize = true;
            this.dlabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.dlabel.Location = new System.Drawing.Point(503, 9);
            this.dlabel.Name = "dlabel";
            this.dlabel.Size = new System.Drawing.Size(51, 20);
            this.dlabel.TabIndex = 111;
            this.dlabel.Text = "dlabel";
            // 
            // payrollTableTableAdapter1
            // 
            this.payrollTableTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.PayrollTableTableAdapter = this.payrollTableTableAdapter1;
            this.tableAdapterManager2.UpdateOrder = PersonnelLogin.LogInDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // deductionLabel1
            // 
            deductionLabel1.AutoSize = true;
            deductionLabel1.Location = new System.Drawing.Point(41, 141);
            deductionLabel1.Name = "deductionLabel1";
            deductionLabel1.Size = new System.Drawing.Size(95, 20);
            deductionLabel1.TabIndex = 111;
            deductionLabel1.Text = "DEDUCTION:";
            // 
            // deductionTextBox
            // 
            this.deductionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollTableBindingSource1, "Deduction", true));
            this.deductionTextBox.Location = new System.Drawing.Point(142, 138);
            this.deductionTextBox.Name = "deductionTextBox";
            this.deductionTextBox.ReadOnly = true;
            this.deductionTextBox.Size = new System.Drawing.Size(70, 27);
            this.deductionTextBox.TabIndex = 112;
            this.deductionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PayrollTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(791, 233);
            this.ControlBox = false;
            this.Controls.Add(deductionLabel1);
            this.Controls.Add(this.deductionTextBox);
            this.Controls.Add(this.dlabel);
            this.Controls.Add(this.payeLabel);
            this.Controls.Add(this.maxDaysLabel);
            this.Controls.Add(this.bankCodeTextBox);
            this.Controls.Add(accountNumberLabel);
            this.Controls.Add(this.accountNumberTextBox);
            this.Controls.Add(bankCodeLabel);
            this.Controls.Add(netSalaryLabel);
            this.Controls.Add(this.netSalaryTextBox);
            this.Controls.Add(grossSalaryLabel);
            this.Controls.Add(this.grossSalaryTextBox);
            this.Controls.Add(absentDaysLabel);
            this.Controls.Add(this.absentDaysTextBox);
            this.Controls.Add(daysWorkedLabel);
            this.Controls.Add(this.daysWorkedTextBox);
            this.Controls.Add(salaryPeriodLabel);
            this.Controls.Add(this.salaryPeriodTextBox);
            this.Controls.Add(staffIDLabel);
            this.Controls.Add(this.staffIDTextBox);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.bottombutton);
            this.Controls.Add(this.previousbutton);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.topbutton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PayrollTable";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Maintenance";
            this.Load += new System.EventHandler(this.PayrollTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button bottombutton;
        private System.Windows.Forms.Button previousbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button topbutton;
        private System.Windows.Forms.TextBox textBox4;
        private LogInDataSet6 logInDataSet6;
        private System.Windows.Forms.BindingSource systemDefaultsBindingSource;
        private LogInDataSet6TableAdapters.SystemDefaultsTableAdapter systemDefaultsTableAdapter;
        private LogInDataSet6TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox staffIDTextBox;
        private System.Windows.Forms.TextBox salaryPeriodTextBox;
        private System.Windows.Forms.TextBox daysWorkedTextBox;
        private System.Windows.Forms.TextBox absentDaysTextBox;
        private System.Windows.Forms.TextBox grossSalaryTextBox;
        private System.Windows.Forms.TextBox netSalaryTextBox;
        private System.Windows.Forms.TextBox accountNumberTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox bankCodeTextBox;
        private LogInDataSet2 logInDataSet2;
        private System.Windows.Forms.BindingSource payrollTableBindingSource1;
        private LogInDataSet2TableAdapters.PayrollTableTableAdapter payrollTableTableAdapter1;
        private LogInDataSet2TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.Label maxDaysLabel;
        private SystemDefaultsDataSet systemDefaultsDataSet;
        private System.Windows.Forms.BindingSource systemDefaultsBindingSource1;
        private SystemDefaultsDataSetTableAdapters.SystemDefaultsTableAdapter systemDefaultsTableAdapter1;
        private SystemDefaultsDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label payeLabel;
        private System.Windows.Forms.Label dlabel;
        private System.Windows.Forms.TextBox deductionTextBox;
    }
}