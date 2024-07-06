namespace UI_winform
{
    partial class DangKyDangTuyen2
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
            panelNavbar = new Panel();
            label6 = new Label();
            btnRegister = new Button();
            btnCancel = new Button();
            lblTitle = new Label();
            panelRegister = new Panel();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            checkBox1 = new CheckBox();
            panelNavbar.SuspendLayout();
            panelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelNavbar.BackColor = Color.FromArgb(250, 135, 135);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(label6);
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1068, 58);
            panelNavbar.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold);
            label6.Location = new Point(11, 8);
            label6.Name = "label6";
            label6.Size = new Size(456, 35);
            label6.TabIndex = 1;
            label6.Text = "ĐĂNG KÝ ĐĂNG TUYỂN DỤNG";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(250, 135, 135);
            btnRegister.Location = new Point(406, 421);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(107, 38);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "ĐĂNG KÝ";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(250, 135, 135);
            btnCancel.Location = new Point(256, 421);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 38);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "QUAY LẠI";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(148, 55);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(487, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "HÌNH THỨC ĐĂNG TUYỂN DỤNG";
            // 
            // panelRegister
            // 
            panelRegister.BackColor = Color.FromArgb(217, 217, 217);
            panelRegister.BorderStyle = BorderStyle.FixedSingle;
            panelRegister.Controls.Add(checkBox5);
            panelRegister.Controls.Add(checkBox4);
            panelRegister.Controls.Add(label4);
            panelRegister.Controls.Add(dateTimePicker2);
            panelRegister.Controls.Add(label3);
            panelRegister.Controls.Add(label1);
            panelRegister.Controls.Add(label2);
            panelRegister.Controls.Add(dateTimePicker1);
            panelRegister.Controls.Add(checkBox1);
            panelRegister.Controls.Add(lblTitle);
            panelRegister.Controls.Add(btnCancel);
            panelRegister.Controls.Add(btnRegister);
            panelRegister.Location = new Point(118, 132);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(746, 513);
            panelRegister.TabIndex = 1;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = SystemColors.Window;
            checkBox5.FlatStyle = FlatStyle.Flat;
            checkBox5.Font = new Font("Segoe UI", 11F);
            checkBox5.ImageAlign = ContentAlignment.MiddleRight;
            checkBox5.Location = new Point(308, 343);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(217, 29);
            checkBox5.TabIndex = 26;
            checkBox5.Text = "Đăng trên trang mạng";
            checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = SystemColors.Window;
            checkBox4.Checked = true;
            checkBox4.CheckState = CheckState.Checked;
            checkBox4.FlatStyle = FlatStyle.Flat;
            checkBox4.Font = new Font("Segoe UI", 11F);
            checkBox4.ImageAlign = ContentAlignment.MiddleRight;
            checkBox4.Location = new Point(308, 308);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(190, 29);
            checkBox4.TabIndex = 25;
            checkBox4.Text = "Banner Quảng Cáo";
            checkBox4.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(257, 191);
            label4.Name = "label4";
            label4.Size = new Size(46, 25);
            label4.TabIndex = 24;
            label4.Text = "Đến";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 11F);
            dateTimePicker2.Location = new Point(308, 191);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(320, 32);
            dateTimePicker2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(257, 160);
            label3.Name = "label3";
            label3.Size = new Size(33, 25);
            label3.TabIndex = 22;
            label3.Text = "Từ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(56, 273);
            label1.Name = "label1";
            label1.Size = new Size(243, 25);
            label1.TabIndex = 21;
            label1.Text = "Hình thức đăng tuyển dụng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(56, 161);
            label2.Name = "label2";
            label2.Size = new Size(191, 25);
            label2.TabIndex = 20;
            label2.Text = "Thời gian đăng tuyển";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 11F);
            dateTimePicker1.Location = new Point(308, 160);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(320, 32);
            dateTimePicker1.TabIndex = 18;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.Window;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Segoe UI", 11F);
            checkBox1.ImageAlign = ContentAlignment.MiddleRight;
            checkBox1.Location = new Point(308, 273);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 29);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Báo giấy";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // DangKyDangTuyen2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(panelNavbar);
            Controls.Add(panelRegister);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1000, 800);
            Name = "DangKyDangTuyen2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangKyDangTuyen2";
            Load += DangKyDangTuyen2_Load;
            Resize += DangKyDangTuyen2_Resize;
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
        }



        #endregion
        private Panel panelNavbar;
        private Label label6;
        private Button btnRegister;
        private Button btnCancel;
        private Label lblTitle;
        private Panel panelRegister;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Label label1;
        private Label label2;
        private Label label4;
        private DateTimePicker dateTimePicker2;
        private CheckBox checkBox1;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
    }
}