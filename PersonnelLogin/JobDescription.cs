using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;


namespace PersonnelLogin
{
    public partial class JobDescription : Form
    {
        public JobDescription()
        {
            InitializeComponent();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            Stringformat();
        }
        public SqlConnection Con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
        private SqlCommand _cmd;

     private void JobDescription_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logInDataSet6.SystemDefaults' table. You can move, or remove it, as needed.
            systemDefaultsTableAdapter.Fill(logInDataSet6.SystemDefaults);
            // TODO: This line of code loads data into the 'jobDataSet4.JobDescription' table. You can move, or remove it, as needed.
            jobDescriptionTableAdapter.Fill(jobDataSet4.JobDescription);
            ActiveControl = topbutton;
            Stringformat();
        }

        public void Readonly()
        {
            descriptiontextBox.ReadOnly = true;
            housingtextBox.ReadOnly = true;
            basicsalarytextBox.ReadOnly = true;
            transporttextBox.ReadOnly = true;
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

        public void retrieveId()
        {
            try
            {
                const string query = "SELECT IDENT_CURRENT('JobDescription')";
                if (Con.State == ConnectionState.Closed)
                {
                    Con.Open();
                }
                SqlCommand cmd = new SqlCommand(query, Con);
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                sda.SelectCommand.ExecuteNonQuery();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int value = int.Parse(reader[0].ToString()) + 1;
                    codetextBox.Text = value.ToString();
                }
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
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

            textBox3.AppendText("  Code: " + "\t\t\t\t" + codetextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Description: " + "\t\t\t" + descriptiontextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Basic Salary: " + "\t\t\tNGN" + basicsalarytextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Housing Allowance: " + "\t\tNGN" + housingtextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Transportation Allowance: " + "\tNGN" + housingtextBox.Text + Environment.NewLine);

            textBox3.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox3.AppendText("\t\t\t\t\t\t\t\t\t               " + timeofDay.ToString("dd-MM-yyyy HH:mm:ss") + Environment.NewLine);
        }

        public void Stringformat()
        {
            try
            {
                if (!string.IsNullOrEmpty(basicsalarytextBox.Text) || !string.IsNullOrEmpty(housingtextBox.Text) ||
                    !string.IsNullOrEmpty(transporttextBox.Text))
                {
                    basicsalarytextBox.Text = string.Format("{0:#,##0.00}", double.Parse(basicsalarytextBox.Text));
                    housingtextBox.Text = string.Format("{0:#,##0.00}", double.Parse(housingtextBox.Text));
                    transporttextBox.Text = string.Format("{0:#,##0.00}", double.Parse(transporttextBox.Text));
                }
                else
                {
                    basicsalarytextBox.Text = @"0.00";
                    housingtextBox.Text = @"0.00";
                    transporttextBox.Text = @"0.00";
                }
            }
            catch (Exception)
            {
                //ignore
            }
        }

        private void topbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            jobDescriptionBindingSource.MoveFirst();
            Stringformat();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            bottombutton.Enabled = true;
            nextbutton.Enabled = true;
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            jobDescriptionBindingSource.MovePrevious();
            Stringformat();
            nextbutton.Enabled = true;
            bottombutton.Enabled = true;
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            jobDescriptionBindingSource.MoveNext();
            RefreshStuff();
            Stringformat();
            previousbutton.Enabled = true;
            topbutton.Enabled = true;
        }

        private void bottombutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            jobDescriptionBindingSource.MoveLast();
            Stringformat();
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
            topbutton.Enabled = true;
            previousbutton.Enabled = true;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
           jobDescriptionBindingSource.AddNew();
            retrieveId();
            descriptiontextBox.ReadOnly = false;
            basicsalarytextBox.ReadOnly = false;
            housingtextBox.ReadOnly = false;
            transporttextBox.ReadOnly = false;
            printbutton.Enabled = false;
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
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
            descriptiontextBox.ReadOnly = false;
            basicsalarytextBox.ReadOnly = false;
            housingtextBox.ReadOnly = false;
            transporttextBox.ReadOnly = false;
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
            deletebutton.Enabled = false;
            exitbutton.Enabled = false;
            printbutton.Enabled = false;
            savebutton.Visible = true;
            cancelbutton.Visible = true;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (descriptiontextBox.Text == "")
            {
                MessageBox.Show(@"Please Fill THAT Field", @"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _cmd = new SqlCommand("SELECT * FROM JobDescription WHERE JobCode = '" + codetextBox.Text + "'", Con);
                SqlDataAdapter da = new SqlDataAdapter(_cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Con.Open();
                    _cmd = Con.CreateCommand();
                    _cmd.CommandType = CommandType.Text;
                    _cmd.CommandText = "UPDATE JobDescription SET JobDesc = '" + descriptiontextBox.Text + "',BasicSalary = '" +basicsalarytextBox.Text + "'," +
                                       "HousingAllowance = '" + housingtextBox.Text + "'," +"TransportationAllowance = '" + transporttextBox.Text + "'" +
                                       " WHERE JobCode = '"+codetextBox.Text + "'";
                    _cmd.ExecuteNonQuery();
                    Con.Close();
                    Readonly();
                }
                else
                {
                    Con.Open();
                    _cmd = Con.CreateCommand();
                    _cmd.CommandType = CommandType.Text;
                    _cmd.CommandText = "INSERT INTO JobDescription (JobDesc,BasicSalary,HousingAllowance,TransportationAllowance)"+
                                       "VALUES('" + descriptiontextBox.Text +"','"+ basicsalarytextBox.Text + "','" + housingtextBox.Text + "','" + transporttextBox.Text + "')";
                    _cmd.ExecuteNonQuery();
                    Con.Close();
                    Readonly();
                }
            }
        }

