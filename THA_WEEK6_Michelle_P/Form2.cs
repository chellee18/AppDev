using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_WEEK6_Michelle_P
{
    public partial class btn_Delete : Form
    {
        public btn_Delete()
        {
            InitializeComponent();
        }
        Form1 form = new Form1();

        int counter = 0;
        int counter2 = 5;
        int x = 0;
        int y = 0;
        int xy = 0;
        int m = 350;
        int n = 0;
        int kotak = 0;
        int guess, a, b = 0;
        string kata = "";
        List<Button> box = new List<Button>();
        List<Button> Kboard = new List<Button>();
        Button[,] button;
        public static List<String> huruf = new List<String>() { "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" };
        string[] answer = File.ReadAllText("Wordle Word List.txt").Split(',');
        string random;
        private void Form2_Load(object sender, EventArgs e)
        {
            for (int a = 0; a < Form1.num; a++)
            {
                for (int b = 0; b < 5; b++)
                {
                    Button button = new Button();
                    button.Location = new Point(6 + x, 6 + y);
                    button.Tag = "button" + xy;
                    button.Size = new Size(50, 50);
                    button.Click += button_Click;
                    button.BackColor = Color.Transparent;
                    box.Add(button);
                    xy++;
                    x += 50;
                }
                x = 0;
                y += 50;
            }

            foreach (Button i in box)
            {
                this.Controls.Add(i);
            }
            xy = 0;

            foreach (string j in huruf)
            {
                Button bt = new Button();
                bt.Tag = j;
                bt.Text = j.ToString();
                bt.Size = new Size(50, 50);
                bt.Location = new Point(m, n);

                Kboard.Add(bt);
                bt.Click += button_Click;
                this.Controls.Add(bt);
                m += 50;

                if (j == "P")
                {
                    m = 370;
                    n += 50;
                }
                else if (j == "L")
                {
                    m = 420;
                    n += 50;
                }
            }
        }

        private void btn_Delete1_Click(object sender, EventArgs e)
        {
            if (box[0].Text != "")
            {
                box[kotak - 1].Text = " ";
                kotak--;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;

            foreach (Button x in Kboard)
            {
                if (bt.Tag == x.Tag)
                {
                    if (counter < counter2)
                    {
                        box[counter].Text = x.Text;
                        counter++;
                    }
                }
            }
            kotak++;
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            int c = 0;
            if (counter < counter2)
            {
                MessageBox.Show("Harus diisi!");
            }
            else
            {
                for (int a = 0; a < x; a++)
                {
                    kata += button[a, y].Text;
                }
                if (answer.Contains(kata.ToLower()))
                {
                    for (int a = 0; a < x; a++)
                    {
                        if (random[a].ToString() == (button[a, y].Text))
                        {
                            button[a, y].BackColor = Color.Green;
                            c++;
                        }
                        else if (random.Contains(button[a, y].Text))
                        {
                            button[a, y].BackColor = Color.Yellow;
                        }
                        else
                        {
                            button[a, y].BackColor = Color.Black;
                        }
                    }
                    y++;
                    counter2 += 5;

                    if (c == 5)
                    {
                        MessageBox.Show("Anda menang!");
                    }
                    else if (c < 5 && y == guess)
                    {
                        MessageBox.Show("Anda Kalah! Jawaban yang benar adalah " + random);
                    }
                }
                else
                {
                    MessageBox.Show("Kata tidak ditemukan!");
                }
            }
        }
    }
}

        

