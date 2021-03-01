using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;


namespace PersonnelLogin
{
    public partial class Banks : Form
    {
        public Banks()
        {
            InitializeComponent();
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
        }
        public static CultureInfo CurrentCulture { get; set; }
        private void Banks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logInDataSet6.SystemDefaults' table. You can move, or remove it, as needed.
            this.systemDefaultsTableAdapter.Fill(this.logInDataSet6.SystemDefaults);
            // TODO: This line of code loads data into the 'bankDataSet5.BankData' table. You can move, or remove it, as needed.
            bankDataTableAdapter.Fill(bankDataSet5.BankData);
            ActiveControl = topbutton;
        }
        public void RefreshStuff()
        {
            bankDataBindingSource.ResetBindings(true);
        }

        private void topbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            bankDataBindingSource.MoveFirst();
            nextbutton.Enabled = true;
            bottombutton.Enabled = true;
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            bankDataBindingSource.MovePrevious();
            nextbutton.Enabled = true;
            bottombutton.Enabled = true;
         }

        private void nextbutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            bankDataBindingSource.MoveNext();
            previousbutton.Enabled = true;
            topbutton.Enabled = true;
        }

        private void bottombutton_Click(object sender, EventArgs e)
        {
            RefreshStuff();
            bankDataBindingSource.MoveLast();
            topbutton.Enabled = true;
            previousbutton.Enabled = true;
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Readonly()
        {
            topbutton.Enabled = true;
            previousbutton.Enabled = true;
            nextbutton.Enabled = true;
            bottombutton.Enabled = true;
            deletebutton.Enabled = true;
            button1.Enabled = true;
            exitbutton.Enabled = true;
            savebutton.Visible = false;
            cancelbutton.Visible = false;
            codetextBox.ReadOnly = true;
            nametextBox.ReadOnly = true;
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            bankDataBindingSource.AddNew();
            nametextBox.ReadOnly = false;
            codetextBox.ReadOnly = false;
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
            nametextBox.ReadOnly = false;
            topbutton.Enabled = false;
            previousbutton.Enabled = false;
            nextbutton.Enabled = false;
            bottombutton.Enabled = false;
            deletebutton.Enabled = false;
            exitbutton.Enabled = false;
            savebutton.Visible = true;
            cancelbutton.Visible = true;
        }

        public SqlConnection Con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");

        private void deletebutton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Are you sure you want to delete this record?", @"Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;
            Con.Open();
            string query = "DELETE FROM BankData WHERE BankCode = '" + codetextBox.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            sda.SelectCommand.ExecuteNonQuery();
            DataTable data = new DataTable();
            sda.Fill(data);
            Con.Close();
            bankDataBindingSource.RemoveCurrent();
            Readonly();
        }

        private void codetextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void nametextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private SqlCommand _cmd;

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (codetextBox.Text == "" || nametextBox.Text == "")
            {
                MessageBox.Show(@"Please Fill All Fields", @"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _cmd = new SqlCommand("SELECT * FROM BankData WHERE BankCode = '" + codetextBox.Text + "'", Con);
                SqlDataAdapter da = new SqlDataAdapter(_cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Con.Open();
                    SqlCommand cmd = Con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "UPDATE BankData SET BankName = '" + nametextBox.Text + "' WHERE BankCode = '" +
                                      codetextBox.Text + "'";
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    Readonly();
                }
                else
                {
                    try
                    {
                        Con.Open();
                        var query = "INSERT INTO BankData (BankCode,BankName) VALUES ('" + codetextBox.Text + "','" +
                                    nametextBox.Text + "')";
                        var sda = new SqlDataAdapter(query, Con);
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
                        Readonly();
                    }
                }
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            bankDataBindingSource.CancelEdit();
            Readonly();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Do you want to print all records?", @"",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                BankDataReport ss = new BankDataReport();
                ss.Show();
            }
        }

        public void PrintI()
        {
            DateTime timeofDay = DateTime.Now;
            textBox4.Text = "";
            textBox4.AppendText(" " + Environment.NewLine);
            textBox4.AppendText("\t\t\t\t   " + companyNameTextBox.Text + Environment.NewLine);
            textBox4.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox4.AppendText("\t\t\t\t\t        "+ label1.Text + Environment.NewLine);
            textBox4.AppendText(Environment.NewLine);

            textBox4.AppendText("  Bank Code: " + "\t" + codetextBox.Text + Environment.NewLine);
            textBox4.AppendText("  Bank Name: " + "\t" + nametextBox.Text + Environment.NewLine);
    
            textBox4.AppendText("_____________________________________________________________________________________________________________________" + Environment.NewLine);
            textBox4.AppendText("\t\t\t\t\t\t\t\t\t              "+ timeofDay.ToString("dd-MM-yyyy HH:mm:ss") + Environment.NewLine);
         }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox4.Text, new Font("Segoe UI Emoji", 12), Brushes.Black, 1, 1);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            PrintI();
        }
    }
}
