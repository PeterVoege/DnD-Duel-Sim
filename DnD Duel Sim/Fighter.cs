using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Duel_Sim
{
    class Fighter : ICharacter
    {
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
