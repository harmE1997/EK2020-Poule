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

namespace EK2020_Poule
{
    public partial class TotoForm : Form
    {
        private Dictionary<KOKeys, TextBox[]> kolocs;
        private NumericUpDown[] NUDs = new NumericUpDown[72];
        public PlayerManager manager;
        public HostManager hostmanager;
        public TotoForm()
        {
            InitializeComponent();
            fillArrays();
            btnSubmit.Enabled = true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            manager.LoadPlayers();
            PoolMatchResult[] matches = new PoolMatchResult[48];
            KnockOutPhase KO = new KnockOutPhase();
            int x = 0;
            while (x < 72)
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

            Player player = new Player(tbName.Text, tbTown.Text, matches, KO, new BonusQuestions(tbChampion.Text, tbTopscorer.Text, tbDutch.Text));
            if (tbName.Text == "Host")
            {
                hostmanager.SetHost(player);
            }

            else
            {
                try
                {
                    manager.removePlayer(tbName.Text);                    
                    manager.AddPlayer(player);
                }

                catch (ArgumentNullException)
                {
                    MessageBox.Show("Veld niet ingevuld. Controleer of alle velden zijn ingevuld en probeer opnieuw.");
                }
                manager.SavePlayers();
            }

            this.Hide();
            this.Dispose();
        }

        public void loadPlayer(Player player)
        {
            //load group phase
            for (int x = 0;  x < NUDs.Length; x+=2)
            {
                int y = x / 2;
                NUDs[x].Value = player.Results[y].ScoreA;
                NUDs[x + 1].Value = player.Results[y].ScoreB;
            }

            //load knock-out phase
            foreach (var stage in player.KnockOut.Stages)
            {
                int i = 0;
                foreach (var team in stage.Value.teams)
                {
                    kolocs[stage.Key][i].Text = team;
                    i++;
                }
            }
            
            //load bonus questions and other info
            tbChampion.Text = player.Questions.Answers[BonusKeys.Kampioen].Answer;
            tbTopscorer.Text = player.Questions.Answers[BonusKeys.Topscorer].Answer;
            tbDutch.Text = player.Questions.Answers[BonusKeys.NL].Answer;
            tbName.Text = player.Name;
            tbTown.Text = player.Town;
        }

        private void fillArrays()
        {
            kolocs = new Dictionary<KOKeys, TextBox[]>()
            {
                {KOKeys.sixteen, new TextBox[]{
                    tb161, tb162, tb163, tb164, tb165, tb166, tb167, tb168, tb169, tb1610, tb1611, tb1612, tb1613, tb1614, tb1615, tb1616 } },
                {KOKeys.quarter, new TextBox[]{tb81, tb82, tb83, tb84, tb85, tb86, tb87, tb88, } },
                {KOKeys.semi, new TextBox[]{tb41, tb42, tb43, tb44 } },
                {KOKeys.final, new TextBox[]{tbF1, tbF2} },
            };

            NUDs = new NumericUpDown[72] {
            nudA11, nudA12, nudA21, nudA22, nudA31, nudA32, nudA41, nudA42, nudA51, nudA52, nudA61, nudA62,
            nudB11, nudB12, nudB21, nudB22, nudB31, nudB32, nudB41, nudB42, nudB51, nudB52, nudB61,nudB62,
            nudC11, nudC12, nudC21, nudC22, nudC31, nudC32, nudC41, nudC42, nudC51, nudC52, nudC61, nudC62,
            nudD11, nudD12, nudD21, nudD22, nudD31, nudD32, nudD41, nudD42, nudD51, nudD52, nudD61, nudD62,
            nudE11, nudE12, nudE21, nudE22, nudE31, nudE32, nudE41, nudE42, nudE51, nudE52, nudE61, nudE62,
            nudF11, nudF12, nudF21, nudF22, nudF31, nudF32, nudF41, nudF42, nudF51, nudF52, nudF61, nudF62 };
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (ofdExcelFile.ShowDialog() == DialogResult.OK)
            {
                string file = ofdExcelFile.FileName;
                if (file.EndsWith(".xlsx") || file.EndsWith(".xls"))
                {
                    tbFile.Text = ofdExcelFile.FileName;
                }

                else
                {
                    MessageBox.Show("Invalid file type!");
                }
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            string file = tbFile.Text;
            ExcelManager em = new ExcelManager();
            ExcelReadSettings settings = new ExcelReadSettings();
            Player player = new Player(tbName.Text, tbTown.Text, em.ReadGroupPhase(file, 1, settings), em.readKnockout(file, 1, settings), em.readBonus(file, 1));
            MessageBox.Show("player sucesfully created!");
            loadPlayer(player);
        }
    }
}
