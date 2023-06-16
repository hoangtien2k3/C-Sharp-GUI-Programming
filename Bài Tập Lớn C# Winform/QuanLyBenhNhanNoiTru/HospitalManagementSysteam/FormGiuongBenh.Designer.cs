namespace QuanLyBenhNhanNoiTru
{
    partial class FormGiuongBenh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiuongBenh));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGRVBenhNhan = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbSoGiuong = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonResert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSuaThongTin = new System.Windows.Forms.Button();
            this.txtChuyenKhoa = new System.Windows.Forms.TextBox();
            this.buttonXepGiuongBenh = new System.Windows.Forms.Button();
            this.cbbMaBN = new System.Windows.Forms.ComboBox();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbSoPhong = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnTimKiemGiuongBenh = new System.Windows.Forms.Button();
            this.txtTimGiuong = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGRVBenhNhan)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 54);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox3
            // 
            this.pictureBox3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.ErrorImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1039, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(395, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xếp Giường Bệnh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGRVBenhNhan);
            this.groupBox2.Location = new System.Drawing.Point(329, 111);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(701, 361);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách bệnh nhân";
            // 
            // dataGRVBenhNhan
            // 
            this.dataGRVBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGRVBenhNhan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGRVBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGRVBenhNhan.Location = new System.Drawing.Point(0, 28);
            this.dataGRVBenhNhan.Margin = new System.Windows.Forms.Padding(2);
            this.dataGRVBenhNhan.Name = "dataGRVBenhNhan";
            this.dataGRVBenhNhan.RowHeadersWidth = 51;
            this.dataGRVBenhNhan.RowTemplate.Height = 24;
            this.dataGRVBenhNhan.Size = new System.Drawing.Size(701, 333);
            this.dataGRVBenhNhan.TabIndex = 0;
            this.dataGRVBenhNhan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGRVBenhNhan_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTrangThai);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbbSoGiuong);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtMaBS);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.buttonResert);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnSuaThongTin);
            this.groupBox3.Controls.Add(this.txtChuyenKhoa);
            this.groupBox3.Controls.Add(this.buttonXepGiuongBenh);
            this.groupBox3.Controls.Add(this.cbbMaBN);
            this.groupBox3.Controls.Add(this.txtLoaiPhong);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbbSoPhong);
            this.groupBox3.Location = new System.Drawing.Point(0, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 419);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Giường Bệnh";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.ForeColor = System.Drawing.Color.Blue;
            this.txtTrangThai.Location = new System.Drawing.Point(128, 238);
            this.txtTrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(178, 20);
            this.txtTrangThai.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 13);
            this.label11.TabIndex = 61;
            this.label11.Text = "Trạng Thái Giường";
            // 
            // cbbSoGiuong
            // 
            this.cbbSoGiuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoGiuong.FormattingEnabled = true;
            this.cbbSoGiuong.Location = new System.Drawing.Point(128, 199);
            this.cbbSoGiuong.Name = "cbbSoGiuong";
            this.cbbSoGiuong.Size = new System.Drawing.Size(178, 21);
            this.cbbSoGiuong.TabIndex = 60;
            this.cbbSoGiuong.SelectedIndexChanged += new System.EventHandler(this.cbbSoGiuong_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 204);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Số Giường";
            // 
            // txtMaBS
            // 
            this.txtMaBS.Enabled = false;
            this.txtMaBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBS.ForeColor = System.Drawing.Color.Blue;
            this.txtMaBS.Location = new System.Drawing.Point(128, 89);
            this.txtMaBS.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(178, 20);
            this.txtMaBS.TabIndex = 51;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cyan;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(163, 349);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 36);
            this.button4.TabIndex = 58;
            this.button4.Text = "Xuất Excel";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 50;
            // 
            // buttonResert
            // 
            this.buttonResert.BackColor = System.Drawing.Color.Cyan;
            this.buttonResert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonResert.Location = new System.Drawing.Point(31, 349);
            this.buttonResert.Margin = new System.Windows.Forms.Padding(2);
            this.buttonResert.Name = "buttonResert";
            this.buttonResert.Size = new System.Drawing.Size(111, 36);
            this.buttonResert.TabIndex = 57;
            this.buttonResert.Text = "Reset";
            this.buttonResert.UseVisualStyleBackColor = false;
            this.buttonResert.Click += new System.EventHandler(this.buttonResert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "MaBS Phụ Trách";
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.BackColor = System.Drawing.Color.Cyan;
            this.btnSuaThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSuaThongTin.Location = new System.Drawing.Point(163, 293);
            this.btnSuaThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(111, 37);
            this.btnSuaThongTin.TabIndex = 56;
            this.btnSuaThongTin.Text = "Sửa";
            this.btnSuaThongTin.UseVisualStyleBackColor = false;
            this.btnSuaThongTin.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // txtChuyenKhoa
            // 
            this.txtChuyenKhoa.Enabled = false;
            this.txtChuyenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChuyenKhoa.ForeColor = System.Drawing.Color.Blue;
            this.txtChuyenKhoa.Location = new System.Drawing.Point(128, 50);
            this.txtChuyenKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtChuyenKhoa.Name = "txtChuyenKhoa";
            this.txtChuyenKhoa.Size = new System.Drawing.Size(178, 20);
            this.txtChuyenKhoa.TabIndex = 48;
            this.txtChuyenKhoa.TextChanged += new System.EventHandler(this.txtChuyenKhoa_TextChanged);
            // 
            // buttonXepGiuongBenh
            // 
            this.buttonXepGiuongBenh.BackColor = System.Drawing.Color.Cyan;
            this.buttonXepGiuongBenh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXepGiuongBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXepGiuongBenh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonXepGiuongBenh.Location = new System.Drawing.Point(31, 293);
            this.buttonXepGiuongBenh.Margin = new System.Windows.Forms.Padding(2);
            this.buttonXepGiuongBenh.Name = "buttonXepGiuongBenh";
            this.buttonXepGiuongBenh.Size = new System.Drawing.Size(111, 37);
            this.buttonXepGiuongBenh.TabIndex = 55;
            this.buttonXepGiuongBenh.Text = "Xếp Giường";
            this.buttonXepGiuongBenh.UseVisualStyleBackColor = false;
            this.buttonXepGiuongBenh.Click += new System.EventHandler(this.buttonXepGiuongBenh_Click);
            // 
            // cbbMaBN
            // 
            this.cbbMaBN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaBN.FormattingEnabled = true;
            this.cbbMaBN.Location = new System.Drawing.Point(128, 21);
            this.cbbMaBN.Name = "cbbMaBN";
            this.cbbMaBN.Size = new System.Drawing.Size(178, 21);
            this.cbbMaBN.TabIndex = 46;
            this.cbbMaBN.SelectedIndexChanged += new System.EventHandler(this.cbbMaBN_SelectedIndexChanged);
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Enabled = false;
            this.txtLoaiPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiPhong.ForeColor = System.Drawing.Color.Blue;
            this.txtLoaiPhong.Location = new System.Drawing.Point(128, 162);
            this.txtLoaiPhong.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(178, 20);
            this.txtLoaiPhong.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Chuyên Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Mã BN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 52;
            this.label8.Text = "Loại Phòng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Số Phòng";
            // 
            // cbbSoPhong
            // 
            this.cbbSoPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSoPhong.FormattingEnabled = true;
            this.cbbSoPhong.Location = new System.Drawing.Point(128, 126);
            this.cbbSoPhong.Name = "cbbSoPhong";
            this.cbbSoPhong.Size = new System.Drawing.Size(178, 21);
            this.cbbSoPhong.TabIndex = 27;
            this.cbbSoPhong.SelectedIndexChanged += new System.EventHandler(this.cbbSoPhong_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(592, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Tìm Giường Bệnh:";
            // 
            // btnTimKiemGiuongBenh
            // 
            this.btnTimKiemGiuongBenh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiemGiuongBenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemGiuongBenh.ForeColor = System.Drawing.Color.Blue;
            this.btnTimKiemGiuongBenh.Location = new System.Drawing.Point(902, 72);
            this.btnTimKiemGiuongBenh.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiemGiuongBenh.Name = "btnTimKiemGiuongBenh";
            this.btnTimKiemGiuongBenh.Size = new System.Drawing.Size(101, 31);
            this.btnTimKiemGiuongBenh.TabIndex = 64;
            this.btnTimKiemGiuongBenh.Text = "Tìm Kiếm";
            this.btnTimKiemGiuongBenh.UseVisualStyleBackColor = true;
            this.btnTimKiemGiuongBenh.Click += new System.EventHandler(this.btnTimKiemGiuongBenh_Click);
            // 
            // txtTimGiuong
            // 
            this.txtTimGiuong.Location = new System.Drawing.Point(717, 78);
            this.txtTimGiuong.Name = "txtTimGiuong";
            this.txtTimGiuong.Size = new System.Drawing.Size(168, 20);
            this.txtTimGiuong.TabIndex = 65;
            // 
            // FormGiuongBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 500);
            this.Controls.Add(this.txtTimGiuong);
            this.Controls.Add(this.btnTimKiemGiuongBenh);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGiuongBenh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGiuongBenh";
            this.Load += new System.EventHandler(this.FormGiuongBenh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGRVBenhNhan)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGRVBenhNhan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTrangThai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbSoGiuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonResert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.TextBox txtChuyenKhoa;
        private System.Windows.Forms.Button buttonXepGiuongBenh;
        private System.Windows.Forms.ComboBox cbbMaBN;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbSoPhong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnTimKiemGiuongBenh;
        private System.Windows.Forms.TextBox txtTimGiuong;
    }
}