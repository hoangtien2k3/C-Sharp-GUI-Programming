namespace QuanLyTaiKhoanNganHang
{
    partial class FormGuiTien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuiTien));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSoTaiKhoan = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtSoTienHienTai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SoDuTaiKhoanGV = new System.Windows.Forms.DataGridView();
            this.ptbTaiAnh = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiaChiEmail = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbSoTaiKhoan = new System.Windows.Forms.ComboBox();
            this.cbbTenTaiKhoan = new System.Windows.Forms.ComboBox();
            this.btnGuiTien = new System.Windows.Forms.Button();
            this.txtSoTienMuonGui = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoDuTaiKhoanGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTaiAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 48);
            this.panel1.TabIndex = 72;
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(340, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gửi Tiền Vào Tài Khoản";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTenTaiKhoan);
            this.groupBox1.Controls.Add(this.cbbSoTaiKhoan);
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 153);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên tài khoản";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSoTienMuonGui);
            this.groupBox2.Controls.Add(this.btnGuiTien);
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.txtCCCD);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.txtDiaChiEmail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ptbTaiAnh);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.txtSoTienHienTai);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.txtSoTaiKhoan);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.txtTenTaiKhoan);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(29, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(961, 194);
            this.groupBox2.TabIndex = 74;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm tài khoản";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(291, 85);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 2);
            this.button3.TabIndex = 25;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(291, 71);
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(190, 13);
            this.txtSoTaiKhoan.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(291, 50);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 2);
            this.button4.TabIndex = 23;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BackColor = System.Drawing.SystemColors.Control;
            this.txtTenTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(291, 36);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(190, 13);
            this.txtTenTaiKhoan.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(188, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số tài khoản:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên tài khoản:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(552, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "Số dư hiện tại:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Blue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(691, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(190, 2);
            this.button5.TabIndex = 28;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // txtSoTienHienTai
            // 
            this.txtSoTienHienTai.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoTienHienTai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoTienHienTai.Location = new System.Drawing.Point(691, 42);
            this.txtSoTienHienTai.Name = "txtSoTienHienTai";
            this.txtSoTienHienTai.Size = new System.Drawing.Size(190, 13);
            this.txtSoTienHienTai.TabIndex = 27;
            this.txtSoTienHienTai.Text = "0000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(552, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Số tiền muốn gửi:";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(183, 115);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 26;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SoDuTaiKhoanGV);
            this.groupBox3.Location = new System.Drawing.Point(540, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(450, 201);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách ";
            // 
            // SoDuTaiKhoanGV
            // 
            this.SoDuTaiKhoanGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SoDuTaiKhoanGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoDuTaiKhoanGV.Location = new System.Drawing.Point(0, 29);
            this.SoDuTaiKhoanGV.Name = "SoDuTaiKhoanGV";
            this.SoDuTaiKhoanGV.Size = new System.Drawing.Size(450, 172);
            this.SoDuTaiKhoanGV.TabIndex = 0;
            // 
            // ptbTaiAnh
            // 
            this.ptbTaiAnh.BackColor = System.Drawing.Color.White;
            this.ptbTaiAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbTaiAnh.Location = new System.Drawing.Point(26, 28);
            this.ptbTaiAnh.Name = "ptbTaiAnh";
            this.ptbTaiAnh.Size = new System.Drawing.Size(121, 146);
            this.ptbTaiAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbTaiAnh.TabIndex = 76;
            this.ptbTaiAnh.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(188, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 77;
            this.label8.Text = "Địa chỉ Email";
            // 
            // txtDiaChiEmail
            // 
            this.txtDiaChiEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtDiaChiEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiaChiEmail.Location = new System.Drawing.Point(291, 105);
            this.txtDiaChiEmail.Name = "txtDiaChiEmail";
            this.txtDiaChiEmail.Size = new System.Drawing.Size(190, 13);
            this.txtDiaChiEmail.TabIndex = 78;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Blue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Blue;
            this.button8.Location = new System.Drawing.Point(291, 119);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(190, 2);
            this.button8.TabIndex = 79;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Blue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Blue;
            this.button9.Location = new System.Drawing.Point(291, 158);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(190, 2);
            this.button9.TabIndex = 82;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // txtCCCD
            // 
            this.txtCCCD.BackColor = System.Drawing.SystemColors.Control;
            this.txtCCCD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCCCD.Location = new System.Drawing.Point(291, 144);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(190, 13);
            this.txtCCCD.TabIndex = 81;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(188, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 15);
            this.label9.TabIndex = 80;
            this.label9.Text = "Số CCCD:";
            // 
            // cbbSoTaiKhoan
            // 
            this.cbbSoTaiKhoan.FormattingEnabled = true;
            this.cbbSoTaiKhoan.Location = new System.Drawing.Point(140, 43);
            this.cbbSoTaiKhoan.Name = "cbbSoTaiKhoan";
            this.cbbSoTaiKhoan.Size = new System.Drawing.Size(199, 21);
            this.cbbSoTaiKhoan.TabIndex = 27;
            // 
            // cbbTenTaiKhoan
            // 
            this.cbbTenTaiKhoan.FormattingEnabled = true;
            this.cbbTenTaiKhoan.Location = new System.Drawing.Point(140, 78);
            this.cbbTenTaiKhoan.Name = "cbbTenTaiKhoan";
            this.cbbTenTaiKhoan.Size = new System.Drawing.Size(199, 21);
            this.cbbTenTaiKhoan.TabIndex = 28;
            // 
            // btnGuiTien
            // 
            this.btnGuiTien.Location = new System.Drawing.Point(638, 132);
            this.btnGuiTien.Name = "btnGuiTien";
            this.btnGuiTien.Size = new System.Drawing.Size(124, 37);
            this.btnGuiTien.TabIndex = 83;
            this.btnGuiTien.Text = "Gửi Tiền";
            this.btnGuiTien.UseVisualStyleBackColor = true;
            this.btnGuiTien.Click += new System.EventHandler(this.btnGuiTien_Click);
            // 
            // txtSoTienMuonGui
            // 
            this.txtSoTienMuonGui.FormattingEnabled = true;
            this.txtSoTienMuonGui.Items.AddRange(new object[] {
            "10000000"});
            this.txtSoTienMuonGui.Location = new System.Drawing.Point(691, 79);
            this.txtSoTienMuonGui.Name = "txtSoTienMuonGui";
            this.txtSoTienMuonGui.Size = new System.Drawing.Size(190, 21);
            this.txtSoTienMuonGui.TabIndex = 29;
            // 
            // FormGuiTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 500);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGuiTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGuiTien";
            this.Load += new System.EventHandler(this.FormGuiTien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SoDuTaiKhoanGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTaiAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtSoTienHienTai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtSoTaiKhoan;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView SoDuTaiKhoanGV;
        private System.Windows.Forms.PictureBox ptbTaiAnh;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtDiaChiEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbTenTaiKhoan;
        private System.Windows.Forms.ComboBox cbbSoTaiKhoan;
        private System.Windows.Forms.Button btnGuiTien;
        private System.Windows.Forms.ComboBox txtSoTienMuonGui;
    }
}