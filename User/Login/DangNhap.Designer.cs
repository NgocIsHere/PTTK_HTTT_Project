namespace UI_winform
{
    partial class DangNhap
    {


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
        private void InitializeComponent()
        {
            panelLogin = new Panel();
            txtRole = new ComboBox();
            IblRole = new Label();
            btnTogglePassword = new Button();
            lblLogin = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            linkForgotPassword = new LinkLabel();
            linkRegisterApplicant = new LinkLabel();
            linkRegisterEmployer = new LinkLabel();
            txtPassword = new TextBox();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(217, 217, 217);
            panelLogin.BorderStyle = BorderStyle.FixedSingle;
            panelLogin.Controls.Add(txtRole);
            panelLogin.Controls.Add(IblRole);
            panelLogin.Controls.Add(btnTogglePassword);
            panelLogin.Controls.Add(lblLogin);
            panelLogin.Controls.Add(lblUsername);
            panelLogin.Controls.Add(lblPassword);
            panelLogin.Controls.Add(txtUsername);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(linkForgotPassword);
            panelLogin.Controls.Add(linkRegisterApplicant);
            panelLogin.Controls.Add(linkRegisterEmployer);
            panelLogin.Controls.Add(txtPassword);
            panelLogin.Location = new Point(82, 28);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(620, 494);
            panelLogin.TabIndex = 0;
            panelLogin.TabStop = true;
            // 
            // txtRole
            // 
            txtRole.Font = new Font("Segoe UI", 11F);
            txtRole.FormattingEnabled = true;
            txtRole.Items.AddRange(new object[] { "Quản trị viên", "Doanh nghiệp", "Ứng viên", "Nhân viên" });
            txtRole.Location = new Point(233, 251);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(229, 33);
            txtRole.TabIndex = 10;
            txtRole.SelectedIndexChanged += txtRole_SelectedIndexChanged;
            // 
            // IblRole
            // 
            IblRole.AutoSize = true;
            IblRole.Font = new Font("Segoe UI", 12F);
            IblRole.Location = new Point(156, 252);
            IblRole.Name = "IblRole";
            IblRole.Size = new Size(69, 28);
            IblRole.TabIndex = 9;
            IblRole.Text = "Vai trò";
            // 
            // btnTogglePassword
            // 
            btnTogglePassword.BackColor = SystemColors.ControlLightLight;
            btnTogglePassword.BackgroundImageLayout = ImageLayout.None;
            btnTogglePassword.FlatAppearance.BorderSize = 0;
            btnTogglePassword.FlatStyle = FlatStyle.Flat;
            btnTogglePassword.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnTogglePassword.Location = new Point(435, 195);
            btnTogglePassword.Name = "btnTogglePassword";
            btnTogglePassword.Size = new Size(25, 25);
            btnTogglePassword.TabIndex = 5;
            btnTogglePassword.Text = "👁";
            btnTogglePassword.UseVisualStyleBackColor = false;
            btnTogglePassword.MouseDown += btnTogglePassword_MouseDown;
            btnTogglePassword.MouseUp += btnTogglePassword_MouseUp;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblLogin.Location = new Point(214, 20);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(196, 35);
            lblLogin.TabIndex = 6;
            lblLogin.Text = "ĐĂNG NHẬP";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F);
            lblUsername.Location = new Point(156, 87);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(94, 28);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Tài khoản";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F);
            lblPassword.Location = new Point(156, 160);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(94, 28);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Mật khẩu";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(156, 118);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(306, 32);
            txtUsername.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(250, 135, 135);
            btnLogin.FlatAppearance.BorderColor = Color.Black;
            btnLogin.Location = new Point(233, 346);
            btnLogin.Margin = new Padding(0);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(132, 33);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkForgotPassword
            // 
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.Location = new Point(344, 305);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(116, 20);
            linkForgotPassword.TabIndex = 5;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Quên mật khẩu?";
            linkForgotPassword.LinkClicked += linkForgotPassword_LinkClicked;
            // 
            // linkRegisterApplicant
            // 
            linkRegisterApplicant.AutoSize = true;
            linkRegisterApplicant.Location = new Point(97, 426);
            linkRegisterApplicant.Name = "linkRegisterApplicant";
            linkRegisterApplicant.Size = new Size(254, 20);
            linkRegisterApplicant.TabIndex = 7;
            linkRegisterApplicant.TabStop = true;
            linkRegisterApplicant.Text = "Chưa có tài khoản ứng viên? Đăng ký";
            linkRegisterApplicant.LinkClicked += linkRegisterApplicant_LinkClicked;
            // 
            // linkRegisterEmployer
            // 
            linkRegisterEmployer.AutoSize = true;
            linkRegisterEmployer.Location = new Point(97, 457);
            linkRegisterEmployer.Name = "linkRegisterEmployer";
            linkRegisterEmployer.Size = new Size(345, 20);
            linkRegisterEmployer.TabIndex = 8;
            linkRegisterEmployer.TabStop = true;
            linkRegisterEmployer.Text = "Doanh nghiệp cần đăng tuyển? Đăng ký thành viên";
            linkRegisterEmployer.LinkClicked += linkRegisterEmployer_LinkClicked;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(156, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(306, 32);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(panelLogin);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangNhap";
            Load += DangNhap_Load;
            Resize += DangNhap_Resize;
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
        }

        #region Windows Form Designer generated code

        private Panel panelLogin;
        private Label lblLogin;
        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private LinkLabel linkForgotPassword;
        private LinkLabel linkRegisterApplicant;
        private LinkLabel linkRegisterEmployer;
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion


        protected internal Button btnTogglePassword;
        private ComboBox txtRole;
        private Label IblRole;
    }
}