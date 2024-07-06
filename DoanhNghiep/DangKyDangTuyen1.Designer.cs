namespace UI_winform
{
    partial class DangKyDangTuyen1
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
            textBox1 = new TextBox();
            label1 = new Label();
            panelRegister = new Panel();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
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
            btnRegister.Location = new Point(403, 466);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(107, 38);
            btnRegister.TabIndex = 14;
            btnRegister.Text = "TIẾP TỤC";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(250, 135, 135);
            btnCancel.Location = new Point(253, 466);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 38);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "HỦY";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(187, 59);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(385, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "THÔNG TIN ĐĂNG TUYỂN";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11F);
            textBox1.Location = new Point(314, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(350, 32);
            textBox1.TabIndex = 20;
            textBox1.Text = "Quản lý nhân sự";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(107, 155);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 19;
            label1.Text = "Vị trí ứng tuyển";
            // 
            // panelRegister
            // 
            panelRegister.BackColor = Color.FromArgb(217, 217, 217);
            panelRegister.BorderStyle = BorderStyle.FixedSingle;
            panelRegister.Controls.Add(textBox4);
            panelRegister.Controls.Add(label4);
            panelRegister.Controls.Add(label3);
            panelRegister.Controls.Add(textBox3);
            panelRegister.Controls.Add(label2);
            panelRegister.Controls.Add(textBox2);
            panelRegister.Controls.Add(label1);
            panelRegister.Controls.Add(textBox1);
            panelRegister.Controls.Add(lblTitle);
            panelRegister.Controls.Add(btnCancel);
            panelRegister.Controls.Add(btnRegister);
            panelRegister.Location = new Point(122, 126);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(746, 548);
            panelRegister.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11F);
            textBox4.Location = new Point(314, 318);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Both;
            textBox4.Size = new Size(350, 113);
            textBox4.TabIndex = 26;
            textBox4.Text = "- Trình độ học vấn: Đại học \r\n- Chứng chỉ tin học Z\r\n- Chứng chỉ tiếng anh A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(107, 318);
            label4.Name = "label4";
            label4.Size = new Size(155, 25);
            label4.TabIndex = 25;
            label4.Text = "Yêu cầu ứng viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(107, 263);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 23;
            label3.Text = "Mô tả công việc";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 11F);
            textBox3.Location = new Point(314, 260);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(350, 32);
            textBox3.TabIndex = 24;
            textBox3.Text = "Quản lý phòng ban nhân sự";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(107, 210);
            label2.Name = "label2";
            label2.Size = new Size(177, 25);
            label2.TabIndex = 21;
            label2.Text = "Số lượng ứng tuyển";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 11F);
            textBox2.Location = new Point(314, 207);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(54, 32);
            textBox2.TabIndex = 22;
            textBox2.Text = "1";
            // 
            // DangKyDangTuyen1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(panelNavbar);
            Controls.Add(panelRegister);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1000, 800);
            Name = "DangKyDangTuyen1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DangKyDangTuyen1";
            Load += DangKyDangTuyen1_Load;
            Resize += DangKyDangTuyen1_Resize;
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
        }


        #endregion
        private Panel panelNavbar;
        private Button btnRegister;
        private Button btnCancel;
        private Label lblTitle;
        private TextBox textBox1;
        private Label label1;
        private Panel panelRegister;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label4;
        private Label label6;
        private TextBox textBox4;
    }
}