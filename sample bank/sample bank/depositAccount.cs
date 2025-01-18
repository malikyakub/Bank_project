using System;
using System.CodeDom;
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
    public partial class depositaccount : Form
    {
        public object DataTable { get; private set; }

        public depositaccount()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lookAccount_deposit lookaccountWindow = new lookAccount_deposit();
            this.Hide();
            lookaccountWindow.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Connections.connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MakeDeposit";
                cmd.Parameters.AddWithValue("@tranType", "Deposit");
                cmd.Parameters.AddWithValue("@description", descriptionBox.Text);
                cmd.Parameters.AddWithValue("@amount", amountBox.Text);
                cmd.Parameters.AddWithValue("@accountNo", accountBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deposit successfully", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                GetDepositDetails();
            }
        }

        private void ClearText()
        {
            nameBox.Clear();
            amountBox.Clear();
            balanceBox.Clear();
            descriptionBox.Clear();
            accountBox.Clear();
        }

        private void depositaccount_Load(object sender, EventArgs e)
        {
            GetDepositDetails();
            lbTranId.Visible = false;
        }

        private void GetDepositDetails()
        {
            using (SqlConnection connection = Connections.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select * from Transactions where status = 1", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

            }
        }

        private void descriptionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void amountBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(amountBox.Text);

                if (amount <= 0)
                {
                    MessageBox.Show("Please provide a valid amount, idiot", "Amount Validations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    amountBox.Clear();
                    return;
                }
                else if (amount == 0)
                {
                    MessageBox.Show("Are you series right now", "Amount Validations", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
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
                if (dr.Read()) {
                    nameBox.Text = dr["custName"].ToString();
                    balanceBox.Text = dr["balance"].ToString();

                }
                else
                {
                    nameBox.Clear();
                    balanceBox.Clear();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = Connections.connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "cancelDepositTransaction";
                cmd.Parameters.AddWithValue("@tranId", lbTranId.Text);
                cmd.Parameters.AddWithValue("@amount", amountBox.Text);
                cmd.Parameters.AddWithValue("@accountNo", accountBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deposit canceled successfully", "Deposit cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                GetDepositDetails();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
