﻿using System;
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

    [Serializable]
    public struct Stage
    {
        public int award;
        public List<string> teams;
    }

    [Serializable]
    public class KnockOutPhase
    {
        public Dictionary<KOKeys ,Stage>Stages { get; private set; }

        public KnockOutPhase()
        {
            Stages = new Dictionary<KOKeys, Stage>()
            {
                {KOKeys.sixteen, new Stage() { award = 25, teams = new List<string>() } },
                {KOKeys.quarter, new Stage() { award = 50, teams = new List<string>()} },
                {KOKeys.semi, new Stage() { award = 100, teams = new List<string>() } },
                {KOKeys.final, new Stage() { award = 200, teams = new List<string>() } },
                {KOKeys.champ, new Stage() { award = 250, teams = new List<string>() } }
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
