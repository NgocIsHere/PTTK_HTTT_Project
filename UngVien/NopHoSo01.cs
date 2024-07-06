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
    public partial class NopHoSo01 : UserControl {
        public int mauv, madt;
        public NopHoSo01(int MaUV, int MaDT)
        {
            InitializeComponent();
            this.mauv = MaUV;
            this.madt = MaDT;
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

        private void button1_Click(object sender, EventArgs e)
        {
            HOMEUV mainForm = (HOMEUV)this.ParentForm;
            mainForm.SwitchUserControl(new NopHoSo02(mauv, madt));
        }

        private void btnExt_Click(object sender, EventArgs e)
        {
            HOMEUV mainForm = (HOMEUV)this.ParentForm;
            mainForm.SwitchUserControl(new TraCuuViTriUngTuyen(mauv));
        }
    }
}
