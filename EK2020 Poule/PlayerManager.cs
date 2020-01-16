using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace EK2020_Poule
{
    [Serializable]
    public class PlayerManager 
    {
        public List<Player> Players { get; private set; }
        public string FileName { get; private set; }
        public PlayerManager()
        {
            Players = new List<Player>();
            FileName = "EK2020";
        }

        public void SavePlayers()
        {
            // filename moet een path zijn!
            FileStream stream = new FileStream(FileName, FileMode.Create);
            BinaryFormatter Formatter = new BinaryFormatter();
            Formatter.Serialize(stream, Players);
            stream.Close();
        }

        public void LoadPlayers()
        {
            if (File.Exists(FileName))
            {
                FileStream stream = new FileStream(FileName, FileMode.Open);
                BinaryFormatter Formatter = new BinaryFormatter();
                Players.Clear();
                Players = (List<Player>)Formatter.Deserialize(stream);
                stream.Close();
            }

            else
            {
                SavePlayers();
            }
        }

        public void AddPlayer(Player player)
        {
            if (player != null)
            {
                Players.Add(player);
            }

            else
            {
                throw new ArgumentNullException();
            }
        }

        public Player FindPlayerByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return null;
            }

            foreach (Player player in Players)
            {
                if (player.Name == name)
                {
                    return player;
                }
            }

            return null;
        }

        public bool removePlayer(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return false;
            }
            Player player = FindPlayerByName(name);
            if (player != null)
            {
                Players.Remove(player);
                return true;
            }

            return false;
        }

        public void checkAllPlayers(Player host)
        {
            if (host != null)
            {
                foreach (Player player in Players)
                {
                    if (player.Name != "Host")
                    {
                        player.Check(host);
                    }
                }
                SavePlayers();
            }
        }

        public void rankPlayers()
        {
            Players.Sort();
            Players.Reverse();
            int counter = 0;
            int lastplayerscore = -1;
            foreach (Player player in Players)
            {
                if (player.Score != lastplayerscore)
                {
                    counter++;
                }
                player.setRanking(counter);
                lastplayerscore = player.Score;
            }
        }
    }
}
