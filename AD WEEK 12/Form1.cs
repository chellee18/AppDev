using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;


namespace AD_WEEK_12
{
    public partial class Form1 : Form
    {
        string ConnectionString = "server=127.0.0.1;uid=root;pwd=Michelle18112004;database=premier_league";

        public Form1()
        {
            sqlConnect = new MySqlConnection(ConnectionString);
            InitializeComponent();
            dgv1.DataSource = DataManager;
            dgv2.DataSource = DataMatch;

            dtp_birthdate.CustomFormat = "yyyy-MM-dd";
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlDataAdapter;
        MySqlDataReader sqlDataReader;
        string sqlQuery;
        DataTable DataTeam = new DataTable();
        DataTable DataTeam1 = new DataTable();
        DataTable DataNation = new DataTable();
        DataTable DataMatch = new DataTable();
        DataTable DataMatch1 = new DataTable();
        DataTable DataManager = new DataTable();
        DataTable Data = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            updatedgv();
            sqlConnect.Open();
            sqlQuery = "select nation, nationality_id from nationality";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(DataNation);
            cmb_nation.DataSource = DataNation;
            cmb_nation.DisplayMember = "nation";
            cmb_nation.ValueMember = "nationality_id";

            sqlQuery = "select team_name, team_id from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(DataTeam1);
            cmb_teamname.DataSource = DataTeam1;
            cmb_teamname.DisplayMember = "team_name";
            cmb_teamname.ValueMember = "team_id";

            sqlQuery = "select team_name, team_id from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            DataTeam.Clear();
            sqlDataAdapter.Fill(DataTeam);
            cmb_team.DataSource = DataTeam;
            cmb_team.DisplayMember = "team_name";
            cmb_team.ValueMember = "team_id";

            sqlQuery = "select team_name, team_id from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            DataTeam.Clear();
            sqlDataAdapter.Fill(Data);
            cmb_team2.DataSource = Data;
            cmb_team2.DisplayMember = "team_name";
            cmb_team2.ValueMember = "team_id";

            sqlQuery = $"select player_name, nation, playing_pos, team_number, height, weight, birthdate from player p, nationality n where p.nationality_id = n.nationality_id and p.team_id = '{cmb_team2.SelectedValue.ToString()}' and status = 1; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(DataTeam);
            dgv3.DataSource = DataTeam;

        }

        private void updatedgv()
        {
            sqlQuery = $"SELECT manager_id, manager_name, n.nation, m.birthdate FROM manager m, nationality n where m.nationality_id = n.nationality_id and m.working = 0;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(DataManager);
            dgv2.DataSource = DataManager;

            sqlQuery = $"SELECT m.manager_id, m.manager_name, n.nation as nation, m.birthdate FROM manager m, team t, nationality n where m.manager_id = t.manager_id and m.nationality_id = n.nationality_id and t.team_id = '" + cmb_team.SelectedValue + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(DataMatch);
            dgv1.DataSource = DataMatch;

        }

        private void btn_addplayer_Click(object sender, EventArgs e)
        {
            string name = txt_name.Text;
            string number = txt_teamnum.Text;
            string nation = cmb_nation.SelectedValue.ToString();
            string pos = cmb_pos.Text;
            string height = txt_height.Text;
            string weight = txt_weight.Text;
            string birthdate = dtp_birthdate.Text;
            string teamname = cmb_teamname.SelectedValue.ToString();
            string playerid = txt_playerid.Text;

            MessageBox.Show(txt_playerid.Text.ToString());
            sqlQuery = $"insert into player values ('{playerid}', '{number}', '{name}', '{nation}', '{pos}', '{height}', '{weight}', '{birthdate}', '{teamname}', 1, 0);";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(DataMatch1);
            dgv3.DataSource = DataMatch1;


            //try
            //{
            //    sqlConnect.Open();
            //    sqlCommand = new MySqlCommand(insert, sqlConnect);
            //    sqlDataReader = sqlCommand.ExecuteReader();
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //finally
            //{
            //    sqlConnect.Close();
            //    updatedgv();
            //}
        }

        private void cmb_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTeam = new DataTable();
            updatedgv();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (DataMatch1.Rows.Count <= 11)
            {
                MessageBox.Show("Error");
            }
            else
            {
                string command = $"update player set status = '0' where player_id = '{txt_playerid}';";
                try
                {
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(command, sqlConnect);
                    sqlDataReader = sqlCommand.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(command, ex.Message);

                }
                finally
                {
                    sqlConnect.Close();
                }
                DataMatch1.Clear();
                sqlQuery = $"select p.player_id,p.player_name,n.nation,p.playing_pos,p.team_number, p.height, p.weight, p.birthdate, p.status from player p,nationality n where p.team_id = '{cmb_team2.SelectedValue.ToString()}' and n.nationality_id = p.nationality_id and p.status = '1';";
                sqlConnect = new MySqlConnection(ConnectionString);
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                sqlDataAdapter.Fill(DataMatch1);
                dgv3.DataSource = DataMatch1;
            }
        }

        private void cmb_team2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTeam = new DataTable();
            sqlQuery = $"select player_name, nation, playing_pos, team_number, height, weight, birthdate from player p, nationality n where p.nationality_id = n.nationality_id and p.team_id = '{cmb_team2.SelectedValue.ToString()}' and status = 1; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(DataTeam);
            dgv3.DataSource = DataTeam;
        }
    }
}