        public void RefreshStuff()
        {
            jobDescriptionBindingSource.ResetBindings(true);
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            jobDescriptionBindingSource.CancelEdit();
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
               JobDescriptionReport ss = new JobDescriptionReport();
                ss.Show();
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to delete this record?", @"Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            Con.Open();
            string query = "DELETE FROM JobDescription WHERE JobCode = '" + codetextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            sda.SelectCommand.ExecuteNonQuery();
            DataTable data = new DataTable();
            sda.Fill(data);
            Con.Close();
            jobDescriptionBindingSource.RemoveCurrent();
            Readonly();
            Stringformat();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void savebutton_MouseHover(object sender, EventArgs e)
        {
        }

        private void basicsalarytextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void housingtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void transporttextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void descriptiontextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox3.Text, new Font("Segoe UI Emoji", 12), Brushes.Black, 1, 1);
        }

        private void descriptiontextBox_TextChanged(object sender, EventArgs e)
        {
            }

        private void descriptiontextBox_Enter(object sender, EventArgs e)
        {
            basicsalarytextBox.Text = string.Format("{0:#,##0.00}", double.Parse(basicsalarytextBox.Text));
            housingtextBox.Text = string.Format("{0:#,##0.00}", double.Parse(housingtextBox.Text));
            transporttextBox.Text = string.Format("{0:#,##0.00}", double.Parse(transporttextBox.Text));
        }

        private void savebutton_MouseEnter(object sender, EventArgs e)
        {
            Stringformat();
        }

        private void printbutton_MouseEnter(object sender, EventArgs e)
        {
            Stringformat();
            PrintI();
        }

        private void basicsalarytextBox_MouseLeave(object sender, EventArgs e)
        {
            basicsalarytextBox.Text = string.Format("{0:#,##0.00}", double.Parse(basicsalarytextBox.Text));
        }

        private void housingtextBox_MouseLeave(object sender, EventArgs e)
        {
            housingtextBox.Text = string.Format("{0:#,##0.00}", double.Parse(housingtextBox.Text));
        }

        private void transporttextBox_MouseLeave(object sender, EventArgs e)
        {
            transporttextBox.Text = string.Format("{0:#,##0.00}", double.Parse(transporttextBox.Text));
        }

        private void transporttextBox_CursorChanged(object sender, EventArgs e)
        {
            transporttextBox.Text = string.Format("{0:#,##0.00}", double.Parse(transporttextBox.Text));
        }

        private void housingtextBox_CursorChanged(object sender, EventArgs e)
        {
            housingtextBox.Text = string.Format("{0:#,##0.00}", double.Parse(housingtextBox.Text));
        }

        private void basicsalarytextBox_CursorChanged(object sender, EventArgs e)
        {
            basicsalarytextBox.Text = string.Format("{0:#,##0.00}", double.Parse(basicsalarytextBox.Text));
        }

        private void basicsalarytextBox_ControlRemoved(object sender, ControlEventArgs e)
        {
            basicsalarytextBox.Text = string.Format("{0:#,##0.00}", double.Parse(basicsalarytextBox.Text));
        }

        private void housingtextBox_Enter(object sender, EventArgs e)
        {
            basicsalarytextBox.Text = string.Format("{0:#,##0.00}", double.Parse(basicsalarytextBox.Text));
        }

        private void transporttextBox_Enter(object sender, EventArgs e)
        {
            housingtextBox.Text = string.Format("{0:#,##0.00}", double.Parse(housingtextBox.Text));
        }
    }
}

