namespace HospitalManagementSysteam
{
    partial class FormBacSi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBacSi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaBS = new System.Windows.Forms.TextBox();
            this.txtTenBS = new System.Windows.Forms.TextBox();
            this.txtKinhNghiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GrvBacSi = new System.Windows.Forms.DataGridView();
            this.MaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KinhNghiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChuyenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChuyenKhoa = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnSuaThongTin = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnThemThongTin = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnXoaThongTin = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvBacSi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1030, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(321, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(425, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁC SĨ TRỰC, QUẢN LÝ BỆNH NHÂN";
            // 
            // txtMaBS
            // 
            this.txtMaBS.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaBS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBS.Location = new System.Drawing.Point(133, 152);
            this.txtMaBS.Name = "txtMaBS";
            this.txtMaBS.Size = new System.Drawing.Size(190, 14);
            this.txtMaBS.TabIndex = 1;
            this.txtMaBS.TextChanged += new System.EventHandler(this.DoctorId_TextChanged);
            // 
            // txtTenBS
            // 
            this.txtTenBS.BackColor = System.Drawing.SystemColors.Control;
            this.txtTenBS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTenBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBS.Location = new System.Drawing.Point(133, 197);
            this.txtTenBS.Name = "txtTenBS";
            this.txtTenBS.Size = new System.Drawing.Size(190, 14);
            this.txtTenBS.TabIndex = 2;
            // 
            // txtKinhNghiem
            // 
            this.txtKinhNghiem.BackColor = System.Drawing.SystemColors.Control;
            this.txtKinhNghiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKinhNghiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKinhNghiem.Location = new System.Drawing.Point(132, 245);
            this.txtKinhNghiem.Name = "txtKinhNghiem";
            this.txtKinhNghiem.Size = new System.Drawing.Size(190, 14);
            this.txtKinhNghiem.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Bác Sĩ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên Bác Sĩ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kinh Nghiệm:";
            // 
            // GrvBacSi
            // 
            this.GrvBacSi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GrvBacSi.BackgroundColor = System.Drawing.Color.White;
            this.GrvBacSi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvBacSi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaBS,
            this.TenBS,
            this.KinhNghiem,
            this.ChuyenKhoa});
            this.GrvBacSi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GrvBacSi.Location = new System.Drawing.Point(6, 35);
            this.GrvBacSi.Name = "GrvBacSi";
            this.GrvBacSi.ReadOnly = true;
            this.GrvBacSi.RowHeadersWidth = 51;
            this.GrvBacSi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GrvBacSi.Size = new System.Drawing.Size(664, 336);
            this.GrvBacSi.TabIndex = 13;
            this.GrvBacSi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrvBacSi_CellClick);
            this.GrvBacSi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorGV_CellContentClick);
            // 
            // MaBS
            // 
            this.MaBS.DataPropertyName = "MaBS";
            this.MaBS.HeaderText = "MaBS";
            this.MaBS.MinimumWidth = 6;
            this.MaBS.Name = "MaBS";
            this.MaBS.ReadOnly = true;
            // 
            // TenBS
            // 
            this.TenBS.DataPropertyName = "TenBS";
            this.TenBS.HeaderText = "TenBS";
            this.TenBS.MinimumWidth = 6;
            this.TenBS.Name = "TenBS";
            this.TenBS.ReadOnly = true;
            // 
            // KinhNghiem
            // 
            this.KinhNghiem.DataPropertyName = "KinhNghiem";
            this.KinhNghiem.HeaderText = "KinhNghiem";
            this.KinhNghiem.MinimumWidth = 6;
            this.KinhNghiem.Name = "KinhNghiem";
            this.KinhNghiem.ReadOnly = true;
            // 
            // ChuyenKhoa
            // 
            this.ChuyenKhoa.DataPropertyName = "ChuyenKhoa";
            this.ChuyenKhoa.HeaderText = "ChuyenKhoa";
            this.ChuyenKhoa.MinimumWidth = 6;
            this.ChuyenKhoa.Name = "ChuyenKhoa";
            this.ChuyenKhoa.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Chuyên Khoa:";
            // 
            // cbChuyenKhoa
            // 
            this.cbChuyenKhoa.BackColor = System.Drawing.SystemColors.Control;
            this.cbChuyenKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbChuyenKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChuyenKhoa.FormattingEnabled = true;
            this.cbChuyenKhoa.Items.AddRange(new object[] {
            "Khoa Nhi",
            "Khoa Nội",
            "Khoa Ngoại",
            "Khoa Tai Mũi Họng"});
            this.cbChuyenKhoa.Location = new System.Drawing.Point(132, 291);
            this.cbChuyenKhoa.Name = "cbChuyenKhoa";
            this.cbChuyenKhoa.Size = new System.Drawing.Size(192, 23);
            this.cbChuyenKhoa.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GrvBacSi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(344, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(674, 377);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Bác Sĩ Quản Lý Bệnh Nhân";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Blue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Blue;
            this.button4.Location = new System.Drawing.Point(132, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(190, 2);
            this.button4.TabIndex = 24;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Blue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Blue;
            this.button6.Location = new System.Drawing.Point(131, 309);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(190, 2);
            this.button6.TabIndex = 26;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(61, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(263, 26);
            this.label11.TabIndex = 67;
            this.label11.Text = "Nhập vào các thông tin ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Lime;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(205, 375);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(37, 31);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 75;
            this.pictureBox6.TabStop = false;
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.BackColor = System.Drawing.Color.Lime;
            this.btnSuaThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaThongTin.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSuaThongTin.Location = new System.Drawing.Point(197, 364);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(114, 53);
            this.btnSuaThongTin.TabIndex = 74;
            this.btnSuaThongTin.Text = "Sửa TT ";
            this.btnSuaThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaThongTin.UseVisualStyleBackColor = false;
            this.btnSuaThongTin.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Lime;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(35, 372);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 36);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 77;
            this.pictureBox7.TabStop = false;
            // 
            // btnThemThongTin
            // 
            this.btnThemThongTin.BackColor = System.Drawing.Color.Lime;
            this.btnThemThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemThongTin.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnThemThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnThemThongTin.Location = new System.Drawing.Point(26, 364);
            this.btnThemThongTin.Name = "btnThemThongTin";
            this.btnThemThongTin.Size = new System.Drawing.Size(122, 53);
            this.btnThemThongTin.TabIndex = 76;
            this.btnThemThongTin.Text = "Thêm BS";
            this.btnThemThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemThongTin.UseVisualStyleBackColor = false;
            this.btnThemThongTin.Click += new System.EventHandler(this.btnThemThongTin_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Lime;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(127, 447);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(37, 31);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 77;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // btnXoaThongTin
            // 
            this.btnXoaThongTin.BackColor = System.Drawing.Color.Lime;
            this.btnXoaThongTin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaThongTin.Font = new System.Drawing.Font("Arial", 10.8F);
            this.btnXoaThongTin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnXoaThongTin.Location = new System.Drawing.Point(119, 436);
            this.btnXoaThongTin.Name = "btnXoaThongTin";
            this.btnXoaThongTin.Size = new System.Drawing.Size(110, 52);
            this.btnXoaThongTin.TabIndex = 76;
            this.btnXoaThongTin.Text = "Xóa BS";
            this.btnXoaThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaThongTin.UseVisualStyleBackColor = false;
            this.btnXoaThongTin.Click += new System.EventHandler(this.btnXoaThongTin_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(133, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 2);
            this.button3.TabIndex = 23;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(133, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 2);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormBacSi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1030, 500);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnXoaThongTin);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.btnSuaThongTin);
            this.Controls.Add(this.btnThemThongTin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbChuyenKhoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKinhNghiem);
            this.Controls.Add(this.txtTenBS);
            this.Controls.Add(this.txtMaBS);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormBacSi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBacSi_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvBacSi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaBS;
        private System.Windows.Forms.TextBox txtTenBS;
        private System.Windows.Forms.TextBox txtKinhNghiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GrvBacSi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChuyenKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnXoaThongTin;
        private System.Windows.Forms.Button btnThemThongTin;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn KinhNghiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenKhoa;
    }
}