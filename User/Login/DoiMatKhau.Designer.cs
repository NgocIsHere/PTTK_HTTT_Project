namespace UI_winform.User.Login
{
    partial class DoiMatKhau
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
            panelChangePassword = new Panel();
            labelConfirmPassword = new Label();
            textBoxConfirmPassword = new TextBox();
            labelCurrentPassword = new Label();
            textBoxCurrentPassword = new TextBox();
            lblTitle = new Label();
            lblNewPassword = new Label();
            txtNewPassword = new TextBox();
            lblValidation = new Label();
            btnSubmit = new Button();
            linkBack = new LinkLabel();
            panelChangePassword.SuspendLayout();
            SuspendLayout();
            // 
            // panelChangePassword
            // 
            panelChangePassword.BackColor = Color.FromArgb(217, 217, 217);
            panelChangePassword.BorderStyle = BorderStyle.FixedSingle;
            panelChangePassword.Controls.Add(labelConfirmPassword);
            panelChangePassword.Controls.Add(textBoxConfirmPassword);
            panelChangePassword.Controls.Add(labelCurrentPassword);
            panelChangePassword.Controls.Add(textBoxCurrentPassword);
            panelChangePassword.Controls.Add(lblTitle);
            panelChangePassword.Controls.Add(lblNewPassword);
            panelChangePassword.Controls.Add(txtNewPassword);
            panelChangePassword.Controls.Add(lblValidation);
            panelChangePassword.Controls.Add(btnSubmit);
            panelChangePassword.Controls.Add(linkBack);
            panelChangePassword.Location = new Point(87, 36);
            panelChangePassword.Name = "panelChangePassword";
            panelChangePassword.Size = new Size(620, 471);
            panelChangePassword.TabIndex = 1;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Font = new Font("Segoe UI", 13F);
            labelConfirmPassword.Location = new Point(125, 277);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(187, 30);
            labelConfirmPassword.TabIndex = 9;
            labelConfirmPassword.Text = "Nhập lại mật khẩu";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Font = new Font("Segoe UI", 12F);
            textBoxConfirmPassword.Location = new Point(125, 315);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(381, 34);
            textBoxConfirmPassword.TabIndex = 10;
            // 
            // labelCurrentPassword
            // 
            labelCurrentPassword.AutoSize = true;
            labelCurrentPassword.Font = new Font("Segoe UI", 13F);
            labelCurrentPassword.Location = new Point(125, 98);
            labelCurrentPassword.Name = "labelCurrentPassword";
            labelCurrentPassword.Size = new Size(179, 30);
            labelCurrentPassword.TabIndex = 7;
            labelCurrentPassword.Text = "Mật khẩu hiện tại";
            // 
            // textBoxCurrentPassword
            // 
            textBoxCurrentPassword.Font = new Font("Segoe UI", 12F);
            textBoxCurrentPassword.Location = new Point(125, 136);
            textBoxCurrentPassword.Name = "textBoxCurrentPassword";
            textBoxCurrentPassword.Size = new Size(381, 34);
            textBoxCurrentPassword.TabIndex = 8;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(201, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(235, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐỔI MẬT KHẨU";
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 13F);
            lblNewPassword.Location = new Point(125, 189);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(146, 30);
            lblNewPassword.TabIndex = 1;
            lblNewPassword.Text = "Mật khẩu mới";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F);
            txtNewPassword.Location = new Point(125, 227);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(381, 34);
            txtNewPassword.TabIndex = 2;
            // 
            // lblValidation
            // 
            lblValidation.AutoSize = true;
            lblValidation.ForeColor = Color.Red;
            lblValidation.ImageAlign = ContentAlignment.TopRight;
            lblValidation.Location = new Point(125, 352);
            lblValidation.Name = "lblValidation";
            lblValidation.Size = new Size(73, 20);
            lblValidation.TabIndex = 3;
            lblValidation.Text = "*message";
            lblValidation.TextAlign = ContentAlignment.MiddleRight;
            lblValidation.Visible = false;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(250, 135, 135);
            btnSubmit.Location = new Point(252, 392);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(136, 43);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Xác nhận";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // linkBack
            // 
            linkBack.AutoSize = true;
            linkBack.Location = new Point(519, 433);
            linkBack.Name = "linkBack";
            linkBack.Size = new Size(63, 20);
            linkBack.TabIndex = 6;
            linkBack.TabStop = true;
            linkBack.Text = "Quay lại";
            linkBack.LinkClicked += linkBack_LinkClicked;
            // 
            // DoiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(panelChangePassword);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "DoiMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DoiMatKhau";
            Load += DoiMatKhau_Load;
            panelChangePassword.ResumeLayout(false);
            panelChangePassword.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChangePassword;
        private Label labelConfirmPassword;
        private TextBox textBoxConfirmPassword;
        private Label labelCurrentPassword;
        private TextBox textBoxCurrentPassword;
        private Label lblTitle;
        private Label lblNewPassword;
        private TextBox txtNewPassword;
        private Label lblValidation;
        private Button btnSubmit;
        private LinkLabel linkBack;
    }
}