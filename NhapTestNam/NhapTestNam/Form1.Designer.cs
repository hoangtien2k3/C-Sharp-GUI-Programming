namespace NhapTestNam
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimNgayTrongThang = new System.Windows.Forms.Button();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtThang = new System.Windows.Forms.TextBox();
            this.txtNam = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Ngày: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Tháng: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập Năm: ";
            // 
            // btnTimNgayTrongThang
            // 
            this.btnTimNgayTrongThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimNgayTrongThang.ForeColor = System.Drawing.Color.Red;
            this.btnTimNgayTrongThang.Location = new System.Drawing.Point(53, 172);
            this.btnTimNgayTrongThang.Name = "btnTimNgayTrongThang";
            this.btnTimNgayTrongThang.Size = new System.Drawing.Size(184, 38);
            this.btnTimNgayTrongThang.TabIndex = 3;
            this.btnTimNgayTrongThang.Text = "Số Ngày Trong Tháng";
            this.btnTimNgayTrongThang.UseVisualStyleBackColor = true;
            this.btnTimNgayTrongThang.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNgay
            // 
            this.txtNgay.Location = new System.Drawing.Point(162, 39);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.Size = new System.Drawing.Size(255, 20);
            this.txtNgay.TabIndex = 4;
            this.txtNgay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtThang
            // 
            this.txtThang.Location = new System.Drawing.Point(162, 82);
            this.txtThang.Name = "txtThang";
            this.txtThang.Size = new System.Drawing.Size(255, 20);
            this.txtThang.TabIndex = 5;
            this.txtThang.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNam
            // 
            this.txtNam.Location = new System.Drawing.Point(162, 126);
            this.txtNam.Name = "txtNam";
            this.txtNam.Size = new System.Drawing.Size(255, 20);
            this.txtNam.TabIndex = 6;
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(273, 186);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(46, 13);
            this.lblKetQua.TabIndex = 7;
            this.lblKetQua.Text = "Kết Qủa";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKetQua.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 233);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtNam);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.txtNgay);
            this.Controls.Add(this.btnTimNgayTrongThang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "q";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTimNgayTrongThang;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtThang;
        private System.Windows.Forms.TextBox txtNam;
        private System.Windows.Forms.Label lblKetQua;
    }
}

