namespace UI_winform
{
    partial class NopHoSo03
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            button1 = new Button();
            label5 = new Label();
            panelNavbar = new Panel();
            label9 = new Label();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(250, 135, 135);
            button1.Location = new Point(595, 579);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(129, 42);
            button1.TabIndex = 31;
            button1.Text = "Kết thúc";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 94);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(238, 25);
            label5.TabIndex = 20;
            label5.Text = "Chứng từ, bằng cấp (nếu có)";
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
            label9.Size = new Size(387, 43);
            label9.TabIndex = 8;
            label9.Text = "BỔ SUNG BẰNG CẤP";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Location = new Point(299, 87);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(93, 43);
            button3.TabIndex = 54;
            button3.Text = "Thêm";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
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
            dataGridView1.Location = new Point(45, 135);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 10, 0, 10);
            dataGridView1.RowTemplate.Height = 50;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(1007, 237);
            dataGridView1.TabIndex = 55;
            // 
            // NopHoSo03
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(panelNavbar);
            Controls.Add(button1);
            Controls.Add(label5);
            Margin = new Padding(2);
            MinimumSize = new Size(1244, 986);
            Name = "NopHoSo03";
            Size = new Size(1244, 986);
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private Panel panelNavbar;
        private Label label9;
        private Button button3;
        private DataGridView dataGridView1;
    }
}