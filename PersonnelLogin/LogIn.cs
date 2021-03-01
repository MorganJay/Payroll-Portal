using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PersonnelLogin
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            ActiveControl = textBox1;
        }

        public SqlConnection Con = new SqlConnection(@"Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT Department FROM LogIn WHERE Email = '" + textBox1.Text + "' " +
                                                        "AND Password = '" + textBox2.Text + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    Hide();
                    PayrollPortalWindow ss = new PayrollPortalWindow(dt.Rows[0][0].ToString());
                    ss.Show();
                    WelcomeMessage();
                }
                else
                {
                    MessageBox.Show(@"Please Check Your User ID and Password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void WelcomeMessage()
        {
            Con.Open();
            SqlCommand cmd = Con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM EmployeeBiodata WHERE Email = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                MessageBox.Show(@" Welcome " + dr["Surname"]);
            }
            Con.Close();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
        }
    }
}