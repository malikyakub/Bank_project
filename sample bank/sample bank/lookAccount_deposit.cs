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
    public partial class lookAccount_deposit : Form
    {
        public lookAccount_deposit()
        {
            InitializeComponent();
        }

        private void lookaccount_Load(object sender, EventArgs e)
        {
            GetAccountDetail();
        }

        private void GetAccountDetail()
        {
            using (SqlConnection connection = Connections.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select c.custName, a.accountNo, a.balance from Customer C inner join Account A on c.custId = a.custId", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = Connections.connect())
            {
                SqlDataAdapter da = new SqlDataAdapter("select c.custName, a.accountNo, a.balance from Customer C inner join Account A on c.custId = a.custId where c.custName like '" + searchBox.Text + "%'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            depositaccount depositaccountWindow = new depositaccount();
            depositaccountWindow.accountBox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            depositaccountWindow.nameBox.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            depositaccountWindow.balanceBox.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            this.Hide();
            depositaccountWindow.ShowDialog();
        }
    }
}
