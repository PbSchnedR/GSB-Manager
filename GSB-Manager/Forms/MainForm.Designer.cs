namespace GSB_Manager.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label labelTitle;
        private Label labelEmail;
        private Label labelPassword;
        private TextBox textBoxEmail;
        private TextBox textBoxPassword;
        private Button buttonLogin;

        // Taille de référence (la taille par défaut)
        private readonly Size referenceSize = new Size(760, 450);

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelTitle = new Label();
            labelEmail = new Label();
            labelPassword = new Label();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();

            SuspendLayout();

            // MainForm responsive basics
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 450);
            MinimumSize = new Size(400, 300); // Taille minimale pour éviter un affichage trop petit

            // 
            // labelTitle
            // 
            labelTitle.AutoSize = false;
            labelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(0, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(ClientSize.Width, 46);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "GSB Manager";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(260, 120);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(52, 20);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email :";

            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(260, 145);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(240, 27);
            textBoxEmail.TabIndex = 2;

            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(260, 200);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(84, 20);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password :";

            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(260, 225);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(240, 27);
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TabIndex = 4;

            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(310, 290);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(140, 35);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Connexion";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;

            // Add controls
            Controls.Add(labelTitle);
            Controls.Add(labelEmail);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonLogin);

            Name = "MainForm";
            Text = "GSB Manager";

            // Gérer le redimensionnement
            Resize += MainForm_Resize;

            ResumeLayout(false);
            PerformLayout();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Calculer les facteurs d'échelle
            float scaleX = (float)ClientSize.Width / referenceSize.Width;
            float scaleY = (float)ClientSize.Height / referenceSize.Height;

            // Utiliser le plus petit facteur pour garder les proportions
            float scale = Math.Min(scaleX, scaleY);

            // Mettre à l'échelle labelTitle
            labelTitle.Font = new Font("Segoe UI", 20F * scale, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(0, (int)(20 * scaleY));
            labelTitle.Size = new Size(ClientSize.Width, (int)(46 * scaleY));

            // Mettre à l'échelle labelEmail
            labelEmail.Font = new Font("Segoe UI", 11F * scale, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point((int)(260 * scaleX), (int)(120 * scaleY));

            // Mettre à l'échelle textBoxEmail
            textBoxEmail.Font = new Font("Segoe UI", 9F * scale, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point((int)(260 * scaleX), (int)(145 * scaleY));
            textBoxEmail.Size = new Size((int)(240 * scaleX), (int)(27 * scaleY));

            // Mettre à l'échelle labelPassword
            labelPassword.Font = new Font("Segoe UI", 11F * scale, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point((int)(260 * scaleX), (int)(200 * scaleY));

            // Mettre à l'échelle textBoxPassword
            textBoxPassword.Font = new Font("Segoe UI", 9F * scale, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point((int)(260 * scaleX), (int)(225 * scaleY));
            textBoxPassword.Size = new Size((int)(240 * scaleX), (int)(27 * scaleY));

            // Mettre à l'échelle buttonLogin (centré horizontalement)
            buttonLogin.Font = new Font("Segoe UI", 9F * scale, FontStyle.Regular, GraphicsUnit.Point);
            int buttonWidth = (int)(140 * scaleX);
            buttonLogin.Location = new Point((ClientSize.Width - buttonWidth) / 2, (int)(290 * scaleY));
            buttonLogin.Size = new Size(buttonWidth, (int)(35 * scaleY));
        }
    }
}