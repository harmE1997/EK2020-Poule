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
    public partial class TotoForm : Form
    {
        private Dictionary<KOKeys, TextBox[]> kolocs;
        private NumericUpDown[] NUDs = new NumericUpDown[96];
        public PlayerManager manager;
        public TotoForm()
        {
            InitializeComponent();
            fillArrays();
            btnSubmit.Enabled = true;
            manager = new PlayerManager();
            try
            {
                manager.LoadPlayers();
            }

            catch (FileNotFoundException)
            {

            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            manager.LoadPlayers();
            PoolMatchResult[] matches = new PoolMatchResult[48];
            KnockOutPhase KO = new KnockOutPhase();
            int x = 0;
            while (x < 96)
            {
                int y = x / 2;
                matches[y] = new PoolMatchResult(Convert.ToInt32(NUDs[x].Value), Convert.ToInt32(NUDs[x + 1].Value));
                x += 2;
            }

            foreach (var k in kolocs)
            {
                foreach (var t in k.Value)
                {
                    KO.Stages[k.Key].teams.Add(t.Text);
                }
            }

            try
            {
                BonusQuestions guess = new BonusQuestions(Convert.ToInt16(nudGoals.Value), Convert.ToInt16(nudOwnGoals.Value), Convert.ToInt16(nudYellows.Value)
                        , Convert.ToInt16(nudReds.Value), tbTopscorer.Text);

                manager.removePlayer(tbName.Text);
                Player player = new Player(tbName.Text, matches, KO, guess);
                manager.AddPlayer(player);

            }

            catch (ArgumentNullException)
            {
                MessageBox.Show("Veld niet ingevuld. Controleer of alle velden zijn ingevuld en probeer opnieuw.");
            }

            manager.SavePlayers();
            this.Hide();
            this.Dispose();
        }

        public void loadPlayer(Player player)
        {
            int x = 0;
            while (x < NUDs.Length)
            {
                int y = x / 2;
                NUDs[x].Value = player.Results[y].ScoreA;
                NUDs[x + 1].Value = player.Results[y].ScoreB;
                x += 2;
            }

            int i = 0;
            foreach (var stage in player.KnockOut.Stages)
            {
                foreach (var team in stage.Value.teams)
                {
                    kolocs[stage.Key][i].Text = team;
                    i++;
                }
            }

            nudGoals.Value = player.Bonusquestions.Questions[BonusKeys.goals].Answer;
            nudOwnGoals.Value = player.Bonusquestions.Questions[BonusKeys.owngoals].Answer;
            nudYellows.Value = player.Bonusquestions.Questions[BonusKeys.yellows].Answer;
            nudReds.Value = player.Bonusquestions.Questions[BonusKeys.reds].Answer;
            tbTopscorer.Text = player.Bonusquestions.Questions[BonusKeys.topscorer].Answer;
            tbName.Text = player.Name;
        }

        private void fillArrays()
        {
            kolocs = new Dictionary<KOKeys, TextBox[]>()
            {
                {KOKeys.sixteen, new TextBox[]{
                    tb161, tb162, tb163, tb164, tb165, tb166, tb167, tb168, tb169, tb1610, tb1611, tb1612, tb1613, tb1613, tb1614, tb1615, tb1616 } },
                {KOKeys.quarter, new TextBox[]{tb81, tb82, tb83, tb84, tb85, tb86, tb87, tb88, } },
                {KOKeys.semi, new TextBox[]{tb41, tb42, tb43, tb44 } },
                {KOKeys.final, new TextBox[]{tbF1, tbF2} },
                {KOKeys.champ, new TextBox[]{tbChampion } }
            };

            NUDs[0] = nudA11;
            NUDs[1] = nudA12;
            NUDs[2] = nudA21;
            NUDs[3] = nudA22;
            NUDs[4] = nudA31;
            NUDs[5] = nudA32;
            NUDs[6] = nudA41;
            NUDs[7] = nudA42;
            NUDs[8] = nudA51;
            NUDs[9] = nudA52;
            NUDs[10] = nudA61;
            NUDs[11] = nudA62;

            NUDs[12] = nudB11;
            NUDs[13] = nudB12;
            NUDs[14] = nudB21;
            NUDs[15] = nudB22;
            NUDs[16] = nudB31;
            NUDs[17] = nudB32;
            NUDs[18] = nudB41;
            NUDs[19] = nudB42;
            NUDs[20] = nudB51;
            NUDs[21] = nudB52;
            NUDs[22] = nudB61;
            NUDs[23] = nudB62;

            NUDs[24] = nudC11;
            NUDs[25] = nudC12;
            NUDs[26] = nudC21;
            NUDs[27] = nudC22;
            NUDs[28] = nudC31;
            NUDs[29] = nudC32;
            NUDs[30] = nudC41;
            NUDs[31] = nudC42;
            NUDs[32] = nudC51;
            NUDs[33] = nudC52;
            NUDs[34] = nudC61;
            NUDs[35] = nudC62;

            NUDs[36] = nudD11;
            NUDs[37] = nudD12;
            NUDs[38] = nudD21;
            NUDs[39] = nudD22;
            NUDs[40] = nudD31;
            NUDs[41] = nudD32;
            NUDs[42] = nudD41;
            NUDs[43] = nudD42;
            NUDs[44] = nudD51;
            NUDs[45] = nudD52;
            NUDs[46] = nudD61;
            NUDs[47] = nudD62;

            NUDs[48] = nudE11;
            NUDs[49] = nudE12;
            NUDs[50] = nudE21;
            NUDs[51] = nudE22;
            NUDs[52] = nudE31;
            NUDs[53] = nudE32;
            NUDs[54] = nudE41;
            NUDs[55] = nudE42;
            NUDs[56] = nudE51;
            NUDs[57] = nudE52;
            NUDs[58] = nudE61;
            NUDs[59] = nudE62;

            NUDs[60] = nudF11;
            NUDs[61] = nudF12;
            NUDs[62] = nudF21;
            NUDs[63] = nudF22;
            NUDs[64] = nudF31;
            NUDs[65] = nudF32;
            NUDs[66] = nudF41;
            NUDs[67] = nudF42;
            NUDs[68] = nudF51;
            NUDs[69] = nudF52;
            NUDs[70] = nudF61;
            NUDs[71] = nudF62;
        }
    }
}
