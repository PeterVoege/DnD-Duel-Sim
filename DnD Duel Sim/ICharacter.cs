using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_Duel_Sim
{
    interface ICharacter
    {
        int GetLevel();
        void SetLevel(int level);

        int GetMaxHP();
        void SetMaxHP(int maxHP);
        int GetHP();
        void SetHP(int HP);

        int GetMaxHitDice();
        int GetHitDice();
        void SetHitDice(int hitDice);
        int RollHitDice();

        Race GetRace();
        void SetRace(Race race);
        Background GetBackground();
        void SetBackground(Background background);

        bool GetSimpleWeaponProficiency();
        void SetSimpleWeaponProficiency(bool simpleWeaponProficiency);
        bool GetMartialWeaponProficiency();
        void SetMartialWeaponProficiency(bool martialWeaponProficiency);
        bool GetLightArmorProficiency();
        void SetLightArmorProficiency(bool lightArmorProficiency);
        bool GetMediumArmorProficiency();
        void SetMediumArmorProficiency(bool mediumArmorProficiency);
        bool GetHeavyArmorProficiency();
        void SetHeavyArmorProficiency(bool heavyArmorProficiency);
        bool GetShieldsProficiency();
        void SetShieldsProficiency(bool shieldsProficiency);

        bool GetAthleticsProficiency();
        void SetAthleticsProficiency(bool athleticsProficiency);
        bool GetAcrobaticsProficiency();
        void SetAcrobaticsProficiency(bool acrobaticsProficiency);
        bool GetSleightOfHandProficiency();
        void SetSleightOfHandProficiency(bool sleightOfHandProficiency);
        bool GetStealthProficiency();
        void SetStealthProficiency(bool stealthProficiency);
        bool GetArcanaProficiency();
        void SetArcanaProficiency(bool arcanaProficiency);
        bool GetHistoryProficiency();
        void SetHistoryProficiency(bool historyProficiency);
        bool GetInvestigationProficiency();
        void SetInvestigationProficiency(bool investigationProficiency);
        bool GetNatureProficiency();
        void SetNatureProficiency(bool natureProficiency);
        bool GetReligionProficiency();
        void SetReligionProficiency(bool religionProficiency);
        bool GetAnimalHandlingProficiency();
        void SetAnimalHandlingProficiency(bool animalHandlingProficiency);
        bool GetInsightProficiency();
        void SetInsightProficiency(bool insightProficiency);
        bool GetMedicineProficiency();
        void SetMedicineProficiency(bool medicineProficiency);
        bool GetPerceptionProficiency();
        void SetPerceptionProficiency(bool perceptionProficiency);
        bool GetSurvivalProficiency();
        void SetSurvivalProficiency(bool survivalProficiency);
        bool GetDeceptionProficiency();
        void SetDeceptionProficiency(bool deceptionProficiency);
        bool GetIntimidationProficiency();
        void SetIntimidationProficiency(bool intimidationProficiency);
        bool GetPerformanceProficiency();
        void SetPerformanceProficiency(bool performanceProficiency);
        bool GetPersuasionProficiency();
        void SetPersuasionProficiency(bool persuasionProficiency);

        bool GetStrSaveProficiency();
        void SetStrSaveProficiency(bool strSaveProficiency);
        bool GetDexSaveProficiency();
        void SetDexSaveProficiency(bool dexSaveProficiency);
        bool GetConSaveProficiency();
        void SetConSaveProficiency(bool conSaveProficiency);
        bool GetIntSaveProficiency();
        void SetIntSaveProficiency(bool intSaveProficiency);
        bool GetWisSaveProficiency();
        void SetWisSaveProficiency(bool wisSaveProficiency);
        bool GetChaSaveProficiency();
        void SetChaSaveProficiency(bool chaSaveProficiency);

        int GetProficiencyBonus();

        int GetStr();
        int GetDex();
        int GetCon();
        int GetInt();
        int GetWis();
        int GetCha();

        void SetStr(int Str);
        void SetDex(int Dex);
        void SetCon(int Con);
        void SetInt(int Int);
        void SetWis(int Wis);
        void SetCha(int Cha);

        int GetStrMod();
        int GetDexMod();
        int GetConMod();
        int GetIntMod();
        int GetWisMod();
        int GetChaMod();

        int RollStrCheck();
        int RollDexCheck();
        int RollConCheck();
        int RollIntCheck();
        int RollWisCheck();
        int RollChaCheck();

        int GetStrSaveMod();
        int GetDexSaveMod();
        int GetConSaveMod();
        int GetIntSaveMod();
        int GetWisSaveMod();
        int GetChaSaveMod();

        int RollStrSave();
        int RollDexSave();
        int RollConSave();
        int RollIntSave();
        int RollWisSave();
        int RollChaSave();

        int AttackRoll();
        int DamageRoll();

        int GetSpeed();

        void TakeTurn();
        void TakeShortRest();
        void TakeLongRest();
    }
}
