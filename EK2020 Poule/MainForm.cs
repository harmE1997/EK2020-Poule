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

namespace Wk2018_Poule
{
    public partial class MainForm : Form
    {
        private PlayerManager manager;
        private HostManager host;
        public MainForm()
        {
            InitializeComponent();
            manager = new PlayerManager();
            manager.LoadPlayers();
            host = new HostManager();
        }

        private void btnNewPlayer_Click(object sender, EventArgs e)
        {
            TotoForm toto = new TotoForm();
            toto.Show();
            toto.manager = manager;
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
            Player player = manager.FindPlayerByName(name);

            if (player == null)
            {
                MessageBox.Show("Deze speler bestaat niet. Gebruik een andere naam");
            }

            else if (name == "Host")
            {
                player = host.GetHost();
            }

            TotoForm totoform = new TotoForm();
            totoform.loadPlayer(player);
            totoform.Show();
            totoform.manager = manager;

        }

        private void btnScheddule_Click(object sender, EventArgs e)
        {
            SchedduleForm scheddule = new SchedduleForm(host.GetHost());
            scheddule.Show();
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

    }
}