using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanSweepstakes
{
    class Sweepstakes
    {
        public int winner;
        Dictionary<int, Contestant> dictionary = new Dictionary<int, Contestant>();
        

        public int registrationNumber { get; set; }
        public Sweepstakes(string name)
        {
            registrationNumber = 1;
        }

        public void RegisterContestant()
        {
            Contestant contestant = new Contestant();
            contestant.registrationNumber = registrationNumber;
            UI.GetUserFirstName(contestant);
            UI.GetUserLastName(contestant);
            UI.GetUserEmailAddress(contestant);
            dictionary.Add(registrationNumber, contestant);
            registrationNumber++;
        }

        //public int PickWinner()
        //{
        //    Random random = new Random();
        //    public int winner = random.Next(1, ContestantDictionary.Count);
        //    return winner;
        //}

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
