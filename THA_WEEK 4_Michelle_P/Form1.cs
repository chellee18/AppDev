using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static THA_WEEK_4_Michelle_P.Form1;

namespace THA_WEEK_4_Michelle_P
{
    public partial class Form1 : Form
    {
        string chooseplayer = "";
        public Form1()
        {
            InitializeComponent();
        }

        public class Team
        {
            private string teamName;
            private string teamCountry;
            private string teamCity;
            public List<Player> players = new List<Player>();

            public string TeamName
            {
                get { return teamName; }
                set { teamName = value; }
            }

            public string TeamCountry
            {
                get { return teamCountry; }
                set { teamCountry = value; }
            }

            public string TeamCity
            {
                get { return teamCity; }
                set { teamCity = value; }
            }

            public void add(Player a)
            {
                players.Add(a);
            }
        }

        public class Player
        {
            private string playerName;
            private string playerNum;
            private string playerPos;

            public string PlayerName
            {
                get { return playerName; }
                set { playerName = value; }
            }

            public string PlayerNum
            {
                get { return playerNum; }
                set { playerNum = value; }
            }

            public string PlayerPos
            {
                get { return playerPos; }
                set { playerPos = value; }
            }
        }

        int count = 0;
        string Country1 = "";
        string Team1 = "";


        public void AddCountry()
        {
            cmb_Country.Items.Clear();
            foreach (Team p in myteam)
            {
                if (!cmb_Country.Items.Contains(p.TeamCountry))
                {
                    cmb_Country.Items.Add(p.TeamCountry);
                }
            }
        }

        public void AddTeam()
        {
            cmb_Team.Items.Clear();
            foreach (Team p in myteam)
            {
                if (p.TeamCountry == Country1)
                {
                    cmb_Team.Items.Add(p.TeamName);
                }
            }
        }

        public void AddPlayer()
        {
            listBox_Player.Items.Clear();
            foreach (Team p in myteam)
            {
                if (p.TeamName == Team1 && p.TeamCountry == Country1)
                {
                    foreach (Player players in p.players)
                    {
                        listBox_Player.Items.Add($"({players.PlayerNum}) {players.PlayerName}, {players.PlayerPos}");
                    }
                }
            }
        }

        private void cmb_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country1 = cmb_Country.SelectedItem.ToString();
            AddTeam();
        }

