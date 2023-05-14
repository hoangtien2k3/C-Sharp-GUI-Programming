namespace QuanLyBenhNhanNoiTru
{
    partial class Form_ShowNhapVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ShowNhapVien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grv_NhapVien = new System.Windows.Forms.DataGridView();
            this.cbbMaBN = new System.Windows.Forms.ComboBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTrieuChungThem = new System.Windows.Forms.TextBox();
            this.txtHuongDieuTri = new System.Windows.Forms.TextBox();
            this.cbbChuanDoanSoBo = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grv_NhapVien)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 66);
            this.panel1.TabIndex = 18;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1385, 4);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(406, 9);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(558, 39);
            this.label25.TabIndex = 1;
            this.label25.Text = "Danh Sách Bệnh Nhân Nhập viện";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Grv_NhapVien);
            this.groupBox1.Location = new System.Drawing.Point(9, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(638, 390);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // Grv_NhapVien
            // 
            this.Grv_NhapVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grv_NhapVien.Location = new System.Drawing.Point(13, 21);
            this.Grv_NhapVien.Name = "Grv_NhapVien";
            this.Grv_NhapVien.RowHeadersWidth = 51;
            this.Grv_NhapVien.RowTemplate.Height = 24;
            this.Grv_NhapVien.Size = new System.Drawing.Size(597, 355);
            this.Grv_NhapVien.TabIndex = 0;
            this.Grv_NhapVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grv_NhapVien_CellClick);
            this.Grv_NhapVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grv_NhapVien_CellContentClick);
            // 
            // cbbMaBN
            // 
            this.cbbMaBN.FormattingEnabled = true;
            this.cbbMaBN.Location = new System.Drawing.Point(144, 127);
            this.cbbMaBN.Name = "cbbMaBN";
            this.cbbMaBN.Size = new System.Drawing.Size(475, 24);
            this.cbbMaBN.TabIndex = 25;
            // 
            // btnTim
            // 
            this.btnTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnTim.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTim.ForeColor = System.Drawing.Color.White;
            this.btnTim.Location = new System.Drawing.Point(22, 117);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(116, 42);
            this.btnTim.TabIndex = 24;
            this.btnTim.Text = "Tìm Bênh Nhân";
            this.btnTim.UseVisualStyleBackColor = false;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnXoa);
            this.groupBox4.Controls.Add(this.btnSua);
            this.groupBox4.Controls.Add(this.txtTrieuChungThem);
            this.groupBox4.Controls.Add(this.txtHuongDieuTri);
            this.groupBox4.Controls.Add(this.cbbChuanDoanSoBo);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.ForeColor = System.Drawing.Color.Red;
            this.groupBox4.Location = new System.Drawing.Point(696, 117);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(628, 438);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chuẩn đoán và hướng điều trị";
            // 
            // txtTrieuChungThem
            // 
            this.txtTrieuChungThem.Location = new System.Drawing.Point(168, 88);
            this.txtTrieuChungThem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTrieuChungThem.Name = "txtTrieuChungThem";
            this.txtTrieuChungThem.Size = new System.Drawing.Size(371, 22);
            this.txtTrieuChungThem.TabIndex = 19;
            // 
            // txtHuongDieuTri
            // 
            this.txtHuongDieuTri.Location = new System.Drawing.Point(168, 133);
            this.txtHuongDieuTri.Margin = new System.Windows.Forms.Padding(4);
            this.txtHuongDieuTri.Name = "txtHuongDieuTri";
            this.txtHuongDieuTri.Size = new System.Drawing.Size(371, 22);
            this.txtHuongDieuTri.TabIndex = 18;
            // 
            // cbbChuanDoanSoBo
            // 
            this.cbbChuanDoanSoBo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbChuanDoanSoBo.FormattingEnabled = true;
            this.cbbChuanDoanSoBo.Items.AddRange(new object[] {
            "Cảm lạnh",
            "Viêm họng",
            "Đau bụng",
            "Viêm xoang",
            "Viêm đường tiết niệu",
            "Viêm phổi",
            "Đau đầu",
            "Đau dạ dày",
            "Bệnh tiểu đường",
            "Viêm khớp",
            "Sỏi thận",
            "Bệnh tim mạch"});
            this.cbbChuanDoanSoBo.Location = new System.Drawing.Point(168, 43);
            this.cbbChuanDoanSoBo.Margin = new System.Windows.Forms.Padding(4);
            this.cbbChuanDoanSoBo.Name = "cbbChuanDoanSoBo";
            this.cbbChuanDoanSoBo.Size = new System.Drawing.Size(371, 24);
            this.cbbChuanDoanSoBo.TabIndex = 3;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(17, 139);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 16);
            this.label24.TabIndex = 2;
            this.label24.Text = "Hướng điều trị";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 91);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(117, 16);
            this.label23.TabIndex = 1;
            this.label23.Text = "Triệu Chứng Thêm";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 47);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "Chuẩn đoán sơ bộ";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(168, 221);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(116, 42);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa TT Bênh Nhân";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(302, 221);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(116, 42);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa TT Bênh Nhân";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form_ShowNhapVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1355, 568);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.cbbMaBN);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_ShowNhapVien";
            this.Text = "Bệnh Nhân Nhập viện";
            this.Load += new System.EventHandler(this.Form_ShowNhapVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grv_NhapVien)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Grv_NhapVien;
        private System.Windows.Forms.ComboBox cbbMaBN;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTrieuChungThem;
        private System.Windows.Forms.TextBox txtHuongDieuTri;
        private System.Windows.Forms.ComboBox cbbChuanDoanSoBo;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
    }
}