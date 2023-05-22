namespace AD_WEEK_12
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
            this.cmb_pos = new System.Windows.Forms.ComboBox();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dtp_birthdate = new System.Windows.Forms.DateTimePicker();
            this.cmb_teamname = new System.Windows.Forms.ComboBox();
            this.cmb_nation = new System.Windows.Forms.ComboBox();
            this.txt_teamnum = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.txt_playerid = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.btn_addplayer = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.cmb_team = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_team2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_pos
            // 
            this.cmb_pos.FormattingEnabled = true;
            this.cmb_pos.Items.AddRange(new object[] {
            "G",
            "D",
            "M",
            "F"});
            this.cmb_pos.Location = new System.Drawing.Point(154, 228);
            this.cmb_pos.Name = "cmb_pos";
            this.cmb_pos.Size = new System.Drawing.Size(169, 28);
            this.cmb_pos.TabIndex = 76;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(349, 89);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 62;
            this.dgv1.RowTemplate.Height = 28;
            this.dgv1.Size = new System.Drawing.Size(417, 177);
            this.dgv1.TabIndex = 75;
            // 
            // dtp_birthdate
            // 
            this.dtp_birthdate.Location = new System.Drawing.Point(154, 366);
            this.dtp_birthdate.Name = "dtp_birthdate";
            this.dtp_birthdate.Size = new System.Drawing.Size(169, 26);
            this.dtp_birthdate.TabIndex = 74;
            // 
            // cmb_teamname
            // 
            this.cmb_teamname.FormattingEnabled = true;
            this.cmb_teamname.Location = new System.Drawing.Point(154, 415);
            this.cmb_teamname.Name = "cmb_teamname";
            this.cmb_teamname.Size = new System.Drawing.Size(169, 28);
            this.cmb_teamname.TabIndex = 73;
            // 
            // cmb_nation
            // 
            this.cmb_nation.FormattingEnabled = true;
            this.cmb_nation.Location = new System.Drawing.Point(154, 182);
            this.cmb_nation.Name = "cmb_nation";
            this.cmb_nation.Size = new System.Drawing.Size(169, 28);
            this.cmb_nation.TabIndex = 72;
            // 
            // txt_teamnum
            // 
            this.txt_teamnum.Location = new System.Drawing.Point(154, 138);
            this.txt_teamnum.Name = "txt_teamnum";
            this.txt_teamnum.Size = new System.Drawing.Size(169, 26);
            this.txt_teamnum.TabIndex = 71;
            // 
            // txt_height
            // 
            this.txt_height.Location = new System.Drawing.Point(154, 276);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(169, 26);
            this.txt_height.TabIndex = 70;
            // 
            // txt_weight
            // 
            this.txt_weight.Location = new System.Drawing.Point(154, 324);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(169, 26);
            this.txt_weight.TabIndex = 69;
            // 
            // txt_playerid
            // 
            this.txt_playerid.Location = new System.Drawing.Point(154, 459);
            this.txt_playerid.Name = "txt_playerid";
            this.txt_playerid.Size = new System.Drawing.Size(169, 26);
            this.txt_playerid.TabIndex = 68;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(154, 89);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(169, 26);
            this.txt_name.TabIndex = 67;
            // 
            // btn_addplayer
            // 
            this.btn_addplayer.Location = new System.Drawing.Point(66, 520);
            this.btn_addplayer.Name = "btn_addplayer";
            this.btn_addplayer.Size = new System.Drawing.Size(131, 44);
            this.btn_addplayer.TabIndex = 66;
            this.btn_addplayer.Text = "Add Player";
            this.btn_addplayer.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 65;
            this.label10.Text = "Player ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 64;
            this.label9.Text = "Team Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 371);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Birthdate:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 62;
            this.label7.Text = "Weight:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Height:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 60;
            this.label5.Text = "Position:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Nationality:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Team Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Name:";
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(349, 278);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowHeadersWidth = 62;
            this.dgv2.RowTemplate.Height = 28;
            this.dgv2.Size = new System.Drawing.Size(417, 233);
            this.dgv2.TabIndex = 77;
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(781, 89);
            this.dgv3.Name = "dgv3";
            this.dgv3.RowHeadersWidth = 62;
            this.dgv3.RowTemplate.Height = 28;
            this.dgv3.Size = new System.Drawing.Size(459, 426);
            this.dgv3.TabIndex = 78;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(498, 526);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(98, 32);
            this.btn_update.TabIndex = 79;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(920, 526);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 32);
            this.btn_delete.TabIndex = 80;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cmb_team
            // 
            this.cmb_team.FormattingEnabled = true;
            this.cmb_team.Location = new System.Drawing.Point(349, 51);
            this.cmb_team.Name = "cmb_team";
            this.cmb_team.Size = new System.Drawing.Size(417, 28);
            this.cmb_team.TabIndex = 81;
            this.cmb_team.SelectedIndexChanged += new System.EventHandler(this.cmb_team_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Player";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(345, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 20);
            this.label11.TabIndex = 82;
            this.label11.Text = "Player";
            // 
            // cmb_team2
            // 
            this.cmb_team2.FormattingEnabled = true;
            this.cmb_team2.Location = new System.Drawing.Point(781, 51);
            this.cmb_team2.Name = "cmb_team2";
            this.cmb_team2.Size = new System.Drawing.Size(459, 28);
            this.cmb_team2.TabIndex = 83;
            this.cmb_team2.SelectedIndexChanged += new System.EventHandler(this.cmb_team2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 664);
            this.Controls.Add(this.cmb_team2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmb_team);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.cmb_pos);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.dtp_birthdate);
            this.Controls.Add(this.cmb_teamname);
            this.Controls.Add(this.cmb_nation);
            this.Controls.Add(this.txt_teamnum);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.txt_playerid);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.btn_addplayer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_pos;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DateTimePicker dtp_birthdate;
        private System.Windows.Forms.ComboBox cmb_teamname;
        private System.Windows.Forms.ComboBox cmb_nation;
        private System.Windows.Forms.TextBox txt_teamnum;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.TextBox txt_playerid;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Button btn_addplayer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cmb_team;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_team2;
    }
}

