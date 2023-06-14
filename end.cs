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

#define INCOMPLETEFEATURES

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_2
{
    public partial class end : Form
    {
        //RETRIVE RELEVANT INFORMATION AND DISPLAY; DIFFICULTY, SCORE, TIME SPENT
        public end(string score, string time, int difficulty)
        {
            InitializeComponent();
            scoredPointsL.Text = score;
            timeSpentL.Text = time;
            difficultyL.Text = analyzeIndex(difficulty);

            timer1.Start();
            timer2.Start();
        }

        //TO ADD SIMPLE BLINKING EFFECT TO GAME OVER TEXT
        private void timer1_Tick(object sender, EventArgs e)
        {
            over.Visible = false;
        }

        //TO ADD SIMPLE BLINKING EFFECT TO GAME OVER TEXT
        private void timer2_Tick(object sender, EventArgs e)
        {
            over.Visible = true;
        }

        //QUITS THE GAME AT ONCE
        private void exitdesktop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //EXITS TO MENU, INCOMPLETE FEATURE (todo)
#if INCOMPLETEFEATURES
        private void exitMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();

        }
#endif

        //CONVERT DIFFICULTY RATIO BACK TO DIFFICULTY DESCRIPTION FOR DISPLAY
        string analyzeIndex(int a) 
        {
            if (a == 3) 
            {
                return "doom";
            }
            else if (a == 2) 
            {
                return "grueling";
            }
            else 
            {
                return "harsh";
            }
        }
    }
}
