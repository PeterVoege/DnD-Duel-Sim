using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Duel_Sim
{
    class Fighter : ICharacter
    {
        Fighter(ref DiceRoller rng)
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
        Fighter(ref DiceRoller rng, int level, int maxHP, int HP, Race race, Background background, int Str, int Dex, int Con, int Int, int Wis, int Cha) // and so on
        {
            _rng = rng;
            _level = level;
            _maxHP = maxHP;
            _HP = HP;
            _hitDice = level;
            _race = race;
            _background = background;
            _str = Str;
            _dex = Dex;
            _con = Con;
            _int = Int;
            _wis = Wis;
            _cha = Cha;
        }

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

        // Proficiencies
        // weapons
        private bool _simpleWeaponProficiency;
        private bool _martialWeaponProficiency;
        // armor
        private bool _lightArmorProficiency;
        private bool _mediumArmorProficiency;
        private bool _heavyArmorProficiency;
        private bool _shieldsProficiency;
        // str skills
        private bool _athleticsProficiency;
        // dex skills
        private bool _acrobaticsProficiency;
        private bool _sleightOfHandProficiency;
        private bool _stealthProficiency;
        // int skills
        private bool _arcanaProficiency;
        private bool _historyProficiency;
        private bool _investigationProficiency;
        private bool _natureProficiency;
        private bool _religionProficiency;
        // wis skills
        private bool _animalHandlingProficiency;
        private bool _insightProficiency;
        private bool _medicineProficiency;
        private bool _perceptionProficiency;
        private bool _survivalProficiency;
        // cha skills
        private bool _deceptionProficiency;
        private bool _intimidationProficiency;
        private bool _performanceProficiency;
        private bool _persuasionProficiency;
        // saves
        private bool _strSaveProficiency;
        private bool _dexSaveProficiency;
        private bool _conSaveProficiency;
        private bool _intSaveProficiency;
        private bool _wisSaveProficiency;
        private bool _chaSaveProficiency;

        public bool GetSimpleWeaponProficiency() => _simpleWeaponProficiency;
        public void SetSimpleWeaponProficiency(bool simpleWeaponProficiency) => _simpleWeaponProficiency = simpleWeaponProficiency;
        public bool GetMartialWeaponProficiency() => _martialWeaponProficiency;
        public void SetMartialWeaponProficiency(bool martialWeaponProficiency) => _martialWeaponProficiency = martialWeaponProficiency;
        public bool GetLightArmorProficiency() => _lightArmorProficiency;
        public void SetLightArmorProficiency(bool lightArmorProficiency) => _lightArmorProficiency = lightArmorProficiency;
        public bool GetMediumArmorProficiency() => _mediumArmorProficiency;
        public void SetMediumArmorProficiency(bool mediumArmorProficiency) => _mediumArmorProficiency = mediumArmorProficiency;
        public bool GetHeavyArmorProficiency() => _heavyArmorProficiency;
        public void SetHeavyArmorProficiency(bool heavyArmorProficiency) => _heavyArmorProficiency = heavyArmorProficiency;
        public bool GetShieldsProficiency() => _shieldsProficiency;
        public void SetShieldsProficiency(bool shieldsProficiency) => _shieldsProficiency = shieldsProficiency;
        
        public bool GetAthleticsProficiency() => _athleticsProficiency;
        public void SetAthleticsProficiency(bool athleticsProficiency) => _athleticsProficiency = athleticsProficiency;
        public bool GetAcrobaticsProficiency() => _acrobaticsProficiency;
        public void SetAcrobaticsProficiency(bool acrobaticsProficiency) => _acrobaticsProficiency = acrobaticsProficiency;
        public bool GetSleightOfHandProficiency() => _sleightOfHandProficiency;
        public void SetSleightOfHandProficiency(bool sleightOfHandProficiency) => _sleightOfHandProficiency = sleightOfHandProficiency;
        public bool GetStealthProficiency() => _stealthProficiency;
        public void SetStealthProficiency(bool stealthProficiency) => _stealthProficiency = stealthProficiency;
        public bool GetArcanaProficiency() => _arcanaProficiency;
        public void SetArcanaProficiency(bool arcanaProficiency) => _arcanaProficiency = arcanaProficiency;
        public bool GetHistoryProficiency() => _historyProficiency;
        public void SetHistoryProficiency(bool historyProficiency) => _historyProficiency = historyProficiency;
        public bool GetInvestigationProficiency() => _investigationProficiency;
        public void SetInvestigationProficiency(bool investigationProficiency) => _investigationProficiency = investigationProficiency;
        public bool GetNatureProficiency() => _natureProficiency;
        public void SetNatureProficiency(bool natureProficiency) => _natureProficiency = natureProficiency;
        public bool GetReligionProficiency() => _religionProficiency;
        public void SetReligionProficiency(bool religionProficiency) => _religionProficiency = religionProficiency;
        public bool GetAnimalHandlingProficiency() => _animalHandlingProficiency;
        public void SetAnimalHandlingProficiency(bool animalHandlingProficiency) => _animalHandlingProficiency = animalHandlingProficiency;
        public bool GetInsightProficiency() => _insightProficiency;
        public void SetInsightProficiency(bool insightProficiency) => _insightProficiency = insightProficiency;
        public bool GetMedicineProficiency() => _medicineProficiency;
        public void SetMedicineProficiency(bool medicineProficiency) => _medicineProficiency = medicineProficiency;
        public bool GetPerceptionProficiency() => _perceptionProficiency;
        public void SetPerceptionProficiency(bool perceptionProficiency) => _perceptionProficiency = perceptionProficiency;
        public bool GetSurvivalProficiency() => _survivalProficiency;
        public void SetSurvivalProficiency(bool survivalProficiency) => _survivalProficiency = survivalProficiency;
        public bool GetDeceptionProficiency() => _deceptionProficiency;
        public void SetDeceptionProficiency(bool deceptionProficiency) => _deceptionProficiency = deceptionProficiency;
        public bool GetIntimidationProficiency() => _intimidationProficiency;
        public void SetIntimidationProficiency(bool intimidationProficiency) => _intimidationProficiency = intimidationProficiency;
        public bool GetPerformanceProficiency() => _performanceProficiency;
        public void SetPerformanceProficiency(bool performanceProficiency) => _performanceProficiency = performanceProficiency;
        public bool GetPersuasionProficiency() => _persuasionProficiency;
        public void SetPersuasionProficiency(bool persuasionProficiency) => _persuasionProficiency = persuasionProficiency;

        public bool GetStrSaveProficiency() => _strSaveProficiency;
        public void SetStrSaveProficiency(bool strSaveProficiency) => _strSaveProficiency = strSaveProficiency;
        public bool GetDexSaveProficiency() => _dexSaveProficiency;
        public void SetDexSaveProficiency(bool dexSaveProficiency) => _dexSaveProficiency = dexSaveProficiency;
        public bool GetConSaveProficiency() => _conSaveProficiency;
        public void SetConSaveProficiency(bool conSaveProficiency) => _conSaveProficiency = conSaveProficiency;
        public bool GetIntSaveProficiency() => _intSaveProficiency;
        public void SetIntSaveProficiency(bool intSaveProficiency) => _intSaveProficiency = intSaveProficiency;
        public bool GetWisSaveProficiency() => _wisSaveProficiency;
        public void SetWisSaveProficiency(bool wisSaveProficiency) => _wisSaveProficiency = wisSaveProficiency;
        public bool GetChaSaveProficiency() => _chaSaveProficiency;
        public void SetChaSaveProficiency(bool chaSaveProficiency) => _chaSaveProficiency = chaSaveProficiency;

        // Proficiency bonus.
        public int GetProficiencyBonus() => 2 + (_level - 1) / 4;

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

        // Ability checks
        public int RollStrCheck() => _rng.d20() + GetStrMod(); // Remarkable Athlete?
        public int RollDexCheck() => _rng.d20() + GetDexMod();
        public int RollConCheck() => _rng.d20() + GetConMod();
        public int RollIntCheck() => _rng.d20() + GetIntMod();
        public int RollWisCheck() => _rng.d20() + GetWisMod();
        public int RollChaCheck() => _rng.d20() + GetChaMod();

    }
}
