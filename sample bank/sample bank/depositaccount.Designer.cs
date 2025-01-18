namespace sample_bank
{
    partial class depositaccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label4 = new Label();
            label3 = new Label();
            nameBox = new TextBox();
            label2 = new Label();
            accountBox = new TextBox();
            label1 = new Label();
            balanceBox = new TextBox();
            label5 = new Label();
            button1 = new Button();
            descriptionBox = new TextBox();
            amountBox = new TextBox();
            label6 = new Label();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            cancelDeposit = new Button();
            lbTranId = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 200);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 14;
            label4.Text = "Balance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 167);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 12;
            label3.Text = "Name";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(267, 160);
            nameBox.Name = "nameBox";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(314, 27);
            nameBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 134);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 10;
            label2.Text = "Account #";
            // 
            // accountBox
            // 
            accountBox.Location = new Point(267, 127);
            accountBox.Name = "accountBox";
            accountBox.ReadOnly = true;
            accountBox.Size = new Size(193, 27);
            accountBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(171, 25);
            label1.Name = "label1";
            label1.Size = new Size(331, 80);
            label1.TabIndex = 8;
            label1.Text = "Make deposit";
            // 
            // balanceBox
            // 
            balanceBox.Location = new Point(267, 193);
            balanceBox.Name = "balanceBox";
            balanceBox.ReadOnly = true;
            balanceBox.Size = new Size(314, 27);
            balanceBox.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 233);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 15;
            label5.Text = "Description";
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(278, 379);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 19;
            button1.Text = "DEPOSIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // descriptionBox
            // 
            descriptionBox.Location = new Point(267, 226);
            descriptionBox.Multiline = true;
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(314, 101);
            descriptionBox.TabIndex = 20;
            descriptionBox.TextChanged += descriptionBox_TextChanged;
            // 
            // amountBox
            // 
            amountBox.Location = new Point(267, 333);
            amountBox.Name = "amountBox";
            amountBox.Size = new Size(314, 27);
            amountBox.TabIndex = 21;
            amountBox.TextChanged += amountBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(194, 340);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 22;
            label6.Text = "Amount";
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(466, 127);
            button2.Name = "button2";
            button2.Size = new Size(115, 27);
            button2.TabIndex = 23;
            button2.Text = "FIND";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 438);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 305);
            dataGridView1.TabIndex = 24;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // cancelDeposit
            // 
            cancelDeposit.BackColor = Color.Red;
            cancelDeposit.Font = new Font("Agency FB", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelDeposit.ForeColor = Color.White;
            cancelDeposit.Location = new Point(434, 379);
            cancelDeposit.Name = "cancelDeposit";
            cancelDeposit.Size = new Size(150, 40);
            cancelDeposit.TabIndex = 25;
            cancelDeposit.Text = "CANCEL DEPOSIT";
            cancelDeposit.UseVisualStyleBackColor = false;
            cancelDeposit.Click += button3_Click;
            // 
            // lbTranId
            // 
            lbTranId.AutoSize = true;
            lbTranId.Location = new Point(607, 129);
            lbTranId.Name = "lbTranId";
            lbTranId.Size = new Size(0, 20);
            lbTranId.TabIndex = 26;
            lbTranId.Click += label7_Click;
            // 
            // depositaccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 743);
            Controls.Add(lbTranId);
            Controls.Add(cancelDeposit);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(amountBox);
            Controls.Add(descriptionBox);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(balanceBox);
            Controls.Add(label3);
            Controls.Add(nameBox);
            Controls.Add(label2);
            Controls.Add(accountBox);
            Controls.Add(label1);
            Name = "depositaccount";
            Text = "depositaccount";
            Load += depositaccount_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        public TextBox nameBox;
        public TextBox accountBox;
        public TextBox balanceBox;
        private Button button1;
        public TextBox descriptionBox;
        public TextBox amountBox;
        private Label label6;
        private Button button2;
        private DataGridView dataGridView1;
        private Button cancelDeposit;
        private Label lbTranId;
    }
}