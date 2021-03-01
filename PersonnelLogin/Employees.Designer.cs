namespace PersonnelLogin
{
    partial class Employees
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
            this.DOB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idtextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.employeedataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.viewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DOB
            // 
            this.DOB.CustomFormat = " MMMM dd, yyyy";
            this.DOB.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOB.Location = new System.Drawing.Point(178, 196);
            this.DOB.MaxDate = new System.DateTime(1995, 12, 31, 0, 0, 0, 0);
            this.DOB.MinDate = new System.DateTime(1967, 1, 1, 0, 0, 0, 0);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(187, 29);
            this.DOB.TabIndex = 43;
            this.DOB.Value = new System.DateTime(1995, 12, 31, 0, 0, 0, 0);
            this.DOB.ValueChanged += new System.EventHandler(this.DOB_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SkyBlue;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label9.Location = new System.Drawing.Point(-4, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 25);
            this.label9.TabIndex = 41;
            this.label9.Text = "       ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "DOB";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // idtextBox
            // 
            this.idtextBox.BackColor = System.Drawing.SystemColors.Window;
            this.idtextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtextBox.Location = new System.Drawing.Point(178, 15);
            this.idtextBox.MaxLength = 7;
            this.idtextBox.Multiline = true;
            this.idtextBox.Name = "idtextBox";
            this.idtextBox.Size = new System.Drawing.Size(67, 25);
            this.idtextBox.TabIndex = 1;
            this.idtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idtextBox.Leave += new System.EventHandler(this.idtextBox_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 25);
            this.label7.TabIndex = 44;
            this.label7.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.textBox1.Location = new System.Drawing.Point(178, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(381, 29);
            this.textBox1.TabIndex = 46;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(178, 102);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(671, 29);
            this.textBox7.TabIndex = 2;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(178, 149);
            this.textBox8.MaxLength = 15;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(155, 29);
            this.textBox8.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Name";
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.SystemColors.Window;
            this.savebutton.Location = new System.Drawing.Point(874, 55);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(64, 29);
            this.savebutton.TabIndex = 56;
            this.savebutton.Text = "SAVE";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // employeedataGridView
            // 
            this.employeedataGridView.AllowUserToAddRows = false;
            this.employeedataGridView.AllowUserToDeleteRows = false;
            this.employeedataGridView.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.employeedataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeedataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.employeedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeedataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.employeedataGridView.Location = new System.Drawing.Point(9, 233);
            this.employeedataGridView.Name = "employeedataGridView";
            this.employeedataGridView.ReadOnly = true;
            this.employeedataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.employeedataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.employeedataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.employeedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeedataGridView.ShowEditingIcon = false;
            this.employeedataGridView.Size = new System.Drawing.Size(989, 351);
            this.employeedataGridView.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(392, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 21);
            this.label5.TabIndex = 58;
            this.label5.Text = "  ";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 21);
            this.label6.TabIndex = 58;
            this.label6.Text = "  ";
            this.label6.Visible = false;
            // 
            // updateButton
            // 
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.BackColor = System.Drawing.SystemColors.Window;
            this.updateButton.Location = new System.Drawing.Point(874, 101);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(80, 30);
            this.updateButton.TabIndex = 56;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteButton.BackColor = System.Drawing.SystemColors.Window;
            this.deleteButton.Location = new System.Drawing.Point(874, 147);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(80, 28);
            this.deleteButton.TabIndex = 56;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.SystemColors.Window;
            this.viewButton.Location = new System.Drawing.Point(874, 193);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(64, 29);
            this.viewButton.TabIndex = 56;
            this.viewButton.Text = "VIEW";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(992, 596);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.employeedataGridView);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.idtextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Employees";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employees";
            this.Load += new System.EventHandler(this.Employees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idtextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.DataGridView employeedataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button viewButton;
    }
}