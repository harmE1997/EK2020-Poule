using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace EK2020_Poule
{
    public partial class MainForm : Form
    {
        private PlayerManager manager;
        private HostManager host;
        private TotoForm toto;
        public MainForm()
        {
            InitializeComponent();
            manager = new PlayerManager();
            manager.LoadPlayers();
            host = new HostManager();
            toto = new TotoForm();
        }

        private void btnNewPlayer_Click(object sender, EventArgs e)
        {
            toto = new TotoForm();
            toto.manager = manager;
            toto.Show();
        }

        private void btnRanking_Click(object sender, EventArgs e)
        {
            RankingForm ranking = new RankingForm();
            ranking.Show();
        }

        private void btnLoadPlayer_Click(object sender, EventArgs e)
        {
            string name = tbPlayerName.Text;
            manager.LoadPlayers();
            Player player;
            toto = new TotoForm();
            if (name == "Host")
            {
                player = host.GetHost();
                toto.hostmanager = host;
            }

            else
            {
                player = manager.FindPlayerByName(name);
                toto.manager = manager;
                if (player == null)
                {
                    MessageBox.Show("Deze speler bestaat niet. Gebruik een andere naam");
                    return;
                }
            }

            toto.loadPlayer(player);
            toto.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = tbPlayerName.Text;
            if (name == "Host")
            {
                MessageBox.Show("Invalid Name");
                return;
            }

            manager.LoadPlayers();
            bool check = manager.removePlayer(name);
            if (check)
            {
                manager.SavePlayers();
                MessageBox.Show("Speler is succesvol verwijderd");
            }

            else
            {
                MessageBox.Show("Speler kan niet verwijderd worden, speler bestaat niet");
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            manager.checkAllPlayers(host.GetHost());
            MessageBox.Show("Done Checking");
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            StatsForm stats = new StatsForm();
            stats.manager = manager;
            stats.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            int As = 0;
            int Bs = 0;
            int Ds = 0;
            int matchID = (Convert.ToInt32(cbPoules.Text) - 1) * 6 + Convert.ToInt32(cbID.Text);

            foreach (Player p in manager.Players)
            {
                string res = p.GetMatch(matchID);
                switch (res)
                {
                    case "A":
                        As++;
                        break;
                    case "B":
                        Bs++;
                        break;
                    case "D":
                        Ds++;
                        break;
                    default:
                        break;
                }
            }

            rtbNotes.Text = "Winst A: " + As + "\nWinst B: " + Bs + "\nGelijkspel: " + Ds;
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            int fulls = 0;
            int halfs = 0;
            int matchID = (Convert.ToInt32(cbPoules.Text) - 1) * 6 + Convert.ToInt32(cbID.Text);
            string Names = "";
            foreach (Player player in manager.Players)
            {
                int check = player.CheckMatch(host.GetHost(), matchID);
                if (check > 0)
                {
                    halfs++;
                }

                if (check == 2)
                {
                    fulls++;
                    Names += player.Name + ", ";
                }

            }

            rtbNotes.Text = "Goede winnaar: " + halfs + "\nHelemaal correct: " + fulls + " " + Names;
        }
    }
}