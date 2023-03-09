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
            this.SuspendLayout();
            // 
            // chlbBang1
            // 
            this.chlbBang1.FormattingEnabled = true;
            this.chlbBang1.Items.AddRange(new object[] {
            "Tuổi trẻ",
            "Thanh Xuấn",
            "VNEpress",
            "Dân trí",
            "Công An",
            "Yasuo",
            "Eto icon + 8",
            "Messi",
            "Cristiano Ronaldo (non)",
            "Essien icon + 5",
            "Petit",
            "Zola"});
            this.chlbBang1.Location = new System.Drawing.Point(23, 30);
            this.chlbBang1.Name = "chlbBang1";
            this.chlbBang1.Size = new System.Drawing.Size(237, 184);
            this.chlbBang1.TabIndex = 0;
            this.chlbBang1.SelectedIndexChanged += new System.EventHandler(this.chlbBang1_SelectedIndexChanged);
            // 
            // chlbBang2
            // 
            this.chlbBang2.FormattingEnabled = true;
            this.chlbBang2.Location = new System.Drawing.Point(425, 30);
            this.chlbBang2.Name = "chlbBang2";
            this.chlbBang2.Size = new System.Drawing.Size(237, 184);
            this.chlbBang2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(294, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sang Phải";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(294, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Resert Phải";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chlbBang2);
            this.Controls.Add(this.chlbBang1);
            this.Name = "Form1";
            this.Text = "Vũ Mạnh Chiến";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chlbBang1;
        private System.Windows.Forms.CheckedListBox chlbBang2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

