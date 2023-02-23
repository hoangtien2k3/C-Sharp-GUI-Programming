namespace Test5
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
            this.txtNhapTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBlack = new System.Windows.Forms.RadioButton();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkGachChan = new System.Windows.Forms.CheckBox();
            this.chkInNghiem = new System.Windows.Forms.CheckBox();
            this.chkInDam = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Đầu Vào: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNhapTen
            // 
            this.txtNhapTen.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTen.Location = new System.Drawing.Point(188, 30);
            this.txtNhapTen.Name = "txtNhapTen";
            this.txtNhapTen.Size = new System.Drawing.Size(381, 28);
            this.txtNhapTen.TabIndex = 1;
            this.txtNhapTen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hiển Thị: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(142, 275);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(280, 42);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutput.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(444, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.radBlack);
            this.groupBox1.Controls.Add(this.radBlue);
            this.groupBox1.Controls.Add(this.radGreen);
            this.groupBox1.Controls.Add(this.radRed);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 152);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Color";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radBlack
            // 
            this.radBlack.AutoSize = true;
            this.radBlack.ForeColor = System.Drawing.Color.Black;
            this.radBlack.Location = new System.Drawing.Point(44, 122);
            this.radBlack.Name = "radBlack";
            this.radBlack.Size = new System.Drawing.Size(71, 24);
            this.radBlack.TabIndex = 3;
            this.radBlack.TabStop = true;
            this.radBlack.Text = "Black";
            this.radBlack.UseVisualStyleBackColor = true;
            this.radBlack.CheckedChanged += new System.EventHandler(this.radBlack_CheckedChanged);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.ForeColor = System.Drawing.Color.Blue;
            this.radBlue.Location = new System.Drawing.Point(44, 92);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(63, 24);
            this.radBlue.TabIndex = 2;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.ForeColor = System.Drawing.Color.Lime;
            this.radGreen.Location = new System.Drawing.Point(44, 64);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(77, 24);
            this.radGreen.TabIndex = 1;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.radRed.Location = new System.Drawing.Point(44, 34);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(60, 24);
            this.radRed.TabIndex = 0;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.chkGachChan);
            this.groupBox2.Controls.Add(this.chkInNghiem);
            this.groupBox2.Controls.Add(this.chkInDam);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(304, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 152);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phông Chữ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chkGachChan
            // 
            this.chkGachChan.AutoSize = true;
            this.chkGachChan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGachChan.Location = new System.Drawing.Point(22, 115);
            this.chkGachChan.Name = "chkGachChan";
            this.chkGachChan.Size = new System.Drawing.Size(197, 24);
            this.chkGachChan.TabIndex = 2;
            this.chkGachChan.Text = "Gạch Chân (UnderLine)";
            this.chkGachChan.UseVisualStyleBackColor = true;
            this.chkGachChan.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chkInNghiem
            // 
            this.chkInNghiem.AutoSize = true;
            this.chkInNghiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInNghiem.Location = new System.Drawing.Point(23, 77);
            this.chkInNghiem.Name = "chkInNghiem";
            this.chkInNghiem.Size = new System.Drawing.Size(152, 24);
            this.chkInNghiem.TabIndex = 1;
            this.chkInNghiem.Text = "In Nghiêng (Italic)";
            this.chkInNghiem.UseVisualStyleBackColor = true;
            this.chkInNghiem.CheckedChanged += new System.EventHandler(this.chkInNghiem_CheckedChanged);
            // 
            // chkInDam
            // 
            this.chkInDam.AutoSize = true;
            this.chkInDam.Location = new System.Drawing.Point(23, 35);
            this.chkInDam.Name = "chkInDam";
            this.chkInDam.Size = new System.Drawing.Size(137, 24);
            this.chkInDam.TabIndex = 0;
            this.chkInDam.Text = "In Đậm (bold)";
            this.chkInDam.UseVisualStyleBackColor = true;
            this.chkInDam.CheckedChanged += new System.EventHandler(this.chkInDam_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 345);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNhapTen);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mền Định Dạng Chữ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhapTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radBlack;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.CheckBox chkGachChan;
        private System.Windows.Forms.CheckBox chkInNghiem;
        private System.Windows.Forms.CheckBox chkInDam;
    }
}

