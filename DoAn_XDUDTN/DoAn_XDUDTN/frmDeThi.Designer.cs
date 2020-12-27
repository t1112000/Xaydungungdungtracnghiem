namespace DoAn_XDUDTN
{
    partial class frmDeThi
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Doi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_MonHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaDe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoCauHoi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_TaoMoi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gview_DsDe = new System.Windows.Forms.DataGridView();
            this.gBox_DeThi = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gview_DsDe)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 317F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 312F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btn_Doi, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbo_MonHoc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_MaDe, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_SoCauHoi, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.gBox_DeThi, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1244, 650);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Doi
            // 
            this.btn_Doi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Doi.Location = new System.Drawing.Point(4, 611);
            this.btn_Doi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Doi.Name = "btn_Doi";
            this.btn_Doi.Size = new System.Drawing.Size(80, 35);
            this.btn_Doi.TabIndex = 0;
            this.btn_Doi.Text = "Đổi";
            this.btn_Doi.UseVisualStyleBackColor = true;
            this.btn_Doi.Click += new System.EventHandler(this.btn_Doi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Môn Học";
            // 
            // cbo_MonHoc
            // 
            this.cbo_MonHoc.FormattingEnabled = true;
            this.cbo_MonHoc.Location = new System.Drawing.Point(92, 4);
            this.cbo_MonHoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_MonHoc.Name = "cbo_MonHoc";
            this.cbo_MonHoc.Size = new System.Drawing.Size(308, 24);
            this.cbo_MonHoc.TabIndex = 1;
            this.cbo_MonHoc.SelectedIndexChanged += new System.EventHandler(this.cbmBox_MonHoc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(409, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã Đề";
            // 
            // txt_MaDe
            // 
            this.txt_MaDe.Location = new System.Drawing.Point(478, 4);
            this.txt_MaDe.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaDe.Name = "txt_MaDe";
            this.txt_MaDe.ReadOnly = true;
            this.txt_MaDe.Size = new System.Drawing.Size(303, 22);
            this.txt_MaDe.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(790, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số Câu Hỏi";
            // 
            // txt_SoCauHoi
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txt_SoCauHoi, 2);
            this.txt_SoCauHoi.Location = new System.Drawing.Point(929, 4);
            this.txt_SoCauHoi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoCauHoi.Name = "txt_SoCauHoi";
            this.txt_SoCauHoi.Size = new System.Drawing.Size(308, 22);
            this.txt_SoCauHoi.TabIndex = 5;
            this.txt_SoCauHoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoCauHoi_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Controls.Add(this.btn_TaoMoi);
            this.panel1.Location = new System.Drawing.Point(1021, 611);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 35);
            this.panel1.TabIndex = 8;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Luu.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Luu.Location = new System.Drawing.Point(7, 3);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(100, 28);
            this.btn_Luu.TabIndex = 7;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TaoMoi.Location = new System.Drawing.Point(115, 3);
            this.btn_TaoMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(100, 28);
            this.btn_TaoMoi.TabIndex = 6;
            this.btn_TaoMoi.Text = "Tạo Mới";
            this.btn_TaoMoi.UseVisualStyleBackColor = true;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.gview_DsDe);
            this.groupBox1.Location = new System.Drawing.Point(929, 45);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.SetRowSpan(this.groupBox1, 2);
            this.groupBox1.Size = new System.Drawing.Size(311, 558);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Đề Thi";
            // 
            // gview_DsDe
            // 
            this.gview_DsDe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gview_DsDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gview_DsDe.Location = new System.Drawing.Point(8, 23);
            this.gview_DsDe.Margin = new System.Windows.Forms.Padding(4);
            this.gview_DsDe.Name = "gview_DsDe";
            this.gview_DsDe.RowHeadersWidth = 51;
            this.gview_DsDe.Size = new System.Drawing.Size(295, 527);
            this.gview_DsDe.TabIndex = 0;
            // 
            // gBox_DeThi
            // 
            this.gBox_DeThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.gBox_DeThi, 5);
            this.gBox_DeThi.Location = new System.Drawing.Point(4, 45);
            this.gBox_DeThi.Margin = new System.Windows.Forms.Padding(4);
            this.gBox_DeThi.Name = "gBox_DeThi";
            this.gBox_DeThi.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.SetRowSpan(this.gBox_DeThi, 2);
            this.gBox_DeThi.Size = new System.Drawing.Size(917, 558);
            this.gBox_DeThi.TabIndex = 10;
            this.gBox_DeThi.TabStop = false;
            this.gBox_DeThi.Text = "Đề Thi";
            // 
            // frmDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 652);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDeThi";
            this.Text = "frnDeThi";
            this.Load += new System.EventHandler(this.frmDeThi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gview_DsDe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_MonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_TaoMoi;
        private System.Windows.Forms.TextBox txt_SoCauHoi;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gview_DsDe;
        private System.Windows.Forms.Button btn_Doi;
        private System.Windows.Forms.GroupBox gBox_DeThi;
    }
}