using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_winform.DAO;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace UI_winform
{
    public partial class DangKyTVUV : Form
    {
        private DataProvider data;
        public DangKyTVUV()
        {
            InitializeComponent();
        }

        private void DangKyTVUV_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void DangKyTVUV_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }
        private void CenterPanel()
        {
            panelMain.Left = (this.ClientSize.Width - panelMain.Width) / 2;
            panelMain.Top = (this.ClientSize.Height - panelMain.Height) / 2;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null && dateTimePicker1.Value.ToString() != null && textBox2.Text != null && textBox3.Text != null && textBox4.Text != null && comboBox1.Text!=null && (checkBox1.Checked|| checkBox2.Checked))
            {
                try
                {
                    insert_data();
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình đăng ký, vui lòng thức hiện lại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
            }
        }
        private void insert_data()
        {
            String HOTEN = textBox1.Text;
            String ngaysinh = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            String DIACHI = textBox2.Text;
            String SDT = textBox3.Text;
            String EMAIL = textBox4.Text;
            String TRINHDO = comboBox1.Text;
            String GIOITINH;
            if (checkBox1.Checked)
            {
                GIOITINH = "Nam";
            }
            else
            {
                GIOITINH = "Nữ";
            }
            int MAUV = GetRowCount("QLHSUT_UNG_VIEN") +1 + 110000;
            string query = @"INSERT INTO QLHSUT.QLHSUT_UNG_VIEN
                    (MAUV, HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL, TRINHDO) 
                    VALUES(:MAUV, :HOTEN, TO_DATE(:NGSINH, 'YYYY-MM-DD'), :GIOITINH, :SDT, :DIACHI, :EMAIL, :TRINHDO)";

            // Parameters for the query
            object[] parameters = { MAUV, HOTEN, ngaysinh, GIOITINH, SDT, DIACHI, EMAIL, TRINHDO };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
        public int GetRowCount(string tableName)
        {
            string query = $"SELECT COUNT(*) FROM {tableName}";
            return Convert.ToInt32(DataProvider.Instance.ExecuteQuery(query).Rows[0][0]);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }
    }
}
