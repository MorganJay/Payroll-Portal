using System;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PersonnelLogin
{
    public partial class StatutoryDeduction : Form
    {
        public StatutoryDeduction()
        {
            InitializeComponent();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
        }

        public SqlConnection Con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");

        private void StatutoryDeduction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logInDataSet6.SystemDefaults' table. You can move, or remove it, as needed.
            systemDefaultsTableAdapter.Fill(logInDataSet6.SystemDefaults);
            // TODO: This line of code loads data into the 'statutoryDataSet5.StatutoryDeduction' table. You can move, or remove it, as needed.
            statutoryDeductionTableAdapter.Fill(statutoryDataSet5.StatutoryDeduction);
            ActiveControl = topbutton;
            Stringformat();
            LengthChecker();
        }
        
        public void Readonly()
        {
            topbutton.Enabled = true;
            previousbutton.Enabled = true;
            nextbutton.Enabled = true;
            bottombutton.Enabled = true;
            printbutton.Enabled = true;
            deletebutton.Enabled = true;
            exitbutton.Enabled = true;
            savebutton.Visible = false;
            cancelbutton.Visible = false;
            statutoryTypeIDTextBox.ReadOnly = true;
            descriptionTextBox.ReadOnly = true;
            staffIDTextBox.ReadOnly = true;
            pFAIdTextBox.ReadOnly = true;
            pFAAccountNumberTextBox.ReadOnly = true;
            amount1TextBox.ReadOnly = true;
            amount2TextBox.ReadOnly = true;
        }
        public void PrintI()
        {
            DateTime timeofDay = DateTime.Now;
            textBox3.Text = "";
            textBox3.AppendText(" " + Environment.NewLine);
            textBox3.AppendText("\t\t\t\t    " + companyNameTextBox.Text + Environment.NewLine);
            textBox3.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox3.AppendText("\t\t\t\t\t" + label1.Text + Environment.NewLine);
            textBox3.AppendText(Environment.NewLine);

            textBox3.AppendText("  Statutory Type ID: " + "\t\t" + statutoryTypeIDTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Description: " + "\t\t\t" + descriptionTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Employee ID: " + "\t\t\t" + staffIDTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  PFA ID: " + "\t\t\t\t" + pFAIdTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  PFA Account Number: " + "\t\t" + pFAAccountNumberTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Amount 1: " + "\t\t\tNGN " + amount1TextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Amount 2: " + "\t\t\tNGN " + amount2TextBox.Text + Environment.NewLine);

            textBox3.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox3.AppendText("\t\t\t\t\t\t\t\t\t               " + timeofDay.ToString("dd-MM-yyyy HH:mm:ss") + Environment.NewLine);
        }

        public void Stringformat()
        {
            if (!string.IsNullOrEmpty(amount1TextBox.Text) || !string.IsNullOrEmpty(amount2TextBox.Text))
            {
                amount1TextBox.Text = string.Format("{0:#,##0.00}", double.Parse(amount1TextBox.Text));
                amount2TextBox.Text = string.Format("{0:#,##0.00}", double.Parse(amount2TextBox.Text));
            }
            else
            {
                amount1TextBox.Text = @"0.00";
                amount2TextBox.Text = @"0.00";
            }
        }

        private void staffIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void pFAAccountNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void amount1TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void amount2TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        public void RefreshStuff()
        {
            statutoryDeductionBindingSource.ResetBindings(true);
        }

        public long Textbox;
        public void LengthChecker()
        {
            var chars = pFAAccountNumberTextBox.Text.Length;
            if (chars < 10)
            {
                try
                {
                    Textbox = long.Parse(pFAAccountNumberTextBox.Text);
                    pFAAccountNumberTextBox.Text = string.Format("{0,10:D10}", Textbox);
                }
                catch (Exception)
                {
                    //Ignore
                }
            }
        }
        private void topbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            statutoryDeductionBindingSource.MoveFirst();
            Fill();
           topbutton.Enabled = false;
            previousbutton.Enabled = false;
            bottombutton.Enabled = true;
            nextbutton.Enabled = true;
            Stringformat();
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            statutoryDeductionBindingSource.MovePrevious();
            Fill();
            nextbutton.Enabled = true;
            bottombutton.Enabled = true;
            Stringformat();
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            statutoryDeductionBindingSource.MoveNext();
           Fill();
            previousbutton.Enabled = true;
            topbutton.Enabled = true;
            Stringformat();
        }

        private void bottombutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            statutoryDeductionBindingSource.MoveLast();
            Fill();
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
            topbutton.Enabled = true;
            previousbutton.Enabled = true;
            Stringformat();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            statutoryDeductionBindingSource.AddNew();
            statutoryTypeIDTextBox.ReadOnly = false;
            staffIDTextBox.ReadOnly = false;
            pFAIdTextBox.ReadOnly = false;
            pFAAccountNumberTextBox.ReadOnly = false;
            amount1TextBox.ReadOnly = false;
            amount2TextBox.ReadOnly = false;
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
            statutoryTypeIDTextBox.ReadOnly = false;
            staffIDTextBox.ReadOnly = false;
            pFAIdTextBox.ReadOnly = false;
            pFAAccountNumberTextBox.ReadOnly = false;
            amount1TextBox.ReadOnly = false;
            amount2TextBox.ReadOnly = false;
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
           if (statutoryTypeIDTextBox.Text == "" || staffIDTextBox.Text == "" || pFAIdTextBox.Text =="" || pFAAccountNumberTextBox.Text == "")
            {
                MessageBox.Show(@"Please fill all the fields", @"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var cmd = new SqlCommand("SELECT * FROM StatutoryDeduction WHERE StatutoryTypeID = '" + statutoryTypeIDTextBox.Text + "'",
                    Con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Con.Open();
                    cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE StatutoryDeduction SET StaffID = '" + staffIDTextBox.Text +
                                      "',Amount1 = '" +
                                     amount1TextBox.Text + "',Amount2 = '" + amount2TextBox.Text + "'," +
                                      "PFAId = '" + pFAIdTextBox.Text + "', PFAAccountNumber = '" + pFAAccountNumberTextBox.Text + "' WHERE StatutoryTypeID = '" +
                                      statutoryTypeIDTextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    Readonly();
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "INSERT INTO StatutoryDeduction (StatutoryTypeID,StaffID,Amount1,Amount2,PFAId,PFAAccountNumber)" +
                            "VALUES ('" + statutoryTypeIDTextBox.Text + "','" + staffIDTextBox.Text + "', '" + amount1TextBox.Text +
                            "','" + amount2TextBox.Text + "','" + pFAIdTextBox.Text + "','" + pFAAccountNumberTextBox.Text + "')";
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
            LengthChecker();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            statutoryDeductionBindingSource.CancelEdit();
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
                StatutoryReport ss = new StatutoryReport();
                ss.Show();
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to delete this record?", @"Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            Con.Open();
            string query = "DELETE FROM StatutoryDeduction WHERE StatutoryTypeID = '" + statutoryTypeIDTextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            sda.SelectCommand.ExecuteNonQuery();
            DataTable data = new DataTable();
            sda.Fill(data);
            Con.Close();
            statutoryDeductionBindingSource.RemoveCurrent();
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
            Validation();
            LengthChecker();
        }

        private void printbutton_MouseEnter(object sender, EventArgs e)
        {
           PrintI();
        }

        private void staffIDTextBox_Leave(object sender, EventArgs e)
        {
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
            else if (pFAIdTextBox.Text != "")
            {
                var cmd = new SqlCommand("SELECT * FROM PFATable WHERE PFAId = '" + pFAIdTextBox.Text + "'", Con);
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                }
                else
                {
                    MessageBox.Show(@"INVALID PFA ID");
                }
            }
        }

        private void pFAIdTextBox_Leave(object sender, EventArgs e)
        {
        }

        private void pFAAccountNumberTextBox_Leave(object sender, EventArgs e)
        {
        }

        public void Fill()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
            connection.Open();
            var cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM PFATable WHERE PFAId = '" + pFAIdTextBox.Text + "'";
            cmd.ExecuteNonQuery();
            var dt = new DataTable();
            var sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                pFAAccountNumberTextBox.Text = dr["PFAAccount"].ToString();
            }
            connection.Close();
            LengthChecker();
        }

        private void pFAIdTextBox_TextChanged(object sender, EventArgs e)
        {
            var cmd = new SqlCommand("SELECT * FROM PFATable WHERE PFAId = '" + pFAIdTextBox.Text + "'", Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                Con.Open();
                cmd = Con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM PFATable WHERE PFAId = '" + pFAIdTextBox.Text + "'";
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    pFAAccountNumberTextBox.Text = dr["PFAAccount"].ToString();
                }
                Con.Close();
            }
            else
            {
                pFAAccountNumberTextBox.Clear();
            }
        }
    }
}
