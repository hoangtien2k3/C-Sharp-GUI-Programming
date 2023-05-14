namespace QuanLyBenhNhanNoiTru
{
    partial class FormBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBaoCao));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbbMaBN = new System.Windows.Forms.ComboBox();
            this.cbbTenBN = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChiPhiDichVuGV = new System.Windows.Forms.DataGridView();
            this.label18 = new System.Windows.Forms.Label();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.btnVienPhi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dv6 = new System.Windows.Forms.CheckBox();
            this.dv5 = new System.Windows.Forms.CheckBox();
            this.dv4 = new System.Windows.Forms.CheckBox();
            this.dv3 = new System.Windows.Forms.CheckBox();
            this.dv2 = new System.Windows.Forms.CheckBox();
            this.dv1 = new System.Windows.Forms.CheckBox();
            this.cbbTienTamUng = new System.Windows.Forms.ComboBox();
            this.cbbTienPhatSinh = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLuuThongTin = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChiPhiDichVuGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bệnh Viện Đa Khoa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Bệnh Nhân:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tên Bệnh Nhân:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(50, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tiền Tạm Ứng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(50, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tiền Phát Sinh:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label11.Location = new System.Drawing.Point(374, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 31);
            this.label11.TabIndex = 10;
            this.label11.Text = "Thống Kê Viện Phí";
            // 
            // cbbMaBN
            // 
            this.cbbMaBN.FormattingEnabled = true;
            this.cbbMaBN.Location = new System.Drawing.Point(185, 95);
            this.cbbMaBN.Name = "cbbMaBN";
            this.cbbMaBN.Size = new System.Drawing.Size(205, 21);
            this.cbbMaBN.TabIndex = 12;
            // 
            // cbbTenBN
            // 
            this.cbbTenBN.FormattingEnabled = true;
            this.cbbTenBN.Location = new System.Drawing.Point(185, 134);
            this.cbbTenBN.Name = "cbbTenBN";
            this.cbbTenBN.Size = new System.Drawing.Size(205, 21);
            this.cbbTenBN.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChiPhiDichVuGV);
            this.groupBox2.Location = new System.Drawing.Point(53, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 172);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi phí dịch vụ";
            // 
            // ChiPhiDichVuGV
            // 
            this.ChiPhiDichVuGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ChiPhiDichVuGV.BackgroundColor = System.Drawing.Color.White;
            this.ChiPhiDichVuGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ChiPhiDichVuGV.Location = new System.Drawing.Point(0, 19);
            this.ChiPhiDichVuGV.Name = "ChiPhiDichVuGV";
            this.ChiPhiDichVuGV.Size = new System.Drawing.Size(643, 150);
            this.ChiPhiDichVuGV.TabIndex = 0;
            this.ChiPhiDichVuGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChiPhiDichVuGV_CellClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(752, 407);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Ngày Lập Phiếu";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(755, 332);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(40, 42);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox12.TabIndex = 85;
            this.pictureBox12.TabStop = false;
            // 
            // btnVienPhi
            // 
            this.btnVienPhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnVienPhi.FlatAppearance.BorderSize = 0;
            this.btnVienPhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVienPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVienPhi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnVienPhi.Location = new System.Drawing.Point(755, 332);
            this.btnVienPhi.Name = "btnVienPhi";
            this.btnVienPhi.Size = new System.Drawing.Size(132, 42);
            this.btnVienPhi.TabIndex = 84;
            this.btnVienPhi.Text = "Xuất TT VP";
            this.btnVienPhi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVienPhi.UseVisualStyleBackColor = false;
            this.btnVienPhi.Click += new System.EventHandler(this.btnVienPhi_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dv6);
            this.groupBox1.Controls.Add(this.dv5);
            this.groupBox1.Controls.Add(this.dv4);
            this.groupBox1.Controls.Add(this.dv3);
            this.groupBox1.Controls.Add(this.dv2);
            this.groupBox1.Controls.Add(this.dv1);
            this.groupBox1.Location = new System.Drawing.Point(549, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 187);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch Vụ Khám Chữa Bệnh";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(237, 156);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 15);
            this.label22.TabIndex = 11;
            this.label22.Text = "1.200.000 (VND)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(237, 133);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(113, 15);
            this.label21.TabIndex = 10;
            this.label21.Text = "2.000.000 (VND)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(237, 110);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 15);
            this.label20.TabIndex = 9;
            this.label20.Text = "800.000 (VND)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(237, 87);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 15);
            this.label19.TabIndex = 8;
            this.label19.Text = "700.000 (VND)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(237, 58);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 15);
            this.label13.TabIndex = 7;
            this.label13.Text = "350.000 (VND)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(237, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "780.000 (VND)";
            // 
            // dv6
            // 
            this.dv6.AutoSize = true;
            this.dv6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dv6.Location = new System.Drawing.Point(19, 156);
            this.dv6.Name = "dv6";
            this.dv6.Size = new System.Drawing.Size(159, 20);
            this.dv6.TabIndex = 5;
            this.dv6.Text = "Phục hồi chức năng";
            this.dv6.UseVisualStyleBackColor = true;
            // 
            // dv5
            // 
            this.dv5.AutoSize = true;
            this.dv5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dv5.Location = new System.Drawing.Point(19, 133);
            this.dv5.Name = "dv5";
            this.dv5.Size = new System.Drawing.Size(169, 20);
            this.dv5.TabIndex = 4;
            this.dv5.Text = "Chăm sóc phẫu thuật";
            this.dv5.UseVisualStyleBackColor = true;
            // 
            // dv4
            // 
            this.dv4.AutoSize = true;
            this.dv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dv4.Location = new System.Drawing.Point(19, 106);
            this.dv4.Name = "dv4";
            this.dv4.Size = new System.Drawing.Size(165, 20);
            this.dv4.TabIndex = 3;
            this.dv4.Text = "Tâm lý, hỗ trợ tư vấn";
            this.dv4.UseVisualStyleBackColor = true;
            // 
            // dv3
            // 
            this.dv3.AutoSize = true;
            this.dv3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dv3.Location = new System.Drawing.Point(19, 80);
            this.dv3.Name = "dv3";
            this.dv3.Size = new System.Drawing.Size(128, 20);
            this.dv3.TabIndex = 2;
            this.dv3.Text = "Dịch vụ điều trị";
            this.dv3.UseVisualStyleBackColor = true;
            // 
            // dv2
            // 
            this.dv2.AutoSize = true;
            this.dv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dv2.Location = new System.Drawing.Point(19, 54);
            this.dv2.Name = "dv2";
            this.dv2.Size = new System.Drawing.Size(164, 20);
            this.dv2.TabIndex = 1;
            this.dv2.Text = "Kiểm tra, xét nghiệm";
            this.dv2.UseVisualStyleBackColor = true;
            // 
            // dv1
            // 
            this.dv1.AutoSize = true;
            this.dv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dv1.Location = new System.Drawing.Point(19, 28);
            this.dv1.Name = "dv1";
            this.dv1.Size = new System.Drawing.Size(132, 20);
            this.dv1.TabIndex = 0;
            this.dv1.Text = "Khám tổng quát";
            this.dv1.UseVisualStyleBackColor = true;
            // 
            // cbbTienTamUng
            // 
            this.cbbTienTamUng.FormattingEnabled = true;
            this.cbbTienTamUng.Items.AddRange(new object[] {
            "500.000"});
            this.cbbTienTamUng.Location = new System.Drawing.Point(185, 173);
            this.cbbTienTamUng.Name = "cbbTienTamUng";
            this.cbbTienTamUng.Size = new System.Drawing.Size(131, 21);
            this.cbbTienTamUng.TabIndex = 87;
            // 
            // cbbTienPhatSinh
            // 
            this.cbbTienPhatSinh.FormattingEnabled = true;
            this.cbbTienPhatSinh.Items.AddRange(new object[] {
            "30.000"});
            this.cbbTienPhatSinh.Location = new System.Drawing.Point(185, 210);
            this.cbbTienPhatSinh.Name = "cbbTienPhatSinh";
            this.cbbTienPhatSinh.Size = new System.Drawing.Size(131, 21);
            this.cbbTienPhatSinh.TabIndex = 88;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(371, 249);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 94;
            this.pictureBox2.TabStop = false;
            // 
            // btnLuuThongTin
            // 
            this.btnLuuThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLuuThongTin.FlatAppearance.BorderSize = 0;
            this.btnLuuThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuuThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLuuThongTin.Location = new System.Drawing.Point(371, 249);
            this.btnLuuThongTin.Name = "btnLuuThongTin";
            this.btnLuuThongTin.Size = new System.Drawing.Size(135, 42);
            this.btnLuuThongTin.TabIndex = 93;
            this.btnLuuThongTin.Text = "Lưu Viện Phí";
            this.btnLuuThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuuThongTin.UseVisualStyleBackColor = false;
            this.btnLuuThongTin.Click += new System.EventHandler(this.btnLuuThongTin_Click);
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 500);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLuuThongTin);
            this.Controls.Add(this.cbbTienPhatSinh);
            this.Controls.Add(this.cbbTienTamUng);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.btnVienPhi);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cbbTenBN);
            this.Controls.Add(this.cbbMaBN);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBaoCao";
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChiPhiDichVuGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbbMaBN;
        private System.Windows.Forms.ComboBox cbbTenBN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Button btnVienPhi;
        private System.Windows.Forms.DataGridView ChiPhiDichVuGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox dv6;
        private System.Windows.Forms.CheckBox dv5;
        private System.Windows.Forms.CheckBox dv4;
        private System.Windows.Forms.CheckBox dv3;
        private System.Windows.Forms.CheckBox dv2;
        private System.Windows.Forms.CheckBox dv1;
        private System.Windows.Forms.ComboBox cbbTienTamUng;
        private System.Windows.Forms.ComboBox cbbTienPhatSinh;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLuuThongTin;
    }
}