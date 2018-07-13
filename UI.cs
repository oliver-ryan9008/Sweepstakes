using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RyanSweepstakes
{
    public static class UserInterface
    {

        public static void GetUserFirstName()
        {
            Console.WriteLine("Please enter your first name.");
            string userFirstName = Console.ReadLine().ToString();
        }

        public static void GetUserLastName()
        {
            Console.WriteLine("Please enter your last name.");
            string userLastName = Console.ReadLine().ToString();
        }
        public static void GetUserEmailAddress()
        {
            Console.WriteLine("Please enter your email address.");
            string userEmailAddress = Console.ReadLine().ToString();
        }
    }
}
