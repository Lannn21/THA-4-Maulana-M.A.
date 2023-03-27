using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testes
{
    public partial class Form1 : Form
    {
        public List<Team> teamlist = new List<Team>();
        public Form1()
        {
            InitializeComponent();
            Tim timbola = new Tim();
            teamlist.Add(timbola.Liverpool());
            teamlist.Add(timbola.ManCity());
            teamlist.Add(timbola.Persebaya());
            updator();
        }

        private void lbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addtem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txttmname.Text) && string.IsNullOrEmpty(txttmcntry.Text) &&
               string.IsNullOrEmpty(txttmcity.Text))
            {
                MessageBox.Show("Teks harus diisi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Team team = new Team();
                team.teamName = txttmname.Text;
                team.teamCity = txttmcity.Text;
                team.teamCountry = txttmcntry.Text;
                team.Playerlist = new List<Player>();
                teamlist.Add(team);

                //clear
                txttmname.Clear();
                txttmcntry.Clear();
                txttmcity.Clear();
                updator();
            }
        }
        private void Choosing(object sender, EventArgs e)
        {
            Playerup();
        }
        private void cosingcont(object sender, EventArgs e)
        {
            updatorr();
        }
        private async void updator()
        {
            cmbcntry.Items.Clear();
            foreach (Team x in teamlist)
            {
                if (cmbcntry.Items.Contains(x.teamCountry))
                {

                }
                else
                {
                    cmbcntry.Items.Add(x.teamCountry);
                }
            }
        }
        private void Playerup()
        {
            Leest.Items.Clear();
            {
                foreach (Team x in teamlist)
                {
                    if (x.teamName == cmbteam.SelectedItem.ToString())
                    {
                        foreach (Player y in x.Playerlist)
                        {
                            Leest.Items.Add($"[{y.playerNumber}] {y.playerName}, {y.playerPos}");
                            Leest.Sorted = true;
                            Leest.Sorted = false;
                        }
                    }
                }
            }

        }
        private async void updatorr()
        {
            cmbteam.Items.Clear();
            foreach (Team a in teamlist)
            {
                if (a.teamCountry == cmbcntry.SelectedItem.ToString())
                {
                    cmbteam.Items.Add(a.teamName);
                }
            }

        }

        private void cmbcntry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void remove_Click(object sender, EventArgs e)
        {

        }
    }
    public class Tim
    {
        public Team Liverpool()
        {
            Team teamvar = new Team();
            teamvar.teamName = "Liverpool";
            teamvar.teamCity = "Anfield";
            teamvar.teamCountry = "England";
            teamvar.Playerlist = new List<Player>();
            string[] players = { "Alisson Becker", "Joe Gomez", "Fabinho", "Virgil van Dijk", "Ibrahima Konaté", "Thiago Alcântara", "James Milner", "Naby Keïta", "Roberto Firmino", "Mohamed Salah", "Adrián" };
            string[] number = { "01", "02", "03", "04", "05", "06", "07", "08", "09", "11", "13" };
            string[] pos = { "GK", "DF", "MF", "DF", "DF", "MF", "MF", "MF", "FW", "FW", "GK" };
            for (int i = 0; i < players.Length; i++)
            {
                Player player = new Player();
                player.playerName = players[i];
                player.playerNumber = number[i];
                player.playerPos = pos[i];
                teamvar.Playerlist.Add(player);
            }
            return teamvar;
        }
        public Team ManCity()
        {
            Team teamvar = new Team();
            teamvar.teamName = "Manchester City";
            teamvar.teamCity = "Gorton";
            teamvar.teamCountry = "England";
            teamvar.Playerlist = new List<Player>();
            string[] players = { "Kyle Walker", "Rúben Dias", "Kalvin Phillips", "John Stones", "Nathan Aké", "İlkay Gündoğan", "Erling Haaland", "Jack Grealish", "Aymeric Laporte", "Rodri", "Kevin De Bruyne" };
            string[] number = { "02", "03", "04", "05", "06", "08", "09", "10", "14", "16", "17" };
            string[] pos = { "DF", "DF", "MF", "DF", "DF", "MF", "FW", "MF", "DF", "MF", "MF" };
            for (int i = 0; i < players.Length; i++)
            {
                Player player = new Player();
                player.playerName = players[i];
                player.playerNumber = number[i];
                player.playerPos = pos[i];
                teamvar.Playerlist.Add(player);
            }
            return teamvar;
        }
        public Team Persebaya()
        {
            Team teamvar = new Team();
            teamvar.teamName = "Persebaya";
            teamvar.teamCity = "Surabaya";
            teamvar.teamCountry = "Indonesia";
            teamvar.Playerlist = new List<Player>();
            string[] players = { "Léo Lelis", "Muhammad Iqbal", "Andre Oktaviansyah", "Paulo Victor", "Zé Valente", "Mochammad Supriadi", "Bramdani", "Sho Yamamoto", "George Brown", "Ahmad Nufiandani", "Brylian Aldama" };
            string[] number = { "04", "06", "08", "09", "11", "13", "14", "16", "17", "18", "21" };
            string[] pos = { "DF", "MP", "MF", "FW", "MF", "MF", "MF", "MF", "DF", "MF", "MF" };
            for (int i = 0; i < players.Length; i++)
            {
                Player player = new Player();
                player.playerName = players[i];
                player.playerNumber = number[i];
                player.playerPos = pos[i];
                teamvar.Playerlist.Add(player);
            }
            return teamvar;
        }
    }
    public class Team
    {
        public string teamName;
        public string teamCountry;
        public string teamCity;
        protected List<Player> playerlist;
        public List<Player> Playerlist
        {
            set { playerlist = value; }
            get { return playerlist; }
        }
    }
    public class Player
    {
        public string playerName;
        public string playerNumber;
        public string playerPos;
    }
}
