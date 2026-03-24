namespace SportShopEmeld
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            pnMain = new Panel();
            btnGuest = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lbPassword = new Label();
            txtLogin = new TextBox();
            lbLogin = new Label();
            pbLogo = new PictureBox();
            pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.Anchor = AnchorStyles.None;
            pnMain.Controls.Add(btnGuest);
            pnMain.Controls.Add(btnLogin);
            pnMain.Controls.Add(txtPassword);
            pnMain.Controls.Add(lbPassword);
            pnMain.Controls.Add(txtLogin);
            pnMain.Controls.Add(lbLogin);
            pnMain.Location = new Point(32, 149);
            pnMain.Margin = new Padding(4);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(429, 293);
            pnMain.TabIndex = 3;
            // 
            // btnGuest
            // 
            btnGuest.BackColor = Color.White;
            btnGuest.FlatAppearance.BorderSize = 0;
            btnGuest.FlatStyle = FlatStyle.Flat;
            btnGuest.Location = new Point(118, 239);
            btnGuest.Margin = new Padding(4);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(193, 38);
            btnGuest.TabIndex = 5;
            btnGuest.Text = "Войти как гость";
            btnGuest.UseVisualStyleBackColor = false;
            btnGuest.Click += BtnGuest_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(67, 97, 238);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(118, 186);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(193, 38);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(54, 138);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(320, 26);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(177, 99);
            lbPassword.Margin = new Padding(4, 0, 4, 0);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(58, 19);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Пароль";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(54, 51);
            txtLogin.Margin = new Padding(4);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(320, 26);
            txtLogin.TabIndex = 1;
            // 
            // lbLogin
            // 
            lbLogin.AutoSize = true;
            lbLogin.Location = new Point(181, 11);
            lbLogin.Margin = new Padding(4, 0, 4, 0);
            lbLogin.Name = "lbLogin";
            lbLogin.Size = new Size(52, 19);
            lbLogin.TabIndex = 0;
            lbLogin.Text = "Логин";
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.None;
            pbLogo.Image = (Image)resources.GetObject("pbLogo.Image");
            pbLogo.Location = new Point(179, 15);
            pbLogo.Margin = new Padding(4);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(129, 127);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 2;
            pbLogo.TabStop = false;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(494, 457);
            Controls.Add(pnMain);
            Controls.Add(pbLogo);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Button btnGuest;
        private Button btnLogin;
        private TextBox txtPassword;
        private Label lbPassword;
        private TextBox txtLogin;
        private Label lbLogin;
        private PictureBox pbLogo;
    }
}