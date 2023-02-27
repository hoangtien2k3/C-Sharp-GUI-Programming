namespace test8_baitap
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
            this.textBoxNhapSo = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBoxDanhSachSo = new System.Windows.Forms.GroupBox();
            this.listBoxSo = new System.Windows.Forms.ListBox();
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.buttonSoLe = new System.Windows.Forms.Button();
            this.buttonSoChan = new System.Windows.Forms.Button();
            this.buttonThayBangBinhPhuong = new System.Windows.Forms.Button();
            this.buttonTangLen2 = new System.Windows.Forms.Button();
            this.buttonXoaPTChon = new System.Windows.Forms.Button();
            this.buttonXoaDauCuoi = new System.Windows.Forms.Button();
            this.buttonTongDS = new System.Windows.Forms.Button();
            this.buttonKeThuc = new System.Windows.Forms.Button();
            this.groupBoxDanhSachSo.SuspendLayout();
            this.groupBoxChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Số: ";
            // 
            // textBoxNhapSo
            // 
            this.textBoxNhapSo.Location = new System.Drawing.Point(112, 31);
            this.textBoxNhapSo.Name = "textBoxNhapSo";
            this.textBoxNhapSo.Size = new System.Drawing.Size(464, 20);
            this.textBoxNhapSo.TabIndex = 1;
            this.textBoxNhapSo.Text = "12";
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(604, 31);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 2;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // groupBoxDanhSachSo
            // 
            this.groupBoxDanhSachSo.Controls.Add(this.listBoxSo);
            this.groupBoxDanhSachSo.Location = new System.Drawing.Point(24, 98);
            this.groupBoxDanhSachSo.Name = "groupBoxDanhSachSo";
            this.groupBoxDanhSachSo.Size = new System.Drawing.Size(317, 320);
            this.groupBoxDanhSachSo.TabIndex = 3;
            this.groupBoxDanhSachSo.TabStop = false;
            this.groupBoxDanhSachSo.Text = "Danh Sách Số";
            // 
            // listBoxSo
            // 
            this.listBoxSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxSo.FormattingEnabled = true;
            this.listBoxSo.Location = new System.Drawing.Point(3, 16);
            this.listBoxSo.Name = "listBoxSo";
            this.listBoxSo.Size = new System.Drawing.Size(311, 301);
            this.listBoxSo.TabIndex = 0;
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.Controls.Add(this.buttonSoLe);
            this.groupBoxChucNang.Controls.Add(this.buttonSoChan);
            this.groupBoxChucNang.Controls.Add(this.buttonThayBangBinhPhuong);
            this.groupBoxChucNang.Controls.Add(this.buttonTangLen2);
            this.groupBoxChucNang.Controls.Add(this.buttonXoaPTChon);
            this.groupBoxChucNang.Controls.Add(this.buttonXoaDauCuoi);
            this.groupBoxChucNang.Controls.Add(this.buttonTongDS);
            this.groupBoxChucNang.Location = new System.Drawing.Point(362, 98);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Size = new System.Drawing.Size(317, 320);
            this.groupBoxChucNang.TabIndex = 4;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "Chức Năng";
            // 
            // buttonSoLe
            // 
            this.buttonSoLe.Location = new System.Drawing.Point(7, 273);
            this.buttonSoLe.Name = "buttonSoLe";
            this.buttonSoLe.Size = new System.Drawing.Size(288, 23);
            this.buttonSoLe.TabIndex = 6;
            this.buttonSoLe.Text = "Chọn số lẻ";
            this.buttonSoLe.UseVisualStyleBackColor = true;
            this.buttonSoLe.Click += new System.EventHandler(this.buttonSoLe_Click);
            // 
            // buttonSoChan
            // 
            this.buttonSoChan.Location = new System.Drawing.Point(7, 232);
            this.buttonSoChan.Name = "buttonSoChan";
            this.buttonSoChan.Size = new System.Drawing.Size(288, 23);
            this.buttonSoChan.TabIndex = 5;
            this.buttonSoChan.Text = "Chọn số chẵn";
            this.buttonSoChan.UseVisualStyleBackColor = true;
            this.buttonSoChan.Click += new System.EventHandler(this.buttonSoChan_Click);
            // 
            // buttonThayBangBinhPhuong
            // 
            this.buttonThayBangBinhPhuong.Location = new System.Drawing.Point(7, 193);
            this.buttonThayBangBinhPhuong.Name = "buttonThayBangBinhPhuong";
            this.buttonThayBangBinhPhuong.Size = new System.Drawing.Size(288, 23);
            this.buttonThayBangBinhPhuong.TabIndex = 4;
            this.buttonThayBangBinhPhuong.Text = "Thay bằng bình phương";
            this.buttonThayBangBinhPhuong.UseVisualStyleBackColor = true;
            this.buttonThayBangBinhPhuong.Click += new System.EventHandler(this.buttonThayBangBinhPhuong_Click);
            // 
            // buttonTangLen2
            // 
            this.buttonTangLen2.Location = new System.Drawing.Point(7, 154);
            this.buttonTangLen2.Name = "buttonTangLen2";
            this.buttonTangLen2.Size = new System.Drawing.Size(288, 23);
            this.buttonTangLen2.TabIndex = 3;
            this.buttonTangLen2.Text = "Tăng mỗi phần tử lên 2";
            this.buttonTangLen2.UseVisualStyleBackColor = true;
            this.buttonTangLen2.Click += new System.EventHandler(this.buttonTangLen2_Click);
            // 
            // buttonXoaPTChon
            // 
            this.buttonXoaPTChon.Location = new System.Drawing.Point(7, 109);
            this.buttonXoaPTChon.Name = "buttonXoaPTChon";
            this.buttonXoaPTChon.Size = new System.Drawing.Size(288, 23);
            this.buttonXoaPTChon.TabIndex = 2;
            this.buttonXoaPTChon.Text = "Xóa phần tử đang chọn";
            this.buttonXoaPTChon.UseVisualStyleBackColor = true;
            this.buttonXoaPTChon.Click += new System.EventHandler(this.buttonXoaPTChon_Click);
            // 
            // buttonXoaDauCuoi
            // 
            this.buttonXoaDauCuoi.Location = new System.Drawing.Point(7, 70);
            this.buttonXoaDauCuoi.Name = "buttonXoaDauCuoi";
            this.buttonXoaDauCuoi.Size = new System.Drawing.Size(288, 23);
            this.buttonXoaDauCuoi.TabIndex = 1;
            this.buttonXoaDauCuoi.Text = "Xóa phần tử đầu và cuối";
            this.buttonXoaDauCuoi.UseVisualStyleBackColor = true;
            this.buttonXoaDauCuoi.Click += new System.EventHandler(this.buttonXoaDauCuoi_Click);
            // 
            // buttonTongDS
            // 
            this.buttonTongDS.Location = new System.Drawing.Point(7, 31);
            this.buttonTongDS.Name = "buttonTongDS";
            this.buttonTongDS.Size = new System.Drawing.Size(288, 23);
            this.buttonTongDS.TabIndex = 0;
            this.buttonTongDS.Text = "Tổng của danh sách";
            this.buttonTongDS.UseVisualStyleBackColor = true;
            this.buttonTongDS.Click += new System.EventHandler(this.buttonTongDS_Click);
            // 
            // buttonKeThuc
            // 
            this.buttonKeThuc.Location = new System.Drawing.Point(26, 440);
            this.buttonKeThuc.Name = "buttonKeThuc";
            this.buttonKeThuc.Size = new System.Drawing.Size(653, 23);
            this.buttonKeThuc.TabIndex = 5;
            this.buttonKeThuc.Text = "Kết Thúc";
            this.buttonKeThuc.UseVisualStyleBackColor = true;
            this.buttonKeThuc.Click += new System.EventHandler(this.buttonKeThuc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(708, 496);
            this.Controls.Add(this.buttonKeThuc);
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.groupBoxDanhSachSo);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxNhapSo);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxDanhSachSo.ResumeLayout(false);
            this.groupBoxChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNhapSo;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.GroupBox groupBoxDanhSachSo;
        private System.Windows.Forms.ListBox listBoxSo;
        private System.Windows.Forms.GroupBox groupBoxChucNang;
        private System.Windows.Forms.Button buttonSoLe;
        private System.Windows.Forms.Button buttonSoChan;
        private System.Windows.Forms.Button buttonThayBangBinhPhuong;
        private System.Windows.Forms.Button buttonTangLen2;
        private System.Windows.Forms.Button buttonXoaPTChon;
        private System.Windows.Forms.Button buttonXoaDauCuoi;
        private System.Windows.Forms.Button buttonTongDS;
        private System.Windows.Forms.Button buttonKeThuc;
    }
}

