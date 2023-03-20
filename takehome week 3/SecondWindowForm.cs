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
    public partial class SecondWindowForm : Form
    {
        public static SecondWindowForm Instance;
        public Label label;
        bool value = false;
        public SecondWindowForm()
        {
           
            InitializeComponent();
            Instance = this;
            label = label_NameArtist;
        }

        private void checkBox_Choice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Choice.Checked)
            {
                if (checkBox_Agree.Checked)
                {
                    btn_Magic.Enabled = true;
                }
                else
                {
                    btn_Magic.Enabled = false;
                }
            }
            else
            {
                btn_Magic.Enabled = false;
            }


        }

        private void btn_Magic_Click(object sender, EventArgs e)
        {
            if (!radioButtonRed.Checked && !radioButtonBlue.Checked  && !radioButtonPink.Checked && !radioButtonPurple.Checked && !radioButtonBrown.Checked && !radioButtonYellow.Checked && !radioButtonGreen.Checked && !radioButtonGray.Checked)
            {
                string errortext = "1 Radio Button must be checked";
                MessageBox.Show(errortext, "Radio Button Empty",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else  
            {
                if (radioButtonRed.Checked)
                {
                    Form1.form1.BackColor = Color.Red;
                }

                if (radioButtonBlue.Checked)
                {
                    Form1.form1.BackColor = Color.Blue;
                }

                if (radioButtonPink.Checked)
                {
                    Form1.form1.BackColor = Color.Pink;
                }

                if (radioButtonPurple.Checked)
                {
                    Form1.form1.BackColor = Color.Purple;
                }

                if (radioButtonBrown.Checked)
                {
                    Form1.form1.BackColor = Color.Brown;
                }

                if (radioButtonYellow.Checked)
                {
                    Form1.form1.ForeColor = Color.Yellow;
                }

                if (radioButtonGreen.Checked)
                {
                    Form1.form1.ForeColor = Color.Green;
                }

                if (radioButtonGray.Checked)
                {
                    Form1.form1.ForeColor = Color.Gray;
                }
            }

            

            
        }
    }
}
