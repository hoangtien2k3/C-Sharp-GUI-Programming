namespace Test6_baitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxHaTa = new System.Windows.Forms.PictureBox();
            this.pictureBoxNangTa = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.checkBoxMusic = new System.Windows.Forms.CheckBox();
            this.buttonClick = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHaTa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNangTa)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHaTa
            // 
            this.pictureBoxHaTa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHaTa.Image")));
            this.pictureBoxHaTa.Location = new System.Drawing.Point(43, 94);
            this.pictureBoxHaTa.Name = "pictureBoxHaTa";
            this.pictureBoxHaTa.Size = new System.Drawing.Size(387, 251);
            this.pictureBoxHaTa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHaTa.TabIndex = 0;
            this.pictureBoxHaTa.TabStop = false;
            // 
            // pictureBoxNangTa
            // 
            this.pictureBoxNangTa.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNangTa.Image")));
            this.pictureBoxNangTa.Location = new System.Drawing.Point(45, 94);
            this.pictureBoxNangTa.Name = "pictureBoxNangTa";
            this.pictureBoxNangTa.Size = new System.Drawing.Size(387, 251);
            this.pictureBoxNangTa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNangTa.TabIndex = 1;
            this.pictureBoxNangTa.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelName.Location = new System.Drawing.Point(39, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(86, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nhập Tên";
            this.labelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBoxMusic
            // 
            this.checkBoxMusic.AutoSize = true;
            this.checkBoxMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMusic.ForeColor = System.Drawing.Color.Red;
            this.checkBoxMusic.Location = new System.Drawing.Point(345, 24);
            this.checkBoxMusic.Name = "checkBoxMusic";
            this.checkBoxMusic.Size = new System.Drawing.Size(72, 22);
            this.checkBoxMusic.TabIndex = 3;
            this.checkBoxMusic.Text = "Music";
            this.checkBoxMusic.UseVisualStyleBackColor = true;
            this.checkBoxMusic.CheckedChanged += new System.EventHandler(this.checkBoxMusic_CheckedChanged);
            // 
            // buttonClick
            // 
            this.buttonClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClick.ForeColor = System.Drawing.Color.Red;
            this.buttonClick.Location = new System.Drawing.Point(43, 362);
            this.buttonClick.Name = "buttonClick";
            this.buttonClick.Size = new System.Drawing.Size(387, 36);
            this.buttonClick.TabIndex = 4;
            this.buttonClick.UseVisualStyleBackColor = false;
            this.buttonClick.Click += new System.EventHandler(this.buttonClick_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Design By: ";
            // 
            // labelCount
            // 
            this.labelCount.BackColor = System.Drawing.Color.Yellow;
            this.labelCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(174, 413);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(125, 50);
            this.labelCount.TabIndex = 6;
            this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonThoat
            // 
            this.buttonThoat.BackColor = System.Drawing.Color.Red;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.Yellow;
            this.buttonThoat.Location = new System.Drawing.Point(357, 413);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 50);
            this.buttonThoat.TabIndex = 7;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = false;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(45, 56);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(387, 20);
            this.textBoxInput.TabIndex = 8;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tiến Coder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(501, 482);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClick);
            this.Controls.Add(this.checkBoxMusic);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxNangTa);
            this.Controls.Add(this.pictureBoxHaTa);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tập Luyện";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHaTa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNangTa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHaTa;
        private System.Windows.Forms.PictureBox pictureBoxNangTa;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.CheckBox checkBoxMusic;
        private System.Windows.Forms.Button buttonClick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label4;
    }
}

