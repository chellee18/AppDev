using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THA_WEEK7_Michelle_P
{
    public partial class Movie : Form
    {
        public Movie()
        {
            InitializeComponent();
        }

        private void Movie_Load(object sender, EventArgs e)
        {
            //ALIVE
            PictureBox alive = new PictureBox();
            alive.Image = Image.FromFile("C:\\Users\\Michelle\\source\\repos\\THA_WEEK7_Michelle_P\\alive.jpg");
            alive.Location = new Point(40, 10);
            alive.Size = new Size(100, 150);
            alive.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(alive);

            Button btnalive = new Button();
            btnalive.Text = "SCHEDULE";
            btnalive.Location = new Point(52, 187);
            btnalive.Size = new Size(75, 23);
            this.Controls.Add(btnalive);
            btnalive.Click += Btnalive_Click;

            Label lblalive = new Label();
            lblalive.Text = "ALIVE";
            lblalive.Location = new Point(70, 170);
            lblalive.Size = new Size(100, 40);
            this.Controls.Add(lblalive);


            //CIVIL WAR
            PictureBox civilwar = new PictureBox();
            civilwar.Image = Image.FromFile("C:\\Users\\Michelle\\source\\repos\\THA_WEEK7_Michelle_P\\civilwar.jpg");
            civilwar.Location = new Point(190, 10);
            civilwar.Size = new Size(100, 150);
            civilwar.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(civilwar);

            Button btncivil = new Button();
            btncivil.Text = "SCHEDULE";
            btncivil.Location = new Point(203, 187);
            btncivil.Size = new Size(75, 23);
            this.Controls.Add(btncivil);
            btncivil.Click += Btncivil_Click;


            Label lblcivil = new Label();
            lblcivil.Text = "CIVIL WAR";
            lblcivil.Location = new Point(210, 170);
            lblcivil.Size = new Size(100, 40);
            this.Controls.Add(lblcivil);


            //END GAME
            PictureBox endgame = new PictureBox();
            endgame.Image = Image.FromFile("C:\\Users\\Michelle\\source\\repos\\THA_WEEK7_Michelle_P\\endgame.jpg");
            endgame.Location = new Point(340, 10);
            endgame.Size = new Size(100, 150);
            endgame.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(endgame);

            Button btnendgame = new Button();
            btnendgame.Text = "SCHEDULE";
            btnendgame.Location = new Point(353, 187);
            btnendgame.Size = new Size(75, 23);
            this.Controls.Add(btnendgame);
            btnendgame.Click += Btnendgame_Click;

            Label lblendgame = new Label();
            lblendgame.Text = "AVENGERS: END GAME";
            lblendgame.Location = new Point(327, 170);
            lblendgame.Size = new Size(150, 40);
            this.Controls.Add(lblendgame);


            //EXIT
            PictureBox exit = new PictureBox();
            exit.Image = Image.FromFile("C:\\Users\\Michelle\\source\\repos\\THA_WEEK7_Michelle_P\\exit.jpg");
            exit.Location = new Point(490, 10);
            exit.Size = new Size(100, 150);
            exit.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(exit);

            Button btnexit = new Button();
            btnexit.Text = "SCHEDULE";
            btnexit.Location = new Point(503, 187);
            btnexit.Size = new Size(75, 23);
            this.Controls.Add(btnexit);
            btnexit.Click += Btnexit_Click;

            Label lblexit = new Label();
            lblexit.Text = "EXIT";
            lblexit.Location = new Point(525, 170);
            lblexit.Size = new Size(150, 40);
            this.Controls.Add(lblexit);



            //FAR FROM HOME
            PictureBox farfhome = new PictureBox();
            farfhome.Image = Image.FromFile("C:\\Users\\Michelle\\source\\repos\\THA_WEEK7_Michelle_P\\farfromhome.jpg");
            farfhome.Location = new Point(40, 220);
            farfhome.Size = new Size(100, 150);
            farfhome.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(farfhome);

            Button btnfarfhome = new Button();
            btnfarfhome.Text = "SCHEDULE";
            btnfarfhome.Location = new Point(52, 397);
            btnfarfhome.Size = new Size(75, 23);
            this.Controls.Add(btnfarfhome);
            btnfarfhome.Click += Btnfarfhome_Click;

            Label lblfarfhome = new Label();
            lblfarfhome.Text = "FAR FROM HOME";
            lblfarfhome.Location = new Point(43, 380);
            lblfarfhome.Size = new Size(150, 40);
            this.Controls.Add(lblfarfhome);



            //HOME COMING
            PictureBox homecoming = new PictureBox();
            homecoming.Image = Image.FromFile("C:\\Users\\Michelle\\source\\repos\\THA_WEEK7_Michelle_P\\homecoming.jpg");
            homecoming.Location = new Point(190, 220);
            homecoming.Size = new Size(100, 150);
            homecoming.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(homecoming);

            Button btnhomecoming = new Button();
            btnhomecoming.Text = "SCHEDULE";
            btnhomecoming.Location = new Point(204, 397);
            btnhomecoming.Size = new Size(75, 23);
            this.Controls.Add(btnhomecoming);
            btnhomecoming.Click += Btnhomecoming_Click;

            Label lblhomecoming = new Label();
            lblhomecoming.Text = "HOME COMING";
            lblhomecoming.Location = new Point(199, 380);
            lblhomecoming.Size = new Size(150, 40);
            this.Controls.Add(lblhomecoming);


            //IRON MAN 3
            PictureBox ironman = new PictureBox();
            ironman.Image = Image.FromFile("C:\\Users\\Michelle\\source\\repos\\THA_WEEK7_Michelle_P\\ironman3.jpg");
            ironman.Location = new Point(340, 220);
            ironman.Size = new Size(100, 150);
            ironman.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(ironman);

            Button btnironman = new Button();
            btnironman.Text = "SCHEDULE";
            btnironman.Location = new Point(353, 397);
            btnironman.Size = new Size(75, 23);
            this.Controls.Add(btnironman);
            btnironman.Click += Btnironman_Click;

            Label lblironman = new Label();
            lblironman.Text = "IRON MAN 3";
            lblironman.Location = new Point(355, 380);
            lblironman.Size = new Size(145, 40);
            this.Controls.Add(lblironman);


            //THE BOX
            PictureBox thebox = new PictureBox();
            thebox.Image = Image.FromFile("C:\\Users\\Michelle\\source\\repos\\THA_WEEK7_Michelle_P\\thebox.jpeg");
            thebox.Location = new Point(490, 220);
            thebox.Size = new Size(100, 150);
            thebox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Controls.Add(thebox);

            Button btnthebox = new Button();
            btnthebox.Text = "SCHEDULE";
            btnthebox.Location = new Point(501, 397);
            btnthebox.Size = new Size(75, 23);
            this.Controls.Add(btnthebox);
            btnthebox.Click += Btnthebox_Click;

            Label lblthebox = new Label();
            lblthebox.Text = "THE BOX";
            lblthebox.Location = new Point(510, 380);
            lblthebox.Size = new Size(150, 40);
            this.Controls.Add(lblthebox);

        }

        private void Btnalive_Click(object sender, EventArgs e)
        {
            ALIVE alive = new ALIVE();
            alive.Show();
        }

        private void Btncivil_Click(object sender, EventArgs e)
        {
            CIVILWAR civilwar = new CIVILWAR();
            civilwar.Show();

        }

        private void Btnendgame_Click(object sender, EventArgs e)
        {
            ENDGAME endgame = new ENDGAME();
            endgame.Show();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            EXIT exit = new EXIT();
            exit.Show();
        }

        private void Btnfarfhome_Click(object sender, EventArgs e)
        {
            FARFHOME farfhome = new FARFHOME();
            farfhome.Show();
        }

        private void Btnhomecoming_Click(object sender, EventArgs e)
        {
            HOMECOMING homecoming = new HOMECOMING();
            homecoming.Show();
        }

        private void Btnironman_Click(object sender, EventArgs e)
        {
            IRONMAN ironman = new IRONMAN();
            ironman.Show();
        }

        private void Btnthebox_Click(object sender, EventArgs e)
        {
            THEBOX thebox = new THEBOX();
            thebox.Show();
        }

        

        

        

        

       

        

        
    }
}
