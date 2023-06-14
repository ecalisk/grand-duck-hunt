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

//#define MULTIPLESEEDS
//#define INCOMPLETEFEATURES

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project_2
{
    public partial class Form2 : Form
    {

        int points = 0;
        public int seconds = 60;
        public int difficulity;
        int timeSpent = 0;

        //USING RANDOM CLASS
        Random rand = new Random();

        //DISPLAY USERNAME FROM FORM1, CALCULATE START TIME BASED ON DIFFICULTY SETTING FROM FORM1 
        public Form2(string username, int difficultyIndex)
        {
            InitializeComponent();
            greet.Text = username;
            seconds = 60 / difficultyIndex;
            difficulity = difficultyIndex;
            timer1.Start();
            timer2.Start();
        }

        //MAIN LOOP OF THE GAME, RANDOMLY SPAWNS VARIOUS DUCKS
        private void timer1_Tick(object sender, EventArgs e)
        {
            peasant75.Visible = false;
            commoner75.Visible = false;
            duke75.Visible = false;
            count50.Visible = false;
            baron50.Visible = false;

            luckMec(25, 65, 85, 95, 100); // HARDCODED chances: peasant 25%, commoner 40%, duke 20%, count 10%, baron 5%

#if MULTIPLESEEDS //SUPPORTS POSSIBILITY OF MULTIPLE DUCKS AT ONCE FOR MAX GAMEPLAY, BUT FIRST DUCK CLASH NEED TO BE AVOIDED (todo)
            luckMec(0, 0, 10, 20, 30);
            luckMec(0, 0, 5, 0, 0);
            luckMec(0, 0, 0, 3, 0);
            luckMec(0, 0, 0, 0, 1);
#endif

            time.Text = seconds.ToString(); //UPDATE TIME BECAUSE THERE CAN BE NEW SEC PENALTY OR REWARD
            score.Text = points.ToString(); //UPDATE SCORE BECAUSE THERE CAN BE NEW POINT PENALTY OR REWARD
            updateStage(points); //UPDATE SIZE OF CANVAS ACCORDINGLY TO THE CURRENT SCORE
        }


        //SPAWNS A DUCK OF DESIRED NOBILITY ON A RANDOM LOCATION
        void duckSpawn(int nobility)
        {
            int x = rand.Next(80, this.Width - 100);
            int y = rand.Next(0, this.Height - 100);

            switch (nobility)
            {
                case 0:
                    peasant75.Visible = true;
                    peasant75.Location = new Point(x, y);
                    break;
                case 1:
                    commoner75.Visible = true;
                    commoner75.Location = new Point(x, y);
                    break;
                case 2:
                    duke75.Visible = true;
                    duke75.Location = new Point(x, y);
                    break;
                case 3:
                    count50.Visible = true;
                    count50.Location = new Point(x, y);
                    break;
                case 4:
                    baron50.Visible = true;
                    baron50.Location = new Point(x, y);
                    break;
                default:
                    break;
            }
        }

        //SEEDING MECHANISM, DEFINE PROBABILITIES (RARITY ~ NOBILITY) AND IT WILL DO THE JOB
        void luckMec(int a, int b, int c, int d, int e)
        {
            int x = rand.Next(0, 100);
            if (x < a)
            {
                duckSpawn(0); //PEASANT
            }
            else if (x < b)
            {
                duckSpawn(1); //COMMONER
            }
            else if (x < c)
            {
                duckSpawn(2); //DUKE
            }
            else if (x < d)
            {
                duckSpawn(3); //COUNT
            }
            else if (x < e)
            {
                duckSpawn(4); //BARON
            }
            else
            {
                //NO SPAWN
            }
        }

        //TO CHECK IF THE TIME IS OVER, INITIATE END GAME FORM
        void gameOver(int seconds, int points)
        {
            if (seconds == 0 || seconds == -1 || seconds == -2) //extensive tests showed that sometimes counter can be -1 or -2 without being 0 first, due point penalties on certain ducks
            {
                timer2.Stop();
                timer1.Stop();
                this.Hide();
                string score = points.ToString();
                string time = timeSpent.ToString();
                end f2 = new end(score, time, difficulity);
                f2.ShowDialog();
                this.Close();
                timer2.Stop();
            }
        }

        //EVALUATES THE CURRENT SCORE TO DECIDE WHAT SHOULD BE THE CURRENT CANVAS SIZE; 5 DIFFERENT SIZES ALL WITH SAME RATIO 4:3
        void updateStage(int score)
        {
            if (score < 10)
            {
                this.Width = 400;
                this.Height = 300;
            }
            else if (score < 20)
            {
                this.Width = 600;
                this.Height = 337;
            }
            else if (score < 30)
            {
                this.Width = 700;
                this.Height = 393;
            }
            else if (score < 40)
            {
                this.Width = 800;
                this.Height = 450;
            }
            else
            {
                this.Width = 900;
                this.Height = 506;
            }
        }

        //TIME UPDATER, OVERALL SPENT TIME CALCULATOR, GAME OVER CHECKER
        private void timer2_Tick(object sender, EventArgs e)
        {
            seconds -= 1;
            time.Text = seconds.ToString(); //UPDATE TIME BECAUSE 1 SEC HAS PASSED
            gameOver(seconds, points); //CHECK IF GAME IS OVER
            timeSpent += 1;
        }

        //MEANT TO EXIT TO MENU BUT INCOMPLETE (todo)
#if INCOMPLETEFEATURES
        private void exitMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
            this.Close();
        }
#endif

        //QUITS THE GAME AT ONCE UPON CLICK
        private void exitDesktop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //recognize and evaluate hit, give rewards and penalties
        private void hit(object sender, EventArgs e)
        {
            PictureBox duck = (PictureBox)sender;
            points += registerPoints(duck.Name);
            seconds += registerTime(duck.Name);
        }

        //DICTIONARY OF HOW MANY POINT(S) ADDED/REMOVED BY EACH NOBILITY CLASS
        int registerPoints(string duckName)
        {
            switch (duckName)
            {
                case "peasant75":
                    return 3;

                case "commoner75":
                    return 1;

                case "duke75":
                    return 0;

                case "count50":
                    return -1;

                case "baron50":
                    return -2;

                default:
                    return 0;
            }
        }

        //DICTIONARY OF HOW MUCH TIME ADDED/REMOVED BY EACH NOBILITY CLASS
        int registerTime(string duckName)
        {
            switch (duckName)
            {
                case "peasant75":
                    return -1;

                case "commoner75":
                    return 0;

                case "duke75":
                    return 2;

                case "count50":
                    return 3;

                case "baron50":
                    return 4;

                default:
                    return 0;
            }
        }
    }
}
