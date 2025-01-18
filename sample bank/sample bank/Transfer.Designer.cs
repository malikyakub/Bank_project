namespace sample_bank
{
    partial class Transfer
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
            panel1 = new Panel();
            label4 = new Label();
            fromBalance = new TextBox();
            label3 = new Label();
            fromName = new TextBox();
            label2 = new Label();
            fromAccNo = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            toBalance = new TextBox();
            label6 = new Label();
            toName = new TextBox();
            label7 = new Label();
            toAccNo = new TextBox();
            label8 = new Label();
            label9 = new Label();
            transAmountBox = new TextBox();
            button1 = new Button();
            label10 = new Label();
            descriptionBox = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(fromBalance);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(fromName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(fromAccNo);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(385, 217);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(35, 159);
            label4.Name = "label4";
            label4.Size = new Size(73, 23);
            label4.TabIndex = 6;
            label4.Text = "Balance:";
            // 
            // fromBalance
            // 
            fromBalance.Location = new Point(120, 155);
            fromBalance.Name = "fromBalance";
            fromBalance.ReadOnly = true;
            fromBalance.Size = new Size(220, 27);
            fromBalance.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(48, 126);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 4;
            label3.Text = "Name:";
            label3.Click += label3_Click;
            // 
            // fromName
            // 
            fromName.Location = new Point(120, 122);
            fromName.Name = "fromName";
            fromName.ReadOnly = true;
            fromName.Size = new Size(220, 27);
            fromName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(20, 90);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 2;
            label2.Text = "Account #";
            // 
            // fromAccNo
            // 
            fromAccNo.Location = new Point(120, 86);
            fromAccNo.Name = "fromAccNo";
            fromAccNo.Size = new Size(220, 27);
            fromAccNo.TabIndex = 1;
            fromAccNo.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(74, 7);
            label1.Name = "label1";
            label1.Size = new Size(226, 46);
            label1.TabIndex = 0;
            label1.Text = "From account";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label5);
            panel2.Controls.Add(toBalance);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(toName);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(toAccNo);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(420, 26);
            panel2.Name = "panel2";
            panel2.Size = new Size(385, 217);
            panel2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(35, 159);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 6;
            label5.Text = "Balance:";
            // 
            // toBalance
            // 
            toBalance.Location = new Point(120, 155);
            toBalance.Name = "toBalance";
            toBalance.ReadOnly = true;
            toBalance.Size = new Size(220, 27);
            toBalance.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(48, 126);
            label6.Name = "label6";
            label6.Size = new Size(60, 23);
            label6.TabIndex = 4;
            label6.Text = "Name:";
            // 
            // toName
            // 
            toName.Location = new Point(120, 122);
            toName.Name = "toName";
            toName.ReadOnly = true;
            toName.Size = new Size(220, 27);
            toName.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(20, 90);
            label7.Name = "label7";
            label7.Size = new Size(88, 23);
            label7.TabIndex = 2;
            label7.Text = "Account #";
            // 
            // toAccNo
            // 
            toAccNo.Location = new Point(120, 86);
            toAccNo.Name = "toAccNo";
            toAccNo.Size = new Size(220, 27);
            toAccNo.TabIndex = 1;
            toAccNo.TextChanged += toAccno_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(104, 7);
            label8.Name = "label8";
            label8.Size = new Size(183, 46);
            label8.TabIndex = 0;
            label8.Text = "To account";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(177, 369);
            label9.Name = "label9";
            label9.Size = new Size(135, 23);
            label9.TabIndex = 8;
            label9.Text = "Transfer amount";
            // 
            // transAmountBox
            // 
            transAmountBox.Location = new Point(322, 368);
            transAmountBox.Name = "transAmountBox";
            transAmountBox.Size = new Size(220, 27);
            transAmountBox.TabIndex = 7;
            transAmountBox.TextChanged += transAmountBox_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(350, 430);
            button1.Name = "button1";
            button1.Size = new Size(108, 39);
            button1.TabIndex = 9;
            button1.Text = "transfer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(216, 253);
            label10.Name = "label10";
            label10.Size = new Size(96, 23);
            label10.TabIndex = 11;
            label10.Text = "Description";
            // 
            // descriptionBox
            // 
            descriptionBox.Location = new Point(322, 252);
            descriptionBox.Multiline = true;
            descriptionBox.Name = "descriptionBox";
            descriptionBox.Size = new Size(220, 110);
            descriptionBox.TabIndex = 10;
            // 
            // Transfer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 506);
            Controls.Add(label10);
            Controls.Add(descriptionBox);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(panel2);
            Controls.Add(transAmountBox);
            Controls.Add(panel1);
            Name = "Transfer";
            Text = "Transfer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox fromAccNo;
        private Label label1;
        private Label label4;
        private TextBox fromBalance;
        private Label label3;
        private TextBox fromName;
        private Label label2;
        private Panel panel2;
        private Label label5;
        private TextBox toBalance;
        private Label label6;
        private TextBox toName;
        private Label label7;
        private TextBox toAccNo;
        private Label label8;
        private Label label9;
        private TextBox transAmountBox;
        private Button button1;
        private Label label10;
        private TextBox descriptionBox;
    }
}