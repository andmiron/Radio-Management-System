namespace PublicUtilities
{
    partial class LOGIN_FORM
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            loginButton = new Button();
            loginUsernameInput = new TextBox();
            loginPasswordInput = new TextBox();
            exitAppButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngegg;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CadetBlue;
            label1.Location = new Point(19, 119);
            label1.Name = "label1";
            label1.Size = new Size(255, 37);
            label1.TabIndex = 1;
            label1.Text = "National Radio";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngegg__1_;
            pictureBox2.Location = new Point(24, 208);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.pngegg__2_;
            pictureBox3.Location = new Point(24, 259);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(71, 233);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 1);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(24, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(24, 290);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 6;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.CadetBlue;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("JetBrains Mono", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(24, 312);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(250, 50);
            loginButton.TabIndex = 7;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // loginUsernameInput
            // 
            loginUsernameInput.Location = new Point(55, 206);
            loginUsernameInput.Name = "loginUsernameInput";
            loginUsernameInput.PlaceholderText = "admin";
            loginUsernameInput.Size = new Size(219, 27);
            loginUsernameInput.TabIndex = 8;
            // 
            // loginPasswordInput
            // 
            loginPasswordInput.Location = new Point(55, 257);
            loginPasswordInput.Name = "loginPasswordInput";
            loginPasswordInput.PasswordChar = '*';
            loginPasswordInput.PlaceholderText = "admin";
            loginPasswordInput.Size = new Size(219, 27);
            loginPasswordInput.TabIndex = 9;
            // 
            // exitAppButton
            // 
            exitAppButton.BackColor = Color.Transparent;
            exitAppButton.Cursor = Cursors.Hand;
            exitAppButton.FlatAppearance.BorderSize = 0;
            exitAppButton.FlatStyle = FlatStyle.Flat;
            exitAppButton.Font = new Font("JetBrains Mono", 10.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitAppButton.ForeColor = Color.IndianRed;
            exitAppButton.Location = new Point(67, 400);
            exitAppButton.Name = "exitAppButton";
            exitAppButton.Size = new Size(155, 27);
            exitAppButton.TabIndex = 10;
            exitAppButton.Text = "Exit";
            exitAppButton.UseVisualStyleBackColor = false;
            exitAppButton.Click += exitAppButton_Click;
            // 
            // LOGIN_FORM
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(290, 439);
            Controls.Add(exitAppButton);
            Controls.Add(loginPasswordInput);
            Controls.Add(loginUsernameInput);
            Controls.Add(loginButton);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LOGIN_FORM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button loginButton;
        private TextBox loginUsernameInput;
        private TextBox loginPasswordInput;
        private Button exitAppButton;
    }
}
