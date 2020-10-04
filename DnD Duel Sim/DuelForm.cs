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
    public partial class DuelForm : Form
    {
        public DuelForm(DuelSetupForm parent, ICharacter _char1, ICharacter _char2)
        {
            InitializeComponent();
            _parent = parent;
            char1 = _char1;
            char2 = _char2;
            log = new List<String>();

            // Character details.
            this.Char1NameLabel.Text = char1.GetLongName();
            this.Char2NameLabel.Text = char2.GetLongName();

            this.Char1LevelLabel.Text = ("Lv. " + char1.GetLevel()) + " Fighter";
            this.Char2LevelLabel.Text = ("Lv. " + char2.GetLevel()) + " Fighter";

            this.Char1RaceLabel.Text = CharRace.GetString(char1.GetRace()) + " " + CharBackground.GetString(char1.GetBackground());
            this.Char2RaceLabel.Text = CharRace.GetString(char2.GetRace()) + " " + CharBackground.GetString(char2.GetBackground());

            this.Char1StatsLabel.Text = char1.GetStr() + " / " + char1.GetDex() + " / " + char1.GetCon() + " / " + char1.GetInt() + " / " + char1.GetWis() + " / " + char1.GetCha();
            this.Char2StatsLabel.Text = char2.GetStr() + " / " + char2.GetDex() + " / " + char2.GetCon() + " / " + char2.GetInt() + " / " + char2.GetWis() + " / " + char2.GetCha();

            this.Char1HPLabel.Text = "HP: " + char1.GetHP() + "/" + char1.GetMaxHP();
            this.Char2HPLabel.Text = "HP: " + char2.GetHP() + "/" + char2.GetMaxHP();

            // Log opening line
            log.Add(char1.GetShortName() + " and " + char2.GetShortName() + " are ready to fight!\n");
            this.UpdateLogOutput();

            // Roll initiative.
            _char1Init = char1.RollInitiative();
            _char2Init = char2.RollInitiative();
        }
        DuelSetupForm _parent;
        ICharacter char1;
        ICharacter char2;
        int _char1Init;
        int _char2Init;
        List<String> log;

        private void UpdateLogOutput()
        {
            this.CombatLog.Text = "";
            foreach (string line in log)
            {
                this.CombatLog.Text += line;
            }
            // Scroll to end.
            this.CombatLog.SelectionStart = this.CombatLog.Text.Length;
            this.CombatLog.ScrollToCaret();
        }

        private void UpdateHP()
        {
            this.Char1HPLabel.Text = "HP: " + char1.GetHP() + "/" + char1.GetMaxHP();
            this.Char2HPLabel.Text = "HP: " + char2.GetHP() + "/" + char2.GetMaxHP();
        }

        private void TakeTurn(ref ICharacter first, ref ICharacter second)
        {
            if(first.AttackRoll() > second.GetAC())
            {
                int damage = first.DamageRoll();
                second.ChangeHP(-1 * damage);
                log.Add(first.GetShortName() + " strikes " + second.GetShortName() + " for " + damage + " damage!  ");
            }
            else
            {
                log.Add(first.GetShortName() + " strikes and misses!  ");
            }

            // Other guy's turn.

            if (second.AttackRoll() > first.GetAC())
            {
                int damage = second.DamageRoll();
                first.ChangeHP(-1 * damage);
                log.Add(second.GetShortName() + " strikes " + first.GetShortName() + " for " + damage + " damage!");
            }
            else
            {
                log.Add(second.GetShortName() + " strikes and misses!");
            }

            log.Add("\n");

            this.UpdateHP();

            if (this.IsCombatOver())
            {
                this.NextTurnButton.Enabled = false;
                this.EndFightButton.Enabled = false;
                log.Add("Fight is over!");
            }
        }
        
        private void NextTurn()
        {
            // Main combat loop.

            // Could be expanded to proper initiative list.
            if(_char1Init > _char2Init)
            {
                this.TakeTurn(ref char1, ref char2);
            }
            else
            {
                this.TakeTurn(ref char2, ref char1);
            }
        }

        private bool IsCombatOver()
        {
            if (char1.GetHP() <= 0 || char2.GetHP() <= 0) { return true; }
            return false;
        }

        private void NextTurnButton_Click(object sender, EventArgs e)
        {
            this.NextTurn();
            this.UpdateLogOutput();
        }
        private void EndFightButton_Click(object sender, EventArgs e)
        {
            while (!this.IsCombatOver())
            {
                this.NextTurn();
            }
            this.UpdateLogOutput();
        }
    }
}
