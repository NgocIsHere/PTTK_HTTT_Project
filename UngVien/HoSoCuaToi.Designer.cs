namespace UI_winform
{
    partial class HoSoCuaToi
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            button1 = new Button();
            label5 = new Label();
            bindingSource1 = new BindingSource(components);
            label3 = new Label();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            panelNavbar = new Panel();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(250, 135, 135);
            button1.ForeColor = SystemColors.Desktop;
            button1.Location = new Point(1050, 240);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(129, 42);
            button1.TabIndex = 31;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(1050, 99);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 20;
            label5.Text = "TÌM KIẾM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Desktop;
            label3.Location = new Point(1002, 128);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 36;
            label3.Text = "Từ khóa";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1002, 155);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 31);
            textBox2.TabIndex = 35;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.Navy;
            dataGridViewCellStyle2.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 30;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.Location = new Point(22, 88);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(957, 475);
            dataGridView1.TabIndex = 40;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.FromArgb(250, 135, 135);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(label9);
            panelNavbar.Location = new Point(1, 0);
            panelNavbar.Margin = new Padding(4);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1243, 72);
            panelNavbar.TabIndex = 53;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 18F, FontStyle.Bold);
            label9.Location = new Point(17, 8);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(294, 43);
            label9.TabIndex = 8;
            label9.Text = "HỒ SƠ CỦA TÔI";
            // 
            // HoSoCuaToi
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelNavbar);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label5);
            Margin = new Padding(2);
            MinimumSize = new Size(1244, 986);
            Name = "HoSoCuaToi";
            Size = new Size(1244, 986);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private BindingSource bindingSource1;
        private Label label3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private Panel panelNavbar;
        private Label label9;
        private Button dropdownButton;
        private List<string> options;
    }
    
}