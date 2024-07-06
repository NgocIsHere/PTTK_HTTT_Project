namespace UI_winform.controls
{
    partial class SideBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            hopDongBtn = new Button();
            hoSoBtn = new Button();
            giaHanBtn = new Button();
            SuspendLayout();
            // 
            // hopDongBtn
            // 
            hopDongBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            hopDongBtn.BackColor = Color.FromArgb(250, 135, 135);
            hopDongBtn.Location = new Point(0, 74);
            hopDongBtn.Margin = new Padding(4, 3, 4, 3);
            hopDongBtn.Name = "hopDongBtn";
            hopDongBtn.Size = new Size(170, 51);
            hopDongBtn.TabIndex = 0;
            hopDongBtn.Text = "XỬ LÝ HỢP ĐỒNG";
            hopDongBtn.UseVisualStyleBackColor = false;
            hopDongBtn.Click += hopDongBtn_Click;
            // 
            // hoSoBtn
            // 
            hoSoBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            hoSoBtn.BackColor = Color.FromArgb(250, 135, 135);
            hoSoBtn.Location = new Point(0, 131);
            hoSoBtn.Margin = new Padding(4, 3, 4, 3);
            hoSoBtn.Name = "hoSoBtn";
            hoSoBtn.Size = new Size(170, 51);
            hoSoBtn.TabIndex = 1;
            hoSoBtn.Text = "HỒ SƠ ỨNG VIÊN";
            hoSoBtn.UseVisualStyleBackColor = false;
            // 
            // giaHanBtn
            // 
            giaHanBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            giaHanBtn.BackColor = Color.FromArgb(250, 135, 135);
            giaHanBtn.Location = new Point(0, 188);
            giaHanBtn.Margin = new Padding(4, 3, 4, 3);
            giaHanBtn.Name = "giaHanBtn";
            giaHanBtn.Size = new Size(170, 51);
            giaHanBtn.TabIndex = 2;
            giaHanBtn.Text = "XỬ LÝ GIA HẠN";
            giaHanBtn.UseVisualStyleBackColor = false;
            // 
            // SideBar
            // 
            AutoScaleDimensions = new SizeF(11F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            Controls.Add(giaHanBtn);
            Controls.Add(hoSoBtn);
            Controls.Add(hopDongBtn);
            Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SideBar";
            Size = new Size(170, 783);
            ResumeLayout(false);
        }

        #endregion

        public Button hopDongBtn;
        public Button hoSoBtn;
        public Button giaHanBtn;
    }
}
