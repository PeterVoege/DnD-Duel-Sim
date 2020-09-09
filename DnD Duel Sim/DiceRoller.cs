using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Duel_Sim
{
    public class DiceRoller
    {
        Random _rng;
        public DiceRoller()
        {
            _rng = new Random();
        }

        public int d4() => 1 + (_rng.Next() % 4);
        public int d6() => 1 + (_rng.Next() % 6);
        public int d8() => 1 + (_rng.Next() % 8);
        public int d10() => 1 + (_rng.Next() % 10);
        public int d12() => 1 + (_rng.Next() % 12);
        public int d20() => 1 + (_rng.Next() % 20);

        public int Multidice(int type, int quantity)
        {

            return 0;
        }
    }
}
