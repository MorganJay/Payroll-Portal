using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PersonnelLogin
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        SqlConnection con = new SqlConnection("Data Source=JMORGAN_SCHULPC;Initial Catalog=LogIn;Integrated Security=True");
        private void searchbutton_Click(object sender, EventArgs e)
        {
            if (idtextBox.Text == "" && nametextBox.Text == "")
            {
                MessageBox.Show("DO YOU WANT TO SEARCH OR NOT??!!");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM LogIn WHERE Id = '" + idtextBox.Text + "' OR  Surname = '" + nametextBox.Text + "' OR OtherNames = '" + nametextBox.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                Hide();

                foreach (DataRow dr in dt.Rows)
                {
                    ;                
                 }
                con.Close();
            }
        }

        // public void validation()
        //{
        //   SqlCommand cmd = new SqlCommand("SELECT * FROM LogIn WHERE Id = '" + idtextBox.Text + "' OR  Surname = '" + nametextBox.Text + "' OR OtherNames = '" + nametextBox.Text + "'", con);
        //   //SqlDataAdapter da = new SqlDataAdapter(cmd);
        //   //DataTable dt = new DataTable();
        //   //da.Fill(dt);
        //   //if (dt.Rows.Count == 1)
        //   //{
        //   con.Open();
        //   cmd = con.CreateCommand();
        //   cmd.CommandType = CommandType.Text;
        //   cmd.CommandText = "SELECT * FROM LogIn WHERE Id = '" + idtextBox.Text + "' OR  Surname = '" + nametextBox.Text + "' OR OtherNames = '" + nametextBox.Text + "'";
        //   cmd.ExecuteNonQuery();
        //   DataTable dt = new DataTable();
        //   SqlDataAdapter da = new SqlDataAdapter(cmd);
        //   con.Close()
    }
}

