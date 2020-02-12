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
using System.Configuration;

namespace EK2020_Poule
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

        private void btnRanking_Click(object sender, EventArgs e)
        {
            proBarRanking.Maximum = manager.Players.Count();
            proBarRanking.Value = 0;
            ExcelManager m = new ExcelManager();
            foreach (int i in m.ExportPlayersToExcel(ConfigurationManager.AppSettings.Get("AdminLocation"),Convert.ToInt32(ConfigurationManager.AppSettings.Get("RankingSheet")), manager.Players))
            {
                proBarRanking.Value = i;
            }

        }
    }
}
