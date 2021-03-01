namespace PersonnelLogin
{
    partial class StatutoryDeduction
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
            System.Windows.Forms.Label statutoryTypeIDLabel;
            System.Windows.Forms.Label staffIDLabel;
            System.Windows.Forms.Label amount1Label;
            System.Windows.Forms.Label amount2Label;
            System.Windows.Forms.Label pFAIdLabel;
            System.Windows.Forms.Label pFAAccountNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatutoryDeduction));
            System.Windows.Forms.Label descriptionLabel;
            this.statutoryTypeIDTextBox = new System.Windows.Forms.TextBox();
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
            this.amount1TextBox = new System.Windows.Forms.TextBox();
            this.amount2TextBox = new System.Windows.Forms.TextBox();
            this.pFAIdTextBox = new System.Windows.Forms.TextBox();
            this.pFAAccountNumberTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.editbutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.logInDataSet6 = new PersonnelLogin.LogInDataSet6();
            this.systemDefaultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemDefaultsTableAdapter = new PersonnelLogin.LogInDataSet6TableAdapters.SystemDefaultsTableAdapter();
            this.tableAdapterManager1 = new PersonnelLogin.LogInDataSet6TableAdapters.TableAdapterManager();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.statutoryDeductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statutoryDataSet5 = new PersonnelLogin.StatutoryDataSet5();
            this.statutoryDeductionTableAdapter = new PersonnelLogin.StatutoryDataSet5TableAdapters.StatutoryDeductionTableAdapter();
            this.tableAdapterManager = new PersonnelLogin.StatutoryDataSet5TableAdapters.TableAdapterManager();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            statutoryTypeIDLabel = new System.Windows.Forms.Label();
            staffIDLabel = new System.Windows.Forms.Label();
            amount1Label = new System.Windows.Forms.Label();
            amount2Label = new System.Windows.Forms.Label();
            pFAIdLabel = new System.Windows.Forms.Label();
            pFAAccountNumberLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statutoryDeductionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statutoryDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // statutoryTypeIDLabel
            // 
            statutoryTypeIDLabel.AutoSize = true;
            statutoryTypeIDLabel.Location = new System.Drawing.Point(49, 58);
            statutoryTypeIDLabel.Name = "statutoryTypeIDLabel";
            statutoryTypeIDLabel.Size = new System.Drawing.Size(147, 20);
            statutoryTypeIDLabel.TabIndex = 1;
            statutoryTypeIDLabel.Text = "STATUTORY TYPE ID:";
            // 
            // staffIDLabel
            // 
            staffIDLabel.AutoSize = true;
            staffIDLabel.Location = new System.Drawing.Point(290, 58);
            staffIDLabel.Name = "staffIDLabel";
            staffIDLabel.Size = new System.Drawing.Size(102, 20);
            staffIDLabel.TabIndex = 93;
            staffIDLabel.Text = "EMPLOYEE ID:";
            // 
            // amount1Label
            // 
            amount1Label.AutoSize = true;
            amount1Label.Location = new System.Drawing.Point(290, 117);
            amount1Label.Name = "amount1Label";
            amount1Label.Size = new System.Drawing.Size(87, 20);
            amount1Label.TabIndex = 94;
            amount1Label.Text = "AMOUNT 1:";
            // 
            // amount2Label
            // 
            amount2Label.AutoSize = true;
            amount2Label.Location = new System.Drawing.Point(199, 187);
            amount2Label.Name = "amount2Label";
            amount2Label.Size = new System.Drawing.Size(87, 20);
            amount2Label.TabIndex = 95;
            amount2Label.Text = "AMOUNT 2:";
            // 
            // pFAIdLabel
            // 
            pFAIdLabel.AutoSize = true;
            pFAIdLabel.Location = new System.Drawing.Point(507, 58);
            pFAIdLabel.Name = "pFAIdLabel";
            pFAIdLabel.Size = new System.Drawing.Size(56, 20);
            pFAIdLabel.TabIndex = 96;
            pFAIdLabel.Text = "PFA ID:";
            // 
            // pFAAccountNumberLabel
            // 
            pFAAccountNumberLabel.AutoSize = true;
            pFAAccountNumberLabel.Location = new System.Drawing.Point(467, 117);
            pFAAccountNumberLabel.Name = "pFAAccountNumberLabel";
            pFAAccountNumberLabel.Size = new System.Drawing.Size(173, 20);
            pFAAccountNumberLabel.TabIndex = 97;
            pFAAccountNumberLabel.Text = "PFA ACCOUNT NUMBER:";
            // 
            // statutoryTypeIDTextBox
            // 
            this.statutoryTypeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statutoryDeductionBindingSource, "StatutoryTypeID", true));
            this.statutoryTypeIDTextBox.Location = new System.Drawing.Point(100, 81);
            this.statutoryTypeIDTextBox.MaxLength = 3;
            this.statutoryTypeIDTextBox.Name = "statutoryTypeIDTextBox";
            this.statutoryTypeIDTextBox.ReadOnly = true;
            this.statutoryTypeIDTextBox.Size = new System.Drawing.Size(45, 27);
            this.statutoryTypeIDTextBox.TabIndex = 1;
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(460, 231);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(61, 32);
            this.printbutton.TabIndex = 13;
            this.printbutton.Text = "PRINT";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            this.printbutton.MouseEnter += new System.EventHandler(this.printbutton_MouseEnter);
            // 
            // cancelbutton
            // 
            this.cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(390, 231);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(61, 32);
            this.cancelbutton.TabIndex = 12;
            this.cancelbutton.Text = "UNDO";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Visible = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(322, 231);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(63, 32);
            this.savebutton.TabIndex = 11;
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
            this.exitbutton.Location = new System.Drawing.Point(606, 231);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(56, 32);
            this.exitbutton.TabIndex = 15;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(528, 231);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(71, 32);
            this.deletebutton.TabIndex = 14;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // bottombutton
            // 
            this.bottombutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottombutton.Location = new System.Drawing.Point(236, 231);
            this.bottombutton.Name = "bottombutton";
            this.bottombutton.Size = new System.Drawing.Size(80, 32);
            this.bottombutton.TabIndex = 10;
            this.bottombutton.Text = "BOTTOM";
            this.bottombutton.UseVisualStyleBackColor = true;
            this.bottombutton.Click += new System.EventHandler(this.bottombutton_Click);
            // 
            // previousbutton
            // 
            this.previousbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousbutton.Location = new System.Drawing.Point(78, 231);
            this.previousbutton.Name = "previousbutton";
            this.previousbutton.Size = new System.Drawing.Size(84, 32);
            this.previousbutton.TabIndex = 8;
            this.previousbutton.Text = "PREVIOUS";
            this.previousbutton.UseVisualStyleBackColor = true;
            this.previousbutton.Click += new System.EventHandler(this.previousbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.Location = new System.Drawing.Point(169, 231);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(60, 32);
            this.nextbutton.TabIndex = 9;
            this.nextbutton.Text = "NEXT";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // topbutton
            // 
            this.topbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbutton.Location = new System.Drawing.Point(20, 231);
            this.topbutton.Name = "topbutton";
            this.topbutton.Size = new System.Drawing.Size(51, 32);
            this.topbutton.TabIndex = 7;
            this.topbutton.Text = "TOP";
            this.topbutton.UseVisualStyleBackColor = true;
            this.topbutton.Click += new System.EventHandler(this.topbutton_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(15, 224);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(650, 1);
            this.textBox4.TabIndex = 84;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 40);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(650, 1);
            this.textBox3.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 82;
            this.label1.Text = "STATUTORY DEDUCTION";
            // 
            // staffIDTextBox
            // 
            this.staffIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statutoryDeductionBindingSource, "StaffID", true));
            this.staffIDTextBox.Location = new System.Drawing.Point(312, 81);
            this.staffIDTextBox.MaxLength = 4;
            this.staffIDTextBox.Name = "staffIDTextBox";
            this.staffIDTextBox.ReadOnly = true;
            this.staffIDTextBox.Size = new System.Drawing.Size(46, 27);
            this.staffIDTextBox.TabIndex = 2;
            this.staffIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.staffIDTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.staffIDTextBox_KeyPress);
            this.staffIDTextBox.Leave += new System.EventHandler(this.staffIDTextBox_Leave);
            // 
            // amount1TextBox
            // 
            this.amount1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statutoryDeductionBindingSource, "Amount1", true));
            this.amount1TextBox.Location = new System.Drawing.Point(292, 140);
            this.amount1TextBox.Name = "amount1TextBox";
            this.amount1TextBox.ReadOnly = true;
            this.amount1TextBox.Size = new System.Drawing.Size(100, 27);
            this.amount1TextBox.TabIndex = 5;
            this.amount1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount1TextBox_KeyPress);
            // 
            // amount2TextBox
            // 
            this.amount2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statutoryDeductionBindingSource, "Amount2", true));
            this.amount2TextBox.Location = new System.Drawing.Point(292, 184);
            this.amount2TextBox.Name = "amount2TextBox";
            this.amount2TextBox.ReadOnly = true;
            this.amount2TextBox.Size = new System.Drawing.Size(100, 27);
            this.amount2TextBox.TabIndex = 6;
            this.amount2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount2TextBox_KeyPress);
            // 
            // pFAIdTextBox
            // 
            this.pFAIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statutoryDeductionBindingSource, "PFAId", true));
            this.pFAIdTextBox.Location = new System.Drawing.Point(511, 81);
            this.pFAIdTextBox.MaxLength = 3;
            this.pFAIdTextBox.Name = "pFAIdTextBox";
            this.pFAIdTextBox.ReadOnly = true;
            this.pFAIdTextBox.Size = new System.Drawing.Size(45, 27);
            this.pFAIdTextBox.TabIndex = 3;
            this.pFAIdTextBox.TextChanged += new System.EventHandler(this.pFAIdTextBox_TextChanged);
            this.pFAIdTextBox.Leave += new System.EventHandler(this.pFAIdTextBox_Leave);
            // 
            // pFAAccountNumberTextBox
            // 
            this.pFAAccountNumberTextBox.Location = new System.Drawing.Point(494, 140);
            this.pFAAccountNumberTextBox.MaxLength = 10;
            this.pFAAccountNumberTextBox.Name = "pFAAccountNumberTextBox";
            this.pFAAccountNumberTextBox.ReadOnly = true;
            this.pFAAccountNumberTextBox.Size = new System.Drawing.Size(100, 27);
            this.pFAAccountNumberTextBox.TabIndex = 4;
            this.pFAAccountNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pFAAccountNumberTextBox_KeyPress);
            this.pFAAccountNumberTextBox.Leave += new System.EventHandler(this.pFAAccountNumberTextBox_Leave);
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
            // editbutton
            // 
            this.editbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.Location = new System.Drawing.Point(391, 231);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(60, 32);
            this.editbutton.TabIndex = 99;
            this.editbutton.Text = "EDIT";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(321, 231);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(63, 32);
            this.addbutton.TabIndex = 98;
            this.addbutton.Text = "ADD";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
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
            // companyNameTextBox
            // 
            this.companyNameTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.companyNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.systemDefaultsBindingSource, "CompanyName", true));
            this.companyNameTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.companyNameTextBox.Location = new System.Drawing.Point(427, 10);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyNameTextBox.TabIndex = 100;
            // 
            // statutoryDeductionBindingSource
            // 
            this.statutoryDeductionBindingSource.DataMember = "StatutoryDeduction";
            this.statutoryDeductionBindingSource.DataSource = this.statutoryDataSet5;
            // 
            // statutoryDataSet5
            // 
            this.statutoryDataSet5.DataSetName = "StatutoryDataSet5";
            this.statutoryDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statutoryDeductionTableAdapter
            // 
            this.statutoryDeductionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StatutoryDeductionTableAdapter = this.statutoryDeductionTableAdapter;
            this.tableAdapterManager.UpdateOrder = PersonnelLogin.StatutoryDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(71, 117);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(103, 20);
            descriptionLabel.TabIndex = 100;
            descriptionLabel.Text = "DESCRIPTION:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statutoryDeductionBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(72, 140);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ReadOnly = true;
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 27);
            this.descriptionTextBox.TabIndex = 101;
            // 
            // StatutoryDeduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(685, 272);
            this.ControlBox = false;
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(pFAAccountNumberLabel);
            this.Controls.Add(this.pFAAccountNumberTextBox);
            this.Controls.Add(pFAIdLabel);
            this.Controls.Add(this.pFAIdTextBox);
            this.Controls.Add(amount2Label);
            this.Controls.Add(this.amount2TextBox);
            this.Controls.Add(amount1Label);
            this.Controls.Add(this.amount1TextBox);
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
            this.Controls.Add(statutoryTypeIDLabel);
            this.Controls.Add(this.statutoryTypeIDTextBox);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.editbutton);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StatutoryDeduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Maintenance";
            this.Load += new System.EventHandler(this.StatutoryDeduction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statutoryDeductionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statutoryDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatutoryDataSet5 statutoryDataSet5;
        private System.Windows.Forms.BindingSource statutoryDeductionBindingSource;
        private StatutoryDataSet5TableAdapters.StatutoryDeductionTableAdapter statutoryDeductionTableAdapter;
        private StatutoryDataSet5TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox statutoryTypeIDTextBox;
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
        private System.Windows.Forms.TextBox amount1TextBox;
        private System.Windows.Forms.TextBox amount2TextBox;
        private System.Windows.Forms.TextBox pFAIdTextBox;
        private System.Windows.Forms.TextBox pFAAccountNumberTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button addbutton;
        private LogInDataSet6 logInDataSet6;
        private System.Windows.Forms.BindingSource systemDefaultsBindingSource;
        private LogInDataSet6TableAdapters.SystemDefaultsTableAdapter systemDefaultsTableAdapter;
        private LogInDataSet6TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}