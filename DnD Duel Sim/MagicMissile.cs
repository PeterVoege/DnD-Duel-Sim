using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Duel_Sim
{
    class MagicMissile : ISpell
    {
        private string _name;
        private int _level;
        private int _range;
        private int _duration;
        private bool[] _components;

        private ICharacter _user;
        private ICharacter _target; // TODO: multi-target.

        // internal variables
        private DamageType _dType;
        private int _bolts;
        private int _boltsPerLevel;


        public MagicMissile(string name, DamageType dType, string baseDice, int bolts, int boltsPerLevel) // Take in list of parameters
        {
            _name = name; // default Magic Missile
            _dType = dType; // default Force
            // base damage (default 1d4 + 1 per bolt)
            _bolts = bolts; // default 3
            _boltsPerLevel = boltsPerLevel; // default 1

            // user, target(s)

            // list of targets must be determined with number of bolts as reference.
            // Shouldn't be assumed how it works before creating spell.
            // Make spell, then check num of targets, then pick targets.

            // User makes spell
            // User queries spell about itself, what information it needs
            // User sets required information within the spell
            // User uses spell.

            // More considerations:
            // AoE
            // Point of origin
            // Direction
            // Line of sight?
            // Check for if user is already concentrating.
            // Castable as reaction?
            // Effect on enemy reaction?
        }

        // Name of the specific spell.
        public string GetName() => _name;
        // Minimum level the spell can be cast at
        public int GetSpellLevel() => _level;
        // How far away the spell can reach (used in targetting)
        public int GetRange() => _range;
        // How long the spell lasts.
        public int GetDuration() => _duration;
        // Spells of this type are purely instantaneous.
        public bool IsConcentration() => false;

        // Function to return what information the user needs to provide?

        // Filling in details.
        public void SetUser(ICharacter user) => _user = user;
        //public int SetSpellLevel(int lv) => _level = lv;
        public void SetTarget(ICharacter target) => _target = target;
        
        // Checks if everything that needs to be specified has been.
        public bool CanUse()
        {
            if (_user == null) return false;
            if (_target == null) return false;
            return true;
        }
        
        // internal function
        private int NumberOfMissiles()
        {
            return _bolts + _boltsPerLevel * (_level - 1);
        }
        
        // The core effect of the spell.
        public void InstantaneousEffect() {
            // Get attack roll from user.
            // Get AC of target.
            // Calculate hit.
            // Roll damage.
            // Apply damage.
        }

        // Empty, as Magic Missle does not persist.
        public void OnTurnStart() { }

        // Naive calculation
        public double ExpectedDamage()
        {
            return 3.5 * NumberOfMissiles();
        }
    }
}