        private void cmb_Team_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Team1 = cmb_Team.SelectedItem.ToString();
            AddPlayer();
        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {
            if (txt_TeamName.Text == "" || txt_TeamCountry.Text == "" || txt_TeamName.Text == "")
            {
                string errortext1 = "All Fields Need to be Filled";
                MessageBox.Show(errortext1, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                count = 0;
                foreach (string p in listBox_Player.Items)
                {
                    if (p == ($"({txt_TeamName.Text}) {txt_TeamCountry.Text}, {txt_TeamCity}"))
                    {
                        count = 1;
                    }
                }
                if (count == 1)
                {
                    MessageBox.Show("Team has existed");
                }
                else
                {
                    foreach (Team p in myteam)
                    {
                        if (p.TeamName == Team1 && p.TeamCountry == Country1)
                        {
                            Team team1 = new Team();
                            team1.TeamName = txt_TeamName.Text;
                            team1.TeamCountry = txt_PlayerNum.Text;
                            team1.TeamCity = txt_TeamCity.Text;
                            myteam.Add(team1);
                        }
                    }
                    txt_TeamName.Clear();
                    txt_TeamCountry.Clear();
                    txt_TeamCity.Clear();
                    AddCountry();
                    AddTeam();
                }
            }
        }

        private void btn_Add2_Click_1(object sender, EventArgs e)
        {
            if (txt_PlayerName.Text == "" || txt_PlayerNum.Text == "" || cmb_Position.Text == "")
            {
                string errortext2 = "All Fields Need to be Filled";
                MessageBox.Show(errortext2, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (cmb_Team.SelectedItem == null)
                {
                    MessageBox.Show("Please choose team");
                }
                else
                {
                    count = 0;
                    foreach (string p in listBox_Player.Items)
                    {
                        if (p == ($"({txt_PlayerNum.Text}) {txt_PlayerName.Text}, {cmb_Position.SelectedItem.ToString()}"))
                        {
                            count = 1;
                        }
                    }
                    if (count == 1)
                    {
                        MessageBox.Show("Player has existed");
                    }
                    else
                    {
                        foreach (Team p in myteam)
                        {
                            if (p.TeamName == Team1 && p.TeamCountry == Country1)
                            {
                                Player players = new Player();
                                players.PlayerName = txt_PlayerName.Text;
                                players.PlayerNum = txt_PlayerNum.Text;
                                players.PlayerPos = cmb_Position.SelectedItem.ToString();
                                p.add(players);
                            }
                        }
                    }
                    txt_PlayerName.Clear();
                    txt_PlayerNum.Clear();
                    cmb_Position.Text = null;
                    AddPlayer();
                }
            }
        }

        List<Team> myteam = new List<Team>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Team tim = new Team();
            tim.TeamName = "Barca";
            tim.TeamCountry = "Spain";
            tim.TeamCity = "Barcelona";
            String[] NameBC = {"Marc-Andre Ter Stegen", "Hector Bellerin" , "Gerard Pique", "Ronald Araujo", "Sergio Busquets",
            "Ousmane Dembele", "Pedri", "Robert Lewandowski", "Ansu Fati", "Ferran Torres" , "Gavi"};
            String[] NumBC = { "01", "02", "03", "04", "05", "07", "08", "09", "10", "11", "30" };
            String[] PosBC = { "GK", "DF", "DF", "DF", "MF", "FW", "MF", "FW", "FW", "FW", "MF" };
            for (int x = 0; x < 11; x++)
            {
                Player players = new Player();
                players.PlayerName = NameBC[x];
                players.PlayerNum = NumBC[x];
                players.PlayerPos = PosBC[x];
                tim.add(players);
            }
            myteam.Add(tim);

            tim = new Team();
            tim.TeamName = "Real Betis";
            tim.TeamCountry = "Spain";
            tim.TeamCity = "Seville";
            String[] PlayerRB = {"Claudio Bravo", "Martin Montoya", "Edgar Gonzalez", "Paul Akouokou", "Guido Rodriguez",
            "Victor Ruiz", "Juanmi", "Nabil Fekir", "Borja Iglesias", "Sergio Canales", "Luiz Henrique"};
            String[] NumRB = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11" };
            String[] PosRB = { "GK", "DF", "DF", "MF", "MF", "DF", "FW", "MF", "FW", "MF", "FW" };
            for (int x = 0; x < 11; x++)
            {
                Player players = new Player();
                players.PlayerName = PlayerRB[x];
                players.PlayerNum = NumRB[x];
                players.PlayerPos = PosRB[x];
                tim.add(players);
            }
            myteam.Add(tim);

            tim = new Team();
            tim.TeamName = "Paris Saint-Germain";
            tim.TeamCountry = "France";
            tim.TeamCity = "Paris";
            String[] PlayerPSG = {"Keylor Navas", "Achraf Hakimi", "Presnel Kimpembe", "Sergio Ramos", "Marquinhos",
            "Marco Verratti", "Kylian Mbappe", "Fabian Ruiz", "Mauro Icardi", "Neymar", "Lionel Messi"};
            String[] NumPSG = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "30" };
            String[] PosPSG = { "GK", "DF", "DF", "DF", "DF", "MF", "FW", "MF", "FW", "FW", "FW" };
            for (int x = 0; x < 11; x++)
            {
                Player players = new Player();
                players.PlayerName = PlayerPSG[x];
                players.PlayerNum = NumPSG[x];
                players.PlayerPos = PosPSG[x];
                tim.add(players);
            }
            myteam.Add(tim);
            AddCountry();
        }

        private void btn_Remove_Click_1(object sender, EventArgs e)
        {
            if (listBox_Player.Items.Count <= 11)
            {
                MessageBox.Show("Unable to remove players if players less than equal 11");
            }
            else
            {
                foreach (Team p in myteam)
                {
                    if (p.TeamName == cmb_Team.Text)
                    {
                        foreach (Player player in p.players)
                        {
                            if (listBox_Player.SelectedItem.ToString().Contains(player.PlayerName))
                            {
                                p.players.Remove(player);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}

        
