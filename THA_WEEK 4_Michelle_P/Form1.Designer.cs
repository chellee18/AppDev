namespace THA_WEEK_4_Michelle_P
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Country = new System.Windows.Forms.ComboBox();
            this.cmb_Team = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TeamName = new System.Windows.Forms.TextBox();
            this.txt_TeamCountry = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_TeamCity = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_PlayerName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_PlayerNum = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.listBox_Player = new System.Windows.Forms.ListBox();
            this.btn_Add2 = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.cmb_Position = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soccer Team List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose Country:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose Team:";
            // 
            // cmb_Country
            // 
            this.cmb_Country.FormattingEnabled = true;
            this.cmb_Country.Location = new System.Drawing.Point(139, 66);
            this.cmb_Country.Name = "cmb_Country";
            this.cmb_Country.Size = new System.Drawing.Size(163, 28);
            this.cmb_Country.TabIndex = 3;
            this.cmb_Country.SelectedIndexChanged += new System.EventHandler(this.cmb_Country_SelectedIndexChanged);
            // 
            // cmb_Team
            // 
            this.cmb_Team.FormattingEnabled = true;
            this.cmb_Team.Location = new System.Drawing.Point(139, 113);
            this.cmb_Team.Name = "cmb_Team";
            this.cmb_Team.Size = new System.Drawing.Size(163, 28);
            this.cmb_Team.TabIndex = 4;
            this.cmb_Team.SelectedIndexChanged += new System.EventHandler(this.cmb_Team_SelectedIndexChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adding Team ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(322, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Team Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Team Country:";
            // 
            // txt_TeamName
            // 
            this.txt_TeamName.Location = new System.Drawing.Point(440, 66);
            this.txt_TeamName.Name = "txt_TeamName";
            this.txt_TeamName.Size = new System.Drawing.Size(136, 26);
            this.txt_TeamName.TabIndex = 8;
            // 
            // txt_TeamCountry
            // 
            this.txt_TeamCountry.Location = new System.Drawing.Point(440, 113);
            this.txt_TeamCountry.Name = "txt_TeamCountry";
            this.txt_TeamCountry.Size = new System.Drawing.Size(136, 26);
            this.txt_TeamCountry.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Team City:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_TeamCity
            // 
            this.txt_TeamCity.Location = new System.Drawing.Point(440, 157);
            this.txt_TeamCity.Name = "txt_TeamCity";
            this.txt_TeamCity.Size = new System.Drawing.Size(136, 26);
            this.txt_TeamCity.TabIndex = 11;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(440, 198);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(64, 35);
            this.btn_Add.TabIndex = 12;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(743, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Adding Player";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(609, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Player Name:";
            // 
            // txt_PlayerName
            // 
            this.txt_PlayerName.Location = new System.Drawing.Point(735, 63);
            this.txt_PlayerName.Name = "txt_PlayerName";
            this.txt_PlayerName.Size = new System.Drawing.Size(136, 26);
            this.txt_PlayerName.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(609, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Player Number:";
            // 
            // txt_PlayerNum
            // 
            this.txt_PlayerNum.Location = new System.Drawing.Point(735, 107);
            this.txt_PlayerNum.Name = "txt_PlayerNum";
            this.txt_PlayerNum.Size = new System.Drawing.Size(136, 26);
            this.txt_PlayerNum.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(609, 163);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Player Position:";
            // 
            // listBox_Player
            // 
            this.listBox_Player.FormattingEnabled = true;
            this.listBox_Player.ItemHeight = 20;
            this.listBox_Player.Location = new System.Drawing.Point(23, 222);
            this.listBox_Player.Name = "listBox_Player";
            this.listBox_Player.Size = new System.Drawing.Size(340, 224);
            this.listBox_Player.TabIndex = 20;
            // 
            // btn_Add2
            // 
            this.btn_Add2.Location = new System.Drawing.Point(735, 198);
            this.btn_Add2.Name = "btn_Add2";
            this.btn_Add2.Size = new System.Drawing.Size(64, 35);
            this.btn_Add2.TabIndex = 21;
            this.btn_Add2.Text = "Add";
            this.btn_Add2.UseVisualStyleBackColor = true;
            this.btn_Add2.Click += new System.EventHandler(this.btn_Add2_Click_1);
            // 
            // btn_Remove
            // 
            this.btn_Remove.Location = new System.Drawing.Point(23, 452);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(85, 35);
            this.btn_Remove.TabIndex = 22;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click_1);
            // 
            // cmb_Position
            // 
            this.cmb_Position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Position.FormattingEnabled = true;
            this.cmb_Position.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.cmb_Position.Location = new System.Drawing.Point(735, 157);
            this.cmb_Position.Name = "cmb_Position";
            this.cmb_Position.Size = new System.Drawing.Size(163, 28);
            this.cmb_Position.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 519);
            this.Controls.Add(this.cmb_Position);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add2);
            this.Controls.Add(this.listBox_Player);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_PlayerNum);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_PlayerName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txt_TeamCity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_TeamCountry);
            this.Controls.Add(this.txt_TeamName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Team);
            this.Controls.Add(this.cmb_Country);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Country;
        private System.Windows.Forms.ComboBox cmb_Team;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TeamName;
        private System.Windows.Forms.TextBox txt_TeamCountry;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_TeamCity;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_PlayerName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_PlayerNum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listBox_Player;
        private System.Windows.Forms.Button btn_Add2;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.ComboBox cmb_Position;
    }
}

