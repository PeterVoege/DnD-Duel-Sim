using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Duel_Sim
{
    class Character : ICharacter
    {
        public Character(ref DiceRoller rng)
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
        public Character(ref DiceRoller rng, string shortName, string longName, int level, int maxHP, int HP, Race race, Background background, int[] stats, bool[] combatProficiencies, bool[] skillProficiencies, bool[] saveProficiencies) // and so on
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
        }

        /// Variables
        protected DiceRoller _rng;
        protected string _shortName;
        protected string _longName;
        protected int _level;
        protected int _maxHP;
        protected int _HP;
        protected int _hitDice;
        protected CharStatus _status;
        protected int _deathSavesPassed;
        protected int _deathSavesFailed;
        protected Race _race;
        protected Background _background;
        // proficiencies
        protected bool[] _combatProficiencies;
        protected bool[] _skillProfiencies;
        protected bool[] _saveProficiencies;
        // Attributes
        protected int _str;
        protected int _dex;
        protected int _con;
        protected int _int;
        protected int _wis;
        protected int _cha;


        // Name
        public string GetShortName() => _shortName;
        public void SetShortName(string name) => _shortName = name;
        public string GetLongName() => _longName;
        public void SetLongName(string name) => _longName = name;

        // Level
        public int GetLevel() => _level;
        public void SetLevel(int level) => _level = level;

        // Health
        public int GetMaxHP() => _maxHP;
        public void SetMaxHP(int maxHP) => _maxHP = maxHP;

        public int GetHP() => _HP;
        public void SetHP(int HP) => _HP = HP;

        public void ChangeHP(int delta) => SetHP(GetHP() + delta);
        public void Heal(int delta) => SetHP(Math.Min(GetHP() + delta, GetMaxHP()));
        public void Damage(int delta) => SetHP(Math.Max(GetHP() - delta, 0));
        
        // Hit dice
        public int GetMaxHitDice() => _level;
        public int GetHitDice() => _hitDice;
        public void SetHitDice(int hitDice) => _hitDice = hitDice;
        public int RollHitDice() => _rng.d10();

        // Status
        public CharStatus GetStatus() => _status;
        public void SetStatus(CharStatus newStatus) => _status = newStatus;


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
        public virtual int RollStrCheck() => _rng.d20() + GetStrMod();
        public virtual int RollDexCheck() => _rng.d20() + GetDexMod();
        public virtual int RollConCheck() => _rng.d20() + GetConMod();
        public virtual int RollIntCheck() => _rng.d20() + GetIntMod();
        public virtual int RollWisCheck() => _rng.d20() + GetWisMod();
        public virtual int RollChaCheck() => _rng.d20() + GetChaMod();

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

        // Death saves
        public int GetDeathSavesFailed() => _deathSavesFailed;
        public void SetDeathSavesFailed(int fails) => _deathSavesFailed = fails;
        public int GetDeathSavesPassed() => _deathSavesPassed;
        public void SetDeathSavesPassed(int passes) => _deathSavesPassed = passes;

        public int RollDeathSave() => _rng.d20();
        // Roll, revived, stabilized, died.
        public Tuple<int, bool, bool, bool> MakeDeathSave()
        {
            int roll = this.RollDeathSave();
            bool revived = false;
            bool stabilized = false;
            bool died = false;

            if (roll == 20) // revive to 1 HP
            {
                this.SetHP(1);
                SetStatus(CharStatus.Normal);
                SetDeathSavesFailed(0);
                SetDeathSavesPassed(0);
                revived = true;
            }
            else if (roll == 1) // Two failed saves
            {
                this._deathSavesFailed = Math.Min(_deathSavesFailed + 2, 3);
            }
            else if (roll >= 10) // One passed save
            {
                this._deathSavesPassed = Math.Min(_deathSavesPassed + 1, 3);
            }
            else // One failed save
            {
                this._deathSavesFailed = Math.Min(_deathSavesFailed + 1, 3);
            }

            if (_deathSavesPassed >= 3) // Stabilized
            {
                SetStatus(CharStatus.Stable);
                SetDeathSavesFailed(0);
                SetDeathSavesPassed(0);
                stabilized = true;
            }
            if (GetDeathSavesFailed() >= 3)
            {
                SetStatus(CharStatus.Dead);
                died = true;
            }
            return new Tuple<int, bool, bool, bool>(roll, revived, stabilized, died);
        }

        /// Skill checks.
        // Str skills
        public virtual int RollAthleticsCheck() => _rng.d20() + GetStrMod() + (GetAthleticsProficiency() ? GetProficiencyBonus() : 0);
        // Dex skills
        public virtual int RollAcrobaticsCheck() => _rng.d20() + GetDexMod() + (GetAcrobaticsProficiency() ? GetProficiencyBonus() : 0);
        public virtual int RollSleightOfHandCheck() => _rng.d20() + GetDexMod() + (GetSleightOfHandProficiency() ? GetProficiencyBonus() : 0);
        public virtual int RollStealthCheck() => _rng.d20() + GetDexMod() + (GetStealthProficiency() ? GetProficiencyBonus() : 0);
        // Int skills
        public virtual int RollArcanaCheck() => _rng.d20() + GetIntMod() + (GetArcanaProficiency() ? GetProficiencyBonus() : 0);
        public virtual int RollHistoryCheck() => _rng.d20() + GetIntMod() + (GetHistoryProficiency() ? GetProficiencyBonus() : 0);
        public virtual int RollInvestigationCheck() => _rng.d20() + GetIntMod() + (GetInvestigationProficiency() ? GetProficiencyBonus() : 0);
        public virtual int RollNatureCheck() => _rng.d20() + GetIntMod() + (GetNatureProficiency() ? GetProficiencyBonus() : 0);
        public virtual int RollReligionCheck() => _rng.d20() + GetIntMod() + (GetReligionProficiency() ? GetProficiencyBonus() : 0);
        // Wis skills
        public virtual int RollAnimalHandlingCheck() => _rng.d20() + GetWisMod() + (GetAnimalHandlingProficiency() ? GetProficiencyBonus() : 0);
        public virtual int RollInsightCheck() => _rng.d20() + GetWisMod() + (GetInsightProficiency() ? GetProficiencyBonus() : 0);
        public virtual int RollMedicineCheck() => _rng.d20() + GetWisMod() + (GetMedicineProficiency() ? GetProficiencyBonus() : 0);
        public virtual int RollPerceptionCheck() => _rng.d20() + GetWisMod() + (GetPerceptionProficiency() ? GetProficiencyBonus() : 0);
        public virtual int RollSurvivalCheck() => _rng.d20() + GetWisMod() + (GetSurvivalProficiency() ? GetProficiencyBonus() : 0);
        // Cha skills
        public virtual int RollDeceptionCheck() => _rng.d20() + GetChaMod() + (GetDeceptionProficiency() ? GetProficiencyBonus() : 0);
        public virtual int RollIntimidationCheck() => _rng.d20() + GetChaMod() + (GetIntimidationProficiency() ? GetProficiencyBonus() : 0);
        public virtual int RollPerformanceCheck() => _rng.d20() + GetChaMod() + (GetPerformanceProficiency() ? GetProficiencyBonus() : 0);
        public virtual int RollPersuasionCheck() => _rng.d20() + GetChaMod() + (GetPersuasionProficiency() ? GetProficiencyBonus() : 0);

        // Attacking
        public Tuple<int, int> AttackRoll(int advantage)
        {
            int roll = _rng.d20();
            // Advantage/disadvantage roll
            if (advantage == 1) { roll = Math.Max(roll, _rng.d20()); }
            else if (advantage == -1) { roll = Math.Min(roll, _rng.d20()); }
            // Apply modifiers
            int toHit = roll + GetStrMod() + GetProficiencyBonus();
            return new Tuple<int, int>(roll, toHit);
        }
        public int DamageRoll(bool crit)
        {
            int roll = _rng.d8();
            int critRoll = crit ? _rng.d8() : 0;
            int damage = roll + critRoll + GetStrMod();
            return Math.Max(damage, 0);
        }
        // Assumes static 1d8 weapon, will expand later.

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

        // Getting hit
        // returns {falls unconscious, destabilizes, dies}
        public Tuple<bool, bool, bool> HitByAttack(int damage, bool crit) // Include damage type
        {
            bool unconscious = false;
            bool destabilized = false;
            bool dead = false;

            if (this.GetStatus() == CharStatus.Normal)
            {
                this.Damage(damage);
                if (GetHP() <= 0)
                {
                    SetStatus(CharStatus.Unconscious);
                    unconscious = true;
                }
            }
            else if (this.GetStatus() == CharStatus.Unconscious)
            {
                if (crit) { SetDeathSavesFailed(GetDeathSavesFailed() + 2); }
                else { SetDeathSavesFailed(GetDeathSavesFailed() + 1); }

                if (GetDeathSavesFailed() >= 3)
                {
                    SetStatus(CharStatus.Dead);
                    dead = true;
                }
            }
            else if (this.GetStatus() == CharStatus.Stable)
            {
                this.SetStatus(CharStatus.Unconscious);
                destabilized = true;
            }
            else // Dead
            {

            }

            return new Tuple<bool, bool, bool>(unconscious, destabilized, dead);
        }

        public bool IsDead()
        {
            return _status == CharStatus.Dead;
        }

        // Normal maneuvers

        // Function to determine all available actions?

        // Take turn
        public virtual void TakeTurn()
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

            if (bonusActions > 0)
            {

            }


        }

        public virtual void TakeShortRest()
        {
        }
        public virtual void TakeLongRest()
        {

        }
    }
}
