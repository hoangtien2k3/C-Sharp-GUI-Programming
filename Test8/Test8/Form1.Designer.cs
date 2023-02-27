namespace Test8
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
            this.listDanhSach = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCount = new System.Windows.Forms.Button();
            this.buttonIndex = new System.Windows.Forms.Button();
            this.buttonRemoveAt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listDanhSach
            // 
            this.listDanhSach.FormattingEnabled = true;
            this.listDanhSach.Items.AddRange(new object[] {
            "item1",
            "item2",
            "item3",
            "item4"});
            this.listDanhSach.Location = new System.Drawing.Point(106, 94);
            this.listDanhSach.Name = "listDanhSach";
            this.listDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listDanhSach.Size = new System.Drawing.Size(120, 95);
            this.listDanhSach.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(360, 103);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCount
            // 
            this.buttonCount.Location = new System.Drawing.Point(360, 165);
            this.buttonCount.Name = "buttonCount";
            this.buttonCount.Size = new System.Drawing.Size(75, 23);
            this.buttonCount.TabIndex = 2;
            this.buttonCount.Text = "Count";
            this.buttonCount.UseVisualStyleBackColor = true;
            this.buttonCount.Click += new System.EventHandler(this.buttonCount_Click);
            // 
            // buttonIndex
            // 
            this.buttonIndex.Location = new System.Drawing.Point(360, 220);
            this.buttonIndex.Name = "buttonIndex";
            this.buttonIndex.Size = new System.Drawing.Size(75, 23);
            this.buttonIndex.TabIndex = 3;
            this.buttonIndex.Text = "Index";
            this.buttonIndex.UseVisualStyleBackColor = true;
            this.buttonIndex.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRemoveAt
            // 
            this.buttonRemoveAt.Location = new System.Drawing.Point(360, 267);
            this.buttonRemoveAt.Name = "buttonRemoveAt";
            this.buttonRemoveAt.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAt.TabIndex = 4;
            this.buttonRemoveAt.Text = "RemoveAt";
            this.buttonRemoveAt.UseVisualStyleBackColor = true;
            this.buttonRemoveAt.Click += new System.EventHandler(this.buttonRemoveAt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 362);
            this.Controls.Add(this.buttonRemoveAt);
            this.Controls.Add(this.buttonIndex);
            this.Controls.Add(this.buttonCount);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listDanhSach);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listDanhSach;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCount;
        private System.Windows.Forms.Button buttonIndex;
        private System.Windows.Forms.Button buttonRemoveAt;
    }
}

