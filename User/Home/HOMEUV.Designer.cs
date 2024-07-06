using System.Drawing;
using System.Windows.Forms;

namespace UI_winform
{
    partial class HOMEUV
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
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            btn_dx = new Button();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            content = new Panel();
            linkLabel1 = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(btn_dx);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 860);
            panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.None;
            pictureBox4.BackColor = SystemColors.InactiveCaption;
            pictureBox4.Image = Properties.Resources.user;
            pictureBox4.Location = new Point(61, 28);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            pictureBox4.WaitOnLoad = true;
            // 
            // btn_dx
            // 
            btn_dx.BackColor = Color.Aqua;
            btn_dx.FlatStyle = FlatStyle.Popup;
            btn_dx.Font = new Font("Consolas", 12F, FontStyle.Bold);
            btn_dx.ForeColor = Color.Black;
            btn_dx.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dx.Location = new Point(2, 1011);
            btn_dx.Margin = new Padding(4, 3, 4, 3);
            btn_dx.Name = "btn_dx";
            btn_dx.Size = new Size(301, 111);
            btn_dx.TabIndex = 11;
            btn_dx.Text = "Đăng xuất";
            btn_dx.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_dx.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightCoral;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Consolas", 12F, FontStyle.Bold);
            button2.ForeColor = Color.Black;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(4, 299);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(207, 90);
            button2.TabIndex = 3;
            button2.Text = "Tra cứu tuyển dụng";
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightCoral;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Consolas", 12F, FontStyle.Bold);
            button3.ForeColor = Color.Black;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(4, 395);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(207, 90);
            button3.TabIndex = 2;
            button3.Text = "Hồ sơ đã nộp";
            button3.TextImageRelation = TextImageRelation.ImageBeforeText;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightCoral;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Consolas", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(4, 203);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(207, 90);
            button1.TabIndex = 3;
            button1.Text = "Thông tin thành viên";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // content
            // 
            content.BackColor = SystemColors.Control;
            content.Cursor = Cursors.SizeAll;
            content.ForeColor = Color.White;
            content.Location = new Point(219, 0);
            content.Margin = new Padding(4, 3, 4, 3);
            content.Name = "content";
            content.Size = new Size(1239, 944);
            content.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.WhiteSmoke;
            linkLabel1.Anchor = AnchorStyles.Bottom;
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = SystemColors.ActiveBorder;
            linkLabel1.BorderStyle = BorderStyle.Fixed3D;
            linkLabel1.Cursor = Cursors.AppStarting;
            linkLabel1.Font = new Font("Cascadia Code", 18F);
            linkLabel1.LinkColor = Color.Red;
            linkLabel1.Location = new Point(4, 863);
            linkLabel1.Margin = new Padding(4, 0, 4, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(211, 49);
            linkLabel1.TabIndex = 4;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Đăng xuất";
            // 
            // HOMEUV
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1453, 941);
            Controls.Add(linkLabel1);
            Controls.Add(content);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "HOMEUV";
            Text = "HOMEUV";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel content;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button btn_dx;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox4;
    }
}