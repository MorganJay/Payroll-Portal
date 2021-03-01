namespace PersonnelLogin
{
    partial class Banks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banks));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.codetextBox = new System.Windows.Forms.TextBox();
            this.bankDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankDataSet5 = new PersonnelLogin.BankDataSet5();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.savebutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.exitbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.bottombutton = new System.Windows.Forms.Button();
            this.previousbutton = new System.Windows.Forms.Button();
            this.nextbutton = new System.Windows.Forms.Button();
            this.topbutton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.tableAdapterManager = new PersonnelLogin.BankDataSet5TableAdapters.TableAdapterManager();
            this.bankDataTableAdapter = new PersonnelLogin.BankDataSet5TableAdapters.BankDataTableAdapter();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.logInDataSet6 = new PersonnelLogin.LogInDataSet6();
            this.systemDefaultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemDefaultsTableAdapter = new PersonnelLogin.LogInDataSet6TableAdapters.SystemDefaultsTableAdapter();
            this.tableAdapterManager1 = new PersonnelLogin.LogInDataSet6TableAdapters.TableAdapterManager();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 37);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(646, 1);
            this.textBox3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "BANKS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "CODE:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "NAME:";
            // 
            // codetextBox
            // 
            this.codetextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankDataBindingSource, "BankCode", true));
            this.codetextBox.Location = new System.Drawing.Point(187, 62);
            this.codetextBox.MaxLength = 7;
            this.codetextBox.Multiline = true;
            this.codetextBox.Name = "codetextBox";
            this.codetextBox.ReadOnly = true;
            this.codetextBox.Size = new System.Drawing.Size(85, 26);
            this.codetextBox.TabIndex = 10;
            this.codetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.codetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.codetextBox_KeyPress);
            // 
            // bankDataBindingSource
            // 
            this.bankDataBindingSource.DataMember = "BankData";
            this.bankDataBindingSource.DataSource = this.bankDataSet5;
            // 
            // bankDataSet5
            // 
            this.bankDataSet5.DataSetName = "BankDataSet5";
            this.bankDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nametextBox
            // 
            this.nametextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bankDataBindingSource, "BankName", true));
            this.nametextBox.Location = new System.Drawing.Point(432, 65);
            this.nametextBox.MaxLength = 100;
            this.nametextBox.Multiline = true;
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.ReadOnly = true;
            this.nametextBox.Size = new System.Drawing.Size(157, 26);
            this.nametextBox.TabIndex = 10;
            this.nametextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nametextBox_KeyPress);
            // 
            // cancelbutton
            // 
            this.cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(377, 126);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(124, 64);
            this.cancelbutton.TabIndex = 22;
            this.cancelbutton.Text = "CANCEL";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Visible = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(309, 126);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(116, 64);
            this.savebutton.TabIndex = 21;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Visible = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.Location = new System.Drawing.Point(382, 125);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(116, 64);
            this.editbutton.TabIndex = 17;
            this.editbutton.Text = "EDIT";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.Red;
            this.exitbutton.Location = new System.Drawing.Point(722, 125);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(109, 64);
            this.exitbutton.TabIndex = 24;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(596, 125);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(120, 64);
            this.deletebutton.TabIndex = 23;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(311, 125);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(116, 64);
            this.addbutton.TabIndex = 14;
            this.addbutton.Text = "ADD";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // bottombutton
            // 
            this.bottombutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottombutton.Location = new System.Drawing.Point(220, 126);
            this.bottombutton.Name = "bottombutton";
            this.bottombutton.Size = new System.Drawing.Size(117, 64);
            this.bottombutton.TabIndex = 20;
            this.bottombutton.Text = "BOTTOM";
            this.bottombutton.UseVisualStyleBackColor = true;
            this.bottombutton.Click += new System.EventHandler(this.bottombutton_Click);
            // 
            // previousbutton
            // 
            this.previousbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousbutton.Location = new System.Drawing.Point(52, 126);
            this.previousbutton.Name = "previousbutton";
            this.previousbutton.Size = new System.Drawing.Size(137, 64);
            this.previousbutton.TabIndex = 18;
            this.previousbutton.Text = "PREVIOUS";
            this.previousbutton.UseVisualStyleBackColor = true;
            this.previousbutton.Click += new System.EventHandler(this.previousbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.Location = new System.Drawing.Point(149, 126);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(107, 64);
            this.nextbutton.TabIndex = 19;
            this.nextbutton.Text = "NEXT";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // topbutton
            // 
            this.topbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbutton.Location = new System.Drawing.Point(16, 126);
            this.topbutton.Name = "topbutton";
            this.topbutton.Size = new System.Drawing.Size(104, 64);
            this.topbutton.TabIndex = 15;
            this.topbutton.Text = "TOP";
            this.topbutton.UseVisualStyleBackColor = true;
            this.topbutton.Click += new System.EventHandler(this.topbutton_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(12, 118);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(646, 1);
            this.textBox4.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 64);
            this.button1.TabIndex = 26;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BankDataTableAdapter = this.bankDataTableAdapter;
            this.tableAdapterManager.UpdateOrder = PersonnelLogin.BankDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bankDataTableAdapter
            // 
            this.bankDataTableAdapter.ClearBeforeFill = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument2;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
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
            this.companyNameTextBox.Location = new System.Drawing.Point(555, 9);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.ReadOnly = true;
            this.companyNameTextBox.Size = new System.Drawing.Size(100, 32);
            this.companyNameTextBox.TabIndex = 27;
            // 
            // Banks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(859, 210);
            this.ControlBox = false;
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.exitbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.bottombutton);
            this.Controls.Add(this.previousbutton);
            this.Controls.Add(this.nextbutton);
            this.Controls.Add(this.topbutton);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.codetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Banks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Maintenance";
            this.Load += new System.EventHandler(this.Banks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bankDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox codetextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Button cancelbutton;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button exitbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button bottombutton;
        private System.Windows.Forms.Button previousbutton;
        private System.Windows.Forms.Button nextbutton;
        private System.Windows.Forms.Button topbutton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private BankDataSet5TableAdapters.TableAdapterManager tableAdapterManager;
        private BankDataSet5TableAdapters.BankDataTableAdapter bankDataTableAdapter;
        private BankDataSet5 bankDataSet5;
        private System.Windows.Forms.BindingSource bankDataBindingSource;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private LogInDataSet6 logInDataSet6;
        private System.Windows.Forms.BindingSource systemDefaultsBindingSource;
        private LogInDataSet6TableAdapters.SystemDefaultsTableAdapter systemDefaultsTableAdapter;
        private LogInDataSet6TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox companyNameTextBox;
    }
}