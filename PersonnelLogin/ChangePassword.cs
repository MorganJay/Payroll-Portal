using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonnelLogin
{
    public partial class ChangePassword : Form
    {
        public SqlCommand Cmd;
        private readonly SqlConnection _con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");

        public ChangePassword()
        {
            InitializeComponent();
        }

        public void fill_textbox()
        {
            var command = new SqlCommand("SELECT * FROM EmployeeBiodata WHERE Email = '" + textBox1.Text + "'",_con);
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dat = new DataTable();
            sda.Fill(dat);
            if (dat.Rows.Count == 1)
            {
                _con.Open();
                Cmd = _con.CreateCommand();
                Cmd.CommandType = CommandType.Text;
                Cmd.CommandText = "SELECT Password FROM LogIn where Email ='" + textBox1.Text + "'";
                Cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sdad = new SqlDataAdapter(Cmd);
                sdad.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox2.Text = dr["Password"].ToString();
                }
                _con.Close();
                label5.Text = "";
            }
            else
            {
                textBox2.Clear();
            }
        }

        private void ChangePassword_DoubleClick(object sender, EventArgs e)
        {
            Hide();
        }
    
        private void ChangePassword_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show(@"Please Fill All Fields", @"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (MessageBox.Show(@"Are you sure you want to change your password?", @"Password Change", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {  
                    _con.Open();
                    Cmd = _con.CreateCommand();
                    Cmd.CommandType = CommandType.Text;
                    Cmd.CommandText = "UPDATE LogIn SET Password = '" + textBox4.Text + "' WHERE Email = '" + textBox1.Text + "'";
                    Cmd.ExecuteNonQuery();
                    _con.Close();
                    MessageBox.Show(@"Password Changed Successfully", @"", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Hide();               
            }            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Cmd = new SqlCommand("SELECT * FROM LogIn WHERE Email = '" + textBox1.Text + "'", _con);
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                fill_textbox();
            }
            else if (textBox1.Text != "")
            {
                label5.ForeColor = Color.Red;
                label5.Text = @"INVALID USER ID";
                textBox2.Clear();             
            }         
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox4.Text == textBox3.Text)
            {
                label6.Text = "";
            }
            else
            {
                label6.ForeColor = Color.Red;
                label6.Text = @"PASSWORD DOES NOT MATCH";
            }
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                fill_textbox();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
