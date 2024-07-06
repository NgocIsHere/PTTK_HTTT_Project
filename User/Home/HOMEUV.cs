
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using UI_winform.DAO;
using UI_winform.User.Login;
using UI_winform.Utils;
using UI_winform;

namespace UI_winform
{
    public partial class HOMEUV : Form
    {
        NavigationControl navigationControl;
        private int mauv;
        Color btnDefaultColor = Color.Transparent;
        Color btnSelectedtColor = Color.Teal;
        public string role;

        public HOMEUV(int mauv)
        {
            this.mauv = mauv;
            InitializeComponent();
            SwitchUserControl(new HoSoCuaToi(mauv));
            //InitializeNavigationControl();
        }

        private void InitializeNavigationControl()
        {
            TraCuuViTriUngTuyen tcut = new TraCuuViTriUngTuyen(mauv);
            HoSoCuaToi hs = new HoSoCuaToi(mauv);
            CapNhatThongTinUV ttuv = new CapNhatThongTinUV(mauv);
            List<UserControl> userControls = new List<UserControl>() // Your UserControl list
            {ttuv,tcut, hs};
            navigationControl = new NavigationControl(userControls, content); // create an instance of NavigationControl class
            navigationControl.Display(0);
        }
        public void SwitchUserControl(UserControl newControl)
        {
            // Clear the current controls from the panel
            content.Controls.Clear();

            // Set the Dock style to fill the panel
            newControl.Dock = DockStyle.Fill;

            // Add the new UserControl to the panel
            content.Controls.Add(newControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //navigationControl.Display(0);
            SwitchUserControl(new CapNhatThongTinUV(mauv));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //navigationControl.Display(1);
            SwitchUserControl(new TraCuuViTriUngTuyen(mauv));
        }
        //Nộp hồ sơ
        private void button3_Click(object sender, EventArgs e)
        {
            //navigationControl.Display(2);
            SwitchUserControl(new HoSoCuaToi(mauv));
        }
        //Đổi mật khẩu
        private void button4_Click(object sender, EventArgs e)
        {

            DoiMatKhau newPage = new DoiMatKhau();
            newPage.ShowDialog();
        }


        
    }
}