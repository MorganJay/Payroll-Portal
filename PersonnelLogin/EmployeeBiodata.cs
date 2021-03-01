using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;

namespace PersonnelLogin
{
    public partial class EmployeeBiodata : Form
    {
        public EmployeeBiodata()
        {
            InitializeComponent();
            LengthChecker();
        }
        public SqlConnection Con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
        public SqlCommand Cmd;
        public double GrossSalary, AnnualGross, TaxFreeAllowance, TaxableIncome, Paye, Bal;
        public static CultureInfo CurrentCulture { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logInDataSet6.SystemDefaults' table. You can move, or remove it, as needed.
            systemDefaultsTableAdapter.Fill(logInDataSet6.SystemDefaults);
            // TODO: This line of code loads data into the 'logInDataSet1.EmployeeBiodata' table. You can move, or remove it, as needed.
            employeeBiodataTableAdapter.Fill(logInDataSet1.EmployeeBiodata);
            if (MdiParent.Controls["departmentlabel"].Text != @"Admin")
            {
                button2.Visible = false;
            }
            FillId();
            Statefill();
            Fillcombo();
            fill_combo();
            Salaryfill();
            Readonly();
            Bankfill();
            Stringformat();
            LengthChecker();
            CalculateTax();
            firstbutton.Enabled = false;
            button3.Enabled = false;
            ActiveControl = firstbutton;
        }

        public void RetrieveId()
        {
            try
            {
                string query = "SELECT IDENT_CURRENT('EmployeeBiodata')";
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
                    textBox5.Text = value.ToString();
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

        public void Readonly()
        {
            emailtextBox.ReadOnly = true;
            surnametextBox.ReadOnly = true;
            othernametextBox.ReadOnly = true;
            phonenumbertextBox.ReadOnly = true;
            addresstextBox.ReadOnly = true;
            accountnumbertextBox.ReadOnly = true;
            dateEmployed.Enabled = false;
            dateTimePicker2.Enabled = false;
            othertextBox.Enabled = true;
            BCcomboBox.Enabled = false;
            jobcomboBox.Enabled = false;
            statecomboBox.Enabled = false;
            gendercomboBox.Enabled = false;
            maritalcomboBox.Enabled = false;
            departmentcomboBox.Enabled = false;
            button1.Enabled = false;
            cancelbutton.Enabled = false;
            button5.Enabled = true;
            othertextBox.ReadOnly = true;
            exitbutton.Enabled = true;
            LengthChecker();
        }

        public void Statefill()
        {
            Con.Open();
            Cmd = Con.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT * FROM States";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                statecomboBox.Items.Add(dr["State"].ToString());
            }
            Con.Close();
        }

        public void Fillcombo()
        {
            Con.Open();
            Cmd = Con.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT * FROM JobDescription";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                jobcomboBox.Items.Add(dr["JobDesc"].ToString());
            }
            Con.Close();
        }

        public void fill_combo()
        {
            Con.Open();
            Cmd = Con.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT * FROM Department";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                departmentcomboBox.Items.Add(dr["DeptName"].ToString());
            }
            Con.Close();
        }

