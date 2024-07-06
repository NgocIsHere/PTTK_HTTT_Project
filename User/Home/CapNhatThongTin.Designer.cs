namespace UI_winform
{
    partial class CapNhatThongTin
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
            linkLabel1 = new LinkLabel();
            dateTimePicker1 = new DateTimePicker();
            checkedListBox1 = new CheckedListBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label8 = new Label();
            btnRegister = new Button();
            panelRegister = new Panel();
            lblTitle = new Label();
            panelNavbar.SuspendLayout();
            panelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.FromArgb(250, 135, 135);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(label6);
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(982, 58);
            panelNavbar.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold);
            label6.Location = new Point(11, 8);
            label6.Name = "label6";
            label6.Size = new Size(335, 35);
            label6.TabIndex = 8;
            label6.Text = "THÔNG TIN ỨNG VIÊN";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(566, 560);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 20);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quay lại";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(289, 183);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(207, 27);
            dateTimePicker1.TabIndex = 33;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Đại học", "Cao Đẳng", "Trung cấp" });
            checkedListBox1.Location = new Point(289, 377);
            checkedListBox1.Margin = new Padding(2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(139, 26);
            checkedListBox1.TabIndex = 32;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(424, 427);
            checkBox2.Margin = new Padding(2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(51, 24);
            checkBox2.TabIndex = 31;
            checkBox2.Text = "Nữ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(289, 427);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 24);
            checkBox1.TabIndex = 30;
            checkBox1.Text = "Nam";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(289, 329);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(207, 27);
            textBox4.TabIndex = 29;
            textBox4.Text = "alex@gmail.com";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(289, 280);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 27);
            textBox3.TabIndex = 28;
            textBox3.Text = "0234121215";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(289, 227);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 27);
            textBox2.TabIndex = 27;
            textBox2.Text = "153 St.Peterburg";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(289, 139);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 26;
            textBox1.Text = "Alex";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(170, 430);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 25;
            label7.Text = "Giới tính";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(170, 383);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 24;
            label1.Text = "Trình độ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 331);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 23;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(170, 283);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 22;
            label4.Text = "SĐT";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 232);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 21;
            label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 183);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 20;
            label2.Text = "Ngày sinh";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(169, 139);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 19;
            label8.Text = "Họ tên";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(250, 135, 135);
            btnRegister.Location = new Point(263, 490);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(121, 44);
            btnRegister.TabIndex = 34;
            btnRegister.Text = "CẬP NHẬT";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // panelRegister
            // 
            panelRegister.BackColor = Color.FromArgb(217, 217, 217);
            panelRegister.BorderStyle = BorderStyle.FixedSingle;
            panelRegister.Controls.Add(linkLabel1);
            panelRegister.Controls.Add(btnRegister);
            panelRegister.Controls.Add(dateTimePicker1);
            panelRegister.Controls.Add(lblTitle);
            panelRegister.Controls.Add(checkedListBox1);
            panelRegister.Controls.Add(checkBox2);
            panelRegister.Controls.Add(textBox4);
            panelRegister.Controls.Add(checkBox1);
            panelRegister.Controls.Add(label8);
            panelRegister.Controls.Add(label2);
            panelRegister.Controls.Add(textBox3);
            panelRegister.Controls.Add(label3);
            panelRegister.Controls.Add(textBox2);
            panelRegister.Controls.Add(label4);
            panelRegister.Controls.Add(textBox1);
            panelRegister.Controls.Add(label5);
            panelRegister.Controls.Add(label7);
            panelRegister.Controls.Add(label1);
            panelRegister.Location = new Point(174, 102);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(657, 603);
            panelRegister.TabIndex = 35;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(156, 61);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(340, 35);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "CẬP NHẬT THÔNG TIN";
            // 
            // CapNhatThongTin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(panelNavbar);
            Controls.Add(panelRegister);
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(1000, 800);
            Name = "CapNhatThongTin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CapNhatThongTin";
            Load += CapNhatThongTin_Load;
            Resize += CapNhatThongTin_Resize;
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavbar;
        private Label label6;
        private LinkLabel linkLabel1;
        private DateTimePicker dateTimePicker1;
        private CheckedListBox checkedListBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Button btnRegister;
        private Panel panelRegister;
        private Label lblTitle;
    }
}