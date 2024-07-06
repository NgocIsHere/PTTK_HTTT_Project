using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using UI_winform.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI_winform
{
    public partial class CapNhatThongTinUV : UserControl
    {
        public int mauv;
        public CapNhatThongTinUV(int Mauv)
        {
            InitializeComponent();
            this.mauv = Mauv;
            LoadData();
        }
        private void LoadData()
        {
            string query = "SELECT HOTEN, NGSINH, GIOITINH, SDT, DIACHI, EMAIL, TRINHDO FROM QLHSUT.QLHSUT_UNG_VIEN WHERE MAUV = :MAUV";
            object[] parameters = { mauv };

            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                textBox1.Text = row["HOTEN"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row["NGSINH"]);
                textBox2.Text = row["DIACHI"].ToString();
                textBox3.Text = row["SDT"].ToString();
                textBox4.Text = row["EMAIL"].ToString();
                comboBox1.Text = row["TRINHDO"].ToString();
                if (row["GIOITINH"].ToString() == "Nam")
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox2.Checked = true;
                }
            }
        }

        
        private void update_ttuv()
        {
            string HOTEN = textBox1.Text;
            string NGAYSINH = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string DIACHI = textBox2.Text;
            string SDT = textBox3.Text;
            string EMAIL = textBox4.Text;
            string TRINHDO = comboBox1.Text;
            string GIOITINH = checkBox1.Checked ? "Nam" : "Nữ";
            object[] parameters = { HOTEN, NGAYSINH, GIOITINH, SDT, DIACHI, EMAIL, TRINHDO, mauv };
            string updateQuery = "UPDATE QLHSUT.QLHSUT_UNG_VIEN " +
                                 "SET HOTEN = :HOTEN, " +
                                 "NGSINH = TO_DATE(:NGAYSINH, 'YYYY-MM-DD'), " +
                                 "GIOITINH = :GIOITINH, " +
                                 "SDT = :SDT, " +
                                 "DIACHI = :DIACHI, " +
                                 "EMAIL = :EMAIL, " +
                                 "TRINHDO = :TRINHDO " +
                                 "WHERE MAUV = :MAUV";
            DataProvider.Instance.ExecuteNonQuery(updateQuery, parameters);

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                update_ttuv();
                MessageBox.Show("Đã cập nhật");
                LoadData();
                // TraCuuViTriUngTuyen tcvt = new TraCuuViTriUngTuyen(mauv);
                //tcvt.Show();
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
