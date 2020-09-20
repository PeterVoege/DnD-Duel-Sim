﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Duel_Sim
{
    public enum Race
    {
        HillDwarf,
        MountainDwarf,
        HighElf,
        WoodElf,
        DarkElf,
        LightfootHalfling,
        StoutHalfling,
        Human,
        Dragonborn,
        ForestGnome,
        RockGnome,
        HalfElf,
        HalfOrc,
        Tiefling
    }
    public static class CharRace
    {
        public static int GetRacialSpeed(Race race)
        {
            switch (race)
            {
                case Race.HillDwarf:
                    return 25;
                case Race.MountainDwarf:
                    return 25;
                case Race.HighElf:
                    return 30;
                case Race.WoodElf:
                    return 35;
                case Race.DarkElf:
                    return 30;
                case Race.LightfootHalfling:
                    return 25;
                case Race.StoutHalfling:
                    return 25;
                case Race.Human:
                    return 30;
                case Race.Dragonborn:
                    return 30;
                case Race.ForestGnome:
                    return 25;
                case Race.RockGnome:
                    return 25;
                case Race.HalfElf:
                    return 30;
                case Race.HalfOrc:
                    return 30;
                case Race.Tiefling:
                    return 30;
                default:
                    return 30;
            }
        }
    }
}
