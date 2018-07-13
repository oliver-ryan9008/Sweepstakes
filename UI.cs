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
            Console.WriteLine("You have entered " + contestant.firstName + ". Is that correct? Enter yes or no.");
            string answer = Console.ReadLine().ToString().ToLower();
            if(answer != "yes")
            {
                GetUserFirstName(contestant);
            }
        }

        public static void GetUserLastName(Contestant contestant)
        {
            Console.WriteLine("Please enter your last name.");
            contestant.lastName = Console.ReadLine().ToString();
            Console.WriteLine("You have entered " + contestant.lastName + ". Is that correct? Enter yes or no.");
            string answer = Console.ReadLine().ToString().ToLower();
            if (answer != "yes")
            {
                GetUserLastName(contestant);
            }
        }
        public static void GetUserEmailAddress(Contestant contestant)
        {
            Console.WriteLine("Please enter your email address.");
            contestant.emailAddress = Console.ReadLine().ToString();
            Console.WriteLine("You have entered " + contestant.emailAddress + ". Is that correct? Enter yes or no.");
            string answer = Console.ReadLine().ToString().ToLower();
            if (answer != "yes")
            {
                GetUserEmailAddress(contestant);
            }
        }
    }
}
