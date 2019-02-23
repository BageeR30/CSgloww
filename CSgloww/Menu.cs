using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSgloww
{
    public partial class Menu : Form
    {
        FormESP frm = new FormESP();
        public Menu()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Program.checkBoxGlow = checkBoxGlow.Checked;
        }

        

        private void checkBoxTrigger_CheckedChanged(object sender, EventArgs e)
        {
            Program.checkBoxTrigger = checkBoxTrigger.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxESP.Checked)
            {
                frm.Show();
            }
            else
            {
                frm.Hide();
                
            }
        }

        private void checkBoxBHop_CheckedChanged(object sender, EventArgs e)
        {
            Program.checkBoxBHop = checkBoxBHop.Checked;
        }

        private void checkBoxOnlyEnemy_CheckedChanged(object sender, EventArgs e)
        {
            Program.checkBoxOnlyEnemy = checkBoxOnlyEnemy.Checked;
        }

        private void checkBoxSpotted_CheckedChanged(object sender, EventArgs e)
        {
            Program.checkBoxSpotted = checkBoxSpotted.Checked;
        }
    }
}
