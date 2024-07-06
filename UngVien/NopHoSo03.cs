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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI_winform
{
    public partial class NopHoSo03 : UserControl
    {
        public int mahs, mauv;
        public NopHoSo03(int maUV,int maHS)
        {
            this.mahs = maHS;
            this.mauv = maUV;
            InitializeComponent();
            load_data();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            HOMEUV mainForm = (HOMEUV)this.ParentForm;
            mainForm.SwitchUserControl(new HoSoCuaToi(mauv));
        }
        private void load_data()
        {
            object[] parameters = { this.mahs };
            string query = "select * FROM QLHSUT.QLHSUT_THONG_TIN_BANG_CAP where MAHS = :MAHS";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);
            dataGridView1.DataSource = data;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HOMEUV mainForm = (HOMEUV)this.ParentForm;
            mainForm.SwitchUserControl(new NopBangCap(mahs,mauv));
        }
    }
}
