using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EK2020_Poule
{
    [Serializable]
    public class Player : IComparable<Player>
    {
        public string Name { get; private set; }
        public string Town { get; private set; }
        public List<PoolMatchResult> Results { get; private set; }
        public KnockOutPhase KnockOut { get; private set; }
        public BonusQuestions Questions { get; private set; }
        public int Score { get; private set; }
        public int Ranking { get; private set; }

        public Player(string name, string town, List<PoolMatchResult> poolmatches, KnockOutPhase KO, BonusQuestions BQ)
        {
            if (name != "Host")
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException();
                }

            }

            if (poolmatches == null || KO == null)
            {
                throw new ArgumentNullException();
            }
            Name = name;
            Score = 0;
            Results = poolmatches;
            KnockOut = KO;
            Questions = BQ;
        }
        public string GetMatch(int matchID)
        {
            return Results[matchID].Winner;
        }

        public void setRanking(int rank)
        {
            Ranking = rank;
        }

        public bool Check(Player host, List<goalScorer> scorers)
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

            Score += Questions.CheckBonus(host.Questions);
            var s = findGoalscorer(scorers, Questions.Answers[BonusKeys.Topscorer].Answer);
            if (s != null)
            {
                Score += (s.goals * 20);
            }
            return true;
        }

        public int CheckMatch(Player Host, int matchID)
        {
            PoolMatchResult HostMatch = Host.Results[matchID];
            PoolMatchResult ThisMatch = Results[matchID];

            if (HostMatch.ScoreA != 99 && ThisMatch.ScoreA != 99)
            {
                if (HostMatch.ScoreA == ThisMatch.ScoreA && ThisMatch.ScoreB == HostMatch.ScoreB)
                {
                    return 2;
                }

                else if (ThisMatch.Winner == HostMatch.Winner)
                {
                    return 1;
                }

                else
                {
                    return 0;
                }
            }

            return -1;
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

        private goalScorer findGoalscorer(List<goalScorer> scorers, string name)
        {
            foreach (var s in scorers)
            {
                if (s.name == name)
                {
                    return s;
                }
            }
            return null;
        }
    }
}
