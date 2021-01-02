namespace DoAn_XDUDTN
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.item_Cauhoi = new System.Windows.Forms.ToolStripMenuItem();
            this.item_taocauhoi = new System.Windows.Forms.ToolStripMenuItem();
            this.item_taodethi = new System.Windows.Forms.ToolStripMenuItem();
            this.item_phongthi = new System.Windows.Forms.ToolStripMenuItem();
            this.item_taophongthi = new System.Windows.Forms.ToolStripMenuItem();
            this.item_themde = new System.Windows.Forms.ToolStripMenuItem();
            this.item_ketqua = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.item_Taikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.item_Dangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_Cauhoi,
            this.item_phongthi,
            this.item_ketqua,
            this.item_Taikhoan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // item_Cauhoi
            // 
            this.item_Cauhoi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_taocauhoi,
            this.item_taodethi});
            this.item_Cauhoi.Name = "item_Cauhoi";
            this.item_Cauhoi.Size = new System.Drawing.Size(73, 24);
            this.item_Cauhoi.Text = "Câu hỏi";
            // 
            // item_taocauhoi
            // 
            this.item_taocauhoi.Name = "item_taocauhoi";
            this.item_taocauhoi.Size = new System.Drawing.Size(224, 26);
            this.item_taocauhoi.Text = "Tạo câu hỏi";
            this.item_taocauhoi.Click += new System.EventHandler(this.item_taocauhoi_Click);
            // 
            // item_taodethi
            // 
            this.item_taodethi.Name = "item_taodethi";
            this.item_taodethi.Size = new System.Drawing.Size(224, 26);
            this.item_taodethi.Text = "Tạo đề thi";
            this.item_taodethi.Click += new System.EventHandler(this.item_taodethi_Click);
            // 
            // item_phongthi
            // 
            this.item_phongthi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_taophongthi,
            this.item_themde});
            this.item_phongthi.Name = "item_phongthi";
            this.item_phongthi.Size = new System.Drawing.Size(86, 24);
            this.item_phongthi.Text = "Phòng thi";
            // 
            // item_taophongthi
            // 
            this.item_taophongthi.Name = "item_taophongthi";
            this.item_taophongthi.Size = new System.Drawing.Size(224, 26);
            this.item_taophongthi.Text = "Tạo phòng thi";
            this.item_taophongthi.Click += new System.EventHandler(this.item_taophongthi_Click);
            // 
            // item_themde
            // 
            this.item_themde.Name = "item_themde";
            this.item_themde.Size = new System.Drawing.Size(224, 26);
            this.item_themde.Text = "Thêm đề";
            this.item_themde.Click += new System.EventHandler(this.item_themde_Click);
            // 
            // item_ketqua
            // 
            this.item_ketqua.Name = "item_ketqua";
            this.item_ketqua.Size = new System.Drawing.Size(74, 24);
            this.item_ketqua.Text = "Kết quả";
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.Location = new System.Drawing.Point(0, 31);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(804, 439);
            this.panel.TabIndex = 1;
            // 
            // item_Taikhoan
            // 
            this.item_Taikhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_Dangxuat});
            this.item_Taikhoan.Name = "item_Taikhoan";
            this.item_Taikhoan.Size = new System.Drawing.Size(85, 24);
            this.item_Taikhoan.Text = "Tài khoản";
            // 
            // item_Dangxuat
            // 
            this.item_Dangxuat.Name = "item_Dangxuat";
            this.item_Dangxuat.Size = new System.Drawing.Size(224, 26);
            this.item_Dangxuat.Text = "Đăng xuất";
            this.item_Dangxuat.Click += new System.EventHandler(this.item_Dangxuat_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 470);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem item_Cauhoi;
        private System.Windows.Forms.ToolStripMenuItem item_taocauhoi;
        private System.Windows.Forms.ToolStripMenuItem item_taodethi;
        private System.Windows.Forms.ToolStripMenuItem item_phongthi;
        private System.Windows.Forms.ToolStripMenuItem item_taophongthi;
        private System.Windows.Forms.ToolStripMenuItem item_themde;
        private System.Windows.Forms.ToolStripMenuItem item_ketqua;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem item_Taikhoan;
        private System.Windows.Forms.ToolStripMenuItem item_Dangxuat;
    }
}