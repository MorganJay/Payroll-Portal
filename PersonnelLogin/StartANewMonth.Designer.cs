namespace PersonnelLogin
{
    partial class StartANewMonth
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.systemDefaultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemDefaultsDataSet = new PersonnelLogin.SystemDefaultsDataSet();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new PersonnelLogin.SystemDefaultsDataSetTableAdapters.TableAdapterManager();
            this.payrollTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemDefaultsTableAdapter = new PersonnelLogin.SystemDefaultsDataSetTableAdapters.SystemDefaultsTableAdapter();
            this.textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(95, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Please Confirm Payroll Period";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "CONTINUE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(262, 200);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "E&XIT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Working Days:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "End Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.systemDefaultsBindingSource, "SalaryStartDate", true));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(202, 62);
            this.dateTimePicker1.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 37);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2017, 11, 2, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // systemDefaultsBindingSource
            // 
            this.systemDefaultsBindingSource.DataMember = "SystemDefaults";
            this.systemDefaultsBindingSource.DataSource = this.systemDefaultsDataSet;
            // 
            // systemDefaultsDataSet
            // 
            this.systemDefaultsDataSet.DataSetName = "SystemDefaultsDataSet";
            this.systemDefaultsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(202, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(33, 37);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.systemDefaultsBindingSource, "SalaryEndDate", true));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(202, 102);
            this.dateTimePicker2.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2017, 10, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 37);
            this.dateTimePicker2.TabIndex = 4;
            this.dateTimePicker2.Value = new System.DateTime(2017, 11, 2, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(12, 184);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(387, 3);
            this.textBox3.TabIndex = 5;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.SystemDefaultsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PersonnelLogin.SystemDefaultsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // systemDefaultsTableAdapter
            // 
            this.systemDefaultsTableAdapter.ClearBeforeFill = true;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox.Location = new System.Drawing.Point(241, 147);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(51, 30);
            this.textBox.TabIndex = 6;
            // 
            // StartANewMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(662, 280);
            this.ControlBox = false;
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartANewMonth";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Processes";
            this.Load += new System.EventHandler(this.StartANewMonth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemDefaultsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox3;
        private SystemDefaultsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource payrollTableBindingSource;
        private SystemDefaultsDataSet systemDefaultsDataSet;
        private System.Windows.Forms.BindingSource systemDefaultsBindingSource;
        private SystemDefaultsDataSetTableAdapters.SystemDefaultsTableAdapter systemDefaultsTableAdapter;
        private System.Windows.Forms.TextBox textBox;
    }
}