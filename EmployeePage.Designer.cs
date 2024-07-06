namespace UI_winform
{
    partial class EmployeePage
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
            splitContainer1 = new SplitContainer();
            giaHanBtn = new Button();
            hoSoBtn = new Button();
            hopDongBtn = new Button();
            searchBtn = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            panelNavbar = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Silver;
            splitContainer1.Panel1.Controls.Add(giaHanBtn);
            splitContainer1.Panel1.Controls.Add(hoSoBtn);
            splitContainer1.Panel1.Controls.Add(hopDongBtn);
            splitContainer1.Panel1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(searchBtn);
            splitContainer1.Panel2.Controls.Add(comboBox1);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(panelNavbar);
            splitContainer1.Size = new Size(1347, 778);
            splitContainer1.SplitterDistance = 195;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // giaHanBtn
            // 
            giaHanBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            giaHanBtn.BackColor = Color.FromArgb(250, 135, 135);
            giaHanBtn.Location = new Point(0, 254);
            giaHanBtn.Margin = new Padding(5, 4, 5, 4);
            giaHanBtn.Name = "giaHanBtn";
            giaHanBtn.Size = new Size(190, 64);
            giaHanBtn.TabIndex = 5;
            giaHanBtn.Text = "XỬ LÝ GIA HẠN";
            giaHanBtn.UseVisualStyleBackColor = false;
            // 
            // hoSoBtn
            // 
            hoSoBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            hoSoBtn.BackColor = Color.FromArgb(250, 135, 135);
            hoSoBtn.Location = new Point(0, 182);
            hoSoBtn.Margin = new Padding(5, 4, 5, 4);
            hoSoBtn.Name = "hoSoBtn";
            hoSoBtn.Size = new Size(190, 64);
            hoSoBtn.TabIndex = 4;
            hoSoBtn.Text = "HỒ SƠ ỨNG VIÊN";
            hoSoBtn.UseVisualStyleBackColor = false;
            // 
            // hopDongBtn
            // 
            hopDongBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            hopDongBtn.BackColor = Color.FromArgb(250, 135, 135);
            hopDongBtn.Location = new Point(0, 111);
            hopDongBtn.Margin = new Padding(5, 4, 5, 4);
            hopDongBtn.Name = "hopDongBtn";
            hopDongBtn.Size = new Size(190, 64);
            hopDongBtn.TabIndex = 3;
            hopDongBtn.Text = "XỬ LÝ HỢP ĐỒNG";
            hopDongBtn.UseVisualStyleBackColor = false;
            hopDongBtn.Click += hopDongBtn_Click;
            // 
            // searchBtn
            // 
            searchBtn.BackColor = Color.FromArgb(250, 135, 135);
            searchBtn.Location = new Point(991, 312);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 35);
            searchBtn.TabIndex = 22;
            searchBtn.Text = "Tra cứu";
            searchBtn.UseVisualStyleBackColor = false;
            searchBtn.Click += searchBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 176, 176);
            comboBox1.Font = new Font("Segoe UI", 10.2F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Chưa duyệt", "Đã duyệt", "Gia hạn" });
            comboBox1.Location = new Point(991, 210);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 31);
            comboBox1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.Location = new Point(900, 213);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 20;
            label2.Text = "Tình trạng";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            flowLayoutPanel1.Location = new Point(9, 170);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(885, 582);
            flowLayoutPanel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 130);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 25);
            label1.TabIndex = 18;
            label1.Text = "DANH SÁCH HỢP ĐỒNG";
            // 
            // panelNavbar
            // 
            panelNavbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelNavbar.BackColor = Color.FromArgb(250, 135, 135);
            panelNavbar.BorderStyle = BorderStyle.FixedSingle;
            panelNavbar.Controls.Add(label6);
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Margin = new Padding(0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1146, 87);
            panelNavbar.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 18F, FontStyle.Bold);
            label6.Location = new Point(8, 21);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(279, 35);
            label6.TabIndex = 8;
            label6.Text = "XỬ LÝ HỢP ĐỒNG";
            // 
            // EmployeePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 778);
            Controls.Add(splitContainer1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "EmployeePage";
            Text = "EmployeePage";
            FormClosed += EmployeePage_FormClosed;
            Load += EmployeePage_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Panel panelNavbar;
        private Label label6;
        public Button giaHanBtn;
        public Button hoSoBtn;
        public Button hopDongBtn;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private ComboBox comboBox1;
        private Button searchBtn;
    }
}