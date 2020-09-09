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
    public partial class Fighter_Generator : Form
    {
        public Fighter_Generator(ref DiceRoller rng)
        {
            InitializeComponent();
            _rng = rng;
            this.LevelSelector.Text = "1";
            this._levelOffset = 1;
            CalculateConGrowth();
        }

        DiceRoller _rng;
        int _levelOffset;

        // Level
        private void LevelSelector_DropDownClosed(object sender, EventArgs e)
        {
            this.CalculateConGrowth();
            this.HPOffset();
        }

        /// Stat allocation

        // Hide all controls and reveal only the appropriate one.
        private void StatAllocationModeVisibilityManager(int mode)
        {
            // Mode 1 controls
            StatRollDiceHeader.Visible = false;
            StatRollDiceSelectType1.Visible = false;
            StatRollDiceSelectType2.Visible = false;
            StatRollDiceSelectType3.Visible = false;
            StatRoll1.Visible = false;
            StatRoll2.Visible = false;
            StatRoll3.Visible = false;
            StatRoll4.Visible = false;
            StatRoll5.Visible = false;
            StatRoll6.Visible = false;
            StatResult1.Visible = false;
            StatResult2.Visible = false;
            StatResult3.Visible = false;
            StatResult4.Visible = false;
            StatResult5.Visible = false;
            StatResult6.Visible = false;
            StatTotal1.Visible = false;
            StatTotal2.Visible = false;
            StatTotal3.Visible = false;
            StatTotal4.Visible = false;
            StatTotal5.Visible = false;
            StatTotal6.Visible = false;
            StatRollAllocationBox1.Visible = false;
            StatRollAllocationBox2.Visible = false;
            StatRollAllocationBox3.Visible = false;
            StatRollAllocationBox4.Visible = false;
            StatRollAllocationBox5.Visible = false;
            StatRollAllocationBox6.Visible = false;
            // Mode 2 controls
            StatFixedHeader.Visible = false;
            StatFixedSelectType1.Visible = false;
            StatFixedSelectType2.Visible = false;
            StatFixedSelectType3.Visible = false;
            StatFixed1.Visible = false;
            StatFixed2.Visible = false;
            StatFixed3.Visible = false;
            StatFixed4.Visible = false;
            StatFixed5.Visible = false;
            StatFixed6.Visible = false;
            StatFixedAllocationBox1.Visible = false;
            StatFixedAllocationBox2.Visible = false;
            StatFixedAllocationBox3.Visible = false;
            StatFixedAllocationBox4.Visible = false;
            StatFixedAllocationBox5.Visible = false;
            StatFixedAllocationBox6.Visible = false;
            // Mode 3 controls
            StatPointBuyHeader.Visible = false;
            StatPointBuySelectType1.Visible = false;
            StatPointBuySelectType2.Visible = false;
            StatPointBuySelectType3.Visible = false;
            StatPointBuyTotalBudget.Visible = false;
            StatPointBuyBudget.Visible = false;
            StatPointAllocationBox1.Visible = false;
            StatPointAllocationBox2.Visible = false;
            StatPointAllocationBox3.Visible = false;
            StatPointAllocationBox4.Visible = false;
            StatPointAllocationBox5.Visible = false;
            StatPointAllocationBox6.Visible = false;
            StatPointCost1.Visible = false;
            StatPointCost2.Visible = false;
            StatPointCost3.Visible = false;
            StatPointCost4.Visible = false;
            StatPointCost5.Visible = false;
            StatPointCost6.Visible = false;
            StatPointStrLabel.Visible = false;
            StatPointDexLabel.Visible = false;
            StatPointConLabel.Visible = false;
            StatPointIntLabel.Visible = false;
            StatPointWisLabel.Visible = false;
            StatPointChaLabel.Visible = false;
            switch (mode)
            {
                case 1:
                    StatRollDiceHeader.Visible = true;
                    StatRollDiceSelectType1.Visible = true;
                    StatRollDiceSelectType2.Visible = true;
                    StatRollDiceSelectType3.Visible = true;
                    StatRoll1.Visible = true;
                    StatRoll2.Visible = true;
                    StatRoll3.Visible = true;
                    StatRoll4.Visible = true;
                    StatRoll5.Visible = true;
                    StatRoll6.Visible = true;
                    StatResult1.Visible = true;
                    StatResult2.Visible = true;
                    StatResult3.Visible = true;
                    StatResult4.Visible = true;
                    StatResult5.Visible = true;
                    StatResult6.Visible = true;
                    StatTotal1.Visible = true;
                    StatTotal2.Visible = true;
                    StatTotal3.Visible = true;
                    StatTotal4.Visible = true;
                    StatTotal5.Visible = true;
                    StatTotal6.Visible = true;
                    StatRollAllocationBox1.Visible = true;
                    StatRollAllocationBox2.Visible = true;
                    StatRollAllocationBox3.Visible = true;
                    StatRollAllocationBox4.Visible = true;
                    StatRollAllocationBox5.Visible = true;
                    StatRollAllocationBox6.Visible = true;
                    break;
                case 2:
                    StatFixedHeader.Visible = true;
                    StatFixedSelectType1.Visible = true;
                    StatFixedSelectType2.Visible = true;
                    StatFixedSelectType3.Visible = true;
                    StatFixed1.Visible = true;
                    StatFixed2.Visible = true;
                    StatFixed3.Visible = true;
                    StatFixed4.Visible = true;
                    StatFixed5.Visible = true;
                    StatFixed6.Visible = true;
                    StatFixedAllocationBox1.Visible = true;
                    StatFixedAllocationBox2.Visible = true;
                    StatFixedAllocationBox3.Visible = true;
                    StatFixedAllocationBox4.Visible = true;
                    StatFixedAllocationBox5.Visible = true;
                    StatFixedAllocationBox6.Visible = true;
                    break;
                case 3:
                    StatPointBuyHeader.Visible = true;
                    StatPointBuySelectType1.Visible = true;
                    StatPointBuySelectType2.Visible = true;
                    StatPointBuySelectType3.Visible = true;
                    StatPointBuyTotalBudget.Visible = true;
                    StatPointBuyBudget.Visible = true;
                    StatPointAllocationBox1.Visible = true;
                    StatPointAllocationBox2.Visible = true;
                    StatPointAllocationBox3.Visible = true;
                    StatPointAllocationBox4.Visible = true;
                    StatPointAllocationBox5.Visible = true;
                    StatPointAllocationBox6.Visible = true;
                    StatPointCost1.Visible = true;
                    StatPointCost2.Visible = true;
                    StatPointCost3.Visible = true;
                    StatPointCost4.Visible = true;
                    StatPointCost5.Visible = true;
                    StatPointCost6.Visible = true;
                    StatPointStrLabel.Visible = true;
                    StatPointDexLabel.Visible = true;
                    StatPointConLabel.Visible = true;
                    StatPointIntLabel.Visible = true;
                    StatPointWisLabel.Visible = true;
                    StatPointChaLabel.Visible = true;
                    break;
            }
        }

        private void StatAllocationSelectType1_CheckedChanged(object sender, EventArgs e)
        {
            if (StatAllocationSelectType1.Checked)
            {
                StatAllocationSelectType1.AutoCheck = false;

                StatAllocationSelectType2.Checked = false;
                StatAllocationSelectType2.AutoCheck = true;

                StatAllocationSelectType3.Checked = false;
                StatAllocationSelectType3.AutoCheck = true;

                StatAllocationModeVisibilityManager(1);
            }
        }
        private void StatAllocationSelectType2_CheckedChanged(object sender, EventArgs e)
        {
            if (StatAllocationSelectType2.Checked)
            {
                StatAllocationSelectType1.Checked = false;
                StatAllocationSelectType1.AutoCheck = true;

                StatAllocationSelectType2.AutoCheck = false;

                StatAllocationSelectType3.Checked = false;
                StatAllocationSelectType3.AutoCheck = true;

                StatAllocationModeVisibilityManager(2);
            }
        }
        private void StatAllocationSelectType3_CheckedChanged(object sender, EventArgs e)
        {
            if (StatAllocationSelectType3.Checked)
            {
                StatAllocationSelectType1.Checked = false;
                StatAllocationSelectType1.AutoCheck = true;

                StatAllocationSelectType2.Checked = false;
                StatAllocationSelectType2.AutoCheck = true;

                StatAllocationSelectType3.AutoCheck = false;

                StatAllocationModeVisibilityManager(3);
            }
        }

        // Dice roll
        private void StatRollDiceSelectType1_CheckedChanged(object sender, EventArgs e)
        {
            if (StatRollDiceSelectType1.Checked)
            {
                StatRollDiceSelectType1.AutoCheck = false;

                StatRollDiceSelectType2.Checked = false;
                StatRollDiceSelectType2.AutoCheck = true;

                StatRollDiceSelectType3.Checked = false;
                StatRollDiceSelectType3.AutoCheck = true;
            }
        }
        private void StatRollDiceSelectType2_CheckedChanged(object sender, EventArgs e)
        {
            if (StatRollDiceSelectType2.Checked)
            {
                StatRollDiceSelectType1.Checked = false;
                StatRollDiceSelectType1.AutoCheck = true;

                StatRollDiceSelectType2.AutoCheck = false;

                StatRollDiceSelectType3.Checked = false;
                StatRollDiceSelectType3.AutoCheck = true;
            }
        }
        private void StatRollDiceSelectType3_CheckedChanged(object sender, EventArgs e)
        {
            if (StatRollDiceSelectType3.Checked)
            {
                StatRollDiceSelectType1.Checked = false;
                StatRollDiceSelectType1.AutoCheck = true;

                StatRollDiceSelectType2.Checked = false;
                StatRollDiceSelectType2.AutoCheck = true;

                StatRollDiceSelectType3.AutoCheck = false;
            }
        }
        
        private void StatRoll1_Click(object sender, EventArgs e)
        {
            int[] dice = {_rng.d6(), _rng.d6(), _rng.d6(), _rng.d6()};
            this.StatResult1.Text = dice[0] + ", " + dice[1] + ", " + dice[2] + ", " + dice[3];
            Array.Sort(dice);
            int statTotal1 = dice[3] + dice[2] + dice[1];
            this.StatTotal1.Text = statTotal1.ToString();
            this.StatRoll1.Enabled = false;
        }
        private void StatRoll2_Click(object sender, EventArgs e)
        {
            int[] dice = { _rng.d6(), _rng.d6(), _rng.d6(), _rng.d6() };
            this.StatResult2.Text = dice[0] + ", " + dice[1] + ", " + dice[2] + ", " + dice[3];
            Array.Sort(dice);
            int statTotal2 = dice[3] + dice[2] + dice[1];
            this.StatTotal2.Text = statTotal2.ToString();
            this.StatRoll2.Enabled = false;
        }
        private void StatRoll3_Click(object sender, EventArgs e)
        {
            int[] dice = { _rng.d6(), _rng.d6(), _rng.d6(), _rng.d6() };
            this.StatResult3.Text = dice[0] + ", " + dice[1] + ", " + dice[2] + ", " + dice[3];
            Array.Sort(dice);
            int statTotal3 = dice[3] + dice[2] + dice[1];
            this.StatTotal3.Text = statTotal3.ToString();
            this.StatRoll3.Enabled = false;
        }
        private void StatRoll4_Click(object sender, EventArgs e)
        {
            int[] dice = { _rng.d6(), _rng.d6(), _rng.d6(), _rng.d6() };
            this.StatResult4.Text = dice[0] + ", " + dice[1] + ", " + dice[2] + ", " + dice[3];
            Array.Sort(dice);
            int statTotal4 = dice[3] + dice[2] + dice[1];
            this.StatTotal4.Text = statTotal4.ToString();
            this.StatRoll4.Enabled = false;
        }
        private void StatRoll5_Click(object sender, EventArgs e)
        {
            int[] dice = { _rng.d6(), _rng.d6(), _rng.d6(), _rng.d6() };
            this.StatResult5.Text = dice[0] + ", " + dice[1] + ", " + dice[2] + ", " + dice[3];
            Array.Sort(dice);
            int statTotal5 = dice[3] + dice[2] + dice[1];
            this.StatTotal5.Text = statTotal5.ToString();
            this.StatRoll5.Enabled = false;
        }
        private void StatRoll6_Click(object sender, EventArgs e)
        {
            int[] dice = { _rng.d6(), _rng.d6(), _rng.d6(), _rng.d6() };
            this.StatResult6.Text = dice[0] + ", " + dice[1] + ", " + dice[2] + ", " + dice[3];
            Array.Sort(dice);
            int statTotal6 = dice[3] + dice[2] + dice[1];
            this.StatTotal6.Text = statTotal6.ToString();
            this.StatRoll6.Enabled = false;
        }

        private void StatRollAllocationBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (this.StatRollAllocationBox1.Text == this.StatRollAllocationBox2.Text ||
                this.StatRollAllocationBox1.Text == this.StatRollAllocationBox3.Text ||
                this.StatRollAllocationBox1.Text == this.StatRollAllocationBox4.Text ||
                this.StatRollAllocationBox1.Text == this.StatRollAllocationBox5.Text ||
                this.StatRollAllocationBox1.Text == this.StatRollAllocationBox6.Text)
            {
                this.StatRollAllocationBox1.Text = " ";
            }
            this.CalculateConGrowth();
        }
        private void StatRollAllocationBox2_DropDownClosed(object sender, EventArgs e)
        {
            if (this.StatRollAllocationBox2.Text == this.StatRollAllocationBox1.Text ||
                this.StatRollAllocationBox2.Text == this.StatRollAllocationBox3.Text ||
                this.StatRollAllocationBox2.Text == this.StatRollAllocationBox4.Text ||
                this.StatRollAllocationBox2.Text == this.StatRollAllocationBox5.Text ||
                this.StatRollAllocationBox2.Text == this.StatRollAllocationBox6.Text)
            {
                this.StatRollAllocationBox2.Text = " ";
            }
            this.CalculateConGrowth();
        }
        private void StatRollAllocationBox3_DropDownClosed(object sender, EventArgs e)
        {
            if (this.StatRollAllocationBox3.Text == this.StatRollAllocationBox1.Text ||
                this.StatRollAllocationBox3.Text == this.StatRollAllocationBox2.Text ||
                this.StatRollAllocationBox3.Text == this.StatRollAllocationBox4.Text ||
                this.StatRollAllocationBox3.Text == this.StatRollAllocationBox5.Text ||
                this.StatRollAllocationBox3.Text == this.StatRollAllocationBox6.Text)
            {
                this.StatRollAllocationBox3.Text = " ";
            }
            this.CalculateConGrowth();
        }
        private void StatRollAllocationBox4_DropDownClosed(object sender, EventArgs e)
        {
            if (this.StatRollAllocationBox4.Text == this.StatRollAllocationBox1.Text ||
                this.StatRollAllocationBox4.Text == this.StatRollAllocationBox2.Text ||
                this.StatRollAllocationBox4.Text == this.StatRollAllocationBox3.Text ||
                this.StatRollAllocationBox4.Text == this.StatRollAllocationBox5.Text ||
                this.StatRollAllocationBox4.Text == this.StatRollAllocationBox6.Text)
            {
                this.StatRollAllocationBox4.Text = " ";
            }
            this.CalculateConGrowth();
        }
        private void StatRollAllocationBox5_DropDownClosed(object sender, EventArgs e)
        {
            if (this.StatRollAllocationBox5.Text == this.StatRollAllocationBox1.Text ||
                this.StatRollAllocationBox5.Text == this.StatRollAllocationBox2.Text ||
                this.StatRollAllocationBox5.Text == this.StatRollAllocationBox3.Text ||
                this.StatRollAllocationBox5.Text == this.StatRollAllocationBox4.Text ||
                this.StatRollAllocationBox5.Text == this.StatRollAllocationBox6.Text)
            {
                this.StatRollAllocationBox5.Text = " ";
            }
            this.CalculateConGrowth();
        }
        private void StatRollAllocationBox6_DropDownClosed(object sender, EventArgs e)
        {
            if (this.StatRollAllocationBox6.Text == this.StatRollAllocationBox1.Text ||
                this.StatRollAllocationBox6.Text == this.StatRollAllocationBox2.Text ||
                this.StatRollAllocationBox6.Text == this.StatRollAllocationBox3.Text ||
                this.StatRollAllocationBox6.Text == this.StatRollAllocationBox4.Text ||
                this.StatRollAllocationBox6.Text == this.StatRollAllocationBox5.Text)
            {
                this.StatRollAllocationBox6.Text = " ";
            }
            this.CalculateConGrowth();
        }

        // Fixed distribution
        private void StatFixedSelectType1_CheckedChanged(object sender, EventArgs e)
        {
            if (StatFixedSelectType1.Checked)
            {
                StatFixedSelectType1.AutoCheck = false;

                StatFixedSelectType2.Checked = false;
                StatFixedSelectType2.AutoCheck = true;

                StatFixedSelectType3.Checked = false;
                StatFixedSelectType3.AutoCheck = true;
            }

        }
        private void StatFixedSelectType2_CheckedChanged(object sender, EventArgs e)
        {
            if (StatFixedSelectType2.Checked)
            {
                StatFixedSelectType1.Checked = false;
                StatFixedSelectType1.AutoCheck = true;

                StatFixedSelectType2.AutoCheck = false;
                
                StatFixedSelectType3.Checked = false;
                StatFixedSelectType3.AutoCheck = true;
            }
        }
        private void StatFixedSelectType3_CheckedChanged(object sender, EventArgs e)
        {
            if (StatFixedSelectType3.Checked)
            {
                StatFixedSelectType1.Checked = false;
                StatFixedSelectType1.AutoCheck = true;

                StatFixedSelectType2.Checked = false;
                StatFixedSelectType2.AutoCheck = true;

                StatFixedSelectType3.AutoCheck = false;
            }

        }

        private void StatFixedAllocationBox1_DropDownClosed(object sender, EventArgs e)
        {
            if (this.StatFixedAllocationBox1.Text == this.StatFixedAllocationBox2.Text ||
                this.StatFixedAllocationBox1.Text == this.StatFixedAllocationBox3.Text ||
                this.StatFixedAllocationBox1.Text == this.StatFixedAllocationBox4.Text ||
                this.StatFixedAllocationBox1.Text == this.StatFixedAllocationBox5.Text ||
                this.StatFixedAllocationBox1.Text == this.StatFixedAllocationBox6.Text)
            {
                this.StatFixedAllocationBox1.Text = " ";
            }
            this.CalculateConGrowth();
        }
        private void StatFixedAllocationBox2_DropDownClosed(object sender, EventArgs e)
        {
            if (this.StatFixedAllocationBox2.Text == this.StatFixedAllocationBox1.Text ||
                this.StatFixedAllocationBox2.Text == this.StatFixedAllocationBox3.Text ||
                this.StatFixedAllocationBox2.Text == this.StatFixedAllocationBox4.Text ||
                this.StatFixedAllocationBox2.Text == this.StatFixedAllocationBox5.Text ||
                this.StatFixedAllocationBox2.Text == this.StatFixedAllocationBox6.Text)
            {
                this.StatFixedAllocationBox2.Text = " ";
            }
            this.CalculateConGrowth();
        }
        private void StatFixedAllocationBox3_DropDownClosed(object sender, EventArgs e)
        {
            if (this.StatFixedAllocationBox3.Text == this.StatFixedAllocationBox1.Text ||
                this.StatFixedAllocationBox3.Text == this.StatFixedAllocationBox2.Text ||
                this.StatFixedAllocationBox3.Text == this.StatFixedAllocationBox4.Text ||
                this.StatFixedAllocationBox3.Text == this.StatFixedAllocationBox5.Text ||
                this.StatFixedAllocationBox3.Text == this.StatFixedAllocationBox6.Text)
            {
                this.StatFixedAllocationBox3.Text = " ";
            }
            this.CalculateConGrowth();
        }
        private void StatFixedAllocationBox4_DropDownClosed(object sender, EventArgs e)
        {
            if (this.StatFixedAllocationBox4.Text == this.StatFixedAllocationBox1.Text ||
                this.StatFixedAllocationBox4.Text == this.StatFixedAllocationBox2.Text ||
                this.StatFixedAllocationBox4.Text == this.StatFixedAllocationBox3.Text ||
                this.StatFixedAllocationBox4.Text == this.StatFixedAllocationBox5.Text ||
                this.StatFixedAllocationBox4.Text == this.StatFixedAllocationBox6.Text)
            {
                this.StatFixedAllocationBox4.Text = " ";
            }
            this.CalculateConGrowth();
        }
        private void StatFixedAllocationBox5_DropDownClosed(object sender, EventArgs e)
        {
            if (this.StatFixedAllocationBox5.Text == this.StatFixedAllocationBox1.Text ||
                this.StatFixedAllocationBox5.Text == this.StatFixedAllocationBox2.Text ||
                this.StatFixedAllocationBox5.Text == this.StatFixedAllocationBox3.Text ||
                this.StatFixedAllocationBox5.Text == this.StatFixedAllocationBox4.Text ||
                this.StatFixedAllocationBox5.Text == this.StatFixedAllocationBox6.Text)
            {
                this.StatFixedAllocationBox5.Text = " ";
            }
            this.CalculateConGrowth();
        }
        private void StatFixedAllocationBox6_DropDownClosed(object sender, EventArgs e)
        {
            if (this.StatFixedAllocationBox6.Text == this.StatFixedAllocationBox1.Text ||
                this.StatFixedAllocationBox6.Text == this.StatFixedAllocationBox2.Text ||
                this.StatFixedAllocationBox6.Text == this.StatFixedAllocationBox3.Text ||
                this.StatFixedAllocationBox6.Text == this.StatFixedAllocationBox4.Text ||
                this.StatFixedAllocationBox6.Text == this.StatFixedAllocationBox5.Text)
            {
                this.StatFixedAllocationBox6.Text = " ";
            }
            this.CalculateConGrowth();
        }

        // Point buy
        private void StatPointBuySelectType1_CheckedChanged(object sender, EventArgs e)
        {
            if (StatPointBuySelectType1.Checked)
            {
                StatPointBuySelectType1.AutoCheck = false;

                StatPointBuySelectType2.Checked = false;
                StatPointBuySelectType2.AutoCheck = true;

                StatPointBuySelectType3.Checked = false;
                StatPointBuySelectType3.AutoCheck = true;
            }

        }
        private void StatPointBuySelectType2_CheckedChanged(object sender, EventArgs e)
        {
            if (StatPointBuySelectType2.Checked)
            {
                StatPointBuySelectType1.Checked = false;
                StatPointBuySelectType1.AutoCheck = true;

                StatPointBuySelectType2.AutoCheck = false;

                StatPointBuySelectType3.Checked = false;
                StatPointBuySelectType3.AutoCheck = true;
            }

        }
        private void StatPointBuySelectType3_CheckedChanged(object sender, EventArgs e)
        {
            if (StatPointBuySelectType3.Checked)
            {
                StatPointBuySelectType1.Checked = false;
                StatPointBuySelectType1.AutoCheck = true;

                StatPointBuySelectType2.Checked = false;
                StatPointBuySelectType2.AutoCheck = true;

                StatPointBuySelectType3.AutoCheck = false;
            }

        }
        
        // Maps the value selected to the cost in the point buy system.
        private int GetPointBuyCost(int stat)
        {
            switch (stat)
            {
                case 8:
                    return 0;
                case 9:
                    return 1;
                case 10:
                    return 2;
                case 11:
                    return 3;
                case 12:
                    return 4;
                case 13:
                    return 5;
                case 14:
                    return 7;
                case 15:
                    return 9;
                default:
                    return 0;
            }
        }
        // Finds and adds up all current point buy values selected.
        private int GetStatPointBuyTotal()
        {
            int total = 0;
            int temp;
            if (int.TryParse(this.StatPointAllocationBox1.Text, out temp))
            {
                total += GetPointBuyCost(temp);
            }
            if (int.TryParse(this.StatPointAllocationBox2.Text, out temp))
            {
                total += GetPointBuyCost(temp);
            }
            if (int.TryParse(this.StatPointAllocationBox3.Text, out temp))
            {
                total += GetPointBuyCost(temp);
            }
            if (int.TryParse(this.StatPointAllocationBox4.Text, out temp))
            {
                total += GetPointBuyCost(temp);
            }
            if (int.TryParse(this.StatPointAllocationBox5.Text, out temp))
            {
                total += GetPointBuyCost(temp);
            }
            if (int.TryParse(this.StatPointAllocationBox6.Text, out temp))
            {
                total += GetPointBuyCost(temp);
            }
            return total;
        }
        private void StatPointAllocationBox1_DropDownClosed(object sender, EventArgs e)
        {
            if(int.TryParse(this.StatPointAllocationBox1.Text, out int temp))
            {
                if (GetStatPointBuyTotal() > 27) // Over budget
                {
                    this.StatPointAllocationBox1.Text = " ";
                    StatPointCost1.Text = "Cost: ";
                }
                else // Under budget
                {
                    StatPointCost1.Text = "Cost: " + GetPointBuyCost(temp);
                }
            } // NaN
            else
            {
                StatPointCost1.Text = "Cost: ";
            }
            StatPointBuyBudget.Text = "Points Left: " + (27 - GetStatPointBuyTotal());
        }
        private void StatPointAllocationBox2_DropDownClosed(object sender, EventArgs e)
        {
            if (int.TryParse(this.StatPointAllocationBox2.Text, out int temp))
            {
                if (GetStatPointBuyTotal() > 27) // Over budget
                {
                    this.StatPointAllocationBox2.Text = " ";
                    StatPointCost2.Text = "Cost: ";
                }
                else // Under budget
                {
                    StatPointCost2.Text = "Cost: " + GetPointBuyCost(temp);
                }
            } // NaN
            else
            {
                StatPointCost2.Text = "Cost: ";
            }
            StatPointBuyBudget.Text = "Points Left: " + (27 - GetStatPointBuyTotal());
        }
        private void StatPointAllocationBox3_DropDownClosed(object sender, EventArgs e)
        {
            if (int.TryParse(this.StatPointAllocationBox3.Text, out int temp))
            {
                if (GetStatPointBuyTotal() > 27) // Over budget
                {
                    this.StatPointAllocationBox3.Text = " ";
                    StatPointCost3.Text = "Cost: ";
                }
                else // Under budget
                {
                    StatPointCost3.Text = "Cost: " + GetPointBuyCost(temp);
                }
            } // NaN
            else
            {
                StatPointCost3.Text = "Cost: ";
            }
            StatPointBuyBudget.Text = "Points Left: " + (27 - GetStatPointBuyTotal());
        }
        private void StatPointAllocationBox4_DropDownClosed(object sender, EventArgs e)
        {
            if (int.TryParse(this.StatPointAllocationBox4.Text, out int temp))
            {
                if (GetStatPointBuyTotal() > 27) // Over budget
                {
                    this.StatPointAllocationBox4.Text = " ";
                    StatPointCost4.Text = "Cost: ";
                }
                else // Under budget
                {
                    StatPointCost4.Text = "Cost: " + GetPointBuyCost(temp);
                }
            } // NaN
            else
            {
                StatPointCost4.Text = "Cost: ";
            }
            StatPointBuyBudget.Text = "Points Left: " + (27 - GetStatPointBuyTotal());
        }
        private void StatPointAllocationBox5_DropDownClosed(object sender, EventArgs e)
        {
            if (int.TryParse(this.StatPointAllocationBox5.Text, out int temp))
            {
                if (GetStatPointBuyTotal() > 27) // Over budget
                {
                    this.StatPointAllocationBox5.Text = " ";
                    StatPointCost5.Text = "Cost: ";
                }
                else // Under budget
                {
                    StatPointCost5.Text = "Cost: " + GetPointBuyCost(temp);
                }
            } // NaN
            else
            {
                StatPointCost5.Text = "Cost: ";
            }
            StatPointBuyBudget.Text = "Points Left: " + (27 - GetStatPointBuyTotal());
        }
        private void StatPointAllocationBox6_DropDownClosed(object sender, EventArgs e)
        {
            if (int.TryParse(this.StatPointAllocationBox6.Text, out int temp))
            {
                if (GetStatPointBuyTotal() > 27) // Over budget
                {
                    this.StatPointAllocationBox6.Text = " ";
                    StatPointCost6.Text = "Cost: ";
                }
                else // Under budget
                {
                    StatPointCost6.Text = "Cost: " + GetPointBuyCost(temp);
                }
            } // NaN
            else
            {
                StatPointCost6.Text = "Cost: ";
            }
            StatPointBuyBudget.Text = "Points Left: " + (27 - GetStatPointBuyTotal());
        }

        /// HP

        // Determines the offset created by the dynamic number of HP lines.
        private void HPOffset()
        {
            int offset = int.Parse(this.LevelSelector.Text); // Number of lines visible.
            int diff = (offset - _levelOffset) * 36;
            int threshold = this.divider4.Location.Y;

            foreach (Control element in this.Controls)
            {
                if (element.Location.Y >= threshold)  // Everything beneath the HP section.
                {
                    element.Location = new Point(element.Location.X, element.Location.Y + diff);
                }
            }
            _levelOffset = offset;
            PlaceHPDiceRollLines();
        }
        
        // Adjusts 'con growth' label whenever the relevant information is updated.
        // TODO: compatibiltiy with fixed set and point buy
        private void CalculateConGrowth()
        {
            string con = "0";
            if (this.StatRollAllocationBox1.Text == "Constitution" &&
                StatTotal1.Text != "") { con = StatTotal1.Text; }
            else if (this.StatRollAllocationBox2.Text == "Constitution" &&
                StatTotal2.Text != "") { con = StatTotal2.Text; }
            else if (this.StatRollAllocationBox3.Text == "Constitution" &&
                StatTotal3.Text != "") { con = StatTotal3.Text; }
            else if (this.StatRollAllocationBox4.Text == "Constitution" &&
                StatTotal4.Text != "") { con = StatTotal4.Text; }
            else if (this.StatRollAllocationBox5.Text == "Constitution" &&
                StatTotal5.Text != "") { con = StatTotal5.Text; }
            else if (this.StatRollAllocationBox6.Text == "Constitution" &&
                StatTotal6.Text != "") { con = StatTotal6.Text; }

            if (con != "0")
            {
                //int conN = int.Parse(con);
                //int levelN = int.Parse(this.LevelSelector.Text);
                this.HPConGrowth.Text = (int.Parse(this.LevelSelector.Text) * (int.Parse(con) - 10) / 2).ToString();
            }
            else { this.HPConGrowth.Text = "N/A"; }
        }

        // Based on how many HP lines are supposed to exist, moves the appropriate forms into place and makes them visible or not.
        // For the sake of a legibile design page and avoiding bugs, the controls for lines that are not visible are moved out of the way until they are added back in again.
        private void PlaceHPDiceRollLines()
        {
            if (_levelOffset >= 2)
            {
                this.Lv2HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(2);
                Lv2HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv1HPCheckbox.Location.Y + 36);
                Lv2HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv1HPRoller.Location.Y + 36);
                Lv2HPResult.Location = new Point(Lv1HPResult.Location.X, Lv1HPResult.Location.Y + 36);
                Lv2HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv1HPFixed.Location.Y + 36);
                Lv2HP6.Location = new Point(Lv1HP6.Location.X, Lv1HP6.Location.Y + 36);
            }
            else
            {
                this.Lv2HPCheckbox.Visible = false;
                this.Lv2HPRoller.Visible = false;
                this.Lv2HPResult.Visible = false;
                this.Lv2HPFixed.Visible = false;
                this.Lv2HP6.Visible = false;
                Lv2HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv2HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv2HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv2HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv2HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 3)
            {
                this.Lv3HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(3);
                Lv3HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv2HPCheckbox.Location.Y + 36);
                Lv3HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv2HPRoller.Location.Y + 36);
                Lv3HPResult.Location = new Point(Lv1HPResult.Location.X, Lv2HPResult.Location.Y + 36);
                Lv3HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv2HPFixed.Location.Y + 36);
                Lv3HP6.Location = new Point(Lv1HP6.Location.X, Lv2HP6.Location.Y + 36);
            }
            else
            {
                this.Lv3HPCheckbox.Visible = false;
                this.Lv3HPRoller.Visible = false;
                this.Lv3HPResult.Visible = false;
                this.Lv3HPFixed.Visible = false;
                this.Lv3HP6.Visible = false;
                Lv3HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv3HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv3HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv3HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv3HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 4)
            {
                this.Lv4HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(4);
                Lv4HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv3HPCheckbox.Location.Y + 36);
                Lv4HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv3HPRoller.Location.Y + 36);
                Lv4HPResult.Location = new Point(Lv1HPResult.Location.X, Lv3HPResult.Location.Y + 36);
                Lv4HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv3HPFixed.Location.Y + 36);
                Lv4HP6.Location = new Point(Lv1HP6.Location.X, Lv3HP6.Location.Y + 36);
            }
            else
            {
                this.Lv4HPCheckbox.Visible = false;
                this.Lv4HPRoller.Visible = false;
                this.Lv4HPResult.Visible = false;
                this.Lv4HPFixed.Visible = false;
                this.Lv4HP6.Visible = false;
                Lv4HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv4HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv4HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv4HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv4HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 5)
            {
                this.Lv5HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(5);
                Lv5HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv4HPCheckbox.Location.Y + 36);
                Lv5HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv4HPRoller.Location.Y + 36);
                Lv5HPResult.Location = new Point(Lv1HPResult.Location.X, Lv4HPResult.Location.Y + 36);
                Lv5HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv4HPFixed.Location.Y + 36);
                Lv5HP6.Location = new Point(Lv1HP6.Location.X, Lv4HP6.Location.Y + 36);
            }
            else
            {
                this.Lv5HPCheckbox.Visible = false;
                this.Lv5HPRoller.Visible = false;
                this.Lv5HPResult.Visible = false;
                this.Lv5HPFixed.Visible = false;
                this.Lv5HP6.Visible = false;
                Lv5HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv5HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv5HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv5HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv5HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 6)
            {
                this.Lv6HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(6);
                Lv6HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv5HPCheckbox.Location.Y + 36);
                Lv6HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv5HPRoller.Location.Y + 36);
                Lv6HPResult.Location = new Point(Lv1HPResult.Location.X, Lv5HPResult.Location.Y + 36);
                Lv6HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv5HPFixed.Location.Y + 36);
                Lv6HP6.Location = new Point(Lv1HP6.Location.X, Lv5HP6.Location.Y + 36);
            }
            else
            {
                this.Lv6HPCheckbox.Visible = false;
                this.Lv6HPRoller.Visible = false;
                this.Lv6HPResult.Visible = false;
                this.Lv6HPFixed.Visible = false;
                this.Lv6HP6.Visible = false;
                Lv6HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv6HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv6HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv6HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv6HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 7)
            {
                this.Lv7HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(7);
                Lv7HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv6HPCheckbox.Location.Y + 36);
                Lv7HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv6HPRoller.Location.Y + 36);
                Lv7HPResult.Location = new Point(Lv1HPResult.Location.X, Lv6HPResult.Location.Y + 36);
                Lv7HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv6HPFixed.Location.Y + 36);
                Lv7HP6.Location = new Point(Lv1HP6.Location.X, Lv6HP6.Location.Y + 36);
            }
            else
            {
                this.Lv7HPCheckbox.Visible = false;
                this.Lv7HPRoller.Visible = false;
                this.Lv7HPResult.Visible = false;
                this.Lv7HPFixed.Visible = false;
                this.Lv7HP6.Visible = false;
                Lv7HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv7HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv7HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv7HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv7HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 8)
            {
                this.Lv8HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(8);
                Lv8HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv7HPCheckbox.Location.Y + 36);
                Lv8HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv7HPRoller.Location.Y + 36);
                Lv8HPResult.Location = new Point(Lv1HPResult.Location.X, Lv7HPResult.Location.Y + 36);
                Lv8HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv7HPFixed.Location.Y + 36);
                Lv8HP6.Location = new Point(Lv1HP6.Location.X, Lv7HP6.Location.Y + 36);
            }
            else
            {
                this.Lv8HPCheckbox.Visible = false;
                this.Lv8HPRoller.Visible = false;
                this.Lv8HPResult.Visible = false;
                this.Lv8HPFixed.Visible = false;
                this.Lv8HP6.Visible = false;
                Lv8HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv8HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv8HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv8HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv8HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 9)
            {
                this.Lv9HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(9);
                Lv9HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv8HPCheckbox.Location.Y + 36);
                Lv9HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv8HPRoller.Location.Y + 36);
                Lv9HPResult.Location = new Point(Lv1HPResult.Location.X, Lv8HPResult.Location.Y + 36);
                Lv9HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv8HPFixed.Location.Y + 36);
                Lv9HP6.Location = new Point(Lv1HP6.Location.X, Lv8HP6.Location.Y + 36);
            }
            else
            {
                this.Lv9HPCheckbox.Visible = false;
                this.Lv9HPRoller.Visible = false;
                this.Lv9HPResult.Visible = false;
                this.Lv9HPFixed.Visible = false;
                this.Lv9HP6.Visible = false;
                Lv9HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv9HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv9HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv9HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv9HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 10)
            {
                this.Lv10HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(10);
                Lv10HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv9HPCheckbox.Location.Y + 36);
                Lv10HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv9HPRoller.Location.Y + 36);
                Lv10HPResult.Location = new Point(Lv1HPResult.Location.X, Lv9HPResult.Location.Y + 36);
                Lv10HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv9HPFixed.Location.Y + 36);
                Lv10HP6.Location = new Point(Lv1HP6.Location.X, Lv9HP6.Location.Y + 36);
            }
            else
            {
                this.Lv10HPCheckbox.Visible = false;
                this.Lv10HPRoller.Visible = false;
                this.Lv10HPResult.Visible = false;
                this.Lv10HPFixed.Visible = false;
                this.Lv10HP6.Visible = false;
                Lv10HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv10HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv10HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv10HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv10HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 11)
            {
                this.Lv11HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(11);
                Lv11HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv10HPCheckbox.Location.Y + 36);
                Lv11HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv10HPRoller.Location.Y + 36);
                Lv11HPResult.Location = new Point(Lv1HPResult.Location.X, Lv10HPResult.Location.Y + 36);
                Lv11HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv10HPFixed.Location.Y + 36);
                Lv11HP6.Location = new Point(Lv1HP6.Location.X, Lv10HP6.Location.Y + 36);
            }
            else
            {
                this.Lv11HPCheckbox.Visible = false;
                this.Lv11HPRoller.Visible = false;
                this.Lv11HPResult.Visible = false;
                this.Lv11HPFixed.Visible = false;
                this.Lv11HP6.Visible = false;
                Lv11HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv11HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv11HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv11HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv11HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 12)
            {
                this.Lv12HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(12);
                Lv12HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv11HPCheckbox.Location.Y + 36);
                Lv12HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv11HPRoller.Location.Y + 36);
                Lv12HPResult.Location = new Point(Lv1HPResult.Location.X, Lv11HPResult.Location.Y + 36);
                Lv12HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv11HPFixed.Location.Y + 36);
                Lv12HP6.Location = new Point(Lv1HP6.Location.X, Lv11HP6.Location.Y + 36);
            }
            else
            {
                this.Lv12HPCheckbox.Visible = false;
                this.Lv12HPRoller.Visible = false;
                this.Lv12HPResult.Visible = false;
                this.Lv12HPFixed.Visible = false;
                this.Lv12HP6.Visible = false;
                Lv12HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv12HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv12HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv12HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv12HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 13)
            {
                this.Lv13HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(13);
                Lv13HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv12HPCheckbox.Location.Y + 36);
                Lv13HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv12HPRoller.Location.Y + 36);
                Lv13HPResult.Location = new Point(Lv1HPResult.Location.X, Lv12HPResult.Location.Y + 36);
                Lv13HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv12HPFixed.Location.Y + 36);
                Lv13HP6.Location = new Point(Lv1HP6.Location.X, Lv12HP6.Location.Y + 36);
            }
            else
            {
                this.Lv13HPCheckbox.Visible = false;
                this.Lv13HPRoller.Visible = false;
                this.Lv13HPResult.Visible = false;
                this.Lv13HPFixed.Visible = false;
                this.Lv13HP6.Visible = false;
                Lv13HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv13HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv13HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv13HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv13HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 14)
            {
                this.Lv14HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(14);
                Lv14HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv13HPCheckbox.Location.Y + 36);
                Lv14HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv13HPRoller.Location.Y + 36);
                Lv14HPResult.Location = new Point(Lv1HPResult.Location.X, Lv13HPResult.Location.Y + 36);
                Lv14HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv13HPFixed.Location.Y + 36);
                Lv14HP6.Location = new Point(Lv1HP6.Location.X, Lv13HP6.Location.Y + 36);
            }
            else
            {
                this.Lv14HPCheckbox.Visible = false;
                this.Lv14HPRoller.Visible = false;
                this.Lv14HPResult.Visible = false;
                this.Lv14HPFixed.Visible = false;
                this.Lv14HP6.Visible = false;
                Lv14HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv14HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv14HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv14HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv14HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 15)
            {
                this.Lv15HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(15);
                Lv15HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv14HPCheckbox.Location.Y + 36);
                Lv15HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv14HPRoller.Location.Y + 36);
                Lv15HPResult.Location = new Point(Lv1HPResult.Location.X, Lv14HPResult.Location.Y + 36);
                Lv15HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv14HPFixed.Location.Y + 36);
                Lv15HP6.Location = new Point(Lv1HP6.Location.X, Lv14HP6.Location.Y + 36);
            }
            else
            {
                this.Lv15HPCheckbox.Visible = false;
                this.Lv15HPRoller.Visible = false;
                this.Lv15HPResult.Visible = false;
                this.Lv15HPFixed.Visible = false;
                this.Lv15HP6.Visible = false;
                Lv15HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv15HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv15HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv15HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv15HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 16)
            {
                this.Lv16HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(16);
                Lv16HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv15HPCheckbox.Location.Y + 36);
                Lv16HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv15HPRoller.Location.Y + 36);
                Lv16HPResult.Location = new Point(Lv1HPResult.Location.X, Lv15HPResult.Location.Y + 36);
                Lv16HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv15HPFixed.Location.Y + 36);
                Lv16HP6.Location = new Point(Lv1HP6.Location.X, Lv15HP6.Location.Y + 36);
            }
            else
            {
                this.Lv16HPCheckbox.Visible = false;
                this.Lv16HPRoller.Visible = false;
                this.Lv16HPResult.Visible = false;
                this.Lv16HPFixed.Visible = false;
                this.Lv16HP6.Visible = false;
                Lv16HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv16HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv16HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv16HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv16HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 17)
            {
                this.Lv17HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(17);
                Lv17HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv16HPCheckbox.Location.Y + 36);
                Lv17HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv16HPRoller.Location.Y + 36);
                Lv17HPResult.Location = new Point(Lv1HPResult.Location.X, Lv16HPResult.Location.Y + 36);
                Lv17HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv16HPFixed.Location.Y + 36);
                Lv17HP6.Location = new Point(Lv1HP6.Location.X, Lv16HP6.Location.Y + 36);
            }
            else
            {
                this.Lv17HPCheckbox.Visible = false;
                this.Lv17HPRoller.Visible = false;
                this.Lv17HPResult.Visible = false;
                this.Lv17HPFixed.Visible = false;
                this.Lv17HP6.Visible = false;
                Lv17HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv17HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv17HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv17HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv17HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 18)
            {
                this.Lv18HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(18);
                Lv18HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv17HPCheckbox.Location.Y + 36);
                Lv18HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv17HPRoller.Location.Y + 36);
                Lv18HPResult.Location = new Point(Lv1HPResult.Location.X, Lv17HPResult.Location.Y + 36);
                Lv18HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv17HPFixed.Location.Y + 36);
                Lv18HP6.Location = new Point(Lv1HP6.Location.X, Lv17HP6.Location.Y + 36);
            }
            else
            {
                this.Lv18HPCheckbox.Visible = false;
                this.Lv18HPRoller.Visible = false;
                this.Lv18HPResult.Visible = false;
                this.Lv18HPFixed.Visible = false;
                this.Lv18HP6.Visible = false;
                Lv18HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv18HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv18HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv18HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv18HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 19)
            {
                this.Lv19HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(19);
                Lv19HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv18HPCheckbox.Location.Y + 36);
                Lv19HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv18HPRoller.Location.Y + 36);
                Lv19HPResult.Location = new Point(Lv1HPResult.Location.X, Lv18HPResult.Location.Y + 36);
                Lv19HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv18HPFixed.Location.Y + 36);
                Lv19HP6.Location = new Point(Lv1HP6.Location.X, Lv18HP6.Location.Y + 36);
            }
            else
            {
                this.Lv19HPCheckbox.Visible = false;
                this.Lv19HPRoller.Visible = false;
                this.Lv19HPResult.Visible = false;
                this.Lv19HPFixed.Visible = false;
                this.Lv19HP6.Visible = false;
                Lv19HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv19HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv19HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv19HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv19HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
            if (_levelOffset >= 20)
            {
                this.Lv20HPCheckbox.Visible = true;
                this.HPRollVisibilityManager(20);
                Lv20HPCheckbox.Location = new Point(Lv1HPCheckbox.Location.X, Lv19HPCheckbox.Location.Y + 36);
                Lv20HPRoller.Location = new Point(Lv1HPRoller.Location.X, Lv19HPRoller.Location.Y + 36);
                Lv20HPResult.Location = new Point(Lv1HPResult.Location.X, Lv19HPResult.Location.Y + 36);
                Lv20HPFixed.Location = new Point(Lv1HPFixed.Location.X, Lv19HPFixed.Location.Y + 36);
                Lv20HP6.Location = new Point(Lv1HP6.Location.X, Lv19HP6.Location.Y + 36);
            }
            else
            {
                this.Lv20HPCheckbox.Visible = false;
                this.Lv20HPRoller.Visible = false;
                this.Lv20HPResult.Visible = false;
                this.Lv20HPFixed.Visible = false;
                this.Lv20HP6.Visible = false;
                Lv20HPCheckbox.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv20HPRoller.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv20HPResult.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv20HPFixed.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
                Lv20HP6.Location = new Point(HPHeader.Location.X + 100, HPHeader.Location.Y + 50);
            }
        }
        
        // Decides which half of a HP roll line should be visible, the dice roll or the fixed gain.
        // Is only called when a line is supposed to be visibile, as determined in PlaceHPDiceRollLines()
        private void HPRollVisibilityManager(int level)
        {
            switch (level)
            {
                case 1:
                    if (Lv1HPCheckbox.Checked)
                    {
                        this.Lv1HPRoller.Visible = true;
                        this.Lv1HPResult.Visible = true;
                        this.Lv1HPFixed.Visible = false;
                        this.Lv1HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv1HPRoller.Visible = false;
                        this.Lv1HPResult.Visible = false;
                        this.Lv1HPFixed.Visible = true;
                        this.Lv1HP6.Visible = true;
                    }
                    break;
                case 2:
                    if (Lv2HPCheckbox.Checked)
                    {
                        this.Lv2HPRoller.Visible = true;
                        this.Lv2HPResult.Visible = true;
                        this.Lv2HPFixed.Visible = false;
                        this.Lv2HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv2HPRoller.Visible = false;
                        this.Lv2HPResult.Visible = false;
                        this.Lv2HPFixed.Visible = true;
                        this.Lv2HP6.Visible = true;
                    }
                    break;
                case 3:
                    if (Lv3HPCheckbox.Checked)
                    {
                        this.Lv3HPRoller.Visible = true;
                        this.Lv3HPResult.Visible = true;
                        this.Lv3HPFixed.Visible = false;
                        this.Lv3HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv3HPRoller.Visible = false;
                        this.Lv3HPResult.Visible = false;
                        this.Lv3HPFixed.Visible = true;
                        this.Lv3HP6.Visible = true;
                    }
                    break;
                case 4:
                    if (Lv4HPCheckbox.Checked)
                    {
                        this.Lv4HPRoller.Visible = true;
                        this.Lv4HPResult.Visible = true;
                        this.Lv4HPFixed.Visible = false;
                        this.Lv4HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv4HPRoller.Visible = false;
                        this.Lv4HPResult.Visible = false;
                        this.Lv4HPFixed.Visible = true;
                        this.Lv4HP6.Visible = true;
                    }
                    break;
                case 5:
                    if (Lv5HPCheckbox.Checked)
                    {
                        this.Lv5HPRoller.Visible = true;
                        this.Lv5HPResult.Visible = true;
                        this.Lv5HPFixed.Visible = false;
                        this.Lv5HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv5HPRoller.Visible = false;
                        this.Lv5HPResult.Visible = false;
                        this.Lv5HPFixed.Visible = true;
                        this.Lv5HP6.Visible = true;
                    }
                    break;
                case 6:
                    if (Lv6HPCheckbox.Checked)
                    {
                        this.Lv6HPRoller.Visible = true;
                        this.Lv6HPResult.Visible = true;
                        this.Lv6HPFixed.Visible = false;
                        this.Lv6HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv6HPRoller.Visible = false;
                        this.Lv6HPResult.Visible = false;
                        this.Lv6HPFixed.Visible = true;
                        this.Lv6HP6.Visible = true;
                    }
                    break;
                case 7:
                    if (Lv7HPCheckbox.Checked)
                    {
                        this.Lv7HPRoller.Visible = true;
                        this.Lv7HPResult.Visible = true;
                        this.Lv7HPFixed.Visible = false;
                        this.Lv7HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv7HPRoller.Visible = false;
                        this.Lv7HPResult.Visible = false;
                        this.Lv7HPFixed.Visible = true;
                        this.Lv7HP6.Visible = true;
                    }
                    break;
                case 8:
                    if (Lv8HPCheckbox.Checked)
                    {
                        this.Lv8HPRoller.Visible = true;
                        this.Lv8HPResult.Visible = true;
                        this.Lv8HPFixed.Visible = false;
                        this.Lv8HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv8HPRoller.Visible = false;
                        this.Lv8HPResult.Visible = false;
                        this.Lv8HPFixed.Visible = true;
                        this.Lv8HP6.Visible = true;
                    }
                    break;
                case 9:
                    if (Lv9HPCheckbox.Checked)
                    {
                        this.Lv9HPRoller.Visible = true;
                        this.Lv9HPResult.Visible = true;
                        this.Lv9HPFixed.Visible = false;
                        this.Lv9HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv9HPRoller.Visible = false;
                        this.Lv9HPResult.Visible = false;
                        this.Lv9HPFixed.Visible = true;
                        this.Lv9HP6.Visible = true;
                    }
                    break;
                case 10:
                    if (Lv10HPCheckbox.Checked)
                    {
                        this.Lv10HPRoller.Visible = true;
                        this.Lv10HPResult.Visible = true;
                        this.Lv10HPFixed.Visible = false;
                        this.Lv10HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv10HPRoller.Visible = false;
                        this.Lv10HPResult.Visible = false;
                        this.Lv10HPFixed.Visible = true;
                        this.Lv10HP6.Visible = true;
                    }
                    break;
                case 11:
                    if (Lv11HPCheckbox.Checked)
                    {
                        this.Lv11HPRoller.Visible = true;
                        this.Lv11HPResult.Visible = true;
                        this.Lv11HPFixed.Visible = false;
                        this.Lv11HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv11HPRoller.Visible = false;
                        this.Lv11HPResult.Visible = false;
                        this.Lv11HPFixed.Visible = true;
                        this.Lv11HP6.Visible = true;
                    }
                    break;
                case 12:
                    if (Lv12HPCheckbox.Checked)
                    {
                        this.Lv12HPRoller.Visible = true;
                        this.Lv12HPResult.Visible = true;
                        this.Lv12HPFixed.Visible = false;
                        this.Lv12HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv12HPRoller.Visible = false;
                        this.Lv12HPResult.Visible = false;
                        this.Lv12HPFixed.Visible = true;
                        this.Lv12HP6.Visible = true;
                    }
                    break;
                case 13:
                    if (Lv13HPCheckbox.Checked)
                    {
                        this.Lv13HPRoller.Visible = true;
                        this.Lv13HPResult.Visible = true;
                        this.Lv13HPFixed.Visible = false;
                        this.Lv13HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv13HPRoller.Visible = false;
                        this.Lv13HPResult.Visible = false;
                        this.Lv13HPFixed.Visible = true;
                        this.Lv13HP6.Visible = true;
                    }
                    break;
                case 14:
                    if (Lv14HPCheckbox.Checked)
                    {
                        this.Lv14HPRoller.Visible = true;
                        this.Lv14HPResult.Visible = true;
                        this.Lv14HPFixed.Visible = false;
                        this.Lv14HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv14HPRoller.Visible = false;
                        this.Lv14HPResult.Visible = false;
                        this.Lv14HPFixed.Visible = true;
                        this.Lv14HP6.Visible = true;
                    }
                    break;
                case 15:
                    if (Lv15HPCheckbox.Checked)
                    {
                        this.Lv15HPRoller.Visible = true;
                        this.Lv15HPResult.Visible = true;
                        this.Lv15HPFixed.Visible = false;
                        this.Lv15HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv15HPRoller.Visible = false;
                        this.Lv15HPResult.Visible = false;
                        this.Lv15HPFixed.Visible = true;
                        this.Lv15HP6.Visible = true;
                    }
                    break;
                case 16:
                    if (Lv16HPCheckbox.Checked)
                    {
                        this.Lv16HPRoller.Visible = true;
                        this.Lv16HPResult.Visible = true;
                        this.Lv16HPFixed.Visible = false;
                        this.Lv16HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv16HPRoller.Visible = false;
                        this.Lv16HPResult.Visible = false;
                        this.Lv16HPFixed.Visible = true;
                        this.Lv16HP6.Visible = true;
                    }
                    break;
                case 17:
                    if (Lv17HPCheckbox.Checked)
                    {
                        this.Lv17HPRoller.Visible = true;
                        this.Lv17HPResult.Visible = true;
                        this.Lv17HPFixed.Visible = false;
                        this.Lv17HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv17HPRoller.Visible = false;
                        this.Lv17HPResult.Visible = false;
                        this.Lv17HPFixed.Visible = true;
                        this.Lv17HP6.Visible = true;
                    }
                    break;
                case 18:
                    if (Lv18HPCheckbox.Checked)
                    {
                        this.Lv18HPRoller.Visible = true;
                        this.Lv18HPResult.Visible = true;
                        this.Lv18HPFixed.Visible = false;
                        this.Lv18HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv18HPRoller.Visible = false;
                        this.Lv18HPResult.Visible = false;
                        this.Lv18HPFixed.Visible = true;
                        this.Lv18HP6.Visible = true;
                    }
                    break;
                case 19:
                    if (Lv19HPCheckbox.Checked)
                    {
                        this.Lv19HPRoller.Visible = true;
                        this.Lv19HPResult.Visible = true;
                        this.Lv19HPFixed.Visible = false;
                        this.Lv19HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv19HPRoller.Visible = false;
                        this.Lv19HPResult.Visible = false;
                        this.Lv19HPFixed.Visible = true;
                        this.Lv19HP6.Visible = true;
                    }
                    break;
                case 20:
                    if (Lv20HPCheckbox.Checked)
                    {
                        this.Lv20HPRoller.Visible = true;
                        this.Lv20HPResult.Visible = true;
                        this.Lv20HPFixed.Visible = false;
                        this.Lv20HP6.Visible = false;
                    }
                    else
                    {
                        this.Lv20HPRoller.Visible = false;
                        this.Lv20HPResult.Visible = false;
                        this.Lv20HPFixed.Visible = true;
                        this.Lv20HP6.Visible = true;
                    }
                    break;
            }
        }

        private void Lv1HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(1);
        }
        private void Lv2HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(2);
        }
        private void Lv3HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(3);
        }
        private void Lv4HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(4);
        }
        private void Lv5HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(5);
        }
        private void Lv6HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(6);
        }
        private void Lv7HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(7);
        }
        private void Lv8HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(8);
        }
        private void Lv9HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(9);
        }
        private void Lv10HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(10);
        }
        private void Lv11HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(11);
        }
        private void Lv12HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(12);
        }
        private void Lv13HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(13);
        }
        private void Lv14HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(14);
        }
        private void Lv15HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(15);
        }
        private void Lv16HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(16);
        }
        private void Lv17HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(17);
        }
        private void Lv18HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(18);
        }
        private void Lv19HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(19);
        }
        private void Lv20HPCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            HPRollVisibilityManager(20);
        }

        private void Lv1HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv1HPResult.Text = "+" + _rng.d10();
            this.Lv1HPRoller.Enabled = false;
        }
        private void Lv2HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv2HPResult.Text = "+" + _rng.d10();
            this.Lv2HPRoller.Enabled = false;
        }
        private void Lv3HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv3HPResult.Text = "+" + _rng.d10();
            this.Lv3HPRoller.Enabled = false;
        }
        private void Lv4HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv4HPResult.Text = "+" + _rng.d10();
            this.Lv4HPRoller.Enabled = false;
        }
        private void Lv5HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv5HPResult.Text = "+" + _rng.d10();
            this.Lv5HPRoller.Enabled = false;
        }
        private void Lv6HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv6HPResult.Text = "+" + _rng.d10();
            this.Lv6HPRoller.Enabled = false;
        }
        private void Lv7HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv7HPResult.Text = "+" + _rng.d10();
            this.Lv7HPRoller.Enabled = false;
        }
        private void Lv8HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv8HPResult.Text = "+" + _rng.d10();
            this.Lv8HPRoller.Enabled = false;
        }
        private void Lv9HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv9HPResult.Text = "+" + _rng.d10();
            this.Lv9HPRoller.Enabled = false;
        }
        private void Lv10HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv10HPResult.Text = "+" + _rng.d10();
            this.Lv10HPRoller.Enabled = false;
        }
        private void Lv11HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv11HPResult.Text = "+" + _rng.d10();
            this.Lv11HPRoller.Enabled = false;
        }
        private void Lv12HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv12HPResult.Text = "+" + _rng.d10();
            this.Lv12HPRoller.Enabled = false;
        }
        private void Lv13HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv13HPResult.Text = "+" + _rng.d10();
            this.Lv13HPRoller.Enabled = false;
        }
        private void Lv14HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv14HPResult.Text = "+" + _rng.d10();
            this.Lv14HPRoller.Enabled = false;
        }
        private void Lv15HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv15HPResult.Text = "+" + _rng.d10();
            this.Lv15HPRoller.Enabled = false;
        }
        private void Lv16HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv16HPResult.Text = "+" + _rng.d10();
            this.Lv16HPRoller.Enabled = false;
        }
        private void Lv17HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv17HPResult.Text = "+" + _rng.d10();
            this.Lv17HPRoller.Enabled = false;
        }
        private void Lv18HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv18HPResult.Text = "+" + _rng.d10();
            this.Lv18HPRoller.Enabled = false;
        }
        private void Lv19HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv19HPResult.Text = "+" + _rng.d10();
            this.Lv19HPRoller.Enabled = false;
        }
        private void Lv20HPRoller_Click(object sender, EventArgs e)
        {
            this.Lv20HPResult.Text = "+" + _rng.d10();
            this.Lv20HPRoller.Enabled = false;
        }

        private void RaceSelector_DropDownClosed(object sender, EventArgs e)
        {
            SubraceSelector.Items.Clear();
            switch (RaceSelector.Text)
            {
                case "Dwarf":
                    SubraceSelector.Enabled = true;
                    SubraceSelector.Items.Add("Hill Dwarf");
                    SubraceSelector.Items.Add("Mountain Dwarf");
                    break;
                case "Elf":
                    SubraceSelector.Enabled = true;
                    SubraceSelector.Items.Add("High Elf");
                    SubraceSelector.Items.Add("Wood Elf");
                    SubraceSelector.Items.Add("Dark Elf");
                    break;
                case "Halfling":
                    SubraceSelector.Enabled = true;
                    SubraceSelector.Items.Add("Lightfoot Halfling");
                    SubraceSelector.Items.Add("Stout Halfling");
                    break;
                case "Gnome":
                    SubraceSelector.Enabled = true;
                    SubraceSelector.Items.Add("Forest Gnome");
                    SubraceSelector.Items.Add("Rock Gnome");
                    break;
                default:
                    SubraceSelector.Enabled = false;
                    break;
            }
        }

        private void NameButton_Click(object sender, EventArgs e)
        {
            FirstNameBox.Text = "RandomFirstName";
            LastNameBox.Text = "RandomLastName";
        }
    }
}
