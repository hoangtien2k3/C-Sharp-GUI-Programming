namespace Mau1
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
            this.chlbBang1 = new System.Windows.Forms.CheckedListBox();
            this.chlbBang2 = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chlbBang1
            // 
            this.chlbBang1.FormattingEnabled = true;
            this.chlbBang1.Items.AddRange(new object[] {
            "Yasuo",
            "Eto icon + 8",
            "Messi",
            "Cristiano Ronaldo (non)",
            "Essien icon + 5",
            "Petit",
            "Zola",
            "aaa",
            "hoang anh tien"});
            this.chlbBang1.Location = new System.Drawing.Point(54, 168);
            this.chlbBang1.Name = "chlbBang1";
            this.chlbBang1.Size = new System.Drawing.Size(249, 214);
            this.chlbBang1.TabIndex = 0;
            this.chlbBang1.SelectedIndexChanged += new System.EventHandler(this.chlbBang1_SelectedIndexChanged);
            // 
            // chlbBang2
            // 
            this.chlbBang2.FormattingEnabled = true;
            this.chlbBang2.Location = new System.Drawing.Point(451, 168);
            this.chlbBang2.Name = "chlbBang2";
            this.chlbBang2.Size = new System.Drawing.Size(250, 214);
            this.chlbBang2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(324, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(324, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nhập Sinh Viên: ";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(216, 119);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(278, 20);
            this.txtNhap.TabIndex = 5;
            this.txtNhap.TextChanged += new System.EventHandler(this.txtNhap_TextChanged);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(547, 108);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(111, 31);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Cập Nhật";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(324, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 33);
            this.button3.TabIndex = 7;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(324, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(257, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "DANH SÁCH SINH VIÊN";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(137, 405);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 33);
            this.button5.TabIndex = 10;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(532, 405);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(82, 33);
            this.button6.TabIndex = 11;
            this.button6.Text = "Kết Thức";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 461);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chlbBang2);
            this.Controls.Add(this.chlbBang1);
            this.Name = "Form1";
            this.Text = "HOÀNG ANH TIẾN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chlbBang1;
        private System.Windows.Forms.CheckedListBox chlbBang2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

