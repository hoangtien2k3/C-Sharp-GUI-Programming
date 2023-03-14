namespace test14032023
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
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdoCong = new System.Windows.Forms.RadioButton();
            this.rdoTru = new System.Windows.Forms.RadioButton();
            this.rdoNhan = new System.Windows.Forms.RadioButton();
            this.rdoChia = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số 2:";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(186, 60);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(195, 20);
            this.txtSo1.TabIndex = 2;
            this.txtSo1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(186, 100);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(195, 20);
            this.txtSo2.TabIndex = 2;
            this.txtSo2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phép Tính:";
            // 
            // rdoCong
            // 
            this.rdoCong.AutoSize = true;
            this.rdoCong.Location = new System.Drawing.Point(186, 175);
            this.rdoCong.Name = "rdoCong";
            this.rdoCong.Size = new System.Drawing.Size(50, 17);
            this.rdoCong.TabIndex = 5;
            this.rdoCong.TabStop = true;
            this.rdoCong.Text = "Cộng";
            this.rdoCong.UseVisualStyleBackColor = true;
            this.rdoCong.CheckedChanged += new System.EventHandler(this.rdoCong_CheckedChanged);
            // 
            // rdoTru
            // 
            this.rdoTru.AutoSize = true;
            this.rdoTru.Location = new System.Drawing.Point(277, 175);
            this.rdoTru.Name = "rdoTru";
            this.rdoTru.Size = new System.Drawing.Size(41, 17);
            this.rdoTru.TabIndex = 6;
            this.rdoTru.TabStop = true;
            this.rdoTru.Text = "Trừ";
            this.rdoTru.UseVisualStyleBackColor = true;
            // 
            // rdoNhan
            // 
            this.rdoNhan.AutoSize = true;
            this.rdoNhan.Location = new System.Drawing.Point(355, 175);
            this.rdoNhan.Name = "rdoNhan";
            this.rdoNhan.Size = new System.Drawing.Size(51, 17);
            this.rdoNhan.TabIndex = 7;
            this.rdoNhan.TabStop = true;
            this.rdoNhan.Text = "Nhân";
            this.rdoNhan.UseVisualStyleBackColor = true;
            // 
            // rdoChia
            // 
            this.rdoChia.AutoSize = true;
            this.rdoChia.Location = new System.Drawing.Point(437, 175);
            this.rdoChia.Name = "rdoChia";
            this.rdoChia.Size = new System.Drawing.Size(46, 17);
            this.rdoChia.TabIndex = 8;
            this.rdoChia.TabStop = true;
            this.rdoChia.Text = "Chia";
            this.rdoChia.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kết Qủa:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(189, 222);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(192, 20);
            this.txtKetQua.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 309);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdoChia);
            this.Controls.Add(this.rdoNhan);
            this.Controls.Add(this.rdoTru);
            this.Controls.Add(this.rdoCong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoCong;
        private System.Windows.Forms.RadioButton rdoTru;
        private System.Windows.Forms.RadioButton rdoNhan;
        private System.Windows.Forms.RadioButton rdoChia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}

