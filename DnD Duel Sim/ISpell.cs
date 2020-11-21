using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Duel_Sim
{
    public interface ISpell
    {

        int GetSpellLevel();
        int GetRange();
        int GetDuration();
        bool IsConcentration();
    }
}
