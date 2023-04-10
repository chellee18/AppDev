namespace THA_WEEK6_Michelle_P
{
    partial class btn_Delete
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
            this.btn_Enter = new System.Windows.Forms.Button();
            this.btn_Delete1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(1155, 155);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(135, 76);
            this.btn_Enter.TabIndex = 1;
            this.btn_Enter.Text = "ENTER";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // btn_Delete1
            // 
            this.btn_Delete1.Location = new System.Drawing.Point(495, 155);
            this.btn_Delete1.Name = "btn_Delete1";
            this.btn_Delete1.Size = new System.Drawing.Size(135, 76);
            this.btn_Delete1.TabIndex = 2;
            this.btn_Delete1.Text = "DELETE";
            this.btn_Delete1.UseVisualStyleBackColor = true;
            this.btn_Delete1.Click += new System.EventHandler(this.btn_Delete1_Click);
            // 
            // btn_Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 587);
            this.Controls.Add(this.btn_Delete1);
            this.Controls.Add(this.btn_Enter);
            this.Name = "btn_Delete";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button btn_Delete1;
    }
}