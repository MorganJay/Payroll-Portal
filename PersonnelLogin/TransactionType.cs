using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace PersonnelLogin
{
    public partial class TransactionType : Form
    {
        public TransactionType()
        {
            InitializeComponent();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
        }

        public SqlConnection Con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
       
        private void TransactionType_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'systemDefaultsDataSet.SystemDefaults' table. You can move, or remove it, as needed.
            systemDefaultsTableAdapter1.Fill(systemDefaultsDataSet.SystemDefaults);
            // TODO: This line of code loads data into the 'transactionTypeDataSet.TransactionType' table. You can move, or remove it, as needed.
            transactionTypeTableAdapter1.Fill(transactionTypeDataSet.TransactionType);
            ActiveControl = topbutton;
        }

        private void transactionDescTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char) Keys.Back;
            }
        }

        private void employerRateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char) Keys.Back;
            }
        }

        private void employeeRateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char) Keys.Back;
            }
        }

        private void deductionComboBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void calculatedComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char) Keys.Back;
            }
        }

        public void Readonly()
        {
           transactionIDTextBox.ReadOnly = true;
             transactionDescTextBox.ReadOnly = true;
             deductionComboBox.Enabled = false;
            employerRateTextBox.ReadOnly = true;
            statutoryComboBox.Enabled = false;
            employeeRateTextBox.ReadOnly = true;
            calculatedComboBox.Enabled = false;
            amountTextBox.ReadOnly = true;
            topbutton.Enabled = true;
            previousbutton.Enabled = true;
            deletebutton.Enabled = true;
            exitbutton.Enabled = true;
            savebutton.Visible = false;
            PrintI();
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
            textBox3.AppendText("\t\t\t\t " + label1.Text + Environment.NewLine);
            textBox3.AppendText(Environment.NewLine);

            textBox3.AppendText("  ID: " + "\t\t\t" + transactionIDTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Description: " + "\t\t" + transactionDescTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Deduction: " + "\t\t" + deductionComboBox.Text + Environment.NewLine);
            textBox3.AppendText("  Statutory: " + "\t\t" + statutoryComboBox.Text + Environment.NewLine);
            textBox3.AppendText("  Employer Rate: " + "\t\tNGN " + employerRateTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Employee Rate: " + "\t\tNGN " + employeeRateTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Calculated: " + "\t\t" +calculatedComboBox.Text + Environment.NewLine);
            textBox3.AppendText("  Amount: " + "\t\tNGN " + amountTextBox.Text + Environment.NewLine);

            textBox3.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox3.AppendText("\t\t\t\t\t\t\t\t\t               " + timeofDay.ToString("dd-MM-yyyy HH:mm:ss") + Environment.NewLine);
        }

        public void Stringformat()
        {
            try
            {
                if (!string.IsNullOrEmpty(employerRateTextBox.Text) ||
                    !string.IsNullOrEmpty(employeeRateTextBox.Text) || !string.IsNullOrEmpty(amountTextBox.Text))
                {
                    employerRateTextBox.Text = string.Format("{0:#,##0.00}", double.Parse(employerRateTextBox.Text));
                    employeeRateTextBox.Text = string.Format("{0:#,##0.00}", double.Parse(employeeRateTextBox.Text));
                    amountTextBox.Text = string.Format("{0:#,##0.00}", double.Parse(amountTextBox.Text));
                }
                else
                {
                    employerRateTextBox.Text = @"0.00";
                    employeeRateTextBox.Text = @"0.00";
                    amountTextBox.Text = @"0.00";
                }
            }
            catch (Exception)
            {
                //Ignore
            }
        }
        public void RefreshStuff()
        {
            transactionTypeBindingSource1.ResetBindings(true);
        }

        private void topbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            transactionTypeBindingSource1.MoveFirst();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            bottombutton.Enabled = true;
            nextbutton.Enabled = true;
            Stringformat();
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            transactionTypeBindingSource1.MovePrevious();
            nextbutton.Enabled = true;
            bottombutton.Enabled = true;
            Stringformat();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            transactionTypeBindingSource1.MoveNext();
            previousbutton.Enabled = true;
            topbutton.Enabled = true;
            Stringformat();
        }

        private void bottombutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            transactionTypeBindingSource1.MoveLast();
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
            topbutton.Enabled = true;
            previousbutton.Enabled = true;
            Stringformat();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            transactionTypeBindingSource1.AddNew();
            employerRateTextBox.ReadOnly = false;
            transactionIDTextBox.ReadOnly = false;
            employeeRateTextBox.ReadOnly = false;
            amountTextBox.ReadOnly = false;
            deductionComboBox.Text = @"-SELECT-";
            statutoryComboBox.Text = @"-SELECT-";
            calculatedComboBox.Text = @"-SELECT-";
            deductionComboBox.Enabled = true;
            statutoryComboBox.Enabled = true;
            calculatedComboBox.Enabled = true;
            transactionDescTextBox.ReadOnly = false;
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
            transactionIDTextBox.ReadOnly = false;
            transactionDescTextBox.ReadOnly = false;
            employerRateTextBox.ReadOnly = false;
            employeeRateTextBox.ReadOnly = false;
            deductionComboBox.Enabled = true;
            statutoryComboBox.Enabled = true;
            calculatedComboBox.Enabled = true;
            amountTextBox.ReadOnly = false;
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

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (transactionIDTextBox.Text == "" || transactionDescTextBox.Text == "" || deductionComboBox.Text == @"-SELECT-" || 
                statutoryComboBox.Text == @"-SELECT-" || calculatedComboBox.Text == @"-SELECT-")
            { 
                MessageBox.Show(@"Please Fill All Fields", @"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var cmd = new SqlCommand("SELECT * FROM TransactionType WHERE TransactionID = '" + transactionIDTextBox.Text + "'", Con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Con.Open();
                    cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE TransactionType SET TransactionDesc = '" + transactionDescTextBox.Text + "'," +
                                      "Deduction = '" +deductionComboBox.Text + "',Statutory = '" + statutoryComboBox.Text + "', " +
                                      "EmployerRate = '" + employerRateTextBox.Text + "'," +"EmployeeRate = '" + employeeRateTextBox.Text + "'," +
                                      "Calculated  = '" + calculatedComboBox.Text + "',Amount = '" + amountTextBox.Text + "' WHERE  TransactionID = '" + transactionIDTextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    Transfer();
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query =
                            "INSERT INTO TransactionType (TransactionID,TransactionDesc,Deduction,Statutory,EmployerRate,EmployeeRate,Calculated,Amount)" +
                            "VALUES ('" + transactionIDTextBox.Text + "','" + transactionDescTextBox.Text + "', '" +
                            deductionComboBox.Text +
                            "','" + statutoryComboBox.Text + "','" + employerRateTextBox.Text + "','" +
                            employeeRateTextBox.Text + "'," +
                            "'" + calculatedComboBox.Text + "','" + amountTextBox.Text + "')";
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
                    finally
                    {
                        Transfer();
                    }
                }
                Readonly();
            }
        }
        public void Transfer()
        {
            try
            {
                Con.Open();
                var query = "INSERT INTO StatutoryDeduction (StatutoryTypeID,Description) " +
                              "SELECT TransactionID,TransactionDesc FROM TransactionType " +
                               "WHERE Statutory = '"+statutoryComboBox.Text +"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                sda.SelectCommand.ExecuteNonQuery();
                DataTable data = new DataTable();
                sda.Fill(data);
                Con.Close();
            }
            catch (Exception)
            {
                //Ignore
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            transactionTypeBindingSource1.CancelEdit();
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
                TransactionReport ss = new TransactionReport();
                ss.Show();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox3.Text, new Font("Segoe UI Emoji", 12), Brushes.Black, 1, 1);
        }

        private void printbutton_MouseEnter(object sender, EventArgs e)
        {
            Stringformat();
            PrintI();
        }

        private void savebutton_MouseEnter(object sender, EventArgs e)
        {
            Stringformat();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to delete this record?", @"Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            Con.Open();
            string query = "DELETE FROM TransactionType WHERE TransactionID = '" +transactionIDTextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            sda.SelectCommand.ExecuteNonQuery();
            DataTable data = new DataTable();
            sda.Fill(data);
            Con.Close();
            transactionTypeBindingSource1.RemoveCurrent();
            Readonly();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
