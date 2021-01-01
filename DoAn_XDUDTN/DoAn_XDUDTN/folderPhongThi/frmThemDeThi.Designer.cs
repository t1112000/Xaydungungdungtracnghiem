namespace DoAn_XDUDTN.folderPhongThi
{
    partial class frmThemDeThi
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_Phongthi = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gview_Dethi = new System.Windows.Forms.DataGridView();
            this.gview_Khode = new System.Windows.Forms.DataGridView();
            this.gbox_Dethi = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gview_Dethi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gview_Khode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phòng thi";
            // 
            // cbo_Phongthi
            // 
            this.cbo_Phongthi.FormattingEnabled = true;
            this.cbo_Phongthi.Location = new System.Drawing.Point(98, 16);
            this.cbo_Phongthi.Name = "cbo_Phongthi";
            this.cbo_Phongthi.Size = new System.Drawing.Size(187, 24);
            this.cbo_Phongthi.TabIndex = 1;
            this.cbo_Phongthi.SelectedIndexChanged += new System.EventHandler(this.cbo_Phongthi_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.gview_Khode);
            this.groupBox1.Controls.Add(this.gbox_Dethi);
            this.groupBox1.Location = new System.Drawing.Point(-1, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(951, 427);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đề";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.gview_Dethi);
            this.groupBox3.Location = new System.Drawing.Point(6, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 229);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Số lượng đề";
            // 
            // gview_Dethi
            // 
            this.gview_Dethi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gview_Dethi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gview_Dethi.Location = new System.Drawing.Point(3, 21);
            this.gview_Dethi.Name = "gview_Dethi";
            this.gview_Dethi.RowHeadersWidth = 51;
            this.gview_Dethi.RowTemplate.Height = 24;
            this.gview_Dethi.Size = new System.Drawing.Size(410, 202);
            this.gview_Dethi.TabIndex = 2;
            // 
            // gview_Khode
            // 
            this.gview_Khode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gview_Khode.Location = new System.Drawing.Point(13, 21);
            this.gview_Khode.Name = "gview_Khode";
            this.gview_Khode.RowHeadersWidth = 51;
            this.gview_Khode.RowTemplate.Height = 24;
            this.gview_Khode.Size = new System.Drawing.Size(410, 165);
            this.gview_Khode.TabIndex = 1;
            this.gview_Khode.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gview_Khode_CellClick);
            // 
            // gbox_Dethi
            // 
            this.gbox_Dethi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbox_Dethi.Location = new System.Drawing.Point(429, 21);
            this.gbox_Dethi.Name = "gbox_Dethi";
            this.gbox_Dethi.Size = new System.Drawing.Size(517, 400);
            this.gbox_Dethi.TabIndex = 0;
            this.gbox_Dethi.TabStop = false;
            this.gbox_Dethi.Text = "Đề thi";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(632, 16);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 40);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(713, 16);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 40);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // frmThemDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 492);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbo_Phongthi);
            this.Controls.Add(this.label1);
            this.Name = "frmThemDeThi";
            this.Text = "frmThemDeThi";
            this.Load += new System.EventHandler(this.frmThemDeThi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gview_Dethi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gview_Khode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_Phongthi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gview_Dethi;
        private System.Windows.Forms.DataGridView gview_Khode;
        private System.Windows.Forms.GroupBox gbox_Dethi;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
    }
}