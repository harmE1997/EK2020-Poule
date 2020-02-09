using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EK2020_Poule
{
    public partial class StatsForm : Form
    {
        public PlayerManager manager { get; set; }
        List<Stat> stats { get; set; }
        public StatsForm()
        {
            InitializeComponent();
            stats = new List<Stat>();
        }

        private void btnChampions_Click(object sender, EventArgs e) => ActionStat(BonusKeys.Kampioen);
        private void btnTopscorers_Click(object sender, EventArgs e) => ActionStat(BonusKeys.Topscorer);
        private void btnNL_Click(object sender, EventArgs e) => ActionStat(BonusKeys.NL);
        private void btnLast16_Click(object sender, EventArgs e) => ActionKnockout(KOKeys.sixteen);
        private void btnQuarter_Click(object sender, EventArgs e) => ActionKnockout(KOKeys.quarter);
        private void btnSemi_Click(object sender, EventArgs e) => ActionKnockout(KOKeys.semi);
        private void btnFinal_Click(object sender, EventArgs e) => ActionKnockout(KOKeys.final);


        private void ActionKnockout(KOKeys Key)
        {
            stats.Clear();
            foreach (Player player in manager.Players)
            {
                var Name = player.Name;
                var answer = player.KnockOut.Stages[Key].teams;
                foreach (var team in answer)
                {
                    UpdateStats(team, Name);
                }
            }
            UpdateListBox();
        }

        private void ActionStat(BonusKeys Key)
        {
            stats.Clear();
            foreach (Player player in manager.Players)
            {
                var Name = player.Name;
                var answer = player.Questions.Answers[Key];
                UpdateStats(answer.Answer, Name);
                
            }
            UpdateListBox();
        }

        private void UpdateStats(string stat, string playername)
        {
            Stat existingStat = null;
            foreach (Stat oldstat in stats)
            {
                if (oldstat.Name == stat)
                {
                    existingStat = oldstat;
                }
            }

            if (existingStat == null)
            {
                Stat newstat = new Stat(stat, playername);
                stats.Add(newstat);
            }

            else
            {
                existingStat.Add(playername);
            }
        }

        private void UpdateListBox()
        {
            lbStats.Items.Clear();
            stats.Sort();
            foreach (Stat stat in stats)
            {
                lbStats.Items.Add(stat.StatToString());
                foreach (string name in stat.Names)
                {
                    lbStats.Items.Add(name);
                }

                lbStats.Items.Add("=================================================================================================");
            }
        }

    }
}
