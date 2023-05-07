namespace Bai2
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.rdoThu = new System.Windows.Forms.RadioButton();
            this.rdoChi = new System.Windows.Forms.RadioButton();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.listBoxThu = new System.Windows.Forms.ListBox();
            this.listBoxChi = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxThu = new System.Windows.Forms.CheckBox();
            this.checkBoxChi = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongThuTien = new System.Windows.Forms.TextBox();
            this.btnKetQua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "NGÔN NGỮ LẬP TRÌNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập liệu:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(57, 180);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 25);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(57, 294);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 27);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // rdoThu
            // 
            this.rdoThu.AutoSize = true;
            this.rdoThu.Location = new System.Drawing.Point(193, 123);
            this.rdoThu.Name = "rdoThu";
            this.rdoThu.Size = new System.Drawing.Size(44, 17);
            this.rdoThu.TabIndex = 4;
            this.rdoThu.TabStop = true;
            this.rdoThu.Text = "Thu";
            this.rdoThu.UseVisualStyleBackColor = true;
            // 
            // rdoChi
            // 
            this.rdoChi.AutoSize = true;
            this.rdoChi.Location = new System.Drawing.Point(285, 123);
            this.rdoChi.Name = "rdoChi";
            this.rdoChi.Size = new System.Drawing.Size(40, 17);
            this.rdoChi.TabIndex = 5;
            this.rdoChi.TabStop = true;
            this.rdoChi.Text = "Chi";
            this.rdoChi.UseVisualStyleBackColor = true;
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(57, 120);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(100, 20);
            this.txtNhap.TabIndex = 6;
            // 
            // listBoxThu
            // 
            this.listBoxThu.FormattingEnabled = true;
            this.listBoxThu.Items.AddRange(new object[] {
            "150000",
            "350000",
            "420000",
            "750000"});
            this.listBoxThu.Location = new System.Drawing.Point(193, 174);
            this.listBoxThu.Name = "listBoxThu";
            this.listBoxThu.Size = new System.Drawing.Size(101, 147);
            this.listBoxThu.TabIndex = 7;
            // 
            // listBoxChi
            // 
            this.listBoxChi.FormattingEnabled = true;
            this.listBoxChi.Items.AddRange(new object[] {
            "123000",
            "231000",
            "538000",
            "635000",
            "36000"});
            this.listBoxChi.Location = new System.Drawing.Point(330, 174);
            this.listBoxChi.Name = "listBoxChi";
            this.listBoxChi.Size = new System.Drawing.Size(98, 147);
            this.listBoxChi.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Yêu Cầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tính tiền:";
            // 
            // checkBoxThu
            // 
            this.checkBoxThu.AutoSize = true;
            this.checkBoxThu.Location = new System.Drawing.Point(571, 120);
            this.checkBoxThu.Name = "checkBoxThu";
            this.checkBoxThu.Size = new System.Drawing.Size(45, 17);
            this.checkBoxThu.TabIndex = 11;
            this.checkBoxThu.Text = "Thu";
            this.checkBoxThu.UseVisualStyleBackColor = true;
            // 
            // checkBoxChi
            // 
            this.checkBoxChi.AutoSize = true;
            this.checkBoxChi.Location = new System.Drawing.Point(636, 120);
            this.checkBoxChi.Name = "checkBoxChi";
            this.checkBoxChi.Size = new System.Drawing.Size(41, 17);
            this.checkBoxChi.TabIndex = 12;
            this.checkBoxChi.Text = "Chi";
            this.checkBoxChi.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kết quả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tổng Thu Tiền:";
            // 
            // txtTongThuTien
            // 
            this.txtTongThuTien.Location = new System.Drawing.Point(606, 243);
            this.txtTongThuTien.Name = "txtTongThuTien";
            this.txtTongThuTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongThuTien.TabIndex = 15;
            // 
            // btnKetQua
            // 
            this.btnKetQua.Location = new System.Drawing.Point(574, 314);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(75, 23);
            this.btnKetQua.TabIndex = 16;
            this.btnKetQua.Text = "Kêt quả";
            this.btnKetQua.UseVisualStyleBackColor = true;
            this.btnKetQua.Click += new System.EventHandler(this.btnKetQua_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 368);
            this.Controls.Add(this.btnKetQua);
            this.Controls.Add(this.txtTongThuTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxChi);
            this.Controls.Add(this.checkBoxThu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxChi);
            this.Controls.Add(this.listBoxThu);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.rdoChi);
            this.Controls.Add(this.rdoThu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bài 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.RadioButton rdoThu;
        private System.Windows.Forms.RadioButton rdoChi;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.ListBox listBoxThu;
        private System.Windows.Forms.ListBox listBoxChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxThu;
        private System.Windows.Forms.CheckBox checkBoxChi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongThuTien;
        private System.Windows.Forms.Button btnKetQua;
    }
}

