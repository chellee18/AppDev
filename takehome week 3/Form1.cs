using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace takehome_week_3
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        public Form1()
        {
            InitializeComponent();
            form1 = this;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            SecondWindowForm formNew = new SecondWindowForm();
            formNew.Show();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                string errortext1 = "Please input name";
                MessageBox.Show(errortext1, "Name doesn't exist",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
            if (txt_Artist.Text == "")
            {
                string errortext2 = "Please input artist";
                MessageBox.Show(errortext2, "Artist name doesn't exist",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            SecondWindowForm.Instance.label.Text = "Hi, my name is " + txt_Name.Text + " and my favorite artist is " + txt_Artist.Text;
        }

        private void checkBox_Content_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<SecondWindowForm>().Any() && checkBox_Content.Checked)
            {
                btn_Submit.Enabled = true;
            }
            else
            {
                btn_Submit.Enabled = false;
            }
        }
    }
}
