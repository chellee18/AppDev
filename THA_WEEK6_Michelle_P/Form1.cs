using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_WEEK6_Michelle_P
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int num = 0;
        private void btn_Play_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt_Isi.Text);
            if (txt_Isi.Text == "" || x <= 3) 
            {
                MessageBox.Show("Harus di atas 3");
            }
            else
            {
                btn_Delete form2= new btn_Delete();
                num = Convert.ToInt32(txt_Isi.Text);
                form2.Show();
            }
        }
    }
}
