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

    interface ICharacter
    {
        int GetLevel();
        void SetLevel(int level);

        int GetMaxHP();
        void SetMaxHP(int maxHP);
        int GetHP();
        void SetHP(int HP);

        int GetMaxHitDice();
        int GetHitDice();
        void SetHitDice(int hitDice);
        int RollHitDice();

        Race GetRace();
        void SetRace(Race race);
        Background GetBackground();
        void SetBackground(Background background);

        int GetStr();
        int GetDex();
        int GetCon();
        int GetInt();
        int GetWis();
        int GetCha();

        void SetStr(int Str);
        void SetDex(int Dex);
        void SetCon(int Con);
        void SetInt(int Int);
        void SetWis(int Wis);
        void SetCha(int Cha);

        int GetStrMod();
        int GetDexMod();
        int GetConMod();
        int GetIntMod();
        int GetWisMod();
        int GetChaMod();
    }
}
