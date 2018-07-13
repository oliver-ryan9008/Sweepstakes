using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanSweepstakes
{
    public static class UI
    {

        public static void GetUserFirstName(Contestant contestant)
        {
            Console.WriteLine("Please enter your first name.");
            contestant.firstName = Console.ReadLine().ToString();
        }

        public static void GetUserLastName(Contestant contestant)
        {
            Console.Clear();
            Console.WriteLine("Please enter your last name.");
            contestant.lastName = Console.ReadLine().ToString();
        }
        public static void GetUserEmailAddress(Contestant contestant)
        {
            Console.Clear();
            Console.WriteLine("Please enter your email address.");
            contestant.emailAddress = Console.ReadLine().ToString();
        }

        public static void DisplayWinner(Contestant contestant)
        {
            Console.Clear();
            Console.WriteLine(contestant.firstName + " " + contestant.lastName + " at email address " + contestant.emailAddress + " is the winner!");
            Console.ReadKey();
        }

        public static void CheckAnswers(Contestant contestant)
        {
            Console.WriteLine("You have entered \n" + contestant.firstName + "\n" + contestant.lastName + "\n" + contestant.emailAddress + "\n" + "Is that correct? Enter yes or no.");
            string answer = Console.ReadLine().ToString().ToLower();
            if (answer != "yes")
            {
                Console.Clear();
                GetUserFirstName(contestant);
                GetUserLastName(contestant);
                GetUserEmailAddress(contestant);
            }
        }


    }
}
