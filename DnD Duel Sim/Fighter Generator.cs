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

        }
    }
}
