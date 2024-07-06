namespace UI_winform
{
    partial class NopHoSo02
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            panelNavbar = new Panel();
            label9 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(250, 135, 135);
            button1.Location = new Point(629, 579);
            button1.BackColor = Color.FromArgb(250, 135, 135);
            button1.Location = new Point(629, 579);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(129, 42);
            button1.TabIndex = 31;
            button1.Text = "Nộp";
            button1.Text = "Nộp";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 121);
            textBox1.Location = new Point(42, 121);
            textBox1.Margin = new Padding(2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(770, 159);
            textBox1.TabIndex = 23;
            textBox1.Text = "Thông tin hồ sơ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 85);
            label1.Location = new Point(42, 85);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(224, 25);
            label1.TabIndex = 16;
            label1.Text = "Thông tin hồ sơ ứng tuyển";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(420, 579);
            button2.Location = new Point(420, 579);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(129, 42);
            button2.TabIndex = 32;
            button2.Text = "Quay lại";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.FromArgb(250, 135, 135);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(label9);
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Margin = new Padding(4);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1244, 72);
            panelNavbar.TabIndex = 53;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 18F, FontStyle.Bold);
            label9.Location = new Point(20, 14);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(225, 43);
            label9.TabIndex = 8;
            label9.Text = "NỘP HỒ SƠ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 295);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 54;
            label2.Text = "Link CV";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(48, 332);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(764, 31);
            textBox2.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 295);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 54;
            label2.Text = "Link CV";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(48, 332);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(764, 31);
            textBox2.TabIndex = 55;
            // 
            // NopHoSo02
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(panelNavbar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            MinimumSize = new Size(1244, 986);
            Name = "NopHoSo02";
            Size = new Size(1244, 986);
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Panel panelNavbar;
        private Label label9;
        private Label label2;
        private TextBox textBox2;
        
    }
}