


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerBallSimulator
{
    public partial class PowerBall_Simulator_MichaelLengen : Form
    {

        private int[] whiteBalls = new int[70];
        private int winningRed = 0;
        private int[] winningWhites = new int[5];
        private int myRed = 0;
        private int[] myWhites = new int[5];
        private long plays = 0;
        private int[] preservedWhites = new int[5];
        private bool winner = false;

        private const int whiteBallHopperCount = 69;

        private const int redBallHopperCount = 26;

        private const int numOfWhiteBallsToBeDrawn = 5;


        Random whiteBallPicker = new Random();
        Random redBallPicker = new Random();

        public PowerBall_Simulator_MichaelLengen()
        {
            InitializeComponent();
        }

        private void powerStart_Click(object sender, EventArgs e)
        {

            //Populate white balls

            for (int i = 0; i < whiteBalls.Length; i++)
            {
                whiteBalls[i] = i;
            }

            //Pull the winning white balls

            for (int i = 0; i < winningWhites.Length; i++)
            {
                bool notAlreadyPicked = false;

                while (notAlreadyPicked == false)
                {
                    int currentBall = whiteBallPicker.Next(1, 70);

                    if (whiteBalls[currentBall] != 0)
                    {
                        winningWhites[i] = currentBall;
                        whiteBalls[currentBall] = 0;
                        notAlreadyPicked = true;
                    }
                }

            }

            //Pick winning red ball

            winningRed = redBallPicker.Next(1, 27);

            //Display winning Red ball

            winningRedLbl.Text = winningRed.ToString();

            //Display the winning white balls in the order they are pulled

            winningPull1.Text = winningWhites[0].ToString();
            winningPull2.Text = winningWhites[1].ToString();
            winningPull3.Text = winningWhites[2].ToString();
            winningPull4.Text = winningWhites[3].ToString();
            winningPull5.Text = winningWhites[4].ToString();

            //Sort winning white balls array for easier comparison

            Array.Sort(winningWhites);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            while (winner == false)
            {
                //Pick winning red ball

                myRed = redBallPicker.Next(1, 27);

                //Only pull white if the red is already a match to save processing power. while this might not be the best representation of the actual game
                // it does save a lot of processing power. To change it to always pull the whites would just require a simple code restructure.

                if (winningRed == myRed)
                {
                    //Populate white balls

                    for (int i = 0; i < whiteBalls.Length; i++)
                    {
                        whiteBalls[i] = i;
                    }

                    //My white pulls

                    for (int i = 0; i < myWhites.Length; i++)
                    {
                        bool notAlreadyPicked = false;

                        while (notAlreadyPicked == false)
                        {
                            int currentBall = whiteBallPicker.Next(1, 70);

                            if (whiteBalls[currentBall] != 0)
                            {
                                myWhites[i] = currentBall;
                                whiteBalls[currentBall] = 0;
                                notAlreadyPicked = true;
                            }
                        }

                    }

                }

                //Preserve original order to display in case of a winner

                preservedWhites = myWhites;

                //Sort white pulls for comparison

                Array.Sort(myWhites);

                //Increment plays counter

                plays++;

                if (winningWhites.SequenceEqual(myWhites))
                {
                    //Display winning balls

                    myPull1.Text = preservedWhites[0].ToString();
                    myPull2.Text = preservedWhites[1].ToString();
                    myPull3.Text = preservedWhites[2].ToString();
                    myPull4.Text = preservedWhites[3].ToString();
                    myPull5.Text = preservedWhites[4].ToString();

                    myRedLbl.Text = myRed.ToString();
                    playsLbl.Text = plays.ToString("N0");

                    winner = true;
                }


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //reset all lables and relevant varialbles.

            myPull1.Text = "";
            myPull2.Text = "";
            myPull3.Text = "";
            myPull4.Text = "";
            myPull5.Text = "";

            myRedLbl.Text = "";
            playsLbl.Text = "";

            winningPull1.Text = "";
            winningPull2.Text = "";
            winningPull3.Text = "";
            winningPull4.Text = "";
            winningPull5.Text = "";

            winningRedLbl.Text = "";

            for(int i = 0; i < winningWhites.Length; i++)
            {
                winningWhites[i] = 0;
            }

            for (int i = 0; i < myWhites.Length; i++)
            {
                myWhites[i] = 0;
            }

            winner = false;
            winningRed = 0;
            myRed = 0;
            plays = 0;
        }

        private void oddsBtn_Click(object sender, EventArgs e)
        {
            int workWhiteBalls = whiteBallHopperCount;
            
            int workRedBalls = redBallHopperCount;

            int workWhiteBallPicks = numOfWhiteBallsToBeDrawn;

            double probabilityOfWinning = 1;

            int oddsOfWinning = 0;

            string s = "The odds of winning the PowerBall jackpot are calculated as follows:\n\n";

            /*  5 out of 69 probability for the first white ball.
                4 out of 68 probability for the second white ball.
                3 out of 67 probability for the third white ball.
                2 out of 66 probability for the fourth white ball.
                1 out of 65 probability for the fifth white ball.

                We multiply each of these probabilities together since
                this is an "and" condition - 5 out of 69 AND 4 out of 68, etc.
            */
            for (int i = workWhiteBallPicks; i >= 1; i--)
            {
                probabilityOfWinning = probabilityOfWinning * ((double)i / (workWhiteBalls - (5 - i)));

                s = s + i + "/" + (workWhiteBalls - (5 - i)) + " * ";
            }

            //Red ball only has one draw, so it is straight probability but we multiply
            //it times the probability calculated above since, again, it is an "and" condition.
            probabilityOfWinning = probabilityOfWinning * ((double)1 / workRedBalls);

            s = s + 1 + "/" + workRedBalls + " = " + probabilityOfWinning.ToString("n20") + "!\n\n";

            //To calculate the odds of winning, take the probability and divide it into 1.
            oddsOfWinning = (int)(1 / probabilityOfWinning);

            s = s + "Or, expressed in odds format, we have 1 chance in every " + oddsOfWinning.ToString("n0") + " draws of picking the winning numbers!!!";

            MessageBox.Show(s,"Odds of Winning",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
