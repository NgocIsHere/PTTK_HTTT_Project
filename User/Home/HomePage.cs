using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_winform.User.Login;

namespace UI_winform
{
    public partial class HomePage : Form
    {
        DangNhap curLogin = new DangNhap();
        public HomePage(DangNhap curLogin)
        {
            InitializeComponent();
            this.curLogin = curLogin;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            NavBar();
            SideBar();
            CenterPanel();
        }

        private void HomePage_Resize(object sender, EventArgs e)
        {
            NavBar();
            SideBar();
            CenterPanel();
        }

        private void NavBar()
        {
            panelNavbar.Left = 170;
            panelNavbar.Top = 0;
            panelNavbar.Height = 70;
            panelNavbar.Width = this.ClientSize.Width - panelNavbar.Left;
        }

        private void SideBar()
        {
            panel1.Left = 0;
            panel1.Top = 0;
            panel1.Height = this.ClientSize.Height;
            panel1.Width = 170;
            linkBack.Top = panel1.Height - linkBack.Height - 30;
        }
        private void CenterPanel()
        {
            panelRegister.Left = panel1.Width + (this.ClientSize.Width - panel1.Width - panelRegister.Width) / 2;
            panelRegister.Top = panelNavbar.Height + (this.ClientSize.Height - panelNavbar.Height - panelRegister.Height) / 2;
        }




        private void btnDKyDangTuyen_Click(object sender, EventArgs e)
        {
            DangKyDangTuyen1 dkDangTuyenForm = new DangKyDangTuyen1();
            dkDangTuyenForm.Show();
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap newWindow = new DangNhap();
            this.FormClosing += (s, args) => newWindow.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CapNhatThongTin newWindow = new CapNhatThongTin();
            newWindow.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            DoiMatKhau newWindow = new DoiMatKhau();
            newWindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*NopHoSo01 newWindow = new NopHoSo01();
            newWindow.Show();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*NopHoSo02 newWindow = new NopHoSo02();
            newWindow.Show();*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TraCuuHoSo newWindow = new TraCuuHoSo();
            newWindow.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*TraCuuViTriUngTuyen newWindow = new TraCuuViTriUngTuyen();
            newWindow.Show();*/
        }
    }
}
