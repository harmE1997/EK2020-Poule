using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Wk2018_Poule
{
    class HostManager
    {
        private Player host;

        public Player GetHost()
        {
            if (host == null)
            {
                LoadHost();
            }

            return host;
        }

        private void createHost()
        {
            PoolMatchResult[] matches = new PoolMatchResult[48];
            string[] last16 = new string[16] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            string[] last8 = new string[8] { "", "", "", "", "", "", "", "" };
            string[] last4 = new string[4] { "", "", "", "" };
            string[] final = new string[2] { "", "" };
            string[] champion = new string[1] { "" };

            KnockOutPhase ko = new KnockOutPhase(last16, last8, last4, final, champion);
            BonusQuestions answers = new BonusQuestions(0, 0, 0, 0, "l");

            host = new Player("Host", matches, ko, answers);
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
                createHost();
                saveHost();
            }
        }

        private void saveHost()
        {
            FileStream stream = new FileStream("Host", FileMode.Create);
            BinaryFormatter Formatter = new BinaryFormatter();
            Formatter.Serialize(stream, host);
            stream.Close();
        }
    }
}
