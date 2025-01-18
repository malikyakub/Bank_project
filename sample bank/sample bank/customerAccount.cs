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
    public partial class customeraccount : Form
    {
        public customeraccount()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = Connections.connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "CustomerAccount";
                cmd.Parameters.AddWithValue("@custName", nameBox.Text);
                cmd.Parameters.AddWithValue("@address", addressBox.Text);
                cmd.Parameters.AddWithValue("@phone", phoneBox.Text);
                cmd.Parameters.AddWithValue("@accountType", accountTypeComboBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account created succesifully", "Account creation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetCustomerAccount();
                ClearText();
            }
        }

        private void ClearText()
        {
            nameBox.Clear();
            addressBox.Clear();
            phoneBox.Clear();
            accountTypeComboBox.SelectedIndex = -1;
        }

        private void customeraccount_Load(object sender, EventArgs e)
        {
            GetCustomerAccount();
        }

        private void GetCustomerAccount()
        {
            using (SqlConnection connection = Connections.connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetCustomerAccount";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
