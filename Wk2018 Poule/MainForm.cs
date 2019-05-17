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
        private Player host;
        public MainForm()
        {
            InitializeComponent();
            manager = new PlayerManager();

            try
            {
                manager.LoadPlayers();
            }

            catch (FileNotFoundException)
            {
                manager.SavePlayers();
            }

            try
            {
                LoadHost();
            }

            catch (FileNotFoundException)
            {
                createHost();
                saveHost();
            }
        }

        private void btnNewPlayer_Click(object sender, EventArgs e)
        {
            PlayerForm toto = new PlayerForm();
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
            try
            {
                manager.LoadPlayers();
            }

            catch
            {
                MessageBox.Show("Kan niet laden, spelers bestaan niet");
            }
            Player player = manager.FindPlayerByName(name);
            if (player == null && name != "Host")
            {
                MessageBox.Show("Deze speler bestaat niet. Gebruik een andere naam");
            }

            else if (name == "Host")
            {
                try
                {
                    LoadHost();
                }

                catch
                {
                    MessageBox.Show("Can't load host. No file exists");
                }
                PassWordForm form = new PassWordForm();
                form.host = host;
                form.manager = manager;
                form.nextform = "hostform";
                form.Show();
                
            }

            else
            {
                TotoForm totoform = new TotoForm();
                totoform.loadPlayer(player);
                totoform.Show();
                totoform.manager = manager;
            }        
        }

        private void btnCheckScore_Click(object sender, EventArgs e)
        {
            if (tbPlayerName.Text != "Host")
            {
                try
                {
                    manager.LoadPlayers();
                }

                catch
                {
                    MessageBox.Show("Kan niet laden, spelers bestaan niet");
                }
                Player player = manager.FindPlayerByName(tbPlayerName.Text);
                if (player != null)
                {
                    MessageBox.Show("Je huidige score is: " + player.Score + " punten.");
                }

                else
                {
                    MessageBox.Show("Score kan niet worden gevonden.");
                }
            }
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            RulesForm rules = new RulesForm();
            rules.Show();
        }

        private void btnScheddule_Click(object sender, EventArgs e)
        {
            try
            {
                LoadHost();
            }

            catch
            {
                MessageBox.Show("Can't load host. No file exists");
            }
            SchedduleForm scheddule = new SchedduleForm(host);
            scheddule.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string name = tbPlayerName.Text;
            if (name != "Host")
            {
                try
                {
                    manager.LoadPlayers();
                }

                catch
                {
                    MessageBox.Show("Kan niet laden, spelers bestaan niet");
                }
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

            else
            {
                MessageBox.Show("Invalid Name");
            }
        }

        private void createHost()
        {
            PoolMatchResult[] matches = new PoolMatchResult[48];
            string[] last16 = new string[16];
            string[] last8 = new string[8];
            string[] last4 = new string[4];
            string[] final = new string[2];

            for(int i = 0; i < 48; i++)
            {
                matches[i] = new PoolMatchResult(99, 99);
            }

            for (int i = 0; i < 16; i++)
            {
                last16[i] = "";
            }

            for (int i = 0; i < 8; i++)
            {
                last8[i] = "";
            }

            for (int i = 0; i < 4; i++)
            {
                last4[i] = "";
            }
            final[0] = "";
            final[1] = "";

            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, "l", "l");
            BonusQuestions answers = new BonusQuestions(0, 0, 0, 0, "l");
            
            host = new Player("Host", matches, ko ,answers, "p", "m");
        }

        private void LoadHost()
        {
            if (File.Exists("Host"))
            {
                FileStream stream = new FileStream("Host", FileMode.Open);
                BinaryFormatter Formatter = new BinaryFormatter();
                host = (Player)Formatter.Deserialize(stream);
                stream.Close();
            }

            else
            {
                throw new FileNotFoundException("Host");
            }
        }

        private void saveHost()
        {
            FileStream stream = new FileStream("Host", FileMode.Create);
            BinaryFormatter Formatter = new BinaryFormatter();
            Formatter.Serialize(stream, host);
            stream.Close();
        }

        private void btnMails_Click(object sender, EventArgs e)
        {
            PassWordForm pwf = new PassWordForm();
            pwf.manager = manager;
            pwf.nextform = "mailform";
            pwf.Show();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string land = tbCheck.Text;
            string players = "";
            int counter = 0;
            foreach (Player player in manager.Players)
            {
                if (player.Bonusquestions.Topscorer == land)
                {
                    players += player.Name + "\n";
                    counter++;
                }
            }

            players += counter; 
            MessageBox.Show(players);
        }
    }
}
