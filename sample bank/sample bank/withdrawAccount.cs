using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_bank
{
    public partial class withdrawAccount : Form
    {
        public withdrawAccount()
        {
            InitializeComponent();
        }

        private void withdrawAccount_Load(object sender, EventArgs e)
        {
            GetWithdrawDetails();
            lbTranId.Visible = false;
        }

        private void GetWithdrawDetails()
        {
            using (SqlConnection connection = Connections.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Transactions where status = 2", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lookAccount_withdraw lookaccountWindow = new lookAccount_withdraw();
            this.Hide();
            lookaccountWindow.ShowDialog();
        }

        private void ClearText()
        {
            nameBox.Clear();
            amountBox.Clear();
            balanceBox.Clear();
            descriptionBox.Clear();
            accountBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Connections.connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MakeWithdraw";
                cmd.Parameters.AddWithValue("@tranType", "Withdraw");
                cmd.Parameters.AddWithValue("@description", descriptionBox.Text);
                cmd.Parameters.AddWithValue("@amount", amountBox.Text);
                cmd.Parameters.AddWithValue("@accountNo", accountBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Withdrew successfully", "Withdraw", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                GetWithdrawDetails();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbTranId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            amountBox.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            accountBox.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            descriptionBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            amountBox.ReadOnly = true;
            getAccountName();
        }

        private void getAccountName()
        {
            using (SqlConnection connection = Connections.connect())
            {
                SqlCommand cmd = new SqlCommand("select c.custName, a.balance from Customer C inner join Account A on C.custId = A.custId where a.accountNo = @accNo", connection);

                cmd.Parameters.AddWithValue("@accNo", accountBox.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    nameBox.Text = dr["custName"].ToString();
                    //balanceBox.Text = dr["balance"].ToString();

                }
                else
                {
                    nameBox.Clear();
                    balanceBox.Clear();
                }
            }
        }

        private void amountBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(amountBox.Text);
                decimal balance = Convert.ToDecimal(balanceBox.Text);

                if (amount < 0)
                {
                    MessageBox.Show("Negative not allowed", "Validations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    amountBox.Clear();
                }
                if (amount > balance)
                {
                    MessageBox.Show("Haraagaga kuguma filna", "Validations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    amountBox.Clear();
                }
            }
            catch (Exception ex) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Connections.connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "cancelWithdrawTransaction";
                cmd.Parameters.AddWithValue("@tranId", lbTranId.Text);
                cmd.Parameters.AddWithValue("@amount", amountBox.Text);
                cmd.Parameters.AddWithValue("@accountNo", accountBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Withdraw canceled successfully", "Withdraw cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                GetWithdrawDetails();
            }
        }
    }
}
