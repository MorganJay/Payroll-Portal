namespace PersonnelLogin
{
    partial class PfAtable
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
            System.Windows.Forms.Label pFAIdLabel;
            System.Windows.Forms.Label pFANameLabel;
            System.Windows.Forms.Label pFAAddressLabel;
            System.Windows.Forms.Label pFAAccountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PfAtable));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.exitbutton = new System.Windows.Forms.Button();
            this.logInDataSet6 = new PersonnelLogin.LogInDataSet6();
            this.systemDefaultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemDefaultsTableAdapter = new PersonnelLogin.LogInDataSet6TableAdapters.SystemDefaultsTableAdapter();
            this.tableAdapterManager = new PersonnelLogin.LogInDataSet6TableAdapters.TableAdapterManager();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.pFADataSet5 = new PersonnelLogin.PFADataSet5();
            this.pFATableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pFATableTableAdapter = new PersonnelLogin.PFADataSet5TableAdapters.PFATableTableAdapter();
            this.tableAdapterManager1 = new PersonnelLogin.PFADataSet5TableAdapters.TableAdapterManager();
            this.pFAIdTextBox = new System.Windows.Forms.TextBox();
            this.pFANameTextBox = new System.Windows.Forms.TextBox();
            this.pFAAddressTextBox = new System.Windows.Forms.TextBox();
            this.pFAAccountTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            pFAIdLabel = new System.Windows.Forms.Label();
            pFANameLabel = new System.Windows.Forms.Label();
            pFAAddressLabel = new System.Windows.Forms.Label();
            pFAAccountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFADataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFATableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pFAIdLabel
            // 
            pFAIdLabel.AutoSize = true;
            pFAIdLabel.Location = new System.Drawing.Point(174, 51);
            pFAIdLabel.Name = "pFAIdLabel";
            pFAIdLabel.Size = new System.Drawing.Size(56, 20);
            pFAIdLabel.TabIndex = 113;
            pFAIdLabel.Text = "PFA ID:";
            // 
            // pFANameLabel
            // 
            pFANameLabel.AutoSize = true;
            pFANameLabel.Location = new System.Drawing.Point(147, 88);
            pFANameLabel.Name = "pFANameLabel";
            pFANameLabel.Size = new System.Drawing.Size(83, 20);
            pFANameLabel.TabIndex = 114;
            pFANameLabel.Text = "PFA NAME:";
            // 
            // pFAAddressLabel
            // 
            pFAAddressLabel.AutoSize = true;
            pFAAddressLabel.Location = new System.Drawing.Point(124, 162);
            pFAAddressLabel.Name = "pFAAddressLabel";
            pFAAddressLabel.Size = new System.Drawing.Size(106, 20);
            pFAAddressLabel.TabIndex = 115;
            pFAAddressLabel.Text = "PFA ADDRESS:";
            // 
            // pFAAccountLabel
            // 
            pFAAccountLabel.AutoSize = true;
            pFAAccountLabel.Location = new System.Drawing.Point(57, 125);
            pFAAccountLabel.Name = "pFAAccountLabel";
            pFAAccountLabel.Size = new System.Drawing.Size(173, 20);
            pFAAccountLabel.TabIndex = 116;
            pFAAccountLabel.Text = "PFA ACCOUNT NUMBER:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(10, 40);
            this.textBox3.MaxLength = 327670000;
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(650, 1);
            this.textBox3.TabIndex = 85;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "PENSION FUND ADMINISTRATOR (PFA) DATA";
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(455, 226);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(61, 32);
            this.printbutton.TabIndex = 13;
            this.printbutton.Text = "PRINT";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            this.printbutton.MouseEnter += new System.EventHandler(this.printbutton_MouseEnter);
            this.printbutton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.printbutton_MouseMove);
            // 
            // cancelbutton
            // 
            this.cancelbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelbutton.Location = new System.Drawing.Point(388, 226);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(61, 32);
            this.cancelbutton.TabIndex = 11;
            this.cancelbutton.Text = "UNDO";
            this.cancelbutton.UseVisualStyleBackColor = true;
            this.cancelbutton.Visible = false;
            this.cancelbutton.Click += new System.EventHandler(this.cancelbutton_Click);
            // 
            // savebutton
            // 
            this.savebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.Location = new System.Drawing.Point(319, 226);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(63, 32);
            this.savebutton.TabIndex = 9;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Visible = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            this.savebutton.MouseEnter += new System.EventHandler(this.savebutton_MouseEnter);
            // 
            // deletebutton
            // 
            this.deletebutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebutton.Location = new System.Drawing.Point(522, 226);
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
            this.bottombutton.Location = new System.Drawing.Point(234, 226);
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
            this.previousbutton.Location = new System.Drawing.Point(78, 226);
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
            this.nextbutton.Location = new System.Drawing.Point(168, 226);
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
            this.topbutton.Location = new System.Drawing.Point(21, 226);
            this.topbutton.Name = "topbutton";
            this.topbutton.Size = new System.Drawing.Size(51, 32);
            this.topbutton.TabIndex = 5;
            this.topbutton.Text = "TOP";
            this.topbutton.UseVisualStyleBackColor = true;
            this.topbutton.Click += new System.EventHandler(this.topbutton_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(10, 219);
            this.textBox4.MaxLength = 327670000;
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(650, 1);
            this.textBox4.TabIndex = 108;
            // 
            // addbutton
            // 
            this.addbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbutton.Location = new System.Drawing.Point(320, 226);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(63, 32);
            this.addbutton.TabIndex = 10;
            this.addbutton.Text = "ADD";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editbutton.Location = new System.Drawing.Point(389, 226);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(60, 32);
            this.editbutton.TabIndex = 12;
            this.editbutton.Text = "EDIT";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // exitbutton
            // 
            this.exitbutton.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbutton.ForeColor = System.Drawing.Color.Red;
            this.exitbutton.Location = new System.Drawing.Point(599, 226);
            this.exitbutton.Name = "exitbutton";
            this.exitbutton.Size = new System.Drawing.Size(56, 32);
            this.exitbutton.TabIndex = 15;
            this.exitbutton.Text = "EXIT";
            this.exitbutton.UseVisualStyleBackColor = true;
            this.exitbutton.Click += new System.EventHandler(this.exitbutton_Click);
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
            this.companyNameTextBox.Location = new System.Drawing.Point(412, 9);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyNameTextBox.TabIndex = 113;
            // 
            // pFADataSet5
            // 
            this.pFADataSet5.DataSetName = "PFADataSet5";
            this.pFADataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pFATableBindingSource
            // 
            this.pFATableBindingSource.DataMember = "PFATable";
            this.pFATableBindingSource.DataSource = this.pFADataSet5;
            // 
            // pFATableTableAdapter
            // 
            this.pFATableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.PFATableTableAdapter = this.pFATableTableAdapter;
            this.tableAdapterManager1.UpdateOrder = PersonnelLogin.PFADataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pFAIdTextBox
            // 
            this.pFAIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pFATableBindingSource, "PFAId", true));
            this.pFAIdTextBox.Location = new System.Drawing.Point(236, 48);
            this.pFAIdTextBox.MaxLength = 3;
            this.pFAIdTextBox.Name = "pFAIdTextBox";
            this.pFAIdTextBox.ReadOnly = true;
            this.pFAIdTextBox.Size = new System.Drawing.Size(42, 27);
            this.pFAIdTextBox.TabIndex = 1;
            this.pFAIdTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pFAIdTextBox_KeyPress);
            // 
            // pFANameTextBox
            // 
            this.pFANameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pFATableBindingSource, "PFAName", true));
            this.pFANameTextBox.Location = new System.Drawing.Point(236, 85);
            this.pFANameTextBox.MaxLength = 50;
            this.pFANameTextBox.Name = "pFANameTextBox";
            this.pFANameTextBox.ReadOnly = true;
            this.pFANameTextBox.Size = new System.Drawing.Size(190, 27);
            this.pFANameTextBox.TabIndex = 2;
            this.pFANameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pFANameTextBox_KeyPress);
            // 
            // pFAAddressTextBox
            // 
            this.pFAAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pFATableBindingSource, "PFAAddress", true));
            this.pFAAddressTextBox.Location = new System.Drawing.Point(236, 159);
            this.pFAAddressTextBox.MaxLength = 100;
            this.pFAAddressTextBox.Multiline = true;
            this.pFAAddressTextBox.Name = "pFAAddressTextBox";
            this.pFAAddressTextBox.ReadOnly = true;
            this.pFAAddressTextBox.Size = new System.Drawing.Size(404, 50);
            this.pFAAddressTextBox.TabIndex = 4;
            // 
            // pFAAccountTextBox
            // 
            this.pFAAccountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pFATableBindingSource, "PFAAccount", true));
            this.pFAAccountTextBox.Location = new System.Drawing.Point(236, 122);
            this.pFAAccountTextBox.MaxLength = 10;
            this.pFAAccountTextBox.Name = "pFAAccountTextBox";
            this.pFAAccountTextBox.ReadOnly = true;
            this.pFAAccountTextBox.Size = new System.Drawing.Size(100, 27);
            this.pFAAccountTextBox.TabIndex = 3;
            this.pFAAccountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pFAAccountTextBox_KeyPress);
            this.pFAAccountTextBox.Leave += new System.EventHandler(this.pFAAccountTextBox_Leave);
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
            // PfAtable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(673, 267);
            this.ControlBox = false;
            this.Controls.Add(pFAAccountLabel);
            this.Controls.Add(this.pFAAccountTextBox);
            this.Controls.Add(pFAAddressLabel);
            this.Controls.Add(this.pFAAddressTextBox);
            this.Controls.Add(pFANameLabel);
            this.Controls.Add(this.pFANameTextBox);
            this.Controls.Add(pFAIdLabel);
            this.Controls.Add(this.pFAIdTextBox);
            this.Controls.Add(this.companyNameTextBox);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PfAtable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Maintenance";
            this.Load += new System.EventHandler(this.PFAtable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logInDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFADataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pFATableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Button exitbutton;
        private LogInDataSet6 logInDataSet6;
        private System.Windows.Forms.BindingSource systemDefaultsBindingSource;
        private LogInDataSet6TableAdapters.SystemDefaultsTableAdapter systemDefaultsTableAdapter;
        private LogInDataSet6TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private PFADataSet5 pFADataSet5;
        private System.Windows.Forms.BindingSource pFATableBindingSource;
        private PFADataSet5TableAdapters.PFATableTableAdapter pFATableTableAdapter;
        private PFADataSet5TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.TextBox pFAIdTextBox;
        private System.Windows.Forms.TextBox pFANameTextBox;
        private System.Windows.Forms.TextBox pFAAddressTextBox;
        private System.Windows.Forms.TextBox pFAAccountTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}