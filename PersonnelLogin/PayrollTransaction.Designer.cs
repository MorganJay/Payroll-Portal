namespace PersonnelLogin
{
    partial class PayrollTransaction
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
            System.Windows.Forms.Label transactionIDLabel;
            System.Windows.Forms.Label transactionDateTimeLabel;
            System.Windows.Forms.Label deductionLabel;
            System.Windows.Forms.Label principalLabel;
            System.Windows.Forms.Label statutoryLabel;
            System.Windows.Forms.Label balanceLabel;
            System.Windows.Forms.Label rateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollTransaction));
            this.printbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.bottombutton = new System.Windows.Forms.Button();
            this.previousbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.topbutton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.staffIDTextBox = new System.Windows.Forms.TextBox();
            this.payrollTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pTDataSet = new PersonnelLogin.PTDataSet();
            this.transactionDateTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.principalTextBox = new System.Windows.Forms.TextBox();
            this.statutoryComboBox = new System.Windows.Forms.ComboBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.rateTextBox = new System.Windows.Forms.TextBox();
            this.deductioncomboBox = new System.Windows.Forms.ComboBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.systemDefaultsDataSet = new PersonnelLogin.SystemDefaultsDataSet();
            this.systemDefaultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemDefaultsTableAdapter = new PersonnelLogin.SystemDefaultsDataSetTableAdapters.SystemDefaultsTableAdapter();
            this.tableAdapterManager1 = new PersonnelLogin.SystemDefaultsDataSetTableAdapters.TableAdapterManager();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.payrollTransactionTableAdapter = new PersonnelLogin.PTDataSetTableAdapters.PayrollTransactionTableAdapter();
            this.tableAdapterManager = new PersonnelLogin.PTDataSetTableAdapters.TableAdapterManager();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            staffIDLabel = new System.Windows.Forms.Label();
            transactionIDLabel = new System.Windows.Forms.Label();
            transactionDateTimeLabel = new System.Windows.Forms.Label();
            deductionLabel = new System.Windows.Forms.Label();
            principalLabel = new System.Windows.Forms.Label();
            statutoryLabel = new System.Windows.Forms.Label();
            balanceLabel = new System.Windows.Forms.Label();
            rateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.payrollTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // staffIDLabel
            // 
            staffIDLabel.AutoSize = true;
            staffIDLabel.Location = new System.Drawing.Point(118, 51);
            staffIDLabel.Name = "staffIDLabel";
            staffIDLabel.Size = new System.Drawing.Size(106, 20);
            staffIDLabel.TabIndex = 94;
            staffIDLabel.Text = "EMPLOYEE ID :";
            // 
            // transactionIDLabel
            // 
            transactionIDLabel.AutoSize = true;
            transactionIDLabel.Location = new System.Drawing.Point(90, 92);
            transactionIDLabel.Name = "transactionIDLabel";
            transactionIDLabel.Size = new System.Drawing.Size(134, 20);
            transactionIDLabel.TabIndex = 95;
            transactionIDLabel.Text = "TRANSACTION ID :";
            // 
            // transactionDateTimeLabel
            // 
            transactionDateTimeLabel.AutoSize = true;
            transactionDateTimeLabel.Location = new System.Drawing.Point(35, 135);
            transactionDateTimeLabel.Name = "transactionDateTimeLabel";
            transactionDateTimeLabel.Size = new System.Drawing.Size(189, 20);
            transactionDateTimeLabel.TabIndex = 96;
            transactionDateTimeLabel.Text = "TRANSACTION DATETIME :";
            // 
            // deductionLabel
            // 
            deductionLabel.AutoSize = true;
            deductionLabel.Location = new System.Drawing.Point(125, 176);
            deductionLabel.Name = "deductionLabel";
            deductionLabel.Size = new System.Drawing.Size(99, 20);
            deductionLabel.TabIndex = 97;
            deductionLabel.Text = "DEDUCTION :";
            // 
            // principalLabel
            // 
            principalLabel.AutoSize = true;
            principalLabel.Location = new System.Drawing.Point(397, 89);
            principalLabel.Name = "principalLabel";
            principalLabel.Size = new System.Drawing.Size(86, 20);
            principalLabel.TabIndex = 98;
            principalLabel.Text = "PRINCIPAL :";
            principalLabel.Click += new System.EventHandler(this.principalLabel_Click);
            // 
            // statutoryLabel
            // 
            statutoryLabel.AutoSize = true;
            statutoryLabel.Location = new System.Drawing.Point(387, 51);
            statutoryLabel.Name = "statutoryLabel";
            statutoryLabel.Size = new System.Drawing.Size(96, 20);
            statutoryLabel.TabIndex = 99;
            statutoryLabel.Text = "STATUTORY :";
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Location = new System.Drawing.Point(403, 175);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new System.Drawing.Size(80, 20);
            balanceLabel.TabIndex = 100;
            balanceLabel.Text = "BALANCE :";
            balanceLabel.Click += new System.EventHandler(this.balanceLabel_Click);
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Location = new System.Drawing.Point(432, 132);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new System.Drawing.Size(51, 20);
            rateLabel.TabIndex = 101;
            rateLabel.Text = "RATE :";
            rateLabel.Click += new System.EventHandler(this.rateLabel_Click);
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(457, 219);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(61, 32);
            this.printbutton.TabIndex = 15;
            this.printbutton.Text = "PRINT";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            this.printbutton.MouseEnter += new System.EventHandler(this.printbutton_MouseEnter);
            // 
            // cancelbutton
            // 
            this.cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(390, 219);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(61, 32);
            this.cancelbutton.TabIndex = 90;
            this.cancelbutton.Text = "UNDO";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Visible = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(322, 219);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(63, 32);
            this.savebutton.TabIndex = 89;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Visible = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            this.savebutton.MouseEnter += new System.EventHandler(this.savebutton_MouseEnter);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.Red;
            this.exitbutton.Location = new System.Drawing.Point(601, 219);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(56, 32);
            this.exitbutton.TabIndex = 17;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(524, 219);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(71, 32);
            this.deletebutton.TabIndex = 16;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // bottombutton
            // 
            this.bottombutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottombutton.Location = new System.Drawing.Point(236, 219);
            this.bottombutton.Name = "bottombutton";
            this.bottombutton.Size = new System.Drawing.Size(80, 32);
            this.bottombutton.TabIndex = 12;
            this.bottombutton.Text = "BOTTOM";
            this.bottombutton.UseVisualStyleBackColor = true;
            this.bottombutton.Click += new System.EventHandler(this.bottombutton_Click);
            // 
            // previousbutton
            // 
            this.previousbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousbutton.Location = new System.Drawing.Point(80, 219);
            this.previousbutton.Name = "previousbutton";
            this.previousbutton.Size = new System.Drawing.Size(84, 32);
            this.previousbutton.TabIndex = 10;
            this.previousbutton.Text = "PREVIOUS";
            this.previousbutton.UseVisualStyleBackColor = true;
            this.previousbutton.Click += new System.EventHandler(this.previousbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.Location = new System.Drawing.Point(170, 219);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(60, 32);
            this.nextbutton.TabIndex = 11;
            this.nextbutton.Text = "NEXT";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // topbutton
            // 
            this.topbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbutton.Location = new System.Drawing.Point(23, 219);
            this.topbutton.Name = "topbutton";
            this.topbutton.Size = new System.Drawing.Size(51, 32);
            this.topbutton.TabIndex = 9;
            this.topbutton.Text = "TOP";
            this.topbutton.UseVisualStyleBackColor = true;
            this.topbutton.Click += new System.EventHandler(this.topbutton_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(15, 212);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(650, 1);
            this.textBox4.TabIndex = 84;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(7, 36);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(650, 1);
            this.textBox3.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "PAYROLL TRANSACTION ";
            // 
            // staffIDTextBox
            // 
            this.staffIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollTransactionBindingSource, "StaffID", true));
            this.staffIDTextBox.Location = new System.Drawing.Point(230, 48);
            this.staffIDTextBox.MaxLength = 4;
            this.staffIDTextBox.Name = "staffIDTextBox";
            this.staffIDTextBox.ReadOnly = true;
            this.staffIDTextBox.Size = new System.Drawing.Size(42, 27);
            this.staffIDTextBox.TabIndex = 1;
            this.staffIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.staffIDTextBox_KeyPress);
            // 
            // payrollTransactionBindingSource
            // 
            this.payrollTransactionBindingSource.DataMember = "PayrollTransaction";
            this.payrollTransactionBindingSource.DataSource = this.pTDataSet;
            // 
            // pTDataSet
            // 
            this.pTDataSet.DataSetName = "PTDataSet";
            this.pTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionDateTimeDateTimePicker
            // 
            this.transactionDateTimeDateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.transactionDateTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.payrollTransactionBindingSource, "TransactionDateTime", true));
            this.transactionDateTimeDateTimePicker.Enabled = false;
            this.transactionDateTimeDateTimePicker.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionDateTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.transactionDateTimeDateTimePicker.Location = new System.Drawing.Point(230, 130);
            this.transactionDateTimeDateTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.transactionDateTimeDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.transactionDateTimeDateTimePicker.Name = "transactionDateTimeDateTimePicker";
            this.transactionDateTimeDateTimePicker.Size = new System.Drawing.Size(113, 27);
            this.transactionDateTimeDateTimePicker.TabIndex = 3;
            this.transactionDateTimeDateTimePicker.Value = new System.DateTime(2017, 1, 2, 0, 0, 0, 0);
            this.transactionDateTimeDateTimePicker.ValueChanged += new System.EventHandler(this.transactionDateTimeDateTimePicker_ValueChanged);
            // 
            // principalTextBox
            // 
            this.principalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollTransactionBindingSource, "Principal", true));
            this.principalTextBox.Location = new System.Drawing.Point(489, 89);
            this.principalTextBox.Name = "principalTextBox";
            this.principalTextBox.ReadOnly = true;
            this.principalTextBox.Size = new System.Drawing.Size(88, 27);
            this.principalTextBox.TabIndex = 6;
            this.principalTextBox.TextChanged += new System.EventHandler(this.principalTextBox_TextChanged);
            this.principalTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.principalTextBox_KeyPress);
            // 
            // statutoryComboBox
            // 
            this.statutoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollTransactionBindingSource, "Statutory", true));
            this.statutoryComboBox.Enabled = false;
            this.statutoryComboBox.FormattingEnabled = true;
            this.statutoryComboBox.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.statutoryComboBox.Location = new System.Drawing.Point(489, 48);
            this.statutoryComboBox.Name = "statutoryComboBox";
            this.statutoryComboBox.Size = new System.Drawing.Size(82, 28);
            this.statutoryComboBox.TabIndex = 5;
            this.statutoryComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.statutoryComboBox_KeyPress);
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollTransactionBindingSource, "Balance", true));
            this.balanceTextBox.Location = new System.Drawing.Point(489, 173);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.ReadOnly = true;
            this.balanceTextBox.Size = new System.Drawing.Size(88, 27);
            this.balanceTextBox.TabIndex = 8;
            this.balanceTextBox.TextChanged += new System.EventHandler(this.balanceTextBox_TextChanged);
            this.balanceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.balanceTextBox_KeyPress);
            // 
            // rateTextBox
            // 
            this.rateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollTransactionBindingSource, "Rate", true));
            this.rateTextBox.Location = new System.Drawing.Point(489, 130);
            this.rateTextBox.Name = "rateTextBox";
            this.rateTextBox.ReadOnly = true;
            this.rateTextBox.Size = new System.Drawing.Size(88, 27);
            this.rateTextBox.TabIndex = 7;
            this.rateTextBox.TextChanged += new System.EventHandler(this.rateTextBox_TextChanged);
            this.rateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rateTextBox_KeyPress);
            // 
            // deductioncomboBox
            // 
            this.deductioncomboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.payrollTransactionBindingSource, "Deduction", true));
            this.deductioncomboBox.Enabled = false;
            this.deductioncomboBox.FormattingEnabled = true;
            this.deductioncomboBox.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.deductioncomboBox.Location = new System.Drawing.Point(230, 173);
            this.deductioncomboBox.Name = "deductioncomboBox";
            this.deductioncomboBox.Size = new System.Drawing.Size(82, 28);
            this.deductioncomboBox.TabIndex = 4;
            this.deductioncomboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deductioncomboBox_KeyPress);
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(322, 219);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(63, 32);
            this.addbutton.TabIndex = 18;
            this.addbutton.Text = "ADD";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.Location = new System.Drawing.Point(391, 219);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(60, 32);
            this.editbutton.TabIndex = 14;
            this.editbutton.Text = "EDIT";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // systemDefaultsDataSet
            // 
            this.systemDefaultsDataSet.DataSetName = "SystemDefaultsDataSet";
            this.systemDefaultsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // systemDefaultsBindingSource
            // 
            this.systemDefaultsBindingSource.DataMember = "SystemDefaults";
            this.systemDefaultsBindingSource.DataSource = this.systemDefaultsDataSet;
            // 
            // systemDefaultsTableAdapter
            // 
            this.systemDefaultsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.SystemDefaultsTableAdapter = this.systemDefaultsTableAdapter;
            this.tableAdapterManager1.UpdateOrder = PersonnelLogin.SystemDefaultsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.companyNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemDefaultsBindingSource, "CompanyName", true));
            this.companyNameTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.companyNameTextBox.Location = new System.Drawing.Point(606, 10);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(1, 20);
            this.companyNameTextBox.TabIndex = 129;
            this.companyNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // payrollTransactionTableAdapter
            // 
            this.payrollTransactionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PayrollTransactionTableAdapter = this.payrollTransactionTableAdapter;
            this.tableAdapterManager.UpdateOrder = PersonnelLogin.PTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(230, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 28);
            this.comboBox1.TabIndex = 130;
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // PayrollTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(679, 256);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.deductioncomboBox);
            this.Controls.Add(rateLabel);
            this.Controls.Add(this.rateTextBox);
            this.Controls.Add(balanceLabel);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(statutoryLabel);
            this.Controls.Add(this.statutoryComboBox);
            this.Controls.Add(principalLabel);
            this.Controls.Add(this.principalTextBox);
            this.Controls.Add(deductionLabel);
            this.Controls.Add(transactionDateTimeLabel);
            this.Controls.Add(this.transactionDateTimeDateTimePicker);
            this.Controls.Add(transactionIDLabel);
            this.Controls.Add(staffIDLabel);
            this.Controls.Add(this.staffIDTextBox);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.bottombutton);
            this.Controls.Add(this.previousbutton);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.topbutton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.editbutton);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PayrollTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Maintenance";
            this.Load += new System.EventHandler(this.PayrollTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payrollTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button bottombutton;
        private System.Windows.Forms.Button previousbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button topbutton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox staffIDTextBox;
        private System.Windows.Forms.DateTimePicker transactionDateTimeDateTimePicker;
        private System.Windows.Forms.TextBox principalTextBox;
        private System.Windows.Forms.ComboBox statutoryComboBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.TextBox rateTextBox;
        private System.Windows.Forms.ComboBox deductioncomboBox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button editbutton;
        private SystemDefaultsDataSet systemDefaultsDataSet;
        private System.Windows.Forms.BindingSource systemDefaultsBindingSource;
        private SystemDefaultsDataSetTableAdapters.SystemDefaultsTableAdapter systemDefaultsTableAdapter;
        private SystemDefaultsDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private PTDataSet pTDataSet;
        private System.Windows.Forms.BindingSource payrollTransactionBindingSource;
        private PTDataSetTableAdapters.PayrollTransactionTableAdapter payrollTransactionTableAdapter;
        private PTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}