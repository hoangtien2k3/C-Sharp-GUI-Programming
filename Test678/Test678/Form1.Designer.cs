namespace Test678
{
    partial class Form1
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
            this.txtHoTenNhanVien = new System.Windows.Forms.TextBox();
            this.maskedTextBoxNgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbQueQuan = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbQuocTich = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên Nhân Viên: ";
            // 
            // txtHoTenNhanVien
            // 
            this.txtHoTenNhanVien.Location = new System.Drawing.Point(220, 34);
            this.txtHoTenNhanVien.Name = "txtHoTenNhanVien";
            this.txtHoTenNhanVien.Size = new System.Drawing.Size(244, 20);
            this.txtHoTenNhanVien.TabIndex = 1;
            // 
            // maskedTextBoxNgaySinh
            // 
            this.maskedTextBoxNgaySinh.Location = new System.Drawing.Point(220, 71);
            this.maskedTextBoxNgaySinh.Mask = "00/00/0000";
            this.maskedTextBoxNgaySinh.Name = "maskedTextBoxNgaySinh";
            this.maskedTextBoxNgaySinh.Size = new System.Drawing.Size(89, 20);
            this.maskedTextBoxNgaySinh.TabIndex = 2;
            this.maskedTextBoxNgaySinh.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(78, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày Sinh(mm/dd/yy)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(78, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa Chỉ: ";
            // 
            // cbbQueQuan
            // 
            this.cbbQueQuan.FormattingEnabled = true;
            this.cbbQueQuan.Items.AddRange(new object[] {
            "Thanh Hóa"});
            this.cbbQueQuan.Location = new System.Drawing.Point(220, 151);
            this.cbbQueQuan.Name = "cbbQueQuan";
            this.cbbQueQuan.Size = new System.Drawing.Size(173, 21);
            this.cbbQueQuan.TabIndex = 5;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(220, 114);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(244, 20);
            this.txtDiaChi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(78, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quê Quán: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(78, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quốc Tịch: ";
            // 
            // cbbQuocTich
            // 
            this.cbbQuocTich.FormattingEnabled = true;
            this.cbbQuocTich.Items.AddRange(new object[] {
            "Việt Nam"});
            this.cbbQuocTich.Location = new System.Drawing.Point(220, 191);
            this.cbbQuocTich.Name = "cbbQuocTich";
            this.cbbQuocTich.Size = new System.Drawing.Size(173, 21);
            this.cbbQuocTich.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(78, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Điện Thoại: ";
            // 
            // maskedTextBoxDienThoai
            // 
            this.maskedTextBoxDienThoai.Location = new System.Drawing.Point(220, 233);
            this.maskedTextBoxDienThoai.Mask = "(999) 000-0000";
            this.maskedTextBoxDienThoai.Name = "maskedTextBoxDienThoai";
            this.maskedTextBoxDienThoai.Size = new System.Drawing.Size(89, 20);
            this.maskedTextBoxDienThoai.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(220, 273);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(244, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(78, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Email: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(78, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ngày bắt đầu làm: ";
            // 
            // dateTimePickerNgayBatDau
            // 
            this.dateTimePickerNgayBatDau.Location = new System.Drawing.Point(220, 313);
            this.dateTimePickerNgayBatDau.Name = "dateTimePickerNgayBatDau";
            this.dateTimePickerNgayBatDau.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNgayBatDau.TabIndex = 15;
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(144, 381);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 16;
            this.btnDangKy.Text = "Đăng Ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(310, 381);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 442);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.dateTimePickerNgayBatDau);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBoxDienThoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbbQuocTich);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.cbbQueQuan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedTextBoxNgaySinh);
            this.Controls.Add(this.txtHoTenNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoTenNhanVien;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNgaySinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbQueQuan;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbQuocTich;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBatDau;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnThoat;
    }
}

