using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2018_Poule
{
    [Serializable]
    public class KnockOutPhase
    {
        public string[] Last16 { get; private set; }
        public string[] Last8 { get; private set; }
        public string[] Last4 { get; private set; }
        public string[] Final { get; private set; }
        public string Bronze { get; private set; }
        public string Champion { get; private set; }

        public KnockOutPhase(string[] last16, string[] last8, string[] last4, string[] final, string bronze, string champion)
        {
            if (last16 == null || last8 == null || last4 == null || final == null || string.IsNullOrEmpty(bronze) || string.IsNullOrEmpty(champion))
            {
                throw new ArgumentNullException();
            }
            Last16 = last16;
            Last8 = last8; 
            Last4 = last4;
            Final = final;
            Bronze = bronze;
            Champion = champion; 
        }

        public int checkKnockoutPhase(KnockOutPhase KO)
        {
            if (KO == null)
            {
                return -1;
            }
            int Score = 0;
            foreach (string team in Last16)
            {
                if (KO.Last16.Contains(team))
                {
                    Score += 25;
                }
            }

            foreach (string team in Last8)
            {
                if (KO.Last8.Contains(team))
                {
                    Score += 50;
                }
            }

            foreach (string team in Last4)
            {
                if (KO.Last4.Contains(team))
                {
                    Score += 100;
                }
            }

            foreach (string team in Final)
            {
                if (KO.Final.Contains(team))
                {
                    Score += 200;
                }
            }

            if (KO.Bronze == Bronze)
            {
                Score += 150;
            }

            if (KO.Champion == Champion)
            {
                Score += 250;
            }

            return Score;
        }
    }
}
