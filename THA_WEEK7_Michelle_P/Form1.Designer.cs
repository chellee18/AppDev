namespace THA_WEEK7_Michelle_P
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cinemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Movie = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cinemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cinemaToolStripMenuItem
            // 
            this.cinemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieListToolStripMenuItem});
            this.cinemaToolStripMenuItem.Name = "cinemaToolStripMenuItem";
            this.cinemaToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.cinemaToolStripMenuItem.Text = "Cinema XXI";
            // 
            // movieListToolStripMenuItem
            // 
            this.movieListToolStripMenuItem.Name = "movieListToolStripMenuItem";
            this.movieListToolStripMenuItem.Size = new System.Drawing.Size(194, 34);
            this.movieListToolStripMenuItem.Text = "Movie List";
            this.movieListToolStripMenuItem.Click += new System.EventHandler(this.movieListToolStripMenuItem_Click);
            // 
            // panel_Movie
            // 
            this.panel_Movie.Location = new System.Drawing.Point(12, 36);
            this.panel_Movie.Name = "panel_Movie";
            this.panel_Movie.Size = new System.Drawing.Size(941, 758);
            this.panel_Movie.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 815);
            this.Controls.Add(this.panel_Movie);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cinemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieListToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Movie;
    }
}

