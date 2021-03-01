using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;

namespace PersonnelLogin
{
    public partial class PayrollTable : Form
    {
        public PayrollTable()
        {
            InitializeComponent();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            LengthChecker();
            GetPaye();
        }
        private void PayrollTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'systemDefaultsDataSet.SystemDefaults' table. You can move, or remove it, as needed.
            systemDefaultsTableAdapter1.Fill(systemDefaultsDataSet.SystemDefaults);
           // TODO: This line of code loads data into the 'logInDataSet2.PayrollTable' table. You can move, or remove it, as needed.
            payrollTableTableAdapter1.Fill(logInDataSet2.PayrollTable);
            ActiveControl = topbutton;
            LengthChecker();
            GetPaye();
        }
        public long Textbox;
        public void LengthChecker()
        {
           var chars = accountNumberTextBox.Text.Length;
           if (chars < 10)
            {
                try
                {
                    Textbox = long.Parse(accountNumberTextBox.Text);
                    accountNumberTextBox.Text = string.Format("{0,10:D10}", Textbox);
                }
                catch (Exception)
                {
                    //Ignore
                }
            }
        }
        private void staffIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        private void accountNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void salaryPeriodTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void daysWorkedTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void absentDaysTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        
        private void netSalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void grossSalaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        public SqlConnection Con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
        public SqlCommand Cmd;
        public void Stringformat()
        {
            try
            {
                if (!string.IsNullOrEmpty(netSalaryTextBox.Text))
                {
                    netSalaryTextBox.Text = string.Format("{0:#,##0.00}", double.Parse(netSalaryTextBox.Text));
                }
                else
                {
                    netSalaryTextBox.Text = @"0.00";
                }
            }
            catch (Exception)
            {
                //ignore
            }
        }

