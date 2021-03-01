namespace PersonnelLogin
{
    partial class JobDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobDescription));
            this.printbutton = new System.Windows.Forms.Button();
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
            this.descriptiontextBox = new System.Windows.Forms.TextBox();
            this.jobDescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobDataSet4 = new PersonnelLogin.JobDataSet4();
            this.codetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.basicsalarytextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.housingtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.transporttextBox = new System.Windows.Forms.TextBox();
            this.jobDescriptionTableAdapter = new PersonnelLogin.JobDataSet4TableAdapters.JobDescriptionTableAdapter();
            this.tableAdapterManager = new PersonnelLogin.JobDataSet4TableAdapters.TableAdapterManager();
            this.logInDataSet6 = new PersonnelLogin.LogInDataSet6();
            this.systemDefaultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemDefaultsTableAdapter = new PersonnelLogin.LogInDataSet6TableAdapters.SystemDefaultsTableAdapter();
            this.tableAdapterManager1 = new PersonnelLogin.LogInDataSet6TableAdapters.TableAdapterManager();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.jobDescriptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(467, 178);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(61, 32);
            this.printbutton.TabIndex = 11;
            this.printbutton.Text = "PRINT";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            this.printbutton.MouseEnter += new System.EventHandler(this.printbutton_MouseEnter);
            // 
            // cancelbutton
            // 
            this.cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(399, 178);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(61, 32);
            this.cancelbutton.TabIndex = 10;
            this.cancelbutton.Text = "UNDO";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Visible = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(329, 178);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(63, 32);
            this.savebutton.TabIndex = 14;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Visible = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            this.savebutton.MouseEnter += new System.EventHandler(this.savebutton_MouseEnter);
            this.savebutton.MouseHover += new System.EventHandler(this.savebutton_MouseHover);
            // 
            // editbutton
            // 
            this.editbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.Location = new System.Drawing.Point(400, 178);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(60, 32);
            this.editbutton.TabIndex = 56;
            this.editbutton.Text = "EDIT";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.Red;
            this.exitbutton.Location = new System.Drawing.Point(613, 178);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(56, 32);
            this.exitbutton.TabIndex = 13;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(535, 178);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(71, 32);
            this.deletebutton.TabIndex = 12;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(330, 178);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(63, 32);
            this.addbutton.TabIndex = 9;
            this.addbutton.Text = "ADD";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // bottombutton
            // 
            this.bottombutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottombutton.Location = new System.Drawing.Point(243, 178);
            this.bottombutton.Name = "bottombutton";
            this.bottombutton.Size = new System.Drawing.Size(80, 32);
            this.bottombutton.TabIndex = 8;
            this.bottombutton.Text = "BOTTOM";
            this.bottombutton.UseVisualStyleBackColor = true;
            this.bottombutton.Click += new System.EventHandler(this.bottombutton_Click);
            // 
            // previousbutton
            // 
            this.previousbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousbutton.Location = new System.Drawing.Point(85, 178);
            this.previousbutton.Name = "previousbutton";
            this.previousbutton.Size = new System.Drawing.Size(84, 32);
            this.previousbutton.TabIndex = 6;
            this.previousbutton.Text = "PREVIOUS";
            this.previousbutton.UseVisualStyleBackColor = true;
            this.previousbutton.Click += new System.EventHandler(this.previousbutton_Click);
            // 
            // nextbutton
            // 
            this.nextbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextbutton.Location = new System.Drawing.Point(176, 178);
            this.nextbutton.Name = "nextbutton";
            this.nextbutton.Size = new System.Drawing.Size(60, 32);
            this.nextbutton.TabIndex = 7;
            this.nextbutton.Text = "NEXT";
            this.nextbutton.UseVisualStyleBackColor = true;
            this.nextbutton.Click += new System.EventHandler(this.nextbutton_Click);
            // 
            // topbutton
            // 
            this.topbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topbutton.Location = new System.Drawing.Point(27, 178);
            this.topbutton.Name = "topbutton";
            this.topbutton.Size = new System.Drawing.Size(51, 32);
            this.topbutton.TabIndex = 5;
            this.topbutton.Text = "TOP";
            this.topbutton.UseVisualStyleBackColor = true;
            this.topbutton.Click += new System.EventHandler(this.topbutton_Click);
            // 
            // descriptiontextBox
            // 
            this.descriptiontextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDescriptionBindingSource, "JobDesc", true));
            this.descriptiontextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptiontextBox.Location = new System.Drawing.Point(166, 92);
            this.descriptiontextBox.MaxLength = 50;
            this.descriptiontextBox.Multiline = true;
            this.descriptiontextBox.Name = "descriptiontextBox";
            this.descriptiontextBox.ReadOnly = true;
            this.descriptiontextBox.Size = new System.Drawing.Size(165, 27);
            this.descriptiontextBox.TabIndex = 1;
            this.descriptiontextBox.TextChanged += new System.EventHandler(this.descriptiontextBox_TextChanged);
            this.descriptiontextBox.Enter += new System.EventHandler(this.descriptiontextBox_Enter);
            this.descriptiontextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descriptiontextBox_KeyPress);
            // 
            // jobDescriptionBindingSource
            // 
            this.jobDescriptionBindingSource.DataMember = "JobDescription";
            this.jobDescriptionBindingSource.DataSource = this.jobDataSet4;
            // 
            // jobDataSet4
            // 
            this.jobDataSet4.DataSetName = "JobDataSet4";
            this.jobDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codetextBox
            // 
            this.codetextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDescriptionBindingSource, "JobCode", true));
            this.codetextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codetextBox.Location = new System.Drawing.Point(166, 59);
            this.codetextBox.MaxLength = 4;
            this.codetextBox.Name = "codetextBox";
            this.codetextBox.ReadOnly = true;
            this.codetextBox.Size = new System.Drawing.Size(47, 27);
            this.codetextBox.TabIndex = 0;
            this.codetextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 21);
            this.label3.TabIndex = 53;
            this.label3.Text = "DESCRIPTION:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 51;
            this.label2.Text = "CODE:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(19, 169);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(662, 1);
            this.textBox4.TabIndex = 49;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(19, 40);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(662, 1);
            this.textBox3.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "JOB DESCRIPTION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "BASIC SALARY:";
            // 
            // basicsalarytextBox
            // 
            this.basicsalarytextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDescriptionBindingSource, "BasicSalary", true));
            this.basicsalarytextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.basicsalarytextBox.Location = new System.Drawing.Point(549, 59);
            this.basicsalarytextBox.MaxLength = 12;
            this.basicsalarytextBox.Name = "basicsalarytextBox";
            this.basicsalarytextBox.ReadOnly = true;
            this.basicsalarytextBox.Size = new System.Drawing.Size(97, 27);
            this.basicsalarytextBox.TabIndex = 2;
            this.basicsalarytextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.basicsalarytextBox.CursorChanged += new System.EventHandler(this.basicsalarytextBox_CursorChanged);
            this.basicsalarytextBox.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.basicsalarytextBox_ControlRemoved);
            this.basicsalarytextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.basicsalarytextBox_KeyPress);
            this.basicsalarytextBox.MouseLeave += new System.EventHandler(this.basicsalarytextBox_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(366, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 21);
            this.label5.TabIndex = 51;
            this.label5.Text = "HOUSING ALLOWANCE:";
            // 
            // housingtextBox
            // 
            this.housingtextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDescriptionBindingSource, "HousingAllowance", true));
            this.housingtextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.housingtextBox.Location = new System.Drawing.Point(549, 92);
            this.housingtextBox.MaxLength = 12;
            this.housingtextBox.Name = "housingtextBox";
            this.housingtextBox.ReadOnly = true;
            this.housingtextBox.Size = new System.Drawing.Size(97, 27);
            this.housingtextBox.TabIndex = 3;
            this.housingtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.housingtextBox.CursorChanged += new System.EventHandler(this.housingtextBox_CursorChanged);
            this.housingtextBox.Enter += new System.EventHandler(this.housingtextBox_Enter);
            this.housingtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.housingtextBox_KeyPress);
            this.housingtextBox.MouseLeave += new System.EventHandler(this.housingtextBox_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 21);
            this.label6.TabIndex = 51;
            this.label6.Text = "TRANSPORT ALLOWANCE:";
            // 
            // transporttextBox
            // 
            this.transporttextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobDescriptionBindingSource, "TransportationAllowance", true));
            this.transporttextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transporttextBox.Location = new System.Drawing.Point(549, 125);
            this.transporttextBox.MaxLength = 12;
            this.transporttextBox.Name = "transporttextBox";
            this.transporttextBox.ReadOnly = true;
            this.transporttextBox.Size = new System.Drawing.Size(97, 27);
            this.transporttextBox.TabIndex = 4;
            this.transporttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.transporttextBox.CursorChanged += new System.EventHandler(this.transporttextBox_CursorChanged);
            this.transporttextBox.Enter += new System.EventHandler(this.transporttextBox_Enter);
            this.transporttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.transporttextBox_KeyPress);
            this.transporttextBox.MouseLeave += new System.EventHandler(this.transporttextBox_MouseLeave);
            // 
            // jobDescriptionTableAdapter
            // 
            this.jobDescriptionTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.JobDescriptionTableAdapter = this.jobDescriptionTableAdapter;
            this.tableAdapterManager.UpdateOrder = PersonnelLogin.JobDataSet4TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.companyNameTextBox.Location = new System.Drawing.Point(671, 13);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(10, 20);
            this.companyNameTextBox.TabIndex = 67;
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
            // JobDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(694, 220);
            this.ControlBox = false;
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.printbutton);
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
            this.Controls.Add(this.descriptiontextBox);
            this.Controls.Add(this.transporttextBox);
            this.Controls.Add(this.housingtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.basicsalarytextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.codetextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "JobDescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Maintenance";
            this.Load += new System.EventHandler(this.JobDescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobDescriptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printbutton;
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
        private System.Windows.Forms.TextBox descriptiontextBox;
        private System.Windows.Forms.TextBox codetextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox basicsalarytextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox housingtextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox transporttextBox;
        private JobDataSet4 jobDataSet4;
        private System.Windows.Forms.BindingSource jobDescriptionBindingSource;
        private JobDataSet4TableAdapters.JobDescriptionTableAdapter jobDescriptionTableAdapter;
        private JobDataSet4TableAdapters.TableAdapterManager tableAdapterManager;
        private LogInDataSet6 logInDataSet6;
        private System.Windows.Forms.BindingSource systemDefaultsBindingSource;
        private LogInDataSet6TableAdapters.SystemDefaultsTableAdapter systemDefaultsTableAdapter;
        private LogInDataSet6TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}