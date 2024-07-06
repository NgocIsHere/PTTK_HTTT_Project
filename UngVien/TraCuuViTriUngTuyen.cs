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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace UI_winform
{
    public partial class TraCuuViTriUngTuyen : UserControl
    {
        private int maUV;
        public TraCuuViTriUngTuyen(int maUV)
        {
            this.maUV = maUV;
            InitializeComponent();
            string query = "select MADT, DN_DANGTUYEN, VITRI_UNGTUYEN, SOLUONG, MOTA FROM QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN";
            Load_data(query);
        }

        private void Load_data(string query)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            dataGridView1.DataSource = data;
        }
    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            int madtValue = Convert.ToInt32(selectedRow.Cells["MADT"].Value);
            HOMEUV mainForm = (HOMEUV)this.ParentForm;
            mainForm.SwitchUserControl(new NopHoSo01(maUV,madtValue));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int LUONG_MIN = 0, LUONG_MAX = 999999999;
            string query = "";
            if (textBox1.Text != "")
            {
                LUONG_MIN = Convert.ToInt32(textBox1.Text);
            }
            if (textBox2.Text != "")
            {
                LUONG_MAX = Convert.ToInt32(textBox2.Text);
            }
            if(comboBox1.Text.ToString() == "Tất cả")
            {
                query = $"select MADT, DN_DANGTUYEN, VITRI_UNGTUYEN, SOLUONG, MOTA FROM QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN WHERE LUONG >= {LUONG_MIN} AND LUONG <= {LUONG_MAX}" +
                $"AND MOTA LIKE '%{textBox3.Text}%'";
            }
            else
            {
                query = $"select MADT, DN_DANGTUYEN, VITRI_UNGTUYEN, SOLUONG, MOTA FROM QLHSUT.QLHSUT_THONG_TIN_DANG_TUYEN WHERE VITRI_UNGTUYEN LIKE '%{comboBox1.Text}%' AND LUONG >= {LUONG_MIN} AND LUONG <= {LUONG_MAX}" +
                $"AND MOTA LIKE '%{textBox3.Text}%'";
            }
            Load_data(query);
        }

    }
}
