using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Duel_Sim
{
    public partial class DuelSetupForm : Form
    {
        public DuelSetupForm()
        {
            InitializeComponent();
            _rng = new DiceRoller();
        }
        DiceRoller _rng;
        ICharacter char1;
        ICharacter char2;

        // Displays character information
        public void RefreshChar1Text()
        {
            this.Char1NameLabel.Text = char1.GetFirstName() + " " + char1.GetLastName();
            this.Char1LevelLabel.Text = ("Lv. " + char1.GetLevel()) + " Fighter";
            this.Char1RaceLabel.Text = CharRace.GetString(char1.GetRace()) + " " + CharBackground.GetString(char1.GetBackground());
            this.Char1StatsLabel.Text = char1.GetStr() + " / " + char1.GetDex() + " / " + char1.GetCon() + " / " + char1.GetInt() + " / " + char1.GetWis() + " / " + char1.GetCha();
        }
        public void RefreshChar2Text()
        {
            this.Char2NameLabel.Text = char2.GetFirstName() + " " + char2.GetLastName();
            this.Char2LevelLabel.Text = ("Lv. " + char2.GetLevel()) + " Fighter";
            this.Char2RaceLabel.Text = CharRace.GetString(char2.GetRace()) + " " + CharBackground.GetString(char2.GetBackground());
            this.Char2StatsLabel.Text = char2.GetStr() + " / " + char2.GetDex() + " / " + char2.GetCon() + " / " + char2.GetInt() + " / " + char2.GetWis() + " / " + char2.GetCha();
        }

        // Manual design
        public void LoadCharacter(ICharacter character, int slot)
        {
            switch (slot)
            {
                case 1:
                    char1 = character;
                    this.RefreshChar1Text();
                    break;
                case 2:
                    char2 = character;
                    this.RefreshChar2Text();
                    break;
            }
        }

        private void Char1DesignButton_Click(object sender, EventArgs e)
        {
            Fighter_Generator fighter1Form = new Fighter_Generator(this, 1, ref _rng);
            fighter1Form.Show();
        }
        private void Char2DesignButton_Click(object sender, EventArgs e)
        {
            Fighter_Generator fighter1Form = new Fighter_Generator(this, 2, ref _rng);
            fighter1Form.Show();
        }

        // Random generation
        private Fighter GenerateRandomFighter()
        {
            // level
            int level = 5;

            // HP
            int HPGrowth = 0;
            for (int i = 0; i < level; i++)
            {
                HPGrowth += _rng.d10();
            }

            // Race
            Race race;
            switch (_rng.CustomDice(14))
            {
                case 1:
                    race = Race.HillDwarf;
                    break;
                case 2:
                    race = Race.MountainDwarf;
                    break;
                case 3:
                    race = Race.HighElf;
                    break;
                case 4:
                    race = Race.WoodElf;
                    break;
                case 5:
                    race = Race.DarkElf;
                    break;
                case 6:
                    race = Race.LightfootHalfling;
                    break;
                case 7:
                    race = Race.StoutHalfling;
                    break;
                case 8:
                    race = Race.Human;
                    break;
                case 9:
                    race = Race.Dragonborn;
                    break;
                case 10:
                    race = Race.ForestGnome;
                    break;
                case 11:
                    race = Race.RockGnome;
                    break;
                case 12:
                    race = Race.HalfElf;
                    break;
                case 13:
                    race = Race.HalfOrc;
                    break;
                case 14:
                    race = Race.Tiefling;
                    break;
                default:
                    race = Race.Human;
                    break;
            }

            // Name
            string firstName;
            switch (_rng.d10())
            {
                case 1:
                    firstName = "John";
                    break;
                case 2:
                    firstName = "Jane";
                    break;
                case 3:
                    firstName = "Alice";
                    break;
                case 4:
                    firstName = "Bob";
                    break;
                case 5:
                    firstName = "Charles";
                    break;
                case 6:
                    firstName = "Emily";
                    break;
                case 7:
                    firstName = "Daniel";
                    break;
                case 8:
                    firstName = "Max";
                    break;
                case 9:
                    firstName = "Ryan";
                    break;
                case 10:
                    firstName = "Nicole";
                    break;
                default:
                    firstName = "John";
                    break;
            }

            string lastName = "Smith";

            // Background
            Background background;
            switch (_rng.CustomDice(13))
            {
                case 1:
                    background = Background.Acolyte;
                    break;
                case 2:
                    background = Background.Charlatan;
                    break;
                case 3:
                    background = Background.Criminal;
                    break;
                case 4:
                    background = Background.Entertainer;
                    break;
                case 5:
                    background = Background.FolkHero;
                    break;
                case 6:
                    background = Background.GuildArtisan;
                    break;
                case 7:
                    background = Background.Hermit;
                    break;
                case 8:
                    background = Background.Noble;
                    break;
                case 9:
                    background = Background.Outlander;
                    break;
                case 10:
                    background = Background.Sage;
                    break;
                case 11:
                    background = Background.Sailor;
                    break;
                case 12:
                    background = Background.Soldier;
                    break;
                case 13:
                    background = Background.Urchin;
                    break;
                default:
                    background = Background.Hermit;
                    break;
            }

            // stats
            int[] stats = new int[] { 10, 10, 10, 10, 10, 10 };
            for (int i = 0; i < 6; i++)
            {
                int[] dice = { _rng.d6(), _rng.d6(), _rng.d6(), _rng.d6() };
                Array.Sort(dice);
                stats[i] = dice[3] + dice[2] + dice[1];
            }
            // Ability Score Improvement
            int points = 0;
            if (level >= 4) { points += 2; }
            if (level >= 6) { points += 2; }
            if (level >= 8) { points += 2; }
            if (level >= 12) { points += 2; }
            if (level >= 14) { points += 2; }
            if (level >= 16) { points += 2; }
            if (level >= 19) { points += 2; }
            while (points > 0)
            {
                int index = _rng.d6();
                if (stats[index - 1] < 20)
                {
                    stats[index - 1]++;
                    points--;
                }
            }

            // Finish HP
            int HPConGrowth = level * (stats[2] / 2 - 5);
            int maxHP = 10 + HPGrowth + HPConGrowth;

            // martial archetype
            MartialArchetype martialArchetype = MartialArchetype.Champion;

            // combat proficiencies
            bool[] combatProficiencies = new bool[6] { true, true, true, true, true, true };
            // skill proficiencies
            bool[] skillProficiencies = new bool[18] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            int skill1 = _rng.d8();
            int skill2 = _rng.d8();
            while (skill2 == skill1) { skill2 = _rng.d8(); }
            switch (skill1)
            {
                case 1:
                    skillProficiencies[1] = true;
                    break;
                case 2:
                    skillProficiencies[9] = true;
                    break;
                case 3:
                    skillProficiencies[0] = true;
                    break;
                case 4:
                    skillProficiencies[5] = true;
                    break;
                case 5:
                    skillProficiencies[10] = true;
                    break;
                case 6:
                    skillProficiencies[15] = true;
                    break;
                case 7:
                    skillProficiencies[12] = true;
                    break;
                case 8:
                    skillProficiencies[13] = true;
                    break;
            }
            switch (skill2)
            {
                case 1:
                    skillProficiencies[1] = true;
                    break;
                case 2:
                    skillProficiencies[9] = true;
                    break;
                case 3:
                    skillProficiencies[0] = true;
                    break;
                case 4:
                    skillProficiencies[5] = true;
                    break;
                case 5:
                    skillProficiencies[10] = true;
                    break;
                case 6:
                    skillProficiencies[15] = true;
                    break;
                case 7:
                    skillProficiencies[12] = true;
                    break;
                case 8:
                    skillProficiencies[13] = true;
                    break;
            }
            // save proficiencies
            bool[] saveProficiencies = new bool[6] { true, false, true, false, false, false };

            // fighting styles
            bool[] fightingStyles = new bool[6] { false, false, false, false, false, false };
            int style1 = _rng.d6();
            fightingStyles[style1 - 1] = true;
            // Second fighting style
            if (martialArchetype == MartialArchetype.Champion && level >= 10)
            {
                int style2 = _rng.d6();
                while (style2 == style1) { style2 = _rng.d6(); }
                fightingStyles[style2 - 1] = true;
            }

            Fighter fighter = new Fighter(ref _rng, firstName, lastName, level, maxHP, maxHP, race, background, stats, combatProficiencies, skillProficiencies, saveProficiencies, fightingStyles, martialArchetype);

            return fighter;
        }
        
        private void RandomGenerationButton1_Click(object sender, EventArgs e)
        {
            char1 = this.GenerateRandomFighter();
            this.RefreshChar1Text();
        }
        private void RandomGenerationButton2_Click(object sender, EventArgs e)
        {
            char2 = this.GenerateRandomFighter();
            this.RefreshChar2Text();
        }

        private void RandomSettingsButton1_Click(object sender, EventArgs e)
        {

        }
        private void RandomSettingsButton2_Click(object sender, EventArgs e)
        {

        }

        private void FightButton_Click(object sender, EventArgs e)
        {
            DuelForm duel = new DuelForm(this, char1, char2);
            duel.Show();
            // Make duel form, pass both chars.
            // Duel form handles actual sim and output.
        }
    }
}
