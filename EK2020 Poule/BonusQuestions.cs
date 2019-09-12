using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2018_Poule
{
    public enum BonusKeys
    {
        goals,
        owngoals,
        yellows,
        reds,
        topscorer
    }
    public struct Question
    {
        public dynamic Answer;
        public bool estimation;
        public int missmultiplier;
        public int award;
    }

    [Serializable]
    public class BonusQuestions
    {
        public Dictionary<BonusKeys, Question> Questions { get; private set; }
        public BonusQuestions(int goals, int owngoals, int yellows, int reds, string topscorer)
        {
            if (string.IsNullOrEmpty(topscorer))
            {
                throw new ArgumentNullException();
            }

            Questions = new Dictionary<BonusKeys, Question>()
            {
                {BonusKeys.goals, new Question() { Answer = goals, estimation = true, missmultiplier = 4, award = 200 } },
                {BonusKeys.owngoals, new Question() { Answer = owngoals, estimation = true, missmultiplier = 30, award = 100 } },
                {BonusKeys.reds, new Question() { Answer = reds, estimation = true, missmultiplier = 20, award = 100 } },
                {BonusKeys.yellows, new Question() { Answer = yellows, estimation = true, missmultiplier = 4, award = 200 } },
                {BonusKeys.topscorer, new Question() { Answer = topscorer, estimation = false, missmultiplier = 0, award = 100 } }
            };
        }

        public int checkQuestions(BonusQuestions answers)
            {
                if (answers == null)
                {
                    return -1;
                }

                int Score = 0;
                foreach (var q in Questions)
                {
                    if (q.Value.estimation)
                    {
                        int miss = Math.Abs(q.Value.Answer - answers.Questions[q.Key].Answer);
                        int minpoints = miss * q.Value.missmultiplier;
                        if (minpoints > q.Value.award)
                        {
                        minpoints = q.Value. award;
                        }
                        Score += (q.Value.award - minpoints);
                    }

                    else
                    {
                        if (q.Value.Answer == answers.Questions[q.Key].Answer)
                        {
                            Score += q.Value.award;
                        }
                    }
                }

                return Score;
            }
        }
    }
