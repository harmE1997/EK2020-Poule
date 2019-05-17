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
        private TextBox[] textboxes = new TextBox[33];
        private NumericUpDown[] NUDs = new NumericUpDown[96];   
        public PlayerManager manager;
        public string name;
        public string email;
        public string payment;
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
            try
            {
                manager.LoadPlayers();
            }

            catch
            {
                MessageBox.Show("Kan niet laden. Spelers bestaan niet");
            }

            for (int i = 0; i < 33; i++)
            {
                if (string.IsNullOrEmpty(textboxes[i].Text))
                {
                     MessageBox.Show("Veld niet ingevuld. Controleer of alle velden zijn ingevuld en probeer opnieuw.");
                     return;
                }
            }

            PoolMatchResult[] matches = new PoolMatchResult[48];
            string[] last16 = new string[16];
            string[] last8 = new string[8];
            string[] last4 = new string[4];
            string[] final = new string[2];

            int x = 0;
            while (x < 96)
            {
                int y = x / 2;
                matches[y] = new PoolMatchResult(Convert.ToInt32(NUDs[x].Value), Convert.ToInt32(NUDs[x + 1].Value));
                x += 2;
            }

            for (int i = 0; i < 16; i++)
            {
                last16[i] = textboxes[i].Text;
            }

            for (int i = 16; i < 24; i++)
            {
                last8[i - 16] = textboxes[i].Text;
            }

            last4[0] = tb41.Text;
            last4[1] = tb42.Text;
            last4[2] = tb43.Text;
            last4[3] = tb44.Text;

            final[0] = tbF1.Text;
            final[1] = tbF2.Text;

            try
            {
            KnockOutPhase KO = new KnockOutPhase(last16, last8, last4, final, tbBronze.Text, tbChampion.Text);
            BonusQuestions guess = new BonusQuestions(Convert.ToInt16(nudNrGoals.Value), Convert.ToInt16(nudOwnGoals.Value), Convert.ToInt16(nudYellows.Value)
                    , Convert.ToInt16(nudReds.Value), tbTopscorer.Text);

                Player oldplayer = manager.FindPlayerByName(name);
                if (oldplayer != null)
                {
                    manager.removePlayer(name);
                }
                Player player = new Player(name, matches, KO ,guess, payment, email);
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
            while(x < 96)
            {
                int y = x / 2;
                NUDs[x].Value = player.Results[y].ScoreA;
                NUDs[x + 1].Value = player.Results[y].ScoreB;
                x+=2;
            }

            for (int i = 0; i < 16; i++)
            {
                textboxes[i].Text = player.KnockOut.Last16[i];
            }

            for (int i = 16; i < 24; i++)
            {
                textboxes[i].Text = player.KnockOut.Last8[i - 16];
            }

            tb41.Text = player.KnockOut.Last4[0];
            tb42.Text = player.KnockOut.Last4[1];
            tb43.Text = player.KnockOut.Last4[2];
            tb44.Text = player.KnockOut.Last4[3];
            tbF1.Text = player.KnockOut.Final[0];
            tbF2.Text = player.KnockOut.Final[1];
            tbBronze.Text = player.KnockOut.Bronze;
            tbChampion.Text = player.KnockOut.Champion;
            nudNrGoals.Value = player.Bonusquestions.nrGoals;
            nudOwnGoals.Value = player.Bonusquestions.nrOwnGoals;
            nudYellows.Value = player.Bonusquestions.nrYellowCards;
            nudReds.Value = player.Bonusquestions.nrRedCards;
            tbTopscorer.Text = player.Bonusquestions.Topscorer;
            name = player.Name;
            email = player.Email;
            payment = player.Payment;
        }

        private void fillArrays()
        {
            textboxes[0] = tb161;
            textboxes[1] = tb162;
            textboxes[2] = tb163;
            textboxes[3] = tb164;
            textboxes[4] = tb165;
            textboxes[5] = tb166;
            textboxes[6] = tb167;
            textboxes[7] = tb168;
            textboxes[8] = tb169;
            textboxes[9] = tb1610;
            textboxes[10] = tb1611;
            textboxes[11] = tb1612;
            textboxes[12] = tb1613;
            textboxes[13] = tb1614;
            textboxes[14] = tb1615;
            textboxes[15] = tb1616;
            textboxes[16] = tb81;
            textboxes[17] = tb82;
            textboxes[18] = tb83;
            textboxes[19] = tb84;
            textboxes[20] = tb85;
            textboxes[21] = tb86;
            textboxes[22] = tb87;
            textboxes[23] = tb88;
            textboxes[24] = tb41;
            textboxes[25] = tb42;
            textboxes[26] = tb43;
            textboxes[27] = tb44;
            textboxes[28] = tbF1;
            textboxes[29] = tbF2;
            textboxes[30] = tbBronze;
            textboxes[31] = tbChampion;
            textboxes[32] = tbTopscorer;

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

            NUDs[72] = nudG11;
            NUDs[73] = nudG12;
            NUDs[74] = nudG21;
            NUDs[75] = nudG22;
            NUDs[76] = nudG31;
            NUDs[77] = nudG32;
            NUDs[78] = nudG41;
            NUDs[79] = nudG42;
            NUDs[80] = nudG51;
            NUDs[81] = nudG52;
            NUDs[82] = nudG61;
            NUDs[83] = nudG62;

            NUDs[84] = nudH11;
            NUDs[85] = nudH12;
            NUDs[86] = nudH21;
            NUDs[87] = nudH22;
            NUDs[88] = nudH31;
            NUDs[89] = nudH32;
            NUDs[90] = nudH41;
            NUDs[91] = nudH42;
            NUDs[92] = nudH51;
            NUDs[93] = nudH52;
            NUDs[94] = nudH61;
            NUDs[95] = nudH62;
        }
    }
}
