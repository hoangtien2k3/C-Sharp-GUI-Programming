﻿namespace Test1
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
            this.lblKetQua = new System.Windows.Forms.Label();
            this.lblSoA = new System.Windows.Forms.Label();
            this.lblSoB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnTong = new System.Windows.Forms.Button();
            this.btnHieu = new System.Windows.Forms.Button();
            this.btnResert = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTich = new System.Windows.Forms.Button();
            this.btnThuong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiai = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblKetQua
            // 
            this.lblKetQua.BackColor = System.Drawing.Color.Blue;
            this.lblKetQua.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.ForeColor = System.Drawing.Color.Yellow;
            this.lblKetQua.Location = new System.Drawing.Point(0, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(423, 50);
            this.lblKetQua.TabIndex = 0;
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKetQua.Click += new System.EventHandler(this.lblKetQua_Click);
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoA.Location = new System.Drawing.Point(12, 59);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(98, 18);
            this.lblSoA.TabIndex = 1;
            this.lblSoA.Text = "Nhập Số A: ";
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoB.Location = new System.Drawing.Point(10, 100);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(94, 18);
            this.lblSoB.TabIndex = 2;
            this.lblSoB.Text = "Nhập Số B:";
            this.lblSoB.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(135, 60);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(281, 20);
            this.txtA.TabIndex = 3;
            this.txtA.Tag = "";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(135, 98);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(281, 20);
            this.txtB.TabIndex = 4;
            // 
            // btnTong
            // 
            this.btnTong.BackColor = System.Drawing.Color.Lime;
            this.btnTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTong.Location = new System.Drawing.Point(13, 185);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(93, 32);
            this.btnTong.TabIndex = 5;
            this.btnTong.Text = "&Tổng";
            this.btnTong.UseCompatibleTextRendering = true;
            this.btnTong.UseVisualStyleBackColor = false;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // btnHieu
            // 
            this.btnHieu.BackColor = System.Drawing.Color.Red;
            this.btnHieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHieu.Location = new System.Drawing.Point(112, 185);
            this.btnHieu.Name = "btnHieu";
            this.btnHieu.Size = new System.Drawing.Size(93, 32);
            this.btnHieu.TabIndex = 6;
            this.btnHieu.Text = "&Hiệu";
            this.btnHieu.UseVisualStyleBackColor = false;
            this.btnHieu.Click += new System.EventHandler(this.btnHieu_Click);
            // 
            // btnResert
            // 
            this.btnResert.BackColor = System.Drawing.Color.Fuchsia;
            this.btnResert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResert.Location = new System.Drawing.Point(323, 234);
            this.btnResert.Name = "btnResert";
            this.btnResert.Size = new System.Drawing.Size(93, 32);
            this.btnResert.TabIndex = 7;
            this.btnResert.Text = "Resert";
            this.btnResert.UseVisualStyleBackColor = false;
            this.btnResert.Click += new System.EventHandler(this.btnResert_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Yellow;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(224, 234);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 32);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTich
            // 
            this.btnTich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTich.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTich.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTich.Location = new System.Drawing.Point(224, 185);
            this.btnTich.Name = "btnTich";
            this.btnTich.Size = new System.Drawing.Size(93, 32);
            this.btnTich.TabIndex = 9;
            this.btnTich.Text = "&Tích";
            this.btnTich.UseVisualStyleBackColor = false;
            this.btnTich.Click += new System.EventHandler(this.btnTich_Click);
            // 
            // btnThuong
            // 
            this.btnThuong.BackColor = System.Drawing.Color.Black;
            this.btnThuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThuong.ForeColor = System.Drawing.Color.Yellow;
            this.btnThuong.Location = new System.Drawing.Point(323, 185);
            this.btnThuong.Name = "btnThuong";
            this.btnThuong.Size = new System.Drawing.Size(93, 32);
            this.btnThuong.TabIndex = 10;
            this.btnThuong.Text = "&Thương";
            this.btnThuong.UseVisualStyleBackColor = false;
            this.btnThuong.Click += new System.EventHandler(this.btnThuong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "KẾT QUẢ: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnGiai
            // 
            this.btnGiai.BackColor = System.Drawing.Color.White;
            this.btnGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiai.ForeColor = System.Drawing.Color.Blue;
            this.btnGiai.Location = new System.Drawing.Point(13, 232);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(93, 32);
            this.btnGiai.TabIndex = 13;
            this.btnGiai.Text = "GPT Bậc1";
            this.btnGiai.UseVisualStyleBackColor = false;
            this.btnGiai.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(112, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "GPT Bậc 2";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nhập Số C: ";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(135, 137);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(281, 20);
            this.txtC.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 271);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThuong);
            this.Controls.Add(this.btnTich);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnResert);
            this.Controls.Add(this.btnHieu);
            this.Controls.Add(this.btnTong);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblSoB);
            this.Controls.Add(this.lblSoA);
            this.Controls.Add(this.lblKetQua);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Máy Tính Cầm Tay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Button btnHieu;
        private System.Windows.Forms.Button btnResert;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTich;
        private System.Windows.Forms.Button btnThuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtC;
    }
}

