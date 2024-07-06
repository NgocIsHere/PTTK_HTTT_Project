using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using UI_winform.utils;

namespace UI_winform
{
    public partial class DangNhap : Form
    {
        public OracleConnection con;
        public static string Username;
        public static string Password;
        public static string Role;

        public DangNhap()
        {
            con = new OracleConnection();
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void DangNhap_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void CenterPanel()
        {
            panelLogin.Left = (this.ClientSize.Width - panelLogin.Width) / 2;
            panelLogin.Top = (this.ClientSize.Height - panelLogin.Height) / 2;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (txtUsername.Text.Length == 0)
            {
                MessageBox.Show("TÊN ĐĂNG NHẬP không được để trống.");
                return;
            }
            if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("MẬT KHẨU không được để trống.");
                return;
            }
            if (txtRole.Text.Length == 0)
            {
                MessageBox.Show("VAI TRÒ không được để trống.");
                return;
            }

            Username = txtUsername.Text;
            if (Username == "SYS" || Username == "sys")
            {
                MessageBox.Show("TÊN ĐĂNG NHẬP hoặcc MẬT KHẨU không hợp lệ!");
                return;
            }

            try
            {
                string connectionString = "";
                var appSettings = ConfigurationManager.AppSettings;
                string hostname = appSettings["hostname"] ?? "localhost";
                string port = appSettings["port"] ?? "1521";
                string qlhsut = appSettings["sysdba"] ?? "QLHSUT";
                string pwd = appSettings["pwd"] ?? "123456";

                string qlhsutConnectionString = @$"DATA SOURCE={hostname}:{port}/XEPDB1;DBA Privilege=SYSDBA; USER ID=" + qlhsut + ";PASSWORD=" + pwd;

                //using (OracleConnection con = new OracleConnection(qlhsutConnectionString))
                //{
                //    try
                //    {
                //        con.Open();
                //        MessageBox.Show("Kết nối với cơ sở dữ liệu thành công!");
                //    }
                //    catch (OracleException ex)
                //    {
                //        MessageBox.Show("Lỗi kết nối: " + ex.Message);
                //    }
                //}

                if (txtRole.Text == "Quản trị viên")
                {
                    connectionString = @$"DATA SOURCE={hostname}:{port}/XEPDB1;DBA Privilege=SYSDBA; USER ID=" + txtUsername.Text + ";PASSWORD=" + txtPassword.Text;
                    con.ConnectionString = connectionString;
                    con.Open();
                    Session.Instance.OracleConnection = con;
                    MessageBox.Show("Connect với tư cách là quản trị viên thành công!");
                    this.Hide();
                }
                else
                {
                    connectionString = @$"DATA SOURCE = {hostname}:{port}/XEPDB1; USER ID=" + txtUsername.Text + ";PASSWORD=" + txtPassword.Text;
                    var cmd = new OracleCommand();
                    var qlhsutOracleConnection = new OracleConnection();
                    qlhsutOracleConnection.ConnectionString = qlhsutConnectionString;
                    qlhsutOracleConnection.Open();
                    cmd.Connection = qlhsutOracleConnection;
                    cmd.CommandText = "QLHSUT.USER_LOGIN";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.Add("USRNAME", OracleDbType.Varchar2).Value = txtUsername.Text;
                    cmd.Parameters.Add("USR_ROLE", OracleDbType.NVarchar2).Value = txtRole.Text;
                    var outputParam = cmd.Parameters.Add("CNT", OracleDbType.Int32);
                    outputParam.Direction = System.Data.ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    int result = int.Parse(cmd.Parameters["CNT"].Value.ToString());

                    qlhsutOracleConnection.Close();

                    if (result == 0)
                    {
                        MessageBox.Show("Không tồn tại tài khoản với vai trò tương ứng!");
                    }
                    else
                    {
                        if (result == 1)
                        {
                            con.ConnectionString = connectionString;
                            con.Open();

                            Session.Instance.Username = txtUsername.Text;
                            Session.Instance.Password = txtPassword.Text;
                            Session.Instance.Role = txtRole.Text;
                            Session.Instance.OracleConnection = con;
                            MessageBox.Show("Connect với tư cách là Doanh nghiệp thành công!");
                            this.Hide();
                            HomePage DNHomePage = new HomePage(this);
                            DNHomePage.Show();
                        }
                        else if (result == 2)
                        {
                            con.ConnectionString = connectionString;
                            con.Open();
                            Session.Instance.Username = txtUsername.Text;
                            Session.Instance.Password = txtPassword.Text;
                            Session.Instance.Role = txtRole.Text;
                            Session.Instance.OracleConnection = con;
                            MessageBox.Show("Connect với tư cách là Ứng viên thành công!");
                            this.Hide();
                            HomePage UVHomePage = new HomePage(this);
                            UVHomePage.Show();
                        }
                        else if (result == 3)
                        {
                            con.ConnectionString = connectionString;
                            con.Open();

                            Session.Instance.Username = txtUsername.Text;
                            Session.Instance.Password = txtPassword.Text;
                            Session.Instance.Role = txtRole.Text;
                            Session.Instance.OracleConnection = con;
                            MessageBox.Show("Connect với tư cách là Nhân viên thành công!");
                            this.Hide();
                            EmployeePage NVHomePage = new EmployeePage();
                            NVHomePage.Show();
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show("TÊN ĐĂNG NHẬP hoặc MẬT KHẨU không hợp lệ!");
            }
        }

        private void btnTogglePassword_MouseDown(object sender, MouseEventArgs e)
        {
            // Show the password
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnTogglePassword_MouseUp(object sender, MouseEventArgs e)
        {
            // Hide the password
            txtPassword.UseSystemPasswordChar = true;
        }

        private void linkRegisterEmployer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangKyTVDN registerForm = new DangKyTVDN();
            registerForm.FormClosed += (s, args) => this.Show();
            registerForm.Show();
        }

        private void linkRegisterApplicant_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangKyTVUV registerForm = new DangKyTVUV();
            registerForm.FormClosed += (s, args) => this.Show();
            registerForm.Show();
        }

        private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            QuenMatKhau forgotPasswordForm = new QuenMatKhau();
            forgotPasswordForm.FormClosed += (s, args) => this.Close();
            forgotPasswordForm.Show();
        }

        private void txtRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
