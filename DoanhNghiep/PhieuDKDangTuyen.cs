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
    public partial class PhieuDKDangTuyen : Form
    {
        public PhieuDKDangTuyen()
        {
            InitializeComponent();
        }

        private void PhieuDKDangTuyen_Load(object sender, EventArgs e)
        {
            NavBar();
            CenterPanel();
        }

        private void PhieuDKDangTuyen_Resize(object sender, EventArgs e)
        {
            NavBar();
            CenterPanel();
        }
        private void NavBar()
        {
            panelNavbar.Left = 0;
            panelNavbar.Top = 0;
            panelNavbar.Height = 60;
            panelNavbar.Width = this.ClientSize.Width;
        }
        private void CenterPanel()
        {
            this.panelRegister.Left = (this.ClientSize.Width - this.panelRegister.Width) / 2;
            this.panelRegister.Top = (this.ClientSize.Height - this.panelRegister.Height) / 2;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            //IMPLEMENTATION
            //===========================

            MessageBox.Show("Đăng ký đăng tuyển thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //===========================
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hủy bỏ phiếu đăng ký thành công!", "Hủy bỏ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
