using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EK2020_Poule
{
    public enum BonusKeys
    {
        Kampioen,
        NL,
        Topscorer,
    }

    [Serializable]
    public struct Question
    {
        public string Answer;
        public int Points;
    }

    [Serializable]
    public class BonusQuestions
    {
        public Dictionary<BonusKeys, Question> Answers { get; private set; }

        public BonusQuestions(string kampioen, string topscorer, string NL)
        {
            Answers = new Dictionary<BonusKeys, Question>()
            {
                {BonusKeys.Kampioen, new Question(){Answer = kampioen, Points = 100 } },
                {BonusKeys.NL, new Question(){Answer = NL, Points = 100} },
                {BonusKeys.Topscorer, new Question(){Answer = topscorer, Points = 0, } },
            };
        }

        public int CheckBonus(BonusQuestions HostQuestions)
        {
            if (HostQuestions == null)
            {
                throw new ArgumentNullException();
            }
            int score = 0;

            foreach (var a in Answers)
            {
                var ans = HostQuestions.Answers[a.Key];
                if (a.Value.Answer == ans.Answer && ans.Answer != "")
                {
                    score += a.Value.Points;
                }
            }
            return score;
        }
    }
}
