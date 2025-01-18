using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sample_bank
{
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = Connections.connect())
            {
                SqlCommand cmd = new SqlCommand("select c.custName, a.balance from Customer C inner join Account A on C.custId = A.custId where a.accountNo = @accNo", connection);

                cmd.Parameters.AddWithValue("@accNo", fromAccNo.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    fromName.Text = dr["custName"].ToString();
                    fromBalance.Text = dr["balance"].ToString();

                }
                else
                {
                    fromName.Clear();
                    fromBalance.Clear();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toAccno_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = Connections.connect())
            {
                SqlCommand cmd = new SqlCommand("select c.custName, a.balance from Customer C inner join Account A on C.custId = A.custId where a.accountNo = @accNo", connection);

                cmd.Parameters.AddWithValue("@accNo", toAccNo.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    toName.Text = dr["custName"].ToString();
                    toBalance.Text = dr["balance"].ToString();

                }
                else
                {
                    toName.Clear();
                    toBalance.Clear();
                }
            }
        }

        private void transAmountBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal amount = Convert.ToDecimal(transAmountBox.Text);
                if (amount <= 0)
                {
                    MessageBox.Show("Not allowed");
                    transAmountBox.Clear();
                    return;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fromAccNo.Text == toAccNo.Text)
            {
                MessageBox.Show("same accounts are not allowed");
                toAccNo.Clear();
                fromAccNo.Clear();
            }

            using (SqlConnection connection = Connections.connect())
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "MakeTransfer";
                cmd.Parameters.AddWithValue("@tranType", "withdraw");
                cmd.Parameters.AddWithValue("@description", descriptionBox.Text);
                cmd.Parameters.AddWithValue("@amount", transAmountBox.Text);
                cmd.Parameters.AddWithValue("@accountNo1", fromAccNo.Text);
                cmd.Parameters.AddWithValue("@accountNo2", toAccNo.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Transfered successfully", "Transfer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toAccNo.Clear();
                fromAccNo.Clear();
            }
        }
    }
}
