using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EK2020_Poule
{
    [Serializable]
    public class PoolMatchResult
    {
        public int ScoreA { get; private set; }
        public int ScoreB { get; private set; }
        public string Winner { get; private set; }

        public PoolMatchResult(int scorea, int scoreb)
        {
            ScoreA = scorea;
            ScoreB = scoreb;
            if (scorea > scoreb)
            {
                Winner = "A";
            }

            else if (scorea < scoreb)
            {
                Winner = "B";
            }

            else
            {
                Winner = "D";
            }
        }

        public string MatchToString()
        {
            if (ScoreA == 99 || ScoreB == 99)
            {
                return " - ";
            }

            else
            {
                string result = ScoreA + " - " + ScoreB;
                return result;
            }
        }
    }
}
