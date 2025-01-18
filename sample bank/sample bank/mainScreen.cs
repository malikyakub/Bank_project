namespace sample_bank
{
    public partial class mainscreen : Form
    {
        public mainscreen()
        {
            InitializeComponent();
        }

        private void createAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customeraccount customeraccountWindow = new customeraccount();
            customeraccountWindow.ShowDialog();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            depositaccount depositaccountWindow = new depositaccount();
            depositaccountWindow.ShowDialog();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            withdrawAccount withdrawWindow = new withdrawAccount();
            withdrawWindow.ShowDialog();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfer transferWindow = new Transfer();
            transferWindow.ShowDialog();
        }

        private void mainscreen_Load(object sender, EventArgs e)
        {
            Login loginpage = new Login();
            loginpage.ShowDialog();
        }
    }
}
