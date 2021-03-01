using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonnelLogin
{
    public partial class SystemDefaults : Form
    {
        public SystemDefaults()
        {
            InitializeComponent();
        }
        
        private void SystemDefaults_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logInDataSet6.SystemDefaults' table. You can move, or remove it, as needed.
            systemDefaultsTableAdapter.Fill(logInDataSet6.SystemDefaults);
            ActiveControl = savebutton;
            savebutton.Enabled = false;
        }

        public void Readonly()
        {
            companyNameTextBox.ReadOnly = true;
            maxSalaryDaysTextBox.ReadOnly = true;
            salaryStartDateDateTimePicker.Enabled = false;
            salaryEndDateDateTimePicker.Enabled = false;
            exitbutton.Enabled = true;
            printbutton.Enabled = true;
            savebutton.Enabled = false;
            cancelbutton.Enabled = false;
            editbutton.Enabled = true;
            deletebutton.Enabled = true;
        }

        public void PrintI()
        {
            DateTime timeofDay = DateTime.Now;
            textBox3.AppendText("" + Environment.NewLine);
            textBox3.AppendText("\t\t\t\t         " + label1.Text + Environment.NewLine);
            textBox3.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox3.AppendText(Environment.NewLine);

            textBox3.AppendText("  Company Name: " + "\t\t" + companyNameTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Maximum Salary Days: " + "\t\t" + maxSalaryDaysTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Salary Start Date: " + "\t\t" + salaryStartDateDateTimePicker.Text + Environment.NewLine);
            textBox3.AppendText("  Salary End Date: " + "\t\t" + salaryEndDateDateTimePicker.Text + Environment.NewLine);

            textBox3.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox3.AppendText("\t\t\t\t\t\t\t\t\t         " + timeofDay.ToString("dd-MM-yyyy HH:mm:ss") + Environment.NewLine);
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            companyNameTextBox.ReadOnly = false;
            maxSalaryDaysTextBox.ReadOnly = false;
            salaryStartDateDateTimePicker.Enabled = true;
            salaryEndDateDateTimePicker.Enabled = true;
            printbutton.Enabled = false;
            exitbutton.Enabled = false;
            deletebutton.Enabled = false;
            cancelbutton.Enabled = true;
            editbutton.Enabled = false;
            savebutton.Enabled = true;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (companyNameTextBox.Text == "" || maxSalaryDaysTextBox.Text == "")
            {
                MessageBox.Show(@"Please Fill All Fields", @"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var cmd = new SqlCommand("SELECT * FROM SystemDefaults WHERE CompanyName = '" + companyNameTextBox.Text + "'", Con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Con.Open();
                    cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE SystemDefaults SET CompanyName = '" + companyNameTextBox.Text + "', MaxSalaryDays = '" + maxSalaryDaysTextBox.Text +
                                      "',SalaryStartDate = '" + salaryStartDateDateTimePicker.Text + "',SalaryEndDate = '" + salaryEndDateDateTimePicker.Text + "' WHERE CompanyName = '" + companyNameTextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    Con.Close();
                }
                else
                {
                    Con.Open();
                    var query = "INSERT INTO SystemDefaults (CompanyName,MaxSalaryDays,SalaryStartDate,SalaryEndDate)" +
                                "VALUES ('" + companyNameTextBox.Text + "','" + maxSalaryDaysTextBox.Text + "', '" +
                                 salaryStartDateDateTimePicker.Text + "','" + salaryEndDateDateTimePicker.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                    sda.SelectCommand.ExecuteNonQuery();
                    DataTable data = new DataTable();
                    sda.Fill(data);
                    Con.Close();
                }
                Readonly();
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            systemDefaultsBindingSource.CancelEdit();
            Readonly();
        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox3.Text, new Font("Segoe UI Emoji", 12), Brushes.Black, 1, 1);
        }

        public SqlConnection Con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to delete this record?", @"Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            Con.Open();
            string query = "DELETE FROM SystemDefaults WHERE CompanyName = '" + companyNameTextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            sda.SelectCommand.ExecuteNonQuery();
            DataTable data = new DataTable();
            sda.Fill(data);
            Con.Close();
            systemDefaultsBindingSource.RemoveCurrent();
            companyNameTextBox.Clear();
            maxSalaryDaysTextBox.Clear();
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
    }
}
