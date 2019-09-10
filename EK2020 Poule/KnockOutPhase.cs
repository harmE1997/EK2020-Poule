using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2018_Poule
{
    public enum KOKeys
    {
        sixteen,
        quarter,
        semi,
        final,
        champ
    }

    public struct Stage
    {
        public int award;
        public string[] teams;
    }

    [Serializable]
    public class KnockOutPhase
    {
        public Dictionary<KOKeys ,Stage>Stages { get; private set; }

        public KnockOutPhase(string[] last16, string[] last8, string[] last4, string[] final, string[] champion)
        {
            if (last16 == null || last8 == null || last4 == null || final == null || champion == null)
            {
                throw new ArgumentNullException();
            }

            Stages = new Dictionary<KOKeys, Stage>()
            {
                {KOKeys.sixteen, new Stage() { award = 25, teams = last16 } },
                {KOKeys.quarter, new Stage() { award = 50, teams = last8 } },
                {KOKeys.semi, new Stage() { award = 100, teams = last4 } },
                {KOKeys.final, new Stage() { award = 200, teams = final } },
                {KOKeys.champ, new Stage() { award = 250, teams = champion } }
            };
        }

        public int checkKnockoutPhase(KnockOutPhase KO)
        {
            if (KO == null)
            {
                return -1;
            }

            int Score = 0;

            foreach (var stage in Stages)
            {
                foreach (var team in stage.Value.teams)
                {
                    if (KO.Stages[stage.Key].teams.Contains(team))
                    {
                        Score += stage.Value.award;
                    }
                }
            }

            return Score;
        }
    }
}
