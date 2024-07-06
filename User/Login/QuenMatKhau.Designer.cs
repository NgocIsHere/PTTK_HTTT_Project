namespace UI_winform
{
    partial class QuenMatKhau
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

        private void InitializeComponent()
        {
            panelForgotPassword = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            lblTitle = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblEmailValidation = new Label();
            linkNotReceivedEmail = new LinkLabel();
            btnSubmit = new Button();
            linkBack = new LinkLabel();
            lblFooterMessage = new Label();
            panelForgotPassword.SuspendLayout();
            SuspendLayout();
            // 
            // panelForgotPassword
            // 
            panelForgotPassword.BackColor = Color.FromArgb(217, 217, 217);
            panelForgotPassword.BorderStyle = BorderStyle.FixedSingle;
            panelForgotPassword.Controls.Add(label1);
            panelForgotPassword.Controls.Add(textBox1);
            panelForgotPassword.Controls.Add(lblTitle);
            panelForgotPassword.Controls.Add(lblEmail);
            panelForgotPassword.Controls.Add(txtEmail);
            panelForgotPassword.Controls.Add(lblEmailValidation);
            panelForgotPassword.Controls.Add(linkNotReceivedEmail);
            panelForgotPassword.Controls.Add(btnSubmit);
            panelForgotPassword.Controls.Add(linkBack);
            panelForgotPassword.Location = new Point(91, 57);
            panelForgotPassword.Name = "panelForgotPassword";
            panelForgotPassword.Size = new Size(620, 420);
            panelForgotPassword.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(123, 111);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 7;
            label1.Text = "Tài khoản";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(123, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(381, 34);
            textBox1.TabIndex = 8;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(175, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(269, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUÊN MẬT KHẨU";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 13F);
            lblEmail.Location = new Point(123, 202);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(64, 30);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(123, 240);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(381, 34);
            txtEmail.TabIndex = 2;
            // 
            // lblEmailValidation
            // 
            lblEmailValidation.AutoSize = true;
            lblEmailValidation.ForeColor = Color.Red;
            lblEmailValidation.ImageAlign = ContentAlignment.TopRight;
            lblEmailValidation.Location = new Point(123, 277);
            lblEmailValidation.Name = "lblEmailValidation";
            lblEmailValidation.Size = new Size(73, 20);
            lblEmailValidation.TabIndex = 3;
            lblEmailValidation.Text = "*message";
            lblEmailValidation.TextAlign = ContentAlignment.MiddleRight;
            lblEmailValidation.Visible = false;
            // 
            // linkNotReceivedEmail
            // 
            linkNotReceivedEmail.AutoSize = true;
            linkNotReceivedEmail.Location = new Point(36, 381);
            linkNotReceivedEmail.Name = "linkNotReceivedEmail";
            linkNotReceivedEmail.Size = new Size(187, 20);
            linkNotReceivedEmail.TabIndex = 4;
            linkNotReceivedEmail.TabStop = true;
            linkNotReceivedEmail.Text = "Tôi chưa nhận được email?";
            linkNotReceivedEmail.LinkClicked += linkNotReceivedEmail_LinkClicked;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(250, 135, 135);
            btnSubmit.Location = new Point(246, 310);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(126, 39);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Xác nhận";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // linkBack
            // 
            linkBack.AutoSize = true;
            linkBack.Location = new Point(517, 381);
            linkBack.Name = "linkBack";
            linkBack.Size = new Size(63, 20);
            linkBack.TabIndex = 6;
            linkBack.TabStop = true;
            linkBack.Text = "Quay lại";
            linkBack.LinkClicked += linkBack_LinkClicked;
            // 
            // lblFooterMessage
            // 
            lblFooterMessage.AutoSize = true;
            lblFooterMessage.ForeColor = Color.Red;
            lblFooterMessage.Location = new Point(190, 510);
            lblFooterMessage.Name = "lblFooterMessage";
            lblFooterMessage.Size = new Size(435, 20);
            lblFooterMessage.TabIndex = 7;
            lblFooterMessage.Text = "Mật khẩu mới sẽ được gửi đến email. Vui lòng kiểm tra hòm thư.";
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
            Controls.Add(panelForgotPassword);
            Controls.Add(lblFooterMessage);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(800, 600);
            Name = "QuenMatKhau";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuenMatKhau";
            Load += QuenMatKhau_Load;
            Resize += QuenMatKhau_Resize;
            panelForgotPassword.ResumeLayout(false);
            panelForgotPassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion
        private Panel panelForgotPassword;
        private Label lblTitle;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblEmailValidation;
        private LinkLabel linkNotReceivedEmail;
        private Button btnSubmit;
        private LinkLabel linkBack;
        private Label lblFooterMessage;
        private Label label1;
        private TextBox textBox1;
    }
}