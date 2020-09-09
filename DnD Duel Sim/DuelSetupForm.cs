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

        private void button1_Click(object sender, EventArgs e)
        {
            Fighter_Generator fighter1Form = new Fighter_Generator(ref _rng);
            fighter1Form.Show();
        }
    }
}
