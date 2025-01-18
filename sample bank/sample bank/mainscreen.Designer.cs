namespace sample_bank
{
    partial class mainscreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            manageUsersToolStripMenuItem = new ToolStripMenuItem();
            accountsToolStripMenuItem = new ToolStripMenuItem();
            createAccountToolStripMenuItem = new ToolStripMenuItem();
            transactionsToolStripMenuItem = new ToolStripMenuItem();
            depositToolStripMenuItem = new ToolStripMenuItem();
            withdrawToolStripMenuItem = new ToolStripMenuItem();
            transferToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { manageUsersToolStripMenuItem, accountsToolStripMenuItem, transactionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // manageUsersToolStripMenuItem
            // 
            manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            manageUsersToolStripMenuItem.Size = new Size(116, 24);
            manageUsersToolStripMenuItem.Text = "Manage Users";
            // 
            // accountsToolStripMenuItem
            // 
            accountsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { createAccountToolStripMenuItem });
            accountsToolStripMenuItem.Name = "accountsToolStripMenuItem";
            accountsToolStripMenuItem.Size = new Size(83, 24);
            accountsToolStripMenuItem.Text = "Accounts";
            // 
            // createAccountToolStripMenuItem
            // 
            createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            createAccountToolStripMenuItem.Size = new Size(189, 26);
            createAccountToolStripMenuItem.Text = "create account";
            createAccountToolStripMenuItem.Click += createAccountToolStripMenuItem_Click;
            // 
            // transactionsToolStripMenuItem
            // 
            transactionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { depositToolStripMenuItem, withdrawToolStripMenuItem, transferToolStripMenuItem });
            transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            transactionsToolStripMenuItem.Size = new Size(104, 24);
            transactionsToolStripMenuItem.Text = "Transactions";
            // 
            // depositToolStripMenuItem
            // 
            depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            depositToolStripMenuItem.Size = new Size(156, 26);
            depositToolStripMenuItem.Text = "Deposit";
            depositToolStripMenuItem.Click += depositToolStripMenuItem_Click;
            // 
            // withdrawToolStripMenuItem
            // 
            withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            withdrawToolStripMenuItem.Size = new Size(156, 26);
            withdrawToolStripMenuItem.Text = "Withdraw";
            withdrawToolStripMenuItem.Click += withdrawToolStripMenuItem_Click;
            // 
            // transferToolStripMenuItem
            // 
            transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            transferToolStripMenuItem.Size = new Size(156, 26);
            transferToolStripMenuItem.Text = "Transfer";
            transferToolStripMenuItem.Click += transferToolStripMenuItem_Click;
            // 
            // mainscreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "mainscreen";
            Text = "main screen";
            WindowState = FormWindowState.Maximized;
            Load += mainscreen_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem manageUsersToolStripMenuItem;
        private ToolStripMenuItem accountsToolStripMenuItem;
        private ToolStripMenuItem createAccountToolStripMenuItem;
        private ToolStripMenuItem transactionsToolStripMenuItem;
        private ToolStripMenuItem depositToolStripMenuItem;
        private ToolStripMenuItem withdrawToolStripMenuItem;
        private ToolStripMenuItem transferToolStripMenuItem;
    }
}
