namespace takehome_week_3
{
    partial class SecondWindowForm
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
            this.btn_Magic = new System.Windows.Forms.Button();
            this.label_NameArtist = new System.Windows.Forms.Label();
            this.checkBox_Choice = new System.Windows.Forms.CheckBox();
            this.checkBox_Agree = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonBrown = new System.Windows.Forms.RadioButton();
            this.radioButtonPurple = new System.Windows.Forms.RadioButton();
            this.radioButtonPink = new System.Windows.Forms.RadioButton();
            this.radioButtonBlue = new System.Windows.Forms.RadioButton();
            this.radioButtonRed = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonGray = new System.Windows.Forms.RadioButton();
            this.radioButtonGreen = new System.Windows.Forms.RadioButton();
            this.radioButtonYellow = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Magic
            // 
            this.btn_Magic.Enabled = false;
            this.btn_Magic.Location = new System.Drawing.Point(456, 191);
            this.btn_Magic.Name = "btn_Magic";
            this.btn_Magic.Size = new System.Drawing.Size(136, 42);
            this.btn_Magic.TabIndex = 53;
            this.btn_Magic.Text = "Magic";
            this.btn_Magic.UseVisualStyleBackColor = true;
            this.btn_Magic.Click += new System.EventHandler(this.btn_Magic_Click);
            // 
            // label_NameArtist
            // 
            this.label_NameArtist.AutoSize = true;
            this.label_NameArtist.Location = new System.Drawing.Point(377, 247);
            this.label_NameArtist.Name = "label_NameArtist";
            this.label_NameArtist.Size = new System.Drawing.Size(302, 20);
            this.label_NameArtist.TabIndex = 52;
            this.label_NameArtist.Text = "Hi, my name is _ and my favorite artist is _";
            // 
            // checkBox_Choice
            // 
            this.checkBox_Choice.AutoSize = true;
            this.checkBox_Choice.Location = new System.Drawing.Point(33, 390);
            this.checkBox_Choice.Name = "checkBox_Choice";
            this.checkBox_Choice.Size = new System.Drawing.Size(276, 24);
            this.checkBox_Choice.TabIndex = 51;
            this.checkBox_Choice.Text = "All the choice I pick above are true";
            this.checkBox_Choice.UseVisualStyleBackColor = true;
            this.checkBox_Choice.CheckedChanged += new System.EventHandler(this.checkBox_Choice_CheckedChanged);
            // 
            // checkBox_Agree
            // 
            this.checkBox_Agree.AutoSize = true;
            this.checkBox_Agree.Location = new System.Drawing.Point(33, 359);
            this.checkBox_Agree.Name = "checkBox_Agree";
            this.checkBox_Agree.Size = new System.Drawing.Size(279, 24);
            this.checkBox_Agree.TabIndex = 50;
            this.checkBox_Agree.Text = "I agree to the Terms of Agreement";
            this.checkBox_Agree.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Pick text color:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "Pick your favorite background color:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonBrown);
            this.panel1.Controls.Add(this.radioButtonPurple);
            this.panel1.Controls.Add(this.radioButtonPink);
            this.panel1.Controls.Add(this.radioButtonBlue);
            this.panel1.Controls.Add(this.radioButtonRed);
            this.panel1.Location = new System.Drawing.Point(33, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 154);
            this.panel1.TabIndex = 54;
            // 
            // radioButtonBrown
            // 
            this.radioButtonBrown.AutoSize = true;
            this.radioButtonBrown.Location = new System.Drawing.Point(13, 123);
            this.radioButtonBrown.Name = "radioButtonBrown";
            this.radioButtonBrown.Size = new System.Drawing.Size(79, 24);
            this.radioButtonBrown.TabIndex = 50;
            this.radioButtonBrown.TabStop = true;
            this.radioButtonBrown.Text = "Brown";
            this.radioButtonBrown.UseVisualStyleBackColor = true;
            // 
            // radioButtonPurple
            // 
            this.radioButtonPurple.AutoSize = true;
            this.radioButtonPurple.Location = new System.Drawing.Point(13, 93);
            this.radioButtonPurple.Name = "radioButtonPurple";
            this.radioButtonPurple.Size = new System.Drawing.Size(79, 24);
            this.radioButtonPurple.TabIndex = 49;
            this.radioButtonPurple.TabStop = true;
            this.radioButtonPurple.Text = "Purple";
            this.radioButtonPurple.UseVisualStyleBackColor = true;
            // 
            // radioButtonPink
            // 
            this.radioButtonPink.AutoSize = true;
            this.radioButtonPink.Location = new System.Drawing.Point(13, 63);
            this.radioButtonPink.Name = "radioButtonPink";
            this.radioButtonPink.Size = new System.Drawing.Size(64, 24);
            this.radioButtonPink.TabIndex = 48;
            this.radioButtonPink.TabStop = true;
            this.radioButtonPink.Text = "Pink";
            this.radioButtonPink.UseVisualStyleBackColor = true;
            // 
            // radioButtonBlue
            // 
            this.radioButtonBlue.AutoSize = true;
            this.radioButtonBlue.Location = new System.Drawing.Point(13, 33);
            this.radioButtonBlue.Name = "radioButtonBlue";
            this.radioButtonBlue.Size = new System.Drawing.Size(66, 24);
            this.radioButtonBlue.TabIndex = 47;
            this.radioButtonBlue.TabStop = true;
            this.radioButtonBlue.Text = "Blue";
            this.radioButtonBlue.UseVisualStyleBackColor = true;
            // 
            // radioButtonRed
            // 
            this.radioButtonRed.AutoSize = true;
            this.radioButtonRed.Location = new System.Drawing.Point(13, 3);
            this.radioButtonRed.Name = "radioButtonRed";
            this.radioButtonRed.Size = new System.Drawing.Size(64, 24);
            this.radioButtonRed.TabIndex = 46;
            this.radioButtonRed.TabStop = true;
            this.radioButtonRed.Text = "Red";
            this.radioButtonRed.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonGray);
            this.panel2.Controls.Add(this.radioButtonGreen);
            this.panel2.Controls.Add(this.radioButtonYellow);
            this.panel2.Location = new System.Drawing.Point(33, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 55;
            // 
            // radioButtonGray
            // 
            this.radioButtonGray.AutoSize = true;
            this.radioButtonGray.Location = new System.Drawing.Point(8, 68);
            this.radioButtonGray.Name = "radioButtonGray";
            this.radioButtonGray.Size = new System.Drawing.Size(68, 24);
            this.radioButtonGray.TabIndex = 52;
            this.radioButtonGray.TabStop = true;
            this.radioButtonGray.Text = "Gray";
            this.radioButtonGray.UseVisualStyleBackColor = true;
            // 
            // radioButtonGreen
            // 
            this.radioButtonGreen.AutoSize = true;
            this.radioButtonGreen.Location = new System.Drawing.Point(8, 38);
            this.radioButtonGreen.Name = "radioButtonGreen";
            this.radioButtonGreen.Size = new System.Drawing.Size(79, 24);
            this.radioButtonGreen.TabIndex = 51;
            this.radioButtonGreen.TabStop = true;
            this.radioButtonGreen.Text = "Green";
            this.radioButtonGreen.UseVisualStyleBackColor = true;
            // 
            // radioButtonYellow
            // 
            this.radioButtonYellow.AutoSize = true;
            this.radioButtonYellow.Location = new System.Drawing.Point(8, 8);
            this.radioButtonYellow.Name = "radioButtonYellow";
            this.radioButtonYellow.Size = new System.Drawing.Size(80, 24);
            this.radioButtonYellow.TabIndex = 50;
            this.radioButtonYellow.TabStop = true;
            this.radioButtonYellow.Text = "Yellow";
            this.radioButtonYellow.UseVisualStyleBackColor = true;
            // 
            // SecondWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Magic);
            this.Controls.Add(this.label_NameArtist);
            this.Controls.Add(this.checkBox_Choice);
            this.Controls.Add(this.checkBox_Agree);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SecondWindowForm";
            this.Text = "SecondWindowForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Magic;
        private System.Windows.Forms.Label label_NameArtist;
        private System.Windows.Forms.CheckBox checkBox_Choice;
        private System.Windows.Forms.CheckBox checkBox_Agree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonBrown;
        private System.Windows.Forms.RadioButton radioButtonPurple;
        private System.Windows.Forms.RadioButton radioButtonPink;
        private System.Windows.Forms.RadioButton radioButtonBlue;
        private System.Windows.Forms.RadioButton radioButtonRed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonGray;
        private System.Windows.Forms.RadioButton radioButtonGreen;
        private System.Windows.Forms.RadioButton radioButtonYellow;
    }
}