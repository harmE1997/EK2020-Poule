using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace EK2020_Poule
{
    public class HostManager
    {
        private Player Host;
        public HostManager()
        {
            SetHost();
        }

        public Player GetHost()
        {
            return Host;
        }

        public void SetHost(Player host = null)
        {
            if (Host == null && host == null)
            {
                LoadHost();
            }

            else if (host != null)
            {
                Host = host;
                saveHost();
            }
        }

        private void createHost()
        {
            PoolMatchResult[] matches = new PoolMatchResult[48];
            for (int i=0; i<48; i++)
            {
                matches[i] = new PoolMatchResult(99,99);
            }
            KnockOutPhase ko = new KnockOutPhase();

            Host = new Player("Host", matches, ko, new BonusQuestions("", "", ""));
        }

        private void LoadHost()
        {
            if (File.Exists("Host"))
            {
                FileStream stream = new FileStream("Host", FileMode.Open);
                BinaryFormatter Formatter = new BinaryFormatter();
                Host = (Player)Formatter.Deserialize(stream);
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
            Formatter.Serialize(stream, Host);
            stream.Close();
        }
    }
}
