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
        private Panel panelBackground;
        private Panel panelLoginCard;

        // Taille de référence (la taille par défaut)
        private readonly Size referenceSize = new Size(900, 600);

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelBackground = new Panel();
            panelLoginCard = new Panel();
            labelTitle = new Label();
            labelEmail = new Label();
            labelPassword = new Label();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();

            panelBackground.SuspendLayout();
            panelLoginCard.SuspendLayout();
            SuspendLayout();

            // MainForm
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 600);
            MinimumSize = new Size(600, 400);
            BackColor = Color.FromArgb(15, 23, 42);
            FormBorderStyle = FormBorderStyle.Sizable;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = true;
            MinimizeBox = true;

            // 
            // panelBackground
            // 
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.BackColor = Color.FromArgb(15, 23, 42);
            panelBackground.Location = new Point(0, 0);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(900, 600);
            panelBackground.TabIndex = 0;
            panelBackground.Paint += panelBackground_Paint;

            // 
            // panelLoginCard
            // 
            panelLoginCard.BackColor = Color.FromArgb(30, 41, 59);
            panelLoginCard.Location = new Point(300, 150);
            panelLoginCard.Name = "panelLoginCard";
            panelLoginCard.Size = new Size(380, 420);
            panelLoginCard.TabIndex = 0;
            panelLoginCard.Paint += panelLoginCard_Paint;
            panelLoginCard.Controls.Add(labelTitle);
            panelLoginCard.Controls.Add(labelEmail);
            panelLoginCard.Controls.Add(textBoxEmail);
            panelLoginCard.Controls.Add(labelPassword);
            panelLoginCard.Controls.Add(textBoxPassword);
            panelLoginCard.Controls.Add(buttonLogin);

            // 
            // labelTitle
            // 
            labelTitle.AutoSize = false;
            labelTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.FromArgb(226, 232, 240);
            labelTitle.Location = new Point(0, 30);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(380, 70);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "GSB Manager";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;

            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.FromArgb(148, 163, 184);
            labelEmail.Location = new Point(50, 140);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(52, 20);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email";

            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxEmail.BackColor = Color.FromArgb(51, 65, 85);
            textBoxEmail.Location = new Point(50, 170);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(280, 32);
            textBoxEmail.TabIndex = 2;

            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.ForeColor = Color.FromArgb(148, 163, 184);
            labelPassword.Location = new Point(50, 225);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(84, 20);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Password";

            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxPassword.BackColor = Color.FromArgb(51, 65, 85);
            textBoxPassword.Location = new Point(50, 255);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(280, 32);
            textBoxPassword.UseSystemPasswordChar = true;
            textBoxPassword.TabIndex = 4;

            // 
            // buttonLogin
            // 
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.BackColor = Color.FromArgb(16, 185, 129);
            buttonLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(90, 325);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(200, 50);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Sign In";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.Click += buttonLogin_Click;
            buttonLogin.Paint += buttonLogin_Paint;
            buttonLogin.MouseEnter += buttonLogin_MouseEnter;
            buttonLogin.MouseLeave += buttonLogin_MouseLeave;

            // Add controls
            panelBackground.Controls.Add(panelLoginCard);
            Controls.Add(panelBackground);

            Name = "MainForm";
            Text = "GSB Manager - Login";

            // Gérer le redimensionnement
            Resize += MainForm_Resize;

            panelBackground.ResumeLayout(false);
            panelLoginCard.ResumeLayout(false);
            panelLoginCard.PerformLayout();
            ResumeLayout(false);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Calculer les facteurs d'échelle
            float scaleX = (float)ClientSize.Width / referenceSize.Width;
            float scaleY = (float)ClientSize.Height / referenceSize.Height;
            float scale = Math.Min(scaleX, scaleY);

            // Centrer la carte de login
            int cardWidth = (int)(380 * scale);
            int cardHeight = (int)(420 * scale);
            panelLoginCard.Location = new Point((ClientSize.Width - cardWidth) / 2, (ClientSize.Height - cardHeight) / 2);
            panelLoginCard.Size = new Size(cardWidth, cardHeight);

            // Mettre à l'échelle labelTitle
            labelTitle.Font = new Font("Segoe UI", 28F * scale, FontStyle.Bold, GraphicsUnit.Point);
            labelTitle.Location = new Point(0, (int)(30 * scale));
            labelTitle.Size = new Size(cardWidth, (int)(70 * scale));

            // Mettre à l'échelle labelEmail
            labelEmail.Font = new Font("Segoe UI Semibold", 11F * scale, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point((int)(50 * scale), (int)(140 * scale));

            // Mettre à l'échelle textBoxEmail
            textBoxEmail.Font = new Font("Segoe UI", 11F * scale, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmail.Location = new Point((int)(50 * scale), (int)(170 * scale));
            textBoxEmail.Size = new Size((int)(280 * scale), (int)(32 * scale));

            // Mettre à l'échelle labelPassword
            labelPassword.Font = new Font("Segoe UI Semibold", 11F * scale, FontStyle.Bold, GraphicsUnit.Point);
            labelPassword.Location = new Point((int)(50 * scale), (int)(225 * scale));

            // Mettre à l'échelle textBoxPassword
            textBoxPassword.Font = new Font("Segoe UI", 11F * scale, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point((int)(50 * scale), (int)(255 * scale));
            textBoxPassword.Size = new Size((int)(280 * scale), (int)(32 * scale));

            // Mettre à l'échelle buttonLogin
            buttonLogin.Font = new Font("Segoe UI Semibold", 12F * scale, FontStyle.Bold, GraphicsUnit.Point);
            int buttonWidth = (int)(200 * scale);
            buttonLogin.Location = new Point((cardWidth - buttonWidth) / 2, (int)(325 * scale));
            buttonLogin.Size = new Size(buttonWidth, (int)(50 * scale));

            panelBackground.Invalidate();
            panelLoginCard.Invalidate();
        }

        // Dessiner le fond moderne et professionnel
        private void panelBackground_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Fond uni sombre
            using (var brush = new SolidBrush(Color.FromArgb(15, 23, 42)))
            {
                e.Graphics.FillRectangle(brush, panelBackground.ClientRectangle);
            }

            // Grille subtile (lignes verticales et horizontales)
            using (var gridPen = new Pen(Color.FromArgb(15, 51, 65, 85), 1))
            {
                int spacing = 40;

                // Lignes verticales
                for (int x = 0; x < ClientSize.Width; x += spacing)
                {
                    e.Graphics.DrawLine(gridPen, x, 0, x, ClientSize.Height);
                }

                // Lignes horizontales
                for (int y = 0; y < ClientSize.Height; y += spacing)
                {
                    e.Graphics.DrawLine(gridPen, 0, y, ClientSize.Width, y);
                }
            }

            // Accent lumineux en haut à gauche
            using (var glowBrush = new System.Drawing.Drawing2D.PathGradientBrush(
                new Point[] {
                    new Point(0, 0),
                    new Point(300, 0),
                    new Point(300, 300),
                    new Point(0, 300)
                }))
            {
                glowBrush.CenterColor = Color.FromArgb(40, 16, 185, 129);
                glowBrush.SurroundColors = new Color[] {
                    Color.FromArgb(0, 16, 185, 129),
                    Color.FromArgb(0, 16, 185, 129),
                    Color.FromArgb(0, 16, 185, 129),
                    Color.FromArgb(0, 16, 185, 129)
                };
                e.Graphics.FillRectangle(glowBrush, 0, 0, 300, 300);
            }

            // Accent lumineux en bas à droite
            using (var glowBrush = new System.Drawing.Drawing2D.PathGradientBrush(
                new Point[] {
                    new Point(ClientSize.Width - 300, ClientSize.Height - 300),
                    new Point(ClientSize.Width, ClientSize.Height - 300),
                    new Point(ClientSize.Width, ClientSize.Height),
                    new Point(ClientSize.Width - 300, ClientSize.Height)
                }))
            {
                glowBrush.CenterColor = Color.FromArgb(40, 59, 130, 246);
                glowBrush.SurroundColors = new Color[] {
                    Color.FromArgb(0, 59, 130, 246),
                    Color.FromArgb(0, 59, 130, 246),
                    Color.FromArgb(0, 59, 130, 246),
                    Color.FromArgb(0, 59, 130, 246)
                };
                e.Graphics.FillRectangle(glowBrush,
                    ClientSize.Width - 300, ClientSize.Height - 300, 300, 300);
            }
        }

        // Dessiner la carte avec ombre et coins arrondis
        private void panelLoginCard_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Ombre portée
            using (var shadowPath = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radius = 20;
                Rectangle shadowRect = new Rectangle(8, 8, panelLoginCard.Width - 16, panelLoginCard.Height - 16);

                shadowPath.AddArc(shadowRect.X, shadowRect.Y, radius, radius, 180, 90);
                shadowPath.AddArc(shadowRect.Right - radius, shadowRect.Y, radius, radius, 270, 90);
                shadowPath.AddArc(shadowRect.Right - radius, shadowRect.Bottom - radius, radius, radius, 0, 90);
                shadowPath.AddArc(shadowRect.X, shadowRect.Bottom - radius, radius, radius, 90, 90);
                shadowPath.CloseFigure();

                using (var shadowBrush = new SolidBrush(Color.FromArgb(80, 0, 0, 0)))
                {
                    e.Graphics.FillPath(shadowBrush, shadowPath);
                }
            }

            // Carte principale
            using (var cardPath = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radius = 16;
                Rectangle cardRect = new Rectangle(0, 0, panelLoginCard.Width, panelLoginCard.Height);

                cardPath.AddArc(cardRect.X, cardRect.Y, radius, radius, 180, 90);
                cardPath.AddArc(cardRect.Right - radius, cardRect.Y, radius, radius, 270, 90);
                cardPath.AddArc(cardRect.Right - radius, cardRect.Bottom - radius, radius, radius, 0, 90);
                cardPath.AddArc(cardRect.X, cardRect.Bottom - radius, radius, radius, 90, 90);
                cardPath.CloseFigure();

                panelLoginCard.Region = new Region(cardPath);

                using (var cardBrush = new SolidBrush(Color.FromArgb(30, 41, 59)))
                {
                    e.Graphics.FillPath(cardBrush, cardPath);
                }

                // Bordure lumineuse subtile
                using (var borderPen = new Pen(Color.FromArgb(100, 71, 85, 105), 1))
                {
                    e.Graphics.DrawPath(borderPen, cardPath);
                }
            }
        }

        // Dessiner le bouton avec coins arrondis
        private void buttonLogin_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radius = 8;
                Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);

                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                btn.Region = new Region(path);

                using (var brush = new SolidBrush(btn.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            }

            // Dessiner le texte centré
            TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle,
                btn.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        // Effet hover sur le bouton
        private void buttonLogin_MouseEnter(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.FromArgb(5, 150, 105);
        }

        private void buttonLogin_MouseLeave(object sender, EventArgs e)
        {
            buttonLogin.BackColor = Color.FromArgb(16, 185, 129);
        }
    }
}