        public void FillId()
        {
            var connection = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
            connection.Open();
            Cmd = connection.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT * FROM EmployeeBiodata WHERE Email = '" + emailtextBox.Text + "'";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                textBox5.Text = dr["Id"].ToString();
            }
            connection.Close();
         }

        public void Salaryfill()
        {
            Con.Open();
            Cmd = Con.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT * FROM JobDescription WHERE JobDesc = '" + jobcomboBox.Text + "'";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                salarytextBox.Text = dr["BasicSalary"].ToString();
                housingtextBox.Text = dr["HousingAllowance"].ToString();
                trasporttextBox.Text = dr["TransportationAllowance"].ToString();
                Stringformat();
            }
            Con.Close();
            Calculategrosssalary();
            CalculateTax();
        }

        public void Stringformat()
        {
            try
            {
                if (!string.IsNullOrEmpty(salarytextBox.Text) || !string.IsNullOrEmpty(housingtextBox.Text) ||
                    !string.IsNullOrEmpty(othertextBox.Text) || !string.IsNullOrEmpty(trasporttextBox.Text))
                {
                    salarytextBox.Text = string.Format("{0:#,##0.00}", double.Parse(salarytextBox.Text));
                    housingtextBox.Text = string.Format("{0:#,##0.00}", double.Parse(housingtextBox.Text));
                    trasporttextBox.Text = string.Format("{0:#,##0.00}", double.Parse(trasporttextBox.Text));
                    othertextBox.Text = string.Format("{0:#,##0.00}", double.Parse(othertextBox.Text));
                }
                else
                {
                    salarytextBox.Text = @"0.00";
                    housingtextBox.Text = @"0.00";
                    othertextBox.Text = @"0.00";
                    trasporttextBox.Text = @"0.00";
                }
            }
            catch (Exception)
            {
                //ignore
            }
        }

        public long Textbox;
        public void LengthChecker()
        {
            var chars = accountnumbertextBox.Text.Length;
            var num = phonenumbertextBox.Text.Length;
            if (chars < 10)
            {
                try
                {
                    Textbox = long.Parse(accountnumbertextBox.Text);
                    accountnumbertextBox.Text = string.Format("{0,10:D10}", Textbox);
                }
                catch (Exception)
                {
                    //Ignore
                }
            }
            else if (num < 11)
            {
                MessageBox.Show(@"PLEASE ENTER A VALID PHONE NUMBER");
            }
        }

        public void Calculategrosssalary()
        {
            try
            {
                if (!string.IsNullOrEmpty(othertextBox.Text))
                {
                    grossSalarytextBox.Text = (Convert.ToDouble(salarytextBox.Text) +
                                               Convert.ToDouble(housingtextBox.Text) +
                                               Convert.ToDouble(trasporttextBox.Text) +
                                               Convert.ToDouble(othertextBox.Text)).ToString("#,##0.00");
                }
                else
                {
                    grossSalarytextBox.Text = (Convert.ToDouble(salarytextBox.Text) +
                                               Convert.ToDouble(housingtextBox.Text) +
                                               Convert.ToDouble(trasporttextBox.Text)).ToString("#,##0.00");
                }
            }
            catch (Exception)
            {
                //Ignore
            }
        }

        public void Bankfill()
        {
            Con.Open();
            Cmd = Con.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT * FROM BankData";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                BCcomboBox.Items.Add(dr["BankCode"].ToString());
            }
            Con.Close();
        }

        public void RefreshStuff()
        {
            //employeeBiodataBindingSource.ResetBindings(true);
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            employeeBiodataBindingSource.MoveNext();
            //RefreshStuff();
            FillId();
            Calculategrosssalary();
            Stringformat();
            LengthChecker();
            firstbutton.Enabled = true;
            button3.Enabled = true;
            CalculateTax();
        }

        private void LASTbutton_Click(object sender, EventArgs e)
        {
            employeeBiodataBindingSource.MoveLast();
            //RefreshStuff();
            FillId();
            Calculategrosssalary();
            Stringformat();
            LengthChecker();
            LASTbutton.Enabled = false;
            nextbutton.Enabled = false;
            firstbutton.Enabled = true;
            button3.Enabled = true;
            CalculateTax();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            employeeBiodataBindingSource.MovePrevious();
            //RefreshStuff();
            FillId();
            Calculategrosssalary();
            Stringformat();
            LengthChecker();
            nextbutton.Enabled = true;
            LASTbutton.Enabled = true;
            CalculateTax();
        }

        private void firstbutton_Click(object sender, EventArgs e)
        {
            employeeBiodataBindingSource.MoveFirst();
            FillId();
            //RefreshStuff();
            Calculategrosssalary();
            firstbutton.Enabled = false;
            button3.Enabled = false;
            nextbutton.Enabled = true;
            LASTbutton.Enabled = true;
            Stringformat();
            LengthChecker();
            CalculateTax();
        }
       
        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            emailtextBox.ReadOnly = false;
            surnametextBox.ReadOnly = false;
            othernametextBox.ReadOnly = false;
            phonenumbertextBox.ReadOnly = false;
            addresstextBox.ReadOnly = false;
            accountnumbertextBox.ReadOnly = false;
            firstbutton.Enabled = false;
            nextbutton.Enabled = false;
            LASTbutton.Enabled = false;
            button3.Enabled = false;
            searchbutton.Enabled = false;
            statecomboBox.Enabled = true;
            jobcomboBox.Enabled = true;
            gendercomboBox.Enabled = true;
            maritalcomboBox.Enabled = true;
            departmentcomboBox.Enabled = true;
            BCcomboBox.Enabled = true;
            searchbutton.Enabled = false;
            cancelbutton.Enabled = true;
            othertextBox.ReadOnly = false;
            button2.Enabled = false;
            dateEmployed.Enabled = true;
            dateTimePicker2.Enabled = true;
            newbutton.Enabled = false;
            salarytextBox.ReadOnly = false;
            housingtextBox.ReadOnly = false;
            trasporttextBox.ReadOnly = false;
            othertextBox.ReadOnly = false;
            button5.Enabled = false;
            exitbutton.Enabled = false;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            employeeBiodataBindingSource.CancelEdit();
            FillId();
            Readonly();
            LengthChecker();
            button3.Enabled = true;
            button5.Enabled = true;
            button4.Enabled = true;
            button2.Enabled = true;
            firstbutton.Enabled = true;
            searchbutton.Enabled = true;
            nextbutton.Enabled = true;
            LASTbutton.Enabled = true;
            newbutton.Enabled = true;
            ActiveControl = button2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to delete this record?", @"Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            Con.Open();
            string query = "DELETE FROM EmployeeBiodata WHERE Email = '" + emailtextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            sda.SelectCommand.ExecuteNonQuery();
            DataTable data = new DataTable();
            sda.Fill(data);
            Con.Close();
            employeeBiodataBindingSource.RemoveCurrent();
            Readonly();
            LengthChecker();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            //Search ss = new Search();
            //ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Do you want to print all records?", @"",MessageBoxButtons.YesNo,MessageBoxIcon.Question) != DialogResult.Yes)
            {
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                EReporrt ss = new EReporrt();
                ss.Show();
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (surnametextBox.Text == "" || othernametextBox.Text == "" || addresstextBox.Text == "" || DCtextBox.Text == "" || 
                phonenumbertextBox.Text == "" || JCtextBox.Text == "" ||accountnumbertextBox.Text == "" ||maritalcomboBox.Text == "" || 
                gendercomboBox.Text == @"-SELECT-" || SCtextBox.Text == "" || banknametextBox.Text == "" || emailtextBox.Text == "")
            {
                MessageBox.Show(@"Please Fill All Fields", @"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    Cmd = new SqlCommand("SELECT * FROM EmployeeBiodata WHERE Id = '" + textBox5.Text + "'", Con);
                    SqlDataAdapter da = new SqlDataAdapter(Cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        Con.Open();
                        Cmd = Con.CreateCommand();
                        Cmd.CommandType = CommandType.Text;
                        Cmd.CommandText = "UPDATE EmployeeBiodata SET Email = '" + emailtextBox.Text + "',Surname = '" +
                                          surnametextBox.Text + "',OtherNames = '" + othernametextBox.Text + "',DepartmentCode = '" +DCtextBox.Text + "', " +
                                          "Gender = '" + gendercomboBox.Text + "',Contact  = '" + phonenumbertextBox.Text + "',DOB = '" +dateTimePicker2.Text + "'," +
                                          "MaritalStatus = '" + maritalcomboBox.Text + "', StateCode = '" + SCtextBox.Text + "',JobCode = '" + JCtextBox.Text +
                                          "',DateEmployed = '" + dateEmployed.Text + "',Address = '" + addresstextBox.Text + "',BankCode = '" + BCcomboBox.Text +
                                          "',AccountNumber = '" + accountnumbertextBox.Text + "',OtherAllowances = '" + othertextBox.Text + "'," +
                                          "GrossSalary = '" +grossSalarytextBox.Text + "',Paye = '" + ptextBox.Text + "' WHERE  Id = '" + textBox5.Text + "'";
                        Cmd.ExecuteNonQuery();
                        Con.Close();
                        Readonly();
                        Stringformat();
                        LengthChecker();
                        firstbutton.Enabled = true;
                        button3.Enabled = true;
                        nextbutton.Enabled = true;
                        LASTbutton.Enabled = true;
                        newbutton.Enabled = true;
                        button4.Enabled = true;
                        button2.Enabled = true;
                    }
                    else
                    {
                        Con.Open();
                        string query = "INSERT INTO EmployeeBiodata"+
                        "(Email,Surname,OtherNames,DepartmentCode,Gender,Contact,DOB,MaritalStatus,StateCode,JobCode,DateEmployed,Address,BankCode,AccountNumber,OtherAllowances,GrossSalary,Paye)" +
                            "VALUES ('" + emailtextBox.Text + "','" + surnametextBox.Text + "','" +othernametextBox.Text + "','" + DCtextBox.Text + "'," +
                            "'" + gendercomboBox.Text + "','" + phonenumbertextBox.Text + "','" + dateTimePicker2.Text +"','" + maritalcomboBox.Text + "'," +
                            "'" + SCtextBox.Text + "','" + JCtextBox.Text + "','" + dateEmployed.Text + "','" +addresstextBox.Text + "','" + BCcomboBox.Text + "'," +
                            "'" + accountnumbertextBox.Text + "','" + othertextBox.Text + "','" +grossSalarytextBox.Text + "','" + ptextBox.Text + "')";
                        SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                        sda.SelectCommand.ExecuteNonQuery();
                        DataTable data = new DataTable();
                        sda.Fill(data);
                        Con.Close();
                     }
                  }
                catch (Exception)
                 {
                      //Ignore
                 }
                finally
                 {
                        Readonly();
                        Stringformat();
                        LengthChecker();
                        firstbutton.Enabled = true;
                        button3.Enabled = true;
                        nextbutton.Enabled = true;
                        LASTbutton.Enabled = true;
                        newbutton.Enabled = true;
                        button2.Enabled = true;
                        button4.Enabled = true;
                 }
            }
        }

        public void ChangeTheDate()
        {
            DateTime date = DateTime.Now;
            dateEmployed.Text = date.ToShortDateString();
        }

        private void newbutton_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            RetrieveId();
            ChangeTheDate();
            surnametextBox.ReadOnly = false;
            surnametextBox.Clear(); 
            othernametextBox.Clear();
            othernametextBox.ReadOnly = false;
            gendercomboBox.Text = @"-SELECT-";
            departmentcomboBox.Text = @"-SELECT-";
            DCtextBox.Clear();
            phonenumbertextBox.ReadOnly = false;
            phonenumbertextBox.Clear();
            emailtextBox.ReadOnly = false;
            emailtextBox.Clear();
            jobcomboBox.Text = @"-SELECT-";
            JCtextBox.Clear();
            maritalcomboBox.Text = @"-SELECT-";
            addresstextBox.ReadOnly = false;
            addresstextBox.Clear();
            statecomboBox.Text = @"-SELECT-";
            SCtextBox.Clear();
            BCcomboBox.Text = @"-SELECT-";
            accountnumbertextBox.Clear();
            gendercomboBox.Enabled = true;
            maritalcomboBox.Enabled = true;
            statecomboBox.Enabled = true;
            jobcomboBox.Enabled = true;
            departmentcomboBox.Enabled = true;
            BCcomboBox.Enabled = true;
            accountnumbertextBox.ReadOnly = false;
            searchbutton.Enabled = false;
            dateEmployed.Enabled = true;
            dateTimePicker2.Enabled = true;
            banknametextBox.Clear();
            salarytextBox.Clear();
            housingtextBox.Clear();
            trasporttextBox.Clear();
            othertextBox.Text = @"0.00";
            ptextBox.Text = @"0.00";
            grossSalarytextBox.Text = @"0.00";
            button1.Enabled = true;
            button2.Enabled = false;
            newbutton.Enabled = false;
            cancelbutton.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = false;
            exitbutton.Enabled = false;
            othertextBox.ReadOnly = false;
            firstbutton.Enabled = false;
            LASTbutton.Enabled = false;
            nextbutton.Enabled = false;
            button3.Enabled = false;
        }

        private void gendercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void maritalcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void surnametextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void othernametextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void addresstextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void phonenumbertextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void statecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
            con.Open();
            Cmd = con.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT * FROM States WHERE State = '" + statecomboBox.Text + "'";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                SCtextBox.Text = dr["StateCode"].ToString();
            }
            con.Close();
        }

        private void departmentcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
            con.Open();
            Cmd = con.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT * FROM Department WHERE DeptName = '" + departmentcomboBox.Text + "'";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                DCtextBox.Text = dr["DeptCode"].ToString();
            }
            con.Close();
        }

        private void jobcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
            con.Open();
            Cmd = con.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT * FROM JobDescription WHERE JobDesc= '" + jobcomboBox.Text + "'";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                JCtextBox.Text = dr["JobCode"].ToString();
                salarytextBox.Text = dr["BasicSalary"].ToString();
                housingtextBox.Text = dr["HousingAllowance"].ToString();
                trasporttextBox.Text = dr["TransportationAllowance"].ToString();
            }
            Calculategrosssalary();
            CalculateTax();
            con.Close();
        }

        private void SCtextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
            con.Open();
            Cmd = con.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT * FROM States WHERE StateCode = '" + SCtextBox.Text + "'";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                statecomboBox.Text = dr["State"].ToString();
            }
            con.Close();
        }

        private void DCtextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
            connection.Open();
            Cmd = connection.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT * FROM Department WHERE DeptCode = '" + DCtextBox.Text + "'";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                departmentcomboBox.Text = dr["DeptName"].ToString();
            }
            connection.Close();
        }

        private void JCtextBox_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
            conn.Open();
            Cmd = conn.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT * FROM JobDescription WHERE JobCode = '" + JCtextBox.Text + "'";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                jobcomboBox.Text = dr["JobDesc"].ToString();
            }
            conn.Close();
        }

        private void BCcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
            Con.Open();
            Cmd = Con.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT * FROM BankData WHERE BankCode = '" + BCcomboBox.Text + "'";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                banknametextBox.Text = dr["BankName"].ToString();
            }
            Con.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dateEmployed_ValueChanged(object sender, EventArgs e)
        {
        }

      
        private void othernametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

       private void BCcomboBox_TextChanged(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
            Con.Open();
            Cmd = Con.CreateCommand();
            Cmd.CommandType = CommandType.Text;
            Cmd.CommandText = "SELECT * FROM BankData WHERE BankCode = '" + BCcomboBox.Text + "'";
            Cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                banknametextBox.Text = dr["BankName"].ToString();
            }
            Con.Close();
        }

        private void gendercomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void maritalcomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void statecomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void BCcomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void departmentcomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox1.Text, new Font("Segoe UI Emoji", 12), Brushes.Black, 1, 1);
        }

        private void surnametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
            //if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void othertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
       
        private void button5_MouseEnter(object sender, EventArgs e)
        {
            PrintI();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            LengthChecker();
            Stringformat();
            Calculategrosssalary();
            CalculateTax();
        }
       
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void phonenumbertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void accountnumbertextBox_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
       
        private void accountnumbertextBox_Leave(object sender, EventArgs e)
        {
            LengthChecker();
        }
        
        private void accountnumbertextBox_ControlRemoved(object sender, ControlEventArgs e)
        {
            LengthChecker();
        }

        private void jobcomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsLetter(e.KeyChar))
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void accountnumbertextBox_MouseLeave(object sender, EventArgs e)
        {
            LengthChecker();
        }

        private void accountnumbertextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void accountnumbertextBox_VisibleChanged(object sender, EventArgs e)
        {
            LengthChecker();
        }

        private void accountnumbertextBox_MouseMove(object sender, MouseEventArgs e)
        {
            LengthChecker();
        }

        private void ptextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeBiodataBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void accountnumbertextBox_MouseUp(object sender, MouseEventArgs e)
        {
            LengthChecker();
        }

        private void othertextBox_MouseLeave(object sender, EventArgs e)
        {
            othertextBox.Text = string.Format("{0:#,##0.00}", double.Parse(othertextBox.Text));
        }
       

        private void othertextBox_CursorChanged(object sender, EventArgs e)
        {
            othertextBox.Text = string.Format("{0:#,##0.00}", double.Parse(othertextBox.Text));
        }

        public void CalculateTax()
        {
            GrossSalary = double.Parse(grossSalarytextBox.Text);
            if (GrossSalary > 1)
            {
                AnnualGross = GrossSalary * 12;
                Paye = 0;
                if (AnnualGross * 0.20 < 200000)
                {
                    TaxFreeAllowance = 200000 + 10000;
                }
                else
                {
                    TaxFreeAllowance = AnnualGross * 0.20 + 10000;
                }
                TaxableIncome = AnnualGross - TaxFreeAllowance;
                Bal = TaxableIncome;
                if (Bal <= 300000)
                {
                    Paye = Paye + 300000 * 0.07;
                    Bal = Bal - 300000;
                }
                if (Bal > 300000)
                {
                    Paye = Paye + 300000 * 0.11;
                    Bal = Bal - 300000;
                }
                if (Bal > 500000)
                {
                    Paye = Paye + 500000 * 0.15;
                    Bal = Bal - 500000;
                }
                if (Bal > 500000)
                {
                    Paye = Paye + Bal * 0.17;
                    Bal = 0;
                }
                Paye = Paye / 12;
                ptextBox.Text = Paye.ToString("###,###.00");
            }
        }

        public void PrintI()
        {
            DateTime timeofDay = DateTime.Now;
            textBox1.Text = "";
            textBox1.AppendText(" " + Environment.NewLine);
            textBox1.AppendText("\t\t\t\t    " + companyNameTextBox.Text + Environment.NewLine);
            textBox1.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox1.AppendText("\t\t\t\t        " + label22.Text + Environment.NewLine);
            textBox1.AppendText(Environment.NewLine);

            textBox1.AppendText("  ID: " + "\t\t\t" + textBox5.Text + Environment.NewLine);
            textBox1.AppendText("  Surname: " + "\t\t" + surnametextBox.Text + Environment.NewLine);
            textBox1.AppendText("  Other Names: " + "\t\t" + othernametextBox.Text + Environment.NewLine);
            textBox1.AppendText("  Gender: " + "\t\t" + gendercomboBox.Text + Environment.NewLine);
            textBox1.AppendText("  Date of Birth: " + "\t\t" + dateTimePicker2.Text + Environment.NewLine);
            textBox1.AppendText("  State of Origin: " + "\t\t" + statecomboBox.Text + Environment.NewLine);
            textBox1.AppendText("  Marital Status: " + "\t\t" + maritalcomboBox.Text + Environment.NewLine);
            textBox1.AppendText("  Phone Number: " + "\t\t" + phonenumbertextBox.Text + Environment.NewLine);
            textBox1.AppendText("  Email Address: " + "\t\t" + emailtextBox.Text + Environment.NewLine);
            textBox1.AppendText("  Residential Address: " +"\t"+ addresstextBox.Text + Environment.NewLine);
            textBox1.AppendText("  Date Employed: " + "\t\t" + dateEmployed.Text + Environment.NewLine);
            textBox1.AppendText("  Department: " + "\t\t" + departmentcomboBox.Text + Environment.NewLine);
            textBox1.AppendText("  Job Description: " + "\t" + jobcomboBox.Text + Environment.NewLine);
            textBox1.AppendText("  Gross Salary: " + "\t\tNGN " + grossSalarytextBox.Text + Environment.NewLine);

            textBox1.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox1.AppendText("\t\t\t\t\t\t\t\t\t         " + timeofDay.ToString("dd-MM-yyyy HH:mm:ss") + Environment.NewLine);
        }
    }
}
