using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;

namespace PersonnelLogin
{
    public partial class PayrollTransaction : Form
    {
        public PayrollTransaction()
        {
            InitializeComponent();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
        }

        public SqlConnection Con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
        public SqlCommand Cmd;

        public static CultureInfo CurrentCulture { get; set; }
        private void PayrollTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pTDataSet.PayrollTransaction' table. You can move, or remove it, as needed.
            payrollTransactionTableAdapter.Fill(pTDataSet.PayrollTransaction);
            // TODO: This line of code loads data into the 'systemDefaultsDataSet.SystemDefaults' table. You can move, or remove it, as needed.
            systemDefaultsTableAdapter.Fill(systemDefaultsDataSet.SystemDefaults);
            ActiveControl = topbutton;
            DateTime date = DateTime.Now;
            transactionDateTimeDateTimePicker.Text = date.ToShortDateString();
            ComboFill();
        }

        private void principalTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void rateTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void balanceLabel_Click(object sender, EventArgs e)
        {
        }

        private void balanceTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void principalLabel_Click(object sender, EventArgs e)
        {
        }

        private void rateLabel_Click(object sender, EventArgs e)
        {
        }

        private void transactionDateTimeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
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

        private void deductioncomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void statutoryComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void principalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void rateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void balanceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        public void Stringformat()
        {
            if (!string.IsNullOrEmpty(balanceTextBox.Text) || !string.IsNullOrEmpty(principalTextBox.Text) || !string.IsNullOrEmpty(rateTextBox.Text))
            {
                balanceTextBox.Text = string.Format("{0:#,##0.00}", double.Parse(balanceTextBox.Text));
                principalTextBox.Text = string.Format("{0:#,##0.00}", double.Parse(principalTextBox.Text));
                rateTextBox.Text = string.Format("{0:#,##0.00}", double.Parse(rateTextBox.Text));
            }
            else
            {
                balanceTextBox.Text = @"0.00";
                principalTextBox.Text = @"0.00";
                rateTextBox.Text = @"0.00";
            }
        }
        public void ComboFill()
        {
            Con.Open();
            Cmd = Con.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT * FROM TransactionType";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["TransactionID"].ToString());
            }
            Con.Close();
        }
        public void Readonly()
        {
            staffIDTextBox.ReadOnly = true;
            deductioncomboBox.Enabled = false;
            principalTextBox.ReadOnly = true;
            statutoryComboBox.Enabled = false;
            comboBox1.Enabled = false;
            rateTextBox.ReadOnly = true;
            balanceTextBox.ReadOnly = true;
            topbutton.Enabled = true;
            previousbutton.Enabled = true;
            deletebutton.Enabled = true;
            exitbutton.Enabled = true;
            savebutton.Visible = false;
            cancelbutton.Visible = false;
            printbutton.Enabled = true;
            nextbutton.Enabled = true;
            bottombutton.Enabled = true;
        }

        public void PrintI()
        {
            DateTime timeofDay = DateTime.Now;
            textBox3.Text = "";
            textBox3.AppendText(" " + Environment.NewLine);
            textBox3.AppendText("\t\t\t\t    " + companyNameTextBox.Text + Environment.NewLine);
            textBox3.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox3.AppendText("\t\t\t\t       " + label1.Text + Environment.NewLine);
            textBox3.AppendText(Environment.NewLine);

            textBox3.AppendText("  Employee ID: " + "\t\t" + staffIDTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Transaction ID: " + "\t\t" + comboBox1.Text + Environment.NewLine);
            textBox3.AppendText("  Deduction: " + "\t\t" + deductioncomboBox.Text + Environment.NewLine);
            textBox3.AppendText("  Statutory: " + "\t\t" + statutoryComboBox.Text + Environment.NewLine);
            textBox3.AppendText("  Principal: " + "\t\tNGN" + principalTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Rate: " + "\t\t\tNGN" + rateTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Balance: " + "\t\tNGN" + balanceTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Transaction DateTime: " + "\t" + transactionDateTimeDateTimePicker.Text + Environment.NewLine);

            textBox3.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox3.AppendText("\t\t\t\t\t\t\t\t\t         " + timeofDay.ToString("dd-MM-yyyy HH:mm:ss") + Environment.NewLine);
        }

        public void RefreshStuff()
        {
            payrollTransactionBindingSource.ResetBindings(true);
        }

        private void topbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
           payrollTransactionBindingSource.MoveFirst();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            bottombutton.Enabled = true;
            nextbutton.Enabled = true;
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            payrollTransactionBindingSource.MovePrevious();
            nextbutton.Enabled = true;
            bottombutton.Enabled = true;
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            payrollTransactionBindingSource.MoveNext();
            previousbutton.Enabled = true;
            topbutton.Enabled = true;
        }

        private void bottombutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            payrollTransactionBindingSource.MoveLast();
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
            topbutton.Enabled = true;
            previousbutton.Enabled = true;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            payrollTransactionBindingSource.AddNew();
            staffIDTextBox.ReadOnly = false;
            principalTextBox.ReadOnly = false;
            rateTextBox.ReadOnly = false;
            deductioncomboBox.Text = @"-SELECT-";
            statutoryComboBox.Text = @"-SELECT-";
            comboBox1.Text = @"-SELECT-";
            deductioncomboBox.Enabled = true;
            statutoryComboBox.Enabled = true;
            comboBox1.Enabled = true;
            transactionDateTimeDateTimePicker.Enabled = true;
            balanceTextBox.ReadOnly = false;
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            printbutton.Enabled = false;
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
            deletebutton.Enabled = false;
            exitbutton.Enabled = false;
            savebutton.Visible = true;
            cancelbutton.Visible = true;
            Stringformat();
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            staffIDTextBox.ReadOnly = false;
            principalTextBox.ReadOnly = false;
            rateTextBox.ReadOnly = false;
            deductioncomboBox.Enabled = true;
            statutoryComboBox.Enabled = true;
            transactionDateTimeDateTimePicker.Enabled = true;
            balanceTextBox.ReadOnly = false;
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
            deletebutton.Enabled = false;
            printbutton.Enabled = false;
            exitbutton.Enabled = false;
            savebutton.Visible = true;
            cancelbutton.Visible = true;
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
                PayrollTransactionReport ss = new PayrollTransactionReport();
                ss.Show();
            }
       }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to delete this record?", @"Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            Con.Open();
            string query = "DELETE FROM PayrollTransaction WHERE StaffID = '" + staffIDTextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            sda.SelectCommand.ExecuteNonQuery();
            DataTable data = new DataTable();
            sda.Fill(data);
            Con.Close();
            payrollTransactionBindingSource.RemoveCurrent();
            Readonly();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printbutton_MouseEnter(object sender, EventArgs e)
        {
            PrintI();
        }

        public void Validation()
        {
            if (staffIDTextBox.Text != "")
            {
               var cmd = new SqlCommand("SELECT * FROM EmployeeBiodata WHERE Id = '" + staffIDTextBox.Text + "'", Con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                }
                else
                {
                    MessageBox.Show(@"INVALID EMPLOYEE ID");
                }
            }
         }

        public double Rate, Principal;
        public void Pr()
        {
           Rate = double.Parse(rateTextBox.Text);
            Principal = double.Parse(principalTextBox.Text);
            if (Rate > Principal)
            {
                MessageBox.Show(@"RATE CANNOT BE GREATER THAN PRINCIPAL", "", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void savebutton_MouseEnter(object sender, EventArgs e)
        {
            Validation();
            Stringformat();
            Pr();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == @"-SELECT-" || staffIDTextBox.Text == "" || deductioncomboBox.Text == @"-SELECT-" ||
                statutoryComboBox.Text == @"-SELECT-")
            {
                MessageBox.Show(@"Please Fill All Fields", @"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (Rate > Principal)
            {
                MessageBox.Show(@"RATE CANNOT BE GREATER THAN PRINCIPAL", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var cmd = new SqlCommand(
                    "SELECT * FROM PayrollTransaction WHERE StaffID = '" + staffIDTextBox.Text + "'", Con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Con.Open();
                    cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE PayrollTransaction SET TransactionID = '" + comboBox1.Text +
                                      "',TransactionDateTime = '" + transactionDateTimeDateTimePicker.Text + "'," +
                                      "Deduction = '" + deductioncomboBox.Text + "',Principal = '" +
                                      principalTextBox.Text + "', Rate = '" + rateTextBox.Text + "'," +
                                      "Balance  = '" + balanceTextBox.Text + "',Statutory = '" +
                                      statutoryComboBox.Text + "' WHERE StaffID = '" + staffIDTextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    Con.Close();
                }
                else
                { 
                    try
                    {
                        Con.Open();
                        var query = "INSERT INTO PayrollTransaction (StaffID,TransactionID,TransactionDateTime,Deduction,Principal,Rate,Balance,Statutory)" +
                            "VALUES ('" + staffIDTextBox.Text + "','" + comboBox1.Text + "', '" +
                            transactionDateTimeDateTimePicker.Text +
                            "','" + deductioncomboBox.Text + "','" + principalTextBox.Text + "','" + rateTextBox.Text +
                            "'," + "'" + balanceTextBox.Text + "'," +
                            "'" + statutoryComboBox.Text + "')";
                        SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                        sda.SelectCommand.ExecuteNonQuery();
                        DataTable data = new DataTable();
                        sda.Fill(data);
                        Con.Close();
                    }
                    catch (Exception)
                    {
                        //ignore
                    }
                }
                Readonly();
            }
            ActiveControl = addbutton;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            payrollTransactionBindingSource.CancelEdit();
            Readonly();
            Stringformat();
            comboBox1.ResetText();
            ActiveControl = printbutton;
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox3.Text, new Font("Segoe UI Emoji", 12), Brushes.Black, 1, 1);
        }
    }
}
