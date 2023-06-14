/* - - - - * 
 March 2021, OOP Project 2
 * - - - - *
 Team: noble rubber duckies
 * - - - - * 
 Members:
 Emirhan Caliskan (56140)
 Nattawat Srisuriyaprateep (55499)
 * - - - - *
 Simple mole bash derivative game.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int difficultyIndex;

        //REGISTERS SETTINGS; NAME AND DIFFICULTY; AND INITIATES THE GAME ON FORM 2
        private void playClick(object sender, EventArgs e)
        {
            recognizeDifficulty();
            this.Hide();
            Form2 f2 = new Form2(playername.Text, difficultyIndex);
            f2.ShowDialog();
            this.Close();
        }

        //QUITS THE GAME AT ONCE
        private void exitClick(object sender, EventArgs e)
        {
            this.Close();
        }

        //INITIATES HELP FORM WHICH PROVIDES THE PLAYER WITH USEFUL INFORMATION
        private void helpClick(object sender, EventArgs e)
        {
            this.Hide();
            help h = new help();
            h.ShowDialog();
            this.Close();
        }

        private void authors_Click(object sender, EventArgs e)
        {
            blinker();
        }

        // blinking colorful text effect for "DEVELOPED BY: ..." text, activated after a click
        private async void blinker()
        {
            while (true)
            {
                await Task.Delay(500);
                authors.BackColor = authors.BackColor == Color.Red ? Color.Green : Color.Red;
            }
        }

        //INTERPRETING WHICH RADIO BUTTON CORRESPONDS TO WHAT SETTING
        void recognizeDifficulty()
        {
            if (doomRadioB.Checked == true) 
            {
                difficultyIndex = 3;
            }
            else if (gruelingRadioB.Checked == true) 
            {
                difficultyIndex = 2;
            }
            else 
            {
                difficultyIndex = 1;
            }
        }
    }
}
