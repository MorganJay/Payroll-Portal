using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonnelLogin
{
    public partial class PasswordCreate : Form
    {
        DataSet ds = new DataSet();
        SqlCommand cmd;
        private readonly SqlConnection _con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");

        public PasswordCreate()
        {
            InitializeComponent();
        }
       // public void IDvalidation()
       // {
       //     cmd = new SqlCommand("SELECT * FROM LogIn WHERE Id = '" + textBox3.Text + "'", _con);
       //     SqlDataAdapter da = new SqlDataAdapter(cmd);
       //     DataTable dt = new DataTable();
       //     da.Fill(dt);
       //     if (dt.Rows.Count == 1)
       //     {
       //         label5.ForeColor = Color.Green;
       //         label5.Text = "VALID ID NUMBER";
       //     }
       //     else
       //     {
       //         label5.ForeColor = Color.Red;
       //         label5.Text = "INVALID ID NUMBER";
       //     }
       // }
       //private void button1_Click(object sender, EventArgs e)
       // {
       //     if (textBox1.Text != textBox2.Text)
       //     {
       //         MessageBox.Show(@"Password Mismatch", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
       //     }
       //     else if (textBox1.Text != textBox2.Text || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
       //     {
       //         MessageBox.Show(@"Please Fill All Fields", @"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
       //     }
       //     else
       //     {
       //         cmd = new SqlCommand("SELECT * FROM LogIn WHERE Id = '" + textBox3.Text + "'", _con);
       //         SqlDataAdapter da = new SqlDataAdapter(cmd);
       //         DataTable dt = new DataTable();
       //         da.Fill(dt);
       //         if (dt.Rows.Count == 1)
       //         {
       //             MessageBox.Show(@"THIS ID ALREADY HAS A PASSWORD", @"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
       //         }
       //         else
       //         {
       //             _con.Open();
       //             var query = "UPDATE LogIn SET Password = '" + textBox1.Text + "' WHERE Id = '" + textBox3.Text + "'";
       //             var sda = new SqlDataAdapter(query, _con);
       //             sda.SelectCommand.ExecuteNonQuery();
       //             _con.Close();
       //             MessageBox.Show(@"Password Added Successfully!!, @"", MessageBoxButtons.OK, MessageBoxIcon.Information");
       //             Hide();
       //        }
       //     }
       // }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void PasswordCreate_DoubleClick(object sender, EventArgs e)
        {
            Hide();
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            //IDvalidation();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PasswordCreate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logInDataSet4.LogIn' table. You can move, or remove it, as needed.
            this.logInTableAdapter.Fill(this.logInDataSet4.LogIn);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
