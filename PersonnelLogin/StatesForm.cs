using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace PersonnelLogin
{
    public partial class StatesForm : Form
    {
        public StatesForm()
        {
            InitializeComponent();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
       }

        private void StatesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logInDataSet6.SystemDefaults' table. You can move, or remove it, as needed.
            this.systemDefaultsTableAdapter.Fill(this.logInDataSet6.SystemDefaults);
            // TODO: This line of code loads data into the 'statesDataSet5.States' table. You can move, or remove it, as needed.
            statesTableAdapter.Fill(statesDataSet5.States);
            ActiveControl = topbutton;
        }
        public void Readonly()
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            topbutton.Enabled = true;
            previousbutton.Enabled = true;
            deletebutton.Enabled = true;
            exitbutton.Enabled = true;
            savebutton.Visible = false;
            cancelbutton.Visible = false;
            nextbutton.Enabled = true;
            bottombutton.Enabled = true;
        }
        public void RefreshStuff()
        {
            statesBindingSource.ResetBindings(true);
        }
        private void topbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            statesBindingSource.MoveFirst();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            bottombutton.Enabled = true;
            nextbutton.Enabled = true;
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            statesBindingSource.MovePrevious();
            nextbutton.Enabled = true;
            bottombutton.Enabled = true;
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            statesBindingSource.MoveNext();
            previousbutton.Enabled = true;
            topbutton.Enabled = true;
        }

        private void bottombutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            statesBindingSource.MoveLast();
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
            topbutton.Enabled = true;
            previousbutton.Enabled = true;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
           Close();
        }

        public SqlConnection con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to delete this record?", @"Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            con.Open();
            string query = "DELETE FROM States WHERE StateCode = '" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            DataTable data = new DataTable();
            sda.Fill(data);
            con.Close();
            statesBindingSource.RemoveCurrent();
            Readonly();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            statesBindingSource.AddNew();
            textBox1.ReadOnly = false;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
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
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
            deletebutton.Enabled = false;
            exitbutton.Enabled = false;
            savebutton.Visible = true;
            cancelbutton.Visible = true;
        }

        private SqlCommand _cmd;
        public SqlConnection Con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(@"Please Fill All Fields", @"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _cmd = new SqlCommand("SELECT * FROM States WHERE StateCode = '" + textBox1.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(_cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE States SET StateCode = '"+textBox1.Text+"', State = '"+textBox2.Text+"' WHERE StateCode = '" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    Readonly();
                }
                else
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
                        con.Open();
                           var query = "INSERT INTO States (StateCode,State) VALUES ('" + textBox1.Text + "','"+textBox2.Text + "')";
                           var sda = new SqlDataAdapter(query, con);
                            sda.SelectCommand.ExecuteNonQuery();
                            DataTable data = new DataTable();
                            sda.Fill(data);
                            con.Close();
                            Readonly();
                    }
                    catch (Exception)
                    {
                        //ignore
                    }
                 }
            }
        }
       
        private void cancelbutton_Click(object sender, EventArgs e)
        {
                statesBindingSource.CancelEdit();
                Readonly();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void savebutton_MouseClick(object sender, MouseEventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show(@"Please Fill All Fields", @"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _cmd = new SqlCommand("SELECT * FROM States WHERE StateCode = '" + textBox1.Text + "'", connection);
                SqlDataAdapter da = new SqlDataAdapter(_cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {

                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE States SET StateCode = '" + textBox1.Text + "', State = '" + textBox2.Text + "' WHERE StateCode = '" + textBox1.Text + "'";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Readonly();
                }
                else
                {
                    try
                    {
                        connection.Open();
                        var query = "INSERT INTO States (StateCode,State) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')";
                        var sda = new SqlDataAdapter(query, connection);
                        sda.SelectCommand.ExecuteNonQuery();
                        DataTable data = new DataTable();
                        sda.Fill(data);
                        connection.Close();
                        Readonly();
                    }
                    catch (Exception)
                    {
                        //ignore
                    }
                }
            }
                      RefreshStuff();
        }

       public void PrintI()
        {
            DateTime timeofDay = DateTime.Now;
            textBox4.Text = "";
            textBox4.AppendText(" " + Environment.NewLine);
            textBox4.AppendText("\t\t\t\t   " + companyNameTextBox.Text + Environment.NewLine);
            textBox4.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox4.AppendText("\t\t\t\t\t       " + label1.Text + Environment.NewLine);
            textBox4.AppendText(Environment.NewLine);

            textBox4.AppendText("  Code: " + "\t" + textBox1.Text + Environment.NewLine);
            textBox4.AppendText("  State: " + "\t" + textBox2.Text + Environment.NewLine);

            textBox4.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox4.AppendText("\t\t\t\t\t\t\t\t\t              " + timeofDay.ToString("dd-MM-yyyy HH:mm:ss") + Environment.NewLine);
        }
        private void printbutton_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show(@"Do you want to print all records?", @"",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                printPreviewDialog2.ShowDialog();
            }
            else
            {
               StateReport ss = new StateReport();
                ss.Show();
            }
       }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox4.Text, new Font("Segoe UI Emoji", 12), Brushes.Black, 1, 1);
        }

        private void printbutton_MouseEnter(object sender, EventArgs e)
        {
          PrintI();
        }
    }
}
