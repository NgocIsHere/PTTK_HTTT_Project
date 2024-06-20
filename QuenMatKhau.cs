using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_winform
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void QuenMatKhau_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            this.lblFooterMessage.Left = (this.ClientSize.Width - this.lblFooterMessage.Width) / 2;
            this.lblFooterMessage.Top = this.ClientSize.Height - this.lblFooterMessage.Height - 10;
            this.panelForgotPassword.Left = (this.ClientSize.Width - this.panelForgotPassword.Width) / 2;
            this.panelForgotPassword.Top = (this.ClientSize.Height - this.panelForgotPassword.Height) / 2;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validation and submission logic here
            if (string.IsNullOrEmpty(this.txtEmail.Text) || !IsValidEmail(this.txtEmail.Text))
            {
                this.lblEmailValidation.Text = "Email không hợp lệ!";
                this.lblEmailValidation.Visible = true;
            }
            else
            {
                this.lblEmailValidation.Text = "Đã gửi thành công!";
                this.lblEmailValidation.Visible = true;
                // Code to handle email submission
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangNhap loginForm = new DangNhap();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.Show();
        }

        private void linkNotReceivedEmail_LinkClicked(object sender, EventArgs e)
        {
            // Validation and submission logic here
            if (string.IsNullOrEmpty(this.txtEmail.Text) || !IsValidEmail(this.txtEmail.Text))
            {
                this.lblEmailValidation.Text = "Email không hợp lệ!";
                this.lblEmailValidation.Visible = true;
            }
            else
            {
                this.lblEmailValidation.Text = "Mật khẩu đã được gửi lại qua email!";
                this.lblEmailValidation.Visible = true;
                // Code to handle email submission
            }
        }

    }
}
