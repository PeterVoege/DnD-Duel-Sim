using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Duel_Sim
{
    public enum MartialArchetype
    {
        None,
        Champion,
        BattleMaster,
        EldritchKnight
    }
    class Fighter : Character
    {
        public Fighter(ref DiceRoller rng) : base(ref rng)
        {
            _rng = rng;
            _level = 1;
            _maxHP = 10;
            _HP = 10;
            _hitDice = 1;
            _race = Race.Human;
            _background = Background.Soldier;
            _str = 10;
            _dex = 10;
            _con = 10;
            _int = 10;
            _wis = 10;
            _cha = 10;
        }
        public Fighter(ref DiceRoller rng, string shortName, string longName, int level, int maxHP, int HP, Race race, Background background, int[] stats, bool[] combatProficiencies, bool[] skillProficiencies, bool[] saveProficiencies,
            bool[] fightingStyles, MartialArchetype martialArchetype) : base(ref rng, shortName, longName, level, maxHP, HP, race, background, stats, combatProficiencies, skillProficiencies, saveProficiencies) // and so on
        {
            _rng = rng;
            _shortName = shortName;
            _longName = longName;
            _level = level;
            _maxHP = maxHP;
            _HP = HP;
            _hitDice = level;
            _status = CharStatus.Normal;
            _deathSavesPassed = 0;
            _deathSavesFailed = 0;
            _race = race;
            _background = background;
            _str = stats[0];
            _dex = stats[1];
            _con = stats[2];
            _int = stats[3];
            _wis = stats[4];
            _cha = stats[5];
            /// Proficiencies (not properly initialized)
            // By default fighter gets: all armor, shields, simple/martial weapons, str/con saves, and two selected skills.
            _combatProficiencies = combatProficiencies;

            // 18 different skills
            _skillProfiencies = skillProficiencies;
            //_skillProfiencies = new bool[18] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };

            // 6 different saves
            _saveProficiencies = saveProficiencies;
            //_saveProficiencies = new bool[6] { false, false, false, false, false, false };

            // Fighting styles

            _martialArchetype = martialArchetype;

            // battle master maneuvers (16)
        }
        
        // Remarkable Athlete skill check override
        public override int RollStrCheck() => _rng.d20() + GetStrMod(); // Remarkable Athlete?
        public override int RollDexCheck() => _rng.d20() + GetDexMod();
        public override int RollConCheck() => _rng.d20() + GetConMod();
        public override int RollIntCheck() => _rng.d20() + GetIntMod();
        public override int RollWisCheck() => _rng.d20() + GetWisMod();
        public override int RollChaCheck() => _rng.d20() + GetChaMod();

        // Remarkable Athlete skill check override
        // Str skills
        public override int RollAthleticsCheck() => _rng.d20() + GetStrMod() + Math.Max(
            (GetAthleticsProficiency() ? GetProficiencyBonus() : 0), 
            (RemarkableAthlete() ? RemarkableAthleteBonus() : 0));
        // Dex skills
        public override int RollAcrobaticsCheck() => _rng.d20() + GetDexMod() + Math.Max(
            (GetAcrobaticsProficiency() ? GetProficiencyBonus() : 0),
            (RemarkableAthlete() ? RemarkableAthleteBonus() : 0));
        public override int RollSleightOfHandCheck() => _rng.d20() + GetDexMod() + Math.Max(
            (GetSleightOfHandProficiency() ? GetProficiencyBonus() : 0),
            (RemarkableAthlete() ? RemarkableAthleteBonus() : 0));
        public override int RollStealthCheck() => _rng.d20() + GetDexMod() + Math.Max(
            (GetStealthProficiency() ? GetProficiencyBonus() : 0),
            (RemarkableAthlete() ? RemarkableAthleteBonus() : 0));
        
        // Fighter-specific things

        // Fighting styles
        //private bool _archery;
        //private bool _defense;
        //private bool _dueling;
        //private bool _greatWeaponFighting;
        //private bool _protection;
        //private bool _twoWeaponFighting;

        // Second Wind
        public bool SecondWindUnlocked() => true;
        public void UseSecondWind()
        {
            SetHP(Math.Min(GetHP() + GetLevel() + _rng.d10(), GetMaxHP()));
            SetSecondWindAvailability(false);
        }
        public int MaxSecondWind() => 10 + GetLevel(); // For determining when to use it.
        // Cooldown
        bool _secondWindAvailable;
        public bool IsSecondWindAvailable() => _secondWindAvailable;
        public void SetSecondWindAvailability(bool availability) => _secondWindAvailable = availability;

        // Action Surge
        public bool ActionSurgeUnlocked() => GetLevel() >= 2;

        // Martial Archetype
        private MartialArchetype _martialArchetype;
        public MartialArchetype GetMartialArchetype() => _martialArchetype;
        public void SetMartialArchetype(MartialArchetype martialArchetype) => _martialArchetype = martialArchetype;

        // Champion feats
        public bool ImprovedCritical() => GetMartialArchetype() == MartialArchetype.Champion;
        public bool RemarkableAthlete() => (GetMartialArchetype() == MartialArchetype.Champion) && (GetLevel() >= 7);
        public int RemarkableAthleteBonus() => (int)Math.Ceiling((double)GetProficiencyBonus() / 2);
        // Additional fighting style.
        public bool SuperiorCritical() => (GetMartialArchetype() == MartialArchetype.Champion) && (GetLevel() >= 15);
        public bool Survivor() => (GetMartialArchetype() == MartialArchetype.Champion) && (GetLevel() >= 18);

        // Battle Master
        // Maneuvers
        // Commander's Strike, Disarming Attack, Distracting Strike, Evasive Footwork, Feinting Attack, Goading Attack, Lunging Attack, Maneuvering Attack, Menacing Attack, Parry, Precision Attack, Pushing Attack, Rally, Riposte, Sweeping Attack, Trip Attack.


        // Function to determine all actions available to Fighter?

        // Take turn
        public override void TakeTurn()
        {
            int standardActions = 1;
            int bonusActions = 1;
            //int distanceRemaining = GetSpeed(); // Movement not used in sim yet.

            // Check options
            // Make action
            // Repeat until out of viable actions

            // In practice, follow set orders.

            standardActions--;
            Tuple<int, int> attackRoll = AttackRoll(0);
            
            bool crit = (attackRoll.Item1 >= 20); // Check if crit
            // Check if hit
            int damage = DamageRoll(crit);
            // Send damage data to battle controller.
            // Check for second/third attack.

            if(bonusActions > 0)
            {
                if (GetHP() + MaxSecondWind() <= GetMaxHP())
                {
                    UseSecondWind();
                }
            }
            
            
        }

        public override void TakeShortRest()
        {
            SetSecondWindAvailability(true);
        }
        public override void TakeLongRest()
        {

        }
    }
}
