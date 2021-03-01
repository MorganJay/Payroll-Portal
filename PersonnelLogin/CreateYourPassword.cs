using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonnelLogin
{
    public partial class CreateYourPassword : Form
    {
        public CreateYourPassword()
        {
            InitializeComponent();          
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void CreateYourPassword_Load(object sender, EventArgs e)
        {
        }

        public SqlCommand Cmd;
        private readonly SqlConnection _con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");

        public void IdValidation()
        {
            if (textBox1.Text == "")
            {
                label4.Text = "";
            }
            else
            {
                Cmd = new SqlCommand("SELECT * FROM EmployeeBiodata WHERE Email = '" + textBox1.Text + "'", _con);
                SqlDataAdapter da = new SqlDataAdapter(Cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Display();
                    label4.Text = "";
                }
                else
                {
                    label4.ForeColor = Color.Red;
                    label4.Text = @"INVALID USER ID";
                }
            }
        }

        public void Display()
        {
            if (textBox1.Text == "") return;
            var command = new SqlCommand("SELECT * FROM EmployeeBiodata WHERE Email = '" + textBox1.Text + "'", _con);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dat = new DataTable();
            da.Fill(dat);
            if (dat.Rows.Count == 1)
            {
                _con.Open();
                var cmd = _con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM View_2 WHERE Email = '" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    textBox5.Text = dr["DeptName"].ToString();
                }
                _con.Close();
            }
            else
            {
                textBox5.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
             Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show(@"Please Fill All Fields", @"", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);              
            }
            else if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show(@"Password Mismatch", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (label4.Text == @"INVALID USER ID")
            {
                MessageBox.Show(@"INVALID USER ID", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                _con.Open();
                var query = "INSERT INTO LogIn (Email,Password,Department) VALUES('" + textBox1.Text + "','" +
                            textBox3.Text + "','" + textBox5.Text + "')";
                var sda = new SqlDataAdapter(query, _con);
                sda.SelectCommand.ExecuteNonQuery();
                _con.Close();
                MessageBox.Show(@"Password Added Successfully!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            IdValidation();
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            IdValidation();
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            IdValidation();
        }

        private void textBox1_CursorChanged(object sender, EventArgs e)
        {
            IdValidation();
        }
    }
}
