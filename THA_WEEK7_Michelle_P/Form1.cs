using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_WEEK7_Michelle_P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void movieListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.TopLevel= false;
            movie.AutoScroll = true;
            panel_Movie.Controls.Add(movie);
            movie.AutoSize = true;
            movie.Show();
        }
    }
}
