using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Duel_Sim
{
    public static class SpellOverseer
    {
        // Maps spell effects as-stored in database to defined spell effects

        // Stored as such: [name, spell, List of parameters]

        // Name is the unique name of the spell, 'spell' is the reference to the mechanics.

        // List<parameters> = List<<string>,<Object>>
        // The list contains entries containing some defined variable type and a variable of that type
        // Parameters are assembled from the list and sent to the spell constructor.
        // Mayhaps instead of variable type, store variable name?  Would keep things neater.
        

        public static ISpell GetEffect(string effectName)
        {
            switch (effectName)
            {
                case "MagicMissile": // Rolls against AC and deals damage on success
                    return new MagicMissile("Magic Missile", DamageType.Force, "1d4+1", 3, 1);
                case "SaveForHalf": // Makes foe make a save, if they fail then returns a 0.5 multiplier.
                    break;
                case "SaveForHalfDefaultAttack": // Uses a SaveForHalf effect and then deals damage.
                    break;
            }
            return new MagicMissile("Magic Missile", DamageType.Force, "1d4+1", 3, 1);
        }


    }
}
