using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace TournamentApp
{

    public partial class Form1 : Form
    {
        //Declare the initial, winners, losers, and eliminated brackets as lists of competitors

        List<Competitor> initial = new List<Competitor>();
        List<Competitor> winners = new List<Competitor>();
        List<Competitor> losers = new List<Competitor>();
        List<Competitor> eliminated = new List<Competitor>();
        List<Competitor> temp = new List<Competitor>();
      

        //Declare global variables

        Random bracketPicker = new Random();

        public static Competitor comp1;
        public static Competitor comp2;
        int round = 0;

        public Form1()
        {
            InitializeComponent();

            //Disable results buttons until the bracket has been run

            displayByWinsBtn.Enabled = false;
            displayOrderElimBtn.Enabled = false;
        }

        //Method for resetting previous participant after each round
        public void ResetParticipant()
        {
            foreach (Competitor comp in winners)
            {
                comp.PreviousParticipant = false;
            }

            foreach (Competitor comp in losers)
            {
                comp.PreviousParticipant = false;
            }
        }

        //Method for determining winners and losers before integration with the scorekeeping app
        public void Match(Competitor argComp1, Competitor argComp2)
        {
            //Flip a coin and determine winners based on it. 0 is a win 1 is a loss

            Random coinFlip = new Random();

            //Set previous partipant and last match values

            argComp1.PreviousParticipant = true;
            argComp1.LastMatch = true;
            argComp2.PreviousParticipant = true;
            argComp2.LastMatch = true;

            if (coinFlip.Next(2) == 0)
            {
                argComp1.Wins++;
                argComp2.Losses++;

                winners.Add(argComp1);

                if (argComp2.Losses > 1)
                {
                    eliminated.Add(argComp2);
                }
                else
                {
                    losers.Add(argComp2);
                }
            }
            else
            {
                argComp2.Wins++;
                argComp1.Losses++;

                winners.Add(argComp2);

                if (argComp1.Losses > 1)
                {
                    eliminated.Add(argComp1);
                }
                else
                {
                    losers.Add(argComp1);
                }
            }

        }

        //Method to reset lastMatch status

        public void ResetLastMatch(List<Competitor> argBracket)
        {
            foreach (Competitor remainingComp in argBracket)
            {
                remainingComp.LastMatch = false;
            }
        }

        //Method to randomly pick a player from a bracket

        public Competitor PickPlayer(List<Competitor> argBracket)
        {
            int compPick = bracketPicker.Next(argBracket.Count);
            Competitor comp = argBracket[compPick];
            argBracket.RemoveAt(compPick);
            return comp;
        }

        //Method for running through a bracket

        public void RunBracket(List<Competitor> argBracket)
        {
            int numNonPreviousParts = 0;

            foreach (Competitor comp in argBracket)
            {
                if (comp.PreviousParticipant == false)
                {
                    numNonPreviousParts++;
                }
            }

            //Logic for rounds 2 and on

            bool comp1Check = false;
            bool comp2Check = false;

            //Conduct all the matches in a bracket

            //Loop through bracket and determine winners
            if (numNonPreviousParts >= 2)
            {
                if (numNonPreviousParts >= 4)
                {
                    for (int i = 0; i < argBracket.Count; i++)
                    {
                        if (argBracket[i].LastMatch == true)
                        {
                            temp.Add(argBracket[i]);
                            argBracket.RemoveAt(i);
                        }
                    }
                }

                while (argBracket.Count >= 1 && comp1Check == false)
                {

                    comp1 = PickPlayer(argBracket);

                    //check to see is last match if last match or previous participant is true.
                    //If initial bracket is 3 or less don't check last match status because it won't be possible to avoid last matches then


                    if (comp1.PreviousParticipant == false)
                    {
                        comp1Check = true;

                    }
                    else
                    {

                        //If a bad competitor is picked add them into a temporary bracket to remove them from the pool
                        temp.Add(comp1);

                    }
                }

                while (argBracket.Count >= 1 && comp2Check == false)
                {

                    comp2 = PickPlayer(argBracket);

                    if (comp2.PreviousParticipant == false)
                    {
                        comp2Check = true;

                    }
                    else
                    {
                        temp.Add(comp2);
                    }
                }

                for (int j = 0; j < temp.Count; j++)
                {

                    argBracket.Add(temp[j]);
                }

                temp.Clear();

                ResetLastMatch(argBracket);

                var f2 = new Form2();

                f2.ShowDialog();

                //import data from timer form

                List<Competitor> importedWinners = Form2.localWinners;
                List<Competitor> importedLosers = Form2.localLosers;
                List<Competitor> importedEliminated = Form2.localEliminated;

                ImportData(importedWinners, winners);
                ImportData(importedLosers, losers);
                ImportData(importedEliminated, eliminated);

            }

        }

        //Method for importing data from timer form

        public void ImportData(List<Competitor> argBracket1, List<Competitor> argBracket2)
        {
            for(int i = 0; i < argBracket1.Count; i++)
            {
                argBracket2.Add(argBracket1[i]);
            }

            argBracket1.Clear();
        }

        //Method for displaying output

        public void DisplayOutput(List<Competitor> argBracket)
        {
            //Loop through list and use modulo to produce the correct grammar

            String output = "\n";

            for (int i = 0; i < argBracket.Count; i++)
            {
                if (i < 10 && i % 10 == 0)
                {
                    output += $"{i + 1}st Place: {argBracket[i].ToString()} \n";
                }
                else if (i < 10 && i % 10 == 1)
                {
                    output += $"{i + 1}nd Place: {argBracket[i].ToString()} \n";
                }
                else if (i < 10 && i % 10 == 2)
                {
                    output += $"{i + 1}rd Place: {argBracket[i].ToString()} \n";
                }
                else if (i > 19 && i % 10 == 0)
                {
                    output += $"{i + 1}st Place: {argBracket[i].ToString()} \n";
                }
                else if (i > 19 && i % 10 == 1)
                {
                    output += $"{i + 1}nd Place: {argBracket[i].ToString()} \n";
                }
                else if (i > 19 && i % 10 == 2)
                {
                    output += $"{i + 1}rd Place: {argBracket[i].ToString()} \n";
                }
                else
                {
                    output += $"{i + 1}th Place: {argBracket[i].ToString()} \n";
                }
            }

            output += $" After {round} rounds Winners: {winners.Count} Eliminated: {eliminated.Count - 1}";
            testLbl.Text = output;
        }

        private void addCompBtn_Click(object sender, EventArgs e)
        {
            String competitorName;

            if (nameTxt.Text.ToString() == "")
            {
                MessageBox.Show("Competitor Name cannot be blank. Please enter a valid name");
            }
            else
            {
                competitorName = nameTxt.Text.ToString();
                Competitor newComp = new Competitor(competitorName);
                initial.Add(newComp);

                String output = "";

                for (int i = 0; i < initial.Count; i++)
                {

                    output = output + "Player " + (i + 1) + ": " + initial[i].ToString() + "\n";

                }

                testLbl.Text = output;
                nameTxt.Text = "";
            }

        }

        private void startBracketBtn_Click(object sender, EventArgs e)
        {

            addCompBtn.Enabled = false;

            if (initial.Count > 1)
            {
                int startingBracket = initial.Count - 1;


                //Check to see if there is an odd number of competitors in the initial bracket. If so randomly remove one and add them to the winners bracket. 
                //This simulates a bye

                if (initial.Count % 2 != 0)
                {
                    int currentPick = bracketPicker.Next(initial.Count);
                    initial[currentPick].Byes++;
                    winners.Add(initial[currentPick]);
                    initial.RemoveAt(currentPick);
                }

                //Go through initial bracket grabbing two competitors at random and adding them to a match

                while (initial.Count > 0)
                {
                    //Grab first player at random assign them to competitor 1 and remove them from the initial bracket

                    comp1 = PickPlayer(initial);

                    //Grab second player at random assign them to competitor 2 and remove them from the initial bracket

                    comp2 = PickPlayer(initial);

                    //Now that competitors have been selected and the match is about to occur reset previous participant for everyone left in the bracket

                    if(initial.Count > 0)
                    {
                        ResetLastMatch(initial);
                    }
                    //Add players to Match function

                    var f2 = new Form2();

                    f2.ShowDialog();

                    //import data from timer form

                    List<Competitor> importedWinners = Form2.localWinners;
                    List<Competitor> importedLosers = Form2.localLosers;
                    
                    ImportData(importedWinners, winners);
                    ImportData(importedLosers, losers);

                }

                round++;


                //Reset previous participant status

                ResetParticipant();

                //Run through brackets until all but one competitor is eliminated


                while (eliminated.Count != startingBracket)
                {

                    //if the losers bracket is odd then one is selected at random to get a bye and move into the winners bracket
                    //If the winners bracket they will be placed into is even they will not have a match this round but if it is odd then they will have a match
                    // This ensures the least amount of byes possible

                    if (losers.Count % 2 != 0)
                    {
                        int currentPick = bracketPicker.Next(losers.Count);

                        if (winners.Count % 2 == 0)
                        {
                            losers[currentPick].PreviousParticipant = true;
                            losers[currentPick].Byes++;
                        }

                        winners.Add(losers[currentPick]);
                        losers.RemoveAt(currentPick);
                    }

                    if (losers.Count != 0)
                    {
                        RunBracket(losers);
                    }

                    RunBracket(winners);

                    round++;

                    ResetParticipant();
                }

                //Add the final winner to the eliminated bracket. This makes constructing the results output string with proper grammar easier

                eliminated.Add(winners[0]);

                //Reverse list and use index as each competitors place this needs to be done out side of the results button so that it isn't reveresed every time it's clicked

                eliminated.Reverse();

                //Enable display results buttons

                displayOrderElimBtn.Enabled = true;
                displayByWinsBtn.Enabled = true;
            }

            else
            {
                //Return buttons to pre bracket start states

                displayByWinsBtn.Enabled = false;
                displayOrderElimBtn.Enabled = false;
                addCompBtn.Enabled = true;

                MessageBox.Show("You must enter at least two competitors to start the bracket");


            }
        }

        private void displayOrderElimBtn_Click(object sender, EventArgs e)
        {


            List<Competitor> listByOrderElim = eliminated;

            //Display the results

            testLbl.Text = "Rankings by order of elimination:";

            DisplayOutput(listByOrderElim);

        }

        private void displayByWinsBtn_Click(object sender, EventArgs e)
        {

            //Order by most wins

            List<Competitor> listByWins = eliminated.OrderByDescending(o => o.Wins).ToList();

            //Show results by wins

            testLbl.Text = "Rankings by number of wins:";

            DisplayOutput(listByWins);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //Empty all brackets

            winners.Clear();
            losers.Clear();
            temp.Clear();
            eliminated.Clear();
            initial.Clear();

            //reset round counter

            round = 0;

            //disable the results buttons

            displayByWinsBtn.Enabled = false;
            displayOrderElimBtn.Enabled = false;
            addCompBtn.Enabled = true;

            //Clear display

            testLbl.Text = "";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bring up a browser to select a file

            string file = "";

            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = @"c:\";
            fdlg.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                file = fdlg.FileName;
            }

            _Application excel = new Excel.Application();
            Workbook wb;
            Worksheet ws;
            

            wb = excel.Workbooks.Open(file);
            ws = wb.Worksheets[1];
            int range = ws.UsedRange.Rows.Count;
            String cellValue = "";

            for (int i = 0; i < range; i++)
            {
                cellValue = (string)(ws.Cells[i +1 , 1] as Excel.Range).Value;
                Competitor newComp1 = new Competitor(cellValue);
                initial.Add(newComp1);
            }

            String output = "";

            for (int i = 0; i < initial.Count; i++)
            {

                output = output + "Player " + (i + 1) + ": " + initial[i].ToString() + "\n";

            }

            testLbl.Text = output;

        }
    }
}

