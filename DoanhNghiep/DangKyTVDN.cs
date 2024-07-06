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
    public partial class DangKyTVDN : Form
    {
        public DangKyTVDN()
        {
            InitializeComponent();
        }

        private void DangKyTVDN_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void DangKyTVDN_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            this.panelRegister.Left = (this.ClientSize.Width - this.panelRegister.Width) / 2;
            this.panelRegister.Top = (this.ClientSize.Height - this.panelRegister.Height) / 2;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //IMPLEMENTATION
            //===========================
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không được để trống", "ĐĂNG KÝ THẤT BẠI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Đăng ký tài khoản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            //===========================

        }
    }
}
