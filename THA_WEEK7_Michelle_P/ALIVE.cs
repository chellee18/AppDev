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
    public partial class ALIVE : Form
    {
        public ALIVE()
        {
            InitializeComponent();
        }

        List<Button> jadwalfilm1 = new List<Button>();
        List<Button> jadwalfilm2 = new List<Button>();
        List<Button> jadwalfilm3 = new List<Button>();
        int x = 0;
        int y = 0;
        int xy = 0;
        int ab = 0;
        Panel panelseat = new Panel();
        Label seat = new Label();
        Random seat1 = new Random();

        private void ALIVE_Load(object sender, EventArgs e)
        {
            PictureBox alive = new PictureBox();
            alive.Image = Image.FromFile("C:\\Users\\Michelle\\source\\repos\\THA_WEEK7_Michelle_P\\alive.jpg");
            alive.Location = new Point(35, 70);
            alive.Size = new Size(200, 300);
            alive.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(alive);

            Label lblalive = new Label();
            lblalive.Text = "ALIVE";
            lblalive.Location = new Point(115, 50);
            lblalive.Size = new Size(100, 40);
            this.Controls.Add(lblalive);

            Button jadwal1 = new Button();
            jadwal1.Text = "11.00";
            jadwal1.Location = new Point(250, 255);
            jadwal1.Size = new Size(70, 23);
            this.Controls.Add(jadwal1);
            jadwal1.Click += Jadwal1_Click;

            Button jadwal2 = new Button();
            jadwal2.Text = "14.00";
            jadwal2.Location = new Point(250, 295);
            jadwal2.Size = new Size(70, 23);
            this.Controls.Add(jadwal2);
            jadwal2.Click += Jadwal2_Click;

            Button jadwal3 = new Button();
            jadwal3.Text = "19.00";
            jadwal3.Location = new Point(250, 335);
            jadwal3.Size = new Size(70, 23);
            this.Controls.Add(jadwal3);
            jadwal3.Click += Jadwal3_Click;

            Button back = new Button();
            back.Text = "BACK";
            back.Location = new Point(500, 10);
            back.Size = new Size(55, 30);
            back.BackColor = Color.White;
            this.Controls.Add(back);
            back.Click += Back_Click;

            panelseat.Location = new Point(370, 105);
            panelseat.Size = new Size(300, 300);
            panelseat.BackColor = Color.Khaki;
            panelseat.TabIndex = 0;
            this.Controls.Add(panelseat);

            seat.Text = "PLEASE CHOOSE YOUR SEAT";
            seat.Location = new Point(440, 85);
            seat.Size = new Size(200, 50);
            this.Controls.Add(seat);

            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    Button button1 = new Button();
                    button1.Tag = b.ToString() + "," + a.ToString();
                    button1.Location = new Point(2 + x, 2 + y);
                    button1.Size = new Size(25, 25);
                    button1.Click += Button1_Click;
                    button1.BackColor = Color.Transparent;
                    jadwalfilm1.Add(button1);
                    xy++;
                    y += 27;
                    panelseat.Controls.Add(button1);
                }
                y = 0;
                x += 25;
            }

            for (int i = 0; i < 0; i++)
            {
                panelseat.Controls.Clear();
                int random = seat1.Next(0, 100);
                jadwalfilm1[random].BackColor = Color.Yellow;
                jadwalfilm1[random].Enabled = false;
            }

            x = 0;
            y = 0;
            panelseat.Controls.Clear();
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    Button button2 = new Button();
                    button2.Tag = b.ToString() + "," + a.ToString();
                    button2.Location = new Point(2 + x, 2 + y);
                    button2.Size = new Size(25, 25);
                    button2.Click += Button2_Click;
                    button2.BackColor = Color.Transparent;
                    jadwalfilm2.Add(button2);
                    xy++;
                    y += 27;
                    panelseat.Controls.Add(button2);
                }
                y = 0;
                x += 25;
            }

            for (int i = 0; i < 0; i++)
            {
                panelseat.Controls.Clear();
                int random = seat1.Next(0, 100);
                jadwalfilm2[random].BackColor = Color.Yellow;
                jadwalfilm2[random].Enabled = false;
            }

            x= 0;
            y = 0;
            panelseat.Controls.Clear();
            for (int a = 0; a < 10; a++)
            {
                for (int b = 0; b < 10; b++)
                {
                    Button button3 = new Button();
                    button3.Tag = b.ToString() + "," + a.ToString();
                    button3.Location = new Point(2 + x, 2 + y);
                    button3.Size = new Size(25, 25);
                    button3.Click += Button3_Click;
                    button3.BackColor = Color.Transparent;
                    jadwalfilm3.Add(button3);
                    xy++;
                    y += 27;
                    panelseat.Controls.Add(button3);
                }
                y = 0;
                x += 25;
            }

            for (int i = 0; i < 0; i++)
            {
                panelseat.Controls.Clear();
                int random = seat1.Next(0, 100);
                jadwalfilm3[random].BackColor = Color.Yellow;
                jadwalfilm3[random].Enabled = false;
            }


        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Jadwal1_Click(object sender, EventArgs e)
        {
            panelseat.Controls.Clear();
            ab = 14;
            foreach (Button j in jadwalfilm1)
            {
                panelseat.Controls.Add(j);
            }
        }

        private void Jadwal2_Click(object sender, EventArgs e)
        {
            panelseat.Controls.Clear();
            ab = 14;
            foreach (Button j in jadwalfilm2)
            {
                panelseat.Controls.Add(j);
            }
        }

        private void Jadwal3_Click(object sender, EventArgs e)
        {
            panelseat.Controls.Clear();
            ab = 14;
            foreach (Button j in jadwalfilm3)
            {
                panelseat.Controls.Add(j);
            }
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            panelseat.Controls.Clear();
            foreach (Button j in jadwalfilm1)
            {
                panelseat.Controls.Add(j);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.Transparent)
            {
                button.BackColor = Color.Red;
                seat.Text += button.Tag.ToString() + "|";
            }
            MessageBox.Show("You choose: " + button.Tag.ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            panelseat.Controls.Clear();
            foreach (Button j in jadwalfilm2)
            {
                panelseat.Controls.Add(j);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.Transparent)
            {
                button.BackColor = Color.Red;
                seat.Text += button.Tag.ToString() + "|";
            }
            MessageBox.Show("You choose: " + button.Tag.ToString());
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            panelseat.Controls.Clear();
            foreach (Button j in jadwalfilm3)
            {
                panelseat.Controls.Add(j);
            }
            Button button = sender as Button;
            if (button.BackColor == Color.Transparent)
            {
                button.BackColor = Color.Red;
                seat.Text += button.Tag.ToString() + "|";
            }
            MessageBox.Show("You choose: " + button.Tag.ToString());
        }
    }
}
