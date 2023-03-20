namespace takehome_week_3
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
            this.btn_Next = new System.Windows.Forms.Button();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_Artist = new System.Windows.Forms.Label();
            this.txt_Artist = new System.Windows.Forms.TextBox();
            this.checkBox_Content = new System.Windows.Forms.CheckBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(37, 21);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(204, 36);
            this.btn_Next.TabIndex = 0;
            this.btn_Next.Text = "Open Next Form";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(33, 81);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(55, 20);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(94, 78);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(192, 26);
            this.txt_Name.TabIndex = 2;

            // 
            // lbl_Artist
            // 
            this.lbl_Artist.AutoSize = true;
            this.lbl_Artist.Location = new System.Drawing.Point(33, 127);
            this.lbl_Artist.Name = "lbl_Artist";
            this.lbl_Artist.Size = new System.Drawing.Size(135, 20);
            this.lbl_Artist.TabIndex = 3;
            this.lbl_Artist.Text = "My Favorite Artist:";
            // 
            // txt_Artist
            // 
            this.txt_Artist.Location = new System.Drawing.Point(174, 124);
            this.txt_Artist.Name = "txt_Artist";
            this.txt_Artist.Size = new System.Drawing.Size(192, 26);
            this.txt_Artist.TabIndex = 4;
            // 
            // checkBox_Content
            // 
            this.checkBox_Content.AutoSize = true;
            this.checkBox_Content.Location = new System.Drawing.Point(37, 172);
            this.checkBox_Content.Name = "checkBox_Content";
            this.checkBox_Content.Size = new System.Drawing.Size(285, 24);
            this.checkBox_Content.TabIndex = 5;
            this.checkBox_Content.Text = "All of the content I put above is true";
            this.checkBox_Content.UseVisualStyleBackColor = true;
            this.checkBox_Content.CheckedChanged += new System.EventHandler(this.checkBox_Content_CheckedChanged_1);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Location = new System.Drawing.Point(37, 222);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(95, 32);
            this.btn_Submit.TabIndex = 6;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.checkBox_Content);
            this.Controls.Add(this.txt_Artist);
            this.Controls.Add(this.lbl_Artist);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.btn_Next);
            this.Name = "Form1";
            this.Text = "Main Windows Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Artist;
        private System.Windows.Forms.TextBox txt_Artist;
        private System.Windows.Forms.CheckBox checkBox_Content;
        private System.Windows.Forms.Button btn_Submit;
    }
}

