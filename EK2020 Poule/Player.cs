using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2018_Poule
{
    [Serializable]
    public class Player : IComparable<Player>
    {
        public string Name { get; private set; }
        public PoolMatchResult[] Results { get; private set; }
        public KnockOutPhase KnockOut { get; private set; }
        public BonusQuestions Bonusquestions { get; private set; }
        public int Score { get; private set; }
        public int Ranking { get; private set; }

        public Player(string name, PoolMatchResult[] poolmatches, KnockOutPhase KO, BonusQuestions bonus)
        {
            if (name != "Host")
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException();
                }

            }

            if (poolmatches == null || KO == null || bonus == null)
            {
                throw new ArgumentNullException();
            }
            Name = name;
            Score = 0;
            Results = poolmatches;
            KnockOut = KO;
            Bonusquestions = bonus;
        }

        public void setRanking(int rank)
        {
            Ranking = rank;
        }
        public bool Check(Player host)
        {
            if (host == null)
            {
                return false;
            }
            //pool
            Score = 0;
            int x = 0;
            foreach(PoolMatchResult result in Results)
            {
                PoolMatchResult hostresult = host.Results[x];
                if (hostresult != null || result != null)
                {
                    if (hostresult.ScoreA != 99)
                    {
                        if (hostresult.Winner == result.Winner)
                        {
                            Score += 60;
                        }

                        if(hostresult.ScoreA == result.ScoreA)
                        {
                            Score += 20;
                        }

                        if (hostresult.ScoreB == result.ScoreB)
                        {
                            Score += 20;
                        }
                    }
                }
                x++;
            }

            //knockout
            int checkscore = KnockOut.checkKnockoutPhase(host.KnockOut);
            if (checkscore != -1)
            {
                Score += checkscore;
            }

            //bonus questions
            checkscore= Bonusquestions.checkQuestions(host.Bonusquestions);
            if (checkscore != -1)
            {
                Score += checkscore;
            }
            return true;
        }

        public int CompareTo(Player other)
        {
            if (other != null)
            {
                return Score.CompareTo(other.Score);
            }

            else
            {
                throw new ArgumentNullException("OtherPlayer");
            }
        }

        public string playerToString()
        {
            return Ranking + ".\t" + Name + "\t" + Score;
        }
    }
}
