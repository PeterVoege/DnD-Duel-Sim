using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Duel_Sim
{
    public enum Background
    {
        Acolyte,
        Charlatan,
        Criminal,
        Entertainer,
        FolkHero,
        GuildArtisan,
        Hermit,
        Noble,
        Outlander,
        Sage,
        Sailor,
        Soldier,
        Urchin
    }

    public static class CharBackground
    {
        public static string GetString(Background background)
        {
            switch (background)
            {
                case Background.Acolyte:
                    return "Acolyte";
                case Background.Charlatan:
                    return "Charlatan";
                case Background.Criminal:
                    return "Criminal";
                case Background.Entertainer:
                    return "Entertainer";
                case Background.FolkHero:
                    return "Folk Hero";
                case Background.GuildArtisan:
                    return "Guild Artisan";
                case Background.Hermit:
                    return "Hermit";
                case Background.Noble:
                    return "Noble";
                case Background.Outlander:
                    return "Outlander";
                case Background.Sage:
                    return "Sage";
                case Background.Sailor:
                    return "Sailor";
                case Background.Soldier:
                    return "Soldier";
                case Background.Urchin:
                    return "Urchin";
                default:
                    return "Unknown";
            }
        }
    }
}
