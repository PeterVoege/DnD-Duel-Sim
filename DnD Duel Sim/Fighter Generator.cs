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
        DiceRoller _rng;
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

        }

        }
    }
}