        public void Readonly()
        {
           daysWorkedTextBox.ReadOnly = true;
           topbutton.Enabled = true;
            previousbutton.Enabled = true;
            deletebutton.Enabled = true;
            exitbutton.Enabled = true;
           cancelbutton.Visible = false;
            printbutton.Enabled = true;
            nextbutton.Enabled = true;
            bottombutton.Enabled = true;
            LengthChecker();
        }
        public void PrintI()
        {
            DateTime timeofDay = DateTime.Now;
            textBox3.Text = "";
            textBox3.AppendText(" " + Environment.NewLine);
            textBox3.AppendText("\t\t\t\t    " + companyNameTextBox.Text + Environment.NewLine);
            textBox3.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox3.AppendText("\t\t\t\t " + label1.Text + Environment.NewLine);
            textBox3.AppendText(Environment.NewLine);

            textBox3.AppendText("  Employee ID: " + "\t\t\t" + staffIDTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Salary Period: " + "\t\t\t" + salaryPeriodTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Days Worked: " + "\t\t\t" + daysWorkedTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Absent Days: " + "\t\t\t" + absentDaysTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Bank Code: " + "\t\t\t" + bankCodeTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Account Number: " + "\t\t\t" + accountNumberTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Deduction: " + "\t\t\t" + deductionTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Gross Salary: " + "\t\t\tNGN " + grossSalaryTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Net Salary: " + "\t\t\tNGN " + netSalaryTextBox.Text + Environment.NewLine);
            
            textBox3.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox3.AppendText("\t\t\t\t\t\t\t\t\t               " + timeofDay.ToString("dd-MM-yyyy HH:mm:ss") + Environment.NewLine);
        }
        public void RefreshStuff()
        {
            payrollTableBindingSource1.ResetBindings(true);
        }
        private void topbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            payrollTableBindingSource1.MoveFirst();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            bottombutton.Enabled = true;
            nextbutton.Enabled = true;
            Stringformat();
            LengthChecker();
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            payrollTableBindingSource1.MovePrevious();
            nextbutton.Enabled = true;
            bottombutton.Enabled = true;
            Stringformat();
            LengthChecker();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            payrollTableBindingSource1.MoveNext();
            previousbutton.Enabled = true;
            topbutton.Enabled = true;
            LengthChecker();
            Stringformat();
        }

        private void bottombutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            payrollTableBindingSource1.MoveLast();
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
            topbutton.Enabled = true;
            previousbutton.Enabled = true;
            Stringformat();
            LengthChecker();
        }
        
        private void editbutton_Click(object sender, EventArgs e)
        {
            daysWorkedTextBox.ReadOnly = false;
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            nextbutton.Enabled = false;
            savebutton.Enabled = true;
            bottombutton.Enabled = false;
            deletebutton.Enabled = false;
            printbutton.Enabled = false;
            exitbutton.Enabled = false;
            cancelbutton.Visible = true;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (absentDaysTextBox.Text == "" || daysWorkedTextBox.Text == "")
            {
                MessageBox.Show(@"Please Fill All Fields", @"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                    Con.Open();
                    var cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE PayrollTable SET DaysWorked = '"+ daysWorkedTextBox.Text + "', AbsentDays = '" + absentDaysTextBox.Text + "'," +
                                      "Deduction = '" + deductionTextBox.Text + "', NetSalary = '"+netSalaryTextBox.Text+"', TotalDeduction= '"+ dlabel.Text +"' WHERE StaffID = '" + staffIDTextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    Con.Close();
                Readonly();
                savebutton.Enabled = false;
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            payrollTableBindingSource1.CancelEdit();
            Readonly();
            Stringformat();
        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Do you want to print all records?", @"",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                PayrollTableReport ss = new PayrollTableReport();
                ss.Show();
            }      
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to delete this record?", @"Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            Con.Open();
            string query = "DELETE FROM PayrollTable WHERE StaffID = '" + staffIDTextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            sda.SelectCommand.ExecuteNonQuery();
            DataTable data = new DataTable();
            sda.Fill(data);
            Con.Close();
            payrollTableBindingSource1.RemoveCurrent();        
            Readonly();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox3.Text, new Font("Segoe UI Emoji", 12), Brushes.Black, 1, 1);
        }
        
        private void savebutton_MouseEnter(object sender, EventArgs e)
        {
            Stringformat();
        }
        public double DaysAbsent, GrossSalary, Deduction,Paye, NetSalary, TheAbsentDays;
        public void NetDeduction()
        {
            if (daysWorkedTextBox.Text != "")
            {
                DaysWorked = double.Parse(daysWorkedTextBox.Text);
                DaysAbsent = double.Parse(absentDaysTextBox.Text);
                GrossSalary = double.Parse(grossSalaryTextBox.Text);
                Paye = double.Parse(payeLabel.Text);
                TheAbsentDays = GrossSalary / 30 * DaysAbsent;
                Deduction = Paye + TheAbsentDays;
                NetSalary = GrossSalary - Deduction;
                dlabel.Text = Deduction.ToString("#,##0.00");
                netSalaryTextBox.Text = NetSalary.ToString("#,##0.00");
            }
            else 
            {
                netSalaryTextBox.Text = "";
            }
        }

        private void printbutton_MouseEnter(object sender, EventArgs e)
        {
            PrintI();
        }

        private void staffIDTextBox_Leave(object sender, EventArgs e)
        {
        }

        public void GetPaye()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM EmployeeBiodata WHERE Id = '" + staffIDTextBox.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                payeLabel.Text = dr["Paye"].ToString();
            }
            connection.Close();
        }

        private void staffIDTextBox_TextChanged(object sender, EventArgs e)
        {
           GetPaye();
        }

        private void accountNumberTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void salaryPeriodTextBox_TextChanged(object sender, EventArgs e)
        {
        }
       
        private void accountNumberTextBox_ControlRemoved(object sender, ControlEventArgs e)
        {
            LengthChecker();
        }
       

        private void accountNumberTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            LengthChecker();
        }

        private void accountNumberTextBox_MouseLeave(object sender, EventArgs e)
        {
            LengthChecker();
        }

        public int Days;
        private void absentDaysTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Days = int.Parse(absentDaysTextBox.Text);
                if (Days > 0)
                {
                    deductionTextBox.Text = @" TRUE";
                }
                else
                {
                    deductionTextBox.Text = @" FALSE";
                }
            }
            catch (Exception)
            {
                //ignore
            }
        }

        private void accountNumberTextBox_MouseUp(object sender, MouseEventArgs e)
        {
            LengthChecker();
        }

        private void accountNumberTextBox_CursorChanged(object sender, EventArgs e)
        {
            LengthChecker();
        }

        private void accountNumberTextBox_Leave(object sender, EventArgs e)
        {
            LengthChecker();
        }

        public double MaxDays, DaysWorked, AbsentDays;
        private void daysWorkedTextBox_TextChanged(object sender, EventArgs e)
        {
               if (daysWorkedTextBox.Text != "")
                {
                    MaxDays = double.Parse(maxDaysLabel.Text);
                    DaysWorked = double.Parse(daysWorkedTextBox.Text);
                    if (MaxDays >= DaysWorked)
                    {
                        AbsentDays = MaxDays - DaysWorked;
                        absentDaysTextBox.Text = AbsentDays.ToString(CultureInfo.CurrentCulture);
                        NetDeduction();
                    }
                    else
                    {
                        MessageBox.Show(@"Days Worked cannot be more than Maximum Days Worked");
                    }
                }
                else
                {
                    absentDaysTextBox.Text = "";
                    deductionTextBox.Text = "";
                }
            }
        }
    }
