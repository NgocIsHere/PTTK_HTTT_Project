namespace UI_winform
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDKyDangTuyen = new Button();
            panelNavbar = new Panel();
            label6 = new Label();
            linkBack = new LinkLabel();
            button1 = new Button();
            panel1 = new Panel();
            nvXemHopDongBtn = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            btnChangePassword = new Button();
            dateTimePicker1 = new DateTimePicker();
            checkedListBox1 = new CheckedListBox();
            checkBox2 = new CheckBox();
            textBox4 = new TextBox();
            checkBox1 = new CheckBox();
            label8 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label7 = new Label();
            label1 = new Label();
            panelRegister = new Panel();
            panelNavbar.SuspendLayout();
            panel1.SuspendLayout();
            panelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // btnDKyDangTuyen
            // 
            btnDKyDangTuyen.BackColor = Color.FromArgb(250, 135, 135);
            btnDKyDangTuyen.Location = new Point(3, 125);
            btnDKyDangTuyen.Name = "btnDKyDangTuyen";
            btnDKyDangTuyen.Size = new Size(154, 60);
            btnDKyDangTuyen.TabIndex = 15;
            btnDKyDangTuyen.Text = "ĐĂNG KÝ ĐĂNG TUYỂN";
            btnDKyDangTuyen.UseVisualStyleBackColor = false;
            btnDKyDangTuyen.Click += btnDKyDangTuyen_Click;
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.FromArgb(250, 135, 135);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(label6);
            panelNavbar.Location = new Point(170, 0);
            panelNavbar.Margin = new Padding(0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(811, 70);
            panelNavbar.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold);
            label6.Location = new Point(6, 17);
            label6.Name = "label6";
            label6.Size = new Size(298, 35);
            label6.TabIndex = 8;
            label6.Text = "THÔNG TIN CHUNG";
            // 
            // linkBack
            // 
            linkBack.AutoSize = true;
            linkBack.LinkColor = Color.Red;
            linkBack.Location = new Point(38, 617);
            linkBack.Name = "linkBack";
            linkBack.Size = new Size(77, 20);
            linkBack.TabIndex = 7;
            linkBack.TabStop = true;
            linkBack.Text = "Đăng xuất";
            linkBack.LinkClicked += linkBack_LinkClicked;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(250, 135, 135);
            button1.Location = new Point(327, 430);
            button1.Name = "button1";
            button1.Size = new Size(146, 38);
            button1.TabIndex = 17;
            button1.Text = "CẬP NHẬT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(nvXemHopDongBtn);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnDKyDangTuyen);
            panel1.Controls.Add(linkBack);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(170, 783);
            panel1.TabIndex = 17;
            // 
            // nvXemHopDongBtn
            // 
            nvXemHopDongBtn.BackColor = Color.FromArgb(250, 135, 135);
            nvXemHopDongBtn.Location = new Point(3, 521);
            nvXemHopDongBtn.Name = "nvXemHopDongBtn";
            nvXemHopDongBtn.Size = new Size(154, 60);
            nvXemHopDongBtn.TabIndex = 20;
            nvXemHopDongBtn.Text = "TRA CỨU VỊ TRÍ ỨNG TUYỂN";
            nvXemHopDongBtn.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(250, 135, 135);
            button5.Location = new Point(3, 446);
            button5.Name = "button5";
            button5.Size = new Size(154, 60);
            button5.TabIndex = 19;
            button5.Text = "TRA CỨU VỊ TRÍ ỨNG TUYỂN";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(250, 135, 135);
            button4.Location = new Point(3, 367);
            button4.Name = "button4";
            button4.Size = new Size(154, 60);
            button4.TabIndex = 18;
            button4.Text = "TRA CỨU HỒ SƠ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(250, 135, 135);
            button2.Location = new Point(3, 206);
            button2.Name = "button2";
            button2.Size = new Size(154, 60);
            button2.TabIndex = 16;
            button2.Text = "NỘP HỒ SƠ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(250, 135, 135);
            btnChangePassword.Location = new Point(136, 427);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(146, 44);
            btnChangePassword.TabIndex = 50;
            btnChangePassword.Text = "ĐỔI MẬT KHẨU";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(278, 95);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(207, 27);
            dateTimePicker1.TabIndex = 49;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Đại học", "Cao Đẳng", "Trung cấp" });
            checkedListBox1.Location = new Point(278, 289);
            checkedListBox1.Margin = new Padding(2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(139, 26);
            checkedListBox1.TabIndex = 48;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(413, 339);
            checkBox2.Margin = new Padding(2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(51, 24);
            checkBox2.TabIndex = 47;
            checkBox2.Text = "Nữ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(278, 241);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(207, 27);
            textBox4.TabIndex = 45;
            textBox4.Text = "alex@gmail.com";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(278, 339);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 24);
            checkBox1.TabIndex = 46;
            checkBox1.Text = "Nam";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(158, 51);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 35;
            label8.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 95);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 36;
            label2.Text = "Ngày sinh";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(278, 192);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 27);
            textBox3.TabIndex = 44;
            textBox3.Text = "0234121215";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 144);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 37;
            label3.Text = "Địa chỉ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(278, 139);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 27);
            textBox2.TabIndex = 43;
            textBox2.Text = "153 St.Peterburg";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 195);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 38;
            label4.Text = "SĐT";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(278, 51);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 42;
            textBox1.Text = "Alex";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 243);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 39;
            label5.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(159, 342);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 41;
            label7.Text = "Giới tính";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 295);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 40;
            label1.Text = "Trình độ";
            // 
            // panelRegister
            // 
            panelRegister.BackColor = SystemColors.Control;
            panelRegister.BorderStyle = BorderStyle.FixedSingle;
            panelRegister.Controls.Add(btnChangePassword);
            panelRegister.Controls.Add(button1);
            panelRegister.Controls.Add(label2);
            panelRegister.Controls.Add(dateTimePicker1);
            panelRegister.Controls.Add(label1);
            panelRegister.Controls.Add(checkedListBox1);
            panelRegister.Controls.Add(label7);
            panelRegister.Controls.Add(checkBox2);
            panelRegister.Controls.Add(label5);
            panelRegister.Controls.Add(textBox4);
            panelRegister.Controls.Add(textBox1);
            panelRegister.Controls.Add(checkBox1);
            panelRegister.Controls.Add(label4);
            panelRegister.Controls.Add(label8);
            panelRegister.Controls.Add(textBox2);
            panelRegister.Controls.Add(label3);
            panelRegister.Controls.Add(textBox3);
            panelRegister.Location = new Point(276, 126);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(620, 512);
            panelRegister.TabIndex = 51;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 953);
            Controls.Add(panel1);
            Controls.Add(panelNavbar);
            Controls.Add(panelRegister);
            MinimumSize = new Size(1000, 800);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            WindowState = FormWindowState.Maximized;
            Load += HomePage_Load;
            Resize += HomePage_Resize;
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDKyDangTuyen;
        private Panel panelNavbar;
        private LinkLabel linkBack;
        private Label label6;
        private Button button1;
        private Panel panel1;
        private Button btnChangePassword;
        private DateTimePicker dateTimePicker1;
        private CheckedListBox checkedListBox1;
        private CheckBox checkBox2;
        private TextBox textBox4;
        private CheckBox checkBox1;
        private Label label8;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private Label label7;
        private Label label1;
        private Panel panelRegister;
        private Button button2;
        private Button button5;
        private Button button4;
        private Button nvXemHopDongBtn;
    }
}