using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2018_Poule
{
    [Serializable]
    public class BonusQuestions
    {
        public int nrGoals { get; private set; }
        public int nrOwnGoals { get; private set; }
        public int nrYellowCards { get; private set; }
        public int nrRedCards { get; private set; }
        public string Topscorer { get; private set; }

        public BonusQuestions(int goals, int owngoals, int yellows, int reds, string topscorer)
        {
            if (string.IsNullOrEmpty(topscorer))
            {
                throw new ArgumentNullException();
            }
            nrGoals = goals;
            nrOwnGoals = owngoals;
            nrRedCards = reds;
            nrYellowCards = yellows;
            Topscorer = topscorer;
        }

        public int checkQuestions(BonusQuestions answers)
        {
            if (answers == null)
            {
                return -1;
            }

            int Score = 0;
 
            if (answers.nrGoals != 0)
            {
                int miss = Math.Abs(nrGoals - answers.nrGoals);
                int minpoints = miss * 4;
                if (minpoints > 200)
                {
                    minpoints = 200;
                }
                Score += (200 - minpoints);
            }

            if (answers.nrOwnGoals != 0)
            {
                int miss = Math.Abs(nrOwnGoals - answers.nrOwnGoals);
                int minpoints = miss * 30;
                if (minpoints > 100)
                {
                    minpoints = 100;
                }
                Score += (100 - minpoints);
            }

            if (answers.nrYellowCards != 0)
            {
                int miss = Math.Abs(nrYellowCards - answers.nrYellowCards);
                int minpoints = miss * 4;
                if (minpoints > 200)
                {
                    minpoints = 200;
                }
                Score += (200 - minpoints);
            }

            if (answers.nrRedCards != 0)
            {
                int miss = Math.Abs(nrRedCards - answers.nrRedCards);
                int minpoints = miss * 20;
                if (minpoints > 100)
                {
                    minpoints = 100;
                }
                Score += (100 - minpoints);
            }

            if (!string.IsNullOrEmpty(answers.Topscorer))
            {
                if (answers.Topscorer == Topscorer)
                {
                    Score += 100;
                }
            }

            return Score;
        }
    }
}
