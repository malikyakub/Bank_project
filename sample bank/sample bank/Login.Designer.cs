namespace sample_bank
{
    partial class Login
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
            label1 = new Label();
            label2 = new Label();
            usernameBox = new TextBox();
            passBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(31, 116);
            label1.Name = "label1";
            label1.Size = new Size(91, 23);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(31, 163);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(146, 116);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(190, 27);
            usernameBox.TabIndex = 2;
            // 
            // passBox
            // 
            passBox.Location = new Point(146, 163);
            passBox.Name = "passBox";
            passBox.Size = new Size(190, 27);
            passBox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(135, 231);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 324);
            Controls.Add(button1);
            Controls.Add(passBox);
            Controls.Add(usernameBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameBox;
        private TextBox passBox;
        private Button button1;
    }
}