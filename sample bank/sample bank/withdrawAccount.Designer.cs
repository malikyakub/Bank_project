namespace sample_bank
{
    partial class withdrawAccount
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label6 = new Label();
            amountBox = new TextBox();
            descriptionBox = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            balanceBox = new TextBox();
            label3 = new Label();
            nameBox = new TextBox();
            label2 = new Label();
            accountBox = new TextBox();
            button3 = new Button();
            label1 = new Label();
            lbTranId = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 438);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(800, 305);
            dataGridView1.TabIndex = 38;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.SpringGreen;
            button2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(481, 118);
            button2.Name = "button2";
            button2.Size = new Size(100, 27);
            button2.TabIndex = 37;
            button2.Text = "FIND";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(194, 331);
            label6.Name = "label6";
            label6.Size = new Size(62, 20);
            label6.TabIndex = 36;
            label6.Text = "Amount";
            // 
            // amountBox
            // 
            amountBox.Location = new Point(267, 324);
            amountBox.Name = "amountBox";
            amountBox.Size = new Size(314, 27);
            amountBox.TabIndex = 35;
            amountBox.TextChanged += amountBox_TextChanged;
            // 
            // descriptionBox
            // 
            descriptionBox.Location = new Point(267, 217);
            descriptionBox.Multiline = true;
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(314, 101);
            descriptionBox.TabIndex = 34;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Agency FB", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(275, 357);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 33;
            button1.Text = "WITHDRAW";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 224);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 32;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 191);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 31;
            label4.Text = "Balance";
            // 
            // balanceBox
            // 
            balanceBox.Location = new Point(267, 184);
            balanceBox.Name = "balanceBox";
            balanceBox.ReadOnly = true;
            balanceBox.Size = new Size(314, 27);
            balanceBox.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 158);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 29;
            label3.Text = "Name";
            // 
            // nameBox
            // 
            nameBox.Location = new Point(267, 151);
            nameBox.Name = "nameBox";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(314, 27);
            nameBox.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 125);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 27;
            label2.Text = "Account #";
            // 
            // accountBox
            // 
            accountBox.Location = new Point(267, 118);
            accountBox.Name = "accountBox";
            accountBox.ReadOnly = true;
            accountBox.Size = new Size(208, 27);
            accountBox.TabIndex = 26;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Agency FB", 12F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(431, 357);
            button3.Name = "button3";
            button3.Size = new Size(150, 40);
            button3.TabIndex = 39;
            button3.Text = "CALCEL WITHDRAW";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 40.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(171, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 80);
            label1.TabIndex = 40;
            label1.Text = "Make withdraw";
            // 
            // lbTranId
            // 
            lbTranId.AutoSize = true;
            lbTranId.Location = new Point(587, 121);
            lbTranId.Name = "lbTranId";
            lbTranId.Size = new Size(0, 20);
            lbTranId.TabIndex = 41;
            // 
            // withdrawAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 743);
            Controls.Add(lbTranId);
            Controls.Add(label1);
            Controls.Add(button3);
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
            Name = "withdrawAccount";
            Text = "withdrawAccount";
            Load += withdrawAccount_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button2;
        private Label label6;
        public TextBox amountBox;
        public TextBox descriptionBox;
        private Button button1;
        private Label label5;
        private Label label4;
        public TextBox balanceBox;
        private Label label3;
        public TextBox nameBox;
        private Label label2;
        public TextBox accountBox;
        private Button button3;
        private Label label1;
        private Label lbTranId;
    }
}