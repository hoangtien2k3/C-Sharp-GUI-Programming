namespace QuanLyTaiKhoanNganHang
{
    partial class FormRutTien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRutTien));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbTenTaiKhoan = new System.Windows.Forms.ComboBox();
            this.cbbSoTaiKhoan = new System.Windows.Forms.ComboBox();
            this.btnKiemTra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SoDuTaiKhoanGV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbSoTienCanRut = new System.Windows.Forms.ComboBox();
            this.lblDataTimeNow = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRutTien = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSoTienChuSo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtSoTienHienTai = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.txtSoTienDaRut = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SoDuTaiKhoanGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTenTaiKhoan);
            this.groupBox1.Controls.Add(this.cbbSoTaiKhoan);
            this.groupBox1.Controls.Add(this.btnKiemTra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(440, 201);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm tài khoản";
            // 
            // cbbTenTaiKhoan
            // 
            this.cbbTenTaiKhoan.FormattingEnabled = true;
            this.cbbTenTaiKhoan.Location = new System.Drawing.Point(169, 82);
            this.cbbTenTaiKhoan.Name = "cbbTenTaiKhoan";
            this.cbbTenTaiKhoan.Size = new System.Drawing.Size(199, 21);
            this.cbbTenTaiKhoan.TabIndex = 28;
            // 
            // cbbSoTaiKhoan
            // 
            this.cbbSoTaiKhoan.FormattingEnabled = true;
            this.cbbSoTaiKhoan.Location = new System.Drawing.Point(169, 48);
            this.cbbSoTaiKhoan.Name = "cbbSoTaiKhoan";
            this.cbbSoTaiKhoan.Size = new System.Drawing.Size(199, 21);
            this.cbbSoTaiKhoan.TabIndex = 27;
            // 
            // btnKiemTra
            // 
            this.btnKiemTra.Location = new System.Drawing.Point(134, 138);
            this.btnKiemTra.Name = "btnKiemTra";
            this.btnKiemTra.Size = new System.Drawing.Size(93, 33);
            this.btnKiemTra.TabIndex = 26;
            this.btnKiemTra.Text = "Kiểm Tra";
            this.btnKiemTra.UseVisualStyleBackColor = true;
            this.btnKiemTra.Click += new System.EventHandler(this.btnKiemTra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số tài khoản";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SoDuTaiKhoanGV);
            this.groupBox3.Location = new System.Drawing.Point(21, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(440, 201);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách ";
            // 
            // SoDuTaiKhoanGV
            // 
            this.SoDuTaiKhoanGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SoDuTaiKhoanGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoDuTaiKhoanGV.Location = new System.Drawing.Point(0, 29);
            this.SoDuTaiKhoanGV.Name = "SoDuTaiKhoanGV";
            this.SoDuTaiKhoanGV.Size = new System.Drawing.Size(440, 172);
            this.SoDuTaiKhoanGV.TabIndex = 0;
            this.SoDuTaiKhoanGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SoDuTaiKhoanGV_CellContentClick);
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
            this.panel1.TabIndex = 79;
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
            this.label2.Size = new System.Drawing.Size(367, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rút Tiền - Trong Tài Khoản";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(375, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Số Tiền Cần Rút";
            // 
            // cbbSoTienCanRut
            // 
            this.cbbSoTienCanRut.FormattingEnabled = true;
            this.cbbSoTienCanRut.Location = new System.Drawing.Point(159, 48);
            this.cbbSoTienCanRut.Name = "cbbSoTienCanRut";
            this.cbbSoTienCanRut.Size = new System.Drawing.Size(199, 21);
            this.cbbSoTienCanRut.TabIndex = 82;
            // 
            // lblDataTimeNow
            // 
            this.lblDataTimeNow.AutoSize = true;
            this.lblDataTimeNow.BackColor = System.Drawing.SystemColors.Control;
            this.lblDataTimeNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataTimeNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDataTimeNow.Location = new System.Drawing.Point(156, 105);
            this.lblDataTimeNow.Name = "lblDataTimeNow";
            this.lblDataTimeNow.Size = new System.Drawing.Size(115, 16);
            this.lblDataTimeNow.TabIndex = 115;
            this.lblDataTimeNow.Text = "day/month/year";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRutTien);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblDataTimeNow);
            this.groupBox2.Controls.Add(this.cbbSoTienCanRut);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Location = new System.Drawing.Point(484, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 201);
            this.groupBox2.TabIndex = 116;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rút Tiền ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 116;
            this.label6.Text = "Ngày - Giờ:";
            // 
            // btnRutTien
            // 
            this.btnRutTien.Location = new System.Drawing.Point(125, 153);
            this.btnRutTien.Name = "btnRutTien";
            this.btnRutTien.Size = new System.Drawing.Size(109, 33);
            this.btnRutTien.TabIndex = 117;
            this.btnRutTien.Text = "Rút Tiền";
            this.btnRutTien.UseVisualStyleBackColor = true;
            this.btnRutTien.Click += new System.EventHandler(this.btnRutTien_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.txtSoTienDaRut);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.txtTenTaiKhoan);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.txtSoTienHienTai);
            this.groupBox4.Controls.Add(this.txtSoTienChuSo);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Location = new System.Drawing.Point(484, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(528, 201);
            this.groupBox4.TabIndex = 117;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Ghi Chú";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 15);
            this.label11.TabIndex = 123;
            this.label11.Text = "Số Tiền Chữ Số:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(161, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(319, 2);
            this.button2.TabIndex = 122;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtSoTienChuSo
            // 
            this.txtSoTienChuSo.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoTienChuSo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoTienChuSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienChuSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSoTienChuSo.Location = new System.Drawing.Point(161, 114);
            this.txtSoTienChuSo.Name = "txtSoTienChuSo";
            this.txtSoTienChuSo.Size = new System.Drawing.Size(319, 15);
            this.txtSoTienChuSo.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 118;
            this.label7.Text = "Số dư hiện tại:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Blue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(161, 87);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(319, 2);
            this.button5.TabIndex = 120;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // txtSoTienHienTai
            // 
            this.txtSoTienHienTai.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoTienHienTai.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoTienHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienHienTai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSoTienHienTai.Location = new System.Drawing.Point(161, 71);
            this.txtSoTienHienTai.Name = "txtSoTienHienTai";
            this.txtSoTienHienTai.Size = new System.Drawing.Size(319, 15);
            this.txtSoTienHienTai.TabIndex = 119;
            this.txtSoTienHienTai.Text = "0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 15);
            this.label8.TabIndex = 124;
            this.label8.Text = "Số tiền đã rút:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(161, 171);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(319, 2);
            this.button3.TabIndex = 126;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // txtSoTienDaRut
            // 
            this.txtSoTienDaRut.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoTienDaRut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoTienDaRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienDaRut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtSoTienDaRut.Location = new System.Drawing.Point(161, 156);
            this.txtSoTienDaRut.Name = "txtSoTienDaRut";
            this.txtSoTienDaRut.Size = new System.Drawing.Size(319, 15);
            this.txtSoTienDaRut.TabIndex = 125;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(161, 46);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(319, 2);
            this.button4.TabIndex = 31;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.BackColor = System.Drawing.SystemColors.Control;
            this.txtTenTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(161, 32);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(319, 15);
            this.txtTenTaiKhoan.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(33, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tên tài khoản:";
            // 
            // FormRutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 500);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRutTien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRutTien";
            this.Load += new System.EventHandler(this.FormRutTien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SoDuTaiKhoanGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbTenTaiKhoan;
        private System.Windows.Forms.ComboBox cbbSoTaiKhoan;
        private System.Windows.Forms.Button btnKiemTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView SoDuTaiKhoanGV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbSoTienCanRut;
        private System.Windows.Forms.Label lblDataTimeNow;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRutTien;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtSoTienHienTai;
        private System.Windows.Forms.TextBox txtSoTienChuSo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtSoTienDaRut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label label4;
    }
}