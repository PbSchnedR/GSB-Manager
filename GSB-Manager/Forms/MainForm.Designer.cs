namespace GSB_Manager.Forms
{
    partial class MainForm
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
            groupBox1 = new GroupBox();
            buttonLogin = new Button();
            labelPassword = new Label();
            labelEmail = new Label();
            textBoxPassword = new TextBox();
            textBoxEmail = new TextBox();
            labelLogin = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonLogin);
            groupBox1.Controls.Add(labelPassword);
            groupBox1.Controls.Add(labelEmail);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(labelLogin);
            groupBox1.Location = new Point(166, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 320);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(178, 266);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Connect";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(166, 192);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(70, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(166, 111);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 3;
            labelEmail.Text = "email";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(166, 215);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(125, 27);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(166, 134);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 1;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Location = new Point(194, 44);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(46, 20);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "Login";
            // 
            // MainForm
            // 
            ClientSize = new Size(777, 461);
            Controls.Add(groupBox1);
            Name = "MainForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelLogin;
        private Button buttonLogin;
        private Label labelPassword;
        private Label labelEmail;
        private TextBox textBoxPassword;
        private TextBox textBoxEmail;
    }
}
