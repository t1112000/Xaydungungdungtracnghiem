namespace DoAn_XDUDTN
{
    partial class frmDangNhap
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Text_MSSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Text_MK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Radio_SV = new System.Windows.Forms.RadioButton();
            this.Radio_GV = new System.Windows.Forms.RadioButton();
            this.BTN_DangNhap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(476, 315);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "MSSV";
            // 
            // Text_MSSV
            // 
            this.Text_MSSV.Location = new System.Drawing.Point(131, 50);
            this.Text_MSSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_MSSV.Name = "Text_MSSV";
            this.Text_MSSV.Size = new System.Drawing.Size(268, 22);
            this.Text_MSSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 2;
            // 
            // Text_MK
            // 
            this.Text_MK.Location = new System.Drawing.Point(131, 105);
            this.Text_MK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_MK.Name = "Text_MK";
            this.Text_MK.Size = new System.Drawing.Size(268, 22);
            this.Text_MK.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // Radio_SV
            // 
            this.Radio_SV.AutoSize = true;
            this.Radio_SV.Checked = true;
            this.Radio_SV.Location = new System.Drawing.Point(84, 156);
            this.Radio_SV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Radio_SV.Name = "Radio_SV";
            this.Radio_SV.Size = new System.Drawing.Size(113, 21);
            this.Radio_SV.TabIndex = 3;
            this.Radio_SV.TabStop = true;
            this.Radio_SV.Text = "Tôi là thí sinh";
            this.Radio_SV.UseVisualStyleBackColor = true;
            // 
            // Radio_GV
            // 
            this.Radio_GV.AutoSize = true;
            this.Radio_GV.Location = new System.Drawing.Point(245, 156);
            this.Radio_GV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Radio_GV.Name = "Radio_GV";
            this.Radio_GV.Size = new System.Drawing.Size(125, 21);
            this.Radio_GV.TabIndex = 4;
            this.Radio_GV.TabStop = true;
            this.Radio_GV.Text = "Tôi là giáo viên";
            this.Radio_GV.UseVisualStyleBackColor = true;
            // 
            // BTN_DangNhap
            // 
            this.BTN_DangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_DangNhap.Location = new System.Drawing.Point(84, 209);
            this.BTN_DangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTN_DangNhap.Name = "BTN_DangNhap";
            this.BTN_DangNhap.Size = new System.Drawing.Size(291, 60);
            this.BTN_DangNhap.TabIndex = 5;
            this.BTN_DangNhap.Text = "ĐĂNG NHẬP";
            this.BTN_DangNhap.UseVisualStyleBackColor = true;
            this.BTN_DangNhap.Click += new System.EventHandler(this.BTN_DangNhap_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 319);
            this.Controls.Add(this.BTN_DangNhap);
            this.Controls.Add(this.Radio_GV);
            this.Controls.Add(this.Radio_SV);
            this.Controls.Add(this.Text_MK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Text_MSSV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDangNhap";
            this.Text = "Ứng Dụng Trắc Nghiệm";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Text_MSSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Text_MK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton Radio_SV;
        private System.Windows.Forms.RadioButton Radio_GV;
        private System.Windows.Forms.Button BTN_DangNhap;
    }
}

