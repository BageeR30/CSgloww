using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
            if (checkBoxGlow.Checked)
            {
                checkBoxGlow.ForeColor = SystemColors.Highlight;
            }
            else
            {
                checkBoxGlow.ForeColor = Color.White;
            }
        }

        

        private void checkBoxTrigger_CheckedChanged(object sender, EventArgs e)
        {
            Program.checkBoxTrigger = checkBoxTrigger.Checked;
            if (checkBoxTrigger.Checked)
            {
                checkBoxTrigger.ForeColor = SystemColors.Highlight;
            }
            else
            {
                checkBoxTrigger.ForeColor = Color.White;
            }
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
            if (checkBoxBHop.Checked)
            {
                checkBoxBHop.ForeColor = SystemColors.Highlight;
            }
            else
            {
                checkBoxBHop.ForeColor = Color.White;
            }
        }

        private void checkBoxOnlyEnemy_CheckedChanged(object sender, EventArgs e)
        {
            Program.checkBoxOnlyEnemy = checkBoxOnlyEnemy.Checked;
            if (checkBoxOnlyEnemy.Checked)
            {
                checkBoxOnlyEnemy.ForeColor = SystemColors.Highlight;
            }
            else
            {
                checkBoxOnlyEnemy.ForeColor = Color.White;
            }
        }

        private void checkBoxSpotted_CheckedChanged(object sender, EventArgs e)
        {
            Program.checkBoxSpotted = checkBoxSpotted.Checked;
            if (checkBoxSpotted.Checked)
            {
                checkBoxSpotted.ForeColor = SystemColors.Highlight;
            }
            else
            {
                checkBoxSpotted.ForeColor = Color.White;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            Program.GlowStruct ally = new Program.GlowStruct();
            ally.a = (float)numericUpDownAlly.Value / 100;
            Program.ally.a = ally.a;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Program.GlowStruct ally = new Program.GlowStruct();
            ally.a = (float)numericUpDownAlly.Value / 100;
            Program.ally.a = ally.a;

            Program.GlowStruct enemy = new Program.GlowStruct();
            enemy.a = (float)numericUpDownEnemy.Value / 100;
            Program.enemy.a = enemy.a;
        }

        private void numericUpDownEnemy_ValueChanged(object sender, EventArgs e)
        {
            Program.GlowStruct enemy = new Program.GlowStruct();
            enemy.a = (float)numericUpDownEnemy.Value / 100;
            Program.enemy.a = enemy.a;
        }

        private void checkBoxConsole_CheckedChanged(object sender, EventArgs e)
        {
            var handle = Program.GetConsoleWindow();

            if (checkBoxConsole.Checked)
            {
                // Show
                Program.ShowWindow(handle, Program.SW_SHOW);
            }
            else
            {
                // Hide
                Program.ShowWindow(handle, Program.SW_HIDE);
            }


           

            
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
