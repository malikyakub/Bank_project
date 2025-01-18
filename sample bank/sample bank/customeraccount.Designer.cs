namespace sample_bank
{
    partial class customeraccount
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            label1 = new Label();
            nameBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            addressBox = new TextBox();
            label4 = new Label();
            phoneBox = new TextBox();
            label5 = new Label();
            accountTypeComboBox = new ComboBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Agency FB", 40.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(103, 9);
            label1.Name = "label1";
            label1.Size = new Size(535, 79);
            label1.TabIndex = 0;
            label1.Text = "New Customer Account";
            label1.Click += label1_Click;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(257, 114);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(314, 27);
            nameBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(117, 121);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 2;
            label2.Text = "Customer Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 154);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 5;
            label3.Text = "Address";
            // 
            // addressBox
            // 
            addressBox.Location = new Point(257, 147);
            addressBox.Name = "addressBox";
            addressBox.Size = new Size(314, 27);
            addressBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 187);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 7;
            label4.Text = "Phone";
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(257, 180);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(314, 27);
            phoneBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(140, 221);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 8;
            label5.Text = "Account type";
            label5.Click += label5_Click;
            // 
            // accountTypeComboBox
            // 
            accountTypeComboBox.FormattingEnabled = true;
            accountTypeComboBox.Items.AddRange(new object[] { "Bussiness", "Family", "Saving", "Student" });
            accountTypeComboBox.Location = new Point(257, 213);
            accountTypeComboBox.Name = "accountTypeComboBox";
            accountTypeComboBox.Size = new Size(314, 28);
            accountTypeComboBox.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Font = new Font("Arabic Typesetting", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(300, 267);
            button1.Name = "button1";
            button1.Size = new Size(150, 40);
            button1.TabIndex = 11;
            button1.Text = "CREATE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.Location = new Point(0, 357);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.Size = new Size(800, 386);
            dataGridView1.TabIndex = 12;
            // 
            // customeraccount
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 743);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(accountTypeComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(phoneBox);
            Controls.Add(label3);
            Controls.Add(addressBox);
            Controls.Add(label2);
            Controls.Add(nameBox);
            Controls.Add(label1);
            Name = "customeraccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer account";
            Load += customeraccount_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameBox;
        private Label label2;
        private Label label3;
        private TextBox addressBox;
        private Label label4;
        private TextBox phoneBox;
        private Label label5;
        private ComboBox accountTypeComboBox;
        private Button button1;
        private DataGridView dataGridView1;
    }
}