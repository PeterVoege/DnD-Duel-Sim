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

        private void CharAction(ref ICharacter friend, ref ICharacter foe)
        {
            if (friend.GetStatus() == CharStatus.Normal)
            {
                Tuple<int, int> attackRoll = friend.AttackRoll(); // nat roll and toHit.
                if (attackRoll.Item1 == 20 || (attackRoll.Item2 > foe.GetAC() && attackRoll.Item1 != 1))
                {
                    // Check for crit
                    bool crit = false;
                    if (attackRoll.Item1 >= 20) { crit = true; } // Also check consciousness?
                    int damage = friend.DamageRoll(crit);
                    Tuple<bool, bool, bool> report = foe.HitByAttack(damage, false);
                    log.Add(friend.GetShortName() + (crit ? " critically" : "") + " strikes " + foe.GetShortName() + " for " + damage + " damage!  ");
                    if (report.Item1) { log.Add(foe.GetShortName() + " falls unconscious!  "); }
                    if (report.Item2) { log.Add(foe.GetShortName() + " is no longer stable!  "); }
                    if (report.Item3) { log.Add(foe.GetShortName() + " dies!  "); }
                    // string report = char1.PickAction() or somesuch
                }
                else
                {
                    log.Add(friend.GetShortName() + " strikes and misses!  ");
                }
            }
            else if (friend.GetStatus() == CharStatus.Unconscious)
            {
                Tuple<int, bool, bool, bool> deathSave = friend.MakeDeathSave();

                if(deathSave.Item1 == 1) { log.Add(friend.GetShortName() + " critically fails a death save!  "); }
                else if (deathSave.Item1 == 20) { log.Add(friend.GetShortName() + " critically succeeds a death save!  "); }
                else if (deathSave.Item1 >= 10) { log.Add(friend.GetShortName() + " succeeds a death save!  "); }
                else { log.Add(friend.GetShortName() + " fails a death save!  "); }

                if (deathSave.Item2) { log.Add(friend.GetShortName() + " revives!  "); }
                if (deathSave.Item3) { log.Add(friend.GetShortName() + " stabilizes!  "); }
                if (deathSave.Item4) { log.Add(friend.GetShortName() + " dies!  "); }
            }
            else if (friend.GetStatus() == CharStatus.Stable)
            {
                log.Add(friend.GetShortName() + " does nothing!  ");
            }
        }

        private void TakeTurn(ref ICharacter first, ref ICharacter second)
        {
            CharAction(ref first, ref second); // First char's turn

            if (this.IsCombatOver())
            {
                this.NextTurnButton.Enabled = false;
                this.EndFightButton.Enabled = false;
                log.Add("\nFight is over!");
                return;
            }
            log.Add("    ");

            CharAction(ref second, ref first); // Second char's turn

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
            if (char1.IsDead() || char2.IsDead()) { return true; }
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
