using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
            conn.Open();
            string sqlquery = "Select team.team_name from team";
            MySqlCommand cmd = new MySqlCommand(sqlquery, conn);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string name = dr.GetString(0);
                cboxhome.Items.Add(name);
                cboxhome.SelectedIndex = 0;
                cboxaway.Items.Add(name);
                cboxaway.SelectedIndex = 0;

            }
            cmd.Dispose();
            dr.Close();
            conn.Close();
        }

        private void cboxhome_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;database=premier_league;user=root;password=");
            con.Open();
            string datasql = "select team.team_name,team.home_stadium,team.capacity,manager.manager_name,player.player_name from team inner join manager on team.manager_id=manager.manager_id inner join player on team.captain_id=player.player_id where team.team_name='" + cboxhome.SelectedItem + "'";
            MySqlCommand cmd = new MySqlCommand(datasql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(0);
                string stadium = reader.GetString(1);
                int capacity = reader.GetInt32(2);
                string manager = reader.GetString(3);
                string captain = reader.GetString(4);

                lblmanager1.Text = "Manager : " + manager;
                lblcaptain1.Text = "Captain : " + captain;
                lblstadium.Text = "Stadium : " + stadium;
                lblcapacity.Text = "Capacity : " + capacity;
            }
            cmd.Dispose();
            reader.Close();
            con.Close();
        }

        private void cboxaway_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;database=premier_league;user=root;password=");
            con.Open();
            string datasql = "select team.team_name,team.home_stadium,team.capacity,manager.manager_name,player.player_name from team inner join manager on team.manager_id=manager.manager_id inner join player on team.captain_id=player.player_id where team.team_name='" + cboxaway.SelectedItem + "'";
            MySqlCommand cmd = new MySqlCommand(datasql, con);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string name = reader.GetString(0);
                string manager = reader.GetString(3);
                string captain = reader.GetString(4);

                lblmanager2.Text = "Manager : " + manager;
                lblcaptain2.Text = "Captain : " + captain;
            }
            cmd.Dispose();
            reader.Close();
            con.Close();
        }

        private void lblcapacity_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }
    }
}
