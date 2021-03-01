using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace PersonnelLogin
{
    public partial class Department : Form
    {
        public Department()
        {
            InitializeComponent();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
        }

      public SqlConnection con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");

        private void Deparment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logInDataSet6.SystemDefaults' table. You can move, or remove it, as needed.
            this.systemDefaultsTableAdapter.Fill(this.logInDataSet6.SystemDefaults);
            // TODO: This line of code loads data into the 'departmentDataSet5.Department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.departmentDataSet5.Department);
            ActiveControl = topbutton;
        }

        private void topbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            departmentBindingSource.MoveFirst();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            bottombutton.Enabled = true;
            nextbutton.Enabled = true;
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            departmentBindingSource.MovePrevious();
            nextbutton.Enabled = true;
            bottombutton.Enabled = true;
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            departmentBindingSource.MoveNext();
            previousbutton.Enabled = true;
            topbutton.Enabled = true;
        }

        private void bottombutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            departmentBindingSource.MoveLast();
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
            topbutton.Enabled = true;
            previousbutton.Enabled = true;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            departmentBindingSource.AddNew();
            deptCodeTextBox.ReadOnly = false;
            deptNameTextBox.ReadOnly = false;
            printbutton.Enabled = false;
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
            deletebutton.Enabled = false;
            exitbutton.Enabled = false;
            savebutton.Visible = true;
            cancelbutton.Visible = true;
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            deptCodeTextBox.ReadOnly = false;
            deptNameTextBox.ReadOnly = false;
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

        private void printbutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Do you want to print all records?", @"",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                printPreviewDialog1.ShowDialog();
            }
            else
            {
               DepartmentReport ss = new DepartmentReport();
                ss.Show();
            } 
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to delete this record?", @"Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            con.Open();
            string query = "DELETE FROM Department WHERE DeptCode = '" + deptCodeTextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            DataTable data = new DataTable();
            sda.Fill(data);
            con.Close();
            departmentBindingSource.RemoveCurrent();
            Readonly();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
       
        private void savebutton_Click(object sender, EventArgs e)
        {
           if (deptCodeTextBox.Text == "" || deptNameTextBox.Text == "")
            {
                MessageBox.Show(@"Please Fill All Fields", @"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                var cmd = new SqlCommand("SELECT * FROM Department WHERE DeptCode = '" + deptCodeTextBox.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE Department SET DeptName = '" + deptCodeTextBox.Text +
                                      "' WHERE DeptCode = '" + deptCodeTextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    Readonly();
                }
                else
                {
                    try
                    {
                        con.Open();
                        var query = "INSERT INTO Department (DeptCode,DeptName) VALUES ('" + deptCodeTextBox.Text +
                                    "','" + deptNameTextBox.Text + "')";
                        var sda = new SqlDataAdapter(query, con);
                        sda.SelectCommand.ExecuteNonQuery();
                        DataTable data = new DataTable();
                        sda.Fill(data);
                        con.Close();

                    }
                    catch (Exception)
                    {
                        //ignore
                    }
                    finally
                    {
                        Readonly();
                    }
                }
           }
        }

        public void RefreshStuff()
        {
           departmentBindingSource.ResetBindings(true);
        }

        public void Readonly()
        {
            deptCodeTextBox.ReadOnly = true;
            deptNameTextBox.ReadOnly = true;
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
            textBox3.AppendText("\t\t\t\t\t" + label1.Text + Environment.NewLine);
            textBox3.AppendText(Environment.NewLine);

            textBox3.AppendText("  Code: " + "\t" + deptCodeTextBox.Text + Environment.NewLine);
            textBox3.AppendText("  Name: " + "\t" + deptNameTextBox.Text + Environment.NewLine);
           
            textBox3.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox3.AppendText("\t\t\t\t\t\t\t\t\t               " + timeofDay.ToString("dd-MM-yyyy HH:mm:ss") + Environment.NewLine);
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
           departmentBindingSource.CancelEdit();
            Readonly();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox3.Text, new Font("Segoe UI Emoji", 12), Brushes.Black, 1, 1);
        }

        private void deptNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void printbutton_MouseEnter(object sender, EventArgs e)
        {
            PrintI();
        }
    }
}
