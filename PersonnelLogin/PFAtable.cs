using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace PersonnelLogin
{
    public partial class PfAtable : Form
    {
        public PfAtable()
        {
            InitializeComponent();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
        }

      private void PFAtable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pFADataSet5.PFATable' table. You can move, or remove it, as needed.
            pFATableTableAdapter.Fill(pFADataSet5.PFATable);
            // TODO: This line of code loads data into the 'logInDataSet6.SystemDefaults' table. You can move, or remove it, as needed.
            systemDefaultsTableAdapter.Fill(logInDataSet6.SystemDefaults);
            ActiveControl = topbutton;
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
            pFANameTextBox.ReadOnly = true;
            pFAAddressTextBox.ReadOnly = true;
            pFAIdTextBox.ReadOnly = true;
            pFAAccountTextBox.ReadOnly = true;
        }
        public void PrintI()
        {
            DateTime timeofDay = DateTime.Now;
            textBox4.Text = "";
            textBox4.AppendText(" " + Environment.NewLine);
            textBox4.AppendText("\t\t\t\t    " + companyNameTextBox.Text + Environment.NewLine);
            textBox4.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox4.AppendText("\t\t\t  " + label1.Text + Environment.NewLine);
            textBox4.AppendText(Environment.NewLine);

            textBox4.AppendText("  PFA ID: " + "\t\t" + pFAIdTextBox.Text + Environment.NewLine);
            textBox4.AppendText("  PFA Name: " + "\t\t" + pFANameTextBox.Text + Environment.NewLine);
            textBox4.AppendText("  PFA Address: " + "\t\t" + pFAAddressTextBox.Text + Environment.NewLine);
            textBox4.AppendText("  PFA Account Number: " + "\t" + pFAAccountTextBox.Text + Environment.NewLine);
            
            textBox4.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox4.AppendText("\t\t\t\t\t\t\t\t\t               " + timeofDay.ToString("dd-MM-yyyy HH:mm:ss") + Environment.NewLine);
        }

        public long Textbox;
        public void LengthChecker()
        {
            var chars = pFAAccountTextBox.Text.Length;
            if (chars < 10)
            {
                try
                {
                    Textbox = long.Parse(pFAAccountTextBox.Text);
                    pFAAccountTextBox.Text = string.Format("{0,10:D10}", Textbox);
                }
                catch (Exception)
                {
                    //Ignore
                }
            }
        }

        private void pFANameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void pFAAccountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void topbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            pFATableBindingSource.MoveFirst();
            LengthChecker();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            bottombutton.Enabled = true;
            nextbutton.Enabled = true;
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            pFATableBindingSource.MovePrevious();
            LengthChecker();
            nextbutton.Enabled = true;
            bottombutton.Enabled = true;
        }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            pFATableBindingSource.MoveNext();
            LengthChecker();
            previousbutton.Enabled = true;
            topbutton.Enabled = true;
        }

        private void bottombutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            pFATableBindingSource.MoveLast();
            LengthChecker();
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
            topbutton.Enabled = true;
            previousbutton.Enabled = true;
        }

        public void RefreshStuff()
        {
            pFATableBindingSource.ResetBindings(true);
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            pFATableBindingSource.AddNew();
            pFANameTextBox.ReadOnly = false;
            pFAAccountTextBox.ReadOnly = false;
            pFAAddressTextBox.ReadOnly = false;
            pFAIdTextBox.ReadOnly = false;
            printbutton.Enabled = false;
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
            printbutton.Enabled = false;
            deletebutton.Enabled = false;
            exitbutton.Enabled = false;
            savebutton.Visible = true;
            cancelbutton.Visible = true;
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            pFAIdTextBox.ReadOnly = false;
            pFANameTextBox.ReadOnly = false;
            pFAAddressTextBox.ReadOnly = false;
            pFAAccountTextBox.ReadOnly = false;
            pFAAddressTextBox.ReadOnly = false;
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
        public SqlConnection Con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
        private void savebutton_Click(object sender, EventArgs e)
        {
            if (pFANameTextBox.Text == "" || pFAAddressTextBox.Text == "" || pFAIdTextBox.Text == "" || pFAAccountTextBox.Text == "")
            {
                MessageBox.Show(@"Please fill all the fields", @"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
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
                    cmd.CommandText = "UPDATE PFATable SET PFAName = '" + pFANameTextBox.Text + "',PFAAddress = '" +
                                      pFAAddressTextBox.Text + "',PFAAccount = '" + pFAAccountTextBox.Text + "'," +
                                      "' WHERE PFAId = '" + pFAIdTextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    Readonly();
                }
                else
                {
                    try
                    {
                        Con.Open();
                        string query = "INSERT INTO PFATable (PFAId,PFAName,PFAAddress,PFAAccount) VALUES ('" + pFAIdTextBox.Text + "'," +
                                       "'" + pFANameTextBox.Text + "','" + pFAAddressTextBox.Text + "','" + pFAAccountTextBox.Text + "')";
                        SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                        sda.SelectCommand.ExecuteNonQuery();
                        DataTable data = new DataTable();
                        sda.Fill(data);
                        Con.Close();
                        pFATableBindingSource.ResetCurrentItem();
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
              pFATableBindingSource.CancelEdit();
                Readonly();
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
                PFAReport ss = new PFAReport();
                ss.Show();
            }
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
            if (MessageBox.Show(@"Are you sure you want to delete this record?", @"Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            con.Open();
            string query = "DELETE FROM PFATable WHERE PFAId = '" + pFAIdTextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            DataTable data = new DataTable();
            sda.Fill(data);
            con.Close();
            pFATableBindingSource.RemoveCurrent();
            Readonly();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void savebutton_MouseEnter(object sender, EventArgs e)
        {
            LengthChecker();
        }

        private void printbutton_MouseEnter(object sender, EventArgs e)
        {
            PrintI();
        }

        private void pFAIdTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void printbutton_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox4.Text, new Font("Segoe UI Emoji", 12), Brushes.Black, 1, 1);
        }

        private void pFAAccountTextBox_Leave(object sender, EventArgs e)
        {
            LengthChecker();
        }
    }
 }

