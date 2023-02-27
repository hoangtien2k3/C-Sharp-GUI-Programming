namespace test7_baitap
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxThongTinDangKy = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textTuoi = new System.Windows.Forms.TextBox();
            this.dateTimeDK = new System.Windows.Forms.DateTimePicker();
            this.buttonDangKy = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxThongTinDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxThongTinDangKy
            // 
            this.groupBoxThongTinDangKy.Controls.Add(this.buttonDangKy);
            this.groupBoxThongTinDangKy.Controls.Add(this.dateTimeDK);
            this.groupBoxThongTinDangKy.Controls.Add(this.textTuoi);
            this.groupBoxThongTinDangKy.Controls.Add(this.textPhone);
            this.groupBoxThongTinDangKy.Controls.Add(this.label3);
            this.groupBoxThongTinDangKy.Controls.Add(this.label2);
            this.groupBoxThongTinDangKy.Controls.Add(this.label1);
            this.groupBoxThongTinDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThongTinDangKy.Location = new System.Drawing.Point(63, 59);
            this.groupBoxThongTinDangKy.Name = "groupBoxThongTinDangKy";
            this.groupBoxThongTinDangKy.Size = new System.Drawing.Size(419, 196);
            this.groupBoxThongTinDangKy.TabIndex = 0;
            this.groupBoxThongTinDangKy.TabStop = false;
            this.groupBoxThongTinDangKy.Text = "Thông Tin Đăng Ký";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phone: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tuổi: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày ĐK: ";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(116, 36);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(200, 21);
            this.textPhone.TabIndex = 3;
            // 
            // textTuoi
            // 
            this.textTuoi.Location = new System.Drawing.Point(116, 70);
            this.textTuoi.Name = "textTuoi";
            this.textTuoi.Size = new System.Drawing.Size(200, 21);
            this.textTuoi.TabIndex = 4;
            // 
            // dateTimeDK
            // 
            this.dateTimeDK.CustomFormat = "dd/MM/yyyy";
            this.dateTimeDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeDK.Location = new System.Drawing.Point(116, 105);
            this.dateTimeDK.Name = "dateTimeDK";
            this.dateTimeDK.Size = new System.Drawing.Size(200, 21);
            this.dateTimeDK.TabIndex = 5;
            // 
            // buttonDangKy
            // 
            this.buttonDangKy.Location = new System.Drawing.Point(169, 147);
            this.buttonDangKy.Name = "buttonDangKy";
            this.buttonDangKy.Size = new System.Drawing.Size(75, 23);
            this.buttonDangKy.TabIndex = 6;
            this.buttonDangKy.Text = "Đăng Ký";
            this.buttonDangKy.UseVisualStyleBackColor = true;
            this.buttonDangKy.Click += new System.EventHandler(this.buttonDangKy_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(616, 370);
            this.Controls.Add(this.groupBoxThongTinDangKy);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký";
            this.groupBoxThongTinDangKy.ResumeLayout(false);
            this.groupBoxThongTinDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongTinDangKy;
        private System.Windows.Forms.Button buttonDangKy;
        private System.Windows.Forms.DateTimePicker dateTimeDK;
        private System.Windows.Forms.TextBox textTuoi;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

