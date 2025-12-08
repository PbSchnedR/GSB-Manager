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
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private Label labelTitle;
        private Label labelEmail;
        private Label labelPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Button buttonLogin;

        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelEmail = new Label();
            labelPassword = new Label();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();

            SuspendLayout();

            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(250, 40);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(240, 46);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "GSB Manager";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(260, 130);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(52, 20);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email :";

            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(260, 155);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(240, 27);
            textBoxEmail.TabIndex = 2;

            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(260, 210);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(84, 20);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password :";

            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(260, 235);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(240, 27);
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TabIndex = 4;

            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(310, 300);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(140, 35);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Connexion";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;

            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 450);
            Controls.Add(labelTitle);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonLogin);
            Name = "MainForm";
            Text = "GSB Manager";

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
