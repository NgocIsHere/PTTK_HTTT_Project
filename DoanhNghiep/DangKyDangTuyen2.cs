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
    public partial class DangKyDangTuyen2 : Form
    {
        private DangKyDangTuyen1 dangKyDangTuyen1;
        public DangKyDangTuyen2()
        {
            this.dangKyDangTuyen1 = new DangKyDangTuyen1();
            InitializeComponent();
        }
        public DangKyDangTuyen2(DangKyDangTuyen1 copy)
        {
            this.dangKyDangTuyen1 = copy;
            InitializeComponent();
        }
        private void DangKyDangTuyen2_Load(object sender, EventArgs e)
        {
            CenterPanel();
            NavBar();
        }

        private void DangKyDangTuyen2_Resize(object sender, EventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.dangKyDangTuyen1.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //IMPLEMENTATION
            //===========================

            //===========================
            this.Hide();
            PhieuDKDangTuyen dkDangTuyenForm = new PhieuDKDangTuyen();
            dkDangTuyenForm.FormClosed += (s, args) =>
            {
                this.dangKyDangTuyen1.Close();
                this.Close();
            };
            dkDangTuyenForm.Show();
        }
    }
}
