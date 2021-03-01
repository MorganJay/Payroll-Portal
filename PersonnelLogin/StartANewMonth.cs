using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PersonnelLogin
{
    public partial class StartANewMonth : Form
    {
       public StartANewMonth()
        {
            InitializeComponent();
            ActiveControl = button1;
        }

        public SqlConnection Con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
        public SqlCommand Cmd;

        public void DaysDifference()
        {
            DateTime startDate = dateTimePicker1.Value.Date;
            DateTime endDate = dateTimePicker2.Value.Date;

            TimeSpan timeSpan = endDate - startDate;
            
            int days = timeSpan.Days;
            textBox2.Text = days.ToString();
        }
         
        public void Transfer()
        {
            try
            {
                Con.Open();
                const string query = "INSERT INTO PayrollTable (StaffID,GrossSalary,BankCode,AccountNumber,OtherAllowance,BasicSalary,HousingAllowance,TransportationAllowance) " +
                                     "SELECT Id,GrossSalary,BankCode,AccountNumber,OtherAllowances,BasicSalary,HousingAllowance,TransportationAllowance FROM View_PayEmpJob " +
                                     "WHERE DateEmployed <= SalaryEndDate";
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
            finally
            {
                SalaryPeriod();
                MessageBox.Show(@"Payroll Table Updated!", @"", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Hide();
        }

        public void Delete()
        {
            Con.Open();
            const string query = "TRUNCATE TABLE PayrollTable";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            sda.SelectCommand.ExecuteNonQuery();
            DataTable data = new DataTable();
            sda.Fill(data);
            Con.Close();
        }

        public void SalaryPeriod()
        {
            SqlConnection con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE PayrollTable SET SalaryPeriod = '" + textBox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date > DateTime.Now)
            {
                MessageBox.Show(@"Start Date cannot be a future date", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (dateTimePicker2.Value.Date < dateTimePicker1.Value.Date)
            {
                MessageBox.Show(@"End Date cannot be less than Start Date", "", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                var cmd = new SqlCommand("SELECT * FROM PayrollTable", Con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    if(MessageBox.Show(@"This process has been done before, repeating this process might cause data loss (attendance log). Are you sure you want to continue?",
                                       @"Payroll Table", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        Delete();
                        Transfer();
                    }
                }
                else
               {
                   Transfer();
               }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            Close();
        }

        private void StartANewMonth_Load(object sender, EventArgs e)
        {
            //TODO: This line of code loads data into the 'systemDefaultsDataSet.SystemDefaults' table. You can move, or remove it, as needed.
            systemDefaultsTableAdapter.Fill(systemDefaultsDataSet.SystemDefaults);
            DaysDifference();
            textBox.Text = dateTimePicker1.Value.ToString("MMM, yyyy");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date > DateTime.Now)
            {
                MessageBox.Show(@"Start Date cannot be a future date", "", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                textBox2.Clear();
            }
            else if (dateTimePicker2.Value.Date < dateTimePicker1.Value.Date)
            {
                MessageBox.Show(@"End Date cannot be less than Start Date", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox2.Clear();
            }
            else
            {
                DaysDifference();
                textBox.Text = dateTimePicker1.Value.ToString("MMM, yyyy");
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DaysDifference();
        }
    }
}
