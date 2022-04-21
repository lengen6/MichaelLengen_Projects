using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TournamentApp
{
    public partial class Form2 : Form
    {

        public Form2()
        {
          
            InitializeComponent();
           
        }

        //Declare variables

        private int totalSeconds;
        bool isPaused;
        int player1Score;
        int player2Score;

        //Import variables form list one

        public static List<Competitor> localLosers = new List<Competitor>();
        public static List<Competitor> localWinners = new List<Competitor>();
        public static List<Competitor> localEliminated = new List<Competitor>();
        Competitor localComp1 = Form1.comp1;
        Competitor localComp2 = Form1.comp2;

        // for later use

        //Mark participation status

        public void StopMatch()
        {
            timer1.Stop();
            countDownLbl.Text = "00:00";
            totalSeconds = 0;
            isPaused = false;
            pauseBtn.Enabled = false;
            stopBtn.Enabled = false;
            p1SubBtn.Enabled = false;
            p1DqBtn.Enabled = false;
            p2SubBtn.Enabled = false;
            p2DqBtn.Enabled = false;
            p1IncreaseBtn.Enabled = false;
            p1DecreaseBtn.Enabled = false;
            p2IncreaseButton.Enabled = false;
            p2DecreaseBtn.Enabled = false;
            player1Score = 0;
            player2Score = 0;
            player1PtsResult.Text = "0";
            player2PtsResultLbl.Text = "0";
        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
           
            //Import player names

            player1Lbl.Text = localComp1.Name.ToString();
            player2Lbl.Text = localComp2.Name.ToString();

            //populate dropdown boxes for time selection

            for (int i = 0; i < 60; i++)
            {
                minutesDropbox.Items.Add(i.ToString());
                secondsDropbox.Items.Add(i.ToString());
            }

            minutesDropbox.SelectedIndex = 5;
            secondsDropbox.SelectedIndex = 00;

            //Enable and disable relevant buttons

            StopMatch();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //Mark participation status

            localComp1.PreviousParticipant = true;
            localComp1.LastMatch = true;
            localComp2.PreviousParticipant = true;
            localComp2.LastMatch = true;

            //Disable Start button and enable others

            startBtn.Enabled = false;
            pauseBtn.Enabled = true;
            stopBtn.Enabled = true;
            p1SubBtn.Enabled = true;
            p1DqBtn.Enabled = true;
            p2SubBtn.Enabled = true;
            p2DqBtn.Enabled = true;
            p1IncreaseBtn.Enabled = true;
            p1DecreaseBtn.Enabled = true;
            p2IncreaseButton.Enabled = true;
            p2DecreaseBtn.Enabled = true;

            //Enable timer

            timer1.Enabled = true;

            if (isPaused == true)
            {
                timer1.Start();
                isPaused = false;
            }
            else
            {
                try
                {
                    //Get minutes and seconds from the dropdown boxes

                    int minutes = int.Parse(minutesDropbox.SelectedItem.ToString());
                    int seconds = int.Parse(secondsDropbox.SelectedItem.ToString());

                    totalSeconds = (minutes * 60) + seconds;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {

            //Disable pause button and enable other two

            pauseBtn.Enabled = false;
            startBtn.Enabled = true;
            stopBtn.Enabled = true;

            //Disable timer

            timer1.Enabled = false;

            //set paused flag to control the behavior of the start button
            isPaused = true;
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            //Disable stop and pause buttons and renable start button

            pauseBtn.Enabled = false;
            startBtn.Enabled = true;

            //Stop timer and initially treat as a pause in case score is tied

            timer1.Stop();
            isPaused = true;

            //Check to see if score is tied

            if (player1Score == player2Score)
            {
                MessageBox.Show("Match cannot result in a tie. Please resume match or declare a winner via submission, advantage, or DQ");
                startBtn.Enabled = true;
            }
            else
            {
                //If match result is valid (not a tie) conduct stopping behavior

                //Determine and declare winner

                if (player1Score > player2Score)
                {
                    //Display the winner

                    MessageBox.Show($"{localComp1.Name.ToString()} wins with a score of {player1Score} to {player2Score}");

                    //Increment wins losses and move to appropriate brackets

                    Player1Wins();
                }
                else
                {
                    
                    //Display the winner

                    MessageBox.Show($"{localComp2.Name.ToString()} wins with a score of {player2Score} to {player1Score}");

                    //Increment wins losses and move to appropriate brackets

                    Player2Wins();
                }

                StopMatch();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds - (minutes * 60);
                if (seconds < 10)
                {
                    countDownLbl.Text = $"{minutes}:0{seconds}";
                }
                else
                {
                    countDownLbl.Text = $"{minutes}:{seconds}";
                }
            }
            else
            {
                //Stop timer before determining winner to prevent logic from executing each tick.

                timer1.Stop();

                //Determine and declare winner

                if (player1Score > player2Score)
                {
                   

                    //Display the winner

                    MessageBox.Show($"{localComp1.Name.ToString()} wins with a score of {player1Score} to {player2Score}");

                    //Increment wins losses and move to appropriate brackets

                    Player1Wins();

                    StopMatch();

                }
                else if (player1Score < player2Score)
                {
                    
                    //Display the winner

                    MessageBox.Show($"{localComp2.Name.ToString()} wins with a score of {player2Score} to {player1Score}");

                    //Increment wins losses and move to appropriate brackets

                    Player2Wins();

                    StopMatch();

                }
                else
                {
                    MessageBox.Show("Match cannot result in a tie. Please decide advantage or enter duration for overtime round and start a new timer");
                    countDownLbl.Text = "00:00";
                    totalSeconds = 0;
                    isPaused = false;
                    startBtn.Enabled = true;
                    pauseBtn.Enabled = false;

                }

            }
        }

        private void p1IncreaseBtn_Click(object sender, EventArgs e)
        {
            player1Score++;
            player1PtsResult.Text = $"{player1Score.ToString()}";
        }

        private void p1DecreaseBtn_Click(object sender, EventArgs e)
        {
            player1Score--;
            player1PtsResult.Text = $"{player1Score.ToString()}";
        }

        private void p2IncreaseButton_Click(object sender, EventArgs e)
        {
            player2Score++;
            player2PtsResultLbl.Text = $"{player2Score.ToString()}";
        }

        private void p2DecreaseBtn_Click(object sender, EventArgs e)
        {
            player2Score--;
            player2PtsResultLbl.Text = $"{player2Score.ToString()}";
        }

        private void p1SubBtn_Click(object sender, EventArgs e)
        {
            //Stop Match behavior

            StopMatch();

            //Increment wins losses and move to appropriate brackets

            Player1Wins();

            //Display winner

            MessageBox.Show( $"{localComp1.Name.ToString()} wins by submission");
        }

        private void p2SubBtn_Click(object sender, EventArgs e)
        {
            //Stop Match behavior

            StopMatch();

            //Increment wins losses and move to appropriate brackets

            Player2Wins();

            //Display winner

            MessageBox.Show($"{localComp2.Name.ToString()} wins by submission");
        }

        private void p1DqBtn_Click(object sender, EventArgs e)
        {
            //Stop match behavior

            StopMatch();

            //Increment wins losses and move to appropriate brackets

            Player2Wins();

            //Display winner

            MessageBox.Show($"{localComp1.Name.ToString()} is Disqualified, {localComp2.Name.ToString()} wins by default");
        }

        private void p2DqBtn_Click(object sender, EventArgs e)
        {

            //Stop Match Behavior

            StopMatch();

            //Increment wins losses and move to appropriate brackets

            Player1Wins();

            //Display winner

            MessageBox.Show($"{localComp2.Name.ToString()} is Disqualified, {localComp1.Name.ToString()} wins by default");
        }


        //Methods for player winning behavior
        public void Player1Wins()
        {

            localComp1.Wins++;
            localComp2.Losses++;

            localWinners.Add(localComp1);

            if (localComp2.Losses > 1)
            {
                localEliminated.Add(localComp2);
            }
            else
            {
                localLosers.Add(localComp2);
            }

            startBtn.Enabled = false;
        }

        public void Player2Wins()
        {
            localComp2.Wins++;
            localComp1.Losses++;

            localWinners.Add(localComp2);

            if (localComp1.Losses > 1)
            {
                localEliminated.Add(localComp1);
            }
            else
            {
                localLosers.Add(localComp1);
            }

            startBtn.Enabled = false;
        }
    }

}
