namespace PersonnelLogin
{
    partial class TransactionType
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
            System.Windows.Forms.Label transactionIDLabel;
            System.Windows.Forms.Label transactionDescLabel;
            System.Windows.Forms.Label deductionLabel;
            System.Windows.Forms.Label statutoryLabel;
            System.Windows.Forms.Label employeeRateLabel;
            System.Windows.Forms.Label employerRateLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label calculatedLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionType));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exitbutton = new System.Windows.Forms.Button();
            this.printbutton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.bottombutton = new System.Windows.Forms.Button();
            this.previousbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.topbutton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.transactionIDTextBox = new System.Windows.Forms.TextBox();
            this.transactionTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transactionTypeDataSet = new PersonnelLogin.TransactionTypeDataSet();
            this.transactionDescTextBox = new System.Windows.Forms.TextBox();
            this.deductionComboBox = new System.Windows.Forms.ComboBox();
            this.statutoryComboBox = new System.Windows.Forms.ComboBox();
            this.employeeRateTextBox = new System.Windows.Forms.TextBox();
            this.employerRateTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.calculatedComboBox = new System.Windows.Forms.ComboBox();
            this.logInDataSet6 = new PersonnelLogin.LogInDataSet6();
            this.systemDefaultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemDefaultsTableAdapter = new PersonnelLogin.LogInDataSet6TableAdapters.SystemDefaultsTableAdapter();
            this.tableAdapterManager1 = new PersonnelLogin.LogInDataSet6TableAdapters.TableAdapterManager();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.transactionTypeTableAdapter1 = new PersonnelLogin.TransactionTypeDataSetTableAdapters.TransactionTypeTableAdapter();
            this.tableAdapterManager2 = new PersonnelLogin.TransactionTypeDataSetTableAdapters.TableAdapterManager();
            this.systemDefaultsDataSet = new PersonnelLogin.SystemDefaultsDataSet();
            this.systemDefaultsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.systemDefaultsTableAdapter1 = new PersonnelLogin.SystemDefaultsDataSetTableAdapters.SystemDefaultsTableAdapter();
            this.tableAdapterManager = new PersonnelLogin.SystemDefaultsDataSetTableAdapters.TableAdapterManager();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            transactionIDLabel = new System.Windows.Forms.Label();
            transactionDescLabel = new System.Windows.Forms.Label();
            deductionLabel = new System.Windows.Forms.Label();
            statutoryLabel = new System.Windows.Forms.Label();
            employeeRateLabel = new System.Windows.Forms.Label();
            employerRateLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            calculatedLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionIDLabel
            // 
            transactionIDLabel.AutoSize = true;
            transactionIDLabel.Location = new System.Drawing.Point(148, 56);
            transactionIDLabel.Name = "transactionIDLabel";
            transactionIDLabel.Size = new System.Drawing.Size(31, 20);
            transactionIDLabel.TabIndex = 121;
            transactionIDLabel.Text = " ID:";
            // 
            // transactionDescLabel
            // 
            transactionDescLabel.AutoSize = true;
            transactionDescLabel.Location = new System.Drawing.Point(345, 56);
            transactionDescLabel.Name = "transactionDescLabel";
            transactionDescLabel.Size = new System.Drawing.Size(107, 20);
            transactionDescLabel.TabIndex = 122;
            transactionDescLabel.Text = "DESCRIPTION :";
            // 
            // deductionLabel
            // 
            deductionLabel.AutoSize = true;
            deductionLabel.Location = new System.Drawing.Point(80, 133);
            deductionLabel.Name = "deductionLabel";
            deductionLabel.Size = new System.Drawing.Size(99, 20);
            deductionLabel.TabIndex = 123;
            deductionLabel.Text = "DEDUCTION :";
            // 
            // statutoryLabel
            // 
            statutoryLabel.AutoSize = true;
            statutoryLabel.Location = new System.Drawing.Point(356, 135);
            statutoryLabel.Name = "statutoryLabel";
            statutoryLabel.Size = new System.Drawing.Size(96, 20);
            statutoryLabel.TabIndex = 124;
            statutoryLabel.Text = "STATUTORY :";
            // 
            // employeeRateLabel
            // 
            employeeRateLabel.AutoSize = true;
            employeeRateLabel.Location = new System.Drawing.Point(326, 96);
            employeeRateLabel.Name = "employeeRateLabel";
            employeeRateLabel.Size = new System.Drawing.Size(126, 20);
            employeeRateLabel.TabIndex = 125;
            employeeRateLabel.Text = "EMPLOYEE RATE :";
            // 
            // employerRateLabel
            // 
            employerRateLabel.AutoSize = true;
            employerRateLabel.Location = new System.Drawing.Point(56, 94);
            employerRateLabel.Name = "employerRateLabel";
            employerRateLabel.Size = new System.Drawing.Size(123, 20);
            employerRateLabel.TabIndex = 126;
            employerRateLabel.Text = "EMPLOYER RATE:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(373, 172);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(79, 20);
            amountLabel.TabIndex = 128;
            amountLabel.Text = "AMOUNT :";
            // 
            // calculatedLabel1
            // 
            calculatedLabel1.AutoSize = true;
            calculatedLabel1.Location = new System.Drawing.Point(74, 172);
            calculatedLabel1.Name = "calculatedLabel1";
            calculatedLabel1.Size = new System.Drawing.Size(105, 20);
            calculatedLabel1.TabIndex = 129;
            calculatedLabel1.Text = "CALCULATED :";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(14, 40);
            this.textBox3.MaxLength = 327670000;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(650, 1);
            this.textBox3.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 86;
            this.label1.Text = "TRANSACTION TYPE";
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.Red;
            this.exitbutton.Location = new System.Drawing.Point(602, 218);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(56, 32);
            this.exitbutton.TabIndex = 119;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(458, 218);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(61, 32);
            this.printbutton.TabIndex = 117;
            this.printbutton.Text = "PRINT";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            this.printbutton.MouseEnter += new System.EventHandler(this.printbutton_MouseEnter);
            // 
            // cancelbutton
            // 
            this.cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(391, 218);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(61, 32);
            this.cancelbutton.TabIndex = 115;
            this.cancelbutton.Text = "UNDO";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Visible = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(323, 218);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(63, 32);
            this.savebutton.TabIndex = 113;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Visible = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            this.savebutton.MouseEnter += new System.EventHandler(this.savebutton_MouseEnter);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(525, 218);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(71, 32);
            this.deletebutton.TabIndex = 118;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // bottombutton
            // 
            this.bottombutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottombutton.Location = new System.Drawing.Point(237, 218);
            this.bottombutton.Name = "bottombutton";
            this.bottombutton.Size = new System.Drawing.Size(80, 32);
            this.bottombutton.TabIndex = 112;
            this.bottombutton.Text = "BOTTOM";
            this.bottombutton.UseVisualStyleBackColor = true;
            this.bottombutton.Click += new System.EventHandler(this.bottombutton_Click);
            // 
            // previousbutton
            // 
            this.previousbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousbutton.Location = new System.Drawing.Point(81, 218);
            this.previousbutton.Name = "previousbutton";
            this.previousbutton.Size = new System.Drawing.Size(84, 32);
            this.previousbutton.TabIndex = 110;
            this.previousbutton.Text = "PREVIOUS";
            this.previousbutton.UseVisualStyleBackColor = true;
            this.previousbutton.Click += new System.EventHandler(this.previousbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.Location = new System.Drawing.Point(171, 218);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(60, 32);
            this.nextbutton.TabIndex = 111;
            this.nextbutton.Text = "NEXT";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // topbutton
            // 
            this.topbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbutton.Location = new System.Drawing.Point(24, 218);
            this.topbutton.Name = "topbutton";
            this.topbutton.Size = new System.Drawing.Size(51, 32);
            this.topbutton.TabIndex = 109;
            this.topbutton.Text = "TOP";
            this.topbutton.UseVisualStyleBackColor = true;
            this.topbutton.Click += new System.EventHandler(this.topbutton_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(14, 211);
            this.textBox4.MaxLength = 327670000;
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(650, 1);
            this.textBox4.TabIndex = 120;
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(323, 218);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(63, 32);
            this.addbutton.TabIndex = 114;
            this.addbutton.Text = "ADD";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.Location = new System.Drawing.Point(392, 218);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(60, 32);
            this.editbutton.TabIndex = 116;
            this.editbutton.Text = "EDIT";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // transactionIDTextBox
            // 
            this.transactionIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionTypeBindingSource1, "TransactionID", true));
            this.transactionIDTextBox.Location = new System.Drawing.Point(185, 53);
            this.transactionIDTextBox.MaxLength = 3;
            this.transactionIDTextBox.Name = "transactionIDTextBox";
            this.transactionIDTextBox.ReadOnly = true;
            this.transactionIDTextBox.Size = new System.Drawing.Size(40, 27);
            this.transactionIDTextBox.TabIndex = 122;
            // 
            // transactionTypeBindingSource1
            // 
            this.transactionTypeBindingSource1.DataMember = "TransactionType";
            this.transactionTypeBindingSource1.DataSource = this.transactionTypeDataSet;
            // 
            // transactionTypeDataSet
            // 
            this.transactionTypeDataSet.DataSetName = "TransactionTypeDataSet";
            this.transactionTypeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionDescTextBox
            // 
            this.transactionDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionTypeBindingSource1, "TransactionDesc", true));
            this.transactionDescTextBox.Location = new System.Drawing.Point(458, 53);
            this.transactionDescTextBox.MaxLength = 50;
            this.transactionDescTextBox.Name = "transactionDescTextBox";
            this.transactionDescTextBox.ReadOnly = true;
            this.transactionDescTextBox.Size = new System.Drawing.Size(157, 27);
            this.transactionDescTextBox.TabIndex = 123;
            this.transactionDescTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transactionDescTextBox_KeyPress);
            // 
            // deductionComboBox
            // 
            this.deductionComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionTypeBindingSource1, "Deduction", true));
            this.deductionComboBox.Enabled = false;
            this.deductionComboBox.FormattingEnabled = true;
            this.deductionComboBox.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.deductionComboBox.Location = new System.Drawing.Point(185, 129);
            this.deductionComboBox.Name = "deductionComboBox";
            this.deductionComboBox.Size = new System.Drawing.Size(86, 28);
            this.deductionComboBox.TabIndex = 124;
            this.deductionComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.deductionComboBox_KeyPress);
            // 
            // statutoryComboBox
            // 
            this.statutoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionTypeBindingSource1, "Statutory", true));
            this.statutoryComboBox.Enabled = false;
            this.statutoryComboBox.FormattingEnabled = true;
            this.statutoryComboBox.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.statutoryComboBox.Location = new System.Drawing.Point(458, 129);
            this.statutoryComboBox.Name = "statutoryComboBox";
            this.statutoryComboBox.Size = new System.Drawing.Size(86, 28);
            this.statutoryComboBox.TabIndex = 125;
            this.statutoryComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.statutoryComboBox_KeyPress);
            // 
            // employeeRateTextBox
            // 
            this.employeeRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionTypeBindingSource1, "EmployeeRate", true));
            this.employeeRateTextBox.Location = new System.Drawing.Point(458, 91);
            this.employeeRateTextBox.MaxLength = 10;
            this.employeeRateTextBox.Name = "employeeRateTextBox";
            this.employeeRateTextBox.ReadOnly = true;
            this.employeeRateTextBox.Size = new System.Drawing.Size(100, 27);
            this.employeeRateTextBox.TabIndex = 126;
            this.employeeRateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employeeRateTextBox_KeyPress);
            // 
            // employerRateTextBox
            // 
            this.employerRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionTypeBindingSource1, "EmployerRate", true));
            this.employerRateTextBox.Location = new System.Drawing.Point(185, 91);
            this.employerRateTextBox.MaxLength = 10;
            this.employerRateTextBox.Name = "employerRateTextBox";
            this.employerRateTextBox.ReadOnly = true;
            this.employerRateTextBox.Size = new System.Drawing.Size(100, 27);
            this.employerRateTextBox.TabIndex = 127;
            this.employerRateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.employerRateTextBox_KeyPress);
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionTypeBindingSource1, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(458, 169);
            this.amountTextBox.MaxLength = 10;
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.ReadOnly = true;
            this.amountTextBox.Size = new System.Drawing.Size(100, 27);
            this.amountTextBox.TabIndex = 129;
            this.amountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountTextBox_KeyPress);
            // 
            // calculatedComboBox
            // 
            this.calculatedComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.transactionTypeBindingSource1, "Calculated", true));
            this.calculatedComboBox.Enabled = false;
            this.calculatedComboBox.FormattingEnabled = true;
            this.calculatedComboBox.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.calculatedComboBox.Location = new System.Drawing.Point(185, 168);
            this.calculatedComboBox.Name = "calculatedComboBox";
            this.calculatedComboBox.Size = new System.Drawing.Size(86, 28);
            this.calculatedComboBox.TabIndex = 130;
            this.calculatedComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.calculatedComboBox_KeyPress);
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
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.SystemDefaultsTableAdapter = this.systemDefaultsTableAdapter;
            this.tableAdapterManager1.UpdateOrder = PersonnelLogin.LogInDataSet6TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // transactionTypeTableAdapter1
            // 
            this.transactionTypeTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.TransactionTypeTableAdapter = this.transactionTypeTableAdapter1;
            this.tableAdapterManager2.UpdateOrder = PersonnelLogin.TransactionTypeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // systemDefaultsDataSet
            // 
            this.systemDefaultsDataSet.DataSetName = "SystemDefaultsDataSet";
            this.systemDefaultsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // systemDefaultsBindingSource1
            // 
            this.systemDefaultsBindingSource1.DataMember = "SystemDefaults";
            this.systemDefaultsBindingSource1.DataSource = this.systemDefaultsDataSet;
            // 
            // systemDefaultsTableAdapter1
            // 
            this.systemDefaultsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.SystemDefaultsTableAdapter = this.systemDefaultsTableAdapter1;
            this.tableAdapterManager.UpdateOrder = PersonnelLogin.SystemDefaultsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.companyNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemDefaultsBindingSource1, "CompanyName", true));
            this.companyNameTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.companyNameTextBox.Location = new System.Drawing.Point(654, 9);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(10, 20);
            this.companyNameTextBox.TabIndex = 133;
            // 
            // TransactionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(675, 258);
            this.ControlBox = false;
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(calculatedLabel1);
            this.Controls.Add(this.calculatedComboBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(employerRateLabel);
            this.Controls.Add(this.employerRateTextBox);
            this.Controls.Add(employeeRateLabel);
            this.Controls.Add(this.employeeRateTextBox);
            this.Controls.Add(statutoryLabel);
            this.Controls.Add(this.statutoryComboBox);
            this.Controls.Add(deductionLabel);
            this.Controls.Add(this.deductionComboBox);
            this.Controls.Add(transactionDescLabel);
            this.Controls.Add(this.transactionDescTextBox);
            this.Controls.Add(transactionIDLabel);
            this.Controls.Add(this.transactionIDTextBox);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.printbutton);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.bottombutton);
            this.Controls.Add(this.previousbutton);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.topbutton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TransactionType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Maintenance";
            this.Load += new System.EventHandler(this.TransactionType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionTypeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button bottombutton;
        private System.Windows.Forms.Button previousbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button topbutton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.TextBox transactionIDTextBox;
        private System.Windows.Forms.TextBox transactionDescTextBox;
        private System.Windows.Forms.ComboBox deductionComboBox;
        private System.Windows.Forms.ComboBox statutoryComboBox;
        private System.Windows.Forms.TextBox employeeRateTextBox;
        private System.Windows.Forms.TextBox employerRateTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox calculatedComboBox;
        private LogInDataSet6 logInDataSet6;
        private System.Windows.Forms.BindingSource systemDefaultsBindingSource;
        private LogInDataSet6TableAdapters.SystemDefaultsTableAdapter systemDefaultsTableAdapter;
        private LogInDataSet6TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private TransactionTypeDataSet transactionTypeDataSet;
        private System.Windows.Forms.BindingSource transactionTypeBindingSource1;
        private TransactionTypeDataSetTableAdapters.TransactionTypeTableAdapter transactionTypeTableAdapter1;
        private TransactionTypeDataSetTableAdapters.TableAdapterManager tableAdapterManager2;
        private SystemDefaultsDataSet systemDefaultsDataSet;
        private System.Windows.Forms.BindingSource systemDefaultsBindingSource1;
        private SystemDefaultsDataSetTableAdapters.SystemDefaultsTableAdapter systemDefaultsTableAdapter1;
        private SystemDefaultsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox companyNameTextBox;
    }
}