using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sample_bank
{
    public partial class Login : Form
    {
        mainscreen ms = new mainscreen();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string pass = passBox.Text;

            if (AuthenticateUser(username, pass)) {
                MessageBox.Show("success");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid");
            }

;        }
        private bool AuthenticateUser(string username, string pass)
        {
            using(SqlConnection connection = Connections.connect())
            {
                string sql = "SELECT * FROM users WHERE username = @username and password = @password";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", pass);

                SqlDataReader  dr =  cmd.ExecuteReader();

                if (dr.Read()) {
                    string type = dr["userType"].ToString();
                }

                return dr.HasRows;
            }
        }
    }
}
