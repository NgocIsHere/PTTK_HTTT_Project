namespace UI_winform
{
    partial class DangKyTVUV
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(319, 82);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 138);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(319, 199);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 2;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(320, 262);
            label4.Name = "label4";
            label4.Size = new Size(44, 25);
            label4.TabIndex = 3;
            label4.Text = "SĐT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(320, 323);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 4;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(320, 387);
            label6.Name = "label6";
            label6.Size = new Size(76, 25);
            label6.TabIndex = 5;
            label6.Text = "Trình độ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(320, 446);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 6;
            label7.Text = "Giới tính";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(469, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(469, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(469, 259);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(258, 31);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(469, 320);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(258, 31);
            textBox4.TabIndex = 10;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(469, 442);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(76, 29);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Nam";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(638, 442);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(62, 29);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "Nữ";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(469, 138);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 31);
            dateTimePicker1.TabIndex = 14;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(469, 541);
            button1.Name = "button1";
            button1.Size = new Size(129, 43);
            button1.TabIndex = 15;
            button1.Text = "ĐĂNG KÝ";
            button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Đại học", "Cao Đẳng", "Trung cấp" });
            comboBox1.Location = new Point(469, 379);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 16;
            // 
            // DangKyTVUV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 725);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DangKyTVUV";
            Text = "DangKyTVUV";
            Load += DangKyTVUV_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private ComboBox comboBox1;
    }
}