using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Duel_Sim
{
    class Fighter : ICharacter
    {
        // Dice Roller
        private DiceRoller _rng;
        
        // Level
        private int _level;
        public int GetLevel() => _level;
        public void SetLevel(int level) => _level = level;

        // Health
        private int _maxHP;
        public int GetMaxHP() => _maxHP;
        public void SetMaxHP(int maxHP) => _maxHP = maxHP;

        private int _HP;
        public int GetHP() => _HP;
        public void SetHP(int HP) => _HP = HP;

        // Hit dice
        private int _hitDice;
        public int GetMaxHitDice() => _level;
        public int GetHitDice() => _hitDice;
        public void SetHitDice(int hitDice) => _hitDice = hitDice;
        public int RollHitDice() => _rng.d10();

        // Race
        private Race _race;
        public Race GetRace() => _race;
        public void SetRace(Race race) => _race = race;

        // Background
        private Background _background;
        public Background GetBackground() => _background;
        public void SetBackground(Background background) => _background = background;

        private int _str;
        private int _dex;
        private int _con;
        private int _int;
        private int _wis;
        private int _cha;

        public int GetStr() => _str;
        public int GetDex() => _dex;
        public int GetCon() => _con;
        public int GetInt() => _int;
        public int GetWis() => _wis;
        public int GetCha() => _cha;

        public void SetStr(int Str) => _str = Str;
        public void SetDex(int Dex) => _dex = Dex;
        public void SetCon(int Con) => _con = Con;
        public void SetInt(int Int) => _int = Int;
        public void SetWis(int Wis) => _wis = Wis;
        public void SetCha(int Cha) => _cha = Cha;

        public int GetStrMod() => (_str - 10) / 2;
        public int GetDexMod() => (_dex - 10) / 2;
        public int GetConMod() => (_con - 10) / 2;
        public int GetIntMod() => (_int - 10) / 2;
        public int GetWisMod() => (_wis - 10) / 2;
        public int GetChaMod() => (_cha - 10) / 2;
    }
}
