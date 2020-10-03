using System;
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

        public static string GetString(Race race)
        {
            switch (race)
            {
                case Race.HillDwarf:
                    return "Hill Dwarf";
                case Race.MountainDwarf:
                    return "Mountain Dwarf";
                case Race.HighElf:
                    return "High Elf";
                case Race.WoodElf:
                    return "Wood Elf";
                case Race.DarkElf:
                    return "Dark Elf";
                case Race.LightfootHalfling:
                    return "Lightfoot Halfling";
                case Race.StoutHalfling:
                    return "Stout Halfling";
                case Race.Human:
                    return "Human";
                case Race.Dragonborn:
                    return "Dragonborn";
                case Race.ForestGnome:
                    return "Forest Gnome";
                case Race.RockGnome:
                    return "Rock Gnome";
                case Race.HalfElf:
                    return "Half-Elf";
                case Race.HalfOrc:
                    return "Half-Orc";
                case Race.Tiefling:
                    return "Tiefling";
                default:
                    return "Unknown";
            }
        }
    }
}
