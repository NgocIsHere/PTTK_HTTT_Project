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
    public partial class DangKyDangTuyen1 : Form
    {
        private DangKyDangTuyen2 dangKyDangTuyen2;
        public DangKyDangTuyen1()
        {
            this.dangKyDangTuyen2 = new DangKyDangTuyen2(this);
            InitializeComponent();
        }

        private void DangKyDangTuyen1_Load(object sender, EventArgs e)
        {
            CenterPanel();
            NavBar();
        }

        private void DangKyDangTuyen1_Resize(object sender, EventArgs e)
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
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //IMPLEMENTATION
            //===========================

            //===========================
            this.Hide();
            this.dangKyDangTuyen2.Show();
        }

    }
}
