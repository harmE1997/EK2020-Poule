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

namespace Wk2018_Poule
{
    public partial class RankingForm : Form
    {
        PlayerManager manager;
        public RankingForm()
        {
            InitializeComponent();
            manager = new PlayerManager();
            try
            {
                manager.LoadPlayers();
            }

            catch (FileNotFoundException)
            {

            }
            DisplayRanking();
        }

        private void DisplayRanking()
        {
            lbRanking.Items.Clear();
            lbRanking.Items.Add("");
            lbRanking.Items.Add("");
            manager.rankPlayers();
            foreach (Player player in manager.Players)
            {
                    lbRanking.Items.Add(player.playerToString());          
            }
        }
    }
}
