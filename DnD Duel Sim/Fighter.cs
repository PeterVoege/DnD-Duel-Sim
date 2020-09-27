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
    class Fighter : ICharacter
    {
        public Fighter(ref DiceRoller rng)
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
        public Fighter(ref DiceRoller rng, int level, int maxHP, int HP, Race race, Background background, int[] stats, bool[] combatProficiencies, bool[] skillProficiencies, bool[] saveProficiencies, bool[] fightingStyles, MartialArchetype martialArchetype) // and so on
        {
            _rng = rng;
            _level = level;
            _maxHP = maxHP;
            _HP = HP;
            _hitDice = level;
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
        }
        
        /// Variables
        private DiceRoller _rng;
        private int _level;
        private int _maxHP;
        private int _HP;
        private int _hitDice;
        private Race _race;
        private Background _background;
        // proficiencies
        private bool[] _combatProficiencies;
        private bool[] _skillProfiencies;
        private bool[] _saveProficiencies;
        // Attributes
        private int _str;
        private int _dex;
        private int _con;
        private int _int;
        private int _wis;
        private int _cha;

        // Level
        public int GetLevel() => _level;
        public void SetLevel(int level) => _level = level;

        // Health
        public int GetMaxHP() => _maxHP;
        public void SetMaxHP(int maxHP) => _maxHP = maxHP;

        public int GetHP() => _HP;
        public void SetHP(int HP) => _HP = HP;

        // Hit dice
        public int GetMaxHitDice() => _level;
        public int GetHitDice() => _hitDice;
        public void SetHitDice(int hitDice) => _hitDice = hitDice;
        public int RollHitDice() => _rng.d10();

        // Race
        public Race GetRace() => _race;
        public void SetRace(Race race) => _race = race;

        // Background
        public Background GetBackground() => _background;
        public void SetBackground(Background background) => _background = background;

        /// Proficiencies
        // Weapons and armor
        public bool GetSimpleWeaponProficiency() => _combatProficiencies[0];
        public bool GetMartialWeaponProficiency() => _combatProficiencies[1];
        public bool GetLightArmorProficiency() => _combatProficiencies[2];
        public bool GetMediumArmorProficiency() => _combatProficiencies[3];
        public bool GetHeavyArmorProficiency() => _combatProficiencies[4];
        public bool GetShieldsProficiency() => _combatProficiencies[5];

        public void SetSimpleWeaponProficiency(bool newState) => _combatProficiencies[0] = newState;
        public void SetMartialWeaponProficiency(bool newState) => _combatProficiencies[1] = newState;
        public void SetLightArmorProficiency(bool newState) => _combatProficiencies[2] = newState;
        public void SetMediumArmorProficiency(bool newState) => _combatProficiencies[3] = newState;
        public void SetHeavyArmorProficiency(bool newState) => _combatProficiencies[4] = newState;
        public void SetShieldsProficiency(bool newState) => _combatProficiencies[5] = newState;
        
        // Str skills
        public bool GetAthleticsProficiency() => _skillProfiencies[0];
        // Dex skills
        public bool GetAcrobaticsProficiency() => _skillProfiencies[1];
        public bool GetSleightOfHandProficiency() => _skillProfiencies[2];
        public bool GetStealthProficiency() => _skillProfiencies[3];
        // Int skills
        public bool GetArcanaProficiency() => _skillProfiencies[4];
        public bool GetHistoryProficiency() => _skillProfiencies[5];
        public bool GetInvestigationProficiency() => _skillProfiencies[6];
        public bool GetNatureProficiency() => _skillProfiencies[7];
        public bool GetReligionProficiency() => _skillProfiencies[8];
        // Wis skills
        public bool GetAnimalHandlingProficiency() => _skillProfiencies[9];
        public bool GetInsightProficiency() => _skillProfiencies[10];
        public bool GetMedicineProficiency() => _skillProfiencies[11];
        public bool GetPerceptionProficiency() => _skillProfiencies[12];
        public bool GetSurvivalProficiency() => _skillProfiencies[13];
        // Cha skills
        public bool GetDeceptionProficiency() => _skillProfiencies[14];
        public bool GetIntimidationProficiency() => _skillProfiencies[15];
        public bool GetPerformanceProficiency() => _skillProfiencies[16];
        public bool GetPersuasionProficiency() => _skillProfiencies[17];

        // Str skills
        public void SetAthleticsProficiency(bool newState) => _skillProfiencies[0] = newState;
        // Dex skills
        public void SetAcrobaticsProficiency(bool newState) => _skillProfiencies[1] = newState;
        public void SetSleightOfHandProficiency(bool newState) => _skillProfiencies[2] = newState;
        public void SetStealthProficiency(bool newState) => _skillProfiencies[3] = newState;
        // Int skills
        public void SetArcanaProficiency(bool newState) => _skillProfiencies[4] = newState;
        public void SetHistoryProficiency(bool newState) => _skillProfiencies[5] = newState;
        public void SetInvestigationProficiency(bool newState) => _skillProfiencies[6] = newState;
        public void SetNatureProficiency(bool newState) => _skillProfiencies[7] = newState;
        public void SetReligionProficiency(bool newState) => _skillProfiencies[8] = newState;
        // Wis skills
        public void SetAnimalHandlingProficiency(bool newState) => _skillProfiencies[9] = newState;
        public void SetInsightProficiency(bool newState) => _skillProfiencies[10] = newState;
        public void SetMedicineProficiency(bool newState) => _skillProfiencies[11] = newState;
        public void SetPerceptionProficiency(bool newState) => _skillProfiencies[12] = newState;
        public void SetSurvivalProficiency(bool newState) => _skillProfiencies[13] = newState;
        // Cha skills
        public void SetDeceptionProficiency(bool newState) => _skillProfiencies[14] = newState;
        public void SetIntimidationProficiency(bool newState) => _skillProfiencies[15] = newState;
        public void SetPerformanceProficiency(bool newState) => _skillProfiencies[16] = newState;
        public void SetPersuasionProficiency(bool newState) => _skillProfiencies[17] = newState;

        // Saves
        public bool GetStrSaveProficiency() => _saveProficiencies[0];
        public void SetStrSaveProficiency(bool newState) => _saveProficiencies[0] = newState;
        public bool GetDexSaveProficiency() => _saveProficiencies[1];
        public void SetDexSaveProficiency(bool newState) => _saveProficiencies[1] = newState;
        public bool GetConSaveProficiency() => _saveProficiencies[2];
        public void SetConSaveProficiency(bool newState) => _saveProficiencies[2] = newState;
        public bool GetIntSaveProficiency() => _saveProficiencies[3];
        public void SetIntSaveProficiency(bool newState) => _saveProficiencies[3] = newState;
        public bool GetWisSaveProficiency() => _saveProficiencies[4];
        public void SetWisSaveProficiency(bool newState) => _saveProficiencies[4] = newState;
        public bool GetChaSaveProficiency() => _saveProficiencies[5];
        public void SetChaSaveProficiency(bool newState) => _saveProficiencies[5] = newState;

        // Custom proficiencies? (i.e. tools and such)

        // Proficiency bonus.
        public int GetProficiencyBonus() => 2 + (_level - 1) / 4;


        // Attributes
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

        public int GetStrMod() => _str / 2 - 5;
        public int GetDexMod() => _dex / 2 - 5;
        public int GetConMod() => _con / 2 - 5;
        public int GetIntMod() => _int / 2 - 5;
        public int GetWisMod() => _wis / 2 - 5;
        public int GetChaMod() => _cha / 2 - 5;

        // Ability checks
        public int RollStrCheck() => _rng.d20() + GetStrMod(); // Remarkable Athlete?
        public int RollDexCheck() => _rng.d20() + GetDexMod();
        public int RollConCheck() => _rng.d20() + GetConMod();
        public int RollIntCheck() => _rng.d20() + GetIntMod();
        public int RollWisCheck() => _rng.d20() + GetWisMod();
        public int RollChaCheck() => _rng.d20() + GetChaMod();

        // Saving throws
        public int GetStrSaveMod() => GetStrMod(); // Plus proficiency.
        public int GetDexSaveMod() => GetDexMod(); // Plus proficiency.
        public int GetConSaveMod() => GetConMod(); // Plus proficiency.
        public int GetIntSaveMod() => GetIntMod(); // Plus proficiency.
        public int GetWisSaveMod() => GetWisMod(); // Plus proficiency.
        public int GetChaSaveMod() => GetChaMod(); // Plus proficiency.
        
        public int RollStrSave() => _rng.d20() + GetStrSaveMod();
        public int RollDexSave() => _rng.d20() + GetDexSaveMod();
        public int RollConSave() => _rng.d20() + GetConSaveMod();
        public int RollIntSave() => _rng.d20() + GetIntSaveMod();
        public int RollWisSave() => _rng.d20() + GetWisSaveMod();
        public int RollChaSave() => _rng.d20() + GetChaSaveMod();

        /// Skill checks.
        // Str skills
        // Remarkable Athlete applies here, returning half proficiency if no regular proficiency exists.
        public int RollAthleticsCheck() => _rng.d20() + GetStrMod() + Math.Max(
            (GetAthleticsProficiency() ? GetProficiencyBonus() : 0), 
            (RemarkableAthlete() ? RemarkableAthleteBonus() : 0));
        // Dex skills
        public int RollAcrobaticsCheck() => _rng.d20() + GetDexMod() + Math.Max(
            (GetAcrobaticsProficiency() ? GetProficiencyBonus() : 0),
            (RemarkableAthlete() ? RemarkableAthleteBonus() : 0));
        public int RollSleightOfHandCheck() => _rng.d20() + GetDexMod() + Math.Max(
            (GetSleightOfHandProficiency() ? GetProficiencyBonus() : 0),
            (RemarkableAthlete() ? RemarkableAthleteBonus() : 0));
        public int RollStealthCheck() => _rng.d20() + GetDexMod() + Math.Max(
            (GetStealthProficiency() ? GetProficiencyBonus() : 0),
            (RemarkableAthlete() ? RemarkableAthleteBonus() : 0));
        // Int skills
        // Remarkable Athlete stops applying here.
        public int RollArcanaCheck() => _rng.d20() + GetIntMod() + (GetArcanaProficiency() ? GetProficiencyBonus() : 0);
        public int RollHistoryCheck() => _rng.d20() + GetIntMod() + (GetHistoryProficiency() ? GetProficiencyBonus() : 0);
        public int RollInvestigationCheck() => _rng.d20() + GetIntMod() + (GetInvestigationProficiency() ? GetProficiencyBonus() : 0);
        public int RollNatureCheck() => _rng.d20() + GetIntMod() + (GetNatureProficiency() ? GetProficiencyBonus() : 0);
        public int RollReligionCheck() => _rng.d20() + GetIntMod() + (GetReligionProficiency() ? GetProficiencyBonus() : 0);
        // Wis skills
        public int RollAnimalHandlingCheck() => _rng.d20() + GetWisMod() + (GetAnimalHandlingProficiency() ? GetProficiencyBonus() : 0);
        public int RollInsightCheck() => _rng.d20() + GetWisMod() + (GetInsightProficiency() ? GetProficiencyBonus() : 0);
        public int RollMedicineCheck() => _rng.d20() + GetWisMod() + (GetMedicineProficiency() ? GetProficiencyBonus() : 0);
        public int RollPerceptionCheck() => _rng.d20() + GetWisMod() + (GetPerceptionProficiency() ? GetProficiencyBonus() : 0);
        public int RollSurvivalCheck() => _rng.d20() + GetWisMod() + (GetSurvivalProficiency() ? GetProficiencyBonus() : 0);
        // Cha skills
        public int RollDeceptionCheck() => _rng.d20() + GetChaMod() + (GetDeceptionProficiency() ? GetProficiencyBonus() : 0);
        public int RollIntimidationCheck() => _rng.d20() + GetChaMod() + (GetIntimidationProficiency() ? GetProficiencyBonus() : 0);
        public int RollPerformanceCheck() => _rng.d20() + GetChaMod() + (GetPerformanceProficiency() ? GetProficiencyBonus() : 0);
        public int RollPersuasionCheck() => _rng.d20() + GetChaMod() + (GetPersuasionProficiency() ? GetProficiencyBonus() : 0);


        // Attacking
        public int AttackRoll() => _rng.d20() + GetStrMod() + GetProficiencyBonus();
        public int DamageRoll() => _rng.d8() + GetStrMod();
        // Assumes static weapon, will expand later.

        // Armor class
        // 16 from chainmail + 2 from shield
        public int GetArmorAC()
        {
            // Get max of all owned options.
            return 16;
        }
        public bool GetShield() => true;
        public int GetAC() => GetArmorAC() + (GetShield() ? 2 : 0);

        // Initiative
        public int RollInitiative() => RollDexCheck();

        // Speed
        public int GetSpeed()
        {
            return CharRace.GetRacialSpeed(GetRace());
        }

        // Fighter-specific things

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
        // Take turn

        public void TakeTurn()
        {
            int standardActions = 1;
            int bonusActions = 1;
            //int distanceRemaining = GetSpeed(); // Movement not used in sim yet.

            // Check options
            // Make action
            // Repeat until out of viable actions

            // In practice, follow set orders.

            standardActions--;
            int toHit = AttackRoll();
            // Check if hit
            int damage = DamageRoll();
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

        public void TakeShortRest()
        {
            SetSecondWindAvailability(true);
        }
        public void TakeLongRest()
        {

        }
    }
}
