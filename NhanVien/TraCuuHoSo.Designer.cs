namespace UI_winform
{
    partial class TraCuuHoSo
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label5 = new Label();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            checkedListBox1 = new CheckedListBox();
            label3 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(594, 222);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(103, 34);
            button1.TabIndex = 31;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(572, 97);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 20;
            label5.Text = "TÌM KIẾM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(594, 131);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 32;
            label1.Text = "Vị trí";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Mã hồ sơ", "Công Ty", "Tình trạng", "Ngày gửi", "Tất cả" });
            checkedListBox1.Location = new Point(679, 131);
            checkedListBox1.Margin = new Padding(2, 2, 2, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(203, 26);
            checkedListBox1.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(594, 174);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 36;
            label3.Text = "Từ khóa";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(679, 170);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(127, 27);
            textBox2.TabIndex = 35;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 74);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(538, 370);
            dataGridView1.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 30);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 38;
            label2.Text = "DANH SÁCH HỒ SƠ";
            // 
            // TraCuuHoSo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 753);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label5);
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(1000, 800);
            Name = "TraCuuHoSo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TraCuuHoSo";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private Label label1;
        private BindingSource bindingSource1;
        private CheckedListBox checkedListBox1;
        private Label label3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Label label2;
    }
}