using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanSweepstakes
{
    class Sweepstakes
    {
        
        Dictionary<int, Contestant> dictionary = new Dictionary<int, Contestant>();


        public int registrationNumber { get; set; }
        public Sweepstakes()
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
            UI.CheckAnswers(contestant);
            dictionary.Add(registrationNumber, contestant);
            registrationNumber++;
            CheckForMoreContestants(contestant);
        }

        public int PickWinner()
        {
            Random random = new Random();
            int winner = random.Next(1, dictionary.Count);
            if(dictionary.ContainsKey(winner))
            {
                Contestant contestant = dictionary[winner];                
                UI.DisplayWinner(contestant);
            }
            return winner;
        }  
        

        public void PrintContestantInfo(Contestant contestant)
            {

            }

        public void CheckForMoreContestants(Contestant contestant)
        {
            Console.WriteLine("Are there any more contestants to register? Enter yes or no.");
            string addContestant = Console.ReadLine().ToString().ToLower();
            if (addContestant == "yes")
            {
                RegisterContestant();
            }
        }
    }
}
