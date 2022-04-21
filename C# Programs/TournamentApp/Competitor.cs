using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentApp
{
    public class Competitor
    {
        //Create properties with gets and sets

        public String Name { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Byes { get; set; }
        public bool PreviousParticipant { get; set; }
        public bool LastMatch { get; set; }
        public String Record { get; set; }

        //Constructor

        public Competitor(String argName)
        {
            Name = argName;
        }

        //Methods

        public override String ToString()
        {
            String outPut = $"{Name} Wins: {Wins} Losses: {Losses} Byes: {Byes}";
            return outPut;
        }


    }
}